
namespace FrmHome
{
    partial class Student_ViewGrades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_ViewGrades));
            this.btnBack = new System.Windows.Forms.Button();
            this.comboBoxCourses = new System.Windows.Forms.ComboBox();
            this.lblSelectCourse = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblStdGrade = new System.Windows.Forms.Label();
            this.lblStdGradeValue = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkRed;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Location = new System.Drawing.Point(26, 325);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(128, 55);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "Go Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // comboBoxCourses
            // 
            this.comboBoxCourses.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCourses.FormattingEnabled = true;
            this.comboBoxCourses.Location = new System.Drawing.Point(68, 134);
            this.comboBoxCourses.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxCourses.Name = "comboBoxCourses";
            this.comboBoxCourses.Size = new System.Drawing.Size(426, 31);
            this.comboBoxCourses.TabIndex = 21;
            this.comboBoxCourses.Visible = false;
            this.comboBoxCourses.SelectedIndexChanged += new System.EventHandler(this.comboBoxCourses_SelectedIndexChanged);
            // 
            // lblSelectCourse
            // 
            this.lblSelectCourse.AutoSize = true;
            this.lblSelectCourse.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblSelectCourse.Location = new System.Drawing.Point(89, 83);
            this.lblSelectCourse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectCourse.Name = "lblSelectCourse";
            this.lblSelectCourse.Size = new System.Drawing.Size(386, 25);
            this.lblSelectCourse.TabIndex = 22;
            this.lblSelectCourse.Text = "Select a Course to view your Grades:";
            this.lblSelectCourse.Visible = false;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnShow.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnShow.Location = new System.Drawing.Point(403, 325);
            this.btnShow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(128, 55);
            this.btnShow.TabIndex = 23;
            this.btnShow.Text = "Show Courses";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblStdGrade
            // 
            this.lblStdGrade.AutoSize = true;
            this.lblStdGrade.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStdGrade.Location = new System.Drawing.Point(207, 201);
            this.lblStdGrade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStdGrade.Name = "lblStdGrade";
            this.lblStdGrade.Size = new System.Drawing.Size(130, 25);
            this.lblStdGrade.TabIndex = 24;
            this.lblStdGrade.Text = "Your Grade";
            this.lblStdGrade.Visible = false;
            // 
            // lblStdGradeValue
            // 
            this.lblStdGradeValue.AutoSize = true;
            this.lblStdGradeValue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStdGradeValue.Location = new System.Drawing.Point(238, 251);
            this.lblStdGradeValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStdGradeValue.Name = "lblStdGradeValue";
            this.lblStdGradeValue.Size = new System.Drawing.Size(60, 19);
            this.lblStdGradeValue.TabIndex = 25;
            this.lblStdGradeValue.Text = "10 / 10";
            this.lblStdGradeValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStdGradeValue.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblSelectCourse);
            this.panel1.Controls.Add(this.lblStdGradeValue);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.lblStdGrade);
            this.panel1.Controls.Add(this.comboBoxCourses);
            this.panel1.Controls.Add(this.btnShow);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 427);
            this.panel1.TabIndex = 26;
            // 
            // Student_ViewGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(578, 451);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(603, 175);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Student_ViewGrades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "View Grades";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox comboBoxCourses;
        private System.Windows.Forms.Label lblSelectCourse;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblStdGrade;
        private System.Windows.Forms.Label lblStdGradeValue;
        private System.Windows.Forms.Panel panel1;
    }
}