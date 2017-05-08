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
            InitCountry(string.Empty);
            InitTuner(string.Empty);
            InitDriveTrain(string.Empty);
            InitPowerRpm(string.Empty);
            InitNameJp(string.Empty);
            InitNameEn(string.Empty);
            InitGarageId(0U);
            InitCarCode(0U);
            InitColor(0U);
            InitType(0U);
            InitFav(0U);
            InitYear(0U);
            InitPower(0U);
            InitPp(0);
            InitMass(0U);
            InitOnline(0U);
            InitGrim(0U);
            InitOdometer(0U);
            InitRideCount(0U);
            InitObtained(0UL);
            InitAsp(0U);
            InitPaint(0);
            InitRidingOrder(0U);
            InitSlot(0U);
            InitInvalid(0U);
            InitLength(0U);
            InitCarCategory(0U);
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
                InitGarageId(uint.Parse(dt.Rows[0]["garage_id"].ToString()));
                InitCarCode(uint.Parse(dt.Rows[0]["car_code"].ToString()));
                InitColor(uint.Parse(dt.Rows[0]["color"].ToString()));
                InitType(uint.Parse(dt.Rows[0]["type"].ToString()));
                InitFav(uint.Parse(dt.Rows[0]["favorite"].ToString()));
                InitYear(uint.Parse(dt.Rows[0]["year"].ToString()));
                InitPower(uint.Parse(dt.Rows[0]["power"].ToString()));
                InitPp(int.Parse(dt.Rows[0]["pp"].ToString()));
                InitMass(uint.Parse(dt.Rows[0]["mass"].ToString()));
                InitOnline(uint.Parse(dt.Rows[0]["online"].ToString()));
                InitGrim(uint.Parse(dt.Rows[0]["grim_car_id"].ToString()));
                InitOdometer(uint.Parse(dt.Rows[0]["odometer"].ToString()));
                InitRideCount(uint.Parse(dt.Rows[0]["ride_count"].ToString()));
                InitObtained(ulong.Parse(dt.Rows[0]["obtained_date"].ToString()));
                InitAsp(uint.Parse(dt.Rows[0]["aspiration"].ToString()));
                InitPaint(int.Parse(dt.Rows[0]["paint_color"].ToString()));
                InitRidingOrder(uint.Parse(dt.Rows[0]["riding_order"].ToString()));
                InitSlot(uint.Parse(dt.Rows[0]["slot_id"].ToString()));
                InitInvalid(uint.Parse(dt.Rows[0]["invalid"].ToString()));
                InitLength(uint.Parse(dt.Rows[0]["length"].ToString()));
                InitCarCategory(uint.Parse(dt.Rows[0]["car_category"].ToString()));
                InitCountry(dt.Rows[0]["country"].ToString());
                InitTuner(dt.Rows[0]["tuner_label"].ToString());
                InitDriveTrain(dt.Rows[0]["drive_train"].ToString());
                InitPowerRpm(dt.Rows[0]["power_rpm"].ToString());
                InitNameJp(dt.Rows[0]["name_JP"].ToString());
                InitNameEn(dt.Rows[0]["name_EN"].ToString());
            }
            catch (Exception)
            {

            }
        }

        public uint GetGarageId()
        {
            return _garageId;
        }

        public void InitGarageId(uint id)
        {
            _garageId = id;
        }

        public uint GetCarCode()
        {
            return _carCode;
        }

        public void InitCarCode(uint code)
        {
            _carCode = code;
        }

        public uint GetColor()
        {
            return _color;
        }

        public void InitColor(uint color)
        {
            _color = color;
        }

        public uint GetType1()
        {
            return _type;
        }

        public void InitType(uint type)
        {
            _type = type;
        }

        public uint GetFav()
        {
            return _fav;
        }

        public void InitFav(uint fav)
        {
            _fav = fav;
        }

        public uint GetYear()
        {
            return _year;
        }

        public void InitYear(uint year)
        {
            _year = year;
        }

        public uint GetPower()
        {
            return _power;
        }

        public void InitPower(uint power)
        {
            _power = power;
        }

        public int GetPp()
        {
            return _pp;
        }

        public void InitPp(int pp)
        {
            _pp = pp;
        }

        public uint GetMass()
        {
            return _mass;
        }

        public void InitMass(uint mass)
        {
            _mass = mass;
        }

        public uint GetOnline()
        {
            return _online;
        }

        public void InitOnline(uint online)
        {
            _online = online;
        }

        public uint GetGrim()
        {
            return _grim;
        }

        public void InitGrim(uint grim)
        {
            _grim = grim;
        }

        public uint GetOdo()
        {
            return _odo;
        }

        public void InitOdometer(uint odo)
        {
            _odo = odo;
        }

        public uint GetRideCount()
        {
            return _rideCount;
        }

        public void InitRideCount(uint rCount)
        {
            _rideCount = rCount;
        }

        public ulong GetObtained()
        {
            return _obtained;
        }

        public void InitObtained(ulong obt)
        {
            _obtained = obt;
        }

        public uint GetAsp()
        {
            return _asp;
        }

        public void InitAsp(uint asp)
        {
            _asp = asp;
        }

        public int GetPaint()
        {
            return _paint;
        }

        public void InitPaint(int paint)
        {
            _paint = paint;
        }

        public uint GetRidingOrder()
        {
            return _ridingOrder;
        }

        public void InitRidingOrder(uint rOrder)
        {
            _ridingOrder = rOrder;
        }

        public uint GetSlot()
        {
            return _slot;
        }

        public void InitSlot(uint slot)
        {
            _slot = slot;
        }

        public uint GetInvalid()
        {
            return _invalid;
        }

        public void InitInvalid(uint invalid)
        {
            _invalid = invalid;
        }

        public uint GetLength()
        {
            return _length;
        }

        public void InitLength(uint len)
        {
            _length = len;
        }

        public uint GetCategory()
        {
            return _category;
        }

        public void InitCarCategory(uint cat)
        {
            _category = cat;
        }

        public string GetCountry()
        {
            return _country;
        }

        public void InitCountry(string country)
        {
            _country = country;
        }

        public string GetTuner()
        {
            return _tuner;
        }

        public void InitTuner(string tuner)
        {
            _tuner = tuner;
        }

        public string GetDt()
        {
            return _dt;
        }

        public void InitDriveTrain(string dt)
        {
            _dt = dt;
        }

        public string GetRpm()
        {
            return _rpm;
        }

        public void InitPowerRpm(string rpm)
        {
            _rpm = rpm;
        }

        public string GetNameJp()
        {
            return _nameJp;
        }

        public void InitNameJp(string nameJp)
        {
            _nameJp = nameJp;
        }

        public string GetNameEn()
        {
            return _nameEn;
        }

        public void InitNameEn(string name)
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
