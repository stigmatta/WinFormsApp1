namespace WinFormsApp1
{
    partial class Form2
    {
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
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(-3, 9);
            label1.Name = "label1";
            label1.Size = new Size(530, 25);
            label1.TabIndex = 0;
            label1.Text = "Pick any number between 1 to 2000 and I will try to find it";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = SystemColors.MenuHighlight;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(230, 116);
            button1.Name = "button1";
            button1.Size = new Size(118, 37);
            button1.TabIndex = 1;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = false;
            button1.Click += StartGame;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            Resize += Form2_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            CenterButton();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CenterButton();
        }

        private void CenterButton()
        {
            label1.Left = (ClientSize.Width - label1.Width) / 2;
            label1.Top = (ClientSize.Height - label1.Height) / 2 - 50;

            button1.Left = (ClientSize.Width - button1.Width) / 2;
            button1.Top = (ClientSize.Height - label1.Height) / 2;
        }

        private void StartGame(object sender, EventArgs e)
        {
            int low = 1;
            int high = 2000;
            int tries = 0;

            Random rnd = new Random();
            int randomNumber = rnd.Next(low, high + 1);
            DialogResult rez;

            do
            {
                tries++;

                rez = MessageBox.Show($"Is your number {randomNumber}? (Yes=It is, No=It's bigger, Cancel=It's smaller)",
                                       "Game",
                                       MessageBoxButtons.YesNoCancel,
                                       MessageBoxIcon.Question);

                if (rez == DialogResult.Yes)
                {
                    MessageBox.Show($"Great! I guessed your number in {tries} tries!");
                    break;  
                }
                else if (rez == DialogResult.No)
                {
                    low = randomNumber + 1;
                }
                else if (rez == DialogResult.Cancel)
                {
                    high = randomNumber - 1;
                }

                randomNumber = (low + high) / 2;

            } while (low <= high);

        }


        #endregion

        private Label label1;
        private Button button1;
    }
}