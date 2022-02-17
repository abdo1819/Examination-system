namespace WindowsFormsApp1
{
    partial class Form1
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
            this.cmbBxChooseCourse = new System.Windows.Forms.ComboBox();
            this.rchBxShowQuestions = new System.Windows.Forms.RichTextBox();
            this.btnAddnewQues = new System.Windows.Forms.Button();
            this.btnRemoveQues = new System.Windows.Forms.Button();
            this.btnViewQues = new System.Windows.Forms.Button();
            this.examinationDataSet = new WindowsFormsApp1.ExaminationDataSet();
            this.lblPleaseChoose = new System.Windows.Forms.Label();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter = new WindowsFormsApp1.ExaminationDataSetTableAdapters.CourseTableAdapter();
            this.viewMCQBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewMCQTableAdapter = new WindowsFormsApp1.ExaminationDataSetTableAdapters.viewMCQTableAdapter();
            this.viewCourseTFQBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewCourseTFQTableAdapter = new WindowsFormsApp1.ExaminationDataSetTableAdapters.viewCourseTFQTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.ExaminationDataSetTableAdapters.TableAdapterManager();
            this.viewCourseTFQDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.examinationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewMCQBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewCourseTFQBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewCourseTFQDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBxChooseCourse
            // 
            this.cmbBxChooseCourse.DataSource = this.courseBindingSource;
            this.cmbBxChooseCourse.DisplayMember = "crs_name";
            this.cmbBxChooseCourse.FormattingEnabled = true;
            this.cmbBxChooseCourse.Location = new System.Drawing.Point(48, 58);
            this.cmbBxChooseCourse.Name = "cmbBxChooseCourse";
            this.cmbBxChooseCourse.Size = new System.Drawing.Size(301, 24);
            this.cmbBxChooseCourse.TabIndex = 0;
            this.cmbBxChooseCourse.ValueMember = "crs_id";
            // 
            // rchBxShowQuestions
            // 
            this.rchBxShowQuestions.Location = new System.Drawing.Point(827, 58);
            this.rchBxShowQuestions.Name = "rchBxShowQuestions";
            this.rchBxShowQuestions.Size = new System.Drawing.Size(23, 251);
            this.rchBxShowQuestions.TabIndex = 1;
            this.rchBxShowQuestions.Text = "";
            // 
            // btnAddnewQues
            // 
            this.btnAddnewQues.Location = new System.Drawing.Point(48, 365);
            this.btnAddnewQues.Name = "btnAddnewQues";
            this.btnAddnewQues.Size = new System.Drawing.Size(178, 47);
            this.btnAddnewQues.TabIndex = 2;
            this.btnAddnewQues.Text = "Add New Question";
            this.btnAddnewQues.UseVisualStyleBackColor = true;
            // 
            // btnRemoveQues
            // 
            this.btnRemoveQues.Location = new System.Drawing.Point(316, 365);
            this.btnRemoveQues.Name = "btnRemoveQues";
            this.btnRemoveQues.Size = new System.Drawing.Size(178, 47);
            this.btnRemoveQues.TabIndex = 3;
            this.btnRemoveQues.Text = "Remove Question";
            this.btnRemoveQues.UseVisualStyleBackColor = true;
            // 
            // btnViewQues
            // 
            this.btnViewQues.Location = new System.Drawing.Point(578, 365);
            this.btnViewQues.Name = "btnViewQues";
            this.btnViewQues.Size = new System.Drawing.Size(178, 47);
            this.btnViewQues.TabIndex = 4;
            this.btnViewQues.Text = "View Question";
            this.btnViewQues.UseVisualStyleBackColor = true;
            // 
            // examinationDataSet
            // 
            this.examinationDataSet.DataSetName = "ExaminationDataSet";
            this.examinationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblPleaseChoose
            // 
            this.lblPleaseChoose.AutoSize = true;
            this.lblPleaseChoose.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblPleaseChoose.Location = new System.Drawing.Point(45, 27);
            this.lblPleaseChoose.Name = "lblPleaseChoose";
            this.lblPleaseChoose.Size = new System.Drawing.Size(294, 16);
            this.lblPleaseChoose.TabIndex = 6;
            this.lblPleaseChoose.Text = "Please Choose the Course to show its Questions";
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.examinationDataSet;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // viewMCQBindingSource
            // 
            this.viewMCQBindingSource.DataMember = "viewMCQ";
            this.viewMCQBindingSource.DataSource = this.examinationDataSet;
            // 
            // viewMCQTableAdapter
            // 
            this.viewMCQTableAdapter.ClearBeforeFill = true;
            // 
            // viewCourseTFQBindingSource
            // 
            this.viewCourseTFQBindingSource.DataMember = "viewCourseTFQ";
            this.viewCourseTFQBindingSource.DataSource = this.examinationDataSet;
            // 
            // viewCourseTFQTableAdapter
            // 
            this.viewCourseTFQTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Course_AttendanceTableAdapter = null;
            this.tableAdapterManager.CourseTableAdapter = this.courseTableAdapter;
            this.tableAdapterManager.DepartmentTableAdapter = null;
            this.tableAdapterManager.Exam_AnswerTableAdapter = null;
            this.tableAdapterManager.Exam_QuestionTableAdapter = null;
            this.tableAdapterManager.ExamTableAdapter = null;
            this.tableAdapterManager.Ins_CourseTableAdapter = null;
            this.tableAdapterManager.InstructorTableAdapter = null;
            this.tableAdapterManager.MCQTableAdapter = null;
            this.tableAdapterManager.QuestionTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.TopicTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.ExaminationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // viewCourseTFQDataGridView
            // 
            this.viewCourseTFQDataGridView.AutoGenerateColumns = false;
            this.viewCourseTFQDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewCourseTFQDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.viewCourseTFQDataGridView.DataSource = this.viewCourseTFQBindingSource;
            this.viewCourseTFQDataGridView.Location = new System.Drawing.Point(48, 111);
            this.viewCourseTFQDataGridView.Name = "viewCourseTFQDataGridView";
            this.viewCourseTFQDataGridView.RowHeadersWidth = 51;
            this.viewCourseTFQDataGridView.RowTemplate.Height = 24;
            this.viewCourseTFQDataGridView.Size = new System.Drawing.Size(708, 220);
            this.viewCourseTFQDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Column1";
            this.dataGridViewTextBoxColumn1.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 473);
            this.Controls.Add(this.viewCourseTFQDataGridView);
            this.Controls.Add(this.lblPleaseChoose);
            this.Controls.Add(this.btnViewQues);
            this.Controls.Add(this.btnRemoveQues);
            this.Controls.Add(this.btnAddnewQues);
            this.Controls.Add(this.rchBxShowQuestions);
            this.Controls.Add(this.cmbBxChooseCourse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.examinationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewMCQBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewCourseTFQBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewCourseTFQDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBxChooseCourse;
        private System.Windows.Forms.RichTextBox rchBxShowQuestions;
        private System.Windows.Forms.Button btnAddnewQues;
        private System.Windows.Forms.Button btnRemoveQues;
        private System.Windows.Forms.Button btnViewQues;
        private ExaminationDataSet examinationDataSet;
        private System.Windows.Forms.Label lblPleaseChoose;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private ExaminationDataSetTableAdapters.CourseTableAdapter courseTableAdapter;
        private System.Windows.Forms.BindingSource viewMCQBindingSource;
        private ExaminationDataSetTableAdapters.viewMCQTableAdapter viewMCQTableAdapter;
        private System.Windows.Forms.BindingSource viewCourseTFQBindingSource;
        private ExaminationDataSetTableAdapters.viewCourseTFQTableAdapter viewCourseTFQTableAdapter;
        private ExaminationDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView viewCourseTFQDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}

