using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GT5_Garage_Editor.Utils;

namespace GT5_Garage_Editor
{
    public sealed class PaintSelector : Form
    {
        private const string _dbFileName = "\\_db";
        private DataTable dataTable_0 = new DataTable();
        private DataTable dataTable_1 = new DataTable();
        private DataTable dataTable_2 = new DataTable();
        private IContainer icontainer_0;
        private GroupBox groupBox1;
        private ListBox listBox_Body;
        private ComboBox comboBox_body_make;
        private ComboBox comboBox_body_cat;
        private GroupBox groupBox2;
        private ListBox listBox_Rim;
        private ComboBox comboBox_rim_make;
        private ComboBox comboBox_rim_cat;
        private Button button_Accept;
        private Button button_Cancel;
        private TextBox tb_PaintCode;
        private Label label1;
        private ToolTip toolTip_0;
        private Button btn_reset;
        private byte[] byte_0;
        private SqlHelper gclass2_0;
        private IContainer components;
        private uint uint_0;

        public PaintSelector()
        {
            try
            {
                byte_0 = Encoding.ASCII.GetBytes("_akz&^_&*^950_dLu");
                gclass2_0 = new SqlHelper(Application.StartupPath + @"\Dependancies" + _dbFileName, true, byte_0);
                method_1(67108863U);
                dataTable_2 = gclass2_0.ExecuteReader("SELECT DISTINCT Maker FROM t_colour");
                InitializeComponent();
                foreach (DataRow dataRow in (InternalDataCollectionBase)dataTable_2.Rows)
                {
                    comboBox_body_make.Items.Add(dataRow.ItemArray[0].ToString());
                    comboBox_rim_make.Items.Add(dataRow.ItemArray[0].ToString());
                }
                comboBox_body_cat.SelectedIndex = 0;
                comboBox_body_make.SelectedIndex = 0;
                comboBox_rim_cat.SelectedIndex = 0;
                comboBox_rim_make.SelectedIndex = 0;
                tb_PaintCode.Text = "0x" + method_0().ToString("X8");
            }
            catch
            {
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
            groupBox1 = new GroupBox();
            listBox_Body = new ListBox();
            comboBox_body_make = new ComboBox();
            comboBox_body_cat = new ComboBox();
            groupBox2 = new GroupBox();
            listBox_Rim = new ListBox();
            comboBox_rim_make = new ComboBox();
            comboBox_rim_cat = new ComboBox();
            button_Accept = new Button();
            button_Cancel = new Button();
            tb_PaintCode = new TextBox();
            label1 = new Label();
            toolTip_0 = new ToolTip(components);
            btn_reset = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBox_Body);
            groupBox1.Controls.Add(comboBox_body_make);
            groupBox1.Controls.Add(comboBox_body_cat);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(531, 135);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Body Paint";
            // 
            // listBox_Body
            // 
            listBox_Body.FormattingEnabled = true;
            listBox_Body.Location = new Point(260, 19);
            listBox_Body.Name = "listBox_Body";
            listBox_Body.Size = new Size(265, 108);
            listBox_Body.TabIndex = 2;
            listBox_Body.SelectedIndexChanged += new EventHandler(listBox_Body_SelectedIndexChanged);
            // 
            // comboBox_body_make
            // 
            comboBox_body_make.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_body_make.FormattingEnabled = true;
            comboBox_body_make.Location = new Point(133, 19);
            comboBox_body_make.Name = "comboBox_body_make";
            comboBox_body_make.Size = new Size(121, 21);
            comboBox_body_make.TabIndex = 1;
            toolTip_0.SetToolTip(comboBox_body_make, "Tuner");
            comboBox_body_make.SelectedIndexChanged += new EventHandler(comboBox_body_make_SelectedIndexChanged);
            // 
            // comboBox_body_cat
            // 
            comboBox_body_cat.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_body_cat.FormattingEnabled = true;
            comboBox_body_cat.Items.AddRange(new object[] {
                "Solid",
                "Metallic",
                "Pearlescent",
                "Shift",
                "Matte",
                "Chrome"});
            comboBox_body_cat.Location = new Point(6, 19);
            comboBox_body_cat.Name = "comboBox_body_cat";
            comboBox_body_cat.Size = new Size(121, 21);
            comboBox_body_cat.TabIndex = 0;
            toolTip_0.SetToolTip(comboBox_body_cat, "Category");
            comboBox_body_cat.SelectedIndexChanged += new EventHandler(comboBox_body_cat_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listBox_Rim);
            groupBox2.Controls.Add(comboBox_rim_make);
            groupBox2.Controls.Add(comboBox_rim_cat);
            groupBox2.Location = new Point(12, 153);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(531, 135);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Rim Paint";
            // 
            // listBox_Rim
            // 
            listBox_Rim.FormattingEnabled = true;
            listBox_Rim.Location = new Point(260, 19);
            listBox_Rim.Name = "listBox_Rim";
            listBox_Rim.Size = new Size(265, 108);
            listBox_Rim.TabIndex = 2;
            listBox_Rim.SelectedIndexChanged += new EventHandler(listBox_Rim_SelectedIndexChanged);
            // 
            // comboBox_rim_make
            // 
            comboBox_rim_make.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_rim_make.FormattingEnabled = true;
            comboBox_rim_make.Location = new Point(133, 19);
            comboBox_rim_make.Name = "comboBox_rim_make";
            comboBox_rim_make.Size = new Size(121, 21);
            comboBox_rim_make.TabIndex = 1;
            toolTip_0.SetToolTip(comboBox_rim_make, "Tuner");
            comboBox_rim_make.SelectedIndexChanged += new EventHandler(comboBox_rim_make_SelectedIndexChanged);
            // 
            // comboBox_rim_cat
            // 
            comboBox_rim_cat.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_rim_cat.FormattingEnabled = true;
            comboBox_rim_cat.Items.AddRange(new object[] {
                "Solid",
                "Metallic",
                "Pearlescent",
                "Shift",
                "Matte",
                "Chrome"});
            comboBox_rim_cat.Location = new Point(6, 19);
            comboBox_rim_cat.Name = "comboBox_rim_cat";
            comboBox_rim_cat.Size = new Size(121, 21);
            comboBox_rim_cat.TabIndex = 0;
            toolTip_0.SetToolTip(comboBox_rim_cat, "Category");
            comboBox_rim_cat.SelectedIndexChanged += new EventHandler(comboBox_rim_cat_SelectedIndexChanged);
            // 
            // button_Accept
            // 
            button_Accept.Location = new Point(462, 337);
            button_Accept.Name = "button_Accept";
            button_Accept.Size = new Size(75, 23);
            button_Accept.TabIndex = 4;
            button_Accept.Text = "Accept";
            button_Accept.UseVisualStyleBackColor = true;
            button_Accept.Click += new EventHandler(button_Accept_Click);
            // 
            // button_Cancel
            // 
            button_Cancel.DialogResult = DialogResult.Cancel;
            button_Cancel.Location = new Point(381, 337);
            button_Cancel.Name = "button_Cancel";
            button_Cancel.Size = new Size(75, 23);
            button_Cancel.TabIndex = 5;
            button_Cancel.Text = "Cancel";
            button_Cancel.UseVisualStyleBackColor = true;
            button_Cancel.Click += new EventHandler(button_Cancel_Click);
            // 
            // tb_PaintCode
            // 
            tb_PaintCode.BackColor = SystemColors.ButtonHighlight;
            tb_PaintCode.Location = new Point(272, 294);
            tb_PaintCode.Name = "tb_PaintCode";
            tb_PaintCode.ReadOnly = true;
            tb_PaintCode.Size = new Size(100, 20);
            tb_PaintCode.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(204, 297);
            label1.Name = "label1";
            label1.Size = new Size(62, 13);
            label1.TabIndex = 7;
            label1.Text = "Paint Code:";
            // 
            // btn_reset
            // 
            btn_reset.Location = new Point(381, 292);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(75, 23);
            btn_reset.TabIndex = 8;
            btn_reset.Text = "Default";
            toolTip_0.SetToolTip(btn_reset, "Reset to default");
            btn_reset.UseVisualStyleBackColor = true;
            btn_reset.Click += new EventHandler(btn_reset_Click);
            // 
            // Paint_Selector
            // 
            AcceptButton = button_Accept;
            BackColor = Color.MintCream;
            CancelButton = button_Cancel;
            ClientSize = new Size(555, 363);
            Controls.Add(btn_reset);
            Controls.Add(label1);
            Controls.Add(tb_PaintCode);
            Controls.Add(button_Cancel);
            Controls.Add(button_Accept);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "PaintSelector";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Paint Selector";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        public uint method_0()
        {
            return uint_0;
        }

        public void method_1(uint uint_1)
        {
            uint_0 = uint_1;
        }

        public void method_2(ref DataTable dataTable_3, ref ListBox listBox_0, int int_0, string string_1)
        {
            try
            {
                dataTable_3.Clear();
                listBox_0.Items.Clear();
                dataTable_3 = gclass2_0.ExecuteReader(string.Concat(new object[4]
                {
                    "SELECT Item_Name, Colour_Number FROM t_colour WHERE Maker = '",
                    string_1,
                    "' AND Colour_Category = ",
                    int_0
                }));
                if (dataTable_3.Rows.Count <= 0)
                    return;
                foreach (DataRow dataRow in (InternalDataCollectionBase)dataTable_3.Rows)
                    listBox_0.Items.Add(dataRow.ItemArray[0].ToString());
            }
            catch
            {
            }
        }

        private void comboBox_body_make_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_body_make.SelectedIndex == -1 || comboBox_body_make.SelectedItem == null)
                return;
            method_2(ref dataTable_0, ref listBox_Body, comboBox_body_cat.SelectedIndex, comboBox_body_make.SelectedItem.ToString());
        }

        private void comboBox_body_cat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_body_make.SelectedIndex == -1 || comboBox_body_make.SelectedItem == null)
                return;
            method_2(ref dataTable_0, ref listBox_Body, comboBox_body_cat.SelectedIndex, comboBox_body_make.SelectedItem.ToString());
        }

        private void comboBox_rim_cat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_rim_make.SelectedIndex == -1 || comboBox_rim_make.SelectedItem == null)
                return;
            method_2(ref dataTable_1, ref listBox_Rim, comboBox_rim_cat.SelectedIndex, comboBox_rim_make.SelectedItem.ToString());
        }

        private void comboBox_rim_make_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_rim_make.SelectedIndex == -1 || comboBox_rim_make.SelectedItem == null)
                return;
            method_2(ref dataTable_1, ref listBox_Rim, comboBox_rim_cat.SelectedIndex, comboBox_rim_make.SelectedItem.ToString());
        }

        private void listBox_Body_SelectedIndexChanged(object sender, EventArgs e)
        {
            var num = uint.Parse(dataTable_0.Rows[listBox_Body.SelectedIndex][1].ToString()) << 13;
            method_1(method_0() & 8191U);
            method_1(method_0() | num);
            tb_PaintCode.Text = "0x" + method_0().ToString("X8");
        }

        private void listBox_Rim_SelectedIndexChanged(object sender, EventArgs e)
        {
            var num = uint.Parse(dataTable_1.Rows[listBox_Rim.SelectedIndex][1].ToString());
            method_1(method_0() & 4294959104U);
            method_1(method_0() | num);
            tb_PaintCode.Text = "0x" + method_0().ToString("X8");
        }

        private void button_Accept_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void method_3(object sender, EventArgs e)
        {
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            method_1(67108863U);
            tb_PaintCode.Text = "0x" + method_0().ToString("X8");
        }
    }
}
