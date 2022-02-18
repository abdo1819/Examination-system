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
            this.getAvailableCoursesForExamTableAdapter = new Trial.ExaminationDataSetTableAdapters.getAvailableCoursesForExamTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAvailableCourses = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerateExam = new System.Windows.Forms.Button();
            this.generateExamTableAdapter1 = new Trial.ExaminationDataSetTableAdapters.generateExamTableAdapter();
            this.SuspendLayout();
            // 
            // getAvailableCoursesForExamTableAdapter
            // 
            this.getAvailableCoursesForExamTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose the course to generate exam for: \r\n";
            // 
            // cmbAvailableCourses
            // 
            this.cmbAvailableCourses.FormattingEnabled = true;
            this.cmbAvailableCourses.Location = new System.Drawing.Point(323, 30);
            this.cmbAvailableCourses.Name = "cmbAvailableCourses";
            this.cmbAvailableCourses.Size = new System.Drawing.Size(231, 21);
            this.cmbAvailableCourses.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(144, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "You can take exam in a certain course only once!";
            // 
            // btnGenerateExam
            // 
            this.btnGenerateExam.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateExam.Location = new System.Drawing.Point(223, 116);
            this.btnGenerateExam.Name = "btnGenerateExam";
            this.btnGenerateExam.Size = new System.Drawing.Size(149, 53);
            this.btnGenerateExam.TabIndex = 3;
            this.btnGenerateExam.Text = "Start Exam";
            this.btnGenerateExam.UseVisualStyleBackColor = true;
            this.btnGenerateExam.Click += new System.EventHandler(this.button1_Click);
            // 
            // generateExamTableAdapter1
            // 
            this.generateExamTableAdapter1.ClearBeforeFill = true;
            // 
            // frmAvailableCoursesForExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 193);
            this.Controls.Add(this.btnGenerateExam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbAvailableCourses);
            this.Controls.Add(this.label1);
            this.Name = "frmAvailableCoursesForExam";
            this.Text = "Available Courses";
            this.Load += new System.EventHandler(this.frmAvailableCoursesForExam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ExaminationDataSetTableAdapters.getAvailableCoursesForExamTableAdapter getAvailableCoursesForExamTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAvailableCourses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerateExam;
        private ExaminationDataSetTableAdapters.generateExamTableAdapter generateExamTableAdapter1;
    }
}