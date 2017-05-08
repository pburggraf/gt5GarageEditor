using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GT5_Garage_Editor
{
    partial class FormMain
    {
        private Panel panel_main;
        private TabControl tabControl_garage;
        private TabPage tabPage_garage;
        private MenuStrip menuStrip_main;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openGarageToolStripMenuItem;
        private ToolStripMenuItem closeGarageToolStripMenuItem;
        private ToolStripMenuItem fillGarageToolStripMenuItem;
        private ToolStripMenuItem sourceTuneToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Label label6;
        private TextBox textBox_DCountry;
        private TextBox textBox_DDT;
        private TextBox textBox_DYear;
        private ComboBox comboBox_DModel;
        private ComboBox comboBox_DMake;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private GroupBox groupBox_Sheet;
        private RadioButton radioButton_C;
        private RadioButton radioButton_B;
        private RadioButton radioButton_A;
        private TabPage tabPage_gift;
        private ComboBox comboBox_category_name;
        private GroupBox groupBox_gift_tuneitems;
        private Button button_gift_tune_add;
        private ComboBox comboBox_gameitem_id;
        private TabPage tabPage_Adv;
        private ComboBox comboBox_func_make;
        private GroupBox groupBox_func_basic;
        private ComboBox comboBox_func_edit;
        private Label label8;
        private Label label7;
        private Button button_func_conf;
        private Label label9;
        private TextBox tb_func_withvalue;
        private ListBox listBox_func_basic;
        private BackgroundWorker backgroundWorker_0;
        private CheckBox cb_c;
        private CheckBox cb_b;
        private CheckBox cb_a;
        private Label label10;
        private ToolTip toolTip_0;
        private DataGridView dataGridView_Dest;
        private DataGridViewTextBoxColumn Column_ItemD;
        private DataGridViewTextBoxColumn Column_ValueD;
        private TabPage tabPage_spec;
        private GroupBox groupBox1;
        private Button button_gift_preset;
        private ComboBox comboBox_gift_preset;
        private GroupBox groupBox2;
        private ComboBox comboBox__gift_paintCat;
        private Button button_gift_paintAdd;
        private ComboBox comboBox_gift_paintNum;
        private Button button1;
        private ComboBox comboBox1;
        private GroupBox groupBox_spec_main;
        private ComboBox comboBox_spec_LeveLA;
        private Label label12;
        private Label label11;
        private TextBox textBox_Credits;
        private ComboBox comboBox_spec_LevelB;
        private Label label13;
        private Button button_Credits;
        private Button button_ASpec;
        private Button button_BSpec;
        private GroupBox groupBox3;
        private Label label14;
        private RadioButton radioButton_secretOff;
        private RadioButton radioButton_secretOn;
        private Button button_secret;
        private GroupBox groupBox6;
        private ComboBox comboBox_tickets;
        private Button button_carTicket;
        private ToolStripMenuItem paToolStripMenuItem;
        private TabPage tabPage2;
        private GroupBox groupBox7;
        private GroupBox groupBox8;
        private Label label16;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private TextBox textBox1;
        private Label label17;
        private TextBox textBox2;
        private Label label18;
        private TextBox textBox3;
        private Label label19;
        private GroupBox groupBox9;
        private ComboBox comboBox4;
        private GroupBox groupBox10;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private ComboBox comboBox5;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label20;
        private TextBox textBox6;
        private Label label21;
        private Label label22;
        private TabPage tabPage3;
        private GroupBox groupBox11;
        private ComboBox comboBox6;
        private Button button2;
        private GroupBox groupBox12;
        private ComboBox comboBox7;
        private Button button3;
        private ComboBox comboBox8;
        private GroupBox groupBox13;
        private ComboBox comboBox9;
        private Button button4;
        private ComboBox comboBox10;
        private TabPage tabPage4;
        private GroupBox groupBox14;
        private Label label23;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private ListBox listBox1;
        private Button button5;
        private Label label24;
        private TextBox textBox7;
        private ComboBox comboBox11;
        private Label label25;
        private Label label26;
        private ComboBox comboBox12;
        private TabPage tabPage5;
        private GroupBox groupBox15;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private Button button6;
        private Label label27;
        private Button button7;
        private Button button8;
        private Button button9;
        private ComboBox comboBox13;
        private Label label28;
        private ComboBox comboBox14;
        private Label label29;
        private Label label30;
        private TextBox textBox8;
        private GroupBox groupBox16;
        private Button button10;
        private ComboBox comboBox15;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private Label label15;
        private ComboBox comboBox_SMake;
        private ComboBox comboBox_SModel;
        private DataGridView dataGridView_Source;
        private DataGridViewTextBoxColumn Column_Item;
        private DataGridViewTextBoxColumn Column_Value;
        private TextBox textBox_SYear;
        private Label label5;
        private TextBox textBox_SDT;
        private Label label4;
        private TextBox textBox_SCountry;
        private Label label3;
        private GroupBox groupBox18;
        private Label label31;
        private ComboBox comboBox16;
        private ComboBox comboBox17;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private TextBox textBox9;
        private Label label32;
        private TextBox textBox10;
        private Label label33;
        private TextBox textBox11;
        private Label label34;
        private TabPage tabPage_ridingCar;
        private Button button11;
        private Button button_apply_gamedays;
        private Label label35;
        private TextBox textBox_gamedays;
        private Button button_apply_used_car_day;
        private Label label36;
        private TextBox textBox_used_car_day;
        private Button bt_course_avail;
        private Button button_car_avail;
        private TextBox tb_course_avail;
        private Label label38;
        private TextBox tb_car_avail;
        private Label label37;
        private Button btn_creditcap;
        private Label label39;
        private TextBox tb_creditcap;
        private RadioButton rb_textdebug_off;
        private RadioButton rb_txtdebug_on;
        private Button btn_text_debug;
        private Label label42;
        private Button btn_bspecwins;
        private Button btn_aspecwins;
        private TextBox tb_bspec_wins;
        private Label label40;
        private TextBox tb_aspec_wins;
        private Label label41;
        private Panel panel1;
        private GroupBox groupBox17;
        private ComboBox cB_insert_colour;
        private ComboBox cB_insert_tuner;
        private ComboBox cB_insert_model;
        private PictureBox pictureBox_thumb;
        private Button btn_Insert_Car_Ticket;
        private Label label43;
        private Button btn_gift_paintBy10;
        private Button btn_gift_tune_give10;
        private Button btn_Year_tickets_give10;
        private GroupBox groupBox19;
        private TextBox tB_Name_New;
        private ComboBox cB_Name_Model;
        private ComboBox cB_Name_Make;
        private Button btn_name_change;
        private GroupBox groupBox20;
        private Button btn_special_insert;
        private ComboBox cB_special_car;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private GroupBox groupBox22;
        private ComboBox cB_itemControl;
        private Button button_delete_item;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_main = new System.Windows.Forms.Panel();
            this.tabControl_garage = new System.Windows.Forms.TabControl();
            this.tabPage_spec = new System.Windows.Forms.TabPage();
            this.groupBox_spec_main = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rb_txtdebug_on = new System.Windows.Forms.RadioButton();
            this.rb_textdebug_off = new System.Windows.Forms.RadioButton();
            this.btn_text_debug = new System.Windows.Forms.Button();
            this.label42 = new System.Windows.Forms.Label();
            this.btn_bspecwins = new System.Windows.Forms.Button();
            this.btn_aspecwins = new System.Windows.Forms.Button();
            this.tb_bspec_wins = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.tb_aspec_wins = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.btn_creditcap = new System.Windows.Forms.Button();
            this.label39 = new System.Windows.Forms.Label();
            this.tb_creditcap = new System.Windows.Forms.TextBox();
            this.bt_course_avail = new System.Windows.Forms.Button();
            this.button_car_avail = new System.Windows.Forms.Button();
            this.tb_course_avail = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.tb_car_avail = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.button_apply_used_car_day = new System.Windows.Forms.Button();
            this.label36 = new System.Windows.Forms.Label();
            this.textBox_used_car_day = new System.Windows.Forms.TextBox();
            this.button_apply_gamedays = new System.Windows.Forms.Button();
            this.label35 = new System.Windows.Forms.Label();
            this.textBox_gamedays = new System.Windows.Forms.TextBox();
            this.radioButton_secretOff = new System.Windows.Forms.RadioButton();
            this.radioButton_secretOn = new System.Windows.Forms.RadioButton();
            this.button_secret = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.button_BSpec = new System.Windows.Forms.Button();
            this.button_ASpec = new System.Windows.Forms.Button();
            this.button_Credits = new System.Windows.Forms.Button();
            this.comboBox_spec_LevelB = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox_spec_LeveLA = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_Credits = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_gift_preset = new System.Windows.Forms.Button();
            this.comboBox_gift_preset = new System.Windows.Forms.ComboBox();
            this.tabPage_garage = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox_SMake = new System.Windows.Forms.ComboBox();
            this.comboBox_SModel = new System.Windows.Forms.ComboBox();
            this.dataGridView_Source = new System.Windows.Forms.DataGridView();
            this.Column_Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox_SYear = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_SDT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_SCountry = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox_DMake = new System.Windows.Forms.ComboBox();
            this.groupBox_Sheet = new System.Windows.Forms.GroupBox();
            this.radioButton_C = new System.Windows.Forms.RadioButton();
            this.radioButton_B = new System.Windows.Forms.RadioButton();
            this.radioButton_A = new System.Windows.Forms.RadioButton();
            this.comboBox_DModel = new System.Windows.Forms.ComboBox();
            this.dataGridView_Dest = new System.Windows.Forms.DataGridView();
            this.Column_ItemD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_ValueD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox_DYear = new System.Windows.Forms.TextBox();
            this.textBox_DDT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_DCountry = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage_ridingCar = new System.Windows.Forms.TabPage();
            this.button11 = new System.Windows.Forms.Button();
            this.tabPage_gift = new System.Windows.Forms.TabPage();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.button_delete_item = new System.Windows.Forms.Button();
            this.cB_itemControl = new System.Windows.Forms.ComboBox();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.btn_special_insert = new System.Windows.Forms.Button();
            this.cB_special_car = new System.Windows.Forms.ComboBox();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.btn_Insert_Car_Ticket = new System.Windows.Forms.Button();
            this.label43 = new System.Windows.Forms.Label();
            this.pictureBox_thumb = new System.Windows.Forms.PictureBox();
            this.cB_insert_colour = new System.Windows.Forms.ComboBox();
            this.cB_insert_tuner = new System.Windows.Forms.ComboBox();
            this.cB_insert_model = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btn_Year_tickets_give10 = new System.Windows.Forms.Button();
            this.comboBox_tickets = new System.Windows.Forms.ComboBox();
            this.button_carTicket = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_gift_paintBy10 = new System.Windows.Forms.Button();
            this.comboBox__gift_paintCat = new System.Windows.Forms.ComboBox();
            this.button_gift_paintAdd = new System.Windows.Forms.Button();
            this.comboBox_gift_paintNum = new System.Windows.Forms.ComboBox();
            this.groupBox_gift_tuneitems = new System.Windows.Forms.GroupBox();
            this.btn_gift_tune_give10 = new System.Windows.Forms.Button();
            this.comboBox_category_name = new System.Windows.Forms.ComboBox();
            this.button_gift_tune_add = new System.Windows.Forms.Button();
            this.comboBox_gameitem_id = new System.Windows.Forms.ComboBox();
            this.tabPage_Adv = new System.Windows.Forms.TabPage();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.btn_name_change = new System.Windows.Forms.Button();
            this.tB_Name_New = new System.Windows.Forms.TextBox();
            this.cB_Name_Model = new System.Windows.Forms.ComboBox();
            this.cB_Name_Make = new System.Windows.Forms.ComboBox();
            this.groupBox_func_basic = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_c = new System.Windows.Forms.CheckBox();
            this.cb_b = new System.Windows.Forms.CheckBox();
            this.cb_a = new System.Windows.Forms.CheckBox();
            this.listBox_func_basic = new System.Windows.Forms.ListBox();
            this.button_func_conf = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_func_withvalue = new System.Windows.Forms.TextBox();
            this.comboBox_func_edit = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_func_make = new System.Windows.Forms.ComboBox();
            this.menuStrip_main = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openGarageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeGarageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fillGarageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceTuneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker_0 = new System.ComponentModel.BackgroundWorker();
            this.toolTip_0 = new System.Windows.Forms.ToolTip(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.comboBox12 = new System.Windows.Forms.ComboBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.comboBox15 = new System.Windows.Forms.ComboBox();
            this.comboBox16 = new System.Windows.Forms.ComboBox();
            this.comboBox17 = new System.Windows.Forms.ComboBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.paToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.button6 = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.comboBox13 = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.comboBox14 = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.button10 = new System.Windows.Forms.Button();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.label31 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.panel_main.SuspendLayout();
            this.tabControl_garage.SuspendLayout();
            this.tabPage_spec.SuspendLayout();
            this.groupBox_spec_main.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage_garage.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Source)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox_Sheet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Dest)).BeginInit();
            this.tabPage_ridingCar.SuspendLayout();
            this.tabPage_gift.SuspendLayout();
            this.groupBox22.SuspendLayout();
            this.groupBox20.SuspendLayout();
            this.groupBox17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_thumb)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox_gift_tuneitems.SuspendLayout();
            this.tabPage_Adv.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.groupBox_func_basic.SuspendLayout();
            this.menuStrip_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.tabControl_garage);
            this.panel_main.Controls.Add(this.menuStrip_main);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(688, 588);
            this.panel_main.TabIndex = 0;
            // 
            // tabControl_garage
            // 
            this.tabControl_garage.Controls.Add(this.tabPage_spec);
            this.tabControl_garage.Controls.Add(this.tabPage_garage);
            this.tabControl_garage.Controls.Add(this.tabPage_ridingCar);
            this.tabControl_garage.Controls.Add(this.tabPage_gift);
            this.tabControl_garage.Controls.Add(this.tabPage_Adv);
            this.tabControl_garage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_garage.Enabled = false;
            this.tabControl_garage.Location = new System.Drawing.Point(0, 24);
            this.tabControl_garage.Name = "tabControl_garage";
            this.tabControl_garage.SelectedIndex = 0;
            this.tabControl_garage.Size = new System.Drawing.Size(688, 564);
            this.tabControl_garage.TabIndex = 0;
            this.tabControl_garage.Enter += new System.EventHandler(this.tabControl_garage_Enter);
            // 
            // tabPage_spec
            // 
            this.tabPage_spec.BackColor = System.Drawing.Color.White;
            this.tabPage_spec.Controls.Add(this.groupBox_spec_main);
            this.tabPage_spec.Controls.Add(this.groupBox1);
            this.tabPage_spec.Location = new System.Drawing.Point(4, 22);
            this.tabPage_spec.Name = "tabPage_spec";
            this.tabPage_spec.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_spec.Size = new System.Drawing.Size(680, 538);
            this.tabPage_spec.TabIndex = 3;
            this.tabPage_spec.Text = "Global";
            this.tabPage_spec.UseVisualStyleBackColor = true;
            // 
            // groupBox_spec_main
            // 
            this.groupBox_spec_main.Controls.Add(this.panel1);
            this.groupBox_spec_main.Controls.Add(this.btn_text_debug);
            this.groupBox_spec_main.Controls.Add(this.label42);
            this.groupBox_spec_main.Controls.Add(this.btn_bspecwins);
            this.groupBox_spec_main.Controls.Add(this.btn_aspecwins);
            this.groupBox_spec_main.Controls.Add(this.tb_bspec_wins);
            this.groupBox_spec_main.Controls.Add(this.label40);
            this.groupBox_spec_main.Controls.Add(this.tb_aspec_wins);
            this.groupBox_spec_main.Controls.Add(this.label41);
            this.groupBox_spec_main.Controls.Add(this.btn_creditcap);
            this.groupBox_spec_main.Controls.Add(this.label39);
            this.groupBox_spec_main.Controls.Add(this.tb_creditcap);
            this.groupBox_spec_main.Controls.Add(this.bt_course_avail);
            this.groupBox_spec_main.Controls.Add(this.button_car_avail);
            this.groupBox_spec_main.Controls.Add(this.tb_course_avail);
            this.groupBox_spec_main.Controls.Add(this.label38);
            this.groupBox_spec_main.Controls.Add(this.tb_car_avail);
            this.groupBox_spec_main.Controls.Add(this.label37);
            this.groupBox_spec_main.Controls.Add(this.button_apply_used_car_day);
            this.groupBox_spec_main.Controls.Add(this.label36);
            this.groupBox_spec_main.Controls.Add(this.textBox_used_car_day);
            this.groupBox_spec_main.Controls.Add(this.button_apply_gamedays);
            this.groupBox_spec_main.Controls.Add(this.label35);
            this.groupBox_spec_main.Controls.Add(this.textBox_gamedays);
            this.groupBox_spec_main.Controls.Add(this.radioButton_secretOff);
            this.groupBox_spec_main.Controls.Add(this.radioButton_secretOn);
            this.groupBox_spec_main.Controls.Add(this.button_secret);
            this.groupBox_spec_main.Controls.Add(this.label14);
            this.groupBox_spec_main.Controls.Add(this.button_BSpec);
            this.groupBox_spec_main.Controls.Add(this.button_ASpec);
            this.groupBox_spec_main.Controls.Add(this.button_Credits);
            this.groupBox_spec_main.Controls.Add(this.comboBox_spec_LevelB);
            this.groupBox_spec_main.Controls.Add(this.label13);
            this.groupBox_spec_main.Controls.Add(this.comboBox_spec_LeveLA);
            this.groupBox_spec_main.Controls.Add(this.label12);
            this.groupBox_spec_main.Controls.Add(this.label11);
            this.groupBox_spec_main.Controls.Add(this.textBox_Credits);
            this.groupBox_spec_main.Location = new System.Drawing.Point(5, 68);
            this.groupBox_spec_main.Name = "groupBox_spec_main";
            this.groupBox_spec_main.Size = new System.Drawing.Size(609, 348);
            this.groupBox_spec_main.TabIndex = 6;
            this.groupBox_spec_main.TabStop = false;
            this.groupBox_spec_main.Text = "Misc";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rb_txtdebug_on);
            this.panel1.Controls.Add(this.rb_textdebug_off);
            this.panel1.Location = new System.Drawing.Point(154, 313);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 20);
            this.panel1.TabIndex = 39;
            // 
            // rb_txtdebug_on
            // 
            this.rb_txtdebug_on.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rb_txtdebug_on.AutoSize = true;
            this.rb_txtdebug_on.Location = new System.Drawing.Point(0, 3);
            this.rb_txtdebug_on.Name = "rb_txtdebug_on";
            this.rb_txtdebug_on.Size = new System.Drawing.Size(39, 17);
            this.rb_txtdebug_on.TabIndex = 0;
            this.rb_txtdebug_on.TabStop = true;
            this.rb_txtdebug_on.Text = "On";
            this.toolTip_0.SetToolTip(this.rb_txtdebug_on, "Caution:\r\nYou can lock yourself out of GT-Life with this option");
            this.rb_txtdebug_on.UseVisualStyleBackColor = true;
            // 
            // rb_textdebug_off
            // 
            this.rb_textdebug_off.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rb_textdebug_off.AutoSize = true;
            this.rb_textdebug_off.Location = new System.Drawing.Point(61, 3);
            this.rb_textdebug_off.Name = "rb_textdebug_off";
            this.rb_textdebug_off.Size = new System.Drawing.Size(39, 17);
            this.rb_textdebug_off.TabIndex = 1;
            this.rb_textdebug_off.TabStop = true;
            this.rb_textdebug_off.Text = "Off";
            this.rb_textdebug_off.UseVisualStyleBackColor = true;
            // 
            // btn_text_debug
            // 
            this.btn_text_debug.Location = new System.Drawing.Point(260, 310);
            this.btn_text_debug.Name = "btn_text_debug";
            this.btn_text_debug.Size = new System.Drawing.Size(75, 23);
            this.btn_text_debug.TabIndex = 23;
            this.btn_text_debug.Text = "Apply";
            this.btn_text_debug.UseVisualStyleBackColor = true;
            this.btn_text_debug.Click += new System.EventHandler(this.btn_text_debug_Click);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(6, 316);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(63, 13);
            this.label42.TabIndex = 34;
            this.label42.Text = "Text Debug";
            // 
            // btn_bspecwins
            // 
            this.btn_bspecwins.Location = new System.Drawing.Point(260, 284);
            this.btn_bspecwins.Name = "btn_bspecwins";
            this.btn_bspecwins.Size = new System.Drawing.Size(75, 23);
            this.btn_bspecwins.TabIndex = 22;
            this.btn_bspecwins.Text = "Apply";
            this.btn_bspecwins.UseVisualStyleBackColor = true;
            this.btn_bspecwins.Click += new System.EventHandler(this.btn_bspecwins_Click);
            // 
            // btn_aspecwins
            // 
            this.btn_aspecwins.Location = new System.Drawing.Point(260, 259);
            this.btn_aspecwins.Name = "btn_aspecwins";
            this.btn_aspecwins.Size = new System.Drawing.Size(75, 23);
            this.btn_aspecwins.TabIndex = 20;
            this.btn_aspecwins.Text = "Apply";
            this.btn_aspecwins.UseVisualStyleBackColor = true;
            this.btn_aspecwins.Click += new System.EventHandler(this.btn_aspecwins_Click);
            // 
            // tb_bspec_wins
            // 
            this.tb_bspec_wins.Location = new System.Drawing.Point(154, 287);
            this.tb_bspec_wins.Name = "tb_bspec_wins";
            this.tb_bspec_wins.Size = new System.Drawing.Size(100, 20);
            this.tb_bspec_wins.TabIndex = 21;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(6, 290);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(96, 13);
            this.label40.TabIndex = 30;
            this.label40.Text = "Total B Spec Wins";
            // 
            // tb_aspec_wins
            // 
            this.tb_aspec_wins.Location = new System.Drawing.Point(154, 261);
            this.tb_aspec_wins.Name = "tb_aspec_wins";
            this.tb_aspec_wins.Size = new System.Drawing.Size(100, 20);
            this.tb_aspec_wins.TabIndex = 19;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(6, 264);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(96, 13);
            this.label41.TabIndex = 28;
            this.label41.Text = "Total A Spec Wins";
            // 
            // btn_creditcap
            // 
            this.btn_creditcap.Location = new System.Drawing.Point(260, 67);
            this.btn_creditcap.Name = "btn_creditcap";
            this.btn_creditcap.Size = new System.Drawing.Size(75, 23);
            this.btn_creditcap.TabIndex = 5;
            this.btn_creditcap.Text = "Apply";
            this.btn_creditcap.UseVisualStyleBackColor = true;
            this.btn_creditcap.Click += new System.EventHandler(this.btn_creditcap_Click);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(6, 72);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(56, 13);
            this.label39.TabIndex = 25;
            this.label39.Text = "Credit Cap";
            // 
            // tb_creditcap
            // 
            this.tb_creditcap.Location = new System.Drawing.Point(154, 69);
            this.tb_creditcap.Name = "tb_creditcap";
            this.tb_creditcap.Size = new System.Drawing.Size(100, 20);
            this.tb_creditcap.TabIndex = 4;
            // 
            // bt_course_avail
            // 
            this.bt_course_avail.Location = new System.Drawing.Point(260, 232);
            this.bt_course_avail.Name = "bt_course_avail";
            this.bt_course_avail.Size = new System.Drawing.Size(75, 23);
            this.bt_course_avail.TabIndex = 18;
            this.bt_course_avail.Text = "Apply";
            this.bt_course_avail.UseVisualStyleBackColor = true;
            this.bt_course_avail.Click += new System.EventHandler(this.bt_course_avail_Click);
            // 
            // button_car_avail
            // 
            this.button_car_avail.Location = new System.Drawing.Point(260, 207);
            this.button_car_avail.Name = "button_car_avail";
            this.button_car_avail.Size = new System.Drawing.Size(75, 23);
            this.button_car_avail.TabIndex = 16;
            this.button_car_avail.Text = "Apply";
            this.button_car_avail.UseVisualStyleBackColor = true;
            this.button_car_avail.Click += new System.EventHandler(this.button_car_avail_Click);
            // 
            // tb_course_avail
            // 
            this.tb_course_avail.Location = new System.Drawing.Point(154, 235);
            this.tb_course_avail.Name = "tb_course_avail";
            this.tb_course_avail.Size = new System.Drawing.Size(100, 20);
            this.tb_course_avail.TabIndex = 17;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(6, 238);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(86, 13);
            this.label38.TabIndex = 21;
            this.label38.Text = "Course Available";
            // 
            // tb_car_avail
            // 
            this.tb_car_avail.Location = new System.Drawing.Point(154, 209);
            this.tb_car_avail.Name = "tb_car_avail";
            this.tb_car_avail.Size = new System.Drawing.Size(100, 20);
            this.tb_car_avail.TabIndex = 15;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(6, 212);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(69, 13);
            this.label37.TabIndex = 19;
            this.label37.Text = "Car Available";
            // 
            // button_apply_used_car_day
            // 
            this.button_apply_used_car_day.Location = new System.Drawing.Point(260, 181);
            this.button_apply_used_car_day.Name = "button_apply_used_car_day";
            this.button_apply_used_car_day.Size = new System.Drawing.Size(75, 23);
            this.button_apply_used_car_day.TabIndex = 14;
            this.button_apply_used_car_day.Text = "Apply";
            this.button_apply_used_car_day.UseVisualStyleBackColor = true;
            this.button_apply_used_car_day.Click += new System.EventHandler(this.button_apply_used_car_day_Click);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(6, 186);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(95, 13);
            this.label36.TabIndex = 18;
            this.label36.Text = "Used Car Visit Day";
            // 
            // textBox_used_car_day
            // 
            this.textBox_used_car_day.Location = new System.Drawing.Point(154, 183);
            this.textBox_used_car_day.Name = "textBox_used_car_day";
            this.textBox_used_car_day.Size = new System.Drawing.Size(100, 20);
            this.textBox_used_car_day.TabIndex = 13;
            // 
            // button_apply_gamedays
            // 
            this.button_apply_gamedays.Location = new System.Drawing.Point(260, 15);
            this.button_apply_gamedays.Name = "button_apply_gamedays";
            this.button_apply_gamedays.Size = new System.Drawing.Size(75, 23);
            this.button_apply_gamedays.TabIndex = 1;
            this.button_apply_gamedays.Text = "Apply";
            this.button_apply_gamedays.UseVisualStyleBackColor = true;
            this.button_apply_gamedays.Click += new System.EventHandler(this.button_apply_gamedays_Click);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(6, 20);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(57, 13);
            this.label35.TabIndex = 15;
            this.label35.Text = "Gamedays";
            // 
            // textBox_gamedays
            // 
            this.textBox_gamedays.Location = new System.Drawing.Point(154, 17);
            this.textBox_gamedays.Name = "textBox_gamedays";
            this.textBox_gamedays.Size = new System.Drawing.Size(100, 20);
            this.textBox_gamedays.TabIndex = 0;
            // 
            // radioButton_secretOff
            // 
            this.radioButton_secretOff.AutoSize = true;
            this.radioButton_secretOff.Location = new System.Drawing.Point(215, 155);
            this.radioButton_secretOff.Name = "radioButton_secretOff";
            this.radioButton_secretOff.Size = new System.Drawing.Size(39, 17);
            this.radioButton_secretOff.TabIndex = 11;
            this.radioButton_secretOff.TabStop = true;
            this.radioButton_secretOff.Text = "Off";
            this.radioButton_secretOff.UseVisualStyleBackColor = true;
            // 
            // radioButton_secretOn
            // 
            this.radioButton_secretOn.AutoSize = true;
            this.radioButton_secretOn.Location = new System.Drawing.Point(154, 155);
            this.radioButton_secretOn.Name = "radioButton_secretOn";
            this.radioButton_secretOn.Size = new System.Drawing.Size(39, 17);
            this.radioButton_secretOn.TabIndex = 10;
            this.radioButton_secretOn.TabStop = true;
            this.radioButton_secretOn.Text = "On";
            this.toolTip_0.SetToolTip(this.radioButton_secretOn, "Caution:\r\nYou can lock yourself out of GT-Life with this option");
            this.radioButton_secretOn.UseVisualStyleBackColor = true;
            // 
            // button_secret
            // 
            this.button_secret.Location = new System.Drawing.Point(260, 152);
            this.button_secret.Name = "button_secret";
            this.button_secret.Size = new System.Drawing.Size(75, 23);
            this.button_secret.TabIndex = 12;
            this.button_secret.Text = "Apply";
            this.button_secret.UseVisualStyleBackColor = true;
            this.button_secret.Click += new System.EventHandler(this.button_secret_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 157);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Secret Menu";
            // 
            // button_BSpec
            // 
            this.button_BSpec.Location = new System.Drawing.Point(260, 123);
            this.button_BSpec.Name = "button_BSpec";
            this.button_BSpec.Size = new System.Drawing.Size(75, 23);
            this.button_BSpec.TabIndex = 9;
            this.button_BSpec.Text = "Apply";
            this.button_BSpec.UseVisualStyleBackColor = true;
            this.button_BSpec.Click += new System.EventHandler(this.button_BSpec_Click);
            // 
            // button_ASpec
            // 
            this.button_ASpec.Location = new System.Drawing.Point(260, 96);
            this.button_ASpec.Name = "button_ASpec";
            this.button_ASpec.Size = new System.Drawing.Size(75, 23);
            this.button_ASpec.TabIndex = 7;
            this.button_ASpec.Text = "Apply";
            this.button_ASpec.UseVisualStyleBackColor = true;
            this.button_ASpec.Click += new System.EventHandler(this.button_ASpec_Click);
            // 
            // button_Credits
            // 
            this.button_Credits.Location = new System.Drawing.Point(260, 41);
            this.button_Credits.Name = "button_Credits";
            this.button_Credits.Size = new System.Drawing.Size(75, 23);
            this.button_Credits.TabIndex = 3;
            this.button_Credits.Text = "Apply";
            this.button_Credits.UseVisualStyleBackColor = true;
            this.button_Credits.Click += new System.EventHandler(this.button_Credits_Click);
            // 
            // comboBox_spec_LevelB
            // 
            this.comboBox_spec_LevelB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_spec_LevelB.FormattingEnabled = true;
            this.comboBox_spec_LevelB.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40"});
            this.comboBox_spec_LevelB.Location = new System.Drawing.Point(154, 125);
            this.comboBox_spec_LevelB.Name = "comboBox_spec_LevelB";
            this.comboBox_spec_LevelB.Size = new System.Drawing.Size(100, 21);
            this.comboBox_spec_LevelB.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 128);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "B Spec Level";
            // 
            // comboBox_spec_LeveLA
            // 
            this.comboBox_spec_LeveLA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_spec_LeveLA.FormattingEnabled = true;
            this.comboBox_spec_LeveLA.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40"});
            this.comboBox_spec_LeveLA.Location = new System.Drawing.Point(154, 98);
            this.comboBox_spec_LeveLA.Name = "comboBox_spec_LeveLA";
            this.comboBox_spec_LeveLA.Size = new System.Drawing.Size(100, 21);
            this.comboBox_spec_LeveLA.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "A Spec Level";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Credits";
            // 
            // textBox_Credits
            // 
            this.textBox_Credits.Location = new System.Drawing.Point(154, 43);
            this.textBox_Credits.Name = "textBox_Credits";
            this.textBox_Credits.Size = new System.Drawing.Size(100, 20);
            this.textBox_Credits.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_gift_preset);
            this.groupBox1.Controls.Add(this.comboBox_gift_preset);
            this.groupBox1.Location = new System.Drawing.Point(5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 56);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game Completion";
            // 
            // button_gift_preset
            // 
            this.button_gift_preset.Location = new System.Drawing.Point(260, 19);
            this.button_gift_preset.Name = "button_gift_preset";
            this.button_gift_preset.Size = new System.Drawing.Size(75, 23);
            this.button_gift_preset.TabIndex = 1;
            this.button_gift_preset.Text = "&Perform";
            this.button_gift_preset.UseVisualStyleBackColor = true;
            this.button_gift_preset.Click += new System.EventHandler(this.button_gift_preset_Click);
            // 
            // comboBox_gift_preset
            // 
            this.comboBox_gift_preset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_gift_preset.FormattingEnabled = true;
            this.comboBox_gift_preset.Items.AddRange(new object[] {
            "Recieve All Presents",
            "All Gold A Spec",
            "All Gold B Spec",
            "All Gold Licences",
            "All Gold Special Events"});
            this.comboBox_gift_preset.Location = new System.Drawing.Point(6, 19);
            this.comboBox_gift_preset.Name = "comboBox_gift_preset";
            this.comboBox_gift_preset.Size = new System.Drawing.Size(121, 21);
            this.comboBox_gift_preset.TabIndex = 0;
            this.toolTip_0.SetToolTip(this.comboBox_gift_preset, "Select One");
            this.comboBox_gift_preset.SelectedIndexChanged += new System.EventHandler(this.comboBox_gift_preset_SelectedIndexChanged);
            // 
            // tabPage_garage
            // 
            this.tabPage_garage.BackColor = System.Drawing.Color.White;
            this.tabPage_garage.Controls.Add(this.groupBox4);
            this.tabPage_garage.Controls.Add(this.groupBox3);
            this.tabPage_garage.Location = new System.Drawing.Point(4, 22);
            this.tabPage_garage.Name = "tabPage_garage";
            this.tabPage_garage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_garage.Size = new System.Drawing.Size(680, 538);
            this.tabPage_garage.TabIndex = 0;
            this.tabPage_garage.Text = "Garage";
            this.tabPage_garage.UseVisualStyleBackColor = true;
            this.tabPage_garage.Enter += new System.EventHandler(this.tabPage_garage_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.comboBox_SMake);
            this.groupBox4.Controls.Add(this.comboBox_SModel);
            this.groupBox4.Controls.Add(this.dataGridView_Source);
            this.groupBox4.Controls.Add(this.textBox_SYear);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.textBox_SDT);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.textBox_SCountry);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(256, 524);
            this.groupBox4.TabIndex = 56;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Part Database";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Location = new System.Drawing.Point(6, 155);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(243, 34);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(131, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Click Parts Below to Swap";
            // 
            // comboBox_SMake
            // 
            this.comboBox_SMake.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox_SMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_SMake.FormattingEnabled = true;
            this.comboBox_SMake.Location = new System.Drawing.Point(6, 21);
            this.comboBox_SMake.Name = "comboBox_SMake";
            this.comboBox_SMake.Size = new System.Drawing.Size(243, 21);
            this.comboBox_SMake.TabIndex = 0;
            this.toolTip_0.SetToolTip(this.comboBox_SMake, "Choose Database Tuner");
            this.comboBox_SMake.SelectedIndexChanged += new System.EventHandler(this.comboBox_SMake_SelectedIndexChanged);
            // 
            // comboBox_SModel
            // 
            this.comboBox_SModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox_SModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_SModel.FormattingEnabled = true;
            this.comboBox_SModel.Location = new System.Drawing.Point(6, 48);
            this.comboBox_SModel.Name = "comboBox_SModel";
            this.comboBox_SModel.Size = new System.Drawing.Size(243, 21);
            this.comboBox_SModel.TabIndex = 1;
            this.toolTip_0.SetToolTip(this.comboBox_SModel, "Choose Database Model");
            this.comboBox_SModel.SelectedIndexChanged += new System.EventHandler(this.comboBox_SModel_SelectedIndexChanged);
            // 
            // dataGridView_Source
            // 
            this.dataGridView_Source.AllowUserToAddRows = false;
            this.dataGridView_Source.AllowUserToDeleteRows = false;
            this.dataGridView_Source.AllowUserToResizeColumns = false;
            this.dataGridView_Source.AllowUserToResizeRows = false;
            this.dataGridView_Source.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView_Source.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_Source.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_Source.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_Source.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Item,
            this.Column_Value});
            this.dataGridView_Source.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView_Source.Location = new System.Drawing.Point(6, 195);
            this.dataGridView_Source.MultiSelect = false;
            this.dataGridView_Source.Name = "dataGridView_Source";
            this.dataGridView_Source.ReadOnly = true;
            this.dataGridView_Source.RowHeadersVisible = false;
            this.dataGridView_Source.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView_Source.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Source.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_Source.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Source.Size = new System.Drawing.Size(243, 322);
            this.dataGridView_Source.TabIndex = 1;
            this.toolTip_0.SetToolTip(this.dataGridView_Source, "Click these Items to swap them to the right");
            this.dataGridView_Source.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Source_CellClick);
            // 
            // Column_Item
            // 
            this.Column_Item.HeaderText = "Item";
            this.Column_Item.Name = "Column_Item";
            this.Column_Item.ReadOnly = true;
            this.Column_Item.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column_Value
            // 
            dataGridViewCellStyle1.Format = "X8";
            this.Column_Value.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column_Value.HeaderText = "Value";
            this.Column_Value.Name = "Column_Value";
            this.Column_Value.ReadOnly = true;
            this.Column_Value.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column_Value.Width = 123;
            // 
            // textBox_SYear
            // 
            this.textBox_SYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_SYear.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_SYear.Location = new System.Drawing.Point(149, 75);
            this.textBox_SYear.Name = "textBox_SYear";
            this.textBox_SYear.ReadOnly = true;
            this.textBox_SYear.Size = new System.Drawing.Size(100, 20);
            this.textBox_SYear.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Country :";
            // 
            // textBox_SDT
            // 
            this.textBox_SDT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_SDT.Location = new System.Drawing.Point(149, 101);
            this.textBox_SDT.Name = "textBox_SDT";
            this.textBox_SDT.ReadOnly = true;
            this.textBox_SDT.Size = new System.Drawing.Size(100, 20);
            this.textBox_SDT.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Drivetrain :";
            // 
            // textBox_SCountry
            // 
            this.textBox_SCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_SCountry.Location = new System.Drawing.Point(149, 127);
            this.textBox_SCountry.Name = "textBox_SCountry";
            this.textBox_SCountry.ReadOnly = true;
            this.textBox_SCountry.Size = new System.Drawing.Size(100, 20);
            this.textBox_SCountry.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Year :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox_DMake);
            this.groupBox3.Controls.Add(this.groupBox_Sheet);
            this.groupBox3.Controls.Add(this.comboBox_DModel);
            this.groupBox3.Controls.Add(this.dataGridView_Dest);
            this.groupBox3.Controls.Add(this.textBox_DYear);
            this.groupBox3.Controls.Add(this.textBox_DDT);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBox_DCountry);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(360, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 524);
            this.groupBox3.TabIndex = 55;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Open Garage";
            // 
            // comboBox_DMake
            // 
            this.comboBox_DMake.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox_DMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_DMake.FormattingEnabled = true;
            this.comboBox_DMake.Location = new System.Drawing.Point(6, 19);
            this.comboBox_DMake.Name = "comboBox_DMake";
            this.comboBox_DMake.Size = new System.Drawing.Size(243, 21);
            this.comboBox_DMake.TabIndex = 0;
            this.toolTip_0.SetToolTip(this.comboBox_DMake, "Choose Tuner from your garage");
            this.comboBox_DMake.SelectedIndexChanged += new System.EventHandler(this.comboBox_DMake_SelectedIndexChanged);
            this.comboBox_DMake.Enter += new System.EventHandler(this.comboBox_DMake_Enter);
            // 
            // groupBox_Sheet
            // 
            this.groupBox_Sheet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox_Sheet.Controls.Add(this.radioButton_C);
            this.groupBox_Sheet.Controls.Add(this.radioButton_B);
            this.groupBox_Sheet.Controls.Add(this.radioButton_A);
            this.groupBox_Sheet.Enabled = false;
            this.groupBox_Sheet.Location = new System.Drawing.Point(6, 153);
            this.groupBox_Sheet.Name = "groupBox_Sheet";
            this.groupBox_Sheet.Size = new System.Drawing.Size(244, 34);
            this.groupBox_Sheet.TabIndex = 54;
            this.groupBox_Sheet.TabStop = false;
            this.toolTip_0.SetToolTip(this.groupBox_Sheet, "Select which Tune to alter");
            // 
            // radioButton_C
            // 
            this.radioButton_C.AutoSize = true;
            this.radioButton_C.Location = new System.Drawing.Point(178, 11);
            this.radioButton_C.Name = "radioButton_C";
            this.radioButton_C.Size = new System.Drawing.Size(60, 17);
            this.radioButton_C.TabIndex = 2;
            this.radioButton_C.TabStop = true;
            this.radioButton_C.Text = "Tune C";
            this.radioButton_C.UseVisualStyleBackColor = true;
            this.radioButton_C.CheckedChanged += new System.EventHandler(this.radioButton_C_CheckedChanged);
            // 
            // radioButton_B
            // 
            this.radioButton_B.AutoSize = true;
            this.radioButton_B.Location = new System.Drawing.Point(92, 11);
            this.radioButton_B.Name = "radioButton_B";
            this.radioButton_B.Size = new System.Drawing.Size(60, 17);
            this.radioButton_B.TabIndex = 1;
            this.radioButton_B.TabStop = true;
            this.radioButton_B.Text = "Tune B";
            this.radioButton_B.UseVisualStyleBackColor = true;
            this.radioButton_B.CheckedChanged += new System.EventHandler(this.radioButton_B_CheckedChanged);
            // 
            // radioButton_A
            // 
            this.radioButton_A.AutoSize = true;
            this.radioButton_A.Checked = true;
            this.radioButton_A.Location = new System.Drawing.Point(6, 11);
            this.radioButton_A.Name = "radioButton_A";
            this.radioButton_A.Size = new System.Drawing.Size(60, 17);
            this.radioButton_A.TabIndex = 0;
            this.radioButton_A.TabStop = true;
            this.radioButton_A.Text = "Tune A";
            this.radioButton_A.UseVisualStyleBackColor = true;
            this.radioButton_A.CheckedChanged += new System.EventHandler(this.radioButton_A_CheckedChanged);
            // 
            // comboBox_DModel
            // 
            this.comboBox_DModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox_DModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_DModel.FormattingEnabled = true;
            this.comboBox_DModel.Location = new System.Drawing.Point(6, 46);
            this.comboBox_DModel.Name = "comboBox_DModel";
            this.comboBox_DModel.Size = new System.Drawing.Size(243, 21);
            this.comboBox_DModel.TabIndex = 1;
            this.toolTip_0.SetToolTip(this.comboBox_DModel, "Choose Model from your garage");
            this.comboBox_DModel.SelectedIndexChanged += new System.EventHandler(this.comboBox_DModel_SelectedIndexChanged);
            // 
            // dataGridView_Dest
            // 
            this.dataGridView_Dest.AllowUserToAddRows = false;
            this.dataGridView_Dest.AllowUserToDeleteRows = false;
            this.dataGridView_Dest.AllowUserToResizeRows = false;
            this.dataGridView_Dest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView_Dest.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_Dest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_Dest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_Dest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_ItemD,
            this.Column_ValueD});
            this.dataGridView_Dest.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView_Dest.Location = new System.Drawing.Point(6, 193);
            this.dataGridView_Dest.MultiSelect = false;
            this.dataGridView_Dest.Name = "dataGridView_Dest";
            this.dataGridView_Dest.RowHeadersVisible = false;
            this.dataGridView_Dest.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView_Dest.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_Dest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_Dest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView_Dest.ShowRowErrors = false;
            this.dataGridView_Dest.Size = new System.Drawing.Size(243, 322);
            this.dataGridView_Dest.TabIndex = 24;
            this.toolTip_0.SetToolTip(this.dataGridView_Dest, "Type 8 digit hex string followed by Enter key to change values");
            this.dataGridView_Dest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Dest_CellClick);
            this.dataGridView_Dest.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Dest_CellEndEdit);
            this.dataGridView_Dest.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Dest_CellMouseLeave);
            // 
            // Column_ItemD
            // 
            this.Column_ItemD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column_ItemD.HeaderText = "Item";
            this.Column_ItemD.Name = "Column_ItemD";
            this.Column_ItemD.ReadOnly = true;
            this.Column_ItemD.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_ItemD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column_ValueD
            // 
            this.Column_ValueD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Format = "X8";
            this.Column_ValueD.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column_ValueD.HeaderText = "Value";
            this.Column_ValueD.Name = "Column_ValueD";
            this.Column_ValueD.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_ValueD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column_ValueD.Width = 123;
            // 
            // textBox_DYear
            // 
            this.textBox_DYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_DYear.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_DYear.Location = new System.Drawing.Point(149, 73);
            this.textBox_DYear.Name = "textBox_DYear";
            this.textBox_DYear.ReadOnly = true;
            this.textBox_DYear.Size = new System.Drawing.Size(100, 20);
            this.textBox_DYear.TabIndex = 18;
            // 
            // textBox_DDT
            // 
            this.textBox_DDT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_DDT.Location = new System.Drawing.Point(149, 99);
            this.textBox_DDT.Name = "textBox_DDT";
            this.textBox_DDT.ReadOnly = true;
            this.textBox_DDT.Size = new System.Drawing.Size(100, 20);
            this.textBox_DDT.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Country :";
            // 
            // textBox_DCountry
            // 
            this.textBox_DCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_DCountry.Location = new System.Drawing.Point(149, 125);
            this.textBox_DCountry.Name = "textBox_DCountry";
            this.textBox_DCountry.ReadOnly = true;
            this.textBox_DCountry.Size = new System.Drawing.Size(100, 20);
            this.textBox_DCountry.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Drivetrain :";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Year :";
            // 
            // tabPage_ridingCar
            // 
            this.tabPage_ridingCar.Controls.Add(this.button11);
            this.tabPage_ridingCar.Location = new System.Drawing.Point(4, 22);
            this.tabPage_ridingCar.Name = "tabPage_ridingCar";
            this.tabPage_ridingCar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ridingCar.Size = new System.Drawing.Size(680, 538);
            this.tabPage_ridingCar.TabIndex = 4;
            this.tabPage_ridingCar.Text = "Riding Car";
            this.tabPage_ridingCar.UseVisualStyleBackColor = true;
            this.tabPage_ridingCar.Enter += new System.EventHandler(this.tabPage_ridingCar_Enter);
            this.tabPage_ridingCar.Leave += new System.EventHandler(this.tabPage_ridingCar_Leave);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(268, 37);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(86, 23);
            this.button11.TabIndex = 0;
            this.button11.Text = "Borrow Glitch";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // tabPage_gift
            // 
            this.tabPage_gift.BackColor = System.Drawing.Color.White;
            this.tabPage_gift.Controls.Add(this.groupBox22);
            this.tabPage_gift.Controls.Add(this.groupBox20);
            this.tabPage_gift.Controls.Add(this.groupBox17);
            this.tabPage_gift.Controls.Add(this.groupBox6);
            this.tabPage_gift.Controls.Add(this.groupBox2);
            this.tabPage_gift.Controls.Add(this.groupBox_gift_tuneitems);
            this.tabPage_gift.Location = new System.Drawing.Point(4, 22);
            this.tabPage_gift.Name = "tabPage_gift";
            this.tabPage_gift.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_gift.Size = new System.Drawing.Size(680, 538);
            this.tabPage_gift.TabIndex = 1;
            this.tabPage_gift.Text = "Items";
            this.tabPage_gift.UseVisualStyleBackColor = true;
            this.tabPage_gift.Enter += new System.EventHandler(this.tabPage_gift_Enter);
            // 
            // groupBox22
            // 
            this.groupBox22.Controls.Add(this.button_delete_item);
            this.groupBox22.Controls.Add(this.cB_itemControl);
            this.groupBox22.Location = new System.Drawing.Point(4, 435);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Size = new System.Drawing.Size(507, 95);
            this.groupBox22.TabIndex = 9;
            this.groupBox22.TabStop = false;
            this.groupBox22.Text = "Item Control";
            // 
            // button_delete_item
            // 
            this.button_delete_item.Location = new System.Drawing.Point(425, 17);
            this.button_delete_item.Name = "button_delete_item";
            this.button_delete_item.Size = new System.Drawing.Size(75, 23);
            this.button_delete_item.TabIndex = 1;
            this.button_delete_item.Text = "Delete";
            this.button_delete_item.UseVisualStyleBackColor = true;
            this.button_delete_item.Click += new System.EventHandler(this.button_delete_item_Click);
            // 
            // cB_itemControl
            // 
            this.cB_itemControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_itemControl.FormattingEnabled = true;
            this.cB_itemControl.Location = new System.Drawing.Point(9, 17);
            this.cB_itemControl.Name = "cB_itemControl";
            this.cB_itemControl.Size = new System.Drawing.Size(243, 21);
            this.cB_itemControl.TabIndex = 0;
            this.toolTip_0.SetToolTip(this.cB_itemControl, "Select Ticket Item to Delete");
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.btn_special_insert);
            this.groupBox20.Controls.Add(this.cB_special_car);
            this.groupBox20.Location = new System.Drawing.Point(4, 161);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(507, 93);
            this.groupBox20.TabIndex = 7;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "Special Car Insert";
            // 
            // btn_special_insert
            // 
            this.btn_special_insert.Location = new System.Drawing.Point(176, 46);
            this.btn_special_insert.Name = "btn_special_insert";
            this.btn_special_insert.Size = new System.Drawing.Size(75, 23);
            this.btn_special_insert.TabIndex = 7;
            this.btn_special_insert.Text = "Insert";
            this.btn_special_insert.UseVisualStyleBackColor = true;
            this.btn_special_insert.Click += new System.EventHandler(this.btn_special_insert_Click);
            // 
            // cB_special_car
            // 
            this.cB_special_car.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_special_car.FormattingEnabled = true;
            this.cB_special_car.Items.AddRange(new object[] {
            "XXXXXXXX",
            "Red Bull X2010 JP Flag Color",
            "Red Bull X2010 5G Type A",
            "Red Bull X2010 5G Type B",
            "Red Bull X2010 5G Type C"});
            this.cB_special_car.Location = new System.Drawing.Point(8, 19);
            this.cB_special_car.Name = "cB_special_car";
            this.cB_special_car.Size = new System.Drawing.Size(243, 21);
            this.cB_special_car.TabIndex = 0;
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.btn_Insert_Car_Ticket);
            this.groupBox17.Controls.Add(this.label43);
            this.groupBox17.Controls.Add(this.pictureBox_thumb);
            this.groupBox17.Controls.Add(this.cB_insert_colour);
            this.groupBox17.Controls.Add(this.cB_insert_tuner);
            this.groupBox17.Controls.Add(this.cB_insert_model);
            this.groupBox17.Location = new System.Drawing.Point(6, 6);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(505, 149);
            this.groupBox17.TabIndex = 6;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Insert New Car Ticket";
            // 
            // btn_Insert_Car_Ticket
            // 
            this.btn_Insert_Car_Ticket.Location = new System.Drawing.Point(174, 118);
            this.btn_Insert_Car_Ticket.Name = "btn_Insert_Car_Ticket";
            this.btn_Insert_Car_Ticket.Size = new System.Drawing.Size(75, 23);
            this.btn_Insert_Car_Ticket.TabIndex = 3;
            this.btn_Insert_Car_Ticket.Text = "Insert";
            this.btn_Insert_Car_Ticket.UseVisualStyleBackColor = true;
            this.btn_Insert_Car_Ticket.Click += new System.EventHandler(this.btn_Insert_Car_Ticket_Click);
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(6, 76);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(80, 13);
            this.label43.TabIndex = 6;
            this.label43.Text = "Dealer Colour : ";
            // 
            // pictureBox_thumb
            // 
            this.pictureBox_thumb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox_thumb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_thumb.ErrorImage = null;
            this.pictureBox_thumb.InitialImage = null;
            this.pictureBox_thumb.Location = new System.Drawing.Point(290, 19);
            this.pictureBox_thumb.Name = "pictureBox_thumb";
            this.pictureBox_thumb.Size = new System.Drawing.Size(207, 122);
            this.pictureBox_thumb.TabIndex = 5;
            this.pictureBox_thumb.TabStop = false;
            // 
            // cB_insert_colour
            // 
            this.cB_insert_colour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_insert_colour.FormattingEnabled = true;
            this.cB_insert_colour.Location = new System.Drawing.Point(128, 73);
            this.cB_insert_colour.Name = "cB_insert_colour";
            this.cB_insert_colour.Size = new System.Drawing.Size(121, 21);
            this.cB_insert_colour.TabIndex = 2;
            this.toolTip_0.SetToolTip(this.cB_insert_colour, "Choose Dealer Colour");
            // 
            // cB_insert_tuner
            // 
            this.cB_insert_tuner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_insert_tuner.FormattingEnabled = true;
            this.cB_insert_tuner.Location = new System.Drawing.Point(6, 19);
            this.cB_insert_tuner.Name = "cB_insert_tuner";
            this.cB_insert_tuner.Size = new System.Drawing.Size(243, 21);
            this.cB_insert_tuner.TabIndex = 0;
            this.toolTip_0.SetToolTip(this.cB_insert_tuner, "Choose Tuner");
            this.cB_insert_tuner.SelectedIndexChanged += new System.EventHandler(this.cB_insert_tuner_SelectedIndexChanged);
            // 
            // cB_insert_model
            // 
            this.cB_insert_model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_insert_model.FormattingEnabled = true;
            this.cB_insert_model.Location = new System.Drawing.Point(6, 46);
            this.cB_insert_model.Name = "cB_insert_model";
            this.cB_insert_model.Size = new System.Drawing.Size(243, 21);
            this.cB_insert_model.TabIndex = 1;
            this.toolTip_0.SetToolTip(this.cB_insert_model, "Choose Model");
            this.cB_insert_model.SelectedIndexChanged += new System.EventHandler(this.cB_insert_model_SelectedIndexChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btn_Year_tickets_give10);
            this.groupBox6.Controls.Add(this.comboBox_tickets);
            this.groupBox6.Controls.Add(this.button_carTicket);
            this.groupBox6.Location = new System.Drawing.Point(4, 378);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(507, 53);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Manufacturer/Year Tickets";
            // 
            // btn_Year_tickets_give10
            // 
            this.btn_Year_tickets_give10.Location = new System.Drawing.Point(424, 17);
            this.btn_Year_tickets_give10.Name = "btn_Year_tickets_give10";
            this.btn_Year_tickets_give10.Size = new System.Drawing.Size(75, 23);
            this.btn_Year_tickets_give10.TabIndex = 2;
            this.btn_Year_tickets_give10.Text = "Add 10";
            this.btn_Year_tickets_give10.UseVisualStyleBackColor = true;
            this.btn_Year_tickets_give10.Click += new System.EventHandler(this.btn_Year_tickets_give10_Click);
            // 
            // comboBox_tickets
            // 
            this.comboBox_tickets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tickets.FormattingEnabled = true;
            this.comboBox_tickets.Items.AddRange(new object[] {
            "Introductory Gift Car Ticket",
            "D1 GRAND PRIX",
            "JGTC &amp; SUPER GT",
            "Le Mans 24h",
            "NASCAR",
            "Rally",
            "Concept Car",
            "LV 1 Class",
            "LV 2 Class",
            "LV 3 Class",
            "LV 4 Class",
            "LV 5 Class",
            "LV 6 Class",
            "LV 7 Class",
            "LV 8 Class",
            "LV 9 Class",
            "LV 10 Class",
            "LV 11 Class",
            "LV 12 Class",
            "LV 13 Class",
            "LV 14 Class",
            "LV 15 Class",
            "LV 16 Class",
            "LV 17 Class",
            "LV 18 Class",
            "LV 19 Class",
            "LV 20 Class",
            "LV 21 Class",
            "LV 22 Class",
            "LV 23 Class",
            "LV 24 Class",
            "LV 25 Class",
            "LV 26 Class",
            "LV 27 Class",
            "LV 28 Class",
            "LV 29 Class",
            "LV 30 Class",
            "LV 31 Class",
            "LV 32 Class",
            "LV 33 Class",
            "LV 34 Class",
            "LV 35 Class",
            "LV 36 Class",
            "LV 37 Class",
            "LV 38 Class",
            "LV 39 Class",
            "LV 40 Class",
            "BMW",
            "FPV",
            "TVR",
            "Audi",
            "Acura",
            "Aston Martin",
            "Alfa Romeo",
            "Isuzu",
            "Infiniti",
            "Vauxhall",
            "Opel",
            "Chrysler",
            "Shelby",
            "Citroen",
            "Chevrolet",
            "Jaguar",
            "Suzuki",
            "Subaru",
            "Daihatsu",
            "Dodge",
            "Toyota",
            "Pagani",
            "Hyundai",
            "fiat",
            "Ferrari",
            "Ford",
            "Volkswagen",
            "Peugeot",
            "Volvo",
            "Honda",
            "Pontiac",
            "Mazda",
            "Mini",
            "Mercedes-Benz",
            "Lancia",
            "Lamborghini",
            "Renault",
            "Lexus",
            "Lotus",
            "Mitsubishi",
            "Nissan",
            "1942",
            "1944",
            "1949",
            "1954",
            "1958",
            "1961",
            "1962",
            "1963",
            "1964",
            "1965",
            "1966",
            "1967",
            "1968",
            "1969",
            "1970",
            "1971",
            "1972",
            "1973",
            "1974",
            "1976",
            "1977",
            "1978",
            "1979",
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005"});
            this.comboBox_tickets.Location = new System.Drawing.Point(8, 19);
            this.comboBox_tickets.Name = "comboBox_tickets";
            this.comboBox_tickets.Size = new System.Drawing.Size(121, 21);
            this.comboBox_tickets.TabIndex = 0;
            this.toolTip_0.SetToolTip(this.comboBox_tickets, "Car Ticket Number");
            // 
            // button_carTicket
            // 
            this.button_carTicket.Location = new System.Drawing.Point(343, 17);
            this.button_carTicket.Name = "button_carTicket";
            this.button_carTicket.Size = new System.Drawing.Size(75, 23);
            this.button_carTicket.TabIndex = 1;
            this.button_carTicket.Text = "Add Item";
            this.button_carTicket.UseVisualStyleBackColor = true;
            this.button_carTicket.Click += new System.EventHandler(this.button_carTicket_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_gift_paintBy10);
            this.groupBox2.Controls.Add(this.comboBox__gift_paintCat);
            this.groupBox2.Controls.Add(this.button_gift_paintAdd);
            this.groupBox2.Controls.Add(this.comboBox_gift_paintNum);
            this.groupBox2.Location = new System.Drawing.Point(4, 319);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(507, 53);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Paint Items";
            // 
            // btn_gift_paintBy10
            // 
            this.btn_gift_paintBy10.Location = new System.Drawing.Point(424, 17);
            this.btn_gift_paintBy10.Name = "btn_gift_paintBy10";
            this.btn_gift_paintBy10.Size = new System.Drawing.Size(75, 23);
            this.btn_gift_paintBy10.TabIndex = 3;
            this.btn_gift_paintBy10.Text = "Add 10";
            this.btn_gift_paintBy10.UseVisualStyleBackColor = true;
            this.btn_gift_paintBy10.Click += new System.EventHandler(this.btn_gift_paintBy10_Click);
            // 
            // comboBox__gift_paintCat
            // 
            this.comboBox__gift_paintCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox__gift_paintCat.FormattingEnabled = true;
            this.comboBox__gift_paintCat.Items.AddRange(new object[] {
            "Solid",
            "Metallic",
            "Pearlescent",
            "Shift",
            "Matte",
            "Chrome"});
            this.comboBox__gift_paintCat.Location = new System.Drawing.Point(8, 19);
            this.comboBox__gift_paintCat.Name = "comboBox__gift_paintCat";
            this.comboBox__gift_paintCat.Size = new System.Drawing.Size(121, 21);
            this.comboBox__gift_paintCat.TabIndex = 0;
            this.toolTip_0.SetToolTip(this.comboBox__gift_paintCat, "Paint Category");
            this.comboBox__gift_paintCat.SelectedIndexChanged += new System.EventHandler(this.comboBox__gift_paintCat_SelectedIndexChanged);
            // 
            // button_gift_paintAdd
            // 
            this.button_gift_paintAdd.Location = new System.Drawing.Point(343, 17);
            this.button_gift_paintAdd.Name = "button_gift_paintAdd";
            this.button_gift_paintAdd.Size = new System.Drawing.Size(75, 23);
            this.button_gift_paintAdd.TabIndex = 2;
            this.button_gift_paintAdd.Text = "Add Item";
            this.button_gift_paintAdd.UseVisualStyleBackColor = true;
            this.button_gift_paintAdd.Click += new System.EventHandler(this.button_gift_paintAdd_Click);
            // 
            // comboBox_gift_paintNum
            // 
            this.comboBox_gift_paintNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_gift_paintNum.FormattingEnabled = true;
            this.comboBox_gift_paintNum.Location = new System.Drawing.Point(135, 19);
            this.comboBox_gift_paintNum.Name = "comboBox_gift_paintNum";
            this.comboBox_gift_paintNum.Size = new System.Drawing.Size(202, 21);
            this.comboBox_gift_paintNum.TabIndex = 1;
            this.toolTip_0.SetToolTip(this.comboBox_gift_paintNum, "Paint number");
            // 
            // groupBox_gift_tuneitems
            // 
            this.groupBox_gift_tuneitems.Controls.Add(this.btn_gift_tune_give10);
            this.groupBox_gift_tuneitems.Controls.Add(this.comboBox_category_name);
            this.groupBox_gift_tuneitems.Controls.Add(this.button_gift_tune_add);
            this.groupBox_gift_tuneitems.Controls.Add(this.comboBox_gameitem_id);
            this.groupBox_gift_tuneitems.Location = new System.Drawing.Point(4, 260);
            this.groupBox_gift_tuneitems.Name = "groupBox_gift_tuneitems";
            this.groupBox_gift_tuneitems.Size = new System.Drawing.Size(507, 53);
            this.groupBox_gift_tuneitems.TabIndex = 3;
            this.groupBox_gift_tuneitems.TabStop = false;
            this.groupBox_gift_tuneitems.Text = "Tune Items";
            // 
            // btn_gift_tune_give10
            // 
            this.btn_gift_tune_give10.Location = new System.Drawing.Point(424, 19);
            this.btn_gift_tune_give10.Name = "btn_gift_tune_give10";
            this.btn_gift_tune_give10.Size = new System.Drawing.Size(75, 23);
            this.btn_gift_tune_give10.TabIndex = 3;
            this.btn_gift_tune_give10.Text = "Add 10";
            this.btn_gift_tune_give10.UseVisualStyleBackColor = true;
            this.btn_gift_tune_give10.Click += new System.EventHandler(this.btn_gift_tune_give10_Click);
            // 
            // comboBox_category_name
            // 
            this.comboBox_category_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_category_name.FormattingEnabled = true;
            this.comboBox_category_name.Items.AddRange(new object[] {
            "Body/Chassis",
            "Engine",
            "Intake/Exhaust",
            "Turbo Kit",
            "Transmission",
            "Drivetrain",
            "Suspension",
            "Brakes",
            "Comfort Tires",
            "Sport Tires",
            "RacingTires",
            "Special Tires",
            "Others"});
            this.comboBox_category_name.Location = new System.Drawing.Point(8, 19);
            this.comboBox_category_name.Name = "comboBox_category_name";
            this.comboBox_category_name.Size = new System.Drawing.Size(121, 21);
            this.comboBox_category_name.TabIndex = 0;
            this.toolTip_0.SetToolTip(this.comboBox_category_name, "The Item that will show In-Game");
            // 
            // button_gift_tune_add
            // 
            this.button_gift_tune_add.Location = new System.Drawing.Point(343, 19);
            this.button_gift_tune_add.Name = "button_gift_tune_add";
            this.button_gift_tune_add.Size = new System.Drawing.Size(75, 23);
            this.button_gift_tune_add.TabIndex = 2;
            this.button_gift_tune_add.Text = "Add Item";
            this.button_gift_tune_add.UseVisualStyleBackColor = true;
            this.button_gift_tune_add.Click += new System.EventHandler(this.button_gift_tune_add_Click);
            // 
            // comboBox_gameitem_id
            // 
            this.comboBox_gameitem_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_gameitem_id.FormattingEnabled = true;
            this.comboBox_gameitem_id.Items.AddRange(new object[] {
            "Weight Stage 1",
            "Weight Stage 2",
            "Weight Stage 3",
            "Weight Stage 4",
            "Weight Stage 5",
            "Window Weight Reduction",
            "Carbon Bonnet (Body Color)",
            "Carbon Bonnet",
            "Rigidity Improvement",
            "Sports ECU",
            "[Engine] Stage 1",
            "[Engine] Stage 2",
            "[Engine] Stage 3",
            "[Engine] Stage 4",
            "[Engine] Stage 5",
            "Sports Intake Manifold",
            "Sports Air filter",
            "Racing Air filter",
            "Improved Accelerator Response",
            "Sports Exhaust Manifold",
            "Catalytic Converter: Sports",
            "Catalytic Converter: Racing",
            "Sports Exhaust",
            "Titanium Semi-Racing Exhaust",
            "Titanium Racing Exhaust",
            "Supercharger",
            "Low RPM Range Turbo Kit",
            "Mid RPM Range Turbo Kit",
            "High RPM Range Turbo Kit",
            "Super High RPM Turbo Kit",
            "Ultra High RPM Turbo Kit",
            "5 Speed Close-Ratio Transmission",
            "6 Speed Close-Ratio Transmission",
            "Fully Customisable Transmission",
            "Clutch: Single-Plate",
            "Clutch: Twin-Plate",
            "Clutch: Triple-Plate",
            "Flywheel: Sports",
            "Flywheel: Semi-Racing",
            "Flywheel: Racing",
            "Fully Customisable LSD",
            "Torque Distributing Centre Differential",
            "AYC Controller",
            "Carbon Propeller Shaft",
            "[Suspension] Fixed Sports Kit",
            "[Suspension] Height-Adjustable Sports Kit",
            "[Suspension] Fully Customisable Kit",
            "[Brakes] Large-Diameter Discs + 4-Piston Calipers",
            "[Brakes] Large-Diameter Discs + 6-Piston Calipers ",
            "[Brakes] Large-Diameter Discs + 8-Piston Calipers",
            "[Brakes] Ceramic Carbon Brakes",
            "[Brakes] Brake Balance Controller",
            "[Tyres] Hard",
            "[Tyres] Comfort: Hard (C)",
            "[Tyres] Comfort: Hard (V)",
            "[Tyres] Medium ",
            "[Tyres] Comfort: Medium (C)",
            "[Tyres] Comfort: Medium (V)",
            "[Tyres] Soft ",
            "[Tyres] Comfort: Soft: (C) ",
            "[Tyres] Comfort: Soft (V)",
            "[Tyres] Hard",
            "[Tyres] Sports: Hard (C)",
            "[Tyres] Sports: Hard (V)",
            "[Tyres] Medium",
            "[Tyres] Sports: Medium (C)",
            "[Tyres] Sports: Medium (V)",
            "[Tyres] Soft",
            "[Tyres] Sports: Soft (C)",
            "[Tyres] Sports: Soft (V)",
            "[Tyres] Sports: Super-Soft",
            "[Tyres] Sports: Super-Soft (C)",
            "[Tyres] Sports: Super-Soft (V)",
            "[Tyres] Hard",
            "[Tyres] Racing: Hard (C)",
            "[Tyres] Racing: Hard (V)",
            "[Tyres] Medium",
            "[Tyres] Racing: Medium (C)",
            "[Tyres] Racing: Medium (V)",
            "[Tyres] Soft",
            "[Tyres] Racing: Soft (C)",
            "[Tyres] Racing: Soft (V) ",
            "[Tyres] Racing: Super-Soft",
            "[Tyres] Racing: Super-Soft (C) ",
            "[Tyres] Racing: Super-Soft (V)",
            "[Tyres] Racing: Intermediate",
            "[Tyres] Racing: Rain ",
            "Dirt Tyres",
            "Snow Tyres ",
            "Nitro: 5 Seconds",
            "Nitro: 10 Seconds",
            "Nitro: 20 Seconds",
            "Nitro: 30 Seconds",
            "Nitro: 60 Seconds",
            "Nitro: 90 Seconds",
            "Nitro: 120 Seconds",
            "5% Power Improvement",
            "10% Power Improvement",
            "20% Power Improvement"});
            this.comboBox_gameitem_id.Location = new System.Drawing.Point(135, 19);
            this.comboBox_gameitem_id.Name = "comboBox_gameitem_id";
            this.comboBox_gameitem_id.Size = new System.Drawing.Size(202, 21);
            this.comboBox_gameitem_id.TabIndex = 1;
            // 
            // tabPage_Adv
            // 
            this.tabPage_Adv.BackColor = System.Drawing.Color.White;
            this.tabPage_Adv.Controls.Add(this.groupBox19);
            this.tabPage_Adv.Controls.Add(this.groupBox_func_basic);
            this.tabPage_Adv.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Adv.Name = "tabPage_Adv";
            this.tabPage_Adv.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Adv.Size = new System.Drawing.Size(680, 538);
            this.tabPage_Adv.TabIndex = 2;
            this.tabPage_Adv.Text = "Functions";
            this.tabPage_Adv.UseVisualStyleBackColor = true;
            this.tabPage_Adv.Enter += new System.EventHandler(this.tabPage_Adv_Enter);
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.btn_name_change);
            this.groupBox19.Controls.Add(this.tB_Name_New);
            this.groupBox19.Controls.Add(this.cB_Name_Model);
            this.groupBox19.Controls.Add(this.cB_Name_Make);
            this.groupBox19.Location = new System.Drawing.Point(5, 212);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(609, 108);
            this.groupBox19.TabIndex = 2;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Name Changer";
            // 
            // btn_name_change
            // 
            this.btn_name_change.Location = new System.Drawing.Point(213, 71);
            this.btn_name_change.Name = "btn_name_change";
            this.btn_name_change.Size = new System.Drawing.Size(75, 23);
            this.btn_name_change.TabIndex = 3;
            this.btn_name_change.Text = "Apply";
            this.toolTip_0.SetToolTip(this.btn_name_change, "Apply Name Change");
            this.btn_name_change.UseVisualStyleBackColor = true;
            this.btn_name_change.Click += new System.EventHandler(this.btn_name_change_Click);
            // 
            // tB_Name_New
            // 
            this.tB_Name_New.Location = new System.Drawing.Point(6, 73);
            this.tB_Name_New.Name = "tB_Name_New";
            this.tB_Name_New.Size = new System.Drawing.Size(201, 20);
            this.tB_Name_New.TabIndex = 2;
            this.toolTip_0.SetToolTip(this.tB_Name_New, "New Model Name");
            // 
            // cB_Name_Model
            // 
            this.cB_Name_Model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_Name_Model.FormattingEnabled = true;
            this.cB_Name_Model.Location = new System.Drawing.Point(6, 46);
            this.cB_Name_Model.Name = "cB_Name_Model";
            this.cB_Name_Model.Size = new System.Drawing.Size(201, 21);
            this.cB_Name_Model.TabIndex = 1;
            this.toolTip_0.SetToolTip(this.cB_Name_Model, "Model");
            // 
            // cB_Name_Make
            // 
            this.cB_Name_Make.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_Name_Make.FormattingEnabled = true;
            this.cB_Name_Make.Location = new System.Drawing.Point(6, 20);
            this.cB_Name_Make.Name = "cB_Name_Make";
            this.cB_Name_Make.Size = new System.Drawing.Size(201, 21);
            this.cB_Name_Make.TabIndex = 0;
            this.toolTip_0.SetToolTip(this.cB_Name_Make, "Tuner");
            this.cB_Name_Make.SelectedIndexChanged += new System.EventHandler(this.cB_Name_Make_SelectedIndexChanged);
            // 
            // groupBox_func_basic
            // 
            this.groupBox_func_basic.Controls.Add(this.label10);
            this.groupBox_func_basic.Controls.Add(this.cb_c);
            this.groupBox_func_basic.Controls.Add(this.cb_b);
            this.groupBox_func_basic.Controls.Add(this.cb_a);
            this.groupBox_func_basic.Controls.Add(this.listBox_func_basic);
            this.groupBox_func_basic.Controls.Add(this.button_func_conf);
            this.groupBox_func_basic.Controls.Add(this.label9);
            this.groupBox_func_basic.Controls.Add(this.tb_func_withvalue);
            this.groupBox_func_basic.Controls.Add(this.comboBox_func_edit);
            this.groupBox_func_basic.Controls.Add(this.label8);
            this.groupBox_func_basic.Controls.Add(this.label7);
            this.groupBox_func_basic.Controls.Add(this.comboBox_func_make);
            this.groupBox_func_basic.Location = new System.Drawing.Point(5, 6);
            this.groupBox_func_basic.Name = "groupBox_func_basic";
            this.groupBox_func_basic.Size = new System.Drawing.Size(609, 200);
            this.groupBox_func_basic.TabIndex = 1;
            this.groupBox_func_basic.TabStop = false;
            this.groupBox_func_basic.Text = "Basic";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "On :";
            // 
            // cb_c
            // 
            this.cb_c.AutoSize = true;
            this.cb_c.Location = new System.Drawing.Point(86, 143);
            this.cb_c.Name = "cb_c";
            this.cb_c.Size = new System.Drawing.Size(64, 17);
            this.cb_c.TabIndex = 5;
            this.cb_c.Text = "Sheet C";
            this.toolTip_0.SetToolTip(this.cb_c, "which sheets");
            this.cb_c.UseVisualStyleBackColor = true;
            // 
            // cb_b
            // 
            this.cb_b.AutoSize = true;
            this.cb_b.Location = new System.Drawing.Point(86, 120);
            this.cb_b.Name = "cb_b";
            this.cb_b.Size = new System.Drawing.Size(64, 17);
            this.cb_b.TabIndex = 4;
            this.cb_b.Text = "Sheet B";
            this.toolTip_0.SetToolTip(this.cb_b, "which sheets");
            this.cb_b.UseVisualStyleBackColor = true;
            // 
            // cb_a
            // 
            this.cb_a.AutoSize = true;
            this.cb_a.Location = new System.Drawing.Point(86, 97);
            this.cb_a.Name = "cb_a";
            this.cb_a.Size = new System.Drawing.Size(64, 17);
            this.cb_a.TabIndex = 3;
            this.cb_a.Text = "Sheet A";
            this.toolTip_0.SetToolTip(this.cb_a, "which sheets");
            this.cb_a.UseVisualStyleBackColor = true;
            // 
            // listBox_func_basic
            // 
            this.listBox_func_basic.FormattingEnabled = true;
            this.listBox_func_basic.Location = new System.Drawing.Point(213, 19);
            this.listBox_func_basic.Name = "listBox_func_basic";
            this.listBox_func_basic.ScrollAlwaysVisible = true;
            this.listBox_func_basic.Size = new System.Drawing.Size(387, 173);
            this.listBox_func_basic.TabIndex = 7;
            // 
            // button_func_conf
            // 
            this.button_func_conf.Location = new System.Drawing.Point(86, 166);
            this.button_func_conf.Name = "button_func_conf";
            this.button_func_conf.Size = new System.Drawing.Size(75, 23);
            this.button_func_conf.TabIndex = 6;
            this.button_func_conf.Text = "&Confirm";
            this.toolTip_0.SetToolTip(this.button_func_conf, "Confirm");
            this.button_func_conf.UseVisualStyleBackColor = true;
            this.button_func_conf.Click += new System.EventHandler(this.button_func_conf_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "With Value:";
            // 
            // tb_func_withvalue
            // 
            this.tb_func_withvalue.Location = new System.Drawing.Point(86, 73);
            this.tb_func_withvalue.Name = "tb_func_withvalue";
            this.tb_func_withvalue.Size = new System.Drawing.Size(121, 20);
            this.tb_func_withvalue.TabIndex = 2;
            this.toolTip_0.SetToolTip(this.tb_func_withvalue, "Enter the Value as Hexadecimal");
            // 
            // comboBox_func_edit
            // 
            this.comboBox_func_edit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_func_edit.FormattingEnabled = true;
            this.comboBox_func_edit.Items.AddRange(new object[] {
            "BHP",
            "Grip",
            "Weight",
            "Odometer",
            "Oil",
            "Paint",
            "Body",
            "Colour",
            "Brakes",
            "_198_201",
            "Chassis",
            "Engine",
            "Drivetrain",
            "Transmission",
            "Suspension",
            "LSD",
            "_226_229",
            "WReduction",
            "_234_237",
            "_238_241",
            "ECU",
            "Engine Tune",
            "Turbo",
            "Flywheel",
            "Clutch",
            "Driveshaft",
            "Exhaust",
            "_270_273",
            "ASM Controller",
            "TCS Controller",
            "_282_285",
            "Supercharger",
            "Intake Manifold",
            "Exhaust Manifold",
            "Catalytic Converter",
            "Air Filter",
            "_306_309",
            "WindowWR",
            "Hood",
            "FrBumper",
            "RrBumper",
            "Extension",
            "Wing",
            "_334_337",
            "Reinforcement",
            "NoS"});
            this.comboBox_func_edit.Location = new System.Drawing.Point(86, 46);
            this.comboBox_func_edit.Name = "comboBox_func_edit";
            this.comboBox_func_edit.Size = new System.Drawing.Size(121, 21);
            this.comboBox_func_edit.TabIndex = 1;
            this.toolTip_0.SetToolTip(this.comboBox_func_edit, "Choose the part of the car to edit");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Edit:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Choose :";
            // 
            // comboBox_func_make
            // 
            this.comboBox_func_make.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_func_make.FormattingEnabled = true;
            this.comboBox_func_make.Items.AddRange(new object[] {
            "ALL CARS",
            "ac",
            "aem",
            "acura",
            "alfaromeo",
            "alpine",
            "amuse",
            "artmorrison",
            "astonmartin",
            "audi",
            "autobacs",
            "bmw",
            "bentley",
            "blitz",
            "bugatti",
            "buick",
            "cadillac",
            "callaway",
            "caterham",
            "chaparral",
            "chevrolet",
            "chrysler",
            "citroen",
            "cizeta",
            "dmc",
            "daihatsu",
            "dodge",
            "dome",
            "eagle",
            "ferrari",
            "fiat",
            "ford",
            "au_ford",
            "gillet",
            "ginetta",
            "polyphony",
            "gtg",
            "hks",
            "hpa",
            "hep",
            "holden",
            "hommell",
            "honda",
            "hyundai",
            "infiniti",
            "isuzu",
            "jaguar",
            "jayleno",
            "jensen",
            "lamborghini",
            "lancia",
            "landrover",
            "lexus",
            "lister",
            "lotus",
            "mg",
            "marcos",
            "maserati",
            "mazda",
            "mclaren",
            "mercedes",
            "mercury",
            "mines",
            "mini",
            "mitsubishi",
            "mugen",
            "nismo",
            "nissan",
            "opel",
            "opera",
            "proto",
            "pagani",
            "panoz",
            "pescarolo",
            "peugeot",
            "plymouth",
            "pontiac",
            "amemiya",
            "ruf",
            "renault",
            "renaultsport",
            "saleen",
            "scion",
            "seat",
            "shelby",
            "spoon",
            "spyker",
            "subaru",
            "suzuki",
            "trd",
            "trial",
            "tvr",
            "tesla",
            "toms",
            "tommykaira",
            "toyota",
            "triumph",
            "vauxhall",
            "volkswagen",
            "volvo"});
            this.comboBox_func_make.Location = new System.Drawing.Point(86, 19);
            this.comboBox_func_make.Name = "comboBox_func_make";
            this.comboBox_func_make.Size = new System.Drawing.Size(121, 21);
            this.comboBox_func_make.TabIndex = 0;
            this.toolTip_0.SetToolTip(this.comboBox_func_make, "Choose what to edit");
            // 
            // menuStrip_main
            // 
            this.menuStrip_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip_main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_main.Name = "menuStrip_main";
            this.menuStrip_main.Size = new System.Drawing.Size(688, 24);
            this.menuStrip_main.TabIndex = 1;
            this.menuStrip_main.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openGarageToolStripMenuItem,
            this.closeGarageToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openGarageToolStripMenuItem
            // 
            this.openGarageToolStripMenuItem.Name = "openGarageToolStripMenuItem";
            this.openGarageToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openGarageToolStripMenuItem.Text = "&Open Garage";
            this.openGarageToolStripMenuItem.Click += new System.EventHandler(this.openGarageToolStripMenuItem_Click);
            // 
            // closeGarageToolStripMenuItem
            // 
            this.closeGarageToolStripMenuItem.Name = "closeGarageToolStripMenuItem";
            this.closeGarageToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeGarageToolStripMenuItem.Text = "&Close Garage";
            this.closeGarageToolStripMenuItem.Click += new System.EventHandler(this.closeGarageToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // fillGarageToolStripMenuItem
            // 
            this.fillGarageToolStripMenuItem.Name = "fillGarageToolStripMenuItem";
            this.fillGarageToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // sourceTuneToolStripMenuItem
            // 
            this.sourceTuneToolStripMenuItem.Name = "sourceTuneToolStripMenuItem";
            this.sourceTuneToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // backgroundWorker_0
            // 
            this.backgroundWorker_0.WorkerReportsProgress = true;
            this.backgroundWorker_0.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_0_DoWork);
            this.backgroundWorker_0.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_0_ProgressChanged);
            // 
            // toolTip_0
            // 
            this.toolTip_0.AutomaticDelay = 300;
            this.toolTip_0.AutoPopDelay = 30000;
            this.toolTip_0.InitialDelay = 300;
            this.toolTip_0.ReshowDelay = 60;
            this.toolTip_0.ShowAlways = true;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(6, 21);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(243, 21);
            this.comboBox2.TabIndex = 0;
            this.toolTip_0.SetToolTip(this.comboBox2, "Choose Database Tuner");
            // 
            // comboBox3
            // 
            this.comboBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(6, 48);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(243, 21);
            this.comboBox3.TabIndex = 1;
            this.toolTip_0.SetToolTip(this.comboBox3, "Choose Database Model");
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(6, 195);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(243, 322);
            this.dataGridView1.TabIndex = 1;
            this.toolTip_0.SetToolTip(this.dataGridView1, "Click these Items to swap them to the right");
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Item";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle5.Format = "X8";
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn2.HeaderText = "Value";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 123;
            // 
            // comboBox4
            // 
            this.comboBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(6, 19);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(243, 21);
            this.comboBox4.TabIndex = 16;
            this.toolTip_0.SetToolTip(this.comboBox4, "Choose Tuner from your garage");
            // 
            // groupBox10
            // 
            this.groupBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox10.Controls.Add(this.radioButton1);
            this.groupBox10.Controls.Add(this.radioButton2);
            this.groupBox10.Controls.Add(this.radioButton3);
            this.groupBox10.Enabled = false;
            this.groupBox10.Location = new System.Drawing.Point(6, 153);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(244, 34);
            this.groupBox10.TabIndex = 54;
            this.groupBox10.TabStop = false;
            this.toolTip_0.SetToolTip(this.groupBox10, "Select which Tune to alter");
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(178, 11);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(60, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tune C";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(92, 11);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(60, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Tune B";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 11);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(60, 17);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Tune A";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // comboBox5
            // 
            this.comboBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(6, 46);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(243, 21);
            this.comboBox5.TabIndex = 17;
            this.toolTip_0.SetToolTip(this.comboBox5, "Choose Model from your garage");
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView2.Location = new System.Drawing.Point(6, 193);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView2.ShowRowErrors = false;
            this.dataGridView2.Size = new System.Drawing.Size(243, 322);
            this.dataGridView2.TabIndex = 24;
            this.toolTip_0.SetToolTip(this.dataGridView2, "Type 8 digit hex string followed by Enter key to change values");
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn3.HeaderText = "Item";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.Format = "X8";
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn4.HeaderText = "Value";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn4.Width = 123;
            // 
            // comboBox6
            // 
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100",
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "109",
            "110",
            "111",
            "112",
            "113",
            "114",
            "115",
            "116",
            "117",
            "118",
            "119",
            "120",
            "121",
            "122",
            "123",
            "124",
            "125",
            "126",
            "127",
            "128",
            "129",
            "130",
            "131",
            "132",
            "133",
            "134",
            "135",
            "136",
            "137",
            "138",
            "139",
            "140",
            "141",
            "142",
            "143",
            "144",
            "145",
            "146",
            "147",
            "148",
            "149",
            "150",
            "151",
            "152",
            "153",
            "154",
            "155",
            "156",
            "157",
            "158",
            "159",
            "160",
            "161",
            "162",
            "163",
            "164",
            "165",
            "166",
            "167",
            "168",
            "169",
            "170",
            "171",
            "172",
            "173",
            "174",
            "175",
            "176",
            "177",
            "178",
            "179",
            "180",
            "181",
            "182",
            "183",
            "184",
            "185",
            "186",
            "187",
            "188",
            "189",
            "190",
            "191",
            "192",
            "193",
            "194",
            "195",
            "196",
            "197",
            "198",
            "199",
            "200",
            "201",
            "202",
            "203",
            "204",
            "205",
            "206",
            "207",
            "208",
            "209",
            "210",
            "211",
            "212",
            "213",
            "214",
            "215",
            "216",
            "217",
            "218",
            "219",
            "220",
            "221",
            "222",
            "223",
            "224",
            "225",
            "226",
            "227",
            "228",
            "229",
            "230",
            "231",
            "232",
            "233",
            "234",
            "235",
            "236",
            "237",
            "238",
            "239",
            "240",
            "241",
            "242",
            "243",
            "244",
            "245",
            "246",
            "247",
            "248",
            "249",
            "250",
            "251",
            "252",
            "253",
            "254",
            "255",
            "256",
            "257",
            "258",
            "259",
            "260",
            "261",
            "262",
            "263",
            "264",
            "265",
            "266",
            "267",
            "268",
            "269",
            "270",
            "271",
            "272",
            "273",
            "274",
            "275",
            "276",
            "277",
            "278",
            "279",
            "280",
            "281",
            "282",
            "283",
            "284",
            "285",
            "286",
            "287",
            "288",
            "289",
            "290",
            "291",
            "292",
            "293",
            "294",
            "295",
            "296",
            "297",
            "298",
            "299",
            "300",
            "301",
            "302",
            "303",
            "304",
            "305",
            "306",
            "307",
            "308",
            "309",
            "310",
            "311",
            "312",
            "313",
            "314",
            "315",
            "316",
            "317",
            "318",
            "319",
            "320",
            "321",
            "322",
            "323",
            "324",
            "325",
            "326",
            "327",
            "328",
            "329",
            "330",
            "331",
            "332",
            "333",
            "334",
            "335",
            "336",
            "337",
            "338",
            "339",
            "340",
            "341",
            "342",
            "343",
            "344",
            "345",
            "346",
            "347",
            "348",
            "349",
            "350",
            "351",
            "352",
            "353",
            "354",
            "355",
            "356",
            "357",
            "358",
            "359",
            "360",
            "361",
            "362",
            "363",
            "364",
            "365",
            "366",
            "367",
            "368",
            "369",
            "370",
            "371",
            "372",
            "373",
            "374",
            "375",
            "376",
            "377",
            "378",
            "379",
            "380",
            "381",
            "382",
            "383",
            "384",
            "385",
            "386",
            "387",
            "388",
            "389",
            "390",
            "391",
            "392",
            "393",
            "394",
            "395",
            "396",
            "397",
            "398",
            "399",
            "400",
            "401",
            "402",
            "403",
            "404",
            "405",
            "406",
            "407",
            "408",
            "409",
            "410",
            "411",
            "412",
            "413",
            "414",
            "415",
            "416",
            "417",
            "418",
            "419",
            "420",
            "421",
            "422",
            "423",
            "424",
            "425",
            "426",
            "427",
            "428",
            "429",
            "430",
            "431",
            "432",
            "433",
            "434",
            "435",
            "436",
            "437",
            "438",
            "439",
            "440",
            "441",
            "442",
            "443",
            "444",
            "445",
            "446",
            "447",
            "448",
            "449",
            "450",
            "451",
            "452",
            "453",
            "454",
            "455",
            "456",
            "457",
            "458",
            "459",
            "460",
            "461",
            "462",
            "463",
            "464",
            "465",
            "466",
            "467",
            "468",
            "469",
            "470",
            "471",
            "472",
            "473",
            "474",
            "475",
            "476",
            "477",
            "478",
            "479",
            "480",
            "481",
            "482",
            "483",
            "484",
            "485",
            "486",
            "487",
            "488",
            "489",
            "490",
            "491",
            "492",
            "493",
            "494",
            "495",
            "496",
            "497",
            "498",
            "499",
            "500",
            "501",
            "502",
            "503",
            "504",
            "505",
            "506",
            "507",
            "508",
            "509",
            "510"});
            this.comboBox6.Location = new System.Drawing.Point(8, 19);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 21);
            this.comboBox6.TabIndex = 0;
            this.toolTip_0.SetToolTip(this.comboBox6, "Car Ticket Number");
            // 
            // comboBox7
            // 
            this.comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox7.Location = new System.Drawing.Point(8, 19);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(121, 21);
            this.comboBox7.TabIndex = 0;
            this.toolTip_0.SetToolTip(this.comboBox7, "Paint Category");
            // 
            // comboBox8
            // 
            this.comboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100",
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "109",
            "110",
            "111",
            "112",
            "113",
            "114",
            "115",
            "116",
            "117",
            "118",
            "119",
            "120",
            "121",
            "122",
            "123",
            "124",
            "125",
            "126",
            "127",
            "128",
            "129",
            "130",
            "131",
            "132",
            "133",
            "134",
            "135",
            "136",
            "137",
            "138",
            "139",
            "140",
            "141",
            "142",
            "143",
            "144",
            "145",
            "146",
            "147",
            "148",
            "149",
            "150",
            "151",
            "152",
            "153",
            "154",
            "155",
            "156",
            "157",
            "158",
            "159",
            "160",
            "161",
            "162",
            "163",
            "164",
            "165",
            "166",
            "167",
            "168",
            "169",
            "170",
            "171",
            "172",
            "173",
            "174",
            "175",
            "176",
            "177",
            "178",
            "179",
            "180",
            "181",
            "182",
            "183",
            "184",
            "185",
            "186",
            "187",
            "188",
            "189",
            "190",
            "191",
            "192",
            "193",
            "194",
            "195",
            "196",
            "197",
            "198",
            "199",
            "200",
            "201",
            "202",
            "203",
            "204",
            "205",
            "206",
            "207",
            "208",
            "209",
            "210",
            "211",
            "212",
            "213",
            "214",
            "215",
            "216",
            "217",
            "218",
            "219",
            "220",
            "221",
            "222",
            "223",
            "224",
            "225",
            "226",
            "227",
            "228",
            "229",
            "230",
            "231",
            "232",
            "233",
            "234",
            "235",
            "236",
            "237",
            "238",
            "239",
            "240",
            "241",
            "242",
            "243",
            "244",
            "245",
            "246",
            "247",
            "248",
            "249",
            "250",
            "251",
            "252",
            "253",
            "254",
            "255",
            "256",
            "257",
            "258",
            "259",
            "260",
            "261",
            "262",
            "263",
            "264",
            "265",
            "266",
            "267",
            "268",
            "269",
            "270",
            "271",
            "272",
            "273",
            "274",
            "275",
            "276",
            "277",
            "278",
            "279",
            "280",
            "281",
            "282",
            "283",
            "284",
            "285",
            "286",
            "287",
            "288",
            "289",
            "290",
            "291",
            "292",
            "293",
            "294",
            "295",
            "296",
            "297",
            "298",
            "299",
            "300",
            "301",
            "302",
            "303",
            "304",
            "305",
            "306",
            "307",
            "308",
            "309",
            "310",
            "311",
            "312",
            "313",
            "314",
            "315",
            "316",
            "317",
            "318",
            "319",
            "320",
            "321",
            "322",
            "323",
            "324",
            "325",
            "326",
            "327",
            "328",
            "329",
            "330",
            "331",
            "332",
            "333",
            "334",
            "335",
            "336",
            "337",
            "338",
            "339",
            "340",
            "341",
            "342",
            "343",
            "344",
            "345",
            "346",
            "347",
            "348",
            "349",
            "350",
            "351",
            "352",
            "353",
            "354",
            "355",
            "356",
            "357",
            "358",
            "359",
            "360",
            "361",
            "362",
            "363",
            "364",
            "365",
            "366",
            "367",
            "368",
            "369",
            "370",
            "371",
            "372",
            "373",
            "374",
            "375",
            "376",
            "377",
            "378",
            "379",
            "380",
            "381",
            "382",
            "383",
            "384",
            "385",
            "386",
            "387",
            "388",
            "389",
            "390",
            "391",
            "392",
            "393",
            "394",
            "395",
            "396",
            "397",
            "398",
            "399",
            "400",
            "401",
            "402",
            "403",
            "404",
            "405",
            "406",
            "407",
            "408",
            "409",
            "410",
            "411",
            "412",
            "413",
            "414",
            "415",
            "416",
            "417",
            "418",
            "419",
            "420",
            "421",
            "422",
            "423",
            "424",
            "425",
            "426",
            "427",
            "428",
            "429",
            "430",
            "431",
            "432",
            "433",
            "434",
            "435",
            "436",
            "437",
            "438",
            "439",
            "440",
            "441",
            "442",
            "443",
            "444",
            "445",
            "446",
            "447",
            "448",
            "449",
            "450",
            "451",
            "452",
            "453",
            "454",
            "455",
            "456",
            "457",
            "458",
            "459",
            "460",
            "461",
            "462",
            "463",
            "464",
            "465",
            "466",
            "467",
            "468",
            "469",
            "470",
            "471",
            "472",
            "473",
            "474",
            "475",
            "476",
            "477",
            "478",
            "479",
            "480",
            "481",
            "482",
            "483",
            "484",
            "485",
            "486",
            "487",
            "488",
            "489",
            "490",
            "491",
            "492",
            "493",
            "494",
            "495",
            "496",
            "497",
            "498",
            "499",
            "500",
            "501",
            "502",
            "503",
            "504",
            "505",
            "506",
            "507",
            "508",
            "509",
            "510",
            "511",
            "512",
            "513",
            "514",
            "515",
            "516",
            "517",
            "518",
            "519",
            "520",
            "521",
            "522",
            "523",
            "524",
            "525",
            "526",
            "527",
            "528",
            "529",
            "530",
            "531",
            "532",
            "533",
            "534",
            "535",
            "536",
            "537",
            "538",
            "539",
            "540",
            "541",
            "542",
            "543",
            "544",
            "545",
            "546",
            "547",
            "548",
            "549",
            "550",
            "551",
            "552",
            "553",
            "554",
            "555",
            "556",
            "557",
            "558",
            "559",
            "560",
            "561",
            "562",
            "563",
            "564",
            "565",
            "566",
            "567",
            "568",
            "569",
            "570",
            "571",
            "572",
            "573",
            "574",
            "575",
            "576",
            "577",
            "578",
            "579",
            "580",
            "581",
            "582",
            "583",
            "584",
            "585",
            "586",
            "587",
            "588",
            "589",
            "590",
            "591",
            "592",
            "593",
            "594",
            "595",
            "596",
            "597",
            "598",
            "599",
            "600",
            "601",
            "602",
            "603",
            "604",
            "605",
            "606",
            "607",
            "608",
            "609",
            "610",
            "611",
            "612",
            "613",
            "614",
            "615",
            "616",
            "617",
            "618",
            "619",
            "620",
            "621",
            "622",
            "623",
            "624",
            "625",
            "626",
            "627",
            "628",
            "629",
            "630",
            "631",
            "632",
            "633",
            "634",
            "635",
            "636",
            "637",
            "638",
            "639",
            "640",
            "641",
            "642",
            "643",
            "644",
            "645",
            "646",
            "647",
            "648",
            "649",
            "650",
            "651",
            "652",
            "653",
            "654",
            "655",
            "656",
            "657",
            "658",
            "659",
            "660",
            "661",
            "662",
            "663",
            "664",
            "665",
            "666",
            "667",
            "668",
            "669",
            "670",
            "671",
            "672",
            "673",
            "674",
            "675",
            "676",
            "677",
            "678",
            "679",
            "680",
            "681",
            "682",
            "683",
            "684",
            "685",
            "686",
            "687",
            "688",
            "689",
            "690",
            "691",
            "692",
            "693",
            "694",
            "695",
            "696",
            "697",
            "698",
            "699",
            "700",
            "701",
            "702",
            "703",
            "704",
            "705",
            "706",
            "707",
            "708",
            "709",
            "710",
            "711",
            "712",
            "713",
            "714",
            "715",
            "716",
            "717",
            "718",
            "719",
            "720",
            "721",
            "722",
            "723",
            "724",
            "725",
            "726",
            "727",
            "728",
            "729",
            "730",
            "731",
            "732",
            "733",
            "734",
            "735",
            "736",
            "737",
            "738",
            "739",
            "740",
            "741",
            "742",
            "743",
            "744",
            "745",
            "746",
            "747",
            "748",
            "749",
            "750",
            "751",
            "752",
            "753",
            "754",
            "755",
            "756",
            "757",
            "758",
            "759",
            "760",
            "761",
            "762",
            "763",
            "764",
            "765",
            "766",
            "767",
            "768",
            "769",
            "770",
            "771",
            "772",
            "773",
            "774",
            "775",
            "776",
            "777",
            "778",
            "779",
            "780",
            "781",
            "782",
            "783",
            "784",
            "785",
            "786",
            "787",
            "788",
            "789",
            "790",
            "791",
            "792",
            "793",
            "794",
            "795",
            "796",
            "797",
            "798",
            "799",
            "800",
            "801",
            "802",
            "803",
            "804",
            "805",
            "806",
            "807",
            "808",
            "809",
            "810",
            "811",
            "812",
            "813",
            "814",
            "815",
            "816",
            "817",
            "818",
            "819",
            "820",
            "821",
            "822",
            "823",
            "824",
            "825",
            "826",
            "827",
            "828",
            "829",
            "830",
            "831",
            "832",
            "833",
            "834",
            "835",
            "836",
            "837",
            "838",
            "839",
            "840",
            "841",
            "842",
            "843",
            "844",
            "845",
            "846",
            "847",
            "848",
            "849",
            "850",
            "851",
            "852",
            "853",
            "854",
            "855",
            "856",
            "857",
            "858",
            "859",
            "860",
            "861",
            "862",
            "863",
            "864",
            "865",
            "866",
            "867",
            "868",
            "869",
            "870",
            "871",
            "872",
            "873",
            "874",
            "875",
            "876",
            "877",
            "878",
            "879",
            "880",
            "881",
            "882",
            "883",
            "884",
            "885",
            "886",
            "887",
            "888",
            "889",
            "890",
            "891",
            "892",
            "893",
            "894",
            "895",
            "896",
            "897",
            "898",
            "899",
            "900",
            "901",
            "902",
            "903",
            "904",
            "905",
            "906",
            "907",
            "908",
            "909",
            "910",
            "911",
            "912",
            "913",
            "914",
            "915",
            "916",
            "917",
            "918",
            "919",
            "920",
            "921",
            "922",
            "923",
            "924",
            "925",
            "926",
            "927",
            "928",
            "929",
            "930",
            "931",
            "932",
            "933",
            "934",
            "935",
            "936",
            "937",
            "938",
            "939",
            "940",
            "941",
            "942",
            "943",
            "944",
            "945",
            "946",
            "947",
            "948",
            "949",
            "950",
            "951",
            "952",
            "953",
            "954",
            "955",
            "956",
            "957",
            "958",
            "959",
            "960",
            "961",
            "962",
            "963",
            "964",
            "965",
            "966",
            "967",
            "968",
            "969",
            "970",
            "971",
            "972",
            "973",
            "974",
            "975",
            "976",
            "977",
            "978",
            "979",
            "980",
            "981",
            "982",
            "983",
            "984",
            "985",
            "986",
            "987",
            "988",
            "989",
            "990",
            "991",
            "992",
            "993",
            "994",
            "995",
            "996",
            "997",
            "998",
            "999",
            "1000",
            "1001",
            "1002",
            "1003",
            "1004",
            "1005",
            "1006",
            "1007",
            "1008",
            "1009",
            "1010",
            "1011",
            "1012",
            "1013",
            "1014",
            "1015",
            "1016",
            "1017",
            "1018",
            "1019",
            "1020",
            "1021",
            "1022",
            "1023",
            "1024",
            "1025",
            "1026",
            "1027",
            "1028",
            "1029",
            "1030",
            "1031",
            "1032",
            "1033",
            "1034",
            "1035",
            "1036",
            "1037",
            "1038",
            "1039",
            "1040",
            "1041",
            "1042",
            "1043",
            "1044",
            "1045",
            "1046",
            "1047",
            "1048",
            "1049",
            "1050",
            "1051",
            "1052",
            "1053",
            "1054",
            "1055",
            "1056",
            "1057",
            "1058",
            "1059",
            "1060",
            "1061",
            "1062",
            "1063",
            "1064",
            "1065",
            "1066",
            "1067",
            "1068",
            "1069",
            "1070",
            "1071",
            "1072",
            "1073",
            "1074",
            "1075",
            "1076",
            "1077",
            "1078",
            "1079",
            "1080",
            "1081",
            "1082",
            "1083",
            "1084",
            "1085",
            "1086",
            "1087",
            "1088",
            "1089",
            "1090",
            "1091",
            "1092",
            "1093",
            "1094",
            "1095",
            "1096",
            "1097",
            "1098",
            "1099",
            "1100",
            "1101",
            "1102",
            "1103",
            "1104",
            "1105",
            "1106",
            "1107",
            "1108",
            "1109",
            "1110",
            "1111",
            "1112",
            "1113",
            "1114",
            "1115",
            "1116",
            "1117",
            "1118",
            "1119",
            "1120",
            "1121",
            "1122",
            "1123",
            "1124",
            "1125",
            "1126",
            "1127",
            "1128",
            "1129",
            "1130",
            "1131",
            "1132",
            "1133",
            "1134",
            "1135",
            "1136",
            "1137",
            "1138",
            "1139",
            "1140",
            "1141",
            "1142",
            "1143",
            "1144",
            "1145",
            "1146",
            "1147",
            "1148",
            "1149",
            "1150",
            "1151",
            "1152",
            "1153",
            "1154",
            "1155",
            "1156",
            "1157",
            "1158",
            "1159",
            "1160",
            "1161",
            "1162",
            "1163",
            "1164",
            "1165",
            "1166",
            "1167",
            "1168",
            "1169",
            "1170",
            "1171",
            "1172",
            "1173",
            "1174",
            "1175",
            "1176",
            "1177",
            "1178",
            "1179",
            "1180",
            "1181",
            "1182",
            "1183",
            "1184",
            "1185",
            "1186",
            "1187",
            "1188",
            "1189",
            "1190",
            "1191",
            "1192",
            "1193",
            "1194",
            "1195",
            "1196",
            "1197",
            "1198",
            "1199",
            "1200",
            "1201",
            "1202",
            "1203",
            "1204",
            "1205",
            "1206",
            "1207",
            "1208",
            "1209",
            "1210",
            "1211",
            "1212",
            "1213",
            "1214",
            "1215",
            "1216",
            "1217",
            "1218",
            "1219",
            "1220",
            "1221",
            "1222",
            "1223",
            "1224",
            "1225",
            "1226",
            "1227",
            "1228",
            "1229",
            "1230",
            "1231",
            "1232",
            "1233",
            "1234",
            "1235",
            "1236",
            "1237",
            "1238",
            "1239",
            "1240",
            "1241",
            "1242",
            "1243",
            "1244",
            "1245",
            "1246",
            "1247",
            "1248",
            "1249",
            "1250",
            "1251",
            "1252",
            "1253",
            "1254",
            "1255",
            "1256",
            "1257",
            "1258",
            "1259",
            "1260",
            "1261",
            "1262",
            "1263",
            "1264",
            "1265",
            "1266",
            "1267",
            "1268",
            "1269",
            "1270",
            "1271",
            "1272",
            "1273",
            "1274",
            "1275",
            "1276",
            "1277",
            "1278",
            "1279",
            "1280",
            "1281",
            "1282",
            "1283",
            "1284",
            "1285",
            "1286",
            "1287",
            "1288",
            "1289",
            "1290",
            "1291",
            "1292",
            "1293",
            "1294",
            "1295",
            "1296",
            "1297",
            "1298",
            "1299",
            "1300",
            "1301",
            "1302",
            "1303",
            "1304",
            "1305",
            "1306",
            "1307",
            "1308",
            "1309",
            "1310",
            "1311",
            "1312",
            "1313",
            "1314",
            "1315",
            "1316",
            "1317",
            "1318",
            "1319",
            "1320",
            "1321",
            "1322",
            "1323",
            "1324",
            "1325",
            "1326",
            "1327",
            "1328",
            "1329",
            "1330",
            "1331",
            "1332",
            "1333",
            "1334",
            "1335",
            "1336",
            "1337",
            "1338",
            "1339",
            "1340",
            "1341",
            "1342",
            "1343",
            "1344",
            "1345",
            "1346",
            "1347",
            "1348",
            "1349",
            "1350",
            "1351",
            "1352",
            "1353",
            "1354",
            "1355",
            "1356",
            "1357",
            "1358",
            "1359",
            "1360",
            "1361",
            "1362",
            "1363",
            "1364",
            "1365",
            "1366",
            "1367",
            "1368",
            "1369",
            "1370",
            "1371",
            "1372",
            "1373",
            "1374",
            "1375",
            "1376",
            "1377",
            "1378",
            "1379",
            "1380",
            "1381",
            "1382",
            "1383",
            "1384",
            "1385",
            "1386",
            "1387",
            "1388",
            "1389",
            "1390",
            "1391",
            "1392",
            "1393",
            "1394",
            "1395",
            "1396",
            "1397",
            "1398",
            "1399",
            "1400",
            "1401",
            "1402",
            "1403",
            "1404",
            "1405",
            "1406",
            "1407",
            "1408",
            "1409",
            "1410",
            "1411",
            "1412",
            "1413",
            "1414",
            "1415",
            "1416",
            "1417",
            "1418",
            "1419",
            "1420",
            "1421",
            "1422",
            "1423",
            "1424",
            "1425",
            "1426",
            "1427",
            "1428",
            "1429",
            "1430",
            "1431",
            "1432",
            "1433",
            "1434",
            "1435",
            "1436",
            "1437",
            "1438",
            "1439",
            "1440",
            "1441",
            "1442",
            "1443",
            "1444",
            "1445",
            "1446",
            "1447",
            "1448",
            "1449",
            "1450",
            "1451",
            "1452",
            "1453",
            "1454",
            "1455",
            "1456",
            "1457",
            "1458",
            "1459",
            "1460",
            "1461",
            "1462",
            "1463",
            "1464",
            "1465",
            "1466",
            "1467",
            "1468",
            "1469",
            "1470",
            "1471",
            "1472",
            "1473",
            "1474",
            "1475",
            "1476",
            "1477",
            "1478",
            "1479",
            "1480",
            "1481",
            "1482",
            "1483",
            "1484",
            "1485",
            "1486",
            "1487",
            "1488",
            "1489",
            "1490",
            "1491",
            "1492",
            "1493",
            "1494",
            "1495",
            "1496",
            "1497",
            "1498",
            "1499",
            "1500",
            "1501",
            "1502",
            "1503",
            "1504",
            "1505",
            "1506",
            "1507",
            "1508",
            "1509",
            "1510",
            "1511",
            "1512",
            "1513",
            "1514",
            "1515",
            "1516",
            "1517",
            "1518",
            "1519",
            "1520",
            "1521",
            "1522",
            "1523",
            "1524",
            "1525",
            "1526",
            "1527",
            "1528",
            "1529",
            "1530",
            "1531",
            "1532",
            "1533",
            "1534",
            "1535",
            "1536",
            "1537",
            "1538",
            "1539",
            "1540",
            "1541",
            "1542",
            "1543",
            "1544",
            "1545",
            "1546",
            "1547",
            "1548",
            "1549",
            "1550",
            "1551",
            "1552",
            "1553",
            "1554",
            "1555",
            "1556",
            "1557",
            "1558",
            "1559",
            "1560",
            "1561",
            "1562",
            "1563",
            "1564",
            "1565",
            "1566",
            "1567",
            "1568",
            "1569",
            "1570",
            "1571",
            "1572",
            "1573",
            "1574",
            "1575",
            "1576",
            "1577",
            "1578",
            "1579",
            "1580",
            "1581",
            "1582",
            "1583",
            "1584",
            "1585",
            "1586",
            "1587",
            "1588",
            "1589",
            "1590",
            "1591",
            "1592",
            "1593",
            "1594",
            "1595",
            "1596",
            "1597",
            "1598",
            "1599",
            "1600",
            "1601",
            "1602",
            "1603",
            "1604",
            "1605",
            "1606",
            "1607",
            "1608",
            "1609",
            "1610",
            "1611",
            "1612",
            "1613",
            "1614",
            "1615",
            "1616",
            "1617",
            "1618",
            "1619",
            "1620",
            "1621",
            "1622",
            "1623",
            "1624",
            "1625",
            "1626",
            "1627",
            "1628",
            "1629",
            "1630",
            "1631",
            "1632",
            "1633",
            "1634",
            "1635",
            "1636",
            "1637",
            "1638",
            "1639",
            "1640",
            "1641",
            "1642",
            "1643",
            "1644",
            "1645",
            "1646",
            "1647",
            "1648",
            "1649",
            "1650",
            "1651",
            "1652",
            "1653",
            "1654",
            "1655",
            "1656",
            "1657",
            "1658",
            "1659",
            "1660",
            "1661",
            "1662",
            "1663",
            "1664",
            "1665",
            "1666",
            "1667",
            "1668",
            "1669",
            "1670",
            "1671",
            "1672",
            "1673",
            "1674",
            "1675",
            "1676",
            "1677",
            "1678",
            "1679",
            "1680",
            "1681",
            "1682",
            "1683",
            "1684",
            "1685",
            "1686",
            "1687",
            "1688",
            "1689",
            "1690",
            "1691",
            "1692",
            "1693",
            "1694",
            "1695",
            "1696",
            "1697",
            "1698",
            "1699",
            "1700",
            "1701",
            "1702",
            "1703",
            "1704",
            "1705",
            "1706",
            "1707",
            "1708",
            "1709",
            "1710",
            "1711",
            "1712",
            "1713",
            "1714",
            "1715",
            "1716",
            "1717",
            "1718",
            "1719",
            "1720",
            "1721",
            "1722",
            "1723",
            "1724",
            "1725",
            "1726",
            "1727",
            "1728",
            "1729",
            "1730",
            "1731",
            "1732",
            "1733",
            "1734",
            "1735",
            "1736",
            "1737",
            "1738",
            "1739",
            "1740",
            "1741",
            "1742",
            "1743",
            "1744",
            "1745",
            "1746",
            "1747",
            "1748",
            "1749",
            "1750",
            "1751",
            "1752",
            "1753",
            "1754",
            "1755",
            "1756",
            "1757",
            "1758",
            "1759",
            "1760",
            "1761",
            "1762",
            "1763",
            "1764",
            "1765",
            "1766",
            "1767",
            "1768",
            "1769",
            "1770",
            "1771",
            "1772",
            "1773",
            "1774",
            "1775",
            "1776",
            "1777",
            "1778",
            "1779",
            "1780",
            "1781",
            "1782",
            "1783",
            "1784",
            "1785",
            "1786",
            "1787",
            "1788",
            "1789",
            "1790",
            "1791",
            "1792",
            "1793",
            "1794",
            "1795",
            "1796",
            "1797",
            "1798",
            "1799",
            "1800",
            "1801",
            "1802",
            "1803",
            "1804",
            "1805",
            "1806",
            "1807",
            "1808",
            "1809",
            "1810",
            "1811",
            "1812",
            "1813",
            "1814",
            "1815",
            "1816",
            "1817",
            "1818",
            "1819",
            "1820",
            "1821",
            "1822",
            "1823",
            "1824",
            "1825",
            "1826",
            "1827",
            "1828",
            "1829",
            "1830",
            "1831",
            "1832",
            "1833",
            "1834",
            "1835",
            "1836",
            "1837",
            "1838",
            "1839",
            "1840",
            "1841",
            "1842",
            "1843",
            "1844",
            "1845",
            "1846",
            "1847",
            "1848",
            "1849",
            "1850",
            "1851",
            "1852",
            "1853",
            "1854",
            "1855",
            "1856",
            "1857",
            "1858",
            "1859",
            "1860",
            "1861",
            "1862",
            "1863",
            "1864",
            "1865",
            "1866",
            "1867",
            "1868",
            "1869",
            "1870",
            "1871",
            "1872",
            "1873",
            "1874",
            "1875",
            "1876",
            "1877",
            "1878",
            "1879",
            "1880",
            "1881",
            "1882",
            "1883",
            "1884",
            "1885",
            "1886",
            "1887",
            "1888",
            "1889",
            "1890",
            "1891",
            "1892",
            "1893",
            "1894",
            "1895",
            "1896",
            "1897",
            "1898",
            "1899",
            "1900",
            "1901",
            "1902",
            "1903",
            "1904",
            "1905",
            "1906",
            "1907",
            "1908",
            "1909",
            "1910",
            "1911",
            "1912",
            "1913",
            "1914",
            "1915",
            "1916",
            "1917",
            "1918",
            "1919",
            "1920",
            "1921",
            "1922",
            "1923",
            "1924",
            "1925",
            "1926",
            "1927",
            "1928",
            "1929",
            "1930",
            "1931",
            "1932",
            "1933",
            "1934",
            "1935",
            "1936",
            "1937",
            "1938",
            "1939",
            "1940",
            "1941",
            "1942",
            "1943",
            "1944",
            "1945",
            "1946",
            "1947",
            "1948",
            "1949",
            "1950",
            "1951",
            "1952",
            "1953",
            "1954",
            "1955",
            "1956",
            "1957",
            "1958",
            "1959",
            "1960",
            "1961",
            "1962",
            "1963",
            "1964",
            "1965",
            "1966",
            "1967",
            "1968",
            "1969",
            "1970",
            "1971",
            "1972",
            "1973",
            "1974",
            "1975",
            "1976",
            "1977",
            "1978",
            "1979",
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035",
            "2036",
            "2037",
            "2038",
            "2039",
            "2040",
            "2041",
            "2042",
            "2043",
            "2044",
            "2045",
            "2046",
            "2047",
            "2048",
            "2049",
            "2050",
            "2051",
            "2052",
            "2053",
            "2054",
            "2055",
            "2056",
            "2057",
            "2058",
            "2059",
            "2060",
            "2061",
            "2062",
            "2063",
            "2064",
            "2065",
            "2066",
            "2067",
            "2068",
            "2069",
            "2070",
            "2071",
            "2072",
            "2073",
            "2074",
            "2075",
            "2076",
            "2077",
            "2078",
            "2079",
            "2080",
            "2081",
            "2082",
            "2083",
            "2084",
            "2085",
            "2086",
            "2087",
            "2088",
            "2089",
            "2090",
            "2091",
            "2092",
            "2093",
            "2094",
            "2095",
            "2096",
            "2097",
            "2098",
            "2099",
            "2100",
            "2101",
            "2102",
            "2103",
            "2104",
            "2105",
            "2106",
            "2107",
            "2108",
            "2109",
            "2110",
            "2111",
            "2112",
            "2113",
            "2114",
            "2115",
            "2116",
            "2117",
            "2118",
            "2119",
            "2120",
            "2121",
            "2122",
            "2123",
            "2124",
            "2125",
            "2126",
            "2127",
            "2128",
            "2129",
            "2130",
            "2131",
            "2132",
            "2133",
            "2134",
            "2135",
            "2136",
            "2137",
            "2138",
            "2139",
            "2140",
            "2141",
            "2142",
            "2143",
            "2144",
            "2145",
            "2146",
            "2147",
            "2148",
            "2149",
            "2150",
            "2151",
            "2152",
            "2153",
            "2154",
            "2155",
            "2156",
            "2157",
            "2158",
            "2159",
            "2160",
            "2161",
            "2162",
            "2163",
            "2164",
            "2165",
            "2166",
            "2167",
            "2168",
            "2169",
            "2170",
            "2171",
            "2172",
            "2173",
            "2174",
            "2175",
            "2176",
            "2177",
            "2178",
            "2179",
            "2180",
            "2181",
            "2182",
            "2183",
            "2184",
            "2185",
            "2186",
            "2187",
            "2188",
            "2189",
            "2190",
            "2191",
            "2192",
            "2193",
            "2194",
            "2195",
            "2196",
            "2197",
            "2198",
            "2199",
            "2200",
            "2201",
            "2202",
            "2203",
            "2204",
            "2205",
            "2206",
            "2207",
            "2208",
            "2209",
            "2210",
            "2211",
            "2212",
            "2213",
            "2214",
            "2215",
            "2216",
            "2217",
            "2218",
            "2219",
            "2220",
            "2221",
            "2222",
            "2223",
            "2224",
            "2225",
            "2226",
            "2227",
            "2228",
            "2229",
            "2230",
            "2231",
            "2232",
            "2233",
            "2234",
            "2235",
            "2236",
            "2237",
            "2238",
            "2239",
            "2240",
            "2241",
            "2242",
            "2243",
            "2244",
            "2245",
            "2246",
            "2247",
            "2248",
            "2249",
            "2250",
            "2251",
            "2252",
            "2253",
            "2254",
            "2255",
            "2256",
            "2257",
            "2258",
            "2259",
            "2260",
            "2261",
            "2262",
            "2263",
            "2264",
            "2265",
            "2266",
            "2267",
            "2268",
            "2269",
            "2270",
            "2271",
            "2272",
            "2273",
            "2274",
            "2275",
            "2276",
            "2277",
            "2278",
            "2279",
            "2280",
            "2281",
            "2282",
            "2283",
            "2284",
            "2285",
            "2286",
            "2287",
            "2288",
            "2289",
            "2290",
            "2291",
            "2292",
            "2293",
            "2294",
            "2295",
            "2296",
            "2297",
            "2298",
            "2299",
            "2300",
            "2301",
            "2302",
            "2303",
            "2304",
            "2305",
            "2306",
            "2307",
            "2308",
            "2309",
            "2310",
            "2311",
            "2312",
            "2313",
            "2314",
            "2315",
            "2316",
            "2317",
            "2318",
            "2319",
            "2320",
            "2321",
            "2322",
            "2323",
            "2324",
            "2325",
            "2326",
            "2327",
            "2328",
            "2329",
            "2330",
            "2331",
            "2332",
            "2333",
            "2334",
            "2335",
            "2336",
            "2337",
            "2338",
            "2339",
            "2340",
            "2341",
            "2342",
            "2343",
            "2344",
            "2345",
            "2346",
            "2347",
            "2348",
            "2349",
            "2350",
            "2351",
            "2352",
            "2353",
            "2354",
            "2355",
            "2356",
            "2357",
            "2358",
            "2359",
            "2360",
            "2361",
            "2362",
            "2363",
            "2364",
            "2365",
            "2366",
            "2367",
            "2368",
            "2369",
            "2370",
            "2371",
            "2372",
            "2373",
            "2374",
            "2375",
            "2376",
            "2377",
            "2378",
            "2379",
            "2380",
            "2381",
            "2382",
            "2383",
            "2384",
            "2385",
            "2386",
            "2387",
            "2388",
            "2389",
            "2390",
            "2391",
            "2392",
            "2393",
            "2394",
            "2395",
            "2396",
            "2397",
            "2398",
            "2399",
            "2400",
            "2401",
            "2402",
            "2403",
            "2404",
            "2405",
            "2406",
            "2407",
            "2408",
            "2409",
            "2410",
            "2411",
            "2412",
            "2413",
            "2414",
            "2415",
            "2416",
            "2417",
            "2418",
            "2419",
            "2420",
            "2421",
            "2422",
            "2423",
            "2424",
            "2425",
            "2426",
            "2427",
            "2428",
            "2429",
            "2430",
            "2431",
            "2432",
            "2433",
            "2434",
            "2435",
            "2436",
            "2437",
            "2438",
            "2439",
            "2440",
            "2441",
            "2442",
            "2443",
            "2444",
            "2445",
            "2446",
            "2447",
            "2448",
            "2449",
            "2450",
            "2451",
            "2452",
            "2453",
            "2454",
            "2455",
            "2456",
            "2457",
            "2458",
            "2459",
            "2460",
            "2461",
            "2462",
            "2463",
            "2464",
            "2465",
            "2466",
            "2467",
            "2468",
            "2469",
            "2470",
            "2471",
            "2472",
            "2473",
            "2474",
            "2475",
            "2476",
            "2477",
            "2478",
            "2479",
            "2480",
            "2481",
            "2482",
            "2483",
            "2484",
            "2485",
            "2486",
            "2487",
            "2488",
            "2489",
            "2490",
            "2491",
            "2492",
            "2493",
            "2494",
            "2495",
            "2496",
            "2497",
            "2498",
            "2499",
            "2500",
            "2501",
            "2502",
            "2503",
            "2504",
            "2505",
            "2506",
            "2507",
            "2508",
            "2509",
            "2510",
            "2511",
            "2512",
            "2513",
            "2514",
            "2515",
            "2516",
            "2517",
            "2518",
            "2519",
            "2520",
            "2521",
            "2522",
            "2523",
            "2524",
            "2525",
            "2526",
            "2527",
            "2528",
            "2529",
            "2530",
            "2531",
            "2532",
            "2533",
            "2534",
            "2535",
            "2536",
            "2537",
            "2538",
            "2539",
            "2540",
            "2541",
            "2542",
            "2543",
            "2544",
            "2545",
            "2546",
            "2547",
            "2548",
            "2549",
            "2550",
            "2551",
            "2552",
            "2553",
            "2554",
            "2555",
            "2556",
            "2557",
            "2558",
            "2559",
            "2560",
            "2561",
            "2562",
            "2563",
            "2564",
            "2565",
            "2566",
            "2567",
            "2568",
            "2569",
            "2570",
            "2571",
            "2572",
            "2573",
            "2574",
            "2575",
            "2576",
            "2577",
            "2578",
            "2579",
            "2580",
            "2581",
            "2582",
            "2583",
            "2584",
            "2585",
            "2586",
            "2587",
            "2588",
            "2589",
            "2590",
            "2591",
            "2592",
            "2593",
            "2594",
            "2595",
            "2596",
            "2597",
            "2598",
            "2599",
            "2600",
            "2601",
            "2602",
            "2603",
            "2604",
            "2605",
            "2606",
            "2607",
            "2608",
            "2609",
            "2610",
            "2611",
            "2612",
            "2613",
            "2614",
            "2615",
            "2616",
            "2617",
            "2618",
            "2619",
            "2620",
            "2621",
            "2622",
            "2623",
            "2624",
            "2625",
            "2626",
            "2627",
            "2628",
            "2629",
            "2630",
            "2631",
            "2632",
            "2633",
            "2634",
            "2635",
            "2636",
            "2637",
            "2638",
            "2639",
            "2640",
            "2641",
            "2642",
            "2643",
            "2644",
            "2645",
            "2646",
            "2647",
            "2648",
            "2649",
            "2650",
            "2651",
            "2652",
            "2653",
            "2654",
            "2655",
            "2656",
            "2657",
            "2658",
            "2659",
            "2660",
            "2661",
            "2662",
            "2663",
            "2664",
            "2665",
            "2666",
            "2667",
            "2668",
            "2669",
            "2670",
            "2671",
            "2672",
            "2673",
            "2674",
            "2675",
            "2676",
            "2677",
            "2678",
            "2679",
            "2680",
            "2681",
            "2682",
            "2683",
            "2684",
            "2685",
            "2686",
            "2687",
            "2688",
            "2689",
            "2690",
            "2691",
            "2692",
            "2693",
            "2694",
            "2695",
            "2696",
            "2697",
            "2698",
            "2699",
            "2700",
            "2701",
            "2702",
            "2703",
            "2704",
            "2705",
            "2706",
            "2707",
            "2708",
            "2709",
            "2710",
            "2711",
            "2712",
            "2713",
            "2714",
            "2715",
            "2716",
            "2717",
            "2718",
            "2719",
            "2720",
            "2721",
            "2722",
            "2723",
            "2724",
            "2725",
            "2726",
            "2727",
            "2728",
            "2729",
            "2730",
            "2731",
            "2732",
            "2733",
            "2734",
            "2735",
            "2736",
            "2737",
            "2738",
            "2739",
            "2740",
            "2741",
            "2742",
            "2743",
            "2744",
            "2745",
            "2746",
            "2747",
            "2748",
            "2749",
            "2750",
            "2751",
            "2752",
            "2753",
            "2754",
            "2755",
            "2756",
            "2757",
            "2758",
            "2759",
            "2760",
            "2761",
            "2762",
            "2763",
            "2764",
            "2765",
            "2766",
            "2767",
            "2768",
            "2769",
            "2770",
            "2771",
            "2772",
            "2773",
            "2774",
            "2775",
            "2776",
            "2777",
            "2778",
            "2779",
            "2780",
            "2781",
            "2782",
            "2783",
            "2784",
            "2785",
            "2786",
            "2787",
            "2788",
            "2789",
            "2790",
            "2791",
            "2792",
            "2793",
            "2794",
            "2795",
            "2796",
            "2797",
            "2798",
            "2799",
            "2800",
            "2801",
            "2802",
            "2803",
            "2804",
            "2805",
            "2806",
            "2807",
            "2808",
            "2809",
            "2810",
            "2811",
            "2812",
            "2813",
            "2814",
            "2815",
            "2816",
            "2817",
            "2818",
            "2819",
            "2820",
            "2821",
            "2822",
            "2823",
            "2824",
            "2825",
            "2826",
            "2827",
            "2828",
            "2829",
            "2830",
            "2831",
            "2832",
            "2833",
            "2834",
            "2835",
            "2836",
            "2837",
            "2838",
            "2839",
            "2840",
            "2841",
            "2842",
            "2843",
            "2844",
            "2845",
            "2846",
            "2847",
            "2848",
            "2849",
            "2850",
            "2851",
            "2852",
            "2853",
            "2854",
            "2855",
            "2856",
            "2857",
            "2858",
            "2859",
            "2860",
            "2861",
            "2862",
            "2863",
            "2864",
            "2865",
            "2866",
            "2867",
            "2868",
            "2869",
            "2870",
            "2871",
            "2872",
            "2873",
            "2874",
            "2875",
            "2876",
            "2877",
            "2878",
            "2879",
            "2880",
            "2881",
            "2882",
            "2883",
            "2884",
            "2885",
            "2886",
            "2887",
            "2888",
            "2889",
            "2890",
            "2891",
            "2892",
            "2893",
            "2894",
            "2895",
            "2896",
            "2897",
            "2898",
            "2899",
            "2900",
            "2901",
            "2902",
            "2903",
            "2904",
            "2905",
            "2906",
            "2907",
            "2908",
            "2909",
            "2910",
            "2911",
            "2912",
            "2913",
            "2914",
            "2915",
            "2916",
            "2917",
            "2918",
            "2919",
            "2920",
            "2921",
            "2922",
            "2923",
            "2924",
            "2925",
            "2926",
            "2927",
            "2928",
            "2929",
            "2930",
            "2931",
            "2932",
            "2933",
            "2934",
            "2935",
            "2936",
            "2937",
            "2938",
            "2939",
            "2940",
            "2941",
            "2942",
            "2943",
            "2944",
            "2945",
            "2946",
            "2947",
            "2948",
            "2949",
            "2950",
            "2951",
            "2952",
            "2953",
            "2954",
            "2955",
            "2956",
            "2957",
            "2958",
            "2959",
            "2960",
            "2961",
            "2962",
            "2963",
            "2964",
            "2965",
            "2966",
            "2967",
            "2968",
            "2969",
            "2970",
            "2971",
            "2972",
            "2973",
            "2974",
            "2975",
            "2976",
            "2977",
            "2978",
            "2979",
            "2980",
            "2981",
            "2982",
            "2983",
            "2984",
            "2985",
            "2986",
            "2987",
            "2988",
            "2989",
            "2990",
            "2991",
            "2992",
            "2993",
            "2994",
            "2995",
            "2996",
            "2997",
            "2998",
            "2999",
            "3000",
            "3001",
            "3002",
            "3003",
            "3004",
            "3005",
            "3006",
            "3007",
            "3008",
            "3009",
            "3010",
            "3011",
            "3012",
            "3013",
            "3014",
            "3015",
            "3016",
            "3017",
            "3018",
            "3019",
            "3020",
            "3021",
            "3022",
            "3023",
            "3024",
            "3025",
            "3026",
            "3027",
            "3028",
            "3029",
            "3030",
            "3031",
            "3032",
            "3033",
            "3034",
            "3035",
            "3036",
            "3037",
            "3038",
            "3039",
            "3040",
            "3041",
            "3042",
            "3043",
            "3044",
            "3045",
            "3046",
            "3047",
            "3048",
            "3049",
            "3050",
            "3051",
            "3052",
            "3053",
            "3054",
            "3055",
            "3056",
            "3057",
            "3058",
            "3059",
            "3060",
            "3061",
            "3062",
            "3063",
            "3064",
            "3065",
            "3066",
            "3067",
            "3068",
            "3069",
            "3070",
            "3071",
            "3072",
            "3073",
            "3074",
            "3075",
            "3076",
            "3077",
            "3078",
            "3079",
            "3080",
            "3081",
            "3082",
            "3083",
            "3084",
            "3085",
            "3086",
            "3087",
            "3088",
            "3089",
            "3090",
            "3091",
            "3092",
            "3093",
            "3094",
            "3095",
            "3096",
            "3097",
            "3098",
            "3099",
            "3100",
            "3101",
            "3102",
            "3103",
            "3104",
            "3105",
            "3106",
            "3107",
            "3108",
            "3109",
            "3110",
            "3111",
            "3112",
            "3113",
            "3114",
            "3115",
            "3116",
            "3117",
            "3118",
            "3119",
            "3120",
            "3121",
            "3122",
            "3123",
            "3124",
            "3125",
            "3126",
            "3127",
            "3128",
            "3129",
            "3130",
            "3131",
            "3132",
            "3133",
            "3134",
            "3135",
            "3136",
            "3137",
            "3138",
            "3139",
            "3140",
            "3141",
            "3142",
            "3143",
            "3144",
            "3145",
            "3146",
            "3147",
            "3148",
            "3149",
            "3150",
            "3151",
            "3152",
            "3153",
            "3154",
            "3155",
            "3156",
            "3157",
            "3158",
            "3159",
            "3160",
            "3161",
            "3162",
            "3163",
            "3164",
            "3165",
            "3166",
            "3167",
            "3168",
            "3169",
            "3170",
            "3171",
            "3172",
            "3173",
            "3174",
            "3175",
            "3176",
            "3177",
            "3178",
            "3179",
            "3180",
            "3181",
            "3182",
            "3183",
            "3184",
            "3185",
            "3186",
            "3187",
            "3188",
            "3189",
            "3190",
            "3191",
            "3192",
            "3193",
            "3194",
            "3195",
            "3196",
            "3197",
            "3198",
            "3199",
            "3200",
            "3201",
            "3202",
            "3203",
            "3204",
            "3205",
            "3206",
            "3207",
            "3208",
            "3209",
            "3210",
            "3211",
            "3212",
            "3213",
            "3214",
            "3215",
            "3216",
            "3217",
            "3218",
            "3219",
            "3220",
            "3221",
            "3222",
            "3223",
            "3224",
            "3225",
            "3226",
            "3227",
            "3228",
            "3229",
            "3230",
            "3231",
            "3232",
            "3233",
            "3234",
            "3235",
            "3236",
            "3237",
            "3238",
            "3239",
            "3240",
            "3241",
            "3242",
            "3243",
            "3244",
            "3245",
            "3246",
            "3247",
            "3248",
            "3249",
            "3250",
            "3251",
            "3252",
            "3253",
            "3254",
            "3255",
            "3256",
            "3257",
            "3258",
            "3259",
            "3260",
            "3261",
            "3262",
            "3263",
            "3264",
            "3265",
            "3266",
            "3267",
            "3268",
            "3269",
            "3270",
            "3271",
            "3272",
            "3273",
            "3274",
            "3275",
            "3276",
            "3277",
            "3278",
            "3279",
            "3280",
            "3281",
            "3282",
            "3283",
            "3284",
            "3285",
            "3286",
            "3287",
            "3288",
            "3289",
            "3290",
            "3291",
            "3292",
            "3293",
            "3294",
            "3295",
            "3296",
            "3297",
            "3298",
            "3299",
            "3300",
            "3301",
            "3302",
            "3303",
            "3304",
            "3305",
            "3306",
            "3307",
            "3308",
            "3309",
            "3310",
            "3311",
            "3312",
            "3313",
            "3314",
            "3315",
            "3316",
            "3317",
            "3318",
            "3319",
            "3320",
            "3321",
            "3322",
            "3323",
            "3324",
            "3325",
            "3326",
            "3327",
            "3328",
            "3329",
            "3330",
            "3331",
            "3332",
            "3333",
            "3334",
            "3335",
            "3336",
            "3337",
            "3338",
            "3339",
            "3340",
            "3341",
            "3342",
            "3343",
            "3344",
            "3345",
            "3346",
            "3347",
            "3348",
            "3349",
            "3350",
            "3351",
            "3352",
            "3353",
            "3354",
            "3355",
            "3356",
            "3357",
            "3358",
            "3359",
            "3360",
            "3361",
            "3362",
            "3363",
            "3364",
            "3365",
            "3366",
            "3367",
            "3368",
            "3369",
            "3370",
            "3371",
            "3372",
            "3373",
            "3374",
            "3375",
            "3376",
            "3377",
            "3378",
            "3379",
            "3380",
            "3381",
            "3382",
            "3383",
            "3384",
            "3385",
            "3386",
            "3387",
            "3388",
            "3389",
            "3390",
            "3391",
            "3392",
            "3393",
            "3394",
            "3395",
            "3396",
            "3397",
            "3398",
            "3399",
            "3400",
            "3401",
            "3402",
            "3403",
            "3404",
            "3405",
            "3406",
            "3407",
            "3408",
            "3409",
            "3410",
            "3411",
            "3412",
            "3413",
            "3414",
            "3415",
            "3416",
            "3417",
            "3418",
            "3419",
            "3420",
            "3421",
            "3422",
            "3423",
            "3424",
            "3425",
            "3426",
            "3427",
            "3428",
            "3429",
            "3430",
            "3431",
            "3432",
            "3433",
            "3434",
            "3435",
            "3436",
            "3437",
            "3438",
            "3439",
            "3440",
            "3441",
            "3442",
            "3443",
            "3444",
            "3445",
            "3446",
            "3447",
            "3448",
            "3449",
            "3450",
            "3451",
            "3452",
            "3453",
            "3454",
            "3455",
            "3456",
            "3457",
            "3458",
            "3459",
            "3460",
            "3461",
            "3462",
            "3463",
            "3464",
            "3465",
            "3466",
            "3467",
            "3468",
            "3469",
            "3470",
            "3471",
            "3472",
            "3473",
            "3474",
            "3475",
            "3476",
            "3477",
            "3478",
            "3479",
            "3480",
            "3481",
            "3482",
            "3483",
            "3484",
            "3485",
            "3486",
            "3487",
            "3488",
            "3489",
            "3490",
            "3491",
            "3492",
            "3493",
            "3494",
            "3495",
            "3496",
            "3497",
            "3498",
            "3499",
            "3500",
            "3501",
            "3502",
            "3503",
            "3504",
            "3505",
            "3506",
            "3507",
            "3508",
            "3509",
            "3510",
            "3511",
            "3512",
            "3513",
            "3514",
            "3515",
            "3516",
            "3517",
            "3518",
            "3519",
            "3520",
            "3521",
            "3522",
            "3523",
            "3524",
            "3525",
            "3526",
            "3527",
            "3528",
            "3529",
            "3530",
            "3531",
            "3532",
            "3533",
            "3534",
            "3535",
            "3536",
            "3537",
            "3538",
            "3539",
            "3540",
            "3541",
            "3542",
            "3543",
            "3544",
            "3545",
            "3546",
            "3547",
            "3548",
            "3549",
            "3550",
            "3551",
            "3552",
            "3553",
            "3554",
            "3555",
            "3556",
            "3557",
            "3558",
            "3559",
            "3560",
            "3561",
            "3562",
            "3563",
            "3564",
            "3565",
            "3566",
            "3567",
            "3568",
            "3569",
            "3570",
            "3571",
            "3572",
            "3573",
            "3574",
            "3575",
            "3576",
            "3577",
            "3578",
            "3579",
            "3580",
            "3581",
            "3582",
            "3583",
            "3584",
            "3585",
            "3586",
            "3587",
            "3588",
            "3589",
            "3590",
            "3591",
            "3592",
            "3593",
            "3594",
            "3595",
            "3596",
            "3597",
            "3598",
            "3599",
            "3600",
            "3601",
            "3602",
            "3603",
            "3604",
            "3605",
            "3606",
            "3607",
            "3608",
            "3609",
            "3610",
            "3611",
            "3612",
            "3613",
            "3614",
            "3615",
            "3616",
            "3617",
            "3618",
            "3619",
            "3620",
            "3621",
            "3622",
            "3623",
            "3624",
            "3625",
            "3626",
            "3627",
            "3628",
            "3629",
            "3630",
            "3631",
            "3632",
            "3633",
            "3634",
            "3635",
            "3636",
            "3637",
            "3638",
            "3639",
            "3640",
            "3641",
            "3642",
            "3643",
            "3644",
            "3645",
            "3646",
            "3647",
            "3648",
            "3649",
            "3650",
            "3651",
            "3652",
            "3653",
            "3654",
            "3655",
            "3656",
            "3657",
            "3658",
            "3659",
            "3660",
            "3661",
            "3662",
            "3663",
            "3664",
            "3665",
            "3666",
            "3667",
            "3668",
            "3669",
            "3670",
            "3671",
            "3672",
            "3673",
            "3674",
            "3675",
            "3676",
            "3677",
            "3678",
            "3679",
            "3680",
            "3681",
            "3682",
            "3683",
            "3684",
            "3685",
            "3686",
            "3687",
            "3688",
            "3689",
            "3690",
            "3691",
            "3692",
            "3693",
            "3694",
            "3695",
            "3696",
            "3697",
            "3698",
            "3699",
            "3700",
            "3701",
            "3702",
            "3703",
            "3704",
            "3705",
            "3706",
            "3707",
            "3708",
            "3709",
            "3710",
            "3711",
            "3712",
            "3713",
            "3714",
            "3715",
            "3716",
            "3717",
            "3718",
            "3719",
            "3720",
            "3721",
            "3722",
            "3723",
            "3724",
            "3725",
            "3726",
            "3727",
            "3728",
            "3729",
            "3730",
            "3731",
            "3732",
            "3733",
            "3734",
            "3735",
            "3736",
            "3737",
            "3738",
            "3739",
            "3740",
            "3741",
            "3742",
            "3743",
            "3744",
            "3745",
            "3746",
            "3747",
            "3748",
            "3749",
            "3750",
            "3751",
            "3752",
            "3753",
            "3754",
            "3755",
            "3756",
            "3757",
            "3758",
            "3759",
            "3760",
            "3761",
            "3762",
            "3763",
            "3764",
            "3765",
            "3766",
            "3767",
            "3768",
            "3769",
            "3770",
            "3771",
            "3772",
            "3773",
            "3774",
            "3775",
            "3776",
            "3777",
            "3778",
            "3779",
            "3780",
            "3781",
            "3782",
            "3783",
            "3784",
            "3785",
            "3786",
            "3787",
            "3788",
            "3789",
            "3790",
            "3791",
            "3792",
            "3793",
            "3794",
            "3795",
            "3796",
            "3797",
            "3798",
            "3799",
            "3800",
            "3801",
            "3802",
            "3803",
            "3804",
            "3805",
            "3806",
            "3807",
            "3808",
            "3809",
            "3810",
            "3811",
            "3812",
            "3813",
            "3814",
            "3815",
            "3816",
            "3817",
            "3818",
            "3819",
            "3820",
            "3821",
            "3822",
            "3823",
            "3824",
            "3825",
            "3826",
            "3827",
            "3828",
            "3829",
            "3830",
            "3831",
            "3832",
            "3833",
            "3834",
            "3835",
            "3836",
            "3837",
            "3838",
            "3839",
            "3840",
            "3841",
            "3842",
            "3843",
            "3844",
            "3845",
            "3846",
            "3847",
            "3848",
            "3849",
            "3850",
            "3851",
            "3852",
            "3853",
            "3854",
            "3855",
            "3856",
            "3857",
            "3858",
            "3859",
            "3860",
            "3861",
            "3862",
            "3863",
            "3864",
            "3865",
            "3866",
            "3867",
            "3868",
            "3869",
            "3870",
            "3871",
            "3872",
            "3873",
            "3874",
            "3875",
            "3876",
            "3877",
            "3878",
            "3879",
            "3880",
            "3881",
            "3882",
            "3883",
            "3884",
            "3885",
            "3886",
            "3887",
            "3888",
            "3889",
            "3890",
            "3891",
            "3892",
            "3893",
            "3894",
            "3895",
            "3896",
            "3897",
            "3898",
            "3899",
            "3900",
            "3901",
            "3902",
            "3903",
            "3904",
            "3905",
            "3906",
            "3907",
            "3908",
            "3909",
            "3910",
            "3911",
            "3912",
            "3913",
            "3914",
            "3915",
            "3916",
            "3917",
            "3918",
            "3919",
            "3920",
            "3921",
            "3922",
            "3923",
            "3924",
            "3925",
            "3926",
            "3927",
            "3928",
            "3929",
            "3930",
            "3931",
            "3932",
            "3933",
            "3934",
            "3935",
            "3936",
            "3937",
            "3938",
            "3939",
            "3940",
            "3941",
            "3942",
            "3943",
            "3944",
            "3945",
            "3946",
            "3947",
            "3948",
            "3949",
            "3950",
            "3951",
            "3952",
            "3953",
            "3954",
            "3955",
            "3956",
            "3957",
            "3958",
            "3959",
            "3960",
            "3961",
            "3962",
            "3963",
            "3964",
            "3965",
            "3966",
            "3967",
            "3968",
            "3969",
            "3970",
            "3971",
            "3972",
            "3973",
            "3974",
            "3975",
            "3976",
            "3977",
            "3978",
            "3979",
            "3980",
            "3981",
            "3982",
            "3983",
            "3984",
            "3985",
            "3986",
            "3987",
            "3988",
            "3989",
            "3990",
            "3991",
            "3992",
            "3993",
            "3994",
            "3995",
            "3996",
            "3997",
            "3998",
            "3999"});
            this.comboBox8.Location = new System.Drawing.Point(135, 19);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(121, 21);
            this.comboBox8.TabIndex = 1;
            this.toolTip_0.SetToolTip(this.comboBox8, "Paint number");
            // 
            // comboBox9
            // 
            this.comboBox9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Items.AddRange(new object[] {
            "Body/Chassis",
            "Engine",
            "Intake/Exhaust",
            "Turbo Kit",
            "Transmission",
            "Drivetrain",
            "Suspension",
            "Brakes",
            "Comfort Tires",
            "Sport Tires",
            "RacingTires",
            "Special Tires",
            "Others"});
            this.comboBox9.Location = new System.Drawing.Point(6, 19);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(121, 21);
            this.comboBox9.TabIndex = 0;
            this.toolTip_0.SetToolTip(this.comboBox9, "The Item that will show In-Game");
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(86, 143);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(64, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Sheet C";
            this.toolTip_0.SetToolTip(this.checkBox1, "which sheets");
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(86, 120);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(64, 17);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Sheet B";
            this.toolTip_0.SetToolTip(this.checkBox2, "which sheets");
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(86, 97);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(64, 17);
            this.checkBox3.TabIndex = 8;
            this.checkBox3.Text = "Sheet A";
            this.toolTip_0.SetToolTip(this.checkBox3, "which sheets");
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(86, 166);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "&Confirm";
            this.toolTip_0.SetToolTip(this.button5, "Confirm");
            this.button5.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(86, 73);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(121, 20);
            this.textBox7.TabIndex = 4;
            this.toolTip_0.SetToolTip(this.textBox7, "Enter the Value as Hexadecimal");
            // 
            // comboBox11
            // 
            this.comboBox11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox11.FormattingEnabled = true;
            this.comboBox11.Items.AddRange(new object[] {
            "BHP",
            "Grip",
            "Weight",
            "Odometer",
            "Oil",
            "Paint",
            "Body",
            "Colour",
            "Brakes",
            "_198_201",
            "Chassis",
            "Engine",
            "Drivetrain",
            "Transmission",
            "Suspension",
            "LSD",
            "_226_229",
            "WReduction",
            "_234_237",
            "_238_241",
            "ECU",
            "Engine Tune",
            "Turbo",
            "Flywheel",
            "Clutch",
            "Driveshaft",
            "Exhaust",
            "_270_273",
            "ASM Controller",
            "TCS Controller",
            "_282_285",
            "Supercharger",
            "Intake Manifold",
            "Exhaust Manifold",
            "Catalytic Converter",
            "Air Filter",
            "_306_309",
            "WindowWR",
            "Hood",
            "FrBumper",
            "RrBumper",
            "Extension",
            "Wing",
            "_334_337",
            "Reinforcement",
            "NoS"});
            this.comboBox11.Location = new System.Drawing.Point(86, 46);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(121, 21);
            this.comboBox11.TabIndex = 3;
            this.toolTip_0.SetToolTip(this.comboBox11, "Choose the part of the car to edit");
            // 
            // comboBox12
            // 
            this.comboBox12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox12.FormattingEnabled = true;
            this.comboBox12.Items.AddRange(new object[] {
            "ALL CARS",
            "ac",
            "aem",
            "acura",
            "alfaromeo",
            "alpine",
            "amuse",
            "artmorrison",
            "astonmartin",
            "audi",
            "autobacs",
            "bmw",
            "bentley",
            "blitz",
            "bugatti",
            "buick",
            "cadillac",
            "callaway",
            "caterham",
            "chaparral",
            "chevrolet",
            "chrysler",
            "citroen",
            "cizeta",
            "dmc",
            "daihatsu",
            "dodge",
            "dome",
            "eagle",
            "ferrari",
            "fiat",
            "ford",
            "au_ford",
            "gillet",
            "ginetta",
            "polyphony",
            "gtg",
            "hks",
            "hpa",
            "hep",
            "holden",
            "hommell",
            "honda",
            "hyundai",
            "infiniti",
            "isuzu",
            "jaguar",
            "jayleno",
            "jensen",
            "lamborghini",
            "lancia",
            "landrover",
            "lexus",
            "lister",
            "lotus",
            "mg",
            "marcos",
            "maserati",
            "mazda",
            "mclaren",
            "mercedes",
            "mercury",
            "mines",
            "mini",
            "mitsubishi",
            "mugen",
            "nismo",
            "nissan",
            "opel",
            "opera",
            "proto",
            "pagani",
            "panoz",
            "pescarolo",
            "peugeot",
            "plymouth",
            "pontiac",
            "amemiya",
            "ruf",
            "renault",
            "renaultsport",
            "saleen",
            "scion",
            "seat",
            "shelby",
            "spoon",
            "spyker",
            "subaru",
            "suzuki",
            "trd",
            "trial",
            "tvr",
            "tesla",
            "toms",
            "tommykaira",
            "toyota",
            "triumph",
            "vauxhall",
            "volkswagen",
            "volvo"});
            this.comboBox12.Location = new System.Drawing.Point(86, 19);
            this.comboBox12.Name = "comboBox12";
            this.comboBox12.Size = new System.Drawing.Size(121, 21);
            this.comboBox12.TabIndex = 0;
            this.toolTip_0.SetToolTip(this.comboBox12, "Choose what to edit");
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(154, 101);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(39, 17);
            this.radioButton5.TabIndex = 12;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "On";
            this.toolTip_0.SetToolTip(this.radioButton5, "Caution:\r\nYou can lock yourself out of GT-Life with this option");
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // comboBox15
            // 
            this.comboBox15.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox15.FormattingEnabled = true;
            this.comboBox15.Items.AddRange(new object[] {
            "Recieve All Presents",
            "All Gold A Spec",
            "All Gold B Spec",
            "All Gold Licences",
            "All Gold Special Events"});
            this.comboBox15.Location = new System.Drawing.Point(6, 19);
            this.comboBox15.Name = "comboBox15";
            this.comboBox15.Size = new System.Drawing.Size(121, 21);
            this.comboBox15.TabIndex = 0;
            this.toolTip_0.SetToolTip(this.comboBox15, "Select One");
            // 
            // comboBox16
            // 
            this.comboBox16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox16.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox16.FormattingEnabled = true;
            this.comboBox16.Location = new System.Drawing.Point(6, 21);
            this.comboBox16.Name = "comboBox16";
            this.comboBox16.Size = new System.Drawing.Size(243, 21);
            this.comboBox16.TabIndex = 0;
            this.toolTip_0.SetToolTip(this.comboBox16, "Choose Database Tuner");
            // 
            // comboBox17
            // 
            this.comboBox17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox17.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox17.FormattingEnabled = true;
            this.comboBox17.Location = new System.Drawing.Point(6, 48);
            this.comboBox17.Name = "comboBox17";
            this.comboBox17.Size = new System.Drawing.Size(243, 21);
            this.comboBox17.TabIndex = 1;
            this.toolTip_0.SetToolTip(this.comboBox17, "Choose Database Model");
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeColumns = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView3.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView3.Location = new System.Drawing.Point(6, 195);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView3.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(243, 322);
            this.dataGridView3.TabIndex = 1;
            this.toolTip_0.SetToolTip(this.dataGridView3, "Click these Items to swap them to the right");
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Item";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewCellStyle9.Format = "X8";
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn6.HeaderText = "Value";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn6.Width = 123;
            // 
            // comboBox10
            // 
            this.comboBox10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99"});
            this.comboBox10.Location = new System.Drawing.Point(133, 19);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(121, 21);
            this.comboBox10.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // paToolStripMenuItem
            // 
            this.paToolStripMenuItem.Name = "paToolStripMenuItem";
            this.paToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.groupBox7);
            this.tabPage2.Controls.Add(this.groupBox9);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(622, 538);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Garage";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.groupBox8);
            this.groupBox7.Controls.Add(this.comboBox2);
            this.groupBox7.Controls.Add(this.comboBox3);
            this.groupBox7.Controls.Add(this.dataGridView1);
            this.groupBox7.Controls.Add(this.textBox1);
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Controls.Add(this.textBox2);
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.Controls.Add(this.textBox3);
            this.groupBox7.Controls.Add(this.label19);
            this.groupBox7.Location = new System.Drawing.Point(6, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(256, 524);
            this.groupBox7.TabIndex = 56;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Part Database";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label16);
            this.groupBox8.Location = new System.Drawing.Point(6, 155);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(243, 34);
            this.groupBox8.TabIndex = 16;
            this.groupBox8.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 13);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(131, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Click Parts Below to Swap";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(149, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 130);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 13);
            this.label17.TabIndex = 15;
            this.label17.Text = "Country :";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox2.Location = new System.Drawing.Point(149, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 11;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 104);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 13);
            this.label18.TabIndex = 14;
            this.label18.Text = "Drivetrain :";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox3.Location = new System.Drawing.Point(149, 127);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 12;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 78);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 13);
            this.label19.TabIndex = 13;
            this.label19.Text = "Year :";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.comboBox4);
            this.groupBox9.Controls.Add(this.groupBox10);
            this.groupBox9.Controls.Add(this.comboBox5);
            this.groupBox9.Controls.Add(this.dataGridView2);
            this.groupBox9.Controls.Add(this.textBox4);
            this.groupBox9.Controls.Add(this.textBox5);
            this.groupBox9.Controls.Add(this.label20);
            this.groupBox9.Controls.Add(this.textBox6);
            this.groupBox9.Controls.Add(this.label21);
            this.groupBox9.Controls.Add(this.label22);
            this.groupBox9.Location = new System.Drawing.Point(358, 8);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(256, 524);
            this.groupBox9.TabIndex = 55;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Open Garage";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox4.Location = new System.Drawing.Point(149, 73);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 18;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox5.Location = new System.Drawing.Point(149, 99);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 19;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 128);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 13);
            this.label20.TabIndex = 23;
            this.label20.Text = "Country :";
            // 
            // textBox6
            // 
            this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox6.Location = new System.Drawing.Point(149, 125);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 20;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(3, 102);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(58, 13);
            this.label21.TabIndex = 22;
            this.label21.Text = "Drivetrain :";
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(3, 76);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(35, 13);
            this.label22.TabIndex = 21;
            this.label22.Text = "Year :";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.groupBox11);
            this.tabPage3.Controls.Add(this.groupBox12);
            this.tabPage3.Controls.Add(this.groupBox13);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(622, 538);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Gifts/Items";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.comboBox6);
            this.groupBox11.Controls.Add(this.button2);
            this.groupBox11.Location = new System.Drawing.Point(6, 124);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(606, 53);
            this.groupBox11.TabIndex = 5;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Car Tickets";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(262, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Add Item";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.comboBox7);
            this.groupBox12.Controls.Add(this.button3);
            this.groupBox12.Controls.Add(this.comboBox8);
            this.groupBox12.Location = new System.Drawing.Point(6, 65);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(606, 53);
            this.groupBox12.TabIndex = 4;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Paint Items";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(262, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Add Item";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.comboBox9);
            this.groupBox13.Controls.Add(this.button4);
            this.groupBox13.Controls.Add(this.comboBox10);
            this.groupBox13.Location = new System.Drawing.Point(8, 6);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(606, 53);
            this.groupBox13.TabIndex = 3;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Tune Items";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(260, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Add Item";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.groupBox14);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(622, 538);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "Batch Functions";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.label23);
            this.groupBox14.Controls.Add(this.checkBox1);
            this.groupBox14.Controls.Add(this.checkBox2);
            this.groupBox14.Controls.Add(this.checkBox3);
            this.groupBox14.Controls.Add(this.listBox1);
            this.groupBox14.Controls.Add(this.button5);
            this.groupBox14.Controls.Add(this.label24);
            this.groupBox14.Controls.Add(this.textBox7);
            this.groupBox14.Controls.Add(this.comboBox11);
            this.groupBox14.Controls.Add(this.label25);
            this.groupBox14.Controls.Add(this.label26);
            this.groupBox14.Controls.Add(this.comboBox12);
            this.groupBox14.Location = new System.Drawing.Point(8, 6);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(606, 200);
            this.groupBox14.TabIndex = 1;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Basic";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(7, 98);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(27, 13);
            this.label23.TabIndex = 11;
            this.label23.Text = "On :";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(213, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(387, 173);
            this.listBox1.TabIndex = 7;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 76);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(62, 13);
            this.label24.TabIndex = 5;
            this.label24.Text = "With Value:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 49);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(28, 13);
            this.label25.TabIndex = 2;
            this.label25.Text = "Edit:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 22);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(49, 13);
            this.label26.TabIndex = 1;
            this.label26.Text = "Choose :";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox15);
            this.tabPage5.Controls.Add(this.groupBox16);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(622, 538);
            this.tabPage5.TabIndex = 3;
            this.tabPage5.Text = "A-Spec/B-Spec";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.radioButton4);
            this.groupBox15.Controls.Add(this.radioButton5);
            this.groupBox15.Controls.Add(this.button6);
            this.groupBox15.Controls.Add(this.label27);
            this.groupBox15.Controls.Add(this.button7);
            this.groupBox15.Controls.Add(this.button8);
            this.groupBox15.Controls.Add(this.button9);
            this.groupBox15.Controls.Add(this.comboBox13);
            this.groupBox15.Controls.Add(this.label28);
            this.groupBox15.Controls.Add(this.comboBox14);
            this.groupBox15.Controls.Add(this.label29);
            this.groupBox15.Controls.Add(this.label30);
            this.groupBox15.Controls.Add(this.textBox8);
            this.groupBox15.Location = new System.Drawing.Point(8, 68);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(606, 129);
            this.groupBox15.TabIndex = 6;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Misc";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(215, 101);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(39, 17);
            this.radioButton4.TabIndex = 13;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Off";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(260, 98);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 11;
            this.button6.Text = "Apply";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(6, 103);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(68, 13);
            this.label27.TabIndex = 10;
            this.label27.Text = "Secret Menu";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(260, 69);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 8;
            this.button7.Text = "Apply";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(260, 42);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 7;
            this.button8.Text = "Apply";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(260, 17);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 6;
            this.button9.Text = "Apply";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // comboBox13
            // 
            this.comboBox13.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox13.FormattingEnabled = true;
            this.comboBox13.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40"});
            this.comboBox13.Location = new System.Drawing.Point(154, 71);
            this.comboBox13.Name = "comboBox13";
            this.comboBox13.Size = new System.Drawing.Size(100, 21);
            this.comboBox13.TabIndex = 5;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 74);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(71, 13);
            this.label28.TabIndex = 4;
            this.label28.Text = "B Spec Level";
            // 
            // comboBox14
            // 
            this.comboBox14.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox14.FormattingEnabled = true;
            this.comboBox14.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40"});
            this.comboBox14.Location = new System.Drawing.Point(154, 44);
            this.comboBox14.Name = "comboBox14";
            this.comboBox14.Size = new System.Drawing.Size(100, 21);
            this.comboBox14.TabIndex = 3;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(6, 47);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(71, 13);
            this.label29.TabIndex = 2;
            this.label29.Text = "A Spec Level";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(6, 22);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(39, 13);
            this.label30.TabIndex = 1;
            this.label30.Text = "Credits";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(154, 19);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 0;
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.button10);
            this.groupBox16.Controls.Add(this.comboBox15);
            this.groupBox16.Location = new System.Drawing.Point(8, 6);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(606, 56);
            this.groupBox16.TabIndex = 5;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Unlock";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(260, 19);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 1;
            this.button10.Text = "&Perform";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.label31);
            this.groupBox18.Location = new System.Drawing.Point(6, 155);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(243, 34);
            this.groupBox18.TabIndex = 16;
            this.groupBox18.TabStop = false;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(8, 13);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(131, 13);
            this.label31.TabIndex = 0;
            this.label31.Text = "Click Parts Below to Swap";
            // 
            // textBox9
            // 
            this.textBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox9.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox9.Location = new System.Drawing.Point(149, 75);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 10;
            // 
            // label32
            // 
            this.label32.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(6, 130);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(49, 13);
            this.label32.TabIndex = 15;
            this.label32.Text = "Country :";
            // 
            // textBox10
            // 
            this.textBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox10.Location = new System.Drawing.Point(149, 101);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 11;
            // 
            // label33
            // 
            this.label33.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(6, 104);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(58, 13);
            this.label33.TabIndex = 14;
            this.label33.Text = "Drivetrain :";
            // 
            // textBox11
            // 
            this.textBox11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox11.Location = new System.Drawing.Point(149, 127);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(100, 20);
            this.textBox11.TabIndex = 12;
            // 
            // label34
            // 
            this.label34.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(6, 78);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(35, 13);
            this.label34.TabIndex = 13;
            this.label34.Text = "Year :";
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(688, 588);
            this.Controls.Add(this.panel_main);
            this.MainMenuStrip = this.menuStrip_main;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GT5 Garage Editor v1.3.1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_main_FormClosing);
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.tabControl_garage.ResumeLayout(false);
            this.tabPage_spec.ResumeLayout(false);
            this.groupBox_spec_main.ResumeLayout(false);
            this.groupBox_spec_main.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabPage_garage.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Source)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox_Sheet.ResumeLayout(false);
            this.groupBox_Sheet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Dest)).EndInit();
            this.tabPage_ridingCar.ResumeLayout(false);
            this.tabPage_gift.ResumeLayout(false);
            this.groupBox22.ResumeLayout(false);
            this.groupBox20.ResumeLayout(false);
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_thumb)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox_gift_tuneitems.ResumeLayout(false);
            this.tabPage_Adv.ResumeLayout(false);
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            this.groupBox_func_basic.ResumeLayout(false);
            this.groupBox_func_basic.PerformLayout();
            this.menuStrip_main.ResumeLayout(false);
            this.menuStrip_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
