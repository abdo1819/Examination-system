namespace ExaminationSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmboxCourses = new System.Windows.Forms.ComboBox();
            this.grdQuestions = new System.Windows.Forms.DataGridView();
            this.btmRemoveQuestion = new System.Windows.Forms.Button();
            this.btnAddNewQuestion = new System.Windows.Forms.Button();
            this.btnViewQuestion = new System.Windows.Forms.Button();
            this.grdQuestions2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdQuestions2)).BeginInit();
            this.SuspendLayout();
            // 
            // cmboxCourses
            // 
            this.cmboxCourses.FormattingEnabled = true;
            this.cmboxCourses.Location = new System.Drawing.Point(37, 31);
            this.cmboxCourses.Name = "cmboxCourses";
            this.cmboxCourses.Size = new System.Drawing.Size(385, 28);
            this.cmboxCourses.TabIndex = 0;
            // 
            // grdQuestions
            // 
            this.grdQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdQuestions.Location = new System.Drawing.Point(37, 89);
            this.grdQuestions.Name = "grdQuestions";
            this.grdQuestions.RowHeadersWidth = 51;
            this.grdQuestions.RowTemplate.Height = 29;
            this.grdQuestions.Size = new System.Drawing.Size(385, 313);
            this.grdQuestions.TabIndex = 1;
            // 
            // btmRemoveQuestion
            // 
            this.btmRemoveQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btmRemoveQuestion.Location = new System.Drawing.Point(37, 450);
            this.btmRemoveQuestion.Name = "btmRemoveQuestion";
            this.btmRemoveQuestion.Size = new System.Drawing.Size(179, 57);
            this.btmRemoveQuestion.TabIndex = 2;
            this.btmRemoveQuestion.Text = "Remove Question";
            this.btmRemoveQuestion.UseVisualStyleBackColor = true;
            // 
            // btnAddNewQuestion
            // 
            this.btnAddNewQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewQuestion.Location = new System.Drawing.Point(501, 450);
            this.btnAddNewQuestion.Name = "btnAddNewQuestion";
            this.btnAddNewQuestion.Size = new System.Drawing.Size(157, 57);
            this.btnAddNewQuestion.TabIndex = 3;
            this.btnAddNewQuestion.Text = "Add New Question";
            this.btnAddNewQuestion.UseVisualStyleBackColor = true;
            // 
            // btnViewQuestion
            // 
            this.btnViewQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewQuestion.Location = new System.Drawing.Point(1011, 450);
            this.btnViewQuestion.Name = "btnViewQuestion";
            this.btnViewQuestion.Size = new System.Drawing.Size(157, 57);
            this.btnViewQuestion.TabIndex = 4;
            this.btnViewQuestion.Text = "View Question";
            this.btnViewQuestion.UseVisualStyleBackColor = true;
            this.btnViewQuestion.Click += new System.EventHandler(this.btnViewQuestion_Click);
            // 
            // grdQuestions2
            // 
            this.grdQuestions2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdQuestions2.Location = new System.Drawing.Point(501, 89);
            this.grdQuestions2.Name = "grdQuestions2";
            this.grdQuestions2.RowHeadersWidth = 51;
            this.grdQuestions2.RowTemplate.Height = 29;
            this.grdQuestions2.Size = new System.Drawing.Size(667, 313);
            this.grdQuestions2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 562);
            this.Controls.Add(this.grdQuestions2);
            this.Controls.Add(this.btnViewQuestion);
            this.Controls.Add(this.btnAddNewQuestion);
            this.Controls.Add(this.btmRemoveQuestion);
            this.Controls.Add(this.grdQuestions);
            this.Controls.Add(this.cmboxCourses);
            this.Name = "Form1";
            this.Text = "Choose course for Questions";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdQuestions2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox cmboxCourses;
        private DataGridView grdQuestions;
        private Button btmRemoveQuestion;
        private Button btnAddNewQuestion;
        private Button btnViewQuestion;
        private DataGridView grdQuestions2;
    }
}