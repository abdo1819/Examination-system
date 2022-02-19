namespace Trial
{
    partial class frmAvailableCoursesForExam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAvailableCoursesForExam));
            this.getAvailableCoursesForExamTableAdapter = new Trial.ExaminationDataSetTableAdapters.getAvailableCoursesForExamTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAvailableCourses = new System.Windows.Forms.ComboBox();
            this.btnGenerateExam = new System.Windows.Forms.Button();
            this.generateExamTableAdapter1 = new Trial.ExaminationDataSetTableAdapters.generateExamTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // getAvailableCoursesForExamTableAdapter
            // 
            this.getAvailableCoursesForExamTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(80, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose the course to generate exam for: \r\n";
            // 
            // cmbAvailableCourses
            // 
            this.cmbAvailableCourses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAvailableCourses.FormattingEnabled = true;
            this.cmbAvailableCourses.Location = new System.Drawing.Point(87, 157);
            this.cmbAvailableCourses.Name = "cmbAvailableCourses";
            this.cmbAvailableCourses.Size = new System.Drawing.Size(377, 21);
            this.cmbAvailableCourses.TabIndex = 1;
            // 
            // btnGenerateExam
            // 
            this.btnGenerateExam.BackColor = System.Drawing.Color.White;
            this.btnGenerateExam.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateExam.ForeColor = System.Drawing.Color.DarkRed;
            this.btnGenerateExam.Location = new System.Drawing.Point(198, 214);
            this.btnGenerateExam.Name = "btnGenerateExam";
            this.btnGenerateExam.Size = new System.Drawing.Size(149, 53);
            this.btnGenerateExam.TabIndex = 3;
            this.btnGenerateExam.Text = "Start Exam";
            this.btnGenerateExam.UseVisualStyleBackColor = false;
            this.btnGenerateExam.Click += new System.EventHandler(this.button1_Click);
            // 
            // generateExamTableAdapter1
            // 
            this.generateExamTableAdapter1.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(380, 28);
            this.label3.TabIndex = 21;
            this.label3.Text = "Information Technology Institute";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(632, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(734, 768);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(617, 19);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 43);
            this.button2.TabIndex = 6;
            this.button2.Text = "ــ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(672, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DarkRed;
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btnGenerateExam);
            this.groupBox3.Controls.Add(this.cmbAvailableCourses);
            this.groupBox3.Location = new System.Drawing.Point(106, 196);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(538, 342);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox2.Location = new System.Drawing.Point(0, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(632, 609);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Notes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(22, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(342, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Please read the following notes carefully: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(53, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(509, 308);
            this.label2.TabIndex = 0;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // frmAvailableCoursesForExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAvailableCoursesForExam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Available Courses";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAvailableCoursesForExam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ExaminationDataSetTableAdapters.getAvailableCoursesForExamTableAdapter getAvailableCoursesForExamTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAvailableCourses;
        private System.Windows.Forms.Button btnGenerateExam;
        private ExaminationDataSetTableAdapters.generateExamTableAdapter generateExamTableAdapter1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
    }
}