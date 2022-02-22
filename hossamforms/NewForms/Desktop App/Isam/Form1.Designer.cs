
namespace Isam
{
    partial class frmStudent
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
            this.btnGenerateExam = new System.Windows.Forms.Button();
            this.txtStudenID = new System.Windows.Forms.TextBox();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.generateExamTableAdapter1 = new Isam.ExaminationDataSet1TableAdapters.generateExamTableAdapter();
            this.SuspendLayout();
            // 
            // btnGenerateExam
            // 
            this.btnGenerateExam.Location = new System.Drawing.Point(164, 220);
            this.btnGenerateExam.Name = "btnGenerateExam";
            this.btnGenerateExam.Size = new System.Drawing.Size(147, 40);
            this.btnGenerateExam.TabIndex = 0;
            this.btnGenerateExam.Text = "Generate Exam";
            this.btnGenerateExam.UseVisualStyleBackColor = true;
            this.btnGenerateExam.Click += new System.EventHandler(this.btnGenerateExam_Click);
            // 
            // txtStudenID
            // 
            this.txtStudenID.Location = new System.Drawing.Point(164, 37);
            this.txtStudenID.Name = "txtStudenID";
            this.txtStudenID.Size = new System.Drawing.Size(147, 20);
            this.txtStudenID.TabIndex = 1;
            // 
            // txtCourseID
            // 
            this.txtCourseID.Location = new System.Drawing.Point(164, 63);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new System.Drawing.Size(147, 20);
            this.txtCourseID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Student ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Course";
            // 
            // generateExamTableAdapter1
            // 
            this.generateExamTableAdapter1.ClearBeforeFill = true;
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 361);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCourseID);
            this.Controls.Add(this.txtStudenID);
            this.Controls.Add(this.btnGenerateExam);
            this.Name = "frmStudent";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateExam;
        private System.Windows.Forms.TextBox txtStudenID;
        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ExaminationDataSet1TableAdapters.generateExamTableAdapter generateExamTableAdapter1;
    }
}

