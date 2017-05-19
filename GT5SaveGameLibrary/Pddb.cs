using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MiscUtil.Conversion;
using MiscUtil.IO;

namespace GT5SaveGameLibrary
{
    public class Pddb
    {
        private static uint _pddbTableLength;
        private static long _pddbSymbolsOffset;
        private const long PddbEotPadding = 2; //81 F2
        private const decimal SaveFileHeaderMagic = 249;
        private const long PddbFirstItemOffset = 42L;
        private const long PddbStartOffsetReadStart = 33L;
        private const long SaveFileHeaderLength = 32L;

        public Pddb(string savePath)
        {
            SavePath = savePath;
            List0 = new List<int>();
            List1 = new List<int>();
            ItemOffsets = new List<int>();
            PddbItemListNames = new List<string>();
            Extract();
            //ExtractPddb();
        }

        private void Extract()
        {
            var fs = new FileStream(SavePath, FileMode.Open);
            var ebr = new EndianBinaryReader(new BigEndianBitConverter(), fs);
            ebr.BaseStream.Position = SaveFileHeaderLength;

            var dataTypeByte = ebr.ReadByte();
            switch (dataTypeByte)
            {
                case 0x0E: //4bytes
                    _pddbTableLength = ebr.ReadUInt32();
                    _pddbSymbolsOffset = SaveFileHeaderLength + _pddbTableLength + PddbEotPadding;
                    break;
                default:
                    throw new NotImplementedException();
            }

            var pddbObjects = new List<PddbObject>();
            var pddbTablePointer = fs.Position;
            var pddbSymbolPointer = _pddbSymbolsOffset;

            while (true)
            {
                dataTypeByte = ebr.ReadByte();
                object dataValue;
                switch (dataTypeByte)
                {
                    case 0x01: //1bytes
                        dataValue = ebr.ReadByte();
                        break;
                    case 0x02: //2bytes
                        dataValue = ebr.ReadUInt16();
                        break;
                    case 0x03: //4bytes
                        dataValue = ebr.ReadUInt32();
                        break;
                    case 0x04: //8bytes
                        dataValue = ebr.ReadUInt64();
                        break;
                    case 0x05: //4bytes
                        dataValue = ebr.ReadUInt32();
                        break;
                    case 0x07: //
                        var nextByte = ebr.ReadByte();
                        if (nextByte >= 128 && nextByte <= 129)
                        {
                            dataValue = ebr.ReadInt16();
                        }
                        else
                        {
                            dataValue = nextByte;
                        }
                        break;
                    case 0x09: //4bytes //Array
                        dataValue = ebr.ReadUInt32();
                        break;
                    case 0x0E: //4bytes
                        dataValue = ebr.ReadUInt32();
                        break;
                    default:
                        throw new NotImplementedException();
                }

                pddbTablePointer = fs.Position;
                fs.Position = pddbSymbolPointer;

                var nextSymbolLength = ebr.ReadByte();
                var symbolByteArray = new byte[nextSymbolLength];
                fs.Read(symbolByteArray, 0, nextSymbolLength);
                var symbol = System.Text.Encoding.ASCII.GetString(symbolByteArray);

                pddbSymbolPointer = fs.Position;
                fs.Position = pddbTablePointer;

                pddbObjects.Add(new PddbObject(symbol, dataTypeByte, dataValue.GetType(), dataValue, null));

            }
        }

        public string SavePath { get; private set; }

        public static List<int> List1 { get; set; }

        public static List<int> List0 { get; set; }

        public static List<int> ItemOffsets { get; set; }

        public static List<string> PddbItemListNames { get; set; }

        private void ExtractPddb()
        {
            var fs = new FileStream(SavePath, FileMode.Open);
            fs.Position = fs.Position + 3L;
            var saveHeaderMagic = (byte)fs.ReadByte();
            fs.Close();
            if (saveHeaderMagic == SaveFileHeaderMagic)
            {
                GetPddbItemListNames(SavePath);
                ulong creditcap = FindItemInPddb(SavePath, "cash_limit", 8);
                ulong carAvail = FindItemInPddb(SavePath, "car_available", 1);
                ulong courseAvail = FindItemInPddb(SavePath, "course_available", 4);
                ulong aspecWins = FindItemInPddb(SavePath, "total_aspec_win", 4);
                ulong bspecWins = FindItemInPddb(SavePath, "total_bspec_win", 4);
                ulong textBoxUsedCarDay = FindItemInPddb(SavePath, "used_car_visit_day", 4);
                ulong textBoxGamedays = FindItemInPddb(SavePath, "gameday", 8);
                ulong textBoxCredits = FindItemInPddb(SavePath, "cash", 8);
                var comboBoxSpecLeveLa = (int)FindItemInPddb(SavePath, "aspec_lv", 4);
                var comboBoxSpecLevelB = (int)FindItemInPddb(SavePath, "bspec_lv", 4);
                var openSpecialOption = (long)FindItemInPddb(SavePath, "open_special_option", 1);
                var rTextDebug = (long)FindItemInPddb(SavePath, "rtext_debug", 1);
                ulong sqlLiteOffset = FindSqlLiteOffset("SQLite format 3", SavePath);
            }
        }

        private static void GetPddbItemListNames(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                    return;
                var fs = new FileStream(filePath, FileMode.Open);
                var ebr = new EndianBinaryReader(new BigEndianBitConverter(), fs);
                fs.Position = PddbStartOffsetReadStart;
                _pddbTableLength = ebr.ReadUInt32();
                fs.Position = PddbFirstItemOffset;
                _pddbSymbolsOffset = _pddbTableLength + SaveFileHeaderLength;

                byte pdddbDataType = 0;
                var sb = new StringBuilder(string.Empty);
                bool bool0 = false;
                int int0 = 0;
                var byte4 = new byte[5];
                var byte5 = new byte[2];

                while (fs.Position < _pddbSymbolsOffset)
                    ReadPddbValues(fs, pdddbDataType, byte4, byte5, ref sb, ref bool0, ref int0);
                List1 = List0.Distinct().ToList();
                List1.Sort();
                int num2 = 0;
                foreach (int num3 in List1)
                    PddbItemListNames.Add(ReadPddbSymbols(fs, num2++));
                fs.Close();
            }
            catch
            {
            }
        }

        public static ulong FindItemInPddb(string pathPddb, string itemKey, byte itemLengthBytes)
        {
            try
            {
                ulong num1 = 0UL;
                var numArray = new byte[8];
                var fileStream1 = new FileStream(pathPddb, FileMode.Open) { Position = FindOffsetForItem(itemKey) };
                if ((byte)fileStream1.ReadByte() == 7)
                {
                    var num2 = (byte)fileStream1.ReadByte();
                    if (num2 <= sbyte.MaxValue)
                    {
                        FileStream fileStream2 = fileStream1;
                        long num3 = fileStream2.Position + 1L;
                        fileStream2.Position = num3;
                    }
                    else if (num2 == 128 || num2 == 129)
                    {
                        FileStream fileStream2 = fileStream1;
                        long num3 = fileStream2.Position + 2L;
                        fileStream2.Position = num3;
                    }
                    switch (itemLengthBytes)
                    {
                        case 1:
                            fileStream1.Read(numArray, 7, 1);
                            num1 = ReverseEndedness(7U, 7U, numArray);
                            break;
                        case 2:
                            fileStream1.Read(numArray, 6, 2);
                            num1 = ReverseEndedness(6U, 7U, numArray);
                            break;
                        case 4:
                            fileStream1.Read(numArray, 4, 4);
                            num1 = ReverseEndedness(4U, 7U, numArray);
                            break;
                        case 8:
                            fileStream1.Read(numArray, 0, 8);
                            num1 = ReverseEndedness(0U, 7U, numArray);
                            break;
                    }
                }
                fileStream1.Close();
                return num1;
            }
            catch
            {
                return 0UL;
            }
        }

        public static int FindOffsetForItem(string itemName)
        {
            try
            {
                int indexOfItemName = PddbItemListNames.IndexOf(itemName);
                int index2 = List0.IndexOf(List1[indexOfItemName]);
                return ItemOffsets[index2];
            }
            catch
            {
                return 0;
            }
        }

        public static string ReadPddbSymbols(FileStream fs, int value)
        {
            try
            {
                var stringBuilder = new StringBuilder(string.Empty);
                var numArray = new byte[4];
                fs.Position = 33L;
                fs.Read(numArray, 0, 4);
                var num1 = (uint)ReverseEndedness(0U, 3U, numArray);
                fs.Position = num1 + 34U;
                for (int index1 = 0; index1 <= value; ++index1)
                {
                    stringBuilder.Remove(0, stringBuilder.Length);
                    int num2 = fs.ReadByte();
                    for (int index2 = 0; index2 < num2; ++index2)
                        stringBuilder.Append((char)fs.ReadByte());
                }
                return stringBuilder.ToString();
            }
            catch
            {
                return string.Empty;
            }
        }

        public static void ReadPddbValues(FileStream fs, byte pddbDataType, byte[] pddbDataTypeExtended,
            byte[] byte_5, ref StringBuilder sb, ref bool bool_0, ref int int_0)
        {
            try
            {
                pddbDataType = (byte)fs.ReadByte();
                pddbDataTypeExtended[0] = pddbDataType;
                if (pddbDataType != 7)
                    return;
                pddbDataType = (byte)fs.ReadByte();
                pddbDataTypeExtended[1] = pddbDataType;
                if (pddbDataType <= sbyte.MaxValue)
                {
                    ReadPddbValue(fs, pddbDataType, ref pddbDataTypeExtended, ref byte_5, ref sb,
                        ref bool_0, ref int_0, (int)fs.Position - 2);
                }
                else
                {
                    if (pddbDataType != 128 && pddbDataType != 129)
                        return;
                    pddbDataType = (byte)fs.ReadByte();
                    pddbDataTypeExtended[2] = pddbDataType;
                    ReadPddbValue(fs, pddbDataType, ref pddbDataTypeExtended, ref byte_5, ref sb,
                        ref bool_0, ref int_0, (int)fs.Position - 3);
                }
            }
            catch
            {
            }
        }

        public static void ReadPddbValue(FileStream fs, byte pddbDataType,
            ref byte[] byte_4, ref byte[] byte_1, ref StringBuilder sb, ref bool bool_0,
            ref int int_0, int int_1)
        {
            try
            {
                var numArray = new byte[4];
                fs.Read(byte_1, 0, 2);
                FileStream fileStream1 = fs;
                long num2 = fileStream1.Position - 1L;
                fileStream1.Position = num2;
                int_1 = (int)byte_4[1] > (int)sbyte.MaxValue
                    ? (int)fs.Position - 4
                    : (int)fs.Position - 3;
                switch (byte_1[0])
                {
                    case 0:
                        GetPddbItemOffset(ref byte_4, ref byte_1, ref sb,
                            ref bool_0, ref int_0, int_1);
                        break;
                    case 1:
                        GetPddbItemOffset(ref byte_4, ref byte_1, ref sb,
                            ref bool_0, ref int_0, int_1);
                        FileStream fileStream2 = fs;
                        long num3 = fileStream2.Position + 1L;
                        fileStream2.Position = num3;
                        break;
                    case 2:
                        GetPddbItemOffset(ref byte_4, ref byte_1, ref sb,
                            ref bool_0, ref int_0, int_1);
                        FileStream fileStream3 = fs;
                        long num4 = fileStream3.Position + 2L;
                        fileStream3.Position = num4;
                        break;
                    case 3:
                        GetPddbItemOffset(ref byte_4, ref byte_1, ref sb,
                            ref bool_0, ref int_0, int_1);
                        FileStream fileStream4 = fs;
                        long num5 = fileStream4.Position + 4L;
                        fileStream4.Position = num5;
                        break;
                    case 4:
                        GetPddbItemOffset(ref byte_4, ref byte_1, ref sb,
                            ref bool_0, ref int_0, int_1);
                        FileStream fileStream5 = fs;
                        long num6 = fileStream5.Position + 8L;
                        fileStream5.Position = num6;
                        break;
                    case 5:
                        GetPddbItemOffset(ref byte_4, ref byte_1, ref sb,
                            ref bool_0, ref int_0, int_1);
                        FileStream fileStream6 = fs;
                        long num7 = fileStream6.Position + 4L;
                        fileStream6.Position = num7;
                        break;
                    case 6:
                        GetPddbItemOffset(ref byte_4, ref byte_1, ref sb,
                            ref bool_0, ref int_0, int_1);
                        fs.Read(numArray, 0, 4);
                        var num8 = (int)ReverseEndedness(0U, 3U, numArray);
                        FileStream fileStream7 = fs;
                        long num9 = fileStream7.Position + num8;
                        fileStream7.Position = num9;
                        break;
                    case 7:
                        bool_0 = false;
                        GetPddbItemOffset(ref byte_4, ref byte_1, ref sb,
                            ref bool_0, ref int_0, int_1);
                        FileStream fileStream8 = fs;
                        long num10 = fileStream8.Position - 1L;
                        fileStream8.Position = num10;
                        break;
                    case 8:
                        GetPddbItemOffset(ref byte_4, ref byte_1, ref sb,
                            ref bool_0, ref int_0, int_1);
                        sb.Append("[]");
                        fs.Read(numArray, 0, 4);
                        var num11 = (int)ReverseEndedness(0U, 3U, numArray);
                        pddbDataType = (byte)fs.ReadByte();
                        FileStream fileStream9 = fs;
                        long num12 = fileStream9.Position - 1L;
                        fileStream9.Position = num12;
                        if (pddbDataType == 7)
                        {
                            bool_0 = false;
                            for (int index = 0; index < num11; ++index)
                                ReadPddbValues(fs, pddbDataType, byte_4, byte_1,
                                    ref sb, ref bool_0, ref int_0);
                        }
                        else
                        {
                            bool_0 = true;
                            for (int index = 0; index < num11; ++index)
                                ReadPddbValue(fs, pddbDataType, ref byte_4, ref byte_1,
                                    ref sb, ref bool_0, ref int_0, int_1);
                            bool_0 = false;
                        }
                        sb.Remove(sb.Length - 2, 2);
                        break;
                    case 9:
                        GetPddbItemOffset(ref byte_4, ref byte_1, ref sb,
                            ref bool_0, ref int_0, int_1);
                        fs.Read(numArray, 0, 4);
                        sb.Append("{}");
                        var num13 = (int)ReverseEndedness(0U, 3U, numArray);
                        pddbDataType = (byte)fs.ReadByte();
                        FileStream fileStream10 = fs;
                        long num14 = fileStream10.Position - 1L;
                        fileStream10.Position = num14;
                        if (pddbDataType == 7)
                        {
                            bool_0 = false;
                            for (int index = 0; index < num13; ++index)
                                ReadPddbValues(fs, pddbDataType, byte_4, byte_1,
                                    ref sb, ref bool_0, ref int_0);
                        }
                        else
                        {
                            bool_0 = true;
                            for (int index = 0; index < num13 * 2; ++index)
                                ReadPddbValue(fs, pddbDataType, ref byte_4, ref byte_1,
                                    ref sb, ref bool_0, ref int_0, int_1);
                            bool_0 = false;
                        }
                        sb.Remove(sb.Length - 2, 2);
                        break;
                    case 10:
                        pddbDataType = (byte)fs.ReadByte();
                        if (pddbDataType == 9)
                        {
                            GetPddbItemOffset(ref byte_4, ref byte_1, ref sb,
                                ref bool_0, ref int_0, int_1);
                            sb.Append("<>");
                            fs.Read(numArray, 0, 4);
                            var num15 = (int)ReverseEndedness(0U, 3U, numArray);
                            for (int index = 0; index < num15; ++index)
                                ReadPddbValues(fs, pddbDataType, byte_4, byte_1,
                                    ref sb, ref bool_0, ref int_0);
                            sb.Remove(sb.Length - 2, 2);
                            break;
                        }
                        else
                        {
                            if (pddbDataType != 6)
                                break;
                            GetPddbItemOffset(ref byte_4, ref byte_1, ref sb,
                                ref bool_0, ref int_0, int_1);
                            sb.Append("<>");
                            FileStream fileStream11 = fs;
                            long num15 = fileStream11.Position + 8L;
                            fileStream11.Position = num15;
                            fs.Read(numArray, 0, 4);
                            var num16 = (int)ReverseEndedness(0U, 3U, numArray);
                            FileStream fileStream12 = fs;
                            long num17 = fileStream12.Position + num16 * 16;
                            fileStream12.Position = num17;
                            sb.Remove(sb.Length - 2, 2);
                            break;
                        }
                    case 12:
                        GetPddbItemOffset(ref byte_4, ref byte_1, ref sb,
                            ref bool_0, ref int_0, int_1);
                        FileStream fileStream13 = fs;
                        long num18 = fileStream13.Position + 1L;
                        fileStream13.Position = num18;
                        break;
                    case 13:
                        GetPddbItemOffset(ref byte_4, ref byte_1, ref sb,
                            ref bool_0, ref int_0, int_1);
                        FileStream fileStream14 = fs;
                        long num19 = fileStream14.Position + 2L;
                        fileStream14.Position = num19;
                        break;
                    case 14:
                        GetPddbItemOffset(ref byte_4, ref byte_1, ref sb,
                            ref bool_0, ref int_0, int_1);
                        FileStream fileStream15 = fs;
                        long num20 = fileStream15.Position + 4L;
                        fileStream15.Position = num20;
                        break;
                    case 15:
                        GetPddbItemOffset(ref byte_4, ref byte_1, ref sb,
                            ref bool_0, ref int_0, int_1);
                        FileStream fileStream16 = fs;
                        long num21 = fileStream16.Position + 8L;
                        fileStream16.Position = num21;
                        break;
                }
            }
            catch
            {
            }
        }

        public static void GetPddbItemOffset(ref byte[] byte3,
            ref byte[] byte4, ref StringBuilder stringBuilder0, ref bool bool0, ref int int0, int int1)
        {
            try
            {
                if (bool0 || byte4[0] >= 16)
                    return;
                Console.Write(stringBuilder0.ToString());
                if (byte4[0] == 7)
                {
                    if (byte3[1] >= 128 && byte3[1] <= 129)
                    {
                        List0.Add((int)ReverseEndedness(0U, 2U, byte3));
                        ItemOffsets.Add(int1);
                    }
                    else
                    {
                        ItemOffsets.Add(int1);
                        List0.Add((int)ReverseEndedness(0U, 1U, byte3));
                    }
                }
                else if (byte3[1] <= sbyte.MaxValue)
                {
                    ItemOffsets.Add(int1);
                    List0.Add((int)ReverseEndedness(0U, 1U, byte3));
                }
                else if (byte3[1] <= 129)
                {
                    ItemOffsets.Add(int1);
                    List0.Add((int)ReverseEndedness(0U, 2U, byte3));
                }
                ++int0;
            }
            catch
            {
            }
        }

        public static ulong ReverseEndedness(uint begin, uint end, byte[] byteArray)
        {
            uint num = 0U;
            for (uint index = begin; index <= end; ++index)
            {
                num = (int)index != (int)begin
                    ? num << 8 | byteArray[index]
                    : byteArray[index];
            }
            return num;
        }

        public static ulong FindSqlLiteOffset(string sqlLiteFileMagic, string filePath)
        {
            var fileStream1 = new FileStream(filePath, FileMode.Open);
            bool flag = false;
            ulong num1 = 0UL;
            byte[] magicBytes = Encoding.ASCII.GetBytes(sqlLiteFileMagic);
            var numArray = new byte[sqlLiteFileMagic.Length];
            while (!flag && fileStream1.Position < fileStream1.Length)
            {
                if ((char)fileStream1.ReadByte() == magicBytes[0])
                {
                    FileStream fileStream2 = fileStream1;
                    long num2 = fileStream2.Position - 1L;
                    fileStream2.Position = num2;
                    fileStream1.Read(numArray, 0, sqlLiteFileMagic.Length);
                    if (AreByteArraysEquivalent(magicBytes, numArray))
                    {
                        flag = true;
                        num1 = (ulong)fileStream1.Position - (ulong)sqlLiteFileMagic.Length;
                    }
                }
            }
            fileStream1.Dispose();
            return num1;
        }


        internal static bool AreByteArraysEquivalent(byte[] array1, byte[] array2)
        {
            if (array1 == null || array2 == null)
                throw new ArgumentNullException();
            if (array1 == array2)
                return true;
            if (array1.Length != array2.Length)
                return false;
            for (int index = 0; index < array1.Length; ++index)
            {
                if (array1[index] != array2[index])
                    return false;
            }
            return true;
        }
    }
}