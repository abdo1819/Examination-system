
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.comboBoxCourses = new System.Windows.Forms.ComboBox();
            this.lblSelectCourse = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblStdGrade = new System.Windows.Forms.Label();
            this.lblStdGradeValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 392);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(110, 44);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "Go Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // comboBoxCourses
            // 
            this.comboBoxCourses.FormattingEnabled = true;
            this.comboBoxCourses.Location = new System.Drawing.Point(407, 160);
            this.comboBoxCourses.Name = "comboBoxCourses";
            this.comboBoxCourses.Size = new System.Drawing.Size(254, 24);
            this.comboBoxCourses.TabIndex = 21;
            this.comboBoxCourses.Visible = false;
            this.comboBoxCourses.SelectedIndexChanged += new System.EventHandler(this.comboBoxCourses_SelectedIndexChanged);
            // 
            // lblSelectCourse
            // 
            this.lblSelectCourse.AutoSize = true;
            this.lblSelectCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCourse.Location = new System.Drawing.Point(36, 160);
            this.lblSelectCourse.Name = "lblSelectCourse";
            this.lblSelectCourse.Size = new System.Drawing.Size(288, 20);
            this.lblSelectCourse.TabIndex = 22;
            this.lblSelectCourse.Text = "Select a Course to view your Grades:";
            this.lblSelectCourse.Visible = false;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(678, 392);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(110, 44);
            this.btnShow.TabIndex = 23;
            this.btnShow.Text = "Show Courses";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblStdGrade
            // 
            this.lblStdGrade.AutoSize = true;
            this.lblStdGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStdGrade.Location = new System.Drawing.Point(94, 255);
            this.lblStdGrade.Name = "lblStdGrade";
            this.lblStdGrade.Size = new System.Drawing.Size(124, 25);
            this.lblStdGrade.TabIndex = 24;
            this.lblStdGrade.Text = "[Your Grade]";
            this.lblStdGrade.Visible = false;
            // 
            // lblStdGradeValue
            // 
            this.lblStdGradeValue.AutoSize = true;
            this.lblStdGradeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStdGradeValue.Location = new System.Drawing.Point(552, 255);
            this.lblStdGradeValue.Name = "lblStdGradeValue";
            this.lblStdGradeValue.Size = new System.Drawing.Size(134, 25);
            this.lblStdGradeValue.TabIndex = 25;
            this.lblStdGradeValue.Text = "[Grade Value]";
            this.lblStdGradeValue.Visible = false;
            // 
            // Student_ViewGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblStdGradeValue);
            this.Controls.Add(this.lblStdGrade);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblSelectCourse);
            this.Controls.Add(this.comboBoxCourses);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Student_ViewGrades";
            this.Text = "View Grades";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox comboBoxCourses;
        private System.Windows.Forms.Label lblSelectCourse;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblStdGrade;
        private System.Windows.Forms.Label lblStdGradeValue;
    }
}