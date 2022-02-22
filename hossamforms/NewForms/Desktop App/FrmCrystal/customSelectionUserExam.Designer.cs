
namespace ReportsForm
{
    partial class customSelectionUserExam
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
            this.components = new System.ComponentModel.Container();
            this.cmbStudent = new System.Windows.Forms.ComboBox();
            this.cmbExam = new System.Windows.Forms.ComboBox();
            this.examinationDataSet = new ReportsForm.ExaminationDataSet();
            this.getAllInstructorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getAllInstructorsTableAdapter = new ReportsForm.ExaminationDataSetTableAdapters.getAllInstructorsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.examinationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllInstructorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbStudent
            // 
            this.cmbStudent.FormattingEnabled = true;
            this.cmbStudent.Location = new System.Drawing.Point(461, 88);
            this.cmbStudent.Name = "cmbStudent";
            this.cmbStudent.Size = new System.Drawing.Size(208, 24);
            this.cmbStudent.TabIndex = 0;
            // 
            // cmbExam
            // 
            this.cmbExam.FormattingEnabled = true;
            this.cmbExam.Location = new System.Drawing.Point(461, 169);
            this.cmbExam.Name = "cmbExam";
            this.cmbExam.Size = new System.Drawing.Size(208, 24);
            this.cmbExam.TabIndex = 1;
            // 
            // examinationDataSet
            // 
            this.examinationDataSet.DataSetName = "ExaminationDataSet";
            this.examinationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getAllInstructorsBindingSource
            // 
            this.getAllInstructorsBindingSource.DataMember = "getAllInstructors";
            this.getAllInstructorsBindingSource.DataSource = this.examinationDataSet;
            // 
            // getAllInstructorsTableAdapter
            // 
            this.getAllInstructorsTableAdapter.ClearBeforeFill = true;
            // 
            // customSelectionUserExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbExam);
            this.Controls.Add(this.cmbStudent);
            this.Name = "customSelectionUserExam";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.customSelectionUserExam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.examinationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllInstructorsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbStudent;
        private System.Windows.Forms.ComboBox cmbExam;
        private ExaminationDataSet examinationDataSet;
        private System.Windows.Forms.BindingSource getAllInstructorsBindingSource;
        private ExaminationDataSetTableAdapters.getAllInstructorsTableAdapter getAllInstructorsTableAdapter;
    }
}