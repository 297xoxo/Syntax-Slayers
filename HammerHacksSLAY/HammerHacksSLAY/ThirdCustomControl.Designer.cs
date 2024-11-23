namespace HammerHacksSLAY
{
    partial class ThirdCustomControl
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
            textBox1 = new TextBox();
            panel4 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            panel3 = new Panel();
            lblQuotes = new Label();
            btnGenerate = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Gabriola", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(258, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(402, 109);
            textBox1.TabIndex = 2;
            textBox1.Text = "Motivational Quotes";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel4
            // 
            panel4.BackColor = Color.MediumPurple;
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(935, 31);
            panel4.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumPurple;
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(899, 31);
            panel2.Name = "panel2";
            panel2.Size = new Size(36, 475);
            panel2.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumPurple;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(40, 475);
            panel1.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MediumPurple;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(40, 474);
            panel3.Name = "panel3";
            panel3.Size = new Size(859, 32);
            panel3.TabIndex = 8;
            // 
            // lblQuotes
            // 
            lblQuotes.AutoSize = true;
            lblQuotes.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuotes.Location = new Point(161, 224);
            lblQuotes.Name = "lblQuotes";
            lblQuotes.Size = new Size(41, 37);
            lblQuotes.TabIndex = 9;
            lblQuotes.Text = "...";
            lblQuotes.Click += label1_Click;
            // 
            // btnGenerate
            // 
            btnGenerate.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerate.Location = new Point(331, 365);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(236, 61);
            btnGenerate.TabIndex = 10;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += button1_Click;
            // 
            // ThirdCustomControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnGenerate);
            Controls.Add(lblQuotes);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(textBox1);
            Name = "ThirdCustomControl";
            Size = new Size(935, 506);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Panel panel4;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private Label lblQuotes;
        private Button btnGenerate;
    }
}
