namespace HammerHacksSLAY
{
    partial class SecondCustomControl
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
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            panel4 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox2 = new TextBox();
            timer = new System.Windows.Forms.Timer(components);
            timerlabel = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Gabriola", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(349, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(213, 109);
            textBox1.TabIndex = 1;
            textBox1.Text = "Pomadoro";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Thistle;
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(935, 31);
            panel4.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Thistle;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(40, 475);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Thistle;
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(899, 31);
            panel2.Name = "panel2";
            panel2.Size = new Size(36, 475);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Thistle;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(40, 474);
            panel3.Name = "panel3";
            panel3.Size = new Size(859, 32);
            panel3.TabIndex = 6;
            // 
            // button1
            // 
            button1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(254, 259);
            button1.Name = "button1";
            button1.Size = new Size(185, 53);
            button1.TabIndex = 7;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(456, 259);
            button2.Name = "button2";
            button2.Size = new Size(185, 53);
            button2.TabIndex = 8;
            button2.Text = "Stop";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(254, 318);
            button3.Name = "button3";
            button3.Size = new Size(387, 53);
            button3.TabIndex = 9;
            button3.Text = "Start";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(201, 126);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(525, 44);
            textBox2.TabIndex = 10;
            textBox2.Text = "25 miunte studying : 5 minute break";
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer1_Tick;
            // 
            // timerlabel
            // 
            timerlabel.AutoSize = true;
            timerlabel.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            timerlabel.Location = new Point(372, 204);
            timerlabel.Name = "timerlabel";
            timerlabel.Size = new Size(171, 37);
            timerlabel.TabIndex = 11;
            timerlabel.Text = "25 minutes";
            timerlabel.Click += timerlabel_Click;
            // 
            // SecondCustomControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(timerlabel);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(textBox1);
            Name = "SecondCustomControl";
            Size = new Size(935, 506);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Panel panel4;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox2;
        private System.Windows.Forms.Timer timer;
        private Label timerlabel;
    }
}
