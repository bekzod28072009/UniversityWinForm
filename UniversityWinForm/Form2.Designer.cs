namespace UniversityWinForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            button1 = new Button();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            textBox3 = new TextBox();
            panel1 = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GrayText;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(67, 530);
            button1.Name = "button1";
            button1.Size = new Size(432, 48);
            button1.TabIndex = 0;
            button1.Text = "LOG IN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(149, 264);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(283, 31);
            textBox1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(230, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Bahnschrift", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.GrayText;
            label1.Location = new Point(168, 135);
            label1.Name = "label1";
            label1.Size = new Size(229, 53);
            label1.TabIndex = 4;
            label1.Text = "   LOG IN   ";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(98, 248);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(51, 47);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(98, 357);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(51, 47);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(149, 373);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(300, 31);
            textBox3.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlText;
            panel1.Location = new Point(98, 292);
            panel1.Name = "panel1";
            panel1.Size = new Size(334, 3);
            panel1.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(98, 401);
            panel3.Name = "panel3";
            panel3.Size = new Size(351, 3);
            panel3.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Dutch801 XBd BT", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(67, 481);
            label2.Name = "label2";
            label2.Size = new Size(84, 34);
            label2.TabIndex = 13;
            label2.Text = "Clear";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Dutch801 XBd BT", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Desktop;
            label3.Location = new Point(248, 605);
            label3.Name = "label3";
            label3.Size = new Size(68, 34);
            label3.TabIndex = 14;
            label3.Text = "Exit";
            label3.Click += label3_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(590, 727);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(pictureBox4);
            Controls.Add(textBox3);
            Controls.Add(pictureBox3);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private TextBox textBox3;
        private Panel panel1;
        private Panel panel3;
        private Label label2;
        private Label label3;
    }
}