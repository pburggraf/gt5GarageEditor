// Type: InputBox
// Assembly: GT5_Garage_Editor, Version=1.3.1.0, Culture=neutral, PublicKeyToken=null
// MVID: DD0589A9-C36F-4C8C-A8E4-5B0E29CADD76
// Assembly location: C:\Users\shalpin\Downloads\GT5_Garage_Editor_v131_slim355_q-k (2)\Release\GT5_Garage_Editor-cleaned.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GT5_Garage_Editor
{
    public sealed class InputBox : Form
    {
        private IContainer icontainer_0;
        private Button button_Cancel;
        private Button button_OK;
        private Label label_prompt;
        private TextBox textBox1;
        private Label label1;
        private uint uint_0;

        public InputBox(string string_0, string string_1)
        {
            InitializeComponent();
            Text = string_0;
            label_prompt.Text = string_1;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && icontainer_0 != null)
                icontainer_0.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            button_Cancel = new Button();
            button_OK = new Button();
            label_prompt = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button_Cancel
            // 
            button_Cancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_Cancel.DialogResult = DialogResult.Cancel;
            button_Cancel.Location = new Point(170, 105);
            button_Cancel.Name = "button_Cancel";
            button_Cancel.Size = new Size(75, 23);
            button_Cancel.TabIndex = 2;
            button_Cancel.Text = "&Cancel";
            button_Cancel.UseVisualStyleBackColor = true;
            button_Cancel.Click += new EventHandler(button_Cancel_Click);
            // 
            // button_OK
            // 
            button_OK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_OK.Location = new Point(251, 105);
            button_OK.Name = "button_OK";
            button_OK.Size = new Size(75, 23);
            button_OK.TabIndex = 1;
            button_OK.Text = "&OK";
            button_OK.UseVisualStyleBackColor = true;
            button_OK.Click += new EventHandler(button_OK_Click);
            // 
            // label_prompt
            // 
            label_prompt.AutoSize = true;
            label_prompt.Location = new Point(12, 9);
            label_prompt.Name = "label_prompt";
            label_prompt.Size = new Size(67, 13);
            label_prompt.TabIndex = 2;
            label_prompt.Text = "label_prompt";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(170, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(156, 20);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 72);
            label1.Name = "label1";
            label1.Size = new Size(43, 13);
            label1.TabIndex = 3;
            label1.Text = "Base10";
            // 
            // InputBox
            // 
            AcceptButton = button_OK;
            CancelButton = button_Cancel;
            ClientSize = new Size(338, 130);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(label_prompt);
            Controls.Add(button_OK);
            Controls.Add(button_Cancel);
            MaximizeBox = false;
            Name = "InputBox";
            Text = "InputBox";
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

        private void button_OK_Click(object sender, EventArgs e)
        {
            var result = 0;
            int.TryParse(textBox1.Text, out result);
            method_1((uint) result);
            Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
