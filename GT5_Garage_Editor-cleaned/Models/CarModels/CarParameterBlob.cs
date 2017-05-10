namespace GT5_Garage_Editor.Models.CarModels
{
    public sealed class CarParameterBlob
    {
        public CarParameterBlob()
        {
            FullBlob = new byte[679];
        }

        public CarParameterBlob(byte[] blob)
        {
            FullBlob = (new byte[679]);
            FullBlob = blob;
            Metres = GetUInt(37U, 40U, blob);
            Wash = GetUInt(41U, 44U, blob);
            Oil = GetUInt(49U, 52U, blob);
            Changes = GetUInt(65U, 66U, blob);
            Wins = GetUInt(67U, 68U, blob);
            Paint = GetUInt(77U, 80U, blob);
            UnKnown1 = GetByte(183U, blob);
            UnKnown2 = GetByte(191U, blob);
            FrTyre = GetByte(185U, blob);
            RrTyre = GetByte(193U, blob);
            Brakes = GetUInt(194U, 197U, blob);
            GearRev = GetUInt(346U, 347U, blob);
            G1 = GetUInt(348U, 349U, blob);
            G2 = GetUInt(350U, 351U, blob);
            G3 = GetUInt(352U, 353U, blob);
            G4 = GetUInt(354U, 355U, blob);
            G5 = GetUInt(356U, 357U, blob);
            G6 = GetUInt(358U, 359U, blob);
            G7 = GetUInt(360U, 361U, blob);
            G8 = GetUInt(362U, 363U, blob);
            G9 = GetUInt(364U, 365U, blob);
            G10 = GetUInt(366U, 367U, blob);
            G11 = GetUInt(368U, 369U, blob);
            GFinal = GetUInt(370U, 371U, blob);
            FrTorque = GetByte(375U, blob);
            DfF = GetByte(378U, blob);
            DfR = GetByte(379U, blob);
            CamberFront = GetByte(386U, blob);
            CamberR = GetByte(387U, blob);
            RideHeightF = GetUInt(388U, 389U, blob);
            RideHeightR = GetUInt(390U, 391U, blob);
            ToeF = (sbyte) GetByte(392U, blob);
            ToeR = (sbyte) GetByte(393U, blob);
            SpringF = GetByte(394U, blob);
            SpringR = GetByte(395U, blob);
            ExtenF = GetByte(399U, blob);
            CompF = GetByte(401U, blob);
            ExtenR = GetByte(403U, blob);
            CompR = GetByte(405U, blob);
            AntiRollBarF = GetByte(406U, blob);
            AntiRollBarR = GetByte(407U, blob);
            LsdInitF = GetByte(408U, blob);
            LsdAccF = GetByte(410U, blob);
            LsdDecF = GetByte(412U, blob);
            LsdInitR = GetByte(409U, blob);
            LsdAccR = GetByte(411U, blob);
            LsdDecR = GetByte(413U, blob);
            BallastKg = GetByte(419U, blob);
            BallastPos = (sbyte) GetByte(420U, blob);
            Grip = GetByte(431U, blob);
            Bbf = GetByte(432U, blob);
            Bbr = GetByte(433U, blob);
            Body = GetUInt(159U, 160U, blob);
            Colour = (byte) GetUInt(169U, 169U, blob);
            Chassis = GetUInt(202U, 205U, blob);
            Engine = GetUInt(206U, 209U, blob);
            Bhp = (byte) GetUInt(422U, 422U, blob);
            Weight = (byte) GetUInt(425U, 425U, blob);
            DriveTrain = GetUInt(210U, 213U, blob);
            Transmission = GetUInt(214U, 217U, blob);
            Suspension = GetUInt(218U, 221U, blob);
            Lsd = GetUInt(222U, 225U, blob);
            Body = GetUInt(157U, 160U, blob);
            Brakes = GetUInt(194U, 197U, blob);
            UnKnown10 = GetUInt(198U, 201U, blob);
            Chassis = GetUInt(202U, 205U, blob);
            Engine = GetUInt(206U, 209U, blob);
            DriveTrain = GetUInt(210U, 213U, blob);
            Transmission = GetUInt(214U, 217U, blob);
            Suspension = GetUInt(218U, 221U, blob);
            Lsd = GetUInt(222U, 225U, blob);
            UnKnown3 = GetUInt(226U, 229U, blob);
            WReduction = GetUInt(230U, 233U, blob);
            UnKnown4 = GetUInt(234U, 337U, blob);
            UnKnown5 = GetUInt(238U, 241U, blob);
            Ecu = GetUInt(242U, 245U, blob);
            EngineTune = GetUInt(246U, 249U, blob);
            Turbo = GetUInt(250U, 253U, blob);
            Flywheel = GetUInt(254U, 257U, blob);
            Clutch = GetUInt(258U, 261U, blob);
            Driveshaft = GetUInt(262U, 265U, blob);
            Exhaust = GetUInt(266U, 269U, blob);
            UnKnown6 = GetUInt(270U, 273U, blob);
            Asm = GetUInt(274U, 277U, blob);
            Tcs = GetUInt(278U, 281U, blob);
            UnKnown7 = GetUInt(282U, 285U, blob);
            Supercharger = GetUInt(286U, 289U, blob);
            Intake = GetUInt(290U, 293U, blob);
            ExhaustManifold = GetUInt(294U, 297U, blob);
            CatConverter = GetUInt(298U, 301U, blob);
            Airfilter = GetUInt(302U, 305U, blob);
            UnKnown8 = GetUInt(306U, 309U, blob);
            WindowWr = GetUInt(310U, 313U, blob);
            Hood = GetUInt(314U, 317U, blob);
            FrBumper = GetUInt(318U, 321U, blob);
            RrBumper = GetUInt(322U, 325U, blob);
            Extension = GetUInt(326U, 329U, blob);
            Wing = GetUInt(330U, 333U, blob);
            UnKnown9 = GetUInt(334U, 337U, blob);
            Reinforcement = GetUInt(338U, 341U, blob);
            Nos = GetUInt(342U, 345U, blob);
            FrRim = GetByte(173U, blob);
            RrRim = GetByte(177U, blob);
        }

        public uint Airfilter { get; set; }

        public byte AntiRollBarF { get; set; }

        public byte AntiRollBarR { get; set; }

        public uint Asm { get; set; }

        public byte BallastKg { get; set; }

        public byte Bbf { get; set; }

        public byte Bbr { get; set; }

        public byte Bhp { get; set; }

        public uint Body { get; set; }

        public uint Brakes { get; set; }

        public byte CamberFront { get; set; }

        public byte CamberR { get; set; }

        public uint CatConverter { get; set; }

        public uint Changes { get; set; }

        public uint Chassis { get; set; }

        public uint Clutch { get; set; }

        public byte Colour { get; set; }

        public byte CompR { get; set; }

        public byte DfF { get; set; }

        public byte DfR { get; set; }

        public uint DriveTrain { get; set; }

        public uint Driveshaft { get; set; }

        public uint Ecu { get; set; }

        public uint Engine { get; set; }

        public uint EngineTune { get; set; }

        public uint ExhaustManifold { get; set; }

        public byte ExtenF { get; set; }

        public byte ExtenR { get; set; }

        public uint Extension { get; set; }

        public uint Flywheel { get; set; }

        public uint FrBumper { get; set; }

        public byte FrRim { get; set; }

        public byte FrTyre { get; set; }

        public byte[] FullBlob { get; set; }

        public uint G1 { get; set; }

        public uint G10 { get; set; }

        public uint G11 { get; set; }

        public uint G3 { get; set; }

        public uint G4 { get; set; }

        public uint G5 { get; set; }

        public uint G7 { get; set; }

        public uint G8 { get; set; }

        public uint G9 { get; set; }

        public uint GFinal { get; set; }

        public byte Grip { get; set; }

        public uint Hood { get; set; }

        public byte LsdAccF { get; set; }

        public byte LsdDecR { get; set; }

        public byte LsdInitF { get; set; }

        public byte LsdInitR { get; set; }

        public uint Metres { get; set; }

        public uint Nos { get; set; }

        public uint Oil { get; set; }

        public uint Paint { get; set; }

        public uint Reinforcement { get; set; }

        public uint RideHeightF { get; set; }

        public uint RideHeightR { get; set; }

        public uint RrBumper { get; set; }

        public byte RrRim { get; set; }

        public byte RrTyre { get; set; }

        public byte SpringF { get; set; }

        public uint Supercharger { get; set; }

        public uint Suspension { get; set; }

        public uint Tcs { get; set; }

        public sbyte ToeF { get; set; }

        public sbyte ToeR { get; set; }

        public uint Transmission { get; set; }

        public uint Turbo { get; set; }

        public uint UInt1 { get; set; }

        public uint UnKnown10 { get; set; }

        public byte UnKnown2 { get; set; }

        public uint UnKnown3 { get; set; }

        public uint UnKnown4 { get; set; }

        public uint UnKnown5 { get; set; }

        public uint UnKnown6 { get; set; }

        public uint UnKnown8 { get; set; }

        public uint UnKnown9 { get; set; }

        public uint WReduction { get; set; }

        public uint Wash { get; set; }

        public byte Weight { get; set; }

        public uint WindowWr { get; set; }

        public uint Wing { get; set; }

        public uint Wins { get; set; }

        public uint UnKnown7 { get; set; }

        public byte UnKnown1 { get; set; }

        public byte SpringR { get; set; }

        public byte LsdDecF { get; set; }

        public byte LsdAccR { get; set; }

        public uint Lsd { get; set; }

        public uint Intake { get; set; }

        public uint GearRev { get; set; }

        public uint G6 { get; set; }

        public uint G2 { get; set; }

        public byte FrTorque { get; set; }

        public uint Exhaust { get; set; }

        public byte CompF { get; set; }

        public sbyte BallastPos { get; set; }

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