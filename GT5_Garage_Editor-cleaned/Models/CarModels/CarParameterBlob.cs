using System;

namespace GT5_Garage_Editor.Models.CarModels
{
    public sealed class CarParameterBlob
    {
        private byte[] _fullBlob;
        private uint _metres;
        private uint _wash;
        private uint _oil;
        private uint _changes;
        private uint _wins;
        private byte byte_1;
        private byte byte_2;
        private byte _frTyre;
        private byte _rrTyre;
        private uint _gearRev;
        private uint _g1;
        private uint _g2;
        private uint _g3;
        private uint _g4;
        private uint _g5;
        private uint _g6;
        private uint _g7;
        private uint _g8;
        private uint _g9;
        private uint _g10;
        private uint _g11;
        private uint _gFinal;
        private byte _frTorque;
        private byte _dfF;
        private byte _dfR;
        private byte _camberFront;
        private byte _camberR;
        private uint _rideHeightF;
        private uint _rideHeightR;
        private sbyte _toeF;
        private sbyte _toeR;
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
            FullBlob(new byte[679]);
        }

        public CarParameterBlob(byte[] blob)
        {
            FullBlob(new byte[679]);
            Array.Copy(blob, FullBlob(), 679);
            Metres(GetUInt(37U, 40U, blob));
            Wash(GetUInt(41U, 44U, blob));
            Oil(GetUInt(49U, 52U, blob));
            Changes(GetUInt(65U, 66U, blob));
            Wins(GetUInt(67U, 68U, blob));
            method_105(GetUInt(77U, 80U, blob));
            method_13(GetByte(183U, blob));
            method_15(GetByte(191U, blob));
            FrTyre(GetByte(185U, blob));
            RrTyre(GetByte(193U, blob));
            method_119(GetUInt(194U, 197U, blob));
            GearRev(GetUInt(346U, 347U, blob));
            G1(GetUInt(348U, 349U, blob));
            method_25(GetUInt(350U, 351U, blob));
            method_27(GetUInt(352U, 353U, blob));
            G4(GetUInt(354U, 355U, blob));
            G5(GetUInt(356U, 357U, blob));
            G6(GetUInt(358U, 359U, blob));
            G7(GetUInt(360U, 361U, blob));
            method_37(GetUInt(362U, 363U, blob));
            G9(GetUInt(364U, 365U, blob));
            G10(GetUInt(366U, 367U, blob));
            G11(GetUInt(368U, 369U, blob));
            GFinal(GetUInt(370U, 371U, blob));
            FrTorque(GetByte(375U, blob));
            DfF(GetByte(378U, blob));
            DfR(GetByte(379U, blob));
            CamberFront(GetByte(386U, blob));
            CamberR(GetByte(387U, blob));
            RideHeightF(GetUInt(388U, 389U, blob));
            RideHeightR(GetUInt(390U, 391U, blob));
            ToeF((sbyte) GetByte(392U, blob));
            ToeR((sbyte) GetByte(393U, blob));
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

        public byte[] FullBlob()
        {
            return _fullBlob;
        }

        public void FullBlob(byte[] blob)
        {
            _fullBlob = blob;
        }

        public uint Metres()
        {
            return _metres;
        }

        public void Metres(uint val)
        {
            _metres = val;
        }

        public uint Wash()
        {
            return _wash;
        }

        public void Wash(uint val)
        {
            _wash = val;
        }

        public uint Oil()
        {
            return _oil;
        }

        public void Oil(uint val)
        {
            _oil = val;
        }

        public uint Changes()
        {
            return _changes;
        }

        public void Changes(uint val)
        {
            _changes = val;
        }

        public uint Wins()
        {
            return _wins;
        }

        public void Wins(uint val)
        {
            _wins = val;
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

        public byte FrTyre()
        {
            return _frTyre;
        }

        public void FrTyre(byte val)
        {
            _frTyre = val;
        }

        public byte RrTyre()
        {
            return _rrTyre;
        }

        public void RrTyre(byte val)
        {
            _rrTyre = val;
        }

        public uint GearRev()
        {
            return _gearRev;
        }

        public void GearRev(uint val)
        {
            _gearRev = val;
        }

        public uint G1()
        {
            return _g1;
        }

        public void G1(uint val)
        {
            _g1 = val;
        }

        public uint G2()
        {
            return _g2;
        }

        public void method_25(uint val)
        {
            _g2 = val;
        }

        public uint G3()
        {
            return _g3;
        }

        public void method_27(uint val)
        {
            _g3 = val;
        }

        public uint G4()
        {
            return _g4;
        }

        public void G4(uint val)
        {
            _g4 = val;
        }

        public uint G5()
        {
            return _g5;
        }

        public void G5(uint val)
        {
            _g5 = val;
        }

        public uint G6()
        {
            return _g6;
        }

        public void G6(uint val)
        {
            _g6 = val;
        }

        public uint G7()
        {
            return _g7;
        }

        public void G7(uint val)
        {
            _g7 = val;
        }

        public uint G8()
        {
            return _g8;
        }

        public void method_37(uint val)
        {
            _g8 = val;
        }

        public uint G9()
        {
            return _g9;
        }

        public void G9(uint val)
        {
            _g9 = val;
        }

        public uint G10()
        {
            return _g10;
        }

        public void G10(uint val)
        {
            _g10 = val;
        }

        public uint G11()
        {
            return _g11;
        }

        public void G11(uint val)
        {
            _g11 = val;
        }

        public uint GFinal()
        {
            return _gFinal;
        }

        public void GFinal(uint val)
        {
            _gFinal = val;
        }

        public byte FrTorque()
        {
            return _frTorque;
        }

        public void FrTorque(byte val)
        {
            _frTorque = val;
        }

        public byte DfF()
        {
            return _dfF;
        }

        public void DfF(byte val)
        {
            _dfF = val;
        }

        public byte DfR()
        {
            return _dfR;
        }

        public void DfR(byte val)
        {
            _dfR = val;
        }

        public byte CamberFront()
        {
            return _camberFront;
        }

        public void CamberFront(byte val)
        {
            _camberFront = val;
        }

        public byte CamberR()
        {
            return _camberR;
        }

        public void CamberR(byte val)
        {
            _camberR = val;
        }

        public uint RideHeightF()
        {
            return _rideHeightF;
        }

        public void RideHeightF(uint val)
        {
            _rideHeightF = val;
        }

        public uint RideHeightR()
        {
            return _rideHeightR;
        }

        public void RideHeightR(uint val)
        {
            _rideHeightR = val;
        }

        public sbyte ToeF()
        {
            return _toeF;
        }

        public void ToeF(sbyte val)
        {
            _toeF = val;
        }

        public sbyte ToeR()
        {
            return _toeR;
        }

        public void ToeR(sbyte val)
        {
            _toeR = val;
        }

        public byte SpringF()
        {
            return byte_10;
        }

        public void method_65(byte byte_33)
        {
            byte_10 = byte_33;
        }

        public byte SpringR()
        {
            return byte_11;
        }

        public void method_67(byte byte_33)
        {
            byte_11 = byte_33;
        }

        public byte ExtenF()
        {
            return byte_12;
        }

        public void method_69(byte byte_33)
        {
            byte_12 = byte_33;
        }

        public byte CompF()
        {
            return byte_13;
        }

        public void method_71(byte byte_33)
        {
            byte_13 = byte_33;
        }

        public byte ExtenR()
        {
            return byte_14;
        }

        public void method_73(byte byte_33)
        {
            byte_14 = byte_33;
        }

        public byte CompR()
        {
            return byte_15;
        }

        public void method_75(byte byte_33)
        {
            byte_15 = byte_33;
        }

        public byte AntiRollBarF()
        {
            return byte_16;
        }

        public void method_77(byte byte_33)
        {
            byte_16 = byte_33;
        }

        public byte AntiRollBarR()
        {
            return byte_17;
        }

        public void method_79(byte byte_33)
        {
            byte_17 = byte_33;
        }

        public byte LSDInitF()
        {
            return byte_18;
        }

        public void method_81(byte byte_33)
        {
            byte_18 = byte_33;
        }

        public byte LSDInitR()
        {
            return byte_19;
        }

        public void method_83(byte byte_33)
        {
            byte_19 = byte_33;
        }

        public byte LSDAccF()
        {
            return byte_20;
        }

        public void method_85(byte byte_33)
        {
            byte_20 = byte_33;
        }

        public byte LSDAccR()
        {
            return byte_21;
        }

        public void method_87(byte byte_33)
        {
            byte_21 = byte_33;
        }

        public byte LSDDecF()
        {
            return byte_22;
        }

        public void method_89(byte byte_33)
        {
            byte_22 = byte_33;
        }

        public byte LSDDecR()
        {
            return byte_23;
        }

        public void method_91(byte byte_33)
        {
            byte_23 = byte_33;
        }

        public byte BallastKg()
        {
            return byte_24;
        }

        public void method_93(byte byte_33)
        {
            byte_24 = byte_33;
        }

        public sbyte BallastPos()
        {
            return sbyte_2;
        }

        public void method_95(sbyte sbyte_3)
        {
            sbyte_2 = sbyte_3;
        }

        public byte BBF()
        {
            return byte_25;
        }

        public void method_97(byte byte_33)
        {
            byte_25 = byte_33;
        }

        public byte BBR()
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

        public byte Colour()
        {
            return byte_27;
        }

        public void method_103(byte byte_33)
        {
            byte_27 = byte_33;
        }

        public uint Paint()
        {
            return uint_21;
        }

        public void method_105(uint uint_61)
        {
            uint_21 = uint_61;
        }

        public byte FrRim()
        {
            return byte_28;
        }

        public void method_107(byte byte_33)
        {
            byte_28 = byte_33;
        }

        public byte RrRim()
        {
            return byte_29;
        }

        public void method_109(byte byte_33)
        {
            byte_29 = byte_33;
        }

        public byte Bhp()
        {
            return byte_30;
        }

        public void method_111(byte byte_33)
        {
            byte_30 = byte_33;
        }

        public byte Grip()
        {
            return byte_31;
        }

        public void method_113(byte byte_33)
        {
            byte_31 = byte_33;
        }

        public byte Weight()
        {
            return byte_32;
        }

        public void method_115(byte byte_33)
        {
            byte_32 = byte_33;
        }

        public uint Body()
        {
            return uint_22;
        }

        public void method_117(uint uint_61)
        {
            uint_22 = uint_61;
        }

        public uint Brakes()
        {
            return uint_23;
        }

        public void method_119(uint uint_61)
        {
            uint_23 = uint_61;
        }

        public uint _198_201()
        {
            return uint_24;
        }

        public void method_121(uint uint_61)
        {
            uint_24 = uint_61;
        }

        public uint Chassis()
        {
            return uint_25;
        }

        public void method_123(uint uint_61)
        {
            uint_25 = uint_61;
        }

        public uint Engine()
        {
            return uint_26;
        }

        public void method_125(uint uint_61)
        {
            uint_26 = uint_61;
        }

        public uint DriveTrain()
        {
            return uint_27;
        }

        public void method_127(uint uint_61)
        {
            uint_27 = uint_61;
        }

        public uint Transmission()
        {
            return uint_28;
        }

        public void method_129(uint uint_61)
        {
            uint_28 = uint_61;
        }

        public uint Suspension()
        {
            return uint_29;
        }

        public void method_131(uint uint_61)
        {
            uint_29 = uint_61;
        }

        public uint LSD()
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

        public uint WReduction()
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

        public uint ECU()
        {
            return uint_35;
        }

        public void method_143(uint uint_61)
        {
            uint_35 = uint_61;
        }

        public uint EngineTune()
        {
            return uint_36;
        }

        public void method_145(uint uint_61)
        {
            uint_36 = uint_61;
        }

        public uint Turbo()
        {
            return uint_37;
        }

        public void method_147(uint uint_61)
        {
            uint_37 = uint_61;
        }

        public uint Flywheel()
        {
            return uint_38;
        }

        public void method_149(uint uint_61)
        {
            uint_38 = uint_61;
        }

        public uint Clutch()
        {
            return uint_39;
        }

        public void method_151(uint uint_61)
        {
            uint_39 = uint_61;
        }

        public uint Driveshaft()
        {
            return uint_40;
        }

        public void method_153(uint uint_61)
        {
            uint_40 = uint_61;
        }

        public uint Exhaust()
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

        public uint ASM()
        {
            return uint_43;
        }

        public void method_159(uint uint_61)
        {
            uint_43 = uint_61;
        }

        public uint TCS()
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

        public uint Supercharger()
        {
            return uint_46;
        }

        public void method_165(uint uint_61)
        {
            uint_46 = uint_61;
        }

        public uint Intake()
        {
            return uint_47;
        }

        public void method_167(uint uint_61)
        {
            uint_47 = uint_61;
        }

        public uint ExhaustManifold()
        {
            return uint_48;
        }

        public void method_169(uint uint_61)
        {
            uint_48 = uint_61;
        }

        public uint CatConverter()
        {
            return uint_49;
        }

        public void method_171(uint uint_61)
        {
            uint_49 = uint_61;
        }

        public uint AirFilter()
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

        public uint WindowWR()
        {
            return uint_52;
        }

        public void method_177(uint uint_61)
        {
            uint_52 = uint_61;
        }

        public uint Hood()
        {
            return uint_53;
        }

        public void method_179(uint uint_61)
        {
            uint_53 = uint_61;
        }

        public uint FrBumper()
        {
            return uint_54;
        }

        public void method_181(uint uint_61)
        {
            uint_54 = uint_61;
        }

        public uint RrBumper()
        {
            return uint_55;
        }

        public void method_183(uint uint_61)
        {
            uint_55 = uint_61;
        }

        public uint Extension()
        {
            return uint_56;
        }

        public void method_185(uint uint_61)
        {
            uint_56 = uint_61;
        }

        public uint Wing()
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

        public uint Reinforcement()
        {
            return uint_59;
        }

        public void method_191(uint uint_61)
        {
            uint_59 = uint_61;
        }

        public uint Nos()
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
