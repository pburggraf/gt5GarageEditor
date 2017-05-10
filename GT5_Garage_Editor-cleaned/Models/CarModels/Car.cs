using System;
using System.Data;

namespace GT5_Garage_Editor.Models.CarModels
{
    public sealed class Car
    {
        public uint GarageId { get; set; }

        public uint CarCode { get; set; }

        public uint Color { get; set; }

        public uint Type { get; set; }

        public uint Fav { get; set; }

        public uint Year { get; set; }

        public uint Power { get; set; }

        public int Pp { get; set; }

        public uint Mass { get; set; }

        public uint Online { get; set; }

        public uint Grim { get; set; }

        public uint Odo { get; set; }

        public uint RideCount { get; set; }

        public ulong Obtained { get; set; }

        public uint Asp { get; set; }

        public int Paint { get; set; }

        public uint RidingOrder { get; set; }

        public uint Slot { get; set; }

        public uint Invalid { get; set; }

        public uint Length { get; set; }

        public uint Category { get; set; }

        public string Country { get; set; }

        public string Tuner { get; set; }

        public string DriveTrain { get; set; }

        public string PowerRpm { get; set; }

        public string NameJp { get; set; }

        public string NameEn { get; set; }

        public CarParameterBlob SheetA { get; set; }

        public CarParameterBlob SheetB { get; set; }

        public CarParameterBlob SheetC { get; set; }

        public Car()
        {
            Country = string.Empty;
            Tuner = string.Empty;
            DriveTrain = string.Empty;
            PowerRpm = string.Empty;
            NameJp = string.Empty;
            NameEn = string.Empty;
            GarageId = 0U;
            CarCode = 0U;
            Color = 0U;
            Type = 0U;
            Fav = 0U;
            Year = 0U;
            Power = 0U;
            Pp = 0;
            Mass = 0U;
            Online = 0U;
            Grim = 0U;
            Odo = 0U;
            RideCount = 0U;
            Obtained = 0UL;
            Asp = 0U;
            Paint = 0;
            RidingOrder = 0U;
            Slot = 0U;
            Invalid = 0U;
            Length = 0U;
            Category = 0U;
            SheetA = new CarParameterBlob();
            SheetB = new CarParameterBlob();
            SheetC = new CarParameterBlob();
        }

        public Car(DataTable dt)
        {
            try
            {
                SheetA = (new CarParameterBlob((byte[])dt.Rows[0]["carparameter"]));
                SheetB = (new CarParameterBlob((byte[])dt.Rows[0]["carparameterB"]));
                SheetC = (new CarParameterBlob((byte[])dt.Rows[0]["carparameterC"]));
                GarageId = (uint.Parse(dt.Rows[0]["garage_id"].ToString()));
                CarCode = (uint.Parse(dt.Rows[0]["car_code"].ToString()));
                Color = (uint.Parse(dt.Rows[0]["color"].ToString()));
                Type = (uint.Parse(dt.Rows[0]["type"].ToString()));
                Fav = (uint.Parse(dt.Rows[0]["favorite"].ToString()));
                Year = (uint.Parse(dt.Rows[0]["year"].ToString()));
                Power = (uint.Parse(dt.Rows[0]["power"].ToString()));
                Pp = (int.Parse(dt.Rows[0]["pp"].ToString()));
                Mass = (uint.Parse(dt.Rows[0]["mass"].ToString()));
                Online = (uint.Parse(dt.Rows[0]["online"].ToString()));
                Grim = (uint.Parse(dt.Rows[0]["grim_car_id"].ToString()));
                Odo = (uint.Parse(dt.Rows[0]["odometer"].ToString()));
                RideCount = (uint.Parse(dt.Rows[0]["ride_count"].ToString()));
                Obtained = (ulong.Parse(dt.Rows[0]["obtained_date"].ToString()));
                Asp = (uint.Parse(dt.Rows[0]["aspiration"].ToString()));
                Paint = (int.Parse(dt.Rows[0]["paint_color"].ToString()));
                RidingOrder = (uint.Parse(dt.Rows[0]["riding_order"].ToString()));
                Slot = (uint.Parse(dt.Rows[0]["slot_id"].ToString()));
                Invalid = (uint.Parse(dt.Rows[0]["invalid"].ToString()));
                Length = (uint.Parse(dt.Rows[0]["length"].ToString()));
                Category = (uint.Parse(dt.Rows[0]["car_category"].ToString()));
                Country = (dt.Rows[0]["country"].ToString());
                Tuner = (dt.Rows[0]["tuner_label"].ToString());
                DriveTrain = (dt.Rows[0]["drive_train"].ToString());
                PowerRpm = (dt.Rows[0]["power_rpm"].ToString());
                NameJp = (dt.Rows[0]["name_JP"].ToString());
                NameEn = (dt.Rows[0]["name_EN"].ToString());
            }
            catch (Exception)
            {

            }
        }
    }
}
