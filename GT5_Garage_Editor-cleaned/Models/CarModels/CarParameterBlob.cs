using System;

namespace GT5_Garage_Editor.Models.CarModels
{
    public sealed class CarParameterBlob
    {
        private uint _airfilter;
        private byte _antiRollBarF;
        private byte _antiRollBarR;
        private uint _asm;
        private byte _ballastKg;
        private sbyte _ballastPos;
        private byte _bbf;
        private byte _bbr;
        private byte _bhp;
        private uint _body;
        private uint _brakes;
        private byte _camberFront;
        private byte _camberR;
        private uint _catConverter;
        private uint _changes;
        private uint _chassis;
        private uint _clutch;
        private byte _colour;
        private byte _compF;
        private byte _compR;
        private byte _dfF;
        private byte _dfR;
        private uint _driveTrain;
        private uint _driveshaft;
        private uint _ecu;
        private uint _engine;
        private uint _engineTune;
        private uint _exhaust;
        private uint _exhaustManifold;
        private byte _extenF;
        private byte _extenR;
        private uint _extension;
        private uint _flywheel;
        private uint _frBumper;
        private byte _frRim;
        private byte _frTorque;
        private byte _frTyre;
        private byte[] _fullBlob;
        private uint _g1;
        private uint _g10;
        private uint _g11;
        private uint _g2;
        private uint _g3;
        private uint _g4;
        private uint _g5;
        private uint _g6;
        private uint _g7;
        private uint _g8;
        private uint _g9;
        private uint _gFinal;
        private uint _gearRev;
        private byte _grip;
        private uint _hood;
        private uint _intake;
        private uint _lsd;
        private byte _lsdAccF;
        private byte _lsdAccR;
        private byte _lsdDecF;
        private byte _lsdDecR;
        private byte _lsdInitF;
        private byte _lsdInitR;
        private uint _metres;
        private uint _nos;
        private uint _oil;
        private uint _paint;
        private uint _reinforcement;
        private uint _rideHeightF;
        private uint _rideHeightR;
        private uint _rrBumper;
        private byte _rrRim;
        private byte _rrTyre;
        private byte _springF;
        private byte _springR;
        private uint _supercharger;
        private uint _suspension;
        private uint _tcs;
        private sbyte _toeF;
        private sbyte _toeR;
        private uint _transmission;
        private uint _turbo;
        private uint _uInt1;
        private byte _unKnown1;
        private uint _unKnown10;
        private byte _unKnown2;
        private uint _unKnown3;
        private uint _unKnown4;
        private uint _unKnown5;
        private uint _unKnown6;
        private uint _unKnown7;
        private uint _unKnown8;
        private uint _unKnown9;
        private uint _wReduction;
        private uint _wash;
        private byte _weight;
        private uint _windowWr;
        private uint _wing;
        private uint _wins;

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
            Paint(GetUInt(77U, 80U, blob));
            UnKnown1(GetByte(183U, blob));
            UnKnown2(GetByte(191U, blob));
            FrTyre(GetByte(185U, blob));
            RrTyre(GetByte(193U, blob));
            Brakes(GetUInt(194U, 197U, blob));
            GearRev(GetUInt(346U, 347U, blob));
            G1(GetUInt(348U, 349U, blob));
            G2(GetUInt(350U, 351U, blob));
            G3(GetUInt(352U, 353U, blob));
            G4(GetUInt(354U, 355U, blob));
            G5(GetUInt(356U, 357U, blob));
            G6(GetUInt(358U, 359U, blob));
            G7(GetUInt(360U, 361U, blob));
            G8(GetUInt(362U, 363U, blob));
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
            SpringF(GetByte(394U, blob));
            SpringR(GetByte(395U, blob));
            ExtenF(GetByte(399U, blob));
            CompF(GetByte(401U, blob));
            ExtenR(GetByte(403U, blob));
            CompR(GetByte(405U, blob));
            AntiRollBarF(GetByte(406U, blob));
            AntiRollBarR(GetByte(407U, blob));
            LsdInitF(GetByte(408U, blob));
            LsdAccF(GetByte(410U, blob));
            LsdDecF(GetByte(412U, blob));
            LsdInitR(GetByte(409U, blob));
            LsdAccR(GetByte(411U, blob));
            LsdDecR(GetByte(413U, blob));
            BallastKg(GetByte(419U, blob));
            BallastPos((sbyte) GetByte(420U, blob));
            Grip(GetByte(431U, blob));
            Bbf(GetByte(432U, blob));
            Bbr(GetByte(433U, blob));
            Body(GetUInt(159U, 160U, blob));
            Colour((byte) GetUInt(169U, 169U, blob));
            Chassis(GetUInt(202U, 205U, blob));
            Engine(GetUInt(206U, 209U, blob));
            Bhp((byte) GetUInt(422U, 422U, blob));
            Weight((byte) GetUInt(425U, 425U, blob));
            DriveTrain(GetUInt(210U, 213U, blob));
            Transmission(GetUInt(214U, 217U, blob));
            Suspension(GetUInt(218U, 221U, blob));
            Lsd(GetUInt(222U, 225U, blob));
            Body(GetUInt(157U, 160U, blob));
            Brakes(GetUInt(194U, 197U, blob));
            UnKnown10(GetUInt(198U, 201U, blob));
            Chassis(GetUInt(202U, 205U, blob));
            Engine(GetUInt(206U, 209U, blob));
            DriveTrain(GetUInt(210U, 213U, blob));
            Transmission(GetUInt(214U, 217U, blob));
            Suspension(GetUInt(218U, 221U, blob));
            Lsd(GetUInt(222U, 225U, blob));
            UnKnown3(GetUInt(226U, 229U, blob));
            WReduction(GetUInt(230U, 233U, blob));
            UnKnown4(GetUInt(234U, 337U, blob));
            UnKnown5(GetUInt(238U, 241U, blob));
            Ecu(GetUInt(242U, 245U, blob));
            EngineTune(GetUInt(246U, 249U, blob));
            Turbo(GetUInt(250U, 253U, blob));
            Flywheel(GetUInt(254U, 257U, blob));
            Clutch(GetUInt(258U, 261U, blob));
            Driveshaft(GetUInt(262U, 265U, blob));
            Exhaust(GetUInt(266U, 269U, blob));
            UnKnown6(GetUInt(270U, 273U, blob));
            Asm(GetUInt(274U, 277U, blob));
            Tcs(GetUInt(278U, 281U, blob));
            UnKnown7(GetUInt(282U, 285U, blob));
            Supercharger(GetUInt(286U, 289U, blob));
            Intake(GetUInt(290U, 293U, blob));
            ExhaustManifold(GetUInt(294U, 297U, blob));
            CatConverter(GetUInt(298U, 301U, blob));
            AirFilter(GetUInt(302U, 305U, blob));
            UnKnown8(GetUInt(306U, 309U, blob));
            WindowWr(GetUInt(310U, 313U, blob));
            Hood(GetUInt(314U, 317U, blob));
            FrBumper(GetUInt(318U, 321U, blob));
            RrBumper(GetUInt(322U, 325U, blob));
            Extension(GetUInt(326U, 329U, blob));
            Wing(GetUInt(330U, 333U, blob));
            UnKnown9(GetUInt(334U, 337U, blob));
            Reinforcement(GetUInt(338U, 341U, blob));
            Nos(GetUInt(342U, 345U, blob));
            FrRim(GetByte(173U, blob));
            RrRim(GetByte(177U, blob));
        }

        public uint Airfilter
        {
            get { return _airfilter; }
            set { _airfilter = value; }
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

        public byte UnKnown1()
        {
            return _unKnown1;
        }

        public void UnKnown1(byte byte_33)
        {
            _unKnown1 = byte_33;
        }

        public byte UnKnown2()
        {
            return _unKnown2;
        }

        public void UnKnown2(byte byte_33)
        {
            _unKnown2 = byte_33;
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

        public void G2(uint val)
        {
            _g2 = val;
        }

        public uint G3()
        {
            return _g3;
        }

        public void G3(uint val)
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

        public void G8(uint val)
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
            return _springF;
        }

        public void SpringF(byte byte_33)
        {
            _springF = byte_33;
        }

        public byte SpringR()
        {
            return _springR;
        }

        public void SpringR(byte byte_33)
        {
            _springR = byte_33;
        }

        public byte ExtenF()
        {
            return _extenF;
        }

        public void ExtenF(byte byte_33)
        {
            _extenF = byte_33;
        }

        public byte CompF()
        {
            return _compF;
        }

        public void CompF(byte byte_33)
        {
            _compF = byte_33;
        }

        public byte ExtenR()
        {
            return _extenR;
        }

        public void ExtenR(byte byte_33)
        {
            _extenR = byte_33;
        }

        public byte CompR()
        {
            return _compR;
        }

        public void CompR(byte byte_33)
        {
            _compR = byte_33;
        }

        public byte AntiRollBarF()
        {
            return _antiRollBarF;
        }

        public void AntiRollBarF(byte byte_33)
        {
            _antiRollBarF = byte_33;
        }

        public byte AntiRollBarR()
        {
            return _antiRollBarR;
        }

        public void AntiRollBarR(byte byte_33)
        {
            _antiRollBarR = byte_33;
        }

        public byte LsdInitF()
        {
            return _lsdInitF;
        }

        public void LsdInitF(byte byte_33)
        {
            _lsdInitF = byte_33;
        }

        public byte LsdInitR()
        {
            return _lsdInitR;
        }

        public void LsdInitR(byte byte_33)
        {
            _lsdInitR = byte_33;
        }

        public byte LsdAccF()
        {
            return _lsdAccF;
        }

        public void LsdAccF(byte byte_33)
        {
            _lsdAccF = byte_33;
        }

        public byte LsdAccR()
        {
            return _lsdAccR;
        }

        public void LsdAccR(byte byte_33)
        {
            _lsdAccR = byte_33;
        }

        public byte LsdDecF()
        {
            return _lsdDecF;
        }

        public void LsdDecF(byte byte_33)
        {
            _lsdDecF = byte_33;
        }

        public byte LsdDecR()
        {
            return _lsdDecR;
        }

        public void LsdDecR(byte byte_33)
        {
            _lsdDecR = byte_33;
        }

        public byte BallastKg()
        {
            return _ballastKg;
        }

        public void BallastKg(byte val)
        {
            _ballastKg = val;
        }

        public sbyte BallastPos()
        {
            return _ballastPos;
        }

        public void BallastPos(sbyte val)
        {
            _ballastPos = val;
        }

        public byte Bbf()
        {
            return _bbf;
        }

        public void Bbf(byte byte_33)
        {
            _bbf = byte_33;
        }

        public byte Bbr()
        {
            return _bbr;
        }

        public void Bbr(byte byte_33)
        {
            _bbr = byte_33;
        }

        public uint Uint1()
        {
            return _uInt1;
        }

        public void Uint1(uint uint_61)
        {
            _uInt1 = uint_61;
        }

        public byte Colour()
        {
            return _colour;
        }

        public void Colour(byte val)
        {
            _colour = val;
        }

        public uint Paint()
        {
            return _paint;
        }

        public void Paint(uint uint_61)
        {
            _paint = uint_61;
        }

        public byte FrRim()
        {
            return _frRim;
        }

        public void FrRim(byte byte_33)
        {
            _frRim = byte_33;
        }

        public byte RrRim()
        {
            return _rrRim;
        }

        public void RrRim(byte byte_33)
        {
            _rrRim = byte_33;
        }

        public byte Bhp()
        {
            return _bhp;
        }

        public void Bhp(byte val)
        {
            _bhp = val;
        }

        public byte Grip()
        {
            return _grip;
        }

        public void Grip(byte val)
        {
            _grip = val;
        }

        public byte Weight()
        {
            return _weight;
        }

        public void Weight(byte val)
        {
            _weight = val;
        }

        public uint Body()
        {
            return _body;
        }

        public void Body(uint val)
        {
            _body = val;
        }

        public uint Brakes()
        {
            return _brakes;
        }

        public void Brakes(uint val)
        {
            _brakes = val;
        }

        public uint UnKnown10()
        {
            return _unKnown10;
        }

        public void UnKnown10(uint uint_61)
        {
            _unKnown10 = uint_61;
        }

        public uint Chassis()
        {
            return _chassis;
        }

        public void Chassis(uint val)
        {
            _chassis = val;
        }

        public uint Engine()
        {
            return _engine;
        }

        public void Engine(uint val)
        {
            _engine = val;
        }

        public uint DriveTrain()
        {
            return _driveTrain;
        }

        public void DriveTrain(uint val)
        {
            _driveTrain = val;
        }

        public uint Transmission()
        {
            return _transmission;
        }

        public void Transmission(uint val)
        {
            _transmission = val;
        }

        public uint Suspension()
        {
            return _suspension;
        }

        public void Suspension(uint val)
        {
            _suspension = val;
        }

        public uint Lsd()
        {
            return _lsd;
        }

        public void Lsd(uint val)
        {
            _lsd = val;
        }

        public uint UnKnown3()
        {
            return _unKnown3;
        }

        public void UnKnown3(uint uint_61)
        {
            _unKnown3 = uint_61;
        }

        public uint WReduction()
        {
            return _wReduction;
        }

        public void WReduction(uint val)
        {
            _wReduction = val;
        }

        public uint UnKnown4()
        {
            return _unKnown4;
        }

        public void UnKnown4(uint uint_61)
        {
            _unKnown4 = uint_61;
        }

        public uint UnKnown5()
        {
            return _unKnown5;
        }

        public void UnKnown5(uint uint_61)
        {
            _unKnown5 = uint_61;
        }

        public uint Ecu()
        {
            return _ecu;
        }

        public void Ecu(uint val)
        {
            _ecu = val;
        }

        public uint EngineTune()
        {
            return _engineTune;
        }

        public void EngineTune(uint val)
        {
            _engineTune = val;
        }

        public uint Turbo()
        {
            return _turbo;
        }

        public void Turbo(uint val)
        {
            _turbo = val;
        }

        public uint Flywheel()
        {
            return _flywheel;
        }

        public void Flywheel(uint val)
        {
            _flywheel = val;
        }

        public uint Clutch()
        {
            return _clutch;
        }

        public void Clutch(uint val)
        {
            _clutch = val;
        }

        public uint Driveshaft()
        {
            return _driveshaft;
        }

        public void Driveshaft(uint val)
        {
            _driveshaft = val;
        }

        public uint Exhaust()
        {
            return _exhaust;
        }

        public void Exhaust(uint val)
        {
            _exhaust = val;
        }

        public uint UnKnown6()
        {
            return _unKnown6;
        }

        public void UnKnown6(uint uint_61)
        {
            _unKnown6 = uint_61;
        }

        public uint Asm()
        {
            return _asm;
        }

        public void Asm(uint val)
        {
            _asm = val;
        }

        public uint Tcs()
        {
            return _tcs;
        }

        public void Tcs(uint val)
        {
            _tcs = val;
        }

        public uint UnKnown7()
        {
            return _unKnown7;
        }

        public void UnKnown7(uint uint_61)
        {
            _unKnown7 = uint_61;
        }

        public uint Supercharger()
        {
            return _supercharger;
        }

        public void Supercharger(uint val)
        {
            _supercharger = val;
        }

        public uint Intake()
        {
            return _intake;
        }

        public void Intake(uint val)
        {
            _intake = val;
        }

        public uint ExhaustManifold()
        {
            return _exhaustManifold;
        }

        public void ExhaustManifold(uint val)
        {
            _exhaustManifold = val;
        }

        public uint CatConverter()
        {
            return _catConverter;
        }

        public void CatConverter(uint val)
        {
            _catConverter = val;
        }

        public uint AirFilter()
        {
            return _airfilter;
        }

        public void AirFilter(uint val)
        {
            _airfilter = val;
        }

        public uint UnKnown8()
        {
            return _unKnown8;
        }

        public void UnKnown8(uint uint_61)
        {
            _unKnown8 = uint_61;
        }

        public uint WindowWr()
        {
            return _windowWr;
        }

        public void WindowWr(uint val)
        {
            _windowWr = val;
        }

        public uint Hood()
        {
            return _hood;
        }

        public void Hood(uint val)
        {
            _hood = val;
        }

        public uint FrBumper()
        {
            return _frBumper;
        }

        public void FrBumper(uint val)
        {
            _frBumper = val;
        }

        public uint RrBumper()
        {
            return _rrBumper;
        }

        public void RrBumper(uint val)
        {
            _rrBumper = val;
        }

        public uint Extension()
        {
            return _extension;
        }

        public void Extension(uint val)
        {
            _extension = val;
        }

        public uint Wing()
        {
            return _wing;
        }

        public void Wing(uint val)
        {
            _wing = val;
        }

        public uint UnKnown9()
        {
            return _unKnown9;
        }

        public void UnKnown9(uint uint_61)
        {
            _unKnown9 = uint_61;
        }

        public uint Reinforcement()
        {
            return _reinforcement;
        }

        public void Reinforcement(uint val)
        {
            _reinforcement = val;
        }

        public uint Nos()
        {
            return _nos;
        }

        public void Nos(uint val)
        {
            _nos = val;
        }

        public static uint GetUInt(uint start, uint end, byte[] blob)
        {
            uint num = 0U;
            for (uint index = start; index <= end; ++index)
                num = (int) index != (int) start ? num << 8 | blob[index] : blob[index];
            return num;
        }

        public static byte GetByte(uint location, byte[] blob)
        {
            return blob[location];
        }
    }
}