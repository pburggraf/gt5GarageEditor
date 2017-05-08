using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using GT5_SaveEditor.Properties;

namespace GT5_Garage_Editor
{
    public sealed class FormOptions : Form
    {
        private IContainer icontainer_0;
        private MenuStrip menuStrip1;
        private Panel panel1;
        private RadioButton rB_thumbs_off;
        private RadioButton rb_thumbs_on;
        private Label label1;
        private Button button_Cancel;
        private Button button_OK;
        private bool bool_0;

        public FormOptions()
        {
            method_1(Settings.Default.FetchThumbs);
            InitializeComponent();
            if (method_0())
                rb_thumbs_on.Checked = true;
            else
                rB_thumbs_off.Checked = true;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && icontainer_0 != null)
                icontainer_0.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            panel1 = new Panel();
            button_Cancel = new Button();
            button_OK = new Button();
            rB_thumbs_off = new RadioButton();
            rb_thumbs_on = new RadioButton();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(284, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // panel1
            // 
            panel1.Controls.Add(button_Cancel);
            panel1.Controls.Add(button_OK);
            panel1.Controls.Add(rB_thumbs_off);
            panel1.Controls.Add(rb_thumbs_on);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(284, 114);
            panel1.TabIndex = 1;
            // 
            // button_Cancel
            // 
            button_Cancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_Cancel.DialogResult = DialogResult.Cancel;
            button_Cancel.Location = new Point(116, 88);
            button_Cancel.Name = "button_Cancel";
            button_Cancel.Size = new Size(75, 23);
            button_Cancel.TabIndex = 4;
            button_Cancel.Text = "&Cancel";
            button_Cancel.UseVisualStyleBackColor = true;
            button_Cancel.Click += new EventHandler(button_Cancel_Click);
            // 
            // button_OK
            // 
            button_OK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_OK.Location = new Point(197, 88);
            button_OK.Name = "button_OK";
            button_OK.Size = new Size(75, 23);
            button_OK.TabIndex = 3;
            button_OK.Text = "&OK";
            button_OK.UseVisualStyleBackColor = true;
            button_OK.Click += new EventHandler(button_OK_Click);
            // 
            // rB_thumbs_off
            // 
            rB_thumbs_off.AutoSize = true;
            rB_thumbs_off.Location = new Point(224, 9);
            rB_thumbs_off.Name = "rB_thumbs_off";
            rB_thumbs_off.Size = new Size(39, 17);
            rB_thumbs_off.TabIndex = 2;
            rB_thumbs_off.TabStop = true;
            rB_thumbs_off.Text = "Off";
            rB_thumbs_off.UseVisualStyleBackColor = true;
            // 
            // rb_thumbs_on
            // 
            rb_thumbs_on.AutoSize = true;
            rb_thumbs_on.Location = new Point(179, 9);
            rb_thumbs_on.Name = "rb_thumbs_on";
            rb_thumbs_on.Size = new Size(39, 17);
            rb_thumbs_on.TabIndex = 1;
            rb_thumbs_on.TabStop = true;
            rb_thumbs_on.Text = "On";
            rb_thumbs_on.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(91, 13);
            label1.TabIndex = 0;
            label1.Text = "Fetch Thumbnails";
            // 
            // Form_Options
            // 
            AcceptButton = button_OK;
            CancelButton = button_Cancel;
            ClientSize = new Size(284, 138);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "FormOptions";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Options";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        private bool method_0()
        {
            return bool_0;
        }

        private void method_1(bool bool_1)
        {
            bool_0 = bool_1;
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            Settings.Default.FetchThumbs = rb_thumbs_on.Checked;
            Settings.Default.Save();
            Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
