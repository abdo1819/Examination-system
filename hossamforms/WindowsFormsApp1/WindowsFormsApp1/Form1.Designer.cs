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
            this.cmboxCooseCourse = new System.Windows.Forms.ComboBox();
            this.btnViewQuestion = new System.Windows.Forms.Button();
            this.btnAddNewQuestion = new System.Windows.Forms.Button();
            this.btnRemoveQuestion = new System.Windows.Forms.Button();
            this.grdViewCourses = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // cmboxCooseCourse
            // 
            this.cmboxCooseCourse.FormattingEnabled = true;
            this.cmboxCooseCourse.Location = new System.Drawing.Point(41, 36);
            this.cmboxCooseCourse.Name = "cmboxCooseCourse";
            this.cmboxCooseCourse.Size = new System.Drawing.Size(322, 24);
            this.cmboxCooseCourse.TabIndex = 0;
            // 
            // btnViewQuestion
            // 
            this.btnViewQuestion.Location = new System.Drawing.Point(605, 344);
            this.btnViewQuestion.Name = "btnViewQuestion";
            this.btnViewQuestion.Size = new System.Drawing.Size(139, 58);
            this.btnViewQuestion.TabIndex = 1;
            this.btnViewQuestion.Text = "View Question";
            this.btnViewQuestion.UseVisualStyleBackColor = true;
            // 
            // btnAddNewQuestion
            // 
            this.btnAddNewQuestion.Location = new System.Drawing.Point(323, 344);
            this.btnAddNewQuestion.Name = "btnAddNewQuestion";
            this.btnAddNewQuestion.Size = new System.Drawing.Size(139, 58);
            this.btnAddNewQuestion.TabIndex = 2;
            this.btnAddNewQuestion.Text = "Add New Question";
            this.btnAddNewQuestion.UseVisualStyleBackColor = true;
            // 
            // btnRemoveQuestion
            // 
            this.btnRemoveQuestion.Location = new System.Drawing.Point(41, 344);
            this.btnRemoveQuestion.Name = "btnRemoveQuestion";
            this.btnRemoveQuestion.Size = new System.Drawing.Size(139, 58);
            this.btnRemoveQuestion.TabIndex = 3;
            this.btnRemoveQuestion.Text = "Remove Question";
            this.btnRemoveQuestion.UseVisualStyleBackColor = true;
            // 
            // grdViewCourses
            // 
            this.grdViewCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdViewCourses.Location = new System.Drawing.Point(41, 101);
            this.grdViewCourses.Name = "grdViewCourses";
            this.grdViewCourses.RowHeadersWidth = 51;
            this.grdViewCourses.RowTemplate.Height = 24;
            this.grdViewCourses.Size = new System.Drawing.Size(703, 202);
            this.grdViewCourses.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdViewCourses);
            this.Controls.Add(this.btnRemoveQuestion);
            this.Controls.Add(this.btnAddNewQuestion);
            this.Controls.Add(this.btnViewQuestion);
            this.Controls.Add(this.cmboxCooseCourse);
            this.Name = "Form1";
            this.Text = "Course Questions";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdViewCourses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmboxCooseCourse;
        private System.Windows.Forms.Button btnViewQuestion;
        private System.Windows.Forms.Button btnAddNewQuestion;
        private System.Windows.Forms.Button btnRemoveQuestion;
        private System.Windows.Forms.DataGridView grdViewCourses;
    }
}