// Type: SetUp
// Assembly: GT5_Garage_Editor, Version=1.3.1.0, Culture=neutral, PublicKeyToken=null
// MVID: DD0589A9-C36F-4C8C-A8E4-5B0E29CADD76
// Assembly location: C:\Users\shalpin\Downloads\GT5_Garage_Editor_v131_slim355_q-k (2)\Release\GT5_Garage_Editor-cleaned.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using GT5_Garage_Editor.Models.CarModels;

namespace GT5_Garage_Editor
{
    public sealed class SetUp : Form
    {
        private IContainer icontainer_0;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private GroupBox groupBox_Gears;
        private TextBox tb_1;
        private TextBox tb_rev;
        private TextBox tb_final;
        private TextBox tb_7;
        private TextBox tb_6;
        private TextBox tb_5;
        private TextBox tb_4;
        private TextBox tb_3;
        private TextBox tb_2;
        private GroupBox groupBox_General;
        private TextBox tb_changes;
        private TextBox tb_metres;
        private Label label11;
        private Label label10;
        private TextBox tb_oil;
        private Label label15;
        private TextBox tb_wins;
        private TextBox tb_wash;
        private Label label12;
        private Label label13;
        private GroupBox groupBox_Suspension;
        private TextBox tb_arbr;
        private TextBox tb_compr;
        private TextBox tb_extr;
        private TextBox tb_springr;
        private TextBox tb_toer;
        private TextBox tb_rhr;
        private TextBox tb_camberr;
        private TextBox tb_arbf;
        private TextBox tb_compf;
        private TextBox tb_extf;
        private TextBox tb_springf;
        private TextBox tb_toef;
        private TextBox tb_rhf;
        private Label label14;
        private TextBox tb_camberf;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label22;
        private Label label23;
        private GroupBox groupBox_LSD;
        private Label label21;
        private Label label16;
        private TextBox tb_lsdinitf;
        private TextBox tb_lsdinitr;
        private TextBox tb_lsddecr;
        private TextBox tb_lsdaccf;
        private TextBox tb_lsddecf;
        private TextBox tb_lsdaccr;
        private GroupBox groupBox_Other;
        private Label label26;
        private TextBox tb_BBr;
        private TextBox tb_BBf;
        private Label label24;
        private Label label25;
        private TextBox tb_DFr;
        private TextBox tb_ballastkg;
        private TextBox tb_ballastPos;
        private TextBox tb_DFf;
        private Button button_OK;
        private Button button_Cancel;
        private Label label27;
        private TextBox tb_frTorque;
        private GroupBox groupBox_Sheet;
        private RadioButton radioButton_A;
        private RadioButton radioButton_C;
        private RadioButton radioButton_B;
        private Button button_Go;
        private TextBox tb_11;
        private TextBox tb_10;
        private TextBox tb_9;
        private TextBox tb_8;
        private Label label28;
        private Label label29;
        private Label label30;
        private Label label31;
        private Label label32;
        private Label label33;
        private Label label34;
        private TextBox tb_weight;
        private TextBox tb_bhp;
        private TextBox tb_grip;
        private GroupBox groupBox_wheels;
        private Label label36;
        private TextBox tb_FrTyre;
        private TextBox tb_RrTyre;
        private Label label35;
        private TextBox tb_frRim;
        private TextBox tb_RrRim;
        private PictureBox pictureBox_gear;
        private TextBox tb_Max;
        private Label label37;
        private Timer timer_0;
        private Graphics graphics_0;
        private Car _currentCar;
        private CarParameterBlob _blob1;
        private CarParameterBlob _blob2;
        private CarParameterBlob _blob3;
        private IContainer components;
        private byte byte_0;

        public SetUp(Car car)
        {
            method_1(car);
            method_3(car.GetBlob1());
            method_5(car.GetBlob2());
            method_7(car.GetBlob3());
            InitializeComponent();
            pictureBox_gear.Image = new Bitmap(pictureBox_gear.Width, pictureBox_gear.Height);
            graphics_0 = Graphics.FromImage(pictureBox_gear.Image);
            if (radioButton_A.Checked)
            {
                method_9(1);
                method_10(method_0().GetBlob1());
            }
            else if (radioButton_B.Checked)
            {
                method_9(2);
                method_10(method_0().GetBlob2());
            }
            else
            {
                if (!radioButton_C.Checked)
                    return;
                method_9(3);
                method_10(method_0().GetBlob3());
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && icontainer_0 != null)
                icontainer_0.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            groupBox_Gears = new GroupBox();
            tb_Max = new TextBox();
            label37 = new Label();
            pictureBox_gear = new PictureBox();
            tb_11 = new TextBox();
            tb_10 = new TextBox();
            tb_9 = new TextBox();
            tb_8 = new TextBox();
            label28 = new Label();
            label29 = new Label();
            label30 = new Label();
            label31 = new Label();
            tb_final = new TextBox();
            tb_7 = new TextBox();
            tb_6 = new TextBox();
            tb_5 = new TextBox();
            tb_4 = new TextBox();
            tb_3 = new TextBox();
            tb_2 = new TextBox();
            tb_1 = new TextBox();
            tb_rev = new TextBox();
            groupBox_General = new GroupBox();
            tb_oil = new TextBox();
            label15 = new Label();
            tb_wins = new TextBox();
            tb_wash = new TextBox();
            label12 = new Label();
            label13 = new Label();
            tb_changes = new TextBox();
            tb_metres = new TextBox();
            label11 = new Label();
            label10 = new Label();
            groupBox_Suspension = new GroupBox();
            tb_arbr = new TextBox();
            tb_compr = new TextBox();
            tb_extr = new TextBox();
            tb_springr = new TextBox();
            tb_toer = new TextBox();
            tb_rhr = new TextBox();
            tb_camberr = new TextBox();
            tb_arbf = new TextBox();
            tb_compf = new TextBox();
            tb_extf = new TextBox();
            tb_springf = new TextBox();
            tb_toef = new TextBox();
            tb_rhf = new TextBox();
            label14 = new Label();
            tb_camberf = new TextBox();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label22 = new Label();
            label23 = new Label();
            groupBox_LSD = new GroupBox();
            tb_frTorque = new TextBox();
            label27 = new Label();
            label21 = new Label();
            label16 = new Label();
            tb_lsdinitf = new TextBox();
            tb_lsdinitr = new TextBox();
            tb_lsddecr = new TextBox();
            tb_lsdaccf = new TextBox();
            tb_lsddecf = new TextBox();
            tb_lsdaccr = new TextBox();
            groupBox_Other = new GroupBox();
            label32 = new Label();
            label33 = new Label();
            label34 = new Label();
            tb_weight = new TextBox();
            tb_bhp = new TextBox();
            tb_grip = new TextBox();
            label26 = new Label();
            tb_BBr = new TextBox();
            tb_BBf = new TextBox();
            label24 = new Label();
            label25 = new Label();
            tb_DFr = new TextBox();
            tb_ballastkg = new TextBox();
            tb_ballastPos = new TextBox();
            tb_DFf = new TextBox();
            button_OK = new Button();
            button_Cancel = new Button();
            groupBox_Sheet = new GroupBox();
            button_Go = new Button();
            radioButton_C = new RadioButton();
            radioButton_B = new RadioButton();
            radioButton_A = new RadioButton();
            groupBox_wheels = new GroupBox();
            label36 = new Label();
            tb_FrTyre = new TextBox();
            tb_RrTyre = new TextBox();
            label35 = new Label();
            tb_frRim = new TextBox();
            tb_RrRim = new TextBox();
            timer_0 = new Timer(components);
            groupBox_Gears.SuspendLayout();
            ((ISupportInitialize)(pictureBox_gear)).BeginInit();
            groupBox_General.SuspendLayout();
            groupBox_Suspension.SuspendLayout();
            groupBox_LSD.SuspendLayout();
            groupBox_Other.SuspendLayout();
            groupBox_Sheet.SuspendLayout();
            groupBox_wheels.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(20, 212);
            label1.Name = "label1";
            label1.Size = new Size(47, 13);
            label1.TabIndex = 0;
            label1.Text = "Reverse";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(20, 232);
            label2.Name = "label2";
            label2.Size = new Size(21, 13);
            label2.TabIndex = 1;
            label2.Text = "1st";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(20, 252);
            label3.Name = "label3";
            label3.Size = new Size(25, 13);
            label3.TabIndex = 2;
            label3.Text = "2nd";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(20, 272);
            label4.Name = "label4";
            label4.Size = new Size(22, 13);
            label4.TabIndex = 3;
            label4.Text = "3rd";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(20, 292);
            label5.Name = "label5";
            label5.Size = new Size(22, 13);
            label5.TabIndex = 4;
            label5.Text = "4th";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(20, 312);
            label6.Name = "label6";
            label6.Size = new Size(22, 13);
            label6.TabIndex = 5;
            label6.Text = "5th";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(20, 332);
            label7.Name = "label7";
            label7.Size = new Size(22, 13);
            label7.TabIndex = 6;
            label7.Text = "6th";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(223, 212);
            label8.Name = "label8";
            label8.Size = new Size(22, 13);
            label8.TabIndex = 7;
            label8.Text = "7th";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(223, 312);
            label9.Name = "label9";
            label9.Size = new Size(29, 13);
            label9.TabIndex = 8;
            label9.Text = "Final";
            // 
            // groupBox_Gears
            // 
            groupBox_Gears.BackColor = Color.MintCream;
            groupBox_Gears.Controls.Add(tb_Max);
            groupBox_Gears.Controls.Add(label37);
            groupBox_Gears.Controls.Add(pictureBox_gear);
            groupBox_Gears.Controls.Add(tb_11);
            groupBox_Gears.Controls.Add(tb_10);
            groupBox_Gears.Controls.Add(tb_9);
            groupBox_Gears.Controls.Add(tb_8);
            groupBox_Gears.Controls.Add(label28);
            groupBox_Gears.Controls.Add(label29);
            groupBox_Gears.Controls.Add(label30);
            groupBox_Gears.Controls.Add(label31);
            groupBox_Gears.Controls.Add(tb_final);
            groupBox_Gears.Controls.Add(tb_7);
            groupBox_Gears.Controls.Add(tb_6);
            groupBox_Gears.Controls.Add(tb_5);
            groupBox_Gears.Controls.Add(tb_4);
            groupBox_Gears.Controls.Add(tb_3);
            groupBox_Gears.Controls.Add(tb_2);
            groupBox_Gears.Controls.Add(tb_1);
            groupBox_Gears.Controls.Add(label3);
            groupBox_Gears.Controls.Add(label9);
            groupBox_Gears.Controls.Add(tb_rev);
            groupBox_Gears.Controls.Add(label5);
            groupBox_Gears.Controls.Add(label1);
            groupBox_Gears.Controls.Add(label6);
            groupBox_Gears.Controls.Add(label2);
            groupBox_Gears.Controls.Add(label8);
            groupBox_Gears.Controls.Add(label7);
            groupBox_Gears.Controls.Add(label4);
            groupBox_Gears.Location = new Point(244, 206);
            groupBox_Gears.Name = "groupBox_Gears";
            groupBox_Gears.Size = new Size(404, 359);
            groupBox_Gears.TabIndex = 9;
            groupBox_Gears.TabStop = false;
            groupBox_Gears.Text = "Gears";
            // 
            // tb_Max
            // 
            tb_Max.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tb_Max.Location = new Point(328, 329);
            tb_Max.Name = "tb_Max";
            tb_Max.ReadOnly = true;
            tb_Max.Size = new Size(53, 20);
            tb_Max.TabIndex = 19;
            // 
            // label37
            // 
            label37.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label37.AutoSize = true;
            label37.Location = new Point(223, 332);
            label37.Name = "label37";
            label37.Size = new Size(56, 13);
            label37.TabIndex = 18;
            label37.Text = "Max (kmh)";
            // 
            // pictureBox_gear
            // 
            pictureBox_gear.BackColor = Color.White;
            pictureBox_gear.BorderStyle = BorderStyle.Fixed3D;
            pictureBox_gear.Location = new Point(11, 19);
            pictureBox_gear.Name = "pictureBox_gear";
            pictureBox_gear.Size = new Size(381, 184);
            pictureBox_gear.TabIndex = 17;
            pictureBox_gear.TabStop = false;
            pictureBox_gear.Paint += new PaintEventHandler(pictureBox_gear_Paint);
            // 
            // tb_11
            // 
            tb_11.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tb_11.Location = new Point(328, 289);
            tb_11.Name = "tb_11";
            tb_11.Size = new Size(53, 20);
            tb_11.TabIndex = 11;
            // 
            // tb_10
            // 
            tb_10.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tb_10.Location = new Point(328, 269);
            tb_10.Name = "tb_10";
            tb_10.Size = new Size(53, 20);
            tb_10.TabIndex = 10;
            // 
            // tb_9
            // 
            tb_9.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tb_9.Location = new Point(328, 249);
            tb_9.Name = "tb_9";
            tb_9.Size = new Size(53, 20);
            tb_9.TabIndex = 9;
            // 
            // tb_8
            // 
            tb_8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tb_8.Location = new Point(328, 229);
            tb_8.Name = "tb_8";
            tb_8.Size = new Size(53, 20);
            tb_8.TabIndex = 8;
            // 
            // label28
            // 
            label28.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label28.AutoSize = true;
            label28.Location = new Point(223, 232);
            label28.Name = "label28";
            label28.Size = new Size(22, 13);
            label28.TabIndex = 9;
            label28.Text = "8th";
            // 
            // label29
            // 
            label29.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label29.AutoSize = true;
            label29.Location = new Point(223, 252);
            label29.Name = "label29";
            label29.Size = new Size(22, 13);
            label29.TabIndex = 11;
            label29.Text = "9th";
            // 
            // label30
            // 
            label30.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label30.AutoSize = true;
            label30.Location = new Point(223, 292);
            label30.Name = "label30";
            label30.Size = new Size(28, 13);
            label30.TabIndex = 16;
            label30.Text = "11th";
            // 
            // label31
            // 
            label31.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label31.AutoSize = true;
            label31.Location = new Point(223, 270);
            label31.Name = "label31";
            label31.Size = new Size(28, 13);
            label31.TabIndex = 14;
            label31.Text = "10th";
            // 
            // tb_final
            // 
            tb_final.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tb_final.Location = new Point(328, 309);
            tb_final.Name = "tb_final";
            tb_final.Size = new Size(53, 20);
            tb_final.TabIndex = 12;
            // 
            // tb_7
            // 
            tb_7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tb_7.Location = new Point(328, 209);
            tb_7.Name = "tb_7";
            tb_7.Size = new Size(53, 20);
            tb_7.TabIndex = 7;
            // 
            // tb_6
            // 
            tb_6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tb_6.Location = new Point(121, 329);
            tb_6.Name = "tb_6";
            tb_6.Size = new Size(53, 20);
            tb_6.TabIndex = 6;
            // 
            // tb_5
            // 
            tb_5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tb_5.Location = new Point(121, 309);
            tb_5.Name = "tb_5";
            tb_5.Size = new Size(53, 20);
            tb_5.TabIndex = 5;
            // 
            // tb_4
            // 
            tb_4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tb_4.Location = new Point(121, 289);
            tb_4.Name = "tb_4";
            tb_4.Size = new Size(53, 20);
            tb_4.TabIndex = 4;
            // 
            // tb_3
            // 
            tb_3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tb_3.Location = new Point(121, 269);
            tb_3.Name = "tb_3";
            tb_3.Size = new Size(53, 20);
            tb_3.TabIndex = 3;
            // 
            // tb_2
            // 
            tb_2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tb_2.Location = new Point(121, 249);
            tb_2.Name = "tb_2";
            tb_2.Size = new Size(53, 20);
            tb_2.TabIndex = 2;
            // 
            // tb_1
            // 
            tb_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tb_1.Location = new Point(121, 229);
            tb_1.Name = "tb_1";
            tb_1.Size = new Size(53, 20);
            tb_1.TabIndex = 1;
            // 
            // tb_rev
            // 
            tb_rev.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tb_rev.Location = new Point(121, 209);
            tb_rev.Name = "tb_rev";
            tb_rev.Size = new Size(53, 20);
            tb_rev.TabIndex = 0;
            // 
            // groupBox_General
            // 
            groupBox_General.Controls.Add(tb_oil);
            groupBox_General.Controls.Add(label15);
            groupBox_General.Controls.Add(tb_wins);
            groupBox_General.Controls.Add(tb_wash);
            groupBox_General.Controls.Add(label12);
            groupBox_General.Controls.Add(label13);
            groupBox_General.Controls.Add(tb_changes);
            groupBox_General.Controls.Add(tb_metres);
            groupBox_General.Controls.Add(label11);
            groupBox_General.Controls.Add(label10);
            groupBox_General.Location = new Point(244, 52);
            groupBox_General.Name = "groupBox_General";
            groupBox_General.Size = new Size(172, 145);
            groupBox_General.TabIndex = 10;
            groupBox_General.TabStop = false;
            groupBox_General.Text = "General";
            // 
            // tb_oil
            // 
            tb_oil.Location = new Point(61, 44);
            tb_oil.Name = "tb_oil";
            tb_oil.Size = new Size(101, 20);
            tb_oil.TabIndex = 1;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(6, 72);
            label15.Name = "label15";
            label15.Size = new Size(49, 13);
            label15.TabIndex = 26;
            label15.Text = "Wash(m)";
            // 
            // tb_wins
            // 
            tb_wins.Location = new Point(61, 94);
            tb_wins.Name = "tb_wins";
            tb_wins.Size = new Size(101, 20);
            tb_wins.TabIndex = 3;
            // 
            // tb_wash
            // 
            tb_wash.Location = new Point(61, 69);
            tb_wash.Name = "tb_wash";
            tb_wash.Size = new Size(101, 20);
            tb_wash.TabIndex = 2;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 97);
            label12.Name = "label12";
            label12.Size = new Size(31, 13);
            label12.TabIndex = 23;
            label12.Text = "Wins";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 47);
            label13.Name = "label13";
            label13.Size = new Size(33, 13);
            label13.TabIndex = 22;
            label13.Text = "Oil(m)";
            // 
            // tb_changes
            // 
            tb_changes.Location = new Point(61, 119);
            tb_changes.Name = "tb_changes";
            tb_changes.Size = new Size(101, 20);
            tb_changes.TabIndex = 4;
            // 
            // tb_metres
            // 
            tb_metres.Location = new Point(61, 19);
            tb_metres.Name = "tb_metres";
            tb_metres.Size = new Size(101, 20);
            tb_metres.TabIndex = 0;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 122);
            label11.Name = "label11";
            label11.Size = new Size(49, 13);
            label11.TabIndex = 19;
            label11.Text = "Changes";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 22);
            label10.Name = "label10";
            label10.Size = new Size(39, 13);
            label10.TabIndex = 18;
            label10.Text = "Metres";
            // 
            // groupBox_Suspension
            // 
            groupBox_Suspension.Controls.Add(tb_arbr);
            groupBox_Suspension.Controls.Add(tb_compr);
            groupBox_Suspension.Controls.Add(tb_extr);
            groupBox_Suspension.Controls.Add(tb_springr);
            groupBox_Suspension.Controls.Add(tb_toer);
            groupBox_Suspension.Controls.Add(tb_rhr);
            groupBox_Suspension.Controls.Add(tb_camberr);
            groupBox_Suspension.Controls.Add(tb_arbf);
            groupBox_Suspension.Controls.Add(tb_compf);
            groupBox_Suspension.Controls.Add(tb_extf);
            groupBox_Suspension.Controls.Add(tb_springf);
            groupBox_Suspension.Controls.Add(tb_toef);
            groupBox_Suspension.Controls.Add(tb_rhf);
            groupBox_Suspension.Controls.Add(label14);
            groupBox_Suspension.Controls.Add(tb_camberf);
            groupBox_Suspension.Controls.Add(label17);
            groupBox_Suspension.Controls.Add(label18);
            groupBox_Suspension.Controls.Add(label19);
            groupBox_Suspension.Controls.Add(label20);
            groupBox_Suspension.Controls.Add(label22);
            groupBox_Suspension.Controls.Add(label23);
            groupBox_Suspension.Location = new Point(12, 52);
            groupBox_Suspension.Name = "groupBox_Suspension";
            groupBox_Suspension.Size = new Size(226, 184);
            groupBox_Suspension.TabIndex = 0;
            groupBox_Suspension.TabStop = false;
            groupBox_Suspension.Text = "Suspension";
            // 
            // tb_arbr
            // 
            tb_arbr.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tb_arbr.Location = new Point(161, 154);
            tb_arbr.Name = "tb_arbr";
            tb_arbr.Size = new Size(53, 20);
            tb_arbr.TabIndex = 13;
            // 
            // tb_compr
            // 
            tb_compr.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tb_compr.Location = new Point(161, 131);
            tb_compr.Name = "tb_compr";
            tb_compr.Size = new Size(53, 20);
            tb_compr.TabIndex = 11;
            // 
            // tb_extr
            // 
            tb_extr.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tb_extr.Location = new Point(161, 108);
            tb_extr.Name = "tb_extr";
            tb_extr.Size = new Size(53, 20);
            tb_extr.TabIndex = 9;
            // 
            // tb_springr
            // 
            tb_springr.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tb_springr.Location = new Point(161, 85);
            tb_springr.Name = "tb_springr";
            tb_springr.Size = new Size(53, 20);
            tb_springr.TabIndex = 7;
            // 
            // tb_toer
            // 
            tb_toer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tb_toer.Location = new Point(161, 62);
            tb_toer.Name = "tb_toer";
            tb_toer.Size = new Size(53, 20);
            tb_toer.TabIndex = 5;
            // 
            // tb_rhr
            // 
            tb_rhr.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tb_rhr.Location = new Point(161, 39);
            tb_rhr.Name = "tb_rhr";
            tb_rhr.Size = new Size(53, 20);
            tb_rhr.TabIndex = 3;
            // 
            // tb_camberr
            // 
            tb_camberr.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tb_camberr.Location = new Point(161, 16);
            tb_camberr.Name = "tb_camberr";
            tb_camberr.Size = new Size(53, 20);
            tb_camberr.TabIndex = 1;
            // 
            // tb_arbf
            // 
            tb_arbf.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tb_arbf.Location = new Point(102, 154);
            tb_arbf.Name = "tb_arbf";
            tb_arbf.Size = new Size(53, 20);
            tb_arbf.TabIndex = 12;
            // 
            // tb_compf
            // 
            tb_compf.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tb_compf.Location = new Point(102, 131);
            tb_compf.Name = "tb_compf";
            tb_compf.Size = new Size(53, 20);
            tb_compf.TabIndex = 10;
            // 
            // tb_extf
            // 
            tb_extf.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tb_extf.Location = new Point(102, 108);
            tb_extf.Name = "tb_extf";
            tb_extf.Size = new Size(53, 20);
            tb_extf.TabIndex = 8;
            // 
            // tb_springf
            // 
            tb_springf.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tb_springf.Location = new Point(102, 85);
            tb_springf.Name = "tb_springf";
            tb_springf.Size = new Size(53, 20);
            tb_springf.TabIndex = 6;
            // 
            // tb_toef
            // 
            tb_toef.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tb_toef.Location = new Point(102, 62);
            tb_toef.Name = "tb_toef";
            tb_toef.Size = new Size(53, 20);
            tb_toef.TabIndex = 4;
            // 
            // tb_rhf
            // 
            tb_rhf.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tb_rhf.Location = new Point(102, 39);
            tb_rhf.Name = "tb_rhf";
            tb_rhf.Size = new Size(53, 20);
            tb_rhf.TabIndex = 2;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 65);
            label14.Name = "label14";
            label14.Size = new Size(26, 13);
            label14.TabIndex = 20;
            label14.Text = "Toe";
            // 
            // tb_camberf
            // 
            tb_camberf.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tb_camberf.Location = new Point(102, 16);
            tb_camberf.Name = "tb_camberf";
            tb_camberf.Size = new Size(53, 20);
            tb_camberf.TabIndex = 0;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(6, 111);
            label17.Name = "label17";
            label17.Size = new Size(70, 13);
            label17.TabIndex = 22;
            label17.Text = "Dampers(Ext)";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(6, 19);
            label18.Name = "label18";
            label18.Size = new Size(43, 13);
            label18.TabIndex = 18;
            label18.Text = "Camber";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(6, 134);
            label19.Name = "label19";
            label19.Size = new Size(82, 13);
            label19.TabIndex = 23;
            label19.Text = "Dampers(Comp)";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(6, 42);
            label20.Name = "label20";
            label20.Size = new Size(61, 13);
            label20.TabIndex = 19;
            label20.Text = "Ride height";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(6, 157);
            label22.Name = "label22";
            label22.Size = new Size(29, 13);
            label22.TabIndex = 24;
            label22.Text = "ARB";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(6, 88);
            label23.Name = "label23";
            label23.Size = new Size(37, 13);
            label23.TabIndex = 21;
            label23.Text = "Spring";
            // 
            // groupBox_LSD
            // 
            groupBox_LSD.Controls.Add(tb_frTorque);
            groupBox_LSD.Controls.Add(label27);
            groupBox_LSD.Controls.Add(label21);
            groupBox_LSD.Controls.Add(label16);
            groupBox_LSD.Controls.Add(tb_lsdinitf);
            groupBox_LSD.Controls.Add(tb_lsdinitr);
            groupBox_LSD.Controls.Add(tb_lsddecr);
            groupBox_LSD.Controls.Add(tb_lsdaccf);
            groupBox_LSD.Controls.Add(tb_lsddecf);
            groupBox_LSD.Controls.Add(tb_lsdaccr);
            groupBox_LSD.Location = new Point(422, 52);
            groupBox_LSD.Name = "groupBox_LSD";
            groupBox_LSD.Size = new Size(226, 97);
            groupBox_LSD.TabIndex = 12;
            groupBox_LSD.TabStop = false;
            groupBox_LSD.Text = "LSD";
            // 
            // tb_frTorque
            // 
            tb_frTorque.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tb_frTorque.Location = new Point(102, 69);
            tb_frTorque.Name = "tb_frTorque";
            tb_frTorque.Size = new Size(53, 20);
            tb_frTorque.TabIndex = 6;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(8, 73);
            label27.Name = "label27";
            label27.Size = new Size(26, 13);
            label27.TabIndex = 50;
            label27.Text = "Trq.";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(8, 50);
            label21.Name = "label21";
            label21.Size = new Size(30, 13);
            label21.TabIndex = 49;
            label21.Text = "Rear";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(8, 27);
            label16.Name = "label16";
            label16.Size = new Size(31, 13);
            label16.TabIndex = 43;
            label16.Text = "Front";
            // 
            // tb_lsdinitf
            // 
            tb_lsdinitf.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tb_lsdinitf.Location = new Point(43, 23);
            tb_lsdinitf.Name = "tb_lsdinitf";
            tb_lsdinitf.Size = new Size(53, 20);
            tb_lsdinitf.TabIndex = 0;
            // 
            // tb_lsdinitr
            // 
            tb_lsdinitr.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tb_lsdinitr.Location = new Point(43, 46);
            tb_lsdinitr.Name = "tb_lsdinitr";
            tb_lsdinitr.Size = new Size(53, 20);
            tb_lsdinitr.TabIndex = 3;
            // 
            // tb_lsddecr
            // 
            tb_lsddecr.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tb_lsddecr.Location = new Point(161, 46);
            tb_lsddecr.Name = "tb_lsddecr";
            tb_lsddecr.Size = new Size(53, 20);
            tb_lsddecr.TabIndex = 5;
            // 
            // tb_lsdaccf
            // 
            tb_lsdaccf.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tb_lsdaccf.Location = new Point(102, 23);
            tb_lsdaccf.Name = "tb_lsdaccf";
            tb_lsdaccf.Size = new Size(53, 20);
            tb_lsdaccf.TabIndex = 1;
            // 
            // tb_lsddecf
            // 
            tb_lsddecf.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tb_lsddecf.Location = new Point(161, 23);
            tb_lsddecf.Name = "tb_lsddecf";
            tb_lsddecf.Size = new Size(53, 20);
            tb_lsddecf.TabIndex = 2;
            // 
            // tb_lsdaccr
            // 
            tb_lsdaccr.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tb_lsdaccr.Location = new Point(102, 46);
            tb_lsdaccr.Name = "tb_lsdaccr";
            tb_lsdaccr.Size = new Size(53, 20);
            tb_lsdaccr.TabIndex = 4;
            // 
            // groupBox_Other
            // 
            groupBox_Other.Controls.Add(label32);
            groupBox_Other.Controls.Add(label33);
            groupBox_Other.Controls.Add(label34);
            groupBox_Other.Controls.Add(tb_weight);
            groupBox_Other.Controls.Add(tb_bhp);
            groupBox_Other.Controls.Add(tb_grip);
            groupBox_Other.Controls.Add(label26);
            groupBox_Other.Controls.Add(tb_BBr);
            groupBox_Other.Controls.Add(tb_BBf);
            groupBox_Other.Controls.Add(label24);
            groupBox_Other.Controls.Add(label25);
            groupBox_Other.Controls.Add(tb_DFr);
            groupBox_Other.Controls.Add(tb_ballastkg);
            groupBox_Other.Controls.Add(tb_ballastPos);
            groupBox_Other.Controls.Add(tb_DFf);
            groupBox_Other.Location = new Point(12, 242);
            groupBox_Other.Name = "groupBox_Other";
            groupBox_Other.Size = new Size(226, 163);
            groupBox_Other.TabIndex = 50;
            groupBox_Other.TabStop = false;
            groupBox_Other.Text = "Other";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(8, 139);
            label32.Name = "label32";
            label32.Size = new Size(66, 13);
            label32.TabIndex = 58;
            label32.Text = "Weight Multi";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(8, 117);
            label33.Name = "label33";
            label33.Size = new Size(54, 13);
            label33.TabIndex = 57;
            label33.Text = "BHP Multi";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(8, 94);
            label34.Name = "label34";
            label34.Size = new Size(51, 13);
            label34.TabIndex = 56;
            label34.Text = "Grip Multi";
            // 
            // tb_weight
            // 
            tb_weight.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tb_weight.Location = new Point(161, 136);
            tb_weight.Name = "tb_weight";
            tb_weight.Size = new Size(53, 20);
            tb_weight.TabIndex = 8;
            // 
            // tb_bhp
            // 
            tb_bhp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tb_bhp.Location = new Point(161, 114);
            tb_bhp.Name = "tb_bhp";
            tb_bhp.Size = new Size(53, 20);
            tb_bhp.TabIndex = 7;
            // 
            // tb_grip
            // 
            tb_grip.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tb_grip.Location = new Point(161, 91);
            tb_grip.Name = "tb_grip";
            tb_grip.Size = new Size(53, 20);
            tb_grip.TabIndex = 6;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(8, 72);
            label26.Name = "label26";
            label26.Size = new Size(77, 13);
            label26.TabIndex = 52;
            label26.Text = "Brake Balance";
            // 
            // tb_BBr
            // 
            tb_BBr.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tb_BBr.Location = new Point(161, 68);
            tb_BBr.Name = "tb_BBr";
            tb_BBr.Size = new Size(53, 20);
            tb_BBr.TabIndex = 5;
            // 
            // tb_BBf
            // 
            tb_BBf.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tb_BBf.Location = new Point(102, 68);
            tb_BBf.Name = "tb_BBf";
            tb_BBf.Size = new Size(53, 20);
            tb_BBf.TabIndex = 4;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(8, 50);
            label24.Name = "label24";
            label24.Size = new Size(59, 13);
            label24.TabIndex = 49;
            label24.Text = "Downforce";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(8, 27);
            label25.Name = "label25";
            label25.Size = new Size(80, 13);
            label25.TabIndex = 43;
            label25.Text = "Ballast(Kg/Pos)";
            // 
            // tb_DFr
            // 
            tb_DFr.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tb_DFr.Location = new Point(161, 46);
            tb_DFr.Name = "tb_DFr";
            tb_DFr.Size = new Size(53, 20);
            tb_DFr.TabIndex = 3;
            // 
            // tb_ballastkg
            // 
            tb_ballastkg.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tb_ballastkg.Location = new Point(102, 23);
            tb_ballastkg.Name = "tb_ballastkg";
            tb_ballastkg.Size = new Size(53, 20);
            tb_ballastkg.TabIndex = 0;
            // 
            // tb_ballastPos
            // 
            tb_ballastPos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tb_ballastPos.Location = new Point(161, 23);
            tb_ballastPos.Name = "tb_ballastPos";
            tb_ballastPos.Size = new Size(53, 20);
            tb_ballastPos.TabIndex = 1;
            // 
            // tb_DFf
            // 
            tb_DFf.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tb_DFf.Location = new Point(102, 46);
            tb_DFf.Name = "tb_DFf";
            tb_DFf.Size = new Size(53, 20);
            tb_DFf.TabIndex = 2;
            // 
            // button_OK
            // 
            button_OK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_OK.Location = new Point(573, 584);
            button_OK.Name = "button_OK";
            button_OK.Size = new Size(75, 23);
            button_OK.TabIndex = 2;
            button_OK.Text = "&OK";
            button_OK.UseVisualStyleBackColor = true;
            button_OK.Click += new EventHandler(button_OK_Click);
            // 
            // button_Cancel
            // 
            button_Cancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_Cancel.DialogResult = DialogResult.Cancel;
            button_Cancel.Location = new Point(492, 584);
            button_Cancel.Name = "button_Cancel";
            button_Cancel.Size = new Size(75, 23);
            button_Cancel.TabIndex = 1;
            button_Cancel.Text = "&Cancel";
            button_Cancel.UseVisualStyleBackColor = true;
            button_Cancel.Click += new EventHandler(button_Cancel_Click);
            // 
            // groupBox_Sheet
            // 
            groupBox_Sheet.Controls.Add(button_Go);
            groupBox_Sheet.Controls.Add(radioButton_C);
            groupBox_Sheet.Controls.Add(radioButton_B);
            groupBox_Sheet.Controls.Add(radioButton_A);
            groupBox_Sheet.Location = new Point(12, 12);
            groupBox_Sheet.Name = "groupBox_Sheet";
            groupBox_Sheet.Size = new Size(404, 34);
            groupBox_Sheet.TabIndex = 53;
            groupBox_Sheet.TabStop = false;
            groupBox_Sheet.Text = "Sheet";
            // 
            // button_Go
            // 
            button_Go.Location = new Point(351, 8);
            button_Go.Name = "button_Go";
            button_Go.Size = new Size(41, 23);
            button_Go.TabIndex = 3;
            button_Go.Text = "&Go";
            button_Go.UseVisualStyleBackColor = true;
            button_Go.Click += new EventHandler(button_Go_Click);
            // 
            // radioButton_C
            // 
            radioButton_C.AutoSize = true;
            radioButton_C.Location = new Point(138, 11);
            radioButton_C.Name = "radioButton_C";
            radioButton_C.Size = new Size(60, 17);
            radioButton_C.TabIndex = 2;
            radioButton_C.Text = "Tune C";
            radioButton_C.UseVisualStyleBackColor = true;
            // 
            // radioButton_B
            // 
            radioButton_B.AutoSize = true;
            radioButton_B.Location = new Point(72, 11);
            radioButton_B.Name = "radioButton_B";
            radioButton_B.Size = new Size(60, 17);
            radioButton_B.TabIndex = 1;
            radioButton_B.Text = "Tune B";
            radioButton_B.UseVisualStyleBackColor = true;
            // 
            // radioButton_A
            // 
            radioButton_A.AutoSize = true;
            radioButton_A.Checked = true;
            radioButton_A.Location = new Point(6, 11);
            radioButton_A.Name = "radioButton_A";
            radioButton_A.Size = new Size(60, 17);
            radioButton_A.TabIndex = 0;
            radioButton_A.TabStop = true;
            radioButton_A.Text = "Tune A";
            radioButton_A.UseVisualStyleBackColor = true;
            // 
            // groupBox_wheels
            // 
            groupBox_wheels.Controls.Add(label36);
            groupBox_wheels.Controls.Add(tb_FrTyre);
            groupBox_wheels.Controls.Add(tb_RrTyre);
            groupBox_wheels.Controls.Add(label35);
            groupBox_wheels.Controls.Add(tb_frRim);
            groupBox_wheels.Controls.Add(tb_RrRim);
            groupBox_wheels.Location = new Point(12, 412);
            groupBox_wheels.Name = "groupBox_wheels";
            groupBox_wheels.Size = new Size(226, 81);
            groupBox_wheels.TabIndex = 59;
            groupBox_wheels.TabStop = false;
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Location = new Point(8, 48);
            label36.Name = "label36";
            label36.Size = new Size(33, 13);
            label36.TabIndex = 64;
            label36.Text = "Tyres";
            // 
            // tb_FrTyre
            // 
            tb_FrTyre.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tb_FrTyre.Location = new Point(108, 45);
            tb_FrTyre.Name = "tb_FrTyre";
            tb_FrTyre.Size = new Size(53, 20);
            tb_FrTyre.TabIndex = 2;
            // 
            // tb_RrTyre
            // 
            tb_RrTyre.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tb_RrTyre.Location = new Point(167, 45);
            tb_RrTyre.Name = "tb_RrTyre";
            tb_RrTyre.Size = new Size(53, 20);
            tb_RrTyre.TabIndex = 3;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new Point(8, 22);
            label35.Name = "label35";
            label35.Size = new Size(30, 13);
            label35.TabIndex = 61;
            label35.Text = "Rims";
            // 
            // tb_frRim
            // 
            tb_frRim.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tb_frRim.Location = new Point(108, 19);
            tb_frRim.Name = "tb_frRim";
            tb_frRim.Size = new Size(53, 20);
            tb_frRim.TabIndex = 0;
            // 
            // tb_RrRim
            // 
            tb_RrRim.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tb_RrRim.Location = new Point(167, 19);
            tb_RrRim.Name = "tb_RrRim";
            tb_RrRim.Size = new Size(53, 20);
            tb_RrRim.TabIndex = 1;
            // 
            // timer_0
            // 
            timer_0.Enabled = true;
            timer_0.Interval = 250;
            timer_0.Tick += new EventHandler(timer_0_Tick);
            // 
            // SetUp
            // 
            AcceptButton = button_OK;
            BackColor = Color.MintCream;
            CancelButton = button_Cancel;
            ClientSize = new Size(660, 609);
            Controls.Add(groupBox_wheels);
            Controls.Add(groupBox_Sheet);
            Controls.Add(button_Cancel);
            Controls.Add(button_OK);
            Controls.Add(groupBox_Other);
            Controls.Add(groupBox_LSD);
            Controls.Add(groupBox_Suspension);
            Controls.Add(groupBox_General);
            Controls.Add(groupBox_Gears);
            MaximizeBox = false;
            Name = "SetUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tune Sheet";
            groupBox_Gears.ResumeLayout(false);
            groupBox_Gears.PerformLayout();
            ((ISupportInitialize)(pictureBox_gear)).EndInit();
            groupBox_General.ResumeLayout(false);
            groupBox_General.PerformLayout();
            groupBox_Suspension.ResumeLayout(false);
            groupBox_Suspension.PerformLayout();
            groupBox_LSD.ResumeLayout(false);
            groupBox_LSD.PerformLayout();
            groupBox_Other.ResumeLayout(false);
            groupBox_Other.PerformLayout();
            groupBox_Sheet.ResumeLayout(false);
            groupBox_Sheet.PerformLayout();
            groupBox_wheels.ResumeLayout(false);
            groupBox_wheels.PerformLayout();
            ResumeLayout(false);

        }

        private Car method_0()
        {
            return _currentCar;
        }

        private void method_1(Car gclass0_1)
        {
            _currentCar = gclass0_1;
        }

        public CarParameterBlob method_2()
        {
            return _blob1;
        }

        public void method_3(CarParameterBlob gclass1_3)
        {
            _blob1 = gclass1_3;
        }

        public CarParameterBlob method_4()
        {
            return _blob2;
        }

        public void method_5(CarParameterBlob gclass1_3)
        {
            _blob2 = gclass1_3;
        }

        public CarParameterBlob method_6()
        {
            return _blob3;
        }

        public void method_7(CarParameterBlob gclass1_3)
        {
            _blob3 = gclass1_3;
        }

        private byte method_8()
        {
            return byte_0;
        }

        private void method_9(byte byte_1)
        {
            byte_0 = byte_1;
        }

        public void method_10(CarParameterBlob blob)
        {
            try
            {
                tb_rev.Text = blob.GearRev().ToString(CultureInfo.InvariantCulture);
                tb_1.Text = blob.G1().ToString(CultureInfo.InvariantCulture);
                tb_2.Text = blob.G2().ToString(CultureInfo.InvariantCulture);
                tb_3.Text = blob.G3().ToString(CultureInfo.InvariantCulture);
                tb_4.Text = blob.G4().ToString(CultureInfo.InvariantCulture);
                tb_5.Text = blob.G5().ToString(CultureInfo.InvariantCulture);
                tb_6.Text = blob.G6().ToString(CultureInfo.InvariantCulture);
                tb_7.Text = blob.G7().ToString(CultureInfo.InvariantCulture);
                tb_8.Text = blob.G8().ToString(CultureInfo.InvariantCulture);
                tb_9.Text = blob.G9().ToString(CultureInfo.InvariantCulture);
                tb_10.Text = blob.G10().ToString(CultureInfo.InvariantCulture);
                tb_11.Text = blob.G11().ToString(CultureInfo.InvariantCulture);
                tb_final.Text = blob.GFinal().ToString(CultureInfo.InvariantCulture);
                tb_metres.Text = blob.Metres().ToString(CultureInfo.InvariantCulture);
                tb_oil.Text = blob.Oil().ToString(CultureInfo.InvariantCulture);
                tb_wash.Text = blob.Wash().ToString(CultureInfo.InvariantCulture);
                tb_changes.Text = blob.Changes().ToString(CultureInfo.InvariantCulture);
                tb_wins.Text = blob.Wins().ToString(CultureInfo.InvariantCulture);
                tb_camberf.Text = blob.CamberFront().ToString(CultureInfo.InvariantCulture);
                tb_camberr.Text = blob.CamberR().ToString(CultureInfo.InvariantCulture);
                tb_rhf.Text = blob.RideHeightF().ToString(CultureInfo.InvariantCulture);
                tb_rhr.Text = blob.RideHeightR().ToString(CultureInfo.InvariantCulture);
                tb_toef.Text = blob.ToeF().ToString(CultureInfo.InvariantCulture);
                tb_toer.Text = blob.ToeR().ToString(CultureInfo.InvariantCulture);
                tb_springf.Text = blob.SpringF().ToString(CultureInfo.InvariantCulture);
                tb_springr.Text = blob.SpringR().ToString(CultureInfo.InvariantCulture);
                tb_arbf.Text = blob.AntiRollBarF().ToString(CultureInfo.InvariantCulture);
                tb_arbr.Text = blob.AntiRollBarR().ToString(CultureInfo.InvariantCulture);
                tb_extf.Text = blob.ExtenF().ToString(CultureInfo.InvariantCulture);
                tb_extr.Text = blob.ExtenR().ToString(CultureInfo.InvariantCulture);
                tb_compf.Text = blob.CompF().ToString(CultureInfo.InvariantCulture);
                tb_compr.Text = blob.CompR().ToString(CultureInfo.InvariantCulture);
                tb_lsdinitf.Text = blob.LSDInitF().ToString(CultureInfo.InvariantCulture);
                tb_lsdinitr.Text = blob.LSDInitR().ToString(CultureInfo.InvariantCulture);
                tb_lsdaccf.Text = blob.LSDAccF().ToString(CultureInfo.InvariantCulture);
                tb_lsdaccr.Text = blob.LSDAccR().ToString(CultureInfo.InvariantCulture);
                tb_lsddecf.Text = blob.LSDDecF().ToString(CultureInfo.InvariantCulture);
                tb_lsddecr.Text = blob.LSDDecR().ToString(CultureInfo.InvariantCulture);
                tb_frTorque.Text = blob.FrTorque().ToString(CultureInfo.InvariantCulture);
                tb_ballastkg.Text = blob.BallastKg().ToString(CultureInfo.InvariantCulture);
                tb_ballastPos.Text = blob.BallastPos().ToString(CultureInfo.InvariantCulture);
                tb_BBf.Text = blob.BBF().ToString(CultureInfo.InvariantCulture);
                tb_BBr.Text = blob.BBR().ToString(CultureInfo.InvariantCulture);
                tb_DFf.Text = blob.DfF().ToString(CultureInfo.InvariantCulture);
                tb_DFr.Text = blob.DfR().ToString(CultureInfo.InvariantCulture);
                tb_grip.Text = blob.Grip().ToString(CultureInfo.InvariantCulture);
                tb_weight.Text = blob.Weight().ToString(CultureInfo.InvariantCulture);
                tb_bhp.Text = blob.Bhp().ToString(CultureInfo.InvariantCulture);
                tb_frRim.Text = blob.FrRim().ToString(CultureInfo.InvariantCulture);
                tb_RrRim.Text = blob.RrRim().ToString(CultureInfo.InvariantCulture);
                tb_FrTyre.Text = blob.FrTyre().ToString(CultureInfo.InvariantCulture);
                tb_RrTyre.Text = blob.RrTyre().ToString(CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
            }
        }

        public void method_11(CarParameterBlob blob)
        {
            try
            {
                blob.GearRev(uint.Parse(tb_rev.Text));
                blob.G1(uint.Parse(tb_1.Text));
                blob.method_25(uint.Parse(tb_2.Text));
                blob.method_27(uint.Parse(tb_3.Text));
                blob.G4(uint.Parse(tb_4.Text));
                blob.G5(uint.Parse(tb_5.Text));
                blob.G6(uint.Parse(tb_6.Text));
                blob.G7(uint.Parse(tb_7.Text));
                blob.method_37(uint.Parse(tb_8.Text));
                blob.G9(uint.Parse(tb_9.Text));
                blob.G10(uint.Parse(tb_10.Text));
                blob.G11(uint.Parse(tb_11.Text));
                blob.GFinal(uint.Parse(tb_final.Text));
                blob.Metres(uint.Parse(tb_metres.Text));
                blob.Oil(uint.Parse(tb_oil.Text));
                blob.Wash(uint.Parse(tb_wash.Text));
                blob.Changes(uint.Parse(tb_changes.Text));
                blob.Wins(uint.Parse(tb_wins.Text));
                blob.CamberFront(byte.Parse(tb_camberf.Text));
                blob.CamberR(byte.Parse(tb_camberr.Text));
                blob.RideHeightF(uint.Parse(tb_rhf.Text));
                blob.RideHeightR(uint.Parse(tb_rhr.Text));
                blob.DfF(byte.Parse(tb_DFf.Text));
                blob.DfR(byte.Parse(tb_DFr.Text));
                blob.ToeF(sbyte.Parse(tb_toef.Text));
                blob.ToeR(sbyte.Parse(tb_toer.Text));
                blob.method_65(byte.Parse(tb_springf.Text));
                blob.method_67(byte.Parse(tb_springr.Text));
                blob.method_77(byte.Parse(tb_arbf.Text));
                blob.method_79(byte.Parse(tb_arbr.Text));
                blob.method_71(byte.Parse(tb_compf.Text));
                blob.method_75(byte.Parse(tb_compr.Text));
                blob.method_69(byte.Parse(tb_extf.Text));
                blob.method_73(byte.Parse(tb_extr.Text));
                blob.method_81(byte.Parse(tb_lsdinitf.Text));
                blob.method_83(byte.Parse(tb_lsdinitr.Text));
                blob.method_85(byte.Parse(tb_lsdaccf.Text));
                blob.method_87(byte.Parse(tb_lsdaccr.Text));
                blob.method_89(byte.Parse(tb_lsddecf.Text));
                blob.method_91(byte.Parse(tb_lsddecr.Text));
                blob.FrTorque(byte.Parse(tb_frTorque.Text));
                blob.method_93(byte.Parse(tb_ballastkg.Text));
                blob.method_95(sbyte.Parse(tb_ballastPos.Text));
                blob.method_97(byte.Parse(tb_BBf.Text));
                blob.method_99(byte.Parse(tb_BBr.Text));
                blob.method_113(byte.Parse(tb_grip.Text));
                blob.method_111(byte.Parse(tb_bhp.Text));
                blob.method_115(byte.Parse(tb_weight.Text));
                blob.FrTyre(byte.Parse(tb_FrTyre.Text));
                blob.RrTyre(byte.Parse(tb_RrTyre.Text));
                blob.method_107(byte.Parse(tb_frRim.Text));
                blob.method_109(byte.Parse(tb_RrRim.Text));
            }
            catch
            {
                var num = (int) MessageBox.Show(this, "Bad Input, Enter Whole Numbers in range{0,256}.\nGears & Ride Height, {0,65536}\nToe, {-128,127}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public static void smethod_0(byte[] byte_1, uint uint_0, byte byte_2)
        {
            byte_1[ uint_0] = byte_2;
        }

        public static void smethod_1(byte[] byte_1, uint uint_0, sbyte sbyte_0)
        {
            byte_1[ uint_0] = (byte) sbyte_0;
        }

        public static void smethod_2(byte[] byte_1, uint uint_0, uint uint_1, uint uint_2)
        {
            switch (uint_1)
            {
                case 2U:
                    byte_1[ uint_0] = (byte) (uint_2 >> 8 & byte.MaxValue);
                    byte_1[ (uint_0 + 1U)] = (byte) (uint_2 & byte.MaxValue);
                    break;
                case 4U:
                    byte_1[ uint_0] = (byte) (uint_2 >> 24 & byte.MaxValue);
                    byte_1[ (uint_0 + 1U)] = (byte) (uint_2 >> 16 & byte.MaxValue);
                    byte_1[ (uint_0 + 2U)] = (byte) (uint_2 >> 8 & byte.MaxValue);
                    byte_1[ (uint_0 + 3U)] = (byte) (uint_2 & byte.MaxValue);
                    break;
            }
        }

        public static void smethod_3(byte[] byte_1, CarParameterBlob gclass1_3)
        {
            smethod_2(byte_1, 37U, 4U, gclass1_3.Metres());
            smethod_2(byte_1, 41U, 4U, gclass1_3.Wash());
            smethod_2(byte_1, 49U, 4U, gclass1_3.Oil());
            smethod_2(byte_1, 65U, 2U, gclass1_3.Changes());
            smethod_2(byte_1, 67U, 2U, gclass1_3.Wins());
            smethod_2(byte_1, 77U, 4U, gclass1_3.Paint());
            smethod_2(byte_1, 157U, 4U, gclass1_3.Body());
            smethod_0(byte_1, 169U, gclass1_3.Colour());
            smethod_0(byte_1, 173U, gclass1_3.FrRim());
            smethod_0(byte_1, 177U, gclass1_3.RrRim());
            smethod_0(byte_1, 185U, gclass1_3.FrTyre());
            smethod_0(byte_1, 193U, gclass1_3.RrTyre());
            smethod_2(byte_1, 194U, 4U, gclass1_3.Brakes());
            smethod_2(byte_1, 198U, 4U, gclass1_3._198_201());
            smethod_2(byte_1, 202U, 4U, gclass1_3.Chassis());
            smethod_2(byte_1, 206U, 4U, gclass1_3.Engine());
            smethod_2(byte_1, 210U, 4U, gclass1_3.DriveTrain());
            smethod_2(byte_1, 214U, 4U, gclass1_3.Transmission());
            smethod_2(byte_1, 218U, 4U, gclass1_3.Suspension());
            smethod_2(byte_1, 222U, 4U, gclass1_3.LSD());
            smethod_2(byte_1, 226U, 4U, gclass1_3.method_134());
            smethod_2(byte_1, 230U, 4U, gclass1_3.WReduction());
            smethod_2(byte_1, 234U, 4U, gclass1_3.method_138());
            smethod_2(byte_1, 238U, 4U, gclass1_3.method_140());
            smethod_2(byte_1, 242U, 4U, gclass1_3.ECU());
            smethod_2(byte_1, 246U, 4U, gclass1_3.EngineTune());
            smethod_2(byte_1, 250U, 4U, gclass1_3.Turbo());
            smethod_2(byte_1, 254U, 4U, gclass1_3.Flywheel());
            smethod_2(byte_1, 258U, 4U, gclass1_3.Clutch());
            smethod_2(byte_1, 262U, 4U, gclass1_3.Driveshaft());
            smethod_2(byte_1, 266U, 4U, gclass1_3.Exhaust());
            smethod_2(byte_1, 270U, 4U, gclass1_3.method_156());
            smethod_2(byte_1, 274U, 4U, gclass1_3.ASM());
            smethod_2(byte_1, 278U, 4U, gclass1_3.TCS());
            smethod_2(byte_1, 282U, 4U, gclass1_3.method_162());
            smethod_2(byte_1, 286U, 4U, gclass1_3.Supercharger());
            smethod_2(byte_1, 290U, 4U, gclass1_3.Intake());
            smethod_2(byte_1, 294U, 4U, gclass1_3.ExhaustManifold());
            smethod_2(byte_1, 298U, 4U, gclass1_3.CatConverter());
            smethod_2(byte_1, 302U, 4U, gclass1_3.AirFilter());
            smethod_2(byte_1, 306U, 4U, gclass1_3.method_174());
            smethod_2(byte_1, 310U, 4U, gclass1_3.WindowWR());
            smethod_2(byte_1, 314U, 4U, gclass1_3.Hood());
            smethod_2(byte_1, 318U, 4U, gclass1_3.FrBumper());
            smethod_2(byte_1, 322U, 4U, gclass1_3.RrBumper());
            smethod_2(byte_1, 326U, 4U, gclass1_3.Extension());
            smethod_2(byte_1, 330U, 4U, gclass1_3.Wing());
            smethod_2(byte_1, 334U, 4U, gclass1_3.method_188());
            smethod_2(byte_1, 338U, 4U, gclass1_3.Reinforcement());
            smethod_2(byte_1, 342U, 4U, gclass1_3.Nos());
            smethod_2(byte_1, 346U, 2U, gclass1_3.GearRev());
            smethod_2(byte_1, 348U, 2U, gclass1_3.G1());
            smethod_2(byte_1, 350U, 2U, gclass1_3.G2());
            smethod_2(byte_1, 352U, 2U, gclass1_3.G3());
            smethod_2(byte_1, 354U, 2U, gclass1_3.G4());
            smethod_2(byte_1, 356U, 2U, gclass1_3.G5());
            smethod_2(byte_1, 358U, 2U, gclass1_3.G6());
            smethod_2(byte_1, 360U, 2U, gclass1_3.G7());
            smethod_2(byte_1, 362U, 2U, gclass1_3.G8());
            smethod_2(byte_1, 364U, 2U, gclass1_3.G9());
            smethod_2(byte_1, 366U, 2U, gclass1_3.G10());
            smethod_2(byte_1, 368U, 2U, gclass1_3.G11());
            smethod_2(byte_1, 370U, 2U, gclass1_3.GFinal());
            smethod_0(byte_1, 375U, gclass1_3.FrTorque());
            smethod_0(byte_1, 378U, gclass1_3.DfF());
            smethod_0(byte_1, 379U, gclass1_3.DfR());
            smethod_0(byte_1, 386U, gclass1_3.CamberFront());
            smethod_0(byte_1, 387U, gclass1_3.CamberR());
            smethod_2(byte_1, 388U, 2U, gclass1_3.RideHeightF());
            smethod_2(byte_1, 390U, 2U, gclass1_3.RideHeightR());
            smethod_1(byte_1, 392U, gclass1_3.ToeF());
            smethod_1(byte_1, 393U, gclass1_3.ToeR());
            smethod_0(byte_1, 394U, gclass1_3.SpringF());
            smethod_0(byte_1, 395U, gclass1_3.SpringR());
            smethod_0(byte_1, 398U, gclass1_3.ExtenF());
            smethod_0(byte_1, 399U, gclass1_3.ExtenF());
            smethod_0(byte_1, 400U, gclass1_3.CompF());
            smethod_0(byte_1, 401U, gclass1_3.CompF());
            smethod_0(byte_1, 402U, gclass1_3.ExtenR());
            smethod_0(byte_1, 403U, gclass1_3.ExtenR());
            smethod_0(byte_1, 404U, gclass1_3.CompR());
            smethod_0(byte_1, 405U, gclass1_3.CompR());
            smethod_0(byte_1, 406U, gclass1_3.AntiRollBarF());
            smethod_0(byte_1, 407U, gclass1_3.AntiRollBarR());
            smethod_0(byte_1, 408U, gclass1_3.LSDInitF());
            smethod_0(byte_1, 409U, gclass1_3.LSDInitR());
            smethod_0(byte_1, 410U, gclass1_3.LSDAccF());
            smethod_0(byte_1, 411U, gclass1_3.LSDAccR());
            smethod_0(byte_1, 412U, gclass1_3.LSDDecF());
            smethod_0(byte_1, 413U, gclass1_3.LSDDecR());
            smethod_0(byte_1, 419U, gclass1_3.BallastKg());
            smethod_1(byte_1, 420U, gclass1_3.BallastPos());
            smethod_0(byte_1, 431U, gclass1_3.Grip());
            smethod_0(byte_1, 432U, gclass1_3.BBF());
            smethod_0(byte_1, 433U, gclass1_3.BBR());
            smethod_0(byte_1, 422U, gclass1_3.Bhp());
            smethod_0(byte_1, 425U, gclass1_3.Weight());
            smethod_2(byte_1, 94U, 4U, uint.MaxValue);
            smethod_2(byte_1, 98U, 2U, ushort.MaxValue);
            smethod_0(byte_1, 100U, byte.MaxValue);
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            try
            {
                switch (method_8())
                {
                    case 1:
                        method_11(method_2());
                        smethod_3(method_2().FullBlob(), method_2());
                        break;
                    case 2:
                        method_11(method_4());
                        smethod_3(method_4().FullBlob(), method_4());
                        break;
                    case 3:
                        method_11(method_6());
                        smethod_3(method_6().FullBlob(), method_6());
                        break;
                }
                Close();
            }
            catch
            {
            }
        }

        private void button_Go_Click(object sender, EventArgs e)
        {
            try
            {
                switch (method_8())
                {
                    case 1:
                        method_11(method_2());
                        smethod_3(method_2().FullBlob(), method_2());
                        break;
                    case 2:
                        method_11(method_4());
                        smethod_3(method_4().FullBlob(), method_4());
                        break;
                    case 3:
                        method_11(method_6());
                        smethod_3(method_6().FullBlob(), method_6());
                        break;
                }
                if (radioButton_A.Checked)
                {
                    method_9(1);
                    method_10(method_0().GetBlob1());
                }
                else if (radioButton_B.Checked)
                {
                    method_9(2);
                    method_10(method_0().GetBlob2());
                }
                else
                {
                    if (!radioButton_C.Checked)
                        return;
                    method_9(3);
                    method_10(method_0().GetBlob3());
                }
            }
            catch
            {
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox_gear_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                var numArray1 = new double[13]
                {
                    double.Parse(tb_rev.Text),
                    double.Parse(tb_1.Text),
                    double.Parse(tb_2.Text),
                    double.Parse(tb_3.Text),
                    double.Parse(tb_4.Text),
                    double.Parse(tb_5.Text),
                    double.Parse(tb_6.Text),
                    double.Parse(tb_7.Text),
                    double.Parse(tb_8.Text),
                    double.Parse(tb_9.Text),
                    double.Parse(tb_10.Text),
                    double.Parse(tb_11.Text),
                    double.Parse(tb_final.Text)
                };
                if (numArray1[1] < numArray1[2] || numArray1[2] < numArray1[3] || (numArray1[3] < numArray1[4] || numArray1[4] < numArray1[5]) || (numArray1[5] < numArray1[6] || numArray1[6] < numArray1[7] || (numArray1[7] < numArray1[8] || numArray1[8] < numArray1[9])) || (numArray1[9] < numArray1[10] || numArray1[10] < numArray1[11]))
                    return;
                var numArray2 = new double[11];
                var num1 = 11.0;
                numArray2[0] = double.Parse(method_0().GetRpm()) * num1 / (numArray1[1] / 1000.0 * numArray1[12] / 1000.0 * 88.0);
                numArray2[1] = double.Parse(method_0().GetRpm()) * num1 / (numArray1[2] / 1000.0 * numArray1[12] / 1000.0 * 88.0);
                numArray2[2] = double.Parse(method_0().GetRpm()) * num1 / (numArray1[3] / 1000.0 * numArray1[12] / 1000.0 * 88.0);
                numArray2[3] = double.Parse(method_0().GetRpm()) * num1 / (numArray1[4] / 1000.0 * numArray1[12] / 1000.0 * 88.0);
                numArray2[4] = double.Parse(method_0().GetRpm()) * num1 / (numArray1[5] / 1000.0 * numArray1[12] / 1000.0 * 88.0);
                numArray2[5] = double.Parse(method_0().GetRpm()) * num1 / (numArray1[6] / 1000.0 * numArray1[12] / 1000.0 * 88.0);
                numArray2[6] = double.Parse(method_0().GetRpm()) * num1 / (numArray1[7] / 1000.0 * numArray1[12] / 1000.0 * 88.0);
                numArray2[7] = double.Parse(method_0().GetRpm()) * num1 / (numArray1[8] / 1000.0 * numArray1[12] / 1000.0 * 88.0);
                numArray2[8] = double.Parse(method_0().GetRpm()) * num1 / (numArray1[9] / 1000.0 * numArray1[12] / 1000.0 * 88.0);
                numArray2[9] = double.Parse(method_0().GetRpm()) * num1 / (numArray1[10] / 1000.0 * numArray1[12] / 1000.0 * 88.0);
                numArray2[10] = double.Parse(method_0().GetRpm()) * num1 / (numArray1[11] / 1000.0 * numArray1[12] / 1000.0 * 88.0);
                var num2 = 0;
                foreach (var num3 in numArray2)
                {
                    if (num3 > 1.0 && num3 < 5000.0)
                        ++num2;
                    else
                        break;
                }
                var pt1 = new Point(0, 212);
                var pt2 = new Point((int) numArray2[0], 15);
                graphics_0.Clear(Color.White);
                graphics_0.DrawLine(Pens.Black, pt1, pt2);
                var pointArray = new Point[11, 3];
                for (var index = 0; index < num2; ++index)
                {
                    pt2.X = (int) numArray2[index];
                    graphics_0.DrawLine(Pens.Black, pt1, pt2);
                    var point1 = new Point(pt2.X + 1, pt2.Y);
                    var point2 = new Point(pt2.X, 212);
                    var point3 = new Point(1, 213);
                    pointArray[index, 0] = point1;
                    pointArray[index, 1] = point2;
                    pointArray[index, 2] = point3;
                }
                for (var index = 0; index < num2; ++index)
                    graphics_0.FillPolygon(Brushes.White, new Point[3]
                    {
                        pointArray[index, 0],
                        pointArray[index, 1],
                        pointArray[index, 2]
                    });
                graphics_0.FillRectangle(Brushes.White, 0, 138, 5000, 5000);
                graphics_0.DrawLine(Pens.Red, new Point(0, 15), new Point(5000, 15));
                graphics_0.DrawString(method_0().GetRpm() + " r·min⁻\x00B9", new Font("Arial", 8f), Brushes.Red, new PointF(2f, 2f));
                if (num2 <= 0)
                    return;
                tb_Max.Text = numArray2[num2 - 1].ToString("N");
            }
            catch
            {
            }
        }

        private void timer_0_Tick(object sender, EventArgs e)
        {
            pictureBox_gear.Invalidate();
        }
    }
}
