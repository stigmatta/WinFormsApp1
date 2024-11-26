using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            button1 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(234, 76);
            button1.TabIndex = 0;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Resize += Form1_Resize;
            ResumeLayout(false);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            CenterButton();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterButton();
        }

        private void CenterButton()
        {
            button1.Left = (ClientSize.Width - button1.Width) / 2;
            button1.Top = (ClientSize.Height - button1.Height) / 2;
        }

        private Button button1;
    }
}
