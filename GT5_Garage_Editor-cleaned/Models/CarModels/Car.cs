using System;
using System.Data;

namespace GT5_Garage_Editor.Models.CarModels
{
    public sealed class Car
    {
        private uint _garageId;
        private uint _carCode;
        private uint _color;
        private uint _type;
        private uint _fav;
        private uint _year;
        private uint _power;
        private int _pp;
        private uint _mass;
        private uint _online;
        private uint _grim;
        private uint _odo;
        private uint _rideCount;
        private ulong _obtained;
        private uint _asp;
        private int _paint;
        private uint _ridingOrder;
        private uint _slot;
        private uint _invalid;
        private uint _length;
        private uint _category;
        private string _country;
        private string _tuner;
        private string _dt;
        private string _rpm;
        private string _nameJp;
        private string _nameEn;
        private CarParameterBlob _carParameterBlob1;
        private CarParameterBlob _carParameterBlob2;
        private CarParameterBlob _carParameterBlob3;

        public Car()
        {
            Country(string.Empty);
            Tuner(string.Empty);
            DriveTrain(string.Empty);
            PowerRpm(string.Empty);
            NameJp(string.Empty);
            NameEn(string.Empty);
            GarageId(0U);
            CarCode(0U);
            Color(0U);
            Type(0U);
            Fav(0U);
            Year(0U);
            Power(0U);
            Pp(0);
            Mass(0U);
            Online(0U);
            Grim(0U);
            Odometer(0U);
            RideCount(0U);
            Obtained(0UL);
            Asp(0U);
            Paint(0);
            RidingOrder(0U);
            Slot(0U);
            Invalid(0U);
            Length(0U);
            CarCategory(0U);
            UpdateBlob1(new CarParameterBlob());
            UpdateBlob2(new CarParameterBlob());
            UpdateBlob3(new CarParameterBlob());
        }

        public Car(DataTable dt)
        {
            try
            {
                UpdateBlob1(new CarParameterBlob((byte[])dt.Rows[0]["carparameter"]));
                UpdateBlob2(new CarParameterBlob((byte[])dt.Rows[0]["carparameterB"]));
                UpdateBlob3(new CarParameterBlob((byte[])dt.Rows[0]["carparameterC"]));
                GarageId(uint.Parse(dt.Rows[0]["garage_id"].ToString()));
                CarCode(uint.Parse(dt.Rows[0]["car_code"].ToString()));
                Color(uint.Parse(dt.Rows[0]["color"].ToString()));
                Type(uint.Parse(dt.Rows[0]["type"].ToString()));
                Fav(uint.Parse(dt.Rows[0]["favorite"].ToString()));
                Year(uint.Parse(dt.Rows[0]["year"].ToString()));
                Power(uint.Parse(dt.Rows[0]["power"].ToString()));
                Pp(int.Parse(dt.Rows[0]["pp"].ToString()));
                Mass(uint.Parse(dt.Rows[0]["mass"].ToString()));
                Online(uint.Parse(dt.Rows[0]["online"].ToString()));
                Grim(uint.Parse(dt.Rows[0]["grim_car_id"].ToString()));
                Odometer(uint.Parse(dt.Rows[0]["odometer"].ToString()));
                RideCount(uint.Parse(dt.Rows[0]["ride_count"].ToString()));
                Obtained(ulong.Parse(dt.Rows[0]["obtained_date"].ToString()));
                Asp(uint.Parse(dt.Rows[0]["aspiration"].ToString()));
                Paint(int.Parse(dt.Rows[0]["paint_color"].ToString()));
                RidingOrder(uint.Parse(dt.Rows[0]["riding_order"].ToString()));
                Slot(uint.Parse(dt.Rows[0]["slot_id"].ToString()));
                Invalid(uint.Parse(dt.Rows[0]["invalid"].ToString()));
                Length(uint.Parse(dt.Rows[0]["length"].ToString()));
                CarCategory(uint.Parse(dt.Rows[0]["car_category"].ToString()));
                Country(dt.Rows[0]["country"].ToString());
                Tuner(dt.Rows[0]["tuner_label"].ToString());
                DriveTrain(dt.Rows[0]["drive_train"].ToString());
                PowerRpm(dt.Rows[0]["power_rpm"].ToString());
                NameJp(dt.Rows[0]["name_JP"].ToString());
                NameEn(dt.Rows[0]["name_EN"].ToString());
            }
            catch (Exception)
            {

            }
        }

        public uint GetGarageId()
        {
            return _garageId;
        }

        public void GarageId(uint id)
        {
            _garageId = id;
        }

        public uint GetCarCode()
        {
            return _carCode;
        }

        public void CarCode(uint code)
        {
            _carCode = code;
        }

        public uint GetColor()
        {
            return _color;
        }

        public void Color(uint color)
        {
            _color = color;
        }

        public uint GetType1()
        {
            return _type;
        }

        public void Type(uint type)
        {
            _type = type;
        }

        public uint GetFav()
        {
            return _fav;
        }

        public void Fav(uint fav)
        {
            _fav = fav;
        }

        public uint GetYear()
        {
            return _year;
        }

        public void Year(uint year)
        {
            _year = year;
        }

        public uint GetPower()
        {
            return _power;
        }

        public void Power(uint power)
        {
            _power = power;
        }

        public int GetPp()
        {
            return _pp;
        }

        public void Pp(int pp)
        {
            _pp = pp;
        }

        public uint GetMass()
        {
            return _mass;
        }

        public void Mass(uint mass)
        {
            _mass = mass;
        }

        public uint GetOnline()
        {
            return _online;
        }

        public void Online(uint online)
        {
            _online = online;
        }

        public uint GetGrim()
        {
            return _grim;
        }

        public void Grim(uint grim)
        {
            _grim = grim;
        }

        public uint GetOdo()
        {
            return _odo;
        }

        public void Odometer(uint odo)
        {
            _odo = odo;
        }

        public uint GetRideCount()
        {
            return _rideCount;
        }

        public void RideCount(uint rCount)
        {
            _rideCount = rCount;
        }

        public ulong GetObtained()
        {
            return _obtained;
        }

        public void Obtained(ulong obt)
        {
            _obtained = obt;
        }

        public uint GetAsp()
        {
            return _asp;
        }

        public void Asp(uint asp)
        {
            _asp = asp;
        }

        public int GetPaint()
        {
            return _paint;
        }

        public void Paint(int paint)
        {
            _paint = paint;
        }

        public uint GetRidingOrder()
        {
            return _ridingOrder;
        }

        public void RidingOrder(uint rOrder)
        {
            _ridingOrder = rOrder;
        }

        public uint GetSlot()
        {
            return _slot;
        }

        public void Slot(uint slot)
        {
            _slot = slot;
        }

        public uint GetInvalid()
        {
            return _invalid;
        }

        public void Invalid(uint invalid)
        {
            _invalid = invalid;
        }

        public uint GetLength()
        {
            return _length;
        }

        public void Length(uint len)
        {
            _length = len;
        }

        public uint GetCategory()
        {
            return _category;
        }

        public void CarCategory(uint cat)
        {
            _category = cat;
        }

        public string GetCountry()
        {
            return _country;
        }

        public void Country(string country)
        {
            _country = country;
        }

        public string GetTuner()
        {
            return _tuner;
        }

        public void Tuner(string tuner)
        {
            _tuner = tuner;
        }

        public string GetDt()
        {
            return _dt;
        }

        public void DriveTrain(string dt)
        {
            _dt = dt;
        }

        public string GetRpm()
        {
            return _rpm;
        }

        public void PowerRpm(string rpm)
        {
            _rpm = rpm;
        }

        public string GetNameJp()
        {
            return _nameJp;
        }

        public void NameJp(string nameJp)
        {
            _nameJp = nameJp;
        }

        public string GetNameEn()
        {
            return _nameEn;
        }

        public void NameEn(string name)
        {
            _nameEn = name;
        }

        public CarParameterBlob GetBlob1()
        {
            return _carParameterBlob1;
        }

        public void UpdateBlob1(CarParameterBlob blob)
        {
            _carParameterBlob1 = blob;
        }

        public CarParameterBlob GetBlob2()
        {
            return _carParameterBlob2;
        }

        public void UpdateBlob2(CarParameterBlob blob)
        {
            _carParameterBlob2 = blob;
        }

        public CarParameterBlob GetBlob3()
        {
            return _carParameterBlob3;
        }

        public void UpdateBlob3(CarParameterBlob blob)
        {
            _carParameterBlob3 = blob;
        }
    }
}
