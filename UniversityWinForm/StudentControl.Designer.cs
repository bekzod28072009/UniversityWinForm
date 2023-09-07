namespace UniversityWinForm
{
    partial class StudentControl
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            Id = new Label();
            Name = new Label();
            label5 = new Label();
            TeacherName = new Label();
            label7 = new Label();
            Course = new Label();
            Faculity = new Label();
            label10 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.InactiveCaption;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label10, 0, 4);
            tableLayoutPanel1.Controls.Add(Faculity, 0, 4);
            tableLayoutPanel1.Controls.Add(Course, 1, 3);
            tableLayoutPanel1.Controls.Add(label7, 0, 3);
            tableLayoutPanel1.Controls.Add(TeacherName, 1, 2);
            tableLayoutPanel1.Controls.Add(label5, 0, 2);
            tableLayoutPanel1.Controls.Add(Name, 1, 1);
            tableLayoutPanel1.Controls.Add(Id, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Location = new Point(36, 26);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(353, 449);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 89);
            label1.Name = "label1";
            label1.Size = new Size(170, 89);
            label1.TabIndex = 0;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(170, 89);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // Id
            // 
            Id.AutoSize = true;
            Id.Dock = DockStyle.Fill;
            Id.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Id.Location = new Point(179, 0);
            Id.Name = "Id";
            Id.Size = new Size(171, 89);
            Id.TabIndex = 2;
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Dock = DockStyle.Fill;
            Name.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name.Location = new Point(179, 89);
            Name.Name = "Name";
            Name.Size = new Size(171, 89);
            Name.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(3, 178);
            label5.Name = "label5";
            label5.Size = new Size(170, 89);
            label5.TabIndex = 4;
            label5.Text = "Teacher";
            // 
            // TeacherName
            // 
            TeacherName.AutoSize = true;
            TeacherName.Dock = DockStyle.Fill;
            TeacherName.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TeacherName.Location = new Point(179, 178);
            TeacherName.Name = "TeacherName";
            TeacherName.Size = new Size(171, 89);
            TeacherName.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(3, 267);
            label7.Name = "label7";
            label7.Size = new Size(170, 89);
            label7.TabIndex = 6;
            label7.Text = "Course";
            // 
            // Course
            // 
            Course.AutoSize = true;
            Course.Dock = DockStyle.Fill;
            Course.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Course.Location = new Point(179, 267);
            Course.Name = "Course";
            Course.Size = new Size(171, 89);
            Course.TabIndex = 7;
            // 
            // Faculity
            // 
            Faculity.AutoSize = true;
            Faculity.Dock = DockStyle.Fill;
            Faculity.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Faculity.Location = new Point(179, 356);
            Faculity.Name = "Faculity";
            Faculity.Size = new Size(171, 93);
            Faculity.TabIndex = 8;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Fill;
            label10.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(3, 356);
            label10.Name = "label10";
            label10.Size = new Size(170, 93);
            label10.TabIndex = 9;
            label10.Text = "Faculity";
            // 
            // StudentControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(tableLayoutPanel1);
            Name = "StudentControl";
            Size = new Size(1599, 959);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label Course;
        private Label label7;
        private Label TeacherName;
        private Label label5;
        private Label Name;
        private Label Id;
        private Label label2;
        private Label label10;
        private Label Faculity;
    }
}
