namespace HammerHacksSLAY
{
    partial class FirstCustomControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstCustomControl));
            textBox1 = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Gabriola", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(338, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(213, 109);
            textBox1.TabIndex = 0;
            textBox1.Text = "To do list";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 474);
            panel1.Name = "panel1";
            panel1.Size = new Size(935, 32);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSteelBlue;
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(899, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(36, 474);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSteelBlue;
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(899, 38);
            panel3.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightSteelBlue;
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 38);
            panel4.Name = "panel4";
            panel4.Size = new Size(43, 436);
            panel4.TabIndex = 4;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Gabriola", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(94, 281);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(441, 59);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Complete Homework and Assignments\r\n";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Gabriola", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox2.Location = new Point(94, 122);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(238, 59);
            checkBox2.TabIndex = 6;
            checkBox2.Text = "Drink lots of water\r\n";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Gabriola", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox3.Location = new Point(94, 344);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(414, 59);
            checkBox3.TabIndex = 7;
            checkBox3.Text = "Take a 10-minute mindfulness break";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("Gabriola", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox4.Location = new Point(94, 171);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(284, 59);
            checkBox4.TabIndex = 8;
            checkBox4.Text = "Go for a walk or stretch\r\n";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Font = new Font("Gabriola", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox5.Location = new Point(94, 225);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(281, 59);
            checkBox5.TabIndex = 9;
            checkBox5.Text = "Spend time with family\r\n";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Font = new Font("Gabriola", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox6.Location = new Point(94, 409);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(323, 59);
            checkBox6.TabIndex = 10;
            checkBox6.Text = "Get at least 7 hours of sleep\r\n";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(553, 138);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(323, 222);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // FirstCustomControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(pictureBox1);
            Controls.Add(checkBox6);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Name = "FirstCustomControl";
            Size = new Size(935, 506);
            Load += FirstCustomControl_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private PictureBox pictureBox1;
    }
}
