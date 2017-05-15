using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GT5SaveGameLibrary
{
    public class Pddb
    {
        public Pddb(string savePath)
        {
            SavePath = savePath;
            List0 = new List<int>();
            List1 = new List<int>();
            ItemOffsets = new List<int>();
            PddbItemListNames = new List<string>();
            ExtractPddb();
        }

        public string SavePath { get; private set; }

        public static List<int> List1 { get; set; }

        public static List<int> List0 { get; set; }

        public static List<int> ItemOffsets { get; set; }

        public static List<string> PddbItemListNames { get; set; }

        private void ExtractPddb()
        {
            var fileStream1 = new FileStream(SavePath, FileMode.Open);
            FileStream fileStream2 = fileStream1;
            long num1 = fileStream2.Position + 3L;
            fileStream2.Position = num1;
            var num2 = (byte)fileStream1.ReadByte();
            fileStream1.Close();
            if (num2 == 249)
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

        private static void GetPddbItemListNames(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                    return;
                var stringBuilder0 = new StringBuilder(string.Empty);
                bool bool0 = false;
                int int0 = 0;
                var byte4 = new byte[5];
                var byte5 = new byte[2];
                var numArray = new byte[4];
                var fileStream = new FileStream(filePath, FileMode.Open);
                byte byte_3 = 0;
                fileStream.Position = 33L;
                fileStream.Read(numArray, 0, 4);
                var pddbStringsOffset = (uint)ReverseEndedness(0U, 3U, numArray);
                fileStream.Position = 42L;
                while (fileStream.Position < pddbStringsOffset + 32U)
                    smethod_13(fileStream, byte_3, byte4, byte5, ref stringBuilder0, ref bool0, ref int0);
                List1 = List0.Distinct().ToList();
                List1.Sort();
                int num2 = 0;
                foreach (int num3 in List1)
                    PddbItemListNames.Add(ReadPddbSymbols(fileStream, num2++));
                fileStream.Close();
            }
            catch
            {
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

        public static void smethod_13(FileStream fileStream_0, byte byte_3, byte[] byte_4,
            byte[] byte_5, ref StringBuilder stringBuilder_0, ref bool bool_0, ref int int_0)
        {
            try
            {
                byte_3 = (byte)fileStream_0.ReadByte();
                byte_4[0] = byte_3;
                if (byte_3 != 7)
                    return;
                byte_3 = (byte)fileStream_0.ReadByte();
                byte_4[1] = byte_3;
                if (byte_3 <= sbyte.MaxValue)
                {
                    ReadPddbTable(fileStream_0, byte_3, ref byte_4, ref byte_5, ref stringBuilder_0,
                        ref bool_0, ref int_0, (int)fileStream_0.Position - 2);
                }
                else
                {
                    if (byte_3 != 128 && byte_3 != 129)
                        return;
                    byte_3 = (byte)fileStream_0.ReadByte();
                    byte_4[2] = byte_3;
                    ReadPddbTable(fileStream_0, byte_3, ref byte_4, ref byte_5, ref stringBuilder_0,
                        ref bool_0, ref int_0, (int)fileStream_0.Position - 3);
                }
            }
            catch
            {
            }
        }

        public static void ReadPddbTable(FileStream fileStream_0, byte byte_3,
            ref byte[] byte_4, ref byte[] pddbDataType, ref StringBuilder stringBuilder_0, ref bool bool_0,
            ref int int_0, int int_1)
        {
            try
            {
                int num1 = 0;
                var numArray = new byte[4];
                fileStream_0.Read(pddbDataType, 0, 2);
                FileStream fileStream1 = fileStream_0;
                long num2 = fileStream1.Position - 1L;
                fileStream1.Position = num2;
                int_1 = (int)byte_4[1] > (int)sbyte.MaxValue
                    ? (int)fileStream_0.Position - 4
                    : (int)fileStream_0.Position - 3;
                switch (pddbDataType[0])
                {
                    case 0:
                        GetPddbItemOffset(ref byte_4, ref pddbDataType, ref stringBuilder_0,
                            ref bool_0, ref int_0, int_1);
                        break;
                    case 1:
                        GetPddbItemOffset(ref byte_4, ref pddbDataType, ref stringBuilder_0,
                            ref bool_0, ref int_0, int_1);
                        FileStream fileStream2 = fileStream_0;
                        long num3 = fileStream2.Position + 1L;
                        fileStream2.Position = num3;
                        break;
                    case 2:
                        GetPddbItemOffset(ref byte_4, ref pddbDataType, ref stringBuilder_0,
                            ref bool_0, ref int_0, int_1);
                        FileStream fileStream3 = fileStream_0;
                        long num4 = fileStream3.Position + 2L;
                        fileStream3.Position = num4;
                        break;
                    case 3:
                        GetPddbItemOffset(ref byte_4, ref pddbDataType, ref stringBuilder_0,
                            ref bool_0, ref int_0, int_1);
                        FileStream fileStream4 = fileStream_0;
                        long num5 = fileStream4.Position + 4L;
                        fileStream4.Position = num5;
                        break;
                    case 4:
                        GetPddbItemOffset(ref byte_4, ref pddbDataType, ref stringBuilder_0,
                            ref bool_0, ref int_0, int_1);
                        num1 = 8;
                        FileStream fileStream5 = fileStream_0;
                        long num6 = fileStream5.Position + 8L;
                        fileStream5.Position = num6;
                        break;
                    case 5:
                        GetPddbItemOffset(ref byte_4, ref pddbDataType, ref stringBuilder_0,
                            ref bool_0, ref int_0, int_1);
                        num1 = 4;
                        FileStream fileStream6 = fileStream_0;
                        long num7 = fileStream6.Position + 4L;
                        fileStream6.Position = num7;
                        break;
                    case 6:
                        GetPddbItemOffset(ref byte_4, ref pddbDataType, ref stringBuilder_0,
                            ref bool_0, ref int_0, int_1);
                        fileStream_0.Read(numArray, 0, 4);
                        var num8 = (int)ReverseEndedness(0U, 3U, numArray);
                        FileStream fileStream7 = fileStream_0;
                        long num9 = fileStream7.Position + num8;
                        fileStream7.Position = num9;
                        break;
                    case 7:
                        bool_0 = false;
                        GetPddbItemOffset(ref byte_4, ref pddbDataType, ref stringBuilder_0,
                            ref bool_0, ref int_0, int_1);
                        FileStream fileStream8 = fileStream_0;
                        long num10 = fileStream8.Position - 1L;
                        fileStream8.Position = num10;
                        break;
                    case 8:
                        GetPddbItemOffset(ref byte_4, ref pddbDataType, ref stringBuilder_0,
                            ref bool_0, ref int_0, int_1);
                        stringBuilder_0.Append("[]");
                        fileStream_0.Read(numArray, 0, 4);
                        var num11 = (int)ReverseEndedness(0U, 3U, numArray);
                        byte_3 = (byte)fileStream_0.ReadByte();
                        FileStream fileStream9 = fileStream_0;
                        long num12 = fileStream9.Position - 1L;
                        fileStream9.Position = num12;
                        if (byte_3 == 7)
                        {
                            bool_0 = false;
                            for (int index = 0; index < num11; ++index)
                                smethod_13(fileStream_0, byte_3, byte_4, pddbDataType,
                                    ref stringBuilder_0, ref bool_0, ref int_0);
                        }
                        else
                        {
                            bool_0 = true;
                            for (int index = 0; index < num11; ++index)
                                ReadPddbTable(fileStream_0, byte_3, ref byte_4, ref pddbDataType,
                                    ref stringBuilder_0, ref bool_0, ref int_0, int_1);
                            bool_0 = false;
                        }
                        stringBuilder_0.Remove(stringBuilder_0.Length - 2, 2);
                        break;
                    case 9:
                        GetPddbItemOffset(ref byte_4, ref pddbDataType, ref stringBuilder_0,
                            ref bool_0, ref int_0, int_1);
                        fileStream_0.Read(numArray, 0, 4);
                        stringBuilder_0.Append("{}");
                        var num13 = (int)ReverseEndedness(0U, 3U, numArray);
                        byte_3 = (byte)fileStream_0.ReadByte();
                        FileStream fileStream10 = fileStream_0;
                        long num14 = fileStream10.Position - 1L;
                        fileStream10.Position = num14;
                        if (byte_3 == 7)
                        {
                            bool_0 = false;
                            for (int index = 0; index < num13; ++index)
                                smethod_13(fileStream_0, byte_3, byte_4, pddbDataType,
                                    ref stringBuilder_0, ref bool_0, ref int_0);
                        }
                        else
                        {
                            bool_0 = true;
                            for (int index = 0; index < num13 * 2; ++index)
                                ReadPddbTable(fileStream_0, byte_3, ref byte_4, ref pddbDataType,
                                    ref stringBuilder_0, ref bool_0, ref int_0, int_1);
                            bool_0 = false;
                        }
                        stringBuilder_0.Remove(stringBuilder_0.Length - 2, 2);
                        break;
                    case 10:
                        byte_3 = (byte)fileStream_0.ReadByte();
                        if (byte_3 == 9)
                        {
                            GetPddbItemOffset(ref byte_4, ref pddbDataType, ref stringBuilder_0,
                                ref bool_0, ref int_0, int_1);
                            stringBuilder_0.Append("<>");
                            fileStream_0.Read(numArray, 0, 4);
                            var num15 = (int)ReverseEndedness(0U, 3U, numArray);
                            for (int index = 0; index < num15; ++index)
                                smethod_13(fileStream_0, byte_3, byte_4, pddbDataType,
                                    ref stringBuilder_0, ref bool_0, ref int_0);
                            stringBuilder_0.Remove(stringBuilder_0.Length - 2, 2);
                            break;
                        }
                        else
                        {
                            if (byte_3 != 6)
                                break;
                            GetPddbItemOffset(ref byte_4, ref pddbDataType, ref stringBuilder_0,
                                ref bool_0, ref int_0, int_1);
                            stringBuilder_0.Append("<>");
                            FileStream fileStream11 = fileStream_0;
                            long num15 = fileStream11.Position + 8L;
                            fileStream11.Position = num15;
                            fileStream_0.Read(numArray, 0, 4);
                            var num16 = (int)ReverseEndedness(0U, 3U, numArray);
                            FileStream fileStream12 = fileStream_0;
                            long num17 = fileStream12.Position + num16 * 16;
                            fileStream12.Position = num17;
                            stringBuilder_0.Remove(stringBuilder_0.Length - 2, 2);
                            break;
                        }
                    case 12:
                        GetPddbItemOffset(ref byte_4, ref pddbDataType, ref stringBuilder_0,
                            ref bool_0, ref int_0, int_1);
                        num1 = 1;
                        FileStream fileStream13 = fileStream_0;
                        long num18 = fileStream13.Position + 1L;
                        fileStream13.Position = num18;
                        break;
                    case 13:
                        GetPddbItemOffset(ref byte_4, ref pddbDataType, ref stringBuilder_0,
                            ref bool_0, ref int_0, int_1);
                        num1 = 2;
                        FileStream fileStream14 = fileStream_0;
                        long num19 = fileStream14.Position + 2L;
                        fileStream14.Position = num19;
                        break;
                    case 14:
                        GetPddbItemOffset(ref byte_4, ref pddbDataType, ref stringBuilder_0,
                            ref bool_0, ref int_0, int_1);
                        num1 = 4;
                        FileStream fileStream15 = fileStream_0;
                        long num20 = fileStream15.Position + 4L;
                        fileStream15.Position = num20;
                        break;
                    case 15:
                        GetPddbItemOffset(ref byte_4, ref pddbDataType, ref stringBuilder_0,
                            ref bool_0, ref int_0, int_1);
                        num1 = 8;
                        FileStream fileStream16 = fileStream_0;
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
                if (bool0 || byte4[0] < 0 || byte4[0] >= 16)
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