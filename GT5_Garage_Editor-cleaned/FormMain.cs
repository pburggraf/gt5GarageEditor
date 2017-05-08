﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using GT5_Garage_Editor.Models.CarModels;
using GT5_Garage_Editor.Utils;
using GT5_SaveEditor.Properties;

namespace GT5_Garage_Editor
{
    public sealed partial class FormMain : Form
    {
        private static byte _numberOfFilesInSave = 0;
        private static char _char0 = 'a';
        public static List<int> list_0 = new List<int>();
        public static List<int> list_1 = new List<int>();
        public static List<string> list_2 = new List<string>();
        public static List<int> list_3 = new List<int>();
        private DataTable dataTable_0 = new DataTable();
        private DataTable dataTable_1 = new DataTable();
        private DataTable dataTable_2 = new DataTable();
        private const string DBFileName = "\\_db";
        private DataTable dataTable_3 = new DataTable();
        private DataTable dataTable_4 = new DataTable();
        private DataTable dataTable_5 = new DataTable();
        private Car _tempCar = new Car();
        private readonly byte[] passBytes = new byte[16];
        private DataTable dataTable_6 = new DataTable();
        private DataTable dataTable_7 = new DataTable();
        private DataTable dataTable_8 = new DataTable();
        private Car _currentCar = new Car();
        private DataTable dataTable_9 = new DataTable();
        private string _pathToSave = string.Empty;
        public string _pathToGT5PointZero = string.Empty;
        private byte[] _dbPassBytes;
        private SqlHelper _sqlHelper;
        private SqlHelper _sqlHelper2;
        public ulong ulong_0;

        public FormMain()
        {
            try
            {
                _dbPassBytes = Encoding.ASCII.GetBytes("_akz&^_&*^950_dLu");
                _sqlHelper = new SqlHelper(Application.StartupPath + @"\Dependancies" + DBFileName, true, _dbPassBytes);
                GetTuners(_sqlHelper, ref dataTable_3);
                InitializeComponent();
                PopulateComboBoxFromDatatable(ref comboBox_SMake, ref dataTable_3);
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong: Error 101");
            }
        }

        public void GetTuners(SqlHelper sqlHelper, ref DataTable dt)
        {
            dt.Clear();
            dt = sqlHelper.ExecuteReader("SELECT DISTINCT tuner_label FROM t_garage;");
        }

        public void GetDistinctCarsByManufacturer(SqlHelper sqlHelper, ref DataTable dt)
        {
            dt.Clear();
            dt = sqlHelper.ExecuteReader("SELECT DISTINCT name_EN garage_id FROM t_garage WHERE tuner_label LIKE '" + comboBox_SMake.SelectedItem + "';");
        }

        public void GetCarsByManufacturer(SqlHelper sqlHelper, ref DataTable dt, ref ComboBox cb)
        {
            dt.Clear();
            dt = sqlHelper.ExecuteReader("SELECT name_EN, garage_id FROM t_garage WHERE tuner_label LIKE '" + cb.SelectedItem + "';");
        }

        public void UpdateCarParamBlobs(SqlHelper sqlhelper, Car car)
        {
            try
            {
                var connection = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\temp");
                connection.SetPassword(passBytes);
                connection.Open();
                var sqLiteCommand = new SQLiteCommand(connection);
                var parameter1 = new SQLiteParameter("@blobA", DbType.Binary);
                var parameter2 = new SQLiteParameter("@blobB", DbType.Binary);
                var parameter3 = new SQLiteParameter("@blobC", DbType.Binary);
                parameter1.Value = car.GetBlob1().GetBlob();
                parameter2.Value = car.GetBlob2().GetBlob();
                parameter3.Value = car.GetBlob3().GetBlob();
                sqLiteCommand.Parameters.Add(parameter1);
                sqLiteCommand.Parameters.Add(parameter2);
                sqLiteCommand.Parameters.Add(parameter3);
                sqLiteCommand.CommandText = string.Format("UPDATE t_garage SET carparameter = @blobA, carparameterB = @blobB, carparameterC = @blobC, country = 'HYBRID' WHERE garage_id = " + car.GetGarageId(), new object[0]);
                sqLiteCommand.ExecuteNonQuery();
                connection.Close();
            }
            catch
            {
                var num = (int)MessageBox.Show("Something went wrong: Error 101");
            }
        }

        private void tabPage_garage_Enter(object sender, EventArgs e)
        {
            try
            {
                groupBox4.Parent = tabPage_garage;
                groupBox3.Parent = tabPage_garage;
                PopulateComboBoxFromDatatable(ref comboBox_DMake, ref dataTable_6);
            }
            catch
            {
            }
        }

        private void tabPage_ridingCar_Enter(object sender, EventArgs e)
        {
            try
            {
                groupBox4.Parent = tabPage_ridingCar;
                groupBox3.Parent = tabPage_ridingCar;
                groupBox_Sheet.Enabled = false;
                comboBox_DMake.Items.Clear();
                comboBox_DModel.Items.Clear();
                comboBox_DMake.Items.Add("Riding Car");
                comboBox_DMake.SelectedIndex = 0;
                comboBox_DMake.Enabled = false;
                comboBox_DModel.Enabled = false;
                _char0 = 'a';
                _currentCar = new Car();
                var num = smethod_17("riding_car");
                var numArray = new byte[679];
                var fileStream = new FileStream(_pathToGT5PointZero, FileMode.Open);
                fileStream.Position = num;
                fileStream.ReadByte();
                if (fileStream.ReadByte() <= sbyte.MaxValue)
                    fileStream.Position = num + 22;
                else
                    fileStream.Position = num + 23;
                fileStream.Read(numArray, 25, 640);
                fileStream.Close();
                var gclass1_3 = new CarParameterBlob(numArray);
                _currentCar.UpdateBlob1(gclass1_3);
                _currentCar.UpdateBlob2(gclass1_3);
                _currentCar.UpdateBlob3(gclass1_3);
                LoadCarSheet('a');
            }
            catch
            {
            }
        }

        private void tabPage_ridingCar_Leave(object sender, EventArgs e)
        {
            var num = smethod_17("riding_car");
            var fileStream = new FileStream(_pathToGT5PointZero, FileMode.Open);
            fileStream.Position = num;
            fileStream.ReadByte();
            if (fileStream.ReadByte() <= sbyte.MaxValue)
                fileStream.Position = num + 22;
            else
                fileStream.Position = num + 23;
            fileStream.Write(_currentCar.GetBlob1().GetBlob(), 25, 640);
            fileStream.Close();
            comboBox_DMake.Items.Clear();
            comboBox_DModel.Items.Clear();
            comboBox_DMake.Enabled = true;
            comboBox_DModel.Enabled = true;
            RemoveDgvRows(ref dataGridView_Dest);
        }

        private void comboBox__gift_paintCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dataTable_2 = _sqlHelper.ExecuteReader("SELECT * FROM t_colour WHERE Colour_Category = " + comboBox__gift_paintCat.SelectedIndex + " ORDER BY Colour_Number");
                comboBox_gift_paintNum.Items.Clear();
                foreach (DataRow dataRow in (InternalDataCollectionBase)dataTable_2.Rows)
                    comboBox_gift_paintNum.Items.Add(dataRow.ItemArray[2].ToString());
                comboBox_gift_paintNum.SelectedIndex = 0;
            }
            catch
            {
            }
        }

        private void tabPage_gift_Enter(object sender, EventArgs e)
        {
            try
            {
                cB_special_car.SelectedIndex = 0;
                dataTable_1 = _sqlHelper.ExecuteReader("SELECT DISTINCT tuner FROM t_cars");
                cB_insert_tuner.Items.Clear();
                foreach (DataRow dataRow in (InternalDataCollectionBase)dataTable_1.Rows)
                    cB_insert_tuner.Items.Add(dataRow.ItemArray[0].ToString());
                cB_insert_tuner.SelectedIndex = 0;
                dataTable_2 = _sqlHelper.ExecuteReader("SELECT * FROM t_colour WHERE Colour_Category = 0 ORDER BY Colour_Number");
                comboBox_gift_paintNum.Items.Clear();
                foreach (DataRow dataRow in (InternalDataCollectionBase)dataTable_2.Rows)
                    comboBox_gift_paintNum.Items.Add(dataRow.ItemArray[2].ToString());
                comboBox_category_name.SelectedIndex = 0;
                comboBox_gameitem_id.SelectedIndex = 0;
                comboBox_gift_paintNum.SelectedIndex = 0;
                comboBox__gift_paintCat.SelectedIndex = 0;
                comboBox_tickets.SelectedIndex = 0;
                method_17();
            }
            catch
            {
            }
        }

        private void tabControl_garage_Enter(object sender, EventArgs e)
        {
        }

        private void tabPage_Adv_Enter(object sender, EventArgs e)
        {
            try
            {
                cB_Name_Make.Items.Clear();
                GetTuners(_sqlHelper2, ref dataTable_9);
                PopulateComboBoxFromDatatable(ref cB_Name_Make, ref dataTable_9);
                cB_Name_Make.SelectedIndex = 0;
                comboBox_func_edit.SelectedIndex = 0;
                comboBox_func_make.SelectedIndex = 0;
                tb_func_withvalue.Text = "000000FF";
                cb_a.Checked = true;
            }
            catch
            {
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            smethod_19(_pathToGT5PointZero, "friend_car_id", 4, uint.MaxValue);
            var num = (int)MessageBox.Show("Car has been permanently borrowed", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        public void LoadTempCarDetails()
        {
            textBox_SYear.Text = _tempCar.GetYear().ToString(CultureInfo.InvariantCulture);
            textBox_SDT.Text = _tempCar.GetDt();
            textBox_SCountry.Text = _tempCar.GetCountry();
        }

        public void LoadCurrentCarDetails()
        {
            try
            {
                textBox_DYear.Text = _currentCar.GetYear().ToString();
                textBox_DDT.Text = _currentCar.GetDt();
                textBox_DCountry.Text = _currentCar.GetCountry();
            }
            catch
            {
                var num = (int)MessageBox.Show(this, "An Error Occurred: Error 801\nDo not attempt to load older saves\nNOW EXITING", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                Application.Exit();
            }
        }

        public void PopulateComboBoxFromDatatable(ref ComboBox comboBox_0, ref DataTable dataTable_10)
        {
            comboBox_0.Items.Clear();
            foreach (DataRow dataRow in (InternalDataCollectionBase)dataTable_10.Rows)
                comboBox_0.Items.Add(dataRow.ItemArray[0].ToString());
        }

        private void comboBox_SMake_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _tempCar = new Car();
                LoadTempCarDetails();
                GetDistinctCarsByManufacturer(_sqlHelper, ref dataTable_4);
                PopulateComboBoxFromDatatable(ref comboBox_SModel, ref dataTable_4);
                comboBox_SModel.SelectedIndex = 0;
            }
            catch
            {
            }
        }

        private void comboBox_SModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataTable_5 = _sqlHelper.ExecuteReader("SELECT * FROM t_garage WHERE tuner_label LIKE '" + comboBox_SMake.SelectedItem + "' AND name_EN LIKE '" + comboBox_SModel.SelectedItem.ToString().Replace("'", "''") + "';");
            _tempCar = new Car(dataTable_5);
            LoadTempCarDetails();
            LoadSourceCarSheetA();
        }

        private void comboBox_DMake_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentCar = new Car();
            LoadCurrentCarDetails();
            GetCarsByManufacturer(_sqlHelper2, ref dataTable_7, ref comboBox_DMake);
            PopulateComboBoxFromDatatable(ref comboBox_DModel, ref dataTable_7);
        }

        private void comboBox_DModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataTable_8 = _sqlHelper2.ExecuteReader("SELECT * FROM t_garage WHERE garage_id LIKE " + dataTable_7.Rows[comboBox_DModel.SelectedIndex].ItemArray[1]);
            _currentCar = new Car(dataTable_8);
            LoadCurrentCarDetails();
            LoadCarSheet(_char0);
            groupBox_Sheet.Enabled = true;
        }

        private void comboBox_DMake_Enter(object sender, EventArgs e)
        {
            comboBox_DMake.SelectedIndex = 0;
        }

        public void LoadSourceCarSheetA()
        {
            var tempCar = _tempCar;
            textBox_SYear.Text = tempCar.GetYear().ToString();
            textBox_SDT.Text = tempCar.GetDt();
            textBox_SCountry.Text = tempCar.GetCountry();
            dataGridView_Source.Rows.Clear();
            AddColumnToDgv(ref dataGridView_Source, "Tune Sheet", 0U);
            AddColumnToDgv(ref dataGridView_Source, "Paint", tempCar.GetBlob1().Paint());
            AddColumnToDgv(ref dataGridView_Source, "Body", tempCar.GetBlob1().Body());
            AddColumnToDgv(ref dataGridView_Source, "Colour", tempCar.GetBlob1().Colour());
            AddColumnToDgv(ref dataGridView_Source, "Brakes", tempCar.GetBlob1().Brakes());
            AddColumnToDgv(ref dataGridView_Source, "_198_201", tempCar.GetBlob1()._198_201());
            AddColumnToDgv(ref dataGridView_Source, "Chassis", tempCar.GetBlob1().Chassis());
            AddColumnToDgv(ref dataGridView_Source, "Engine", tempCar.GetBlob1().Engine());
            AddColumnToDgv(ref dataGridView_Source, "Drivetrain", tempCar.GetBlob1().DriveTrain());
            AddColumnToDgv(ref dataGridView_Source, "Transmission", tempCar.GetBlob1().Transmission());
            AddColumnToDgv(ref dataGridView_Source, "Suspension", tempCar.GetBlob1().Suspension());
            AddColumnToDgv(ref dataGridView_Source, "LSD", tempCar.GetBlob1().LSD());
            AddColumnToDgv(ref dataGridView_Source, "_226_229", tempCar.GetBlob1().method_134());
            AddColumnToDgv(ref dataGridView_Source, "WReduction", tempCar.GetBlob1().WReduction());
            AddColumnToDgv(ref dataGridView_Source, "_234_237", tempCar.GetBlob1().method_138());
            AddColumnToDgv(ref dataGridView_Source, "_238_241", tempCar.GetBlob1().method_140());
            AddColumnToDgv(ref dataGridView_Source, "ECU", tempCar.GetBlob1().ECU());
            AddColumnToDgv(ref dataGridView_Source, "Engine Tune", tempCar.GetBlob1().EngineTune());
            AddColumnToDgv(ref dataGridView_Source, "Turbo", tempCar.GetBlob1().Turbo());
            AddColumnToDgv(ref dataGridView_Source, "Flywheel", tempCar.GetBlob1().Flywheel());
            AddColumnToDgv(ref dataGridView_Source, "Clutch", tempCar.GetBlob1().Clutch());
            AddColumnToDgv(ref dataGridView_Source, "Driveshaft", tempCar.GetBlob1().Driveshaft());
            AddColumnToDgv(ref dataGridView_Source, "Exhaust", tempCar.GetBlob1().Exhaust());
            AddColumnToDgv(ref dataGridView_Source, "_270_273", tempCar.GetBlob1().method_156());
            AddColumnToDgv(ref dataGridView_Source, "ASM Controller", tempCar.GetBlob1().ASM());
            AddColumnToDgv(ref dataGridView_Source, "TCS Controller", tempCar.GetBlob1().TCS());
            AddColumnToDgv(ref dataGridView_Source, "_282_285", tempCar.GetBlob1().method_162());
            AddColumnToDgv(ref dataGridView_Source, "Supercharger", tempCar.GetBlob1().Supercharger());
            AddColumnToDgv(ref dataGridView_Source, "Intake Manifold", tempCar.GetBlob1().Intake());
            AddColumnToDgv(ref dataGridView_Source, "Exhaust Manifold", tempCar.GetBlob1().ExhaustManifold());
            AddColumnToDgv(ref dataGridView_Source, "Catalytic Converter", tempCar.GetBlob1().CatConverter());
            AddColumnToDgv(ref dataGridView_Source, "Air Filter", tempCar.GetBlob1().AirFilter());
            AddColumnToDgv(ref dataGridView_Source, "_306_309", tempCar.GetBlob1().method_174());
            AddColumnToDgv(ref dataGridView_Source, "WindowWR", tempCar.GetBlob1().WindowWR());
            AddColumnToDgv(ref dataGridView_Source, "Hood", tempCar.GetBlob1().Hood());
            AddColumnToDgv(ref dataGridView_Source, "FrBumper", tempCar.GetBlob1().FrBumper());
            AddColumnToDgv(ref dataGridView_Source, "RrBumper", tempCar.GetBlob1().RrBumper());
            AddColumnToDgv(ref dataGridView_Source, "Extension", tempCar.GetBlob1().Extension());
            AddColumnToDgv(ref dataGridView_Source, "Wing", tempCar.GetBlob1().Wing());
            AddColumnToDgv(ref dataGridView_Source, "_334_337", tempCar.GetBlob1().method_188());
            AddColumnToDgv(ref dataGridView_Source, "Reinforcement", tempCar.GetBlob1().Reinforcement());
            AddColumnToDgv(ref dataGridView_Source, "NoS", tempCar.GetBlob1().Nos());
        }

        public void LoadCarSheet(char sheet)
        {
            try
            {
                var newCar = new Car();
                var tempCar = _currentCar;
                textBox_DYear.Text = tempCar.GetYear().ToString();
                textBox_DDT.Text = tempCar.GetDt();
                textBox_DCountry.Text = tempCar.GetCountry();
                while (Convert.ToBoolean(dataGridView_Dest.Rows.Count))
                    dataGridView_Dest.Rows.Remove(dataGridView_Dest.Rows[0]);
                switch (sheet)
                {
                    case 'a':
                        LoadItemToDgv(ref dataGridView_Dest, "Tune Sheet", 0U);
                        LoadItemToDgv(ref dataGridView_Dest, "Paint", tempCar.GetBlob1().Paint());
                        LoadItemToDgv(ref dataGridView_Dest, "Body", tempCar.GetBlob1().Body());
                        LoadItemToDgv(ref dataGridView_Dest, "Colour", tempCar.GetBlob1().Colour());
                        LoadItemToDgv(ref dataGridView_Dest, "Brakes", tempCar.GetBlob1().Brakes());
                        LoadItemToDgv(ref dataGridView_Dest, "_198_201", tempCar.GetBlob1()._198_201());
                        LoadItemToDgv(ref dataGridView_Dest, "Chassis", tempCar.GetBlob1().Chassis());
                        LoadItemToDgv(ref dataGridView_Dest, "Engine", tempCar.GetBlob1().Engine());
                        LoadItemToDgv(ref dataGridView_Dest, "Drivetrain", tempCar.GetBlob1().DriveTrain());
                        LoadItemToDgv(ref dataGridView_Dest, "Transmission", tempCar.GetBlob1().Transmission());
                        LoadItemToDgv(ref dataGridView_Dest, "Suspension", tempCar.GetBlob1().Suspension());
                        LoadItemToDgv(ref dataGridView_Dest, "LSD", tempCar.GetBlob1().LSD());
                        LoadItemToDgv(ref dataGridView_Dest, "_226_229", tempCar.GetBlob1().method_134());
                        LoadItemToDgv(ref dataGridView_Dest, "WReduction", tempCar.GetBlob1().WReduction());
                        LoadItemToDgv(ref dataGridView_Dest, "_234_237", tempCar.GetBlob1().method_138());
                        LoadItemToDgv(ref dataGridView_Dest, "_238_241", tempCar.GetBlob1().method_140());
                        LoadItemToDgv(ref dataGridView_Dest, "ECU", tempCar.GetBlob1().ECU());
                        LoadItemToDgv(ref dataGridView_Dest, "Engine Tune", tempCar.GetBlob1().EngineTune());
                        LoadItemToDgv(ref dataGridView_Dest, "Turbo", tempCar.GetBlob1().Turbo());
                        LoadItemToDgv(ref dataGridView_Dest, "Flywheel", tempCar.GetBlob1().Flywheel());
                        LoadItemToDgv(ref dataGridView_Dest, "Clutch", tempCar.GetBlob1().Clutch());
                        LoadItemToDgv(ref dataGridView_Dest, "Driveshaft", tempCar.GetBlob1().Driveshaft());
                        LoadItemToDgv(ref dataGridView_Dest, "Exhaust", tempCar.GetBlob1().Exhaust());
                        LoadItemToDgv(ref dataGridView_Dest, "_270_273", tempCar.GetBlob1().method_156());
                        LoadItemToDgv(ref dataGridView_Dest, "ASM Controller", tempCar.GetBlob1().ASM());
                        LoadItemToDgv(ref dataGridView_Dest, "TCS Controller", tempCar.GetBlob1().TCS());
                        LoadItemToDgv(ref dataGridView_Dest, "_282_285", tempCar.GetBlob1().method_162());
                        LoadItemToDgv(ref dataGridView_Dest, "Supercharger", tempCar.GetBlob1().Supercharger());
                        LoadItemToDgv(ref dataGridView_Dest, "Intake Manifold", tempCar.GetBlob1().Intake());
                        LoadItemToDgv(ref dataGridView_Dest, "Exhaust Manifold", tempCar.GetBlob1().ExhaustManifold());
                        LoadItemToDgv(ref dataGridView_Dest, "Catalytic Converter", tempCar.GetBlob1().CatConverter());
                        LoadItemToDgv(ref dataGridView_Dest, "Air Filter", tempCar.GetBlob1().AirFilter());
                        LoadItemToDgv(ref dataGridView_Dest, "_306_309", tempCar.GetBlob1().method_174());
                        LoadItemToDgv(ref dataGridView_Dest, "WindowWR", tempCar.GetBlob1().WindowWR());
                        LoadItemToDgv(ref dataGridView_Dest, "Hood", tempCar.GetBlob1().Hood());
                        LoadItemToDgv(ref dataGridView_Dest, "FrBumper", tempCar.GetBlob1().FrBumper());
                        LoadItemToDgv(ref dataGridView_Dest, "RrBumper", tempCar.GetBlob1().RrBumper());
                        LoadItemToDgv(ref dataGridView_Dest, "Extension", tempCar.GetBlob1().Extension());
                        LoadItemToDgv(ref dataGridView_Dest, "Wing", tempCar.GetBlob1().Wing());
                        LoadItemToDgv(ref dataGridView_Dest, "_334_337", tempCar.GetBlob1().method_188());
                        LoadItemToDgv(ref dataGridView_Dest, "Reinforcement", tempCar.GetBlob1().Reinforcement());
                        LoadItemToDgv(ref dataGridView_Dest, "NoS", tempCar.GetBlob1().Nos());
                        break;
                    case 'b':
                        LoadItemToDgv(ref dataGridView_Dest, "Tune Sheet", 0U);
                        LoadItemToDgv(ref dataGridView_Dest, "Paint", tempCar.GetBlob2().Paint());
                        LoadItemToDgv(ref dataGridView_Dest, "Body", tempCar.GetBlob2().Body());
                        LoadItemToDgv(ref dataGridView_Dest, "Colour", tempCar.GetBlob2().Colour());
                        LoadItemToDgv(ref dataGridView_Dest, "Brakes", tempCar.GetBlob2().Brakes());
                        LoadItemToDgv(ref dataGridView_Dest, "_198_201", tempCar.GetBlob2()._198_201());
                        LoadItemToDgv(ref dataGridView_Dest, "Chassis", tempCar.GetBlob2().Chassis());
                        LoadItemToDgv(ref dataGridView_Dest, "Engine", tempCar.GetBlob2().Engine());
                        LoadItemToDgv(ref dataGridView_Dest, "Drivetrain", tempCar.GetBlob2().DriveTrain());
                        LoadItemToDgv(ref dataGridView_Dest, "Transmission", tempCar.GetBlob2().Transmission());
                        LoadItemToDgv(ref dataGridView_Dest, "Suspension", tempCar.GetBlob2().Suspension());
                        LoadItemToDgv(ref dataGridView_Dest, "LSD", tempCar.GetBlob2().LSD());
                        LoadItemToDgv(ref dataGridView_Dest, "_226_229", tempCar.GetBlob2().method_134());
                        LoadItemToDgv(ref dataGridView_Dest, "WReduction", tempCar.GetBlob2().WReduction());
                        LoadItemToDgv(ref dataGridView_Dest, "_234_237", tempCar.GetBlob2().method_138());
                        LoadItemToDgv(ref dataGridView_Dest, "_238_241", tempCar.GetBlob2().method_140());
                        LoadItemToDgv(ref dataGridView_Dest, "ECU", tempCar.GetBlob2().ECU());
                        LoadItemToDgv(ref dataGridView_Dest, "Engine Tune", tempCar.GetBlob2().EngineTune());
                        LoadItemToDgv(ref dataGridView_Dest, "Turbo", tempCar.GetBlob2().Turbo());
                        LoadItemToDgv(ref dataGridView_Dest, "Flywheel", tempCar.GetBlob2().Flywheel());
                        LoadItemToDgv(ref dataGridView_Dest, "Clutch", tempCar.GetBlob2().Clutch());
                        LoadItemToDgv(ref dataGridView_Dest, "Driveshaft", tempCar.GetBlob2().Driveshaft());
                        LoadItemToDgv(ref dataGridView_Dest, "Exhaust", tempCar.GetBlob2().Exhaust());
                        LoadItemToDgv(ref dataGridView_Dest, "_270_273", tempCar.GetBlob2().method_156());
                        LoadItemToDgv(ref dataGridView_Dest, "ASM Controller", tempCar.GetBlob2().ASM());
                        LoadItemToDgv(ref dataGridView_Dest, "TCS Controller", tempCar.GetBlob2().TCS());
                        LoadItemToDgv(ref dataGridView_Dest, "_282_285", tempCar.GetBlob2().method_162());
                        LoadItemToDgv(ref dataGridView_Dest, "Supercharger", tempCar.GetBlob2().Supercharger());
                        LoadItemToDgv(ref dataGridView_Dest, "Intake Manifold", tempCar.GetBlob2().Intake());
                        LoadItemToDgv(ref dataGridView_Dest, "Exhaust Manifold", tempCar.GetBlob2().ExhaustManifold());
                        LoadItemToDgv(ref dataGridView_Dest, "Catalytic Converter", tempCar.GetBlob2().CatConverter());
                        LoadItemToDgv(ref dataGridView_Dest, "Air Filter", tempCar.GetBlob2().AirFilter());
                        LoadItemToDgv(ref dataGridView_Dest, "_306_309", tempCar.GetBlob2().method_174());
                        LoadItemToDgv(ref dataGridView_Dest, "WindowWR", tempCar.GetBlob2().WindowWR());
                        LoadItemToDgv(ref dataGridView_Dest, "Hood", tempCar.GetBlob2().Hood());
                        LoadItemToDgv(ref dataGridView_Dest, "FrBumper", tempCar.GetBlob2().FrBumper());
                        LoadItemToDgv(ref dataGridView_Dest, "RrBumper", tempCar.GetBlob2().RrBumper());
                        LoadItemToDgv(ref dataGridView_Dest, "Extension", tempCar.GetBlob2().Extension());
                        LoadItemToDgv(ref dataGridView_Dest, "Wing", tempCar.GetBlob2().Wing());
                        LoadItemToDgv(ref dataGridView_Dest, "_334_337", tempCar.GetBlob2().method_188());
                        LoadItemToDgv(ref dataGridView_Dest, "Reinforcement", tempCar.GetBlob2().Reinforcement());
                        LoadItemToDgv(ref dataGridView_Dest, "NoS", tempCar.GetBlob2().Nos());
                        break;
                    case 'c':
                        LoadItemToDgv(ref dataGridView_Dest, "Tune Sheet", 0U);
                        LoadItemToDgv(ref dataGridView_Dest, "Paint", tempCar.GetBlob3().Paint());
                        LoadItemToDgv(ref dataGridView_Dest, "Body", tempCar.GetBlob3().Body());
                        LoadItemToDgv(ref dataGridView_Dest, "Colour", tempCar.GetBlob3().Colour());
                        LoadItemToDgv(ref dataGridView_Dest, "Brakes", tempCar.GetBlob3().Brakes());
                        LoadItemToDgv(ref dataGridView_Dest, "_198_201", tempCar.GetBlob3()._198_201());
                        LoadItemToDgv(ref dataGridView_Dest, "Chassis", tempCar.GetBlob3().Chassis());
                        LoadItemToDgv(ref dataGridView_Dest, "Engine", tempCar.GetBlob3().Engine());
                        LoadItemToDgv(ref dataGridView_Dest, "Drivetrain", tempCar.GetBlob3().DriveTrain());
                        LoadItemToDgv(ref dataGridView_Dest, "Transmission", tempCar.GetBlob3().Transmission());
                        LoadItemToDgv(ref dataGridView_Dest, "Suspension", tempCar.GetBlob3().Suspension());
                        LoadItemToDgv(ref dataGridView_Dest, "LSD", tempCar.GetBlob3().LSD());
                        LoadItemToDgv(ref dataGridView_Dest, "_226_229", tempCar.GetBlob3().method_134());
                        LoadItemToDgv(ref dataGridView_Dest, "WReduction", tempCar.GetBlob3().WReduction());
                        LoadItemToDgv(ref dataGridView_Dest, "_234_237", tempCar.GetBlob3().method_138());
                        LoadItemToDgv(ref dataGridView_Dest, "_238_241", tempCar.GetBlob3().method_140());
                        LoadItemToDgv(ref dataGridView_Dest, "ECU", tempCar.GetBlob3().ECU());
                        LoadItemToDgv(ref dataGridView_Dest, "Engine Tune", tempCar.GetBlob3().EngineTune());
                        LoadItemToDgv(ref dataGridView_Dest, "Turbo", tempCar.GetBlob3().Turbo());
                        LoadItemToDgv(ref dataGridView_Dest, "Flywheel", tempCar.GetBlob3().Flywheel());
                        LoadItemToDgv(ref dataGridView_Dest, "Clutch", tempCar.GetBlob3().Clutch());
                        LoadItemToDgv(ref dataGridView_Dest, "Driveshaft", tempCar.GetBlob3().Driveshaft());
                        LoadItemToDgv(ref dataGridView_Dest, "Exhaust", tempCar.GetBlob3().Exhaust());
                        LoadItemToDgv(ref dataGridView_Dest, "_270_273", tempCar.GetBlob3().method_156());
                        LoadItemToDgv(ref dataGridView_Dest, "ASM Controller", tempCar.GetBlob3().ASM());
                        LoadItemToDgv(ref dataGridView_Dest, "TCS Controller", tempCar.GetBlob3().TCS());
                        LoadItemToDgv(ref dataGridView_Dest, "_282_285", tempCar.GetBlob3().method_162());
                        LoadItemToDgv(ref dataGridView_Dest, "Supercharger", tempCar.GetBlob3().Supercharger());
                        LoadItemToDgv(ref dataGridView_Dest, "Intake Manifold", tempCar.GetBlob3().Intake());
                        LoadItemToDgv(ref dataGridView_Dest, "Exhaust Manifold", tempCar.GetBlob3().ExhaustManifold());
                        LoadItemToDgv(ref dataGridView_Dest, "Catalytic Converter", tempCar.GetBlob3().CatConverter());
                        LoadItemToDgv(ref dataGridView_Dest, "Air Filter", tempCar.GetBlob3().AirFilter());
                        LoadItemToDgv(ref dataGridView_Dest, "_306_309", tempCar.GetBlob3().method_174());
                        LoadItemToDgv(ref dataGridView_Dest, "WindowWR", tempCar.GetBlob3().WindowWR());
                        LoadItemToDgv(ref dataGridView_Dest, "Hood", tempCar.GetBlob3().Hood());
                        LoadItemToDgv(ref dataGridView_Dest, "FrBumper", tempCar.GetBlob3().FrBumper());
                        LoadItemToDgv(ref dataGridView_Dest, "RrBumper", tempCar.GetBlob3().RrBumper());
                        LoadItemToDgv(ref dataGridView_Dest, "Extension", tempCar.GetBlob3().Extension());
                        LoadItemToDgv(ref dataGridView_Dest, "Wing", tempCar.GetBlob3().Wing());
                        LoadItemToDgv(ref dataGridView_Dest, "_334_337", tempCar.GetBlob3().method_188());
                        LoadItemToDgv(ref dataGridView_Dest, "Reinforcement", tempCar.GetBlob3().Reinforcement());
                        LoadItemToDgv(ref dataGridView_Dest, "NoS", tempCar.GetBlob3().Nos());
                        break;
                }
            }
            catch
            {
            }
        }

        public static void AddColumnToDgv(ref DataGridView dgv, string item, uint value)
        {
            var index = dgv.Rows.Add();
            var dataGridViewRow = dgv.Rows[index];
            dataGridViewRow.Cells["Column_Item"].Value = item;
            dataGridViewRow.Cells["Column_Value"].Value = value;
        }

        public static void LoadItemToDgv(ref DataGridView dgv, string item, uint value)
        {
            var index = dgv.Rows.Add();
            var dataGridViewRow = dgv.Rows[index];
            dataGridViewRow.Cells["Column_ItemD"].Value = item;
            dataGridViewRow.Cells["Column_ValueD"].Value = value;
        }

        private void dataGridView_Source_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (comboBox_DModel.SelectedIndex < 0 && tabControl_garage.SelectedIndex != tabControl_garage.TabPages.IndexOf(tabPage_ridingCar))
                return;
            var str = dataGridView_Source.SelectedRows[0].Cells[0].Value.ToString();
            if (!_char0.Equals('a') && tabControl_garage.SelectedIndex != tabControl_garage.TabPages.IndexOf(tabPage_ridingCar))
            {
                if (_char0.Equals('b'))
                {
                    string key1;
                    if ((key1 = str) != null)
                    {
                        if (Dictionaries.dictionary_1 == null)
                        {
                            var dictionary = new Dictionary<string, int>(42);
                            var key2 = "Tune Sheet";
                            var num1 = 0;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key2, num1);
                            var key3 = "Colour";
                            var num2 = 1;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key3, num2);
                            var key4 = "Paint";
                            var num3 = 2;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key4, num3);
                            var key5 = "Body";
                            var num4 = 3;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key5, num4);
                            var key6 = "Brakes";
                            var num5 = 4;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key6, num5);
                            var key7 = "_198_201";
                            var num6 = 5;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key7, num6);
                            var key8 = "Chassis";
                            var num7 = 6;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key8, num7);
                            var key9 = "Engine";
                            var num8 = 7;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key9, num8);
                            var key10 = "Drivetrain";
                            var num9 = 8;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key10, num9);
                            var key11 = "Transmission";
                            var num10 = 9;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key11, num10);
                            var key12 = "Suspension";
                            var num11 = 10;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key12, num11);
                            var key13 = "LSD";
                            var num12 = 11;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key13, num12);
                            var key14 = "_226_229";
                            var num13 = 12;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key14, num13);
                            var key15 = "WReduction";
                            var num14 = 13;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key15, num14);
                            var key16 = "_234_237";
                            var num15 = 14;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key16, num15);
                            var key17 = "_238_241";
                            var num16 = 15;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key17, num16);
                            var key18 = "ECU";
                            var num17 = 16;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key18, num17);
                            var key19 = "Engine Tune";
                            var num18 = 17;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key19, num18);
                            var key20 = "Turbo";
                            var num19 = 18;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key20, num19);
                            var key21 = "Flywheel";
                            var num20 = 19;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key21, num20);
                            var key22 = "Clutch";
                            var num21 = 20;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key22, num21);
                            var key23 = "Driveshaft";
                            var num22 = 21;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key23, num22);
                            var key24 = "Exhaust";
                            var num23 = 22;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key24, num23);
                            var key25 = "_270_273";
                            var num24 = 23;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key25, num24);
                            var key26 = "ASM Controller";
                            var num25 = 24;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key26, num25);
                            var key27 = "TCS Controller";
                            var num26 = 25;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key27, num26);
                            var key28 = "_282_285";
                            var num27 = 26;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key28, num27);
                            var key29 = "Supercharger";
                            var num28 = 27;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key29, num28);
                            var key30 = "Intake Manifold";
                            var num29 = 28;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key30, num29);
                            var key31 = "Exhaust Manifold";
                            var num30 = 29;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key31, num30);
                            var key32 = "Catalytic Converter";
                            var num31 = 30;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key32, num31);
                            var key33 = "Air Filter";
                            var num32 = 31;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key33, num32);
                            var key34 = "_306_309";
                            var num33 = 32;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key34, num33);
                            var key35 = "WindowWR";
                            var num34 = 33;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key35, num34);
                            var key36 = "Hood";
                            var num35 = 34;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key36, num35);
                            var key37 = "FrBumper";
                            var num36 = 35;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key37, num36);
                            var key38 = "RrBumper";
                            var num37 = 36;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key38, num37);
                            var key39 = "Extension";
                            var num38 = 37;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key39, num38);
                            var key40 = "Wing";
                            var num39 = 38;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key40, num39);
                            var key41 = "_334_337";
                            var num40 = 39;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key41, num40);
                            var key42 = "Reinforcement";
                            var num41 = 40;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key42, num41);
                            var key43 = "NoS";
                            var num42 = 41;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key43, num42);
                            Dictionaries.dictionary_1 = dictionary;
                        }
                        int num;
                        // ISSUE: explicit non-virtual call
                        if ((Dictionaries.dictionary_1.TryGetValue(key1, out num)))
                        {
                            switch (num)
                            {
                                case 1:
                                    _currentCar.GetBlob2().method_103(_tempCar.GetBlob1().Colour());
                                    break;
                                case 2:
                                    _currentCar.GetBlob2().method_105(_tempCar.GetBlob1().Paint());
                                    break;
                                case 3:
                                    _currentCar.GetBlob2().method_117(_tempCar.GetBlob1().Body());
                                    break;
                                case 4:
                                    _currentCar.GetBlob2().method_119(_tempCar.GetBlob1().Brakes());
                                    break;
                                case 5:
                                    _currentCar.GetBlob2().method_121(_tempCar.GetBlob1()._198_201());
                                    break;
                                case 6:
                                    _currentCar.GetBlob2().method_123(_tempCar.GetBlob1().Chassis());
                                    break;
                                case 7:
                                    _currentCar.GetBlob2().method_125(_tempCar.GetBlob1().Engine());
                                    break;
                                case 8:
                                    _currentCar.GetBlob2().method_127(_tempCar.GetBlob1().DriveTrain());
                                    break;
                                case 9:
                                    _currentCar.GetBlob2().method_129(_tempCar.GetBlob1().Transmission());
                                    break;
                                case 10:
                                    _currentCar.GetBlob2().method_131(_tempCar.GetBlob1().Suspension());
                                    break;
                                case 11:
                                    _currentCar.GetBlob2().method_133(_tempCar.GetBlob1().LSD());
                                    break;
                                case 12:
                                    _currentCar.GetBlob2().method_135(_tempCar.GetBlob1().method_134());
                                    break;
                                case 13:
                                    _currentCar.GetBlob2().method_137(_tempCar.GetBlob1().WReduction());
                                    break;
                                case 14:
                                    _currentCar.GetBlob2().method_139(_tempCar.GetBlob1().method_138());
                                    break;
                                case 15:
                                    _currentCar.GetBlob2().method_141(_tempCar.GetBlob1().method_140());
                                    break;
                                case 16:
                                    _currentCar.GetBlob2().method_143(_tempCar.GetBlob1().ECU());
                                    break;
                                case 17:
                                    _currentCar.GetBlob2().method_145(_tempCar.GetBlob1().EngineTune());
                                    break;
                                case 18:
                                    _currentCar.GetBlob2().method_147(_tempCar.GetBlob1().Turbo());
                                    break;
                                case 19:
                                    _currentCar.GetBlob2().method_149(_tempCar.GetBlob1().Flywheel());
                                    break;
                                case 20:
                                    _currentCar.GetBlob2().method_151(_tempCar.GetBlob1().Clutch());
                                    break;
                                case 21:
                                    _currentCar.GetBlob2().method_153(_tempCar.GetBlob1().Driveshaft());
                                    break;
                                case 22:
                                    _currentCar.GetBlob2().method_155(_tempCar.GetBlob1().Exhaust());
                                    break;
                                case 23:
                                    _currentCar.GetBlob2().method_157(_tempCar.GetBlob1().method_156());
                                    break;
                                case 24:
                                    _currentCar.GetBlob2().method_159(_tempCar.GetBlob1().ASM());
                                    break;
                                case 25:
                                    _currentCar.GetBlob2().method_161(_tempCar.GetBlob1().TCS());
                                    break;
                                case 26:
                                    _currentCar.GetBlob2().method_163(_tempCar.GetBlob1().method_162());
                                    break;
                                case 27:
                                    _currentCar.GetBlob2().method_165(_tempCar.GetBlob1().Supercharger());
                                    break;
                                case 28:
                                    _currentCar.GetBlob2().method_167(_tempCar.GetBlob1().Intake());
                                    break;
                                case 29:
                                    _currentCar.GetBlob2().method_169(_tempCar.GetBlob1().ExhaustManifold());
                                    break;
                                case 30:
                                    _currentCar.GetBlob2().method_171(_tempCar.GetBlob1().CatConverter());
                                    break;
                                case 31:
                                    _currentCar.GetBlob2().method_173(_tempCar.GetBlob1().AirFilter());
                                    break;
                                case 32:
                                    _currentCar.GetBlob2().method_175(_tempCar.GetBlob1().method_174());
                                    break;
                                case 33:
                                    _currentCar.GetBlob2().method_177(_tempCar.GetBlob1().WindowWR());
                                    break;
                                case 34:
                                    _currentCar.GetBlob2().method_179(_tempCar.GetBlob1().Hood());
                                    break;
                                case 35:
                                    _currentCar.GetBlob2().method_181(_tempCar.GetBlob1().FrBumper());
                                    break;
                                case 36:
                                    _currentCar.GetBlob2().method_183(_tempCar.GetBlob1().RrBumper());
                                    break;
                                case 37:
                                    _currentCar.GetBlob2().method_185(_tempCar.GetBlob1().Extension());
                                    break;
                                case 38:
                                    _currentCar.GetBlob2().method_187(_tempCar.GetBlob1().Wing());
                                    break;
                                case 39:
                                    _currentCar.GetBlob2().method_189(_tempCar.GetBlob1().method_188());
                                    break;
                                case 40:
                                    _currentCar.GetBlob2().method_191(_tempCar.GetBlob1().Reinforcement());
                                    break;
                                case 41:
                                    _currentCar.GetBlob2().method_193(_tempCar.GetBlob1().Nos());
                                    break;
                            }
                        }
                    }
                }
                else
                {
                    string key1;
                    if (_char0.Equals('c') && (key1 = str) != null)
                    {
                        if (Dictionaries.dictionary_2 == null)
                        {
                            var dictionary = new Dictionary<string, int>(42);
                            var key2 = "Tune Sheet";
                            var num1 = 0;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key2, num1);
                            var key3 = "Colour";
                            var num2 = 1;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key3, num2);
                            var key4 = "Paint";
                            var num3 = 2;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key4, num3);
                            var key5 = "Body";
                            var num4 = 3;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key5, num4);
                            var key6 = "Brakes";
                            var num5 = 4;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key6, num5);
                            var key7 = "_198_201";
                            var num6 = 5;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key7, num6);
                            var key8 = "Chassis";
                            var num7 = 6;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key8, num7);
                            var key9 = "Engine";
                            var num8 = 7;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key9, num8);
                            var key10 = "Drivetrain";
                            var num9 = 8;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key10, num9);
                            var key11 = "Transmission";
                            var num10 = 9;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key11, num10);
                            var key12 = "Suspension";
                            var num11 = 10;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key12, num11);
                            var key13 = "LSD";
                            var num12 = 11;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key13, num12);
                            var key14 = "_226_229";
                            var num13 = 12;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key14, num13);
                            var key15 = "WReduction";
                            var num14 = 13;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key15, num14);
                            var key16 = "_234_237";
                            var num15 = 14;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key16, num15);
                            var key17 = "_238_241";
                            var num16 = 15;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key17, num16);
                            var key18 = "ECU";
                            var num17 = 16;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key18, num17);
                            var key19 = "Engine Tune";
                            var num18 = 17;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key19, num18);
                            var key20 = "Turbo";
                            var num19 = 18;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key20, num19);
                            var key21 = "Flywheel";
                            var num20 = 19;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key21, num20);
                            var key22 = "Clutch";
                            var num21 = 20;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key22, num21);
                            var key23 = "Driveshaft";
                            var num22 = 21;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key23, num22);
                            var key24 = "Exhaust";
                            var num23 = 22;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key24, num23);
                            var key25 = "_270_273";
                            var num24 = 23;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key25, num24);
                            var key26 = "ASM Controller";
                            var num25 = 24;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key26, num25);
                            var key27 = "TCS Controller";
                            var num26 = 25;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key27, num26);
                            var key28 = "_282_285";
                            var num27 = 26;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key28, num27);
                            var key29 = "Supercharger";
                            var num28 = 27;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key29, num28);
                            var key30 = "Intake Manifold";
                            var num29 = 28;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key30, num29);
                            var key31 = "Exhaust Manifold";
                            var num30 = 29;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key31, num30);
                            var key32 = "Catalytic Converter";
                            var num31 = 30;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key32, num31);
                            var key33 = "Air Filter";
                            var num32 = 31;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key33, num32);
                            var key34 = "_306_309";
                            var num33 = 32;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key34, num33);
                            var key35 = "WindowWR";
                            var num34 = 33;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key35, num34);
                            var key36 = "Hood";
                            var num35 = 34;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key36, num35);
                            var key37 = "FrBumper";
                            var num36 = 35;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key37, num36);
                            var key38 = "RrBumper";
                            var num37 = 36;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key38, num37);
                            var key39 = "Extension";
                            var num38 = 37;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key39, num38);
                            var key40 = "Wing";
                            var num39 = 38;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key40, num39);
                            var key41 = "_334_337";
                            var num40 = 39;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key41, num40);
                            var key42 = "Reinforcement";
                            var num41 = 40;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key42, num41);
                            var key43 = "NoS";
                            var num42 = 41;
                            // ISSUE: explicit non-virtual call
                            dictionary.Add(key43, num42);
                            Dictionaries.dictionary_2 = dictionary;
                        }
                        int num;
                        // ISSUE: explicit non-virtual call
                        if ((Dictionaries.dictionary_2.TryGetValue(key1, out num)))
                        {
                            switch (num)
                            {
                                case 1:
                                    _currentCar.GetBlob3().method_103(_tempCar.GetBlob1().Colour());
                                    break;
                                case 2:
                                    _currentCar.GetBlob3().method_105(_tempCar.GetBlob1().Paint());
                                    break;
                                case 3:
                                    _currentCar.GetBlob3().method_117(_tempCar.GetBlob1().Body());
                                    break;
                                case 4:
                                    _currentCar.GetBlob3().method_119(_tempCar.GetBlob1().Brakes());
                                    break;
                                case 5:
                                    _currentCar.GetBlob3().method_121(_tempCar.GetBlob1()._198_201());
                                    break;
                                case 6:
                                    _currentCar.GetBlob3().method_123(_tempCar.GetBlob1().Chassis());
                                    break;
                                case 7:
                                    _currentCar.GetBlob3().method_125(_tempCar.GetBlob1().Engine());
                                    break;
                                case 8:
                                    _currentCar.GetBlob3().method_127(_tempCar.GetBlob1().DriveTrain());
                                    break;
                                case 9:
                                    _currentCar.GetBlob3().method_129(_tempCar.GetBlob1().Transmission());
                                    break;
                                case 10:
                                    _currentCar.GetBlob3().method_131(_tempCar.GetBlob1().Suspension());
                                    break;
                                case 11:
                                    _currentCar.GetBlob3().method_133(_tempCar.GetBlob1().LSD());
                                    break;
                                case 12:
                                    _currentCar.GetBlob3().method_135(_tempCar.GetBlob1().method_134());
                                    break;
                                case 13:
                                    _currentCar.GetBlob3().method_137(_tempCar.GetBlob1().WReduction());
                                    break;
                                case 14:
                                    _currentCar.GetBlob3().method_139(_tempCar.GetBlob1().method_138());
                                    break;
                                case 15:
                                    _currentCar.GetBlob3().method_141(_tempCar.GetBlob1().method_140());
                                    break;
                                case 16:
                                    _currentCar.GetBlob3().method_143(_tempCar.GetBlob1().ECU());
                                    break;
                                case 17:
                                    _currentCar.GetBlob3().method_145(_tempCar.GetBlob1().EngineTune());
                                    break;
                                case 18:
                                    _currentCar.GetBlob3().method_147(_tempCar.GetBlob1().Turbo());
                                    break;
                                case 19:
                                    _currentCar.GetBlob3().method_149(_tempCar.GetBlob1().Flywheel());
                                    break;
                                case 20:
                                    _currentCar.GetBlob3().method_151(_tempCar.GetBlob1().Clutch());
                                    break;
                                case 21:
                                    _currentCar.GetBlob3().method_153(_tempCar.GetBlob1().Driveshaft());
                                    break;
                                case 22:
                                    _currentCar.GetBlob3().method_155(_tempCar.GetBlob1().Exhaust());
                                    break;
                                case 23:
                                    _currentCar.GetBlob3().method_157(_tempCar.GetBlob1().method_156());
                                    break;
                                case 24:
                                    _currentCar.GetBlob3().method_159(_tempCar.GetBlob1().ASM());
                                    break;
                                case 25:
                                    _currentCar.GetBlob3().method_161(_tempCar.GetBlob1().TCS());
                                    break;
                                case 26:
                                    _currentCar.GetBlob3().method_163(_tempCar.GetBlob1().method_162());
                                    break;
                                case 27:
                                    _currentCar.GetBlob3().method_165(_tempCar.GetBlob1().Supercharger());
                                    break;
                                case 28:
                                    _currentCar.GetBlob3().method_167(_tempCar.GetBlob1().Intake());
                                    break;
                                case 29:
                                    _currentCar.GetBlob3().method_169(_tempCar.GetBlob1().ExhaustManifold());
                                    break;
                                case 30:
                                    _currentCar.GetBlob3().method_171(_tempCar.GetBlob1().CatConverter());
                                    break;
                                case 31:
                                    _currentCar.GetBlob3().method_173(_tempCar.GetBlob1().AirFilter());
                                    break;
                                case 32:
                                    _currentCar.GetBlob3().method_175(_tempCar.GetBlob1().method_174());
                                    break;
                                case 33:
                                    _currentCar.GetBlob3().method_177(_tempCar.GetBlob1().WindowWR());
                                    break;
                                case 34:
                                    _currentCar.GetBlob3().method_179(_tempCar.GetBlob1().Hood());
                                    break;
                                case 35:
                                    _currentCar.GetBlob3().method_181(_tempCar.GetBlob1().FrBumper());
                                    break;
                                case 36:
                                    _currentCar.GetBlob3().method_183(_tempCar.GetBlob1().RrBumper());
                                    break;
                                case 37:
                                    _currentCar.GetBlob3().method_185(_tempCar.GetBlob1().Extension());
                                    break;
                                case 38:
                                    _currentCar.GetBlob3().method_187(_tempCar.GetBlob1().Wing());
                                    break;
                                case 39:
                                    _currentCar.GetBlob3().method_189(_tempCar.GetBlob1().method_188());
                                    break;
                                case 40:
                                    _currentCar.GetBlob3().method_191(_tempCar.GetBlob1().Reinforcement());
                                    break;
                                case 41:
                                    _currentCar.GetBlob3().method_193(_tempCar.GetBlob1().Nos());
                                    break;
                            }
                        }
                    }
                }
            }
            else
            {
                string key1;
                if ((key1 = str) != null)
                {
                    if (Dictionaries.dictionary_0 == null)
                    {
                        var dictionary = new Dictionary<string, int>(42);
                        var key2 = "Tune Sheet";
                        var num1 = 0;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key2, num1);
                        var key3 = "Colour";
                        var num2 = 1;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key3, num2);
                        var key4 = "Paint";
                        var num3 = 2;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key4, num3);
                        var key5 = "Body";
                        var num4 = 3;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key5, num4);
                        var key6 = "Brakes";
                        var num5 = 4;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key6, num5);
                        var key7 = "_198_201";
                        var num6 = 5;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key7, num6);
                        var key8 = "Chassis";
                        var num7 = 6;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key8, num7);
                        var key9 = "Engine";
                        var num8 = 7;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key9, num8);
                        var key10 = "Drivetrain";
                        var num9 = 8;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key10, num9);
                        var key11 = "Transmission";
                        var num10 = 9;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key11, num10);
                        var key12 = "Suspension";
                        var num11 = 10;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key12, num11);
                        var key13 = "LSD";
                        var num12 = 11;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key13, num12);
                        var key14 = "_226_229";
                        var num13 = 12;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key14, num13);
                        var key15 = "WReduction";
                        var num14 = 13;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key15, num14);
                        var key16 = "_234_237";
                        var num15 = 14;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key16, num15);
                        var key17 = "_238_241";
                        var num16 = 15;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key17, num16);
                        var key18 = "ECU";
                        var num17 = 16;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key18, num17);
                        var key19 = "Engine Tune";
                        var num18 = 17;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key19, num18);
                        var key20 = "Turbo";
                        var num19 = 18;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key20, num19);
                        var key21 = "Flywheel";
                        var num20 = 19;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key21, num20);
                        var key22 = "Clutch";
                        var num21 = 20;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key22, num21);
                        var key23 = "Driveshaft";
                        var num22 = 21;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key23, num22);
                        var key24 = "Exhaust";
                        var num23 = 22;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key24, num23);
                        var key25 = "_270_273";
                        var num24 = 23;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key25, num24);
                        var key26 = "ASM Controller";
                        var num25 = 24;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key26, num25);
                        var key27 = "TCS Controller";
                        var num26 = 25;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key27, num26);
                        var key28 = "_282_285";
                        var num27 = 26;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key28, num27);
                        var key29 = "Supercharger";
                        var num28 = 27;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key29, num28);
                        var key30 = "Intake Manifold";
                        var num29 = 28;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key30, num29);
                        var key31 = "Exhaust Manifold";
                        var num30 = 29;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key31, num30);
                        var key32 = "Catalytic Converter";
                        var num31 = 30;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key32, num31);
                        var key33 = "Air Filter";
                        var num32 = 31;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key33, num32);
                        var key34 = "_306_309";
                        var num33 = 32;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key34, num33);
                        var key35 = "WindowWR";
                        var num34 = 33;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key35, num34);
                        var key36 = "Hood";
                        var num35 = 34;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key36, num35);
                        var key37 = "FrBumper";
                        var num36 = 35;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key37, num36);
                        var key38 = "RrBumper";
                        var num37 = 36;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key38, num37);
                        var key39 = "Extension";
                        var num38 = 37;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key39, num38);
                        var key40 = "Wing";
                        var num39 = 38;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key40, num39);
                        var key41 = "_334_337";
                        var num40 = 39;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key41, num40);
                        var key42 = "Reinforcement";
                        var num41 = 40;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key42, num41);
                        var key43 = "NoS";
                        var num42 = 41;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key43, num42);
                        Dictionaries.dictionary_0 = dictionary;
                    }
                    int num;
                    // ISSUE: explicit non-virtual call
                    if ((Dictionaries.dictionary_0.TryGetValue(key1, out num)))
                    {
                        switch (num)
                        {
                            case 1:
                                _currentCar.GetBlob1().method_103(_tempCar.GetBlob1().Colour());
                                break;
                            case 2:
                                _currentCar.GetBlob1().method_105(_tempCar.GetBlob1().Paint());
                                break;
                            case 3:
                                _currentCar.GetBlob1().method_117(_tempCar.GetBlob1().Body());
                                break;
                            case 4:
                                _currentCar.GetBlob1().method_119(_tempCar.GetBlob1().Brakes());
                                break;
                            case 5:
                                _currentCar.GetBlob1().method_121(_tempCar.GetBlob1()._198_201());
                                break;
                            case 6:
                                _currentCar.GetBlob1().method_123(_tempCar.GetBlob1().Chassis());
                                break;
                            case 7:
                                _currentCar.GetBlob1().method_125(_tempCar.GetBlob1().Engine());
                                break;
                            case 8:
                                _currentCar.GetBlob1().method_127(_tempCar.GetBlob1().DriveTrain());
                                break;
                            case 9:
                                _currentCar.GetBlob1().method_129(_tempCar.GetBlob1().Transmission());
                                break;
                            case 10:
                                _currentCar.GetBlob1().method_131(_tempCar.GetBlob1().Suspension());
                                break;
                            case 11:
                                _currentCar.GetBlob1().method_133(_tempCar.GetBlob1().LSD());
                                break;
                            case 12:
                                _currentCar.GetBlob1().method_135(_tempCar.GetBlob1().method_134());
                                break;
                            case 13:
                                _currentCar.GetBlob1().method_137(_tempCar.GetBlob1().WReduction());
                                break;
                            case 14:
                                _currentCar.GetBlob1().method_139(_tempCar.GetBlob1().method_138());
                                break;
                            case 15:
                                _currentCar.GetBlob1().method_141(_tempCar.GetBlob1().method_140());
                                break;
                            case 16:
                                _currentCar.GetBlob1().method_143(_tempCar.GetBlob1().ECU());
                                break;
                            case 17:
                                _currentCar.GetBlob1().method_145(_tempCar.GetBlob1().EngineTune());
                                break;
                            case 18:
                                _currentCar.GetBlob1().method_147(_tempCar.GetBlob1().Turbo());
                                break;
                            case 19:
                                _currentCar.GetBlob1().method_149(_tempCar.GetBlob1().Flywheel());
                                break;
                            case 20:
                                _currentCar.GetBlob1().method_151(_tempCar.GetBlob1().Clutch());
                                break;
                            case 21:
                                _currentCar.GetBlob1().method_153(_tempCar.GetBlob1().Driveshaft());
                                break;
                            case 22:
                                _currentCar.GetBlob1().method_155(_tempCar.GetBlob1().Exhaust());
                                break;
                            case 23:
                                _currentCar.GetBlob1().method_157(_tempCar.GetBlob1().method_156());
                                break;
                            case 24:
                                _currentCar.GetBlob1().method_159(_tempCar.GetBlob1().ASM());
                                break;
                            case 25:
                                _currentCar.GetBlob1().method_161(_tempCar.GetBlob1().TCS());
                                break;
                            case 26:
                                _currentCar.GetBlob1().method_163(_tempCar.GetBlob1().method_162());
                                break;
                            case 27:
                                _currentCar.GetBlob1().method_165(_tempCar.GetBlob1().Supercharger());
                                break;
                            case 28:
                                _currentCar.GetBlob1().method_167(_tempCar.GetBlob1().Intake());
                                break;
                            case 29:
                                _currentCar.GetBlob1().method_169(_tempCar.GetBlob1().ExhaustManifold());
                                break;
                            case 30:
                                _currentCar.GetBlob1().method_171(_tempCar.GetBlob1().CatConverter());
                                break;
                            case 31:
                                _currentCar.GetBlob1().method_173(_tempCar.GetBlob1().AirFilter());
                                break;
                            case 32:
                                _currentCar.GetBlob1().method_175(_tempCar.GetBlob1().method_174());
                                break;
                            case 33:
                                _currentCar.GetBlob1().method_177(_tempCar.GetBlob1().WindowWR());
                                break;
                            case 34:
                                _currentCar.GetBlob1().method_179(_tempCar.GetBlob1().Hood());
                                break;
                            case 35:
                                _currentCar.GetBlob1().method_181(_tempCar.GetBlob1().FrBumper());
                                break;
                            case 36:
                                _currentCar.GetBlob1().method_183(_tempCar.GetBlob1().RrBumper());
                                break;
                            case 37:
                                _currentCar.GetBlob1().method_185(_tempCar.GetBlob1().Extension());
                                break;
                            case 38:
                                _currentCar.GetBlob1().method_187(_tempCar.GetBlob1().Wing());
                                break;
                            case 39:
                                _currentCar.GetBlob1().method_189(_tempCar.GetBlob1().method_188());
                                break;
                            case 40:
                                _currentCar.GetBlob1().method_191(_tempCar.GetBlob1().Reinforcement());
                                break;
                            case 41:
                                _currentCar.GetBlob1().method_193(_tempCar.GetBlob1().Nos());
                                break;
                        }
                    }
                }
            }
            method_18();
        }

        private void dataGridView_Dest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (dataGridView_Dest.SelectedCells[0].Value.ToString())
            {
                case "Tune Sheet":
                    var setUp = new SetUp(_currentCar);
                    if (setUp.ShowDialog() != DialogResult.OK)
                        break;
                    _currentCar.UpdateBlob1(setUp.method_2());
                    _currentCar.UpdateBlob2(setUp.method_4());
                    _currentCar.UpdateBlob3(setUp.method_6());
                    UpdateBlobFromCarParam(_currentCar.GetBlob1().GetBlob(), _currentCar.GetBlob1());
                    UpdateBlobFromCarParam(_currentCar.GetBlob2().GetBlob(), _currentCar.GetBlob2());
                    UpdateBlobFromCarParam(_currentCar.GetBlob3().GetBlob(), _currentCar.GetBlob3());
                    method_18();
                    break;
                case "Paint":
                    var paintSelector = new PaintSelector();
                    if (paintSelector.ShowDialog() == DialogResult.OK)
                    {
                        switch (_char0)
                        {
                            case 'a':
                                _currentCar.GetBlob1().method_105(paintSelector.method_0());
                                LoadCarSheet('a');
                                break;
                            case 'b':
                                _currentCar.GetBlob2().method_105(paintSelector.method_0());
                                LoadCarSheet('b');
                                break;
                            case 'c':
                                _currentCar.GetBlob3().method_105(paintSelector.method_0());
                                LoadCarSheet('c');
                                break;
                        }
                        method_18();
                    }
                    paintSelector.Dispose();
                    break;
            }
        }

        public void method_9(ref DataGridView dataGridView_0, ref byte[] carParamBlob)
        {
            try
            {
                InsertUIntToByteArray(carParamBlob, 77U, 4U, Convert.ToUInt32(dataGridView_0.Rows[1].Cells[1].EditedFormattedValue.ToString(), 16));
                InsertUIntToByteArray(carParamBlob, 157U, 4U, Convert.ToUInt32(dataGridView_0.Rows[2].Cells[1].EditedFormattedValue.ToString(), 16));
                UpdateBlobWithByte(carParamBlob, 169U, Convert.ToByte(dataGridView_0.Rows[3].Cells[1].EditedFormattedValue.ToString(), 16));
                InsertUIntToByteArray(carParamBlob, 194U, 4U, Convert.ToUInt32(dataGridView_0.Rows[4].Cells[1].EditedFormattedValue.ToString(), 16));
                InsertUIntToByteArray(carParamBlob, 198U, 4U, Convert.ToUInt32(dataGridView_0.Rows[5].Cells[1].EditedFormattedValue.ToString(), 16));
                InsertUIntToByteArray(carParamBlob, 202U, 4U, Convert.ToUInt32(dataGridView_0.Rows[6].Cells[1].EditedFormattedValue.ToString(), 16));
                InsertUIntToByteArray(carParamBlob, 206U, 4U, Convert.ToUInt32(dataGridView_0.Rows[7].Cells[1].EditedFormattedValue.ToString(), 16));
                InsertUIntToByteArray(carParamBlob, 210U, 4U, Convert.ToUInt32(dataGridView_0.Rows[8].Cells[1].EditedFormattedValue.ToString(), 16));
                InsertUIntToByteArray(carParamBlob, 214U, 4U, Convert.ToUInt32(dataGridView_0.Rows[9].Cells[1].EditedFormattedValue.ToString(), 16));
                InsertUIntToByteArray(carParamBlob, 218U, 4U, Convert.ToUInt32(dataGridView_0.Rows[10].Cells[1].EditedFormattedValue.ToString(), 16));
                InsertUIntToByteArray(carParamBlob, 222U, 4U, Convert.ToUInt32(dataGridView_0.Rows[11].Cells[1].EditedFormattedValue.ToString(), 16));
                InsertUIntToByteArray(carParamBlob, 226U, 4U, Convert.ToUInt32(dataGridView_0.Rows[12].Cells[1].EditedFormattedValue.ToString(), 16));
                InsertUIntToByteArray(carParamBlob, 230U, 4U, Convert.ToUInt32(dataGridView_0.Rows[13].Cells[1].EditedFormattedValue.ToString(), 16));
                InsertUIntToByteArray(carParamBlob, 234U, 4U, Convert.ToUInt32(dataGridView_0.Rows[14].Cells[1].EditedFormattedValue.ToString(), 16));
                InsertUIntToByteArray(carParamBlob, 238U, 4U, Convert.ToUInt32(dataGridView_0.Rows[15].Cells[1].EditedFormattedValue.ToString(), 16));
                InsertUIntToByteArray(carParamBlob, 242U, 4U, Convert.ToUInt32(dataGridView_0.Rows[16].Cells[1].EditedFormattedValue.ToString(), 16));
                InsertUIntToByteArray(carParamBlob, 246U, 4U, Convert.ToUInt32(dataGridView_0.Rows[17].Cells[1].EditedFormattedValue.ToString(), 16));
                InsertUIntToByteArray(carParamBlob, 250U, 4U, Convert.ToUInt32(dataGridView_0.Rows[18].Cells[1].EditedFormattedValue.ToString(), 16));
                InsertUIntToByteArray(carParamBlob, 254U, 4U, Convert.ToUInt32(dataGridView_0.Rows[19].Cells[1].EditedFormattedValue.ToString(), 16));
                InsertUIntToByteArray(carParamBlob, 258U, 4U, Convert.ToUInt32(dataGridView_0.Rows[20].Cells[1].EditedFormattedValue.ToString(), 16));
                InsertUIntToByteArray(carParamBlob, 262U, 4U, Convert.ToUInt32(dataGridView_0.Rows[21].Cells[1].EditedFormattedValue.ToString(), 16));
                InsertUIntToByteArray(carParamBlob, 266U, 4U, Convert.ToUInt32(dataGridView_0.Rows[22].Cells[1].EditedFormattedValue.ToString(), 16));
                InsertUIntToByteArray(carParamBlob, 270U, 4U, Convert.ToUInt32(dataGridView_0.Rows[23].Cells[1].EditedFormattedValue.ToString(), 16));
                InsertUIntToByteArray(carParamBlob, 274U, 4U, Convert.ToUInt32(dataGridView_0.Rows[24].Cells[1].EditedFormattedValue.ToString(), 16));
                InsertUIntToByteArray(carParamBlob, 278U, 4U, Convert.ToUInt32(dataGridView_0.Rows[25].Cells[1].EditedFormattedValue.ToString(), 16));
                InsertUIntToByteArray(carParamBlob, 282U, 4U, Convert.ToUInt32(dataGridView_0.Rows[26].Cells[1].EditedFormattedValue.ToString(), 16));
                InsertUIntToByteArray(carParamBlob, 286U, 4U, Convert.ToUInt32(dataGridView_0.Rows[27].Cells[1].EditedFormattedValue.ToString(), 16));
                InsertUIntToByteArray(carParamBlob, 290U, 4U, Convert.ToUInt32(dataGridView_0.Rows[28].Cells[1].EditedFormattedValue.ToString(), 16));
                InsertUIntToByteArray(carParamBlob, 294U, 4U, Convert.ToUInt32(dataGridView_0.Rows[29].Cells[1].EditedFormattedValue.ToString(), 16));
                InsertUIntToByteArray(carParamBlob, 298U, 4U, Convert.ToUInt32(dataGridView_0.Rows[30].Cells[1].EditedFormattedValue.ToString(), 16));
                InsertUIntToByteArray(carParamBlob, 302U, 4U, Convert.ToUInt32(dataGridView_0.Rows[31].Cells[1].EditedFormattedValue.ToString(), 16));
                InsertUIntToByteArray(carParamBlob, 306U, 4U, Convert.ToUInt32(dataGridView_0.Rows[32].Cells[1].EditedFormattedValue.ToString(), 16));
                InsertUIntToByteArray(carParamBlob, 310U, 4U, Convert.ToUInt32(dataGridView_0.Rows[33].Cells[1].EditedFormattedValue.ToString(), 16));
                InsertUIntToByteArray(carParamBlob, 314U, 4U, Convert.ToUInt32(dataGridView_0.Rows[34].Cells[1].EditedFormattedValue.ToString(), 16));
                InsertUIntToByteArray(carParamBlob, 318U, 4U, Convert.ToUInt32(dataGridView_0.Rows[35].Cells[1].EditedFormattedValue.ToString(), 16));
                InsertUIntToByteArray(carParamBlob, 322U, 4U, Convert.ToUInt32(dataGridView_0.Rows[36].Cells[1].EditedFormattedValue.ToString(), 16));
                InsertUIntToByteArray(carParamBlob, 326U, 4U, Convert.ToUInt32(dataGridView_0.Rows[37].Cells[1].EditedFormattedValue.ToString(), 16));
                InsertUIntToByteArray(carParamBlob, 330U, 4U, Convert.ToUInt32(dataGridView_0.Rows[38].Cells[1].EditedFormattedValue.ToString(), 16));
                InsertUIntToByteArray(carParamBlob, 334U, 4U, Convert.ToUInt32(dataGridView_0.Rows[39].Cells[1].EditedFormattedValue.ToString(), 16));
                InsertUIntToByteArray(carParamBlob, 338U, 4U, Convert.ToUInt32(dataGridView_0.Rows[40].Cells[1].EditedFormattedValue.ToString(), 16));
                InsertUIntToByteArray(carParamBlob, 342U, 4U, Convert.ToUInt32(dataGridView_0.Rows[41].Cells[1].EditedFormattedValue.ToString(), 16));
            }
            catch
            {
                var num = (int)MessageBox.Show(this, "Bad Input, try entering a smaller value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dataGridView_Dest_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (IsAlphaNumeric(dataGridView_Dest.CurrentCell.EditedFormattedValue.ToString()) && dataGridView_Dest.CurrentCell.EditedFormattedValue.ToString().Length == 8)
            {
                var carParamBlob = new byte[679];
                if (_char0.Equals('a'))
                    carParamBlob = _currentCar.GetBlob1().GetBlob();
                if (_char0.Equals('b'))
                    carParamBlob = _currentCar.GetBlob2().GetBlob();
                if (_char0.Equals('c'))
                    carParamBlob = _currentCar.GetBlob3().GetBlob();
                method_9(ref dataGridView_Dest, ref carParamBlob);
                if (tabControl_garage.SelectedIndex == tabControl_garage.TabPages.IndexOf(tabPage_garage))
                {
                    UpdateCarParamBlobs(_sqlHelper2, _currentCar);
                    dataTable_8 = _sqlHelper2.ExecuteReader("SELECT * FROM t_garage WHERE garage_id LIKE " + dataTable_7.Rows[comboBox_DModel.SelectedIndex].ItemArray[1]);
                    _currentCar = new Car(dataTable_8);
                    LoadCurrentCarDetails();
                }
                else
                    _currentCar.UpdateBlob1(new CarParameterBlob(_currentCar.GetBlob1().GetBlob()));
                LoadCarSheet(_char0);
            }
            else
                LoadCarSheet(_char0);
        }

        private void dataGridView_Dest_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var str = dataGridView_Dest.SelectedCells[0].Value.ToString();
                if (comboBox_DModel.SelectedIndex < 0 || str.Equals("Paint") && str.Equals("Tune Sheet") || (dataGridView_Dest.SelectedCells[0].RowIndex <= 0 || dataGridView_Dest.SelectedCells[0].ColumnIndex != 1))
                    return;
                LoadCarSheet(_char0);
            }
            catch
            {
            }
        }

        public static void RemoveDgvRows(ref DataGridView dgv)
        {
            while (Convert.ToBoolean(dgv.Rows.Count))
                dgv.Rows.Remove(dgv.Rows[0]);
        }

        public static void UpdateBlobWithByte(byte[] carParamBlob, uint pos, byte value)
        {
            carParamBlob[pos] = value;
        }

        public static void UpdateBlobWithSByte(byte[] carParamBlob, uint pos, sbyte value)
        {
            carParamBlob[pos] = (byte)value;
        }

        public static void InsertUIntToByteArray(byte[] carParamBlob, uint position, uint byteLength, uint value)
        {
            switch (byteLength)
            {
                case 1U:
                    carParamBlob[position] = (byte)(value & byte.MaxValue);
                    break;
                case 2U:
                    carParamBlob[position] = (byte)(value >> 8 & byte.MaxValue);
                    carParamBlob[(position + 1U)] = (byte)(value & byte.MaxValue);
                    break;
                case 4U:
                    carParamBlob[position] = (byte)(value >> 24 & byte.MaxValue);
                    carParamBlob[(position + 1U)] = (byte)(value >> 16 & byte.MaxValue);
                    carParamBlob[(position + 2U)] = (byte)(value >> 8 & byte.MaxValue);
                    carParamBlob[(position + 3U)] = (byte)(value & byte.MaxValue);
                    break;
            }
        }

        public static void UpdateBlobFromCarParam(byte[] carParamBlob, CarParameterBlob carParam)
        {
            InsertUIntToByteArray(carParamBlob, 37U, 4U, carParam.method_2());
            InsertUIntToByteArray(carParamBlob, 41U, 4U, carParam.method_4());
            InsertUIntToByteArray(carParamBlob, 49U, 4U, carParam.method_6());
            InsertUIntToByteArray(carParamBlob, 65U, 2U, carParam.method_8());
            InsertUIntToByteArray(carParamBlob, 67U, 2U, carParam.method_10());
            InsertUIntToByteArray(carParamBlob, 77U, 4U, carParam.Paint());
            InsertUIntToByteArray(carParamBlob, 157U, 4U, carParam.Body());
            UpdateBlobWithByte(carParamBlob, 169U, carParam.Colour());
            InsertUIntToByteArray(carParamBlob, 170U, 4U, carParam.method_106());
            InsertUIntToByteArray(carParamBlob, 174U, 4U, carParam.method_108());
            UpdateBlobWithByte(carParamBlob, 185U, carParam.method_16());
            UpdateBlobWithByte(carParamBlob, 193U, carParam.method_18());
            InsertUIntToByteArray(carParamBlob, 194U, 4U, carParam.Brakes());
            InsertUIntToByteArray(carParamBlob, 198U, 4U, carParam._198_201());
            InsertUIntToByteArray(carParamBlob, 202U, 4U, carParam.Chassis());
            InsertUIntToByteArray(carParamBlob, 206U, 4U, carParam.Engine());
            InsertUIntToByteArray(carParamBlob, 210U, 4U, carParam.DriveTrain());
            InsertUIntToByteArray(carParamBlob, 214U, 4U, carParam.Transmission());
            InsertUIntToByteArray(carParamBlob, 218U, 4U, carParam.Suspension());
            InsertUIntToByteArray(carParamBlob, 222U, 4U, carParam.LSD());
            InsertUIntToByteArray(carParamBlob, 226U, 4U, carParam.method_134());
            InsertUIntToByteArray(carParamBlob, 230U, 4U, carParam.WReduction());
            InsertUIntToByteArray(carParamBlob, 234U, 4U, carParam.method_138());
            InsertUIntToByteArray(carParamBlob, 238U, 4U, carParam.method_140());
            InsertUIntToByteArray(carParamBlob, 242U, 4U, carParam.ECU());
            InsertUIntToByteArray(carParamBlob, 246U, 4U, carParam.EngineTune());
            InsertUIntToByteArray(carParamBlob, 250U, 4U, carParam.Turbo());
            InsertUIntToByteArray(carParamBlob, 254U, 4U, carParam.Flywheel());
            InsertUIntToByteArray(carParamBlob, 258U, 4U, carParam.Clutch());
            InsertUIntToByteArray(carParamBlob, 262U, 4U, carParam.Driveshaft());
            InsertUIntToByteArray(carParamBlob, 266U, 4U, carParam.Exhaust());
            InsertUIntToByteArray(carParamBlob, 270U, 4U, carParam.method_156());
            InsertUIntToByteArray(carParamBlob, 274U, 4U, carParam.ASM());
            InsertUIntToByteArray(carParamBlob, 278U, 4U, carParam.TCS());
            InsertUIntToByteArray(carParamBlob, 282U, 4U, carParam.method_162());
            InsertUIntToByteArray(carParamBlob, 286U, 4U, carParam.Supercharger());
            InsertUIntToByteArray(carParamBlob, 290U, 4U, carParam.Intake());
            InsertUIntToByteArray(carParamBlob, 294U, 4U, carParam.ExhaustManifold());
            InsertUIntToByteArray(carParamBlob, 298U, 4U, carParam.CatConverter());
            InsertUIntToByteArray(carParamBlob, 302U, 4U, carParam.AirFilter());
            InsertUIntToByteArray(carParamBlob, 306U, 4U, carParam.method_174());
            InsertUIntToByteArray(carParamBlob, 310U, 4U, carParam.WindowWR());
            InsertUIntToByteArray(carParamBlob, 314U, 4U, carParam.Hood());
            InsertUIntToByteArray(carParamBlob, 318U, 4U, carParam.FrBumper());
            InsertUIntToByteArray(carParamBlob, 322U, 4U, carParam.RrBumper());
            InsertUIntToByteArray(carParamBlob, 326U, 4U, carParam.Extension());
            InsertUIntToByteArray(carParamBlob, 330U, 4U, carParam.Wing());
            InsertUIntToByteArray(carParamBlob, 334U, 4U, carParam.method_188());
            InsertUIntToByteArray(carParamBlob, 338U, 4U, carParam.Reinforcement());
            InsertUIntToByteArray(carParamBlob, 342U, 4U, carParam.Nos());
            InsertUIntToByteArray(carParamBlob, 346U, 2U, carParam.method_20());
            InsertUIntToByteArray(carParamBlob, 348U, 2U, carParam.method_22());
            InsertUIntToByteArray(carParamBlob, 350U, 2U, carParam.method_24());
            InsertUIntToByteArray(carParamBlob, 352U, 2U, carParam.method_26());
            InsertUIntToByteArray(carParamBlob, 354U, 2U, carParam.method_28());
            InsertUIntToByteArray(carParamBlob, 356U, 2U, carParam.method_30());
            InsertUIntToByteArray(carParamBlob, 358U, 2U, carParam.method_32());
            InsertUIntToByteArray(carParamBlob, 360U, 2U, carParam.method_34());
            InsertUIntToByteArray(carParamBlob, 362U, 2U, carParam.method_36());
            InsertUIntToByteArray(carParamBlob, 364U, 2U, carParam.method_38());
            InsertUIntToByteArray(carParamBlob, 366U, 2U, carParam.method_40());
            InsertUIntToByteArray(carParamBlob, 368U, 2U, carParam.method_42());
            InsertUIntToByteArray(carParamBlob, 370U, 2U, carParam.method_44());
            UpdateBlobWithByte(carParamBlob, 375U, carParam.method_46());
            UpdateBlobWithByte(carParamBlob, 378U, carParam.method_48());
            UpdateBlobWithByte(carParamBlob, 379U, carParam.method_50());
            UpdateBlobWithByte(carParamBlob, 386U, carParam.method_52());
            UpdateBlobWithByte(carParamBlob, 387U, carParam.method_54());
            InsertUIntToByteArray(carParamBlob, 388U, 2U, carParam.method_56());
            InsertUIntToByteArray(carParamBlob, 390U, 2U, carParam.method_58());
            UpdateBlobWithSByte(carParamBlob, 392U, carParam.method_60());
            UpdateBlobWithSByte(carParamBlob, 393U, carParam.method_62());
            UpdateBlobWithByte(carParamBlob, 394U, carParam.method_64());
            UpdateBlobWithByte(carParamBlob, 395U, carParam.method_66());
            UpdateBlobWithByte(carParamBlob, 398U, carParam.method_68());
            UpdateBlobWithByte(carParamBlob, 399U, carParam.method_68());
            UpdateBlobWithByte(carParamBlob, 400U, carParam.method_70());
            UpdateBlobWithByte(carParamBlob, 401U, carParam.method_70());
            UpdateBlobWithByte(carParamBlob, 402U, carParam.method_72());
            UpdateBlobWithByte(carParamBlob, 403U, carParam.method_72());
            UpdateBlobWithByte(carParamBlob, 404U, carParam.method_74());
            UpdateBlobWithByte(carParamBlob, 405U, carParam.method_74());
            UpdateBlobWithByte(carParamBlob, 406U, carParam.method_76());
            UpdateBlobWithByte(carParamBlob, 407U, carParam.method_78());
            UpdateBlobWithByte(carParamBlob, 408U, carParam.method_80());
            UpdateBlobWithByte(carParamBlob, 409U, carParam.method_82());
            UpdateBlobWithByte(carParamBlob, 410U, carParam.method_84());
            UpdateBlobWithByte(carParamBlob, 411U, carParam.method_86());
            UpdateBlobWithByte(carParamBlob, 412U, carParam.method_88());
            UpdateBlobWithByte(carParamBlob, 413U, carParam.method_90());
            UpdateBlobWithByte(carParamBlob, 419U, carParam.method_92());
            UpdateBlobWithSByte(carParamBlob, 420U, carParam.method_94());
            UpdateBlobWithByte(carParamBlob, 431U, carParam.method_112());
            UpdateBlobWithByte(carParamBlob, 432U, carParam.method_96());
            UpdateBlobWithByte(carParamBlob, 433U, carParam.method_98());
            UpdateBlobWithByte(carParamBlob, 422U, carParam.method_110());
            UpdateBlobWithByte(carParamBlob, 425U, carParam.method_114());
        }

        public static ulong smethod_7(uint uint_0, uint uint_1, byte[] byte_3)
        {
            var num = 0U;
            for (var index = uint_0; index <= uint_1; ++index)
                num = (int)index != (int)uint_0 ? num << 8 | byte_3[index] : byte_3[index];
            return num;
        }

        public static void smethod_8(byte[] byte_3, uint uint_0, byte byte_4)
        {
            byte_3[uint_0] = byte_4;
        }

        public static void smethod_9(byte[] byte_3, uint uint_0, sbyte sbyte_0)
        {
            byte_3[uint_0] = (byte)sbyte_0;
        }

        public static void smethod_10(byte[] byte_3, uint uint_0, uint uint_1, uint uint_2)
        {
            switch (uint_1)
            {
                case 1U:
                    byte_3[uint_0] = (byte)(uint_2 & byte.MaxValue);
                    break;
                case 2U:
                    byte_3[uint_0] = (byte)(uint_2 >> 8 & byte.MaxValue);
                    byte_3[(uint_0 + 1U)] = (byte)(uint_2 & byte.MaxValue);
                    break;
                case 4U:
                    byte_3[uint_0] = (byte)(uint_2 >> 24 & byte.MaxValue);
                    byte_3[(uint_0 + 1U)] = (byte)(uint_2 >> 16 & byte.MaxValue);
                    byte_3[(uint_0 + 2U)] = (byte)(uint_2 >> 8 & byte.MaxValue);
                    byte_3[(uint_0 + 3U)] = (byte)(uint_2 & byte.MaxValue);
                    break;
            }
        }

        public static void smethod_11(byte[] byte_3, uint uint_0, uint uint_1, ulong ulong_1)
        {
            switch (uint_1)
            {
                case 1U:
                    byte_3[uint_0] = (byte)(ulong_1 & byte.MaxValue);
                    break;
                case 2U:
                    byte_3[uint_0] = (byte)(ulong_1 >> 8 & byte.MaxValue);
                    byte_3[(uint_0 + 1U)] = (byte)(ulong_1 & byte.MaxValue);
                    break;
                case 4U:
                    byte_3[uint_0] = (byte)(ulong_1 >> 24 & byte.MaxValue);
                    byte_3[(uint_0 + 1U)] = (byte)(ulong_1 >> 16 & byte.MaxValue);
                    byte_3[(uint_0 + 2U)] = (byte)(ulong_1 >> 8 & byte.MaxValue);
                    byte_3[(uint_0 + 3U)] = (byte)(ulong_1 & byte.MaxValue);
                    break;
                case 8U:
                    byte_3[uint_0] = (byte)(ulong_1 >> 56 & byte.MaxValue);
                    byte_3[(uint_0 + 1U)] = (byte)(ulong_1 >> 48 & byte.MaxValue);
                    byte_3[(uint_0 + 2U)] = (byte)(ulong_1 >> 40 & byte.MaxValue);
                    byte_3[(uint_0 + 3U)] = (byte)(ulong_1 >> 32 & byte.MaxValue);
                    byte_3[(uint_0 + 4U)] = (byte)(ulong_1 >> 24 & byte.MaxValue);
                    byte_3[(uint_0 + 5U)] = (byte)(ulong_1 >> 16 & byte.MaxValue);
                    byte_3[(uint_0 + 6U)] = (byte)(ulong_1 >> 8 & byte.MaxValue);
                    byte_3[(uint_0 + 7U)] = (byte)(ulong_1 & byte.MaxValue);
                    break;
            }
        }

        private static void smethod_12(string string_4)
        {
            try
            {
                if (!File.Exists(string_4))
                    return;
                var stringBuilder_0 = new StringBuilder(string.Empty);
                var bool_0 = false;
                var int_0 = 0;
                var byte_4 = new byte[5];
                var byte_5 = new byte[2];
                var numArray = new byte[4];
                var streamWriter_0 = new StreamWriter(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\log.txt");
                var fileStream_0 = new FileStream(string_4, FileMode.Open);
                byte byte_3 = 0;
                fileStream_0.Position = 33L;
                fileStream_0.Read(numArray, 0, 4);
                var num1 = (uint)smethod_7(0U, 3U, numArray);
                fileStream_0.Position = 42L;
                while (fileStream_0.Position < num1 + 32U)
                    smethod_13(fileStream_0, streamWriter_0, byte_3, byte_4, byte_5, ref stringBuilder_0, ref bool_0, ref int_0);
                list_1 = Enumerable.ToList<int>(Enumerable.Distinct<int>(list_0));
                list_1.Sort();
                var num2 = 0;
                foreach (var num3 in list_1)
                    list_2.Add(smethod_16(fileStream_0, num2++));
                fileStream_0.Close();
            }
            catch
            {
            }
        }

        public static void smethod_13(FileStream fileStream_0, StreamWriter streamWriter_0, byte byte_3, byte[] byte_4, byte[] byte_5, ref StringBuilder stringBuilder_0, ref bool bool_0, ref int int_0)
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
                    smethod_14(fileStream_0, streamWriter_0, byte_3, ref byte_4, ref byte_5, ref stringBuilder_0, ref bool_0, ref int_0, (int)fileStream_0.Position - 2);
                }
                else
                {
                    if (byte_3 != 128 && byte_3 != 129)
                        return;
                    byte_3 = (byte)fileStream_0.ReadByte();
                    byte_4[2] = byte_3;
                    smethod_14(fileStream_0, streamWriter_0, byte_3, ref byte_4, ref byte_5, ref stringBuilder_0, ref bool_0, ref int_0, (int)fileStream_0.Position - 3);
                }
            }
            catch
            {
            }
        }

        public static void smethod_14(FileStream fileStream_0, StreamWriter streamWriter_0, byte byte_3, ref byte[] byte_4, ref byte[] byte_5, ref StringBuilder stringBuilder_0, ref bool bool_0, ref int int_0, int int_1)
        {
            try
            {
                var num1 = 0;
                var numArray = new byte[4];
                fileStream_0.Read(byte_5, 0, 2);
                var fileStream1 = fileStream_0;
                var num2 = fileStream1.Position - 1L;
                fileStream1.Position = num2;
                int_1 = (int)byte_4[1] > (int)sbyte.MaxValue ? (int)fileStream_0.Position - 4 : (int)fileStream_0.Position - 3;
                switch (byte_5[0])
                {
                    case 0:
                        smethod_15(fileStream_0, streamWriter_0, ref byte_4, ref byte_5, ref stringBuilder_0, ref bool_0, ref int_0, int_1);
                        break;
                    case 1:
                        smethod_15(fileStream_0, streamWriter_0, ref byte_4, ref byte_5, ref stringBuilder_0, ref bool_0, ref int_0, int_1);
                        var fileStream2 = fileStream_0;
                        var num3 = fileStream2.Position + 1L;
                        fileStream2.Position = num3;
                        break;
                    case 2:
                        smethod_15(fileStream_0, streamWriter_0, ref byte_4, ref byte_5, ref stringBuilder_0, ref bool_0, ref int_0, int_1);
                        var fileStream3 = fileStream_0;
                        var num4 = fileStream3.Position + 2L;
                        fileStream3.Position = num4;
                        break;
                    case 3:
                        smethod_15(fileStream_0, streamWriter_0, ref byte_4, ref byte_5, ref stringBuilder_0, ref bool_0, ref int_0, int_1);
                        var fileStream4 = fileStream_0;
                        var num5 = fileStream4.Position + 4L;
                        fileStream4.Position = num5;
                        break;
                    case 4:
                        smethod_15(fileStream_0, streamWriter_0, ref byte_4, ref byte_5, ref stringBuilder_0, ref bool_0, ref int_0, int_1);
                        num1 = 8;
                        var fileStream5 = fileStream_0;
                        var num6 = fileStream5.Position + 8L;
                        fileStream5.Position = num6;
                        break;
                    case 5:
                        smethod_15(fileStream_0, streamWriter_0, ref byte_4, ref byte_5, ref stringBuilder_0, ref bool_0, ref int_0, int_1);
                        num1 = 4;
                        var fileStream6 = fileStream_0;
                        var num7 = fileStream6.Position + 4L;
                        fileStream6.Position = num7;
                        break;
                    case 6:
                        smethod_15(fileStream_0, streamWriter_0, ref byte_4, ref byte_5, ref stringBuilder_0, ref bool_0, ref int_0, int_1);
                        fileStream_0.Read(numArray, 0, 4);
                        var num8 = (int)smethod_7(0U, 3U, numArray);
                        var fileStream7 = fileStream_0;
                        var num9 = fileStream7.Position + num8;
                        fileStream7.Position = num9;
                        break;
                    case 7:
                        bool_0 = false;
                        smethod_15(fileStream_0, streamWriter_0, ref byte_4, ref byte_5, ref stringBuilder_0, ref bool_0, ref int_0, int_1);
                        var fileStream8 = fileStream_0;
                        var num10 = fileStream8.Position - 1L;
                        fileStream8.Position = num10;
                        break;
                    case 8:
                        smethod_15(fileStream_0, streamWriter_0, ref byte_4, ref byte_5, ref stringBuilder_0, ref bool_0, ref int_0, int_1);
                        stringBuilder_0.Append("[]");
                        fileStream_0.Read(numArray, 0, 4);
                        var num11 = (int)smethod_7(0U, 3U, numArray);
                        byte_3 = (byte)fileStream_0.ReadByte();
                        var fileStream9 = fileStream_0;
                        var num12 = fileStream9.Position - 1L;
                        fileStream9.Position = num12;
                        if (byte_3 == 7)
                        {
                            bool_0 = false;
                            for (var index = 0; index < num11; ++index)
                                smethod_13(fileStream_0, streamWriter_0, byte_3, byte_4, byte_5, ref stringBuilder_0, ref bool_0, ref int_0);
                        }
                        else
                        {
                            bool_0 = true;
                            for (var index = 0; index < num11; ++index)
                                smethod_14(fileStream_0, streamWriter_0, byte_3, ref byte_4, ref byte_5, ref stringBuilder_0, ref bool_0, ref int_0, int_1);
                            bool_0 = false;
                        }
                        stringBuilder_0.Remove(stringBuilder_0.Length - 2, 2);
                        break;
                    case 9:
                        smethod_15(fileStream_0, streamWriter_0, ref byte_4, ref byte_5, ref stringBuilder_0, ref bool_0, ref int_0, int_1);
                        fileStream_0.Read(numArray, 0, 4);
                        stringBuilder_0.Append("{}");
                        var num13 = (int)smethod_7(0U, 3U, numArray);
                        byte_3 = (byte)fileStream_0.ReadByte();
                        var fileStream10 = fileStream_0;
                        var num14 = fileStream10.Position - 1L;
                        fileStream10.Position = num14;
                        if (byte_3 == 7)
                        {
                            bool_0 = false;
                            for (var index = 0; index < num13; ++index)
                                smethod_13(fileStream_0, streamWriter_0, byte_3, byte_4, byte_5, ref stringBuilder_0, ref bool_0, ref int_0);
                        }
                        else
                        {
                            bool_0 = true;
                            for (var index = 0; index < num13 * 2; ++index)
                                smethod_14(fileStream_0, streamWriter_0, byte_3, ref byte_4, ref byte_5, ref stringBuilder_0, ref bool_0, ref int_0, int_1);
                            bool_0 = false;
                        }
                        stringBuilder_0.Remove(stringBuilder_0.Length - 2, 2);
                        break;
                    case 10:
                        byte_3 = (byte)fileStream_0.ReadByte();
                        if (byte_3 == 9)
                        {
                            smethod_15(fileStream_0, streamWriter_0, ref byte_4, ref byte_5, ref stringBuilder_0, ref bool_0, ref int_0, int_1);
                            stringBuilder_0.Append("<>");
                            fileStream_0.Read(numArray, 0, 4);
                            var num15 = (int)smethod_7(0U, 3U, numArray);
                            for (var index = 0; index < num15; ++index)
                                smethod_13(fileStream_0, streamWriter_0, byte_3, byte_4, byte_5, ref stringBuilder_0, ref bool_0, ref int_0);
                            stringBuilder_0.Remove(stringBuilder_0.Length - 2, 2);
                            break;
                        }
                        else
                        {
                            if (byte_3 != 6)
                                break;
                            smethod_15(fileStream_0, streamWriter_0, ref byte_4, ref byte_5, ref stringBuilder_0, ref bool_0, ref int_0, int_1);
                            stringBuilder_0.Append("<>");
                            var fileStream11 = fileStream_0;
                            var num15 = fileStream11.Position + 8L;
                            fileStream11.Position = num15;
                            fileStream_0.Read(numArray, 0, 4);
                            var num16 = (int)smethod_7(0U, 3U, numArray);
                            var fileStream12 = fileStream_0;
                            var num17 = fileStream12.Position + num16 * 16;
                            fileStream12.Position = num17;
                            stringBuilder_0.Remove(stringBuilder_0.Length - 2, 2);
                            break;
                        }
                    case 12:
                        smethod_15(fileStream_0, streamWriter_0, ref byte_4, ref byte_5, ref stringBuilder_0, ref bool_0, ref int_0, int_1);
                        num1 = 1;
                        var fileStream13 = fileStream_0;
                        var num18 = fileStream13.Position + 1L;
                        fileStream13.Position = num18;
                        break;
                    case 13:
                        smethod_15(fileStream_0, streamWriter_0, ref byte_4, ref byte_5, ref stringBuilder_0, ref bool_0, ref int_0, int_1);
                        num1 = 2;
                        var fileStream14 = fileStream_0;
                        var num19 = fileStream14.Position + 2L;
                        fileStream14.Position = num19;
                        break;
                    case 14:
                        smethod_15(fileStream_0, streamWriter_0, ref byte_4, ref byte_5, ref stringBuilder_0, ref bool_0, ref int_0, int_1);
                        num1 = 4;
                        var fileStream15 = fileStream_0;
                        var num20 = fileStream15.Position + 4L;
                        fileStream15.Position = num20;
                        break;
                    case 15:
                        smethod_15(fileStream_0, streamWriter_0, ref byte_4, ref byte_5, ref stringBuilder_0, ref bool_0, ref int_0, int_1);
                        num1 = 8;
                        var fileStream16 = fileStream_0;
                        var num21 = fileStream16.Position + 8L;
                        fileStream16.Position = num21;
                        break;
                }
            }
            catch
            {
            }
        }

        public static void smethod_15(FileStream fileStream_0, StreamWriter streamWriter_0, ref byte[] byte_3, ref byte[] byte_4, ref StringBuilder stringBuilder_0, ref bool bool_0, ref int int_0, int int_1)
        {
            try
            {
                if (bool_0 || byte_4[0] < 0 || byte_4[0] >= 16)
                    return;
                Console.Write(stringBuilder_0.ToString());
                if (byte_4[0] == 7)
                {
                    if (byte_3[1] >= 128 && byte_3[1] <= 129)
                    {
                        list_0.Add((int)smethod_7(0U, 2U, byte_3));
                        list_3.Add(int_1);
                    }
                    else
                    {
                        list_3.Add(int_1);
                        list_0.Add((int)smethod_7(0U, 1U, byte_3));
                    }
                }
                else if (byte_3[1] <= sbyte.MaxValue)
                {
                    list_3.Add(int_1);
                    list_0.Add((int)smethod_7(0U, 1U, byte_3));
                }
                else if (byte_3[1] <= 129)
                {
                    list_3.Add(int_1);
                    list_0.Add((int)smethod_7(0U, 2U, byte_3));
                }
                ++int_0;
            }
            catch
            {
            }
        }

        public static string smethod_16(FileStream fileStream_0, int int_0)
        {
            try
            {
                var stringBuilder = new StringBuilder(string.Empty);
                var numArray = new byte[4];
                fileStream_0.Position = 33L;
                fileStream_0.Read(numArray, 0, 4);
                var num1 = (uint)smethod_7(0U, 3U, numArray);
                fileStream_0.Position = num1 + 34U;
                for (var index1 = 0; index1 <= int_0; ++index1)
                {
                    stringBuilder.Remove(0, stringBuilder.Length);
                    var num2 = fileStream_0.ReadByte();
                    for (var index2 = 0; index2 < num2; ++index2)
                        stringBuilder.Append((char)fileStream_0.ReadByte());
                }
                return stringBuilder.ToString();
            }
            catch
            {
                return string.Empty;
            }
        }

        public static int smethod_17(string string_4)
        {
            try
            {
                var index1 = list_2.IndexOf(string_4);
                var index2 = list_0.IndexOf(list_1[index1]);
                return list_3[index2];
            }
            catch
            {
                return 0;
            }
        }

        public static ulong smethod_18(string string_4, string string_5, byte byte_3)
        {
            try
            {
                var num1 = 0UL;
                var numArray = new byte[8];
                var fileStream1 = new FileStream(string_4, FileMode.Open);
                fileStream1.Position = smethod_17(string_5);
                if ((byte)fileStream1.ReadByte() == 7)
                {
                    var num2 = (byte)fileStream1.ReadByte();
                    if (num2 <= sbyte.MaxValue)
                    {
                        var fileStream2 = fileStream1;
                        var num3 = fileStream2.Position + 1L;
                        fileStream2.Position = num3;
                    }
                    else if (num2 == 128 || num2 == 129)
                    {
                        var fileStream2 = fileStream1;
                        var num3 = fileStream2.Position + 2L;
                        fileStream2.Position = num3;
                    }
                    switch (byte_3)
                    {
                        case 1:
                            fileStream1.Read(numArray, 7, 1);
                            num1 = smethod_7(7U, 7U, numArray);
                            break;
                        case 2:
                            fileStream1.Read(numArray, 6, 2);
                            num1 = smethod_7(6U, 7U, numArray);
                            break;
                        case 4:
                            fileStream1.Read(numArray, 4, 4);
                            num1 = smethod_7(4U, 7U, numArray);
                            break;
                        case 8:
                            fileStream1.Read(numArray, 0, 8);
                            num1 = smethod_7(0U, 7U, numArray);
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

        public static void smethod_19(string string_4, string string_5, byte byte_3, ulong ulong_1)
        {
            try
            {
                var numArray = new byte[8];
                var fileStream1 = new FileStream(string_4, FileMode.Open) {Position = smethod_17(string_5)};
                if ((byte)fileStream1.ReadByte() == 7)
                {
                    var num1 = (byte)fileStream1.ReadByte();
                    if (num1 <= sbyte.MaxValue)
                    {
                        var fileStream2 = fileStream1;
                        var num2 = fileStream2.Position + 1L;
                        fileStream2.Position = num2;
                    }
                    else if (num1 == 128 || num1 == 129)
                    {
                        var fileStream2 = fileStream1;
                        var num2 = fileStream2.Position + 2L;
                        fileStream2.Position = num2;
                    }
                    switch (byte_3)
                    {
                        case 1:
                            smethod_11(numArray, 7U, 1U, ulong_1);
                            fileStream1.Write(numArray, 7, 1);
                            break;
                        case 2:
                            smethod_11(numArray, 6U, 2U, ulong_1);
                            fileStream1.Write(numArray, 6, 2);
                            break;
                        case 4:
                            smethod_11(numArray, 4U, 4U, ulong_1);
                            fileStream1.Write(numArray, 4, 4);
                            break;
                        case 8:
                            smethod_11(numArray, 0U, 8U, ulong_1);
                            fileStream1.Write(numArray, 0, 8);
                            break;
                    }
                }
                fileStream1.Close();
            }
            catch
            {
            }
        }

        public void DecryptSave(string pathToSave)
        {
            if (File.Exists(pathToSave + "\\GT5.0"))
                _numberOfFilesInSave = 1;
            if (File.Exists(pathToSave + "\\GT5.1"))
                ++_numberOfFilesInSave;
            if (File.Exists(pathToSave + "\\GT5.2"))
                ++_numberOfFilesInSave;
            if (File.Exists(pathToSave + "\\GT5.3"))
                ++_numberOfFilesInSave;
            var process = new Process
            {
                StartInfo = {FileName = Application.StartupPath + @"\Dependancies" + "\\pfdtool.exe"}
            };
            switch (_numberOfFilesInSave)
            {
                case 1:
                    process.StartInfo.Arguments = "-g BCES00569 -d \"" + pathToSave + "\" GT5.0";
                    break;
                case 2:
                    process.StartInfo.Arguments = "-g BCES00569 -d \"" + pathToSave + "\" GT5.0 GT5.1";
                    break;
                case 3:
                    process.StartInfo.Arguments = "-g BCES00569 -d \"" + pathToSave + "\" GT5.0 GT5.1 GT5.2";
                    break;
                case 4:
                    process.StartInfo.Arguments = "-g BCES00569 -d \"" + pathToSave + "\" GT5.0 GT5.1 GT5.2 GT5.3";
                    break;
            }
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.WorkingDirectory = Application.StartupPath + @"\Dependancies";
            process.Start();
            process.WaitForExit();
            process.Close();
            Thread.Sleep(60);
        }

        public void EncryptSave(string pathToSave)
        {
            var startInfo = new ProcessStartInfo();
            switch (_numberOfFilesInSave)
            {
                case 1:
                    startInfo.Arguments = "-g BCES00569 -e \"" + pathToSave + "\" GT5.0";
                    break;
                case 2:
                    startInfo.Arguments = "-g BCES00569 -e \"" + pathToSave + "\" GT5.0 GT5.1";
                    break;
                case 3:
                    startInfo.Arguments = "-g BCES00569 -e \"" + pathToSave + "\" GT5.0 GT5.1 GT5.2";
                    break;
                case 4:
                    startInfo.Arguments = "-g BCES00569 -e \"" + pathToSave + "\" GT5.0 GT5.1 GT5.2 GT5.3";
                    break;
            }
            startInfo.FileName = Application.StartupPath + @"\Dependancies" + "\\pfdtool.exe ";
            startInfo.RedirectStandardError = true;
            startInfo.RedirectStandardInput = true;
            startInfo.RedirectStandardOutput = true;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            Process.Start(startInfo);
        }

        public void CompileSaveIntoSingleDb(string pathToSave)
        {
            FileStream fileStream1 = null;
            FileStream fileStream2 = null;
            FileStream fileStream3 = null;
            FileStream fileStream4 = null;
            FileStream fileStream5 = null;
            try
            {
                switch (_numberOfFilesInSave)
                {
                    case 1:
                        fileStream1 = new FileStream(pathToSave + "\\GT5.0", FileMode.Open);
                        break;
                    case 2:
                        fileStream1 = new FileStream(pathToSave + "\\GT5.0", FileMode.Open);
                        fileStream2 = new FileStream(pathToSave + "\\GT5.1", FileMode.Open);
                        break;
                    case 3:
                        fileStream1 = new FileStream(pathToSave + "\\GT5.0", FileMode.Open);
                        fileStream2 = new FileStream(pathToSave + "\\GT5.1", FileMode.Open);
                        fileStream3 = new FileStream(pathToSave + "\\GT5.2", FileMode.Open);
                        break;
                    case 4:
                        fileStream1 = new FileStream(pathToSave + "\\GT5.0", FileMode.Open);
                        fileStream2 = new FileStream(pathToSave + "\\GT5.1", FileMode.Open);
                        fileStream3 = new FileStream(pathToSave + "\\GT5.2", FileMode.Open);
                        fileStream4 = new FileStream(pathToSave + "\\GT5.3", FileMode.Open);
                        break;
                }
                if (File.Exists(Application.StartupPath + "\\temp"))
                    File.Delete(Application.StartupPath + "\\temp");
                fileStream5 = new FileStream(Application.StartupPath + "\\temp", FileMode.Create);
            }
            catch
            {
                var num = (int)MessageBox.Show("Something went wrong: Error 151");
            }
            try
            {
                var buffer = new byte[2097152];
                fileStream1.Position = (long)ulong_0;
                switch (_numberOfFilesInSave)
                {
                    case 1:
                        fileStream1.Read(buffer, 0, (int)fileStream1.Length - (int)ulong_0 - 1);
                        fileStream5.Write(buffer, 0, (int)fileStream1.Length - (int)ulong_0 - 1);
                        fileStream1.Close();
                        fileStream5.Close();
                        break;
                    case 2:
                        fileStream1.Read(buffer, 0, (int)fileStream1.Length - (int)ulong_0);
                        fileStream5.Write(buffer, 0, (int)fileStream1.Length - (int)ulong_0);
                        fileStream2.Read(buffer, 0, (int)fileStream2.Length - 1);
                        fileStream5.Write(buffer, 0, (int)fileStream2.Length - 1);
                        fileStream1.Close();
                        fileStream2.Close();
                        fileStream5.Close();
                        break;
                    case 3:
                        fileStream1.Read(buffer, 0, (int)fileStream1.Length - (int)ulong_0);
                        fileStream5.Write(buffer, 0, (int)fileStream1.Length - (int)ulong_0);
                        fileStream2.Read(buffer, 0, (int)fileStream2.Length);
                        fileStream5.Write(buffer, 0, (int)fileStream2.Length);
                        fileStream3.Read(buffer, 0, (int)fileStream3.Length - 1);
                        fileStream5.Write(buffer, 0, (int)fileStream3.Length - 1);
                        fileStream1.Close();
                        fileStream2.Close();
                        fileStream3.Close();
                        fileStream5.Close();
                        break;
                    case 4:
                        fileStream1.Read(buffer, 0, (int)fileStream1.Length - (int)ulong_0);
                        fileStream5.Write(buffer, 0, (int)fileStream1.Length - (int)ulong_0);
                        fileStream2.Read(buffer, 0, (int)fileStream2.Length);
                        fileStream5.Write(buffer, 0, (int)fileStream2.Length);
                        fileStream3.Read(buffer, 0, (int)fileStream3.Length);
                        fileStream5.Write(buffer, 0, (int)fileStream3.Length);
                        fileStream4.Read(buffer, 0, (int)fileStream4.Length - 1);
                        fileStream5.Write(buffer, 0, (int)fileStream4.Length - 1);
                        fileStream1.Close();
                        fileStream2.Close();
                        fileStream3.Close();
                        fileStream4.Close();
                        fileStream5.Close();
                        break;
                }
            }
            catch
            {
                var num = (int)MessageBox.Show("Something went wrong: Error 152");
            }
            try
            {
                var sqLiteConnection = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\temp");
                Thread.Sleep(50);
                sqLiteConnection.Open();
                Thread.Sleep(50);
                sqLiteConnection.ChangePassword(passBytes);
                Thread.Sleep(50);
                sqLiteConnection.Close();
            }
            catch
            {
                EncryptSave(_pathToSave);
                var num = (int)MessageBox.Show("Something went wrong: Error 100");
            }
        }

        public void CompileSingleDbIntoSave(string string_4)
        {
            var flag = false;
            FileStream fileStream1 = null;
            try
            {
                if (!_pathToGT5PointZero.Equals(string.Empty))
                {
                    Cursor = Cursors.WaitCursor;
                    var sqLiteConnection = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\temp");
                    sqLiteConnection.SetPassword(passBytes);
                    sqLiteConnection.Open();
                    sqLiteConnection.ChangePassword(string.Empty);
                    sqLiteConnection.Close();
                    Thread.Sleep(100);
                    var buffer1 = new byte[16777216];
                    var fileStream2 = new FileStream(string_4 + "\\GT5.0", FileMode.Open);
                    fileStream2.Read(buffer1, 0, (int)ulong_0);
                    fileStream2.Close();
                    fileStream1 = new FileStream(Application.StartupPath + "\\temp", FileMode.Open);
                    fileStream1.Read(buffer1, (int)ulong_0, (int)fileStream1.Length);
                    var num = 2097152;
                    var fileStream_0 = new FileStream(string_4 + "\\GT5.0", FileMode.Create);
                    fileStream_0.SetLength(1L);
                    fileStream_0.Write(buffer1, 0, (int)ulong_0);
                    WriteLongToFileStream((long)ulong_0 - 9L, fileStream_0, 0L, 4L, fileStream1.Length + 10L);
                    WriteLongToFileStream((long)ulong_0 - 4L, fileStream_0, 0L, 4L, fileStream1.Length);
                    fileStream_0.Position = (long)ulong_0;
                    if (fileStream1.Length + (long)ulong_0 > _numberOfFilesInSave * 2097152)
                        flag = true;
                    if (fileStream1.Length + (long)ulong_0 < num)
                    {
                        fileStream_0.Write(buffer1, (int)ulong_0, (int)fileStream1.Length);
                        fileStream_0.WriteByte(0);
                        fileStream_0.Close();
                    }
                    else if (fileStream1.Length + (long)ulong_0 > num && fileStream1.Length + (long)ulong_0 < 2 * num)
                    {
                        var fileStream3 = new FileStream(string_4 + "\\GT5.1", FileMode.Create);
                        fileStream3.SetLength(1L);
                        fileStream_0.Write(buffer1, (int)ulong_0, num - (int)ulong_0);
                        fileStream3.Write(buffer1, num, (int)fileStream1.Length + (int)ulong_0 - num);
                        fileStream3.WriteByte(0);
                        fileStream_0.Close();
                        fileStream3.Close();
                    }
                    else if (fileStream1.Length + (long)ulong_0 > 2 * num && fileStream1.Length + (long)ulong_0 < 3 * num)
                    {
                        var fileStream3 = new FileStream(string_4 + "\\GT5.1", FileMode.Create);
                        fileStream3.SetLength(1L);
                        var fileStream4 = new FileStream(string_4 + "\\GT5.2", FileMode.Create);
                        fileStream4.SetLength(1L);
                        fileStream_0.Write(buffer1, (int)ulong_0, num - (int)ulong_0);
                        fileStream3.Write(buffer1, num, num);
                        fileStream4.Write(buffer1, 2 * num, (int)fileStream1.Length + (int)ulong_0 - 2 * num);
                        fileStream4.WriteByte(0);
                        fileStream_0.Close();
                        fileStream3.Close();
                        fileStream4.Close();
                    }
                    else if (fileStream1.Length + (long)ulong_0 > 3 * num && fileStream1.Length + (long)ulong_0 < 4 * num)
                    {
                        var fileStream3 = new FileStream(string_4 + "\\GT5.1", FileMode.Create);
                        fileStream3.SetLength(1L);
                        var fileStream4 = new FileStream(string_4 + "\\GT5.2", FileMode.Create);
                        fileStream4.SetLength(1L);
                        var fileStream5 = new FileStream(string_4 + "\\GT5.3", FileMode.Create);
                        fileStream5.SetLength(1L);
                        fileStream_0.Write(buffer1, (int)ulong_0, num - (int)ulong_0);
                        fileStream3.Write(buffer1, num, num);
                        fileStream4.Write(buffer1, 2 * num, num);
                        fileStream5.Write(buffer1, 3 * num, (int)fileStream1.Length + (int)ulong_0 - 3 * num);
                        fileStream5.WriteByte(0);
                        fileStream_0.Close();
                        fileStream3.Close();
                        fileStream4.Close();
                        fileStream5.Close();
                    }
                    fileStream1.Close();
                    if (flag)
                    {
                        var fileStream3 = new FileStream(_pathToSave + "\\PARAM.PFD", FileMode.Open);
                        var buffer2 = new byte[272];
                        fileStream3.Position = 848L;
                        fileStream3.Read(buffer2, 0, 272);
                        fileStream3.Position = 848 + 272 * _numberOfFilesInSave;
                        fileStream3.Write(buffer2, 0, 272);
                        fileStream3.Position = 848 + 272 * _numberOfFilesInSave + 12;
                        fileStream3.WriteByte((byte)(_numberOfFilesInSave & 15U));
                        fileStream3.Close();
                        DecryptSave(_pathToSave);
                        EncryptSave(_pathToSave);
                    }
                }
            }
            catch
            {
                fileStream1.Close();
                var num = (int)MessageBox.Show("Something went wrong: Error 113");
                Cursor = Cursors.Default;
            }
            if (File.Exists(Application.StartupPath + "\\temp"))
                File.Delete(Application.StartupPath + "\\temp");
            Cursor = Cursors.Default;
        }

        public static ulong smethod_20(string string_4, string string_5)
        {
            var fileStream1 = new FileStream(string_5, FileMode.Open);
            var flag = false;
            var num1 = 0UL;
            var bytes = Encoding.ASCII.GetBytes(string_4);
            var numArray = new byte[string_4.Length];
            while (!flag && fileStream1.Position < fileStream1.Length)
            {
                if ((char)fileStream1.ReadByte() == bytes[0])
                {
                    var fileStream2 = fileStream1;
                    var num2 = fileStream2.Position - 1L;
                    fileStream2.Position = num2;
                    fileStream1.Read(numArray, 0, string_4.Length);
                    if (ByteArrayComparer.smethod_0(bytes, numArray))
                    {
                        flag = true;
                        num1 = (ulong)fileStream1.Position - (ulong)string_4.Length;
                    }
                }
            }
            fileStream1.Dispose();
            return num1;
        }

        private static void smethod_21(string string_4, string string_5, bool bool_0)
        {
            var directoryInfo1 = new DirectoryInfo(string_4);
            var directories = directoryInfo1.GetDirectories();
            if (!directoryInfo1.Exists)
                throw new DirectoryNotFoundException("Source directory does not exist or could not be found: " + string_4);
            if (!Directory.Exists(string_5))
                Directory.CreateDirectory(string_5);
            foreach (var fileInfo in directoryInfo1.GetFiles())
            {
                var destFileName = Path.Combine(string_5, fileInfo.Name);
                fileInfo.CopyTo(destFileName, false);
            }
            if (!bool_0)
                return;
            foreach (var directoryInfo2 in directories)
            {
                var string_5_1 = Path.Combine(string_5, directoryInfo2.Name);
                smethod_21(directoryInfo2.FullName, string_5_1, bool_0);
            }
        }

        private void openGarageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_pathToGT5PointZero.Equals(string.Empty))
                    return;
                var folderBrowserDialog = new FolderBrowserDialog();
                folderBrowserDialog.Description = "Select your Save Data Folder";
                if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
                    return;
                Cursor = Cursors.WaitCursor;
                Enabled = false;
                _pathToSave = folderBrowserDialog.SelectedPath;
                smethod_21(_pathToSave, Application.StartupPath + "\\BACKUP\\" + DateTime.Now.ToString().Replace('/', '-').Replace(':', ','), false);
                _pathToGT5PointZero = _pathToSave + "\\GT5.0";
                DecryptSave(_pathToSave);
                var fileStream1 = new FileStream(_pathToGT5PointZero, FileMode.Open);
                var fileStream2 = fileStream1;
                var num1 = fileStream2.Position + 3L;
                fileStream2.Position = num1;
                var num2 = (byte)fileStream1.ReadByte();
                fileStream1.Close();
                if (num2 == 249)
                {
                    smethod_12(_pathToGT5PointZero);
                    tb_creditcap.Text = smethod_18(_pathToGT5PointZero, "cash_limit", 8).ToString();
                    tb_car_avail.Text = smethod_18(_pathToGT5PointZero, "car_available", 1).ToString();
                    tb_course_avail.Text = smethod_18(_pathToGT5PointZero, "course_available", 4).ToString();
                    tb_aspec_wins.Text = smethod_18(_pathToGT5PointZero, "total_aspec_win", 4).ToString();
                    tb_bspec_wins.Text = smethod_18(_pathToGT5PointZero, "total_bspec_win", 4).ToString();
                    comboBox_gift_preset.SelectedIndex = 0;
                    textBox_used_car_day.Text = smethod_18(_pathToGT5PointZero, "used_car_visit_day", 4).ToString();
                    textBox_gamedays.Text = smethod_18(_pathToGT5PointZero, "gameday", 8).ToString();
                    textBox_Credits.Text = smethod_18(_pathToGT5PointZero, "cash", 8).ToString();
                    comboBox_spec_LeveLA.SelectedIndex = (int)smethod_18(_pathToGT5PointZero, "aspec_lv", 4);
                    comboBox_spec_LevelB.SelectedIndex = (int)smethod_18(_pathToGT5PointZero, "bspec_lv", 4);
                    radioButton_secretOff.Checked = true;
                    rb_textdebug_off.Checked = true;
                    if ((long)smethod_18(_pathToGT5PointZero, "open_special_option", 1) == 1L)
                        radioButton_secretOn.Checked = true;
                    if ((long)smethod_18(_pathToGT5PointZero, "rtext_debug", 1) == 1L)
                        rb_txtdebug_on.Checked = true;
                    ulong_0 = smethod_20("SQLite format 3", _pathToGT5PointZero);
                    CompileSaveIntoSingleDb(_pathToSave);
                    _sqlHelper2 = new SqlHelper(Application.StartupPath + "\\temp", true, passBytes);
                    GetTuners(_sqlHelper2, ref dataTable_6);
                    PopulateComboBoxFromDatatable(ref comboBox_DMake, ref dataTable_6);
                    Cursor = Cursors.Default;
                    if (comboBox_DMake.Items.Count > 0)
                        tabControl_garage.Enabled = true;
                    Enabled = true;
                    comboBox_SMake.SelectedIndex = 0;
                }
                else
                {
                    var num3 = (int)MessageBox.Show(this, "File is Corrupted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    Application.Exit();
                }
            }
            catch
            {
                var num = (int)MessageBox.Show(this, "An Error Occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void closeGarageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CompileSingleDbIntoSave(_pathToSave);
                EncryptSave(_pathToSave);
                Application.Exit();
            }
            catch
            {
            }
        }

        private void Form_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing)
                return;
            EncryptSave(_pathToSave);
        }

        private void button_Credits_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsNumeric(textBox_Credits.Text) && ulong.Parse(textBox_Credits.Text) < ulong.MaxValue)
                {
                    smethod_19(_pathToGT5PointZero, "cash", 8, ulong.Parse(textBox_Credits.Text));
                    var num = (int)MessageBox.Show("Credits Updated Successfully!");
                }
                else
                {
                    var num1 = (int)MessageBox.Show("Bad Input!");
                }
            }
            catch
            {
                var num = (int)MessageBox.Show("Something went wrong: Error 701");
            }
        }

        private void button_ASpec_Click(object sender, EventArgs e)
        {
            try
            {
                smethod_19(_pathToGT5PointZero, "aspec_point", 8, ulong.Parse(Utilities.PlayerExperienceByRank[comboBox_spec_LeveLA.SelectedIndex]));
                smethod_19(_pathToGT5PointZero, "aspec_lv", 4, (ulong)comboBox_spec_LeveLA.SelectedIndex);
                var num = (int)MessageBox.Show("Applied Successfully");
            }
            catch
            {
                var num = (int)MessageBox.Show("Something went wrong: Error 704");
            }
        }

        private void button_BSpec_Click(object sender, EventArgs e)
        {
            try
            {
                smethod_19(_pathToGT5PointZero, "bspec_point", 8, ulong.Parse(Utilities.PlayerExperienceByRank[comboBox_spec_LevelB.SelectedIndex]));
                smethod_19(_pathToGT5PointZero, "bspec_lv", 4, (ulong)comboBox_spec_LevelB.SelectedIndex);
                var num = (int)MessageBox.Show("Applied Successfully");
            }
            catch
            {
                var num = (int)MessageBox.Show("Something went wrong: Error 704");
            }
        }

        private void button_secret_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton_secretOn.Checked)
                    smethod_19(_pathToGT5PointZero, "open_special_option", 1, 1UL);
                else
                    smethod_19(_pathToGT5PointZero, "open_special_option", 1, 0UL);
                var num = (int)MessageBox.Show("Applied Successfully");
            }
            catch
            {
                var num = (int)MessageBox.Show("Something went wrong: Error 704");
            }
        }

        private void button_apply_gamedays_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsNumeric(textBox_gamedays.Text) && ulong.Parse(textBox_gamedays.Text) < ulong.MaxValue)
                {
                    smethod_19(_pathToGT5PointZero, "gameday", 8, ulong.Parse(textBox_gamedays.Text));
                    var num = (int)MessageBox.Show("Gameday Updated Successfully!");
                }
                else
                {
                    var num1 = (int)MessageBox.Show("Bad Input!");
                }
            }
            catch
            {
                var num = (int)MessageBox.Show("Something went wrong: Error 721");
            }
        }

        private void button_apply_used_car_day_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsNumeric(textBox_used_car_day.Text) && ulong.Parse(textBox_used_car_day.Text) < uint.MaxValue)
                {
                    smethod_19(_pathToGT5PointZero, "used_car_visit_day", 4, ulong.Parse(textBox_used_car_day.Text));
                    var num = (int)MessageBox.Show("Used Car Visit Day Updated Successfully!");
                }
                else
                {
                    var num1 = (int)MessageBox.Show("Bad Input!");
                }
            }
            catch
            {
                var num = (int)MessageBox.Show("Something went wrong: Error 731");
            }
        }

        private void bt_course_avail_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsNumeric(tb_course_avail.Text) && ulong.Parse(tb_course_avail.Text) <= uint.MaxValue)
                {
                    smethod_19(_pathToGT5PointZero, "course_available", 4, ulong.Parse(tb_course_avail.Text));
                    var num = (int)MessageBox.Show("Updated Successfully!");
                }
                else
                {
                    var num1 = (int)MessageBox.Show("Bad Input!");
                }
            }
            catch
            {
                var num = (int)MessageBox.Show("Something went wrong: Error 745");
            }
        }

        private void button_car_avail_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsNumeric(tb_car_avail.Text) && ulong.Parse(tb_car_avail.Text) <= byte.MaxValue)
                {
                    smethod_19(_pathToGT5PointZero, "car_available", 1, ulong.Parse(tb_car_avail.Text));
                    var num = (int)MessageBox.Show("Updated Successfully!");
                }
                else
                {
                    var num1 = (int)MessageBox.Show("Bad Input!");
                }
            }
            catch
            {
                var num = (int)MessageBox.Show("Something went wrong: Error 743");
            }
        }

        private void btn_creditcap_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsNumeric(tb_creditcap.Text) && ulong.Parse(tb_creditcap.Text) <= 999999999999999999UL)
                {
                    smethod_19(_pathToGT5PointZero, "cash_limit", 8, ulong.Parse(tb_creditcap.Text));
                    var num = (int)MessageBox.Show("Credit Cap Updated Successfully!");
                }
                else
                {
                    var num1 = (int)MessageBox.Show("Bad Input!");
                }
            }
            catch
            {
                var num = (int)MessageBox.Show("Something went wrong: Error 742");
            }
        }

        private void btn_aspecwins_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsNumeric(tb_aspec_wins.Text) && ulong.Parse(tb_aspec_wins.Text) <= uint.MaxValue)
                {
                    smethod_19(_pathToGT5PointZero, "total_aspec_win", 4, ulong.Parse(tb_aspec_wins.Text));
                    var num = (int)MessageBox.Show("Updated Successfully!");
                }
                else
                {
                    var num1 = (int)MessageBox.Show("Bad Input!");
                }
            }
            catch
            {
                var num = (int)MessageBox.Show("Something went wrong: Error 755");
            }
        }

        private void btn_bspecwins_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsNumeric(tb_bspec_wins.Text) && ulong.Parse(tb_bspec_wins.Text) <= uint.MaxValue)
                {
                    smethod_19(_pathToGT5PointZero, "total_bspec_win", 4, ulong.Parse(tb_bspec_wins.Text));
                    var num = (int)MessageBox.Show("Updated Successfully!");
                }
                else
                {
                    var num1 = (int)MessageBox.Show("Bad Input!");
                }
            }
            catch
            {
                var num = (int)MessageBox.Show("Something went wrong: Error 756");
            }
        }

        private void btn_text_debug_Click(object sender, EventArgs e)
        {
            try
            {
                if (rb_txtdebug_on.Checked)
                    smethod_19(_pathToGT5PointZero, "rtext_debug", 1, 1UL);
                else
                    smethod_19(_pathToGT5PointZero, "rtext_debug", 1, 0UL);
                var num = (int)MessageBox.Show("Applied Successfully");
            }
            catch
            {
                var num = (int)MessageBox.Show("Something went wrong: Error 704");
            }
        }

        private void button_func_conf_Click(object sender, EventArgs e)
        {
            try
            {
                var num1 = 0U;
                var num2 = 0U;
                var num3 = Convert.ToUInt32(tb_func_withvalue.Text, 16);
                string key1;
                if ((key1 = comboBox_func_edit.SelectedItem.ToString()) != null)
                {
                    if (Dictionaries.dictionary_3 == null)
                    {
                        var dictionary = new Dictionary<string, int>(46);
                        var key2 = "Odometer";
                        var num4 = 0;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key2, num4);
                        var key3 = "Oil";
                        var num5 = 1;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key3, num5);
                        var key4 = "Paint";
                        var num6 = 2;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key4, num6);
                        var key5 = "Body";
                        var num7 = 3;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key5, num7);
                        var key6 = "Colour";
                        var num8 = 4;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key6, num8);
                        var key7 = "Brakes";
                        var num9 = 5;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key7, num9);
                        var key8 = "_198_201";
                        var num10 = 6;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key8, num10);
                        var key9 = "Chassis";
                        var num11 = 7;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key9, num11);
                        var key10 = "Engine";
                        var num12 = 8;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key10, num12);
                        var key11 = "Drivetrain";
                        var num13 = 9;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key11, num13);
                        var key12 = "Transmission";
                        var num14 = 10;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key12, num14);
                        var key13 = "Suspension";
                        var num15 = 11;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key13, num15);
                        var key14 = "LSD";
                        var num16 = 12;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key14, num16);
                        var key15 = "_226_229";
                        var num17 = 13;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key15, num17);
                        var key16 = "WReduction";
                        var num18 = 14;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key16, num18);
                        var key17 = "_234_237";
                        var num19 = 15;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key17, num19);
                        var key18 = "_238_241";
                        var num20 = 16;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key18, num20);
                        var key19 = "ECU";
                        var num21 = 17;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key19, num21);
                        var key20 = "Engine Tune";
                        var num22 = 18;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key20, num22);
                        var key21 = "Turbo ";
                        var num23 = 19;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key21, num23);
                        var key22 = "Flywheel";
                        var num24 = 20;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key22, num24);
                        var key23 = "Clutch";
                        var num25 = 21;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key23, num25);
                        var key24 = "Driveshaft";
                        var num26 = 22;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key24, num26);
                        var key25 = "Exhaust";
                        var num27 = 23;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key25, num27);
                        var key26 = "_270_273";
                        var num28 = 24;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key26, num28);
                        var key27 = "ASM Controller";
                        var num29 = 25;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key27, num29);
                        var key28 = "TCS Controller";
                        var num30 = 26;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key28, num30);
                        var key29 = "_282_285";
                        var num31 = 27;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key29, num31);
                        var key30 = "Supercharger";
                        var num32 = 28;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key30, num32);
                        var key31 = "Intake Manifold";
                        var num33 = 29;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key31, num33);
                        var key32 = "Exhaust Manifold";
                        var num34 = 30;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key32, num34);
                        var key33 = "Catalytic Converter";
                        var num35 = 31;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key33, num35);
                        var key34 = "Air Filter";
                        var num36 = 32;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key34, num36);
                        var key35 = "_306_309";
                        var num37 = 33;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key35, num37);
                        var key36 = "WindowWR";
                        var num38 = 34;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key36, num38);
                        var key37 = "Hood";
                        var num39 = 35;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key37, num39);
                        var key38 = "FrBumper";
                        var num40 = 36;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key38, num40);
                        var key39 = "RrBumper";
                        var num41 = 37;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key39, num41);
                        var key40 = "Extension";
                        var num42 = 38;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key40, num42);
                        var key41 = "Wing";
                        var num43 = 39;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key41, num43);
                        var key42 = "_334_337";
                        var num44 = 40;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key42, num44);
                        var key43 = "Reinforcement";
                        var num45 = 41;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key43, num45);
                        var key44 = "NoS";
                        var num46 = 42;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key44, num46);
                        var key45 = "BHP";
                        var num47 = 43;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key45, num47);
                        var key46 = "Grip";
                        var num48 = 44;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key46, num48);
                        var key47 = "Weight";
                        var num49 = 45;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key47, num49);
                        Dictionaries.dictionary_3 = dictionary;
                    }
                    int num50;
                    // ISSUE: explicit non-virtual call
                    if ((Dictionaries.dictionary_3.TryGetValue(key1, out num50)))
                    {
                        switch (num50)
                        {
                            case 0:
                                num1 = 37U;
                                num2 = 4U;
                                break;
                            case 1:
                                num1 = 49U;
                                num2 = 4U;
                                break;
                            case 2:
                                num1 = 77U;
                                num2 = 4U;
                                break;
                            case 3:
                                num1 = 157U;
                                num2 = 4U;
                                break;
                            case 4:
                                num1 = 169U;
                                num2 = 1U;
                                break;
                            case 5:
                                num1 = 194U;
                                num2 = 4U;
                                break;
                            case 6:
                                num1 = 198U;
                                num2 = 4U;
                                break;
                            case 7:
                                num1 = 202U;
                                num2 = 4U;
                                break;
                            case 8:
                                num1 = 206U;
                                num2 = 4U;
                                break;
                            case 9:
                                num1 = 210U;
                                num2 = 4U;
                                break;
                            case 10:
                                num1 = 214U;
                                num2 = 4U;
                                break;
                            case 11:
                                num1 = 218U;
                                num2 = 4U;
                                break;
                            case 12:
                                num1 = 222U;
                                num2 = 4U;
                                break;
                            case 13:
                                num1 = 226U;
                                num2 = 4U;
                                break;
                            case 14:
                                num1 = 230U;
                                num2 = 4U;
                                break;
                            case 15:
                                num1 = 234U;
                                num2 = 4U;
                                break;
                            case 16:
                                num1 = 238U;
                                num2 = 4U;
                                break;
                            case 17:
                                num1 = 242U;
                                num2 = 4U;
                                break;
                            case 18:
                                num1 = 246U;
                                num2 = 4U;
                                break;
                            case 19:
                                num1 = 250U;
                                num2 = 4U;
                                break;
                            case 20:
                                num1 = 254U;
                                num2 = 4U;
                                break;
                            case 21:
                                num1 = 258U;
                                num2 = 4U;
                                break;
                            case 22:
                                num1 = 262U;
                                num2 = 4U;
                                break;
                            case 23:
                                num1 = 266U;
                                num2 = 4U;
                                break;
                            case 24:
                                num1 = 270U;
                                num2 = 4U;
                                break;
                            case 25:
                                num1 = 274U;
                                num2 = 4U;
                                break;
                            case 26:
                                num1 = 278U;
                                num2 = 4U;
                                break;
                            case 27:
                                num1 = 282U;
                                num2 = 4U;
                                break;
                            case 28:
                                num1 = 286U;
                                num2 = 4U;
                                break;
                            case 29:
                                num1 = 290U;
                                num2 = 4U;
                                break;
                            case 30:
                                num1 = 294U;
                                num2 = 4U;
                                break;
                            case 31:
                                num1 = 298U;
                                num2 = 4U;
                                break;
                            case 32:
                                num1 = 302U;
                                num2 = 4U;
                                break;
                            case 33:
                                num1 = 306U;
                                num2 = 4U;
                                break;
                            case 34:
                                num1 = 310U;
                                num2 = 4U;
                                break;
                            case 35:
                                num1 = 314U;
                                num2 = 4U;
                                break;
                            case 36:
                                num1 = 318U;
                                num2 = 4U;
                                break;
                            case 37:
                                num1 = 322U;
                                num2 = 4U;
                                break;
                            case 38:
                                num1 = 326U;
                                num2 = 4U;
                                break;
                            case 39:
                                num1 = 330U;
                                num2 = 4U;
                                break;
                            case 40:
                                num1 = 334U;
                                num2 = 4U;
                                break;
                            case 41:
                                num1 = 338U;
                                num2 = 4U;
                                break;
                            case 42:
                                num1 = 342U;
                                num2 = 4U;
                                break;
                            case 43:
                                num1 = 422U;
                                num2 = 1U;
                                break;
                            case 44:
                                num1 = 431U;
                                num2 = 1U;
                                break;
                            case 45:
                                num1 = 425U;
                                num2 = 1U;
                                break;
                        }
                    }
                }
                var num51 = 0U;
                if (cb_a.Checked)
                    num51 |= 1U;
                if (cb_b.Checked)
                    num51 |= 2U;
                if (cb_c.Checked)
                    num51 |= 4U;
                if (IsAlphaNumeric(tb_func_withvalue.Text) && tb_func_withvalue.Text.Length <= 8)
                {
                    var strArray = new string[5]
                    {
                        num1.ToString(),
                        num2.ToString(),
                        num3.ToString(),
                        num51.ToString(),
                        comboBox_func_make.Items[comboBox_func_make.SelectedIndex].ToString()
                    };
                    if (num51 > 0U)
                    {
                        Enabled = false;
                        backgroundWorker_0.RunWorkerAsync(strArray);
                    }
                    else
                    {
                        var num4 = (int)MessageBox.Show(this, "No Sheet Selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    var num52 = (int)MessageBox.Show(this, "Bad Input, Enter a Hex String of Length 8 as a value.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                Enabled = true;
                var num = (int)MessageBox.Show("Something went wrong: Error 303");
            }
        }

        private void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                var stringBuilder1 = new StringBuilder();
                var stringBuilder2 = new StringBuilder();
                var strArray = (string[])e.Argument;
                var numArray1 = new uint[4]
                {
                    uint.Parse(strArray[0]),
                    uint.Parse(strArray[1]),
                    Convert.ToUInt32(strArray[2]),
                    uint.Parse(strArray[3])
                };
                var num1 = 1;
                var numArray2 = new byte[679];
                var numArray3 = new byte[679];
                var numArray4 = new byte[679];
                stringBuilder2.Append("SELECT garage_id, carparameter, carparameterB, carparameterC FROM t_garage ");
                if (!strArray[4].Equals("ALL CARS"))
                    stringBuilder2.Append(" WHERE tuner_label LIKE '" + strArray[4] + "'");
                var dataTable = _sqlHelper2.ExecuteReader(stringBuilder2.ToString());
                var connection = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\temp");
                connection.SetPassword(passBytes);
                connection.Open();
                foreach (DataRow dataRow in (InternalDataCollectionBase)dataTable.Rows)
                {
                    var flag = false;
                    var num2 = uint.Parse(dataRow["garage_id"].ToString());
                    var sqLiteCommand = new SQLiteCommand(connection);
                    stringBuilder1.Remove(0, stringBuilder1.Length);
                    stringBuilder1.Append("UPDATE t_garage SET ");
                    if (((int)numArray1[3] & 1) == 1)
                    {
                        var byte_3 = (byte[])dataRow["carparameter"];
                        InsertUIntToByteArray(byte_3, numArray1[0], numArray1[1], numArray1[2]);
                        var parameter = new SQLiteParameter("@blobA", DbType.Binary);
                        parameter.Value = byte_3;
                        sqLiteCommand.Parameters.Add(parameter);
                        stringBuilder1.Append(" carparameter = @blobA ");
                        flag = true;
                    }
                    if (((int)numArray1[3] & 2) == 2)
                    {
                        var byte_3 = (byte[])dataRow["carparameterB"];
                        InsertUIntToByteArray(byte_3, numArray1[0], numArray1[1], numArray1[2]);
                        var parameter = new SQLiteParameter("@blobB", DbType.Binary);
                        parameter.Value = byte_3;
                        sqLiteCommand.Parameters.Add(parameter);
                        if (flag)
                            stringBuilder1.Append(',');
                        stringBuilder1.Append(" carparameterB = @blobB ");
                        flag = true;
                    }
                    if (((int)numArray1[3] & 4) == 4)
                    {
                        var byte_3 = (byte[])dataRow["carparameterC"];
                        InsertUIntToByteArray(byte_3, numArray1[0], numArray1[1], numArray1[2]);
                        var parameter = new SQLiteParameter("@blobC", DbType.Binary);
                        parameter.Value = byte_3;
                        sqLiteCommand.Parameters.Add(parameter);
                        if (flag)
                            stringBuilder1.Append(',');
                        stringBuilder1.Append(" carparameterC = @blobC ");
                    }
                    stringBuilder1.Append("WHERE garage_id = " + num2);
                    sqLiteCommand.CommandText = stringBuilder1.ToString();
                    sqLiteCommand.ExecuteNonQuery();
                    backgroundWorker_0.ReportProgress(num1++);
                }
                connection.Close();
            }
            catch
            {
                var num = (int)MessageBox.Show("Something went wrong: Error 301");
            }
            backgroundWorker_0.ReportProgress(-1);
        }

        private void backgroundWorker_0_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage > 0)
                listBox_func_basic.Items.Add("Car Write : " + e.ProgressPercentage + " Successful");
            else if (e.ProgressPercentage == -1)
            {
                listBox_func_basic.Items.Add("Batch Write Complete");
                Enabled = true;
            }
            listBox_func_basic.SelectedIndex = listBox_func_basic.Items.Count - 1;
        }

        private void btn_name_change_Click(object sender, EventArgs e)
        {
            try
            {
                var num1 = int.Parse(dataTable_9.Rows[cB_Name_Model.SelectedIndex].ItemArray[1].ToString());
                var connection = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\temp");
                connection.SetPassword(passBytes);
                connection.Open();
                var sqLiteCommand = new SQLiteCommand(connection);
                sqLiteCommand.CommandText = string.Concat(new object[4]
                {
                    "UPDATE t_garage SET name_EN = '",
                    tB_Name_New.Text.Replace("'", "''"),
                    "' WHERE garage_id = ",
                    num1
                });
                sqLiteCommand.ExecuteNonQuery();
                connection.Close();
                var num2 = (int)MessageBox.Show("Name Change was Successful!");
                cB_Name_Make.SelectedIndex = 1;
                cB_Name_Make.SelectedIndex = 0;
                tB_Name_New.Text = string.Empty;
            }
            catch
            {
                var num = (int)MessageBox.Show("Something went wrong: Error 101");
            }
        }

        private void button_gift_preset_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBox_gift_preset.Items[comboBox_gift_preset.SelectedIndex].ToString())
                {
                    case "Recieve All Presents":
                        _sqlHelper2.ExecuteNonQuery("UPDATE t_event_present SET get_flag = 0");
                        break;
                    case "All Gold A Spec":
                        _sqlHelper2.ExecuteNonQuery("UPDATE t_aspec_race SET result = 0");
                        break;
                    case "All Gold B Spec":
                        _sqlHelper2.ExecuteNonQuery("UPDATE t_bspec_race SET result = 0");
                        break;
                    case "All Gold Licences":
                        _sqlHelper2.ExecuteNonQuery("UPDATE t_license SET result = 0");
                        break;
                    case "All Gold Special Events":
                        _sqlHelper2.ExecuteNonQuery("UPDATE t_special_event SET result = 0");
                        break;
                }
                var num = (int)MessageBox.Show(this, "Completed Successfuly", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch
            {
                var num = (int)MessageBox.Show("Something went wrong: Error 401");
            }
        }

        private void button_gift_tune_add_Click(object sender, EventArgs e)
        {
            method_14(sender, e);
            var num = (int)MessageBox.Show(this, "Finished Adding Items  ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        public void method_14(object sender, EventArgs e)
        {
            try
            {
                var num1 = ulong.Parse(_sqlHelper2.ExecuteScalar("SELECT MAX (itembox_id) FROM t_itembox_user"));
                var num2 = (uint)(comboBox_gameitem_id.SelectedIndex + 1);
                string key1;
                uint num3;
                if ((key1 = comboBox_category_name.Items[comboBox_category_name.SelectedIndex].ToString()) != null)
                {
                    if (Dictionaries.dictionary_4 == null)
                    {
                        var dictionary = new Dictionary<string, int>(14);
                        var key2 = "Body/Chassis";
                        var num4 = 0;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key2, num4);
                        var key3 = "Engine";
                        var num5 = 1;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key3, num5);
                        var key4 = "Intake/Exhaust";
                        var num6 = 2;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key4, num6);
                        var key5 = "Turbo Kit";
                        var num7 = 3;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key5, num7);
                        var key6 = "Transmission";
                        var num8 = 4;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key6, num8);
                        var key7 = "Drivetrain";
                        var num9 = 5;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key7, num9);
                        var key8 = "Suspension";
                        var num10 = 6;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key8, num10);
                        var key9 = "Brakes";
                        var num11 = 7;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key9, num11);
                        var key10 = "Comfort Tires";
                        var num12 = 8;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key10, num12);
                        var key11 = "Sports Tires";
                        var num13 = 9;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key11, num13);
                        var key12 = "Racing Tires";
                        var num14 = 10;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key12, num14);
                        var key13 = "Special Tires";
                        var num15 = 11;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key13, num15);
                        var key14 = "Others";
                        var num16 = 12;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key14, num16);
                        var key15 = "Horns";
                        var num17 = 13;
                        // ISSUE: explicit non-virtual call
                        dictionary.Add(key15, num17);
                        Dictionaries.dictionary_4 = dictionary;
                    }
                    int num18;
                    // ISSUE: explicit non-virtual call
                    if ((Dictionaries.dictionary_4.TryGetValue(key1, out num18)))
                    {
                        switch (num18)
                        {
                            case 0:
                                num3 = 511U;
                                goto label_20;
                            case 1:
                                num3 = 521U;
                                goto label_20;
                            case 2:
                                num3 = 531U;
                                goto label_20;
                            case 3:
                                num3 = 541U;
                                goto label_20;
                            case 4:
                                num3 = 551U;
                                goto label_20;
                            case 5:
                                num3 = 556U;
                                goto label_20;
                            case 6:
                                num3 = 561U;
                                goto label_20;
                            case 7:
                                num3 = 571U;
                                goto label_20;
                            case 8:
                                num3 = 581U;
                                goto label_20;
                            case 9:
                                num3 = 582U;
                                goto label_20;
                            case 10:
                                num3 = 583U;
                                goto label_20;
                            case 11:
                                num3 = 586U;
                                goto label_20;
                            case 12:
                                num3 = 591U;
                                goto label_20;
                            case 13:
                                num3 = 596U;
                                goto label_20;
                        }
                    }
                }
                num3 = 0U;
                label_20:
                var connection = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\temp");
                connection.SetPassword(passBytes);
                connection.Open();
                var sqLiteCommand = new SQLiteCommand(connection);
                sqLiteCommand.CommandText = "INSERT INTO t_itembox_user VALUES (" + (ulong)((long)num1 + 1L) + ",212157493902,1,1,5," + (string)(object)num3 + "," + (string)(object)num2 + ",0,'Inserted :" + (string)(object)num2 + "',null ,null ,null ,null ,null ,1,null,null,null,null,null ,null )";
                sqLiteCommand.ExecuteNonQuery();
                connection.Close();
            }
            catch
            {
                var num = (int)MessageBox.Show("Something went wrong: Error 402");
            }
        }

        private void button_gift_paintAdd_Click(object sender, EventArgs e)
        {
            method_15(sender, e);
            var num = (int)MessageBox.Show(this, "Finished Adding Items  ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        public void method_15(object sender, EventArgs e)
        {
            try
            {
                var num1 = ulong.Parse(_sqlHelper2.ExecuteScalar("SELECT MAX (itembox_id) FROM t_itembox_user"));
                var num2 = uint.Parse(dataTable_2.Rows[comboBox_gift_paintNum.SelectedIndex].ItemArray[0].ToString());
                var num3 = (uint)comboBox__gift_paintCat.SelectedIndex;
                var connection = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\temp");
                connection.SetPassword(passBytes);
                connection.Open();
                var sqLiteCommand = new SQLiteCommand(connection);
                sqLiteCommand.CommandText = "INSERT INTO t_itembox_user VALUES (" + (ulong)((long)num1 + 1L) + ",212157493902,1,1,6,601,101,0,'none',null ,null ,null ,null ,null ," + (string)(object)num2 + "," + (string)(object)num3 + ",0 ,0,'',null , 1 )";
                sqLiteCommand.ExecuteNonQuery();
                connection.Close();
            }
            catch
            {
                var num = (int)MessageBox.Show("Something went wrong: Error 412");
            }
        }

        private void button_carTicket_Click(object sender, EventArgs e)
        {
            method_16(sender, e);
            method_17();
            var num = (int)MessageBox.Show(this, "Finished Adding Items  ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        public void method_16(object sender, EventArgs e)
        {
            try
            {
                var num1 = ulong.Parse(_sqlHelper2.ExecuteScalar("SELECT MAX (itembox_id) FROM t_itembox_user"));
                var num2 = (uint)(comboBox_tickets.SelectedIndex + 114);
                var connection = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\temp");
                connection.SetPassword(passBytes);
                connection.Open();
                var sqLiteCommand = new SQLiteCommand(connection);
                sqLiteCommand.CommandText = "INSERT INTO t_itembox_user VALUES (" + (ulong)((long)num1 + 1L) + ",112111413102,1,1,9,901," + (string)(object)num2 + ",0,'" + comboBox_tickets.SelectedItem + "',null ,null ,null ,null ,null ,1,0,0,0,'',null,1)";
                sqLiteCommand.ExecuteNonQuery();
                connection.Close();
            }
            catch
            {
                var num = (int)MessageBox.Show("Something went wrong: Error 414");
            }
        }

        private void cB_insert_tuner_SelectedIndexChanged(object sender, EventArgs e)
        {
            cB_insert_model.Items.Clear();
            dataTable_1 = _sqlHelper.ExecuteReader("SELECT name_EN, max_dealer_colour,ticket_name FROM t_cars WHERE tuner = '" + cB_insert_tuner.SelectedItem + "'");
            foreach (DataRow dataRow in (InternalDataCollectionBase)dataTable_1.Rows)
                cB_insert_model.Items.Add(dataRow.ItemArray[0].ToString());
            cB_insert_model.SelectedIndex = 0;
        }

        private void cB_insert_model_SelectedIndexChanged(object sender, EventArgs e)
        {
            var stringBuilder = new StringBuilder("http://eu.gran-turismo.com/common/images/gt5/car/thumbnail/");
            var str = StringToMd5Hash(dataTable_1.Rows[cB_insert_model.SelectedIndex].ItemArray[2].ToString());
            stringBuilder.Append(str);
            stringBuilder.Append(".png");
            if (Settings.Default.FetchThumbs)
                pictureBox_thumb.LoadAsync(stringBuilder.ToString().ToLower());
            cB_insert_colour.Items.Clear();
            var num = int.Parse(dataTable_1.Rows[cB_insert_model.SelectedIndex].ItemArray[1].ToString());
            for (var index = 0; index <= num; ++index)
                cB_insert_colour.Items.Add(index);
            cB_insert_colour.SelectedIndex = 0;
        }

        private void btn_Insert_Car_Ticket_Click(object sender, EventArgs e)
        {
            try
            {
                var num1 = ulong.Parse(_sqlHelper2.ExecuteScalar("SELECT MAX (itembox_id) FROM t_itembox_user"));
                var selectedIndex = comboBox_tickets.SelectedIndex;
                var connection = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\temp");
                connection.SetPassword(passBytes);
                connection.Open();
                var sqLiteCommand = new SQLiteCommand(connection);
                var parameter = new SQLiteParameter("@X30", DbType.Binary);
                var numArray = new byte[1]
                {
                    48
                };
                parameter.Value = numArray;
                sqLiteCommand.Parameters.Add(parameter);
                sqLiteCommand.CommandText = "INSERT INTO t_itembox_user VALUES (" + (ulong)((long)num1 + 1L) + ",112111413102,1,1,9,901,266,0,'" + cB_insert_model.SelectedItem.ToString().Replace("'", "''") + "',null ,null ,null ,null ,null ," + (string)(object)cB_insert_colour.SelectedIndex + ",0,0,266,'" + dataTable_1.Rows[cB_insert_model.SelectedIndex].ItemArray[2] + "',@X30,1)";
                sqLiteCommand.ExecuteNonQuery();
                connection.Close();
                var num2 = (int)MessageBox.Show(this, "Successfully Added Car Ticket ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                method_17();
            }
            catch
            {
                var num = (int)MessageBox.Show("Something went wrong: Error 414");
            }
        }

        private void btn_gift_paintBy10_Click(object sender, EventArgs e)
        {
            for (var index = 0; index < 10; ++index)
                method_15(sender, e);
            var num = (int)MessageBox.Show(this, "Finished Adding Ten Items  ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btn_gift_tune_give10_Click(object sender, EventArgs e)
        {
            for (var index = 0; index < 10; ++index)
                method_14(sender, e);
            var num = (int)MessageBox.Show(this, "Finished Adding Ten Items  ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btn_Year_tickets_give10_Click(object sender, EventArgs e)
        {
            for (var index = 0; index < 10; ++index)
                method_16(sender, e);
            method_17();
            var num = (int)MessageBox.Show(this, "Finished Adding Ten Items  ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void cB_Name_Make_SelectedIndexChanged(object sender, EventArgs e)
        {
            cB_Name_Model.Items.Clear();
            GetCarsByManufacturer(_sqlHelper2, ref dataTable_9, ref cB_Name_Make);
            PopulateComboBoxFromDatatable(ref cB_Name_Model, ref dataTable_9);
            cB_Name_Model.SelectedIndex = 0;
        }

        private void btn_special_insert_Click(object sender, EventArgs e)
        {
            var string_4_1 = "0E000002990A09000000020700030000006E070106000002800000006E0000003C0001FF00000000000000000000000000000000000000000000000000FFFFFFFF00000000000000000002010003FFFFFF0001000042410148000100440081DF0D000000F0BB010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001040140000000000000070CFFFFFFFFFFFFFFFF000000000000000000000000270033000300000027003400030000112F000004A500000C5000000BD300000D5B00001DBF000020940000225B0000000AFFFFFFFF00000C37FFFFFFFFFFFFFFFFFFFFFFFF0000091DFFFFFFFF00000CB8FFFFFFFFFFFFFFFFFFFFFFFF0000002C0000000E0000070CFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF0B540C130809058E03E802E401F4000000000000000000000D5C000D5C0001010000000000000000000000960096001436314B4B010101010101010101010007001E000F0615150B0B00002800000064000001000064050501000000006403E80000EA8E000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000020776657273696F6E0464617461";
            var string_4_2 = "0E000002990A09000000020700030000006E070106000002800000006E0000003C0001FF00000000960000009643160000000000960033000000000000FFFFFFFF00000000000000000002010003FFFFFF0001000082500108020100600082DF0D000000F0BB01000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000104014000000000000006D1FFFFFFFFFFFFFFFF00000000000000000000000027003C000700000027003D0007000010F6000004A600000C1500000B9900000D1900001D5A00002011000022090000000DFFFFFFFF00000BFCFFFFFFFFFFFFFFFFFFFFFFFF00001530FFFFFFFF00000CB9FFFFFFFF000014E8FFFFFFFF0000002C00000010000006D1FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF19F41CA911D70C71091206EA0583049700000000000000000C6C310C6C0006063F5714AA78000000140A00320032CE32AEAF43430808080808080808070700070023000F0615150B0B00001E00000064000001000064050501000000006403E800000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000020776657273696F6E0464617461";
            var string_4_3 = "0E000002990A09000000020700030000006E070106000002800000006E0000003C0001FF00000000000000000000000000000000000000000000000000FFFFFFFF00000000000000000002010003FFFFFF0001000082500108020100600082DF0D000000F0BB010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001040140000000000000070BFFFFFFFFFFFFFFFF00000000000000000000000027003C000700000027003D00070000112E000004A600000C4F00000BD200000D5A00001DBE000020930000225A00000011FFFFFFFF00000C36FFFFFFFFFFFFFFFFFFFFFFFF0000158BFFFFFFFF00000CB9FFFFFFFF00001547FFFFFFFF0000002C000000100000070BFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF0E1F0F4C0A9807E4061A04E60415038800000000000000000DE8200DE80006063752044B78000000140A00320032CE32AEAF43430808080808080808070700070023000F0615150B0B00001E00000064000001000064050501000000006403E800000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000020776657273696F6E0464617461";
            var string_4_4 = "0E000002990A09000000020700030000006E070106000002800000006E0000003C0001FF00000000000000000000000000000000000000000000000000FFFFFFFF00000000000000000002010003FFFFFF0001000082500108020100600082DF0D000000F0BB010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001040140000000000000070FFFFFFFFFFFFFFFFF00000000000000000000000027003C000700000027003D000700001132000004A600000C5300000BD600000D5E00001DC2000020970000225E0000000DFFFFFFFF00000C3AFFFFFFFFFFFFFFFFFFFFFFFF0000158DFFFFFFFF00000CB9FFFFFFFF00001548FFFFFFFF0000002C000000100000070FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF19F41CA911D70C71091206EA0583049700000000000000000C6C310C6C0006063F5714AA78000000140A00320032CE32AEAF43430808080808080808070700070023000F0615150B0B00001E00000064000001000064050501000000006403E800000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000020776657273696F6E0464617461";
            var string_4_5 = "0E000002990A09000000020700030000006E070106000002800000006E0000003C0001FF00000000000000000000000000000000000000000000000000FFFFFFFF00000000000000000002010003FFFFFF0001000082500108020100600082DF0D000000F0BB0100000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000010401400000000000000710FFFFFFFFFFFFFFFF01000000000000000000000027003C000700000027003D000700001133000004A600000C5400000BD700000D5F00001DC3000020980000225F00000012FFFFFFFF00000C3BFFFFFFFFFFFFFFFFFFFFFFFF0000158EFFFFFFFF00000CB9FFFFFFFF00001549FFFFFFFF0000002C0000001000000710FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF0E1F0F4C0A9807E4061A04E60415038800000000000000000DE8200DE80006063752044B78000000140A00320032CE32AEAF43430808080808080808070700070023000F0615150B0B00001E00000064000001000064050501000000006403E800000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000020776657273696F6E0464617461";
            var byte_3 = new byte[679];
            try
            {
                var ulong_1 = ulong.Parse(_sqlHelper2.ExecuteScalar("SELECT MAX (garage_id) FROM t_garage")) + 1UL;
                var connection = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\temp");
                connection.SetPassword(passBytes);
                connection.Open();
                var sqLiteCommand = new SQLiteCommand(connection);
                switch (cB_special_car.SelectedIndex)
                {
                    case 0:
                        byte_3 = StringToByteArray(string_4_1);
                        smethod_11(byte_3, 61U, 4U, ulong_1);
                        sqLiteCommand.CommandText = "INSERT INTO t_garage VALUES (" + ulong_1 + ",1804,0,1,'US','chevrolet','FR',0,0,0,'0',500,1000,0,0,'XXXXXXX','XXXXXXX',@blob,0,0,0,0,0,0,0,@blob,@blob,'','','',0,0,0)";
                        break;
                    case 1:
                        byte_3 = StringToByteArray(string_4_2);
                        smethod_11(byte_3, 61U, 4U, ulong_1);
                        sqLiteCommand.CommandText = "INSERT INTO t_garage VALUES (" + ulong_1 + ",'1745','0','1','JP','polyphony','---','0','2010','0','0','0','0','0','0','Red Bull X2010 JP Flag Color','Red Bull X2010 JP Flag Color',@blob,'0','0','0','0','0','0','0',@blob,@blob,'','','','0','0','0')";
                        break;
                    case 2:
                        byte_3 = StringToByteArray(string_4_3);
                        smethod_11(byte_3, 61U, 4U, ulong_1);
                        sqLiteCommand.CommandText = "INSERT INTO t_garage VALUES (" + ulong_1 + ",'1803','0','1','JP','polyphony','---','0','2010','0','0','0','0','0','0','Red Bull X2010 5G','Red Bull X2010 5G',@blob,'0','0','0','0','0','0','0',@blob,@blob,'','','','0','0','0')";
                        break;
                    case 3:
                        byte_3 = StringToByteArray(string_4_4);
                        smethod_11(byte_3, 61U, 4U, ulong_1);
                        sqLiteCommand.CommandText = "INSERT INTO t_garage VALUES (" + ulong_1 + ",'1807','0','1','JP','polyphony','---','0','2010','0','0','0','0','0','0','Red Bull X2010 5G','Red Bull X2010 5G',@blob,'0','0','0','0','0','0','0',@blob,@blob,'','','','0','0','0')";
                        break;
                    case 4:
                        byte_3 = StringToByteArray(string_4_5);
                        smethod_11(byte_3, 61U, 4U, ulong_1);
                        sqLiteCommand.CommandText = "INSERT INTO t_garage VALUES (" + ulong_1 + ",'1808','0','1','JP','polyphony','---','0','2010','0','0','0','0','0','0','Red Bull X2010 5G','Red Bull X2010 5G',@blob,'0','0','0','0','0','0','0',@blob,@blob,'','','','0','0','0')";
                        break;
                }
                var parameter = new SQLiteParameter("@blob", DbType.Binary);
                parameter.Value = byte_3;
                sqLiteCommand.Parameters.Add(parameter);
                sqLiteCommand.ExecuteNonQuery();
                connection.Close();
                var num = (int)MessageBox.Show("Special Car Successfully Added!");
            }
            catch
            {
                var num = (int)MessageBox.Show("Something went wrong: Error 101");
            }
        }

        private void button_delete_item_Click(object sender, EventArgs e)
        {
            if (dataTable_0.Rows.Count <= 0)
                return;
            _sqlHelper2.ExecuteNonQuery("DELETE FROM t_itembox_user WHERE itembox_id = " + dataTable_0.Rows[cB_itemControl.SelectedIndex].ItemArray[0]);
            method_17();
            var num = (int)MessageBox.Show(this, "Item Deleted Successfully  ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        public void method_17()
        {
            dataTable_0.Clear();
            dataTable_0 = _sqlHelper2.ExecuteReader("SELECT itembox_id,item_name FROM t_itembox_user WHERE category_id = 901 AND status =1");
            cB_itemControl.Items.Clear();
            if (dataTable_0.Rows.Count <= 0)
                return;
            foreach (DataRow dataRow in (InternalDataCollectionBase)dataTable_0.Rows)
                cB_itemControl.Items.Add(dataRow.ItemArray[1].ToString());
            cB_itemControl.SelectedIndex = 0;
        }

        public void method_18()
        {
            LoadCarSheet(_char0);
            var byte_3 = new byte[679];
            if (_char0.Equals('a'))
                byte_3 = _currentCar.GetBlob1().GetBlob();
            if (_char0.Equals('b'))
                byte_3 = _currentCar.GetBlob2().GetBlob();
            if (_char0.Equals('c'))
                byte_3 = _currentCar.GetBlob3().GetBlob();
            method_9(ref dataGridView_Dest, ref byte_3);
            if (tabControl_garage.SelectedIndex == tabControl_garage.TabPages.IndexOf(tabPage_garage))
            {
                UpdateCarParamBlobs(_sqlHelper2, _currentCar);
                dataTable_8 = _sqlHelper2.ExecuteReader("SELECT * FROM t_garage WHERE garage_id LIKE " + dataTable_7.Rows[comboBox_DModel.SelectedIndex].ItemArray[1]);
                _currentCar = new Car(dataTable_8);
                LoadCurrentCarDetails();
            }
            else
                _currentCar.UpdateBlob1(new CarParameterBlob(_currentCar.GetBlob1().GetBlob()));
        }

        public bool IsNumeric(string string_4)
        {
            return Regex.IsMatch(string_4, "\\A\\b[0-9]+\\b\\Z");
        }

        public bool IsAlphaNumeric(string string_4)
        {
            return Regex.IsMatch(string_4, "\\A\\b[0-9a-fA-F]+\\b\\Z");
        }

        public static void WriteByteToFileStream(uint uint_0, FileStream fs, uint uint_1, byte byte_3)
        {
            fs.Position = uint_0 + uint_1;
            fs.WriteByte(byte_3);
        }

        public static void WriteSbyteToFileStream(uint uint_0, FileStream fs, uint uint_1, sbyte sbyte_0)
        {
            fs.Position = uint_0 + uint_1;
            fs.WriteByte((byte)sbyte_0);
        }

        public static void WriteUintToFileStream(uint uint_0, FileStream fs, uint uint_1, uint uint_2, uint uint_3)
        {
            switch (uint_2)
            {
                case 1U:
                    fs.Position = uint_0 + uint_1;
                    fs.WriteByte((byte)(uint_3 & byte.MaxValue));
                    break;
                case 2U:
                    fs.Position = uint_0 + uint_1;
                    fs.WriteByte((byte)(uint_3 >> 8 & byte.MaxValue));
                    fs.WriteByte((byte)(uint_3 & byte.MaxValue));
                    break;
                case 4U:
                    fs.Position = uint_0 + uint_1;
                    fs.WriteByte((byte)(uint_3 >> 24 & byte.MaxValue));
                    fs.WriteByte((byte)(uint_3 >> 16 & byte.MaxValue));
                    fs.WriteByte((byte)(uint_3 >> 8 & byte.MaxValue));
                    fs.WriteByte((byte)(uint_3 & byte.MaxValue));
                    break;
            }
        }

        public static void WriteLongToFileStream(long long0, FileStream fs, long long1, long numberBytes, long long_3)
        {
            switch (numberBytes)
            {
                case 2L:
                    fs.Position = long0 + long1;
                    fs.WriteByte((byte)(long_3 >> 8 & byte.MaxValue));
                    fs.WriteByte((byte)(long_3 & byte.MaxValue));
                    break;
                case 4L:
                    fs.Position = long0 + long1;
                    fs.WriteByte((byte)(long_3 >> 24 & byte.MaxValue));
                    fs.WriteByte((byte)(long_3 >> 16 & byte.MaxValue));
                    fs.WriteByte((byte)(long_3 >> 8 & byte.MaxValue));
                    fs.WriteByte((byte)(long_3 & byte.MaxValue));
                    break;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var num = (int)MessageBox.Show(this, "GT5 Garage Editor, by slim355 & q-k\n\n\nThanks: \nflat_z(pfdtool) \naldostools(globals & game)\n\n\nYoutube.com/pulpfictionost : For Updates", "About", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void radioButton_A_CheckedChanged(object sender, EventArgs e)
        {
            method_18();
            _char0 = 'a';
            LoadCarSheet(_char0);
        }

        private void radioButton_B_CheckedChanged(object sender, EventArgs e)
        {
            method_18();
            _char0 = 'b';
            LoadCarSheet(_char0);
        }

        private void radioButton_C_CheckedChanged(object sender, EventArgs e)
        {
            method_18();
            _char0 = 'c';
            LoadCarSheet(_char0);
        }

        public string StringToMd5Hash(string str)
        {
            var hash = MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(str));
            var stringBuilder = new StringBuilder();
            for (var index = 0; index < hash.Length; ++index)
                stringBuilder.Append(hash[index].ToString("X2"));
            return stringBuilder.ToString();
        }

        public static byte[] StringToByteArray(string str)
        {
            var length = str.Length / 2;
            var numArray = new byte[length];
            var stringReader = new StringReader(str);
            for (var index = 0; index < length; ++index)
                numArray[index] = Convert.ToByte(new string(new char[2]
                {
                    (char) stringReader.Read(),
                    (char) stringReader.Read()
                }), 16);
            stringReader.Dispose();
            return numArray;
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formOptions = new FormOptions();
            var num = (int)formOptions.ShowDialog();
            formOptions.Dispose();
        }

        private void comboBox_gift_preset_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}