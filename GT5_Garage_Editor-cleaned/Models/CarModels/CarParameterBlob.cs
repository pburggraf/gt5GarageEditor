using System;

namespace GT5_Garage_Editor.Models.CarModels
{
    public sealed class CarParameterBlob
    {
        private byte[] _fullBlob;
        private uint uint_0;
        private uint uint_1;
        private uint uint_2;
        private uint uint_3;
        private uint uint_4;
        private byte byte_1;
        private byte byte_2;
        private byte byte_3;
        private byte byte_4;
        private uint uint_5;
        private uint uint_6;
        private uint uint_7;
        private uint uint_8;
        private uint uint_9;
        private uint uint_10;
        private uint uint_11;
        private uint uint_12;
        private uint uint_13;
        private uint uint_14;
        private uint uint_15;
        private uint uint_16;
        private uint uint_17;
        private byte byte_5;
        private byte byte_6;
        private byte byte_7;
        private byte byte_8;
        private byte byte_9;
        private uint uint_18;
        private uint uint_19;
        private sbyte sbyte_0;
        private sbyte sbyte_1;
        private byte byte_10;
        private byte byte_11;
        private byte byte_12;
        private byte byte_13;
        private byte byte_14;
        private byte byte_15;
        private byte byte_16;
        private byte byte_17;
        private byte byte_18;
        private byte byte_19;
        private byte byte_20;
        private byte byte_21;
        private byte byte_22;
        private byte byte_23;
        private byte byte_24;
        private sbyte sbyte_2;
        private byte byte_25;
        private byte byte_26;
        private uint uint_20;
        private byte byte_27;
        private uint uint_21;
        private byte byte_28;
        private byte byte_29;
        private byte byte_30;
        private byte byte_31;
        private byte byte_32;
        private uint uint_22;
        private uint uint_23;
        private uint uint_24;
        private uint uint_25;
        private uint uint_26;
        private uint uint_27;
        private uint uint_28;
        private uint uint_29;
        private uint uint_30;
        private uint uint_31;
        private uint uint_32;
        private uint uint_33;
        private uint uint_34;
        private uint uint_35;
        private uint uint_36;
        private uint uint_37;
        private uint uint_38;
        private uint uint_39;
        private uint uint_40;
        private uint uint_41;
        private uint uint_42;
        private uint uint_43;
        private uint uint_44;
        private uint uint_45;
        private uint uint_46;
        private uint uint_47;
        private uint uint_48;
        private uint uint_49;
        private uint uint_50;
        private uint uint_51;
        private uint uint_52;
        private uint uint_53;
        private uint uint_54;
        private uint uint_55;
        private uint uint_56;
        private uint uint_57;
        private uint uint_58;
        private uint uint_59;
        private uint uint_60;

        public CarParameterBlob()
        {
            SetBlob(new byte[679]);
        }

        public CarParameterBlob(byte[] blob)
        {
            SetBlob(new byte[679]);
            Array.Copy(blob, GetBlob(), 679);
            method_3(GetUInt(37U, 40U, blob));
            method_5(GetUInt(41U, 44U, blob));
            method_7(GetUInt(49U, 52U, blob));
            method_9(GetUInt(65U, 66U, blob));
            method_11(GetUInt(67U, 68U, blob));
            method_105(GetUInt(77U, 80U, blob));
            method_13(GetByte(183U, blob));
            method_15(GetByte(191U, blob));
            method_17(GetByte(185U, blob));
            method_19(GetByte(193U, blob));
            method_119(GetUInt(194U, 197U, blob));
            method_21(GetUInt(346U, 347U, blob));
            method_23(GetUInt(348U, 349U, blob));
            method_25(GetUInt(350U, 351U, blob));
            method_27(GetUInt(352U, 353U, blob));
            method_29(GetUInt(354U, 355U, blob));
            method_31(GetUInt(356U, 357U, blob));
            method_33(GetUInt(358U, 359U, blob));
            method_35(GetUInt(360U, 361U, blob));
            method_37(GetUInt(362U, 363U, blob));
            method_39(GetUInt(364U, 365U, blob));
            method_41(GetUInt(366U, 367U, blob));
            method_43(GetUInt(368U, 369U, blob));
            method_45(GetUInt(370U, 371U, blob));
            method_47(GetByte(375U, blob));
            method_49(GetByte(378U, blob));
            method_51(GetByte(379U, blob));
            method_53(GetByte(386U, blob));
            method_55(GetByte(387U, blob));
            method_57(GetUInt(388U, 389U, blob));
            method_59(GetUInt(390U, 391U, blob));
            method_61((sbyte) GetByte(392U, blob));
            method_63((sbyte) GetByte(393U, blob));
            method_65(GetByte(394U, blob));
            method_67(GetByte(395U, blob));
            method_69(GetByte(399U, blob));
            method_71(GetByte(401U, blob));
            method_73(GetByte(403U, blob));
            method_75(GetByte(405U, blob));
            method_77(GetByte(406U, blob));
            method_79(GetByte(407U, blob));
            method_81(GetByte(408U, blob));
            method_85(GetByte(410U, blob));
            method_89(GetByte(412U, blob));
            method_83(GetByte(409U, blob));
            method_87(GetByte(411U, blob));
            method_91(GetByte(413U, blob));
            method_93(GetByte(419U, blob));
            method_95((sbyte) GetByte(420U, blob));
            method_113(GetByte(431U, blob));
            method_97(GetByte(432U, blob));
            method_99(GetByte(433U, blob));
            method_117(GetUInt(159U, 160U, blob));
            method_103((byte) GetUInt(169U, 169U, blob));
            method_123(GetUInt(202U, 205U, blob));
            method_125(GetUInt(206U, 209U, blob));
            method_111((byte) GetUInt(422U, 422U, blob));
            method_115((byte) GetUInt(425U, 425U, blob));
            method_127(GetUInt(210U, 213U, blob));
            method_129(GetUInt(214U, 217U, blob));
            method_131(GetUInt(218U, 221U, blob));
            method_133(GetUInt(222U, 225U, blob));
            method_117(GetUInt(157U, 160U, blob));
            method_119(GetUInt(194U, 197U, blob));
            method_121(GetUInt(198U, 201U, blob));
            method_123(GetUInt(202U, 205U, blob));
            method_125(GetUInt(206U, 209U, blob));
            method_127(GetUInt(210U, 213U, blob));
            method_129(GetUInt(214U, 217U, blob));
            method_131(GetUInt(218U, 221U, blob));
            method_133(GetUInt(222U, 225U, blob));
            method_135(GetUInt(226U, 229U, blob));
            method_137(GetUInt(230U, 233U, blob));
            method_139(GetUInt(234U, 337U, blob));
            method_141(GetUInt(238U, 241U, blob));
            method_143(GetUInt(242U, 245U, blob));
            method_145(GetUInt(246U, 249U, blob));
            method_147(GetUInt(250U, 253U, blob));
            method_149(GetUInt(254U, 257U, blob));
            method_151(GetUInt(258U, 261U, blob));
            method_153(GetUInt(262U, 265U, blob));
            method_155(GetUInt(266U, 269U, blob));
            method_157(GetUInt(270U, 273U, blob));
            method_159(GetUInt(274U, 277U, blob));
            method_161(GetUInt(278U, 281U, blob));
            method_163(GetUInt(282U, 285U, blob));
            method_165(GetUInt(286U, 289U, blob));
            method_167(GetUInt(290U, 293U, blob));
            method_169(GetUInt(294U, 297U, blob));
            method_171(GetUInt(298U, 301U, blob));
            method_173(GetUInt(302U, 305U, blob));
            method_175(GetUInt(306U, 309U, blob));
            method_177(GetUInt(310U, 313U, blob));
            method_179(GetUInt(314U, 317U, blob));
            method_181(GetUInt(318U, 321U, blob));
            method_183(GetUInt(322U, 325U, blob));
            method_185(GetUInt(326U, 329U, blob));
            method_187(GetUInt(330U, 333U, blob));
            method_189(GetUInt(334U, 337U, blob));
            method_191(GetUInt(338U, 341U, blob));
            method_193(GetUInt(342U, 345U, blob));
            method_107(GetByte(173U, blob));
            method_109(GetByte(177U, blob));
        }

        public byte[] GetBlob()
        {
            return _fullBlob;
        }

        public void SetBlob(byte[] blob)
        {
            _fullBlob = blob;
        }

        public uint method_2()
        {
            return uint_0;
        }

        public void method_3(uint uint_61)
        {
            uint_0 = uint_61;
        }

        public uint method_4()
        {
            return uint_1;
        }

        public void method_5(uint uint_61)
        {
            uint_1 = uint_61;
        }

        public uint method_6()
        {
            return uint_2;
        }

        public void method_7(uint uint_61)
        {
            uint_2 = uint_61;
        }

        public uint method_8()
        {
            return uint_3;
        }

        public void method_9(uint uint_61)
        {
            uint_3 = uint_61;
        }

        public uint method_10()
        {
            return uint_4;
        }

        public void method_11(uint uint_61)
        {
            uint_4 = uint_61;
        }

        public byte method_12()
        {
            return byte_1;
        }

        public void method_13(byte byte_33)
        {
            byte_1 = byte_33;
        }

        public byte method_14()
        {
            return byte_2;
        }

        public void method_15(byte byte_33)
        {
            byte_2 = byte_33;
        }

        public byte method_16()
        {
            return byte_3;
        }

        public void method_17(byte byte_33)
        {
            byte_3 = byte_33;
        }

        public byte method_18()
        {
            return byte_4;
        }

        public void method_19(byte byte_33)
        {
            byte_4 = byte_33;
        }

        public uint method_20()
        {
            return uint_5;
        }

        public void method_21(uint uint_61)
        {
            uint_5 = uint_61;
        }

        public uint method_22()
        {
            return uint_6;
        }

        public void method_23(uint uint_61)
        {
            uint_6 = uint_61;
        }

        public uint method_24()
        {
            return uint_7;
        }

        public void method_25(uint uint_61)
        {
            uint_7 = uint_61;
        }

        public uint method_26()
        {
            return uint_8;
        }

        public void method_27(uint uint_61)
        {
            uint_8 = uint_61;
        }

        public uint method_28()
        {
            return uint_9;
        }

        public void method_29(uint uint_61)
        {
            uint_9 = uint_61;
        }

        public uint method_30()
        {
            return uint_10;
        }

        public void method_31(uint uint_61)
        {
            uint_10 = uint_61;
        }

        public uint method_32()
        {
            return uint_11;
        }

        public void method_33(uint uint_61)
        {
            uint_11 = uint_61;
        }

        public uint method_34()
        {
            return uint_12;
        }

        public void method_35(uint uint_61)
        {
            uint_12 = uint_61;
        }

        public uint method_36()
        {
            return uint_13;
        }

        public void method_37(uint uint_61)
        {
            uint_13 = uint_61;
        }

        public uint method_38()
        {
            return uint_14;
        }

        public void method_39(uint uint_61)
        {
            uint_14 = uint_61;
        }

        public uint method_40()
        {
            return uint_15;
        }

        public void method_41(uint uint_61)
        {
            uint_15 = uint_61;
        }

        public uint method_42()
        {
            return uint_16;
        }

        public void method_43(uint uint_61)
        {
            uint_16 = uint_61;
        }

        public uint method_44()
        {
            return uint_17;
        }

        public void method_45(uint uint_61)
        {
            uint_17 = uint_61;
        }

        public byte method_46()
        {
            return byte_5;
        }

        public void method_47(byte byte_33)
        {
            byte_5 = byte_33;
        }

        public byte method_48()
        {
            return byte_6;
        }

        public void method_49(byte byte_33)
        {
            byte_6 = byte_33;
        }

        public byte method_50()
        {
            return byte_7;
        }

        public void method_51(byte byte_33)
        {
            byte_7 = byte_33;
        }

        public byte method_52()
        {
            return byte_8;
        }

        public void method_53(byte byte_33)
        {
            byte_8 = byte_33;
        }

        public byte method_54()
        {
            return byte_9;
        }

        public void method_55(byte byte_33)
        {
            byte_9 = byte_33;
        }

        public uint method_56()
        {
            return uint_18;
        }

        public void method_57(uint uint_61)
        {
            uint_18 = uint_61;
        }

        public uint method_58()
        {
            return uint_19;
        }

        public void method_59(uint uint_61)
        {
            uint_19 = uint_61;
        }

        public sbyte method_60()
        {
            return sbyte_0;
        }

        public void method_61(sbyte sbyte_3)
        {
            sbyte_0 = sbyte_3;
        }

        public sbyte method_62()
        {
            return sbyte_1;
        }

        public void method_63(sbyte sbyte_3)
        {
            sbyte_1 = sbyte_3;
        }

        public byte method_64()
        {
            return byte_10;
        }

        public void method_65(byte byte_33)
        {
            byte_10 = byte_33;
        }

        public byte method_66()
        {
            return byte_11;
        }

        public void method_67(byte byte_33)
        {
            byte_11 = byte_33;
        }

        public byte method_68()
        {
            return byte_12;
        }

        public void method_69(byte byte_33)
        {
            byte_12 = byte_33;
        }

        public byte method_70()
        {
            return byte_13;
        }

        public void method_71(byte byte_33)
        {
            byte_13 = byte_33;
        }

        public byte method_72()
        {
            return byte_14;
        }

        public void method_73(byte byte_33)
        {
            byte_14 = byte_33;
        }

        public byte method_74()
        {
            return byte_15;
        }

        public void method_75(byte byte_33)
        {
            byte_15 = byte_33;
        }

        public byte method_76()
        {
            return byte_16;
        }

        public void method_77(byte byte_33)
        {
            byte_16 = byte_33;
        }

        public byte method_78()
        {
            return byte_17;
        }

        public void method_79(byte byte_33)
        {
            byte_17 = byte_33;
        }

        public byte method_80()
        {
            return byte_18;
        }

        public void method_81(byte byte_33)
        {
            byte_18 = byte_33;
        }

        public byte method_82()
        {
            return byte_19;
        }

        public void method_83(byte byte_33)
        {
            byte_19 = byte_33;
        }

        public byte method_84()
        {
            return byte_20;
        }

        public void method_85(byte byte_33)
        {
            byte_20 = byte_33;
        }

        public byte method_86()
        {
            return byte_21;
        }

        public void method_87(byte byte_33)
        {
            byte_21 = byte_33;
        }

        public byte method_88()
        {
            return byte_22;
        }

        public void method_89(byte byte_33)
        {
            byte_22 = byte_33;
        }

        public byte method_90()
        {
            return byte_23;
        }

        public void method_91(byte byte_33)
        {
            byte_23 = byte_33;
        }

        public byte method_92()
        {
            return byte_24;
        }

        public void method_93(byte byte_33)
        {
            byte_24 = byte_33;
        }

        public sbyte method_94()
        {
            return sbyte_2;
        }

        public void method_95(sbyte sbyte_3)
        {
            sbyte_2 = sbyte_3;
        }

        public byte method_96()
        {
            return byte_25;
        }

        public void method_97(byte byte_33)
        {
            byte_25 = byte_33;
        }

        public byte method_98()
        {
            return byte_26;
        }

        public void method_99(byte byte_33)
        {
            byte_26 = byte_33;
        }

        public uint method_100()
        {
            return uint_20;
        }

        public void method_101(uint uint_61)
        {
            uint_20 = uint_61;
        }

        public byte method_102()
        {
            return byte_27;
        }

        public void method_103(byte byte_33)
        {
            byte_27 = byte_33;
        }

        public uint method_104()
        {
            return uint_21;
        }

        public void method_105(uint uint_61)
        {
            uint_21 = uint_61;
        }

        public byte method_106()
        {
            return byte_28;
        }

        public void method_107(byte byte_33)
        {
            byte_28 = byte_33;
        }

        public byte method_108()
        {
            return byte_29;
        }

        public void method_109(byte byte_33)
        {
            byte_29 = byte_33;
        }

        public byte method_110()
        {
            return byte_30;
        }

        public void method_111(byte byte_33)
        {
            byte_30 = byte_33;
        }

        public byte method_112()
        {
            return byte_31;
        }

        public void method_113(byte byte_33)
        {
            byte_31 = byte_33;
        }

        public byte method_114()
        {
            return byte_32;
        }

        public void method_115(byte byte_33)
        {
            byte_32 = byte_33;
        }

        public uint method_116()
        {
            return uint_22;
        }

        public void method_117(uint uint_61)
        {
            uint_22 = uint_61;
        }

        public uint method_118()
        {
            return uint_23;
        }

        public void method_119(uint uint_61)
        {
            uint_23 = uint_61;
        }

        public uint method_120()
        {
            return uint_24;
        }

        public void method_121(uint uint_61)
        {
            uint_24 = uint_61;
        }

        public uint method_122()
        {
            return uint_25;
        }

        public void method_123(uint uint_61)
        {
            uint_25 = uint_61;
        }

        public uint method_124()
        {
            return uint_26;
        }

        public void method_125(uint uint_61)
        {
            uint_26 = uint_61;
        }

        public uint method_126()
        {
            return uint_27;
        }

        public void method_127(uint uint_61)
        {
            uint_27 = uint_61;
        }

        public uint method_128()
        {
            return uint_28;
        }

        public void method_129(uint uint_61)
        {
            uint_28 = uint_61;
        }

        public uint method_130()
        {
            return uint_29;
        }

        public void method_131(uint uint_61)
        {
            uint_29 = uint_61;
        }

        public uint method_132()
        {
            return uint_30;
        }

        public void method_133(uint uint_61)
        {
            uint_30 = uint_61;
        }

        public uint method_134()
        {
            return uint_31;
        }

        public void method_135(uint uint_61)
        {
            uint_31 = uint_61;
        }

        public uint method_136()
        {
            return uint_32;
        }

        public void method_137(uint uint_61)
        {
            uint_32 = uint_61;
        }

        public uint method_138()
        {
            return uint_33;
        }

        public void method_139(uint uint_61)
        {
            uint_33 = uint_61;
        }

        public uint method_140()
        {
            return uint_34;
        }

        public void method_141(uint uint_61)
        {
            uint_34 = uint_61;
        }

        public uint method_142()
        {
            return uint_35;
        }

        public void method_143(uint uint_61)
        {
            uint_35 = uint_61;
        }

        public uint method_144()
        {
            return uint_36;
        }

        public void method_145(uint uint_61)
        {
            uint_36 = uint_61;
        }

        public uint method_146()
        {
            return uint_37;
        }

        public void method_147(uint uint_61)
        {
            uint_37 = uint_61;
        }

        public uint method_148()
        {
            return uint_38;
        }

        public void method_149(uint uint_61)
        {
            uint_38 = uint_61;
        }

        public uint method_150()
        {
            return uint_39;
        }

        public void method_151(uint uint_61)
        {
            uint_39 = uint_61;
        }

        public uint method_152()
        {
            return uint_40;
        }

        public void method_153(uint uint_61)
        {
            uint_40 = uint_61;
        }

        public uint method_154()
        {
            return uint_41;
        }

        public void method_155(uint uint_61)
        {
            uint_41 = uint_61;
        }

        public uint method_156()
        {
            return uint_42;
        }

        public void method_157(uint uint_61)
        {
            uint_42 = uint_61;
        }

        public uint method_158()
        {
            return uint_43;
        }

        public void method_159(uint uint_61)
        {
            uint_43 = uint_61;
        }

        public uint method_160()
        {
            return uint_44;
        }

        public void method_161(uint uint_61)
        {
            uint_44 = uint_61;
        }

        public uint method_162()
        {
            return uint_45;
        }

        public void method_163(uint uint_61)
        {
            uint_45 = uint_61;
        }

        public uint method_164()
        {
            return uint_46;
        }

        public void method_165(uint uint_61)
        {
            uint_46 = uint_61;
        }

        public uint method_166()
        {
            return uint_47;
        }

        public void method_167(uint uint_61)
        {
            uint_47 = uint_61;
        }

        public uint method_168()
        {
            return uint_48;
        }

        public void method_169(uint uint_61)
        {
            uint_48 = uint_61;
        }

        public uint method_170()
        {
            return uint_49;
        }

        public void method_171(uint uint_61)
        {
            uint_49 = uint_61;
        }

        public uint method_172()
        {
            return uint_50;
        }

        public void method_173(uint uint_61)
        {
            uint_50 = uint_61;
        }

        public uint method_174()
        {
            return uint_51;
        }

        public void method_175(uint uint_61)
        {
            uint_51 = uint_61;
        }

        public uint method_176()
        {
            return uint_52;
        }

        public void method_177(uint uint_61)
        {
            uint_52 = uint_61;
        }

        public uint method_178()
        {
            return uint_53;
        }

        public void method_179(uint uint_61)
        {
            uint_53 = uint_61;
        }

        public uint method_180()
        {
            return uint_54;
        }

        public void method_181(uint uint_61)
        {
            uint_54 = uint_61;
        }

        public uint method_182()
        {
            return uint_55;
        }

        public void method_183(uint uint_61)
        {
            uint_55 = uint_61;
        }

        public uint method_184()
        {
            return uint_56;
        }

        public void method_185(uint uint_61)
        {
            uint_56 = uint_61;
        }

        public uint method_186()
        {
            return uint_57;
        }

        public void method_187(uint uint_61)
        {
            uint_57 = uint_61;
        }

        public uint method_188()
        {
            return uint_58;
        }

        public void method_189(uint uint_61)
        {
            uint_58 = uint_61;
        }

        public uint method_190()
        {
            return uint_59;
        }

        public void method_191(uint uint_61)
        {
            uint_59 = uint_61;
        }

        public uint method_192()
        {
            return uint_60;
        }

        public void method_193(uint uint_61)
        {
            uint_60 = uint_61;
        }

        public static uint GetUInt(uint start, uint end, byte[] blob)
        {
            var num = 0U;
            for (var index = start; index <= end; ++index)
                num = (int) index != (int) start ? num << 8 | blob[ index] : blob[ index];
            return num;
        }

        public static byte GetByte(uint location, byte[] blob)
        {
            return blob[ location];
        }
    }
}
