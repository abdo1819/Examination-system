
namespace FrmHome
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
            this.button1 = new System.Windows.Forms.Button();
            this.getAllStudentsTableAdapter1 = new FrmHome.ExaminationDataSetTableAdapters.getAllStudentsTableAdapter();
            this.insert_StudentTableAdapter1 = new FrmHome.ExaminationDataSetTableAdapters.Insert_StudentTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnViewGrades = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "TakeExam";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // getAllStudentsTableAdapter1
            // 
            this.getAllStudentsTableAdapter1.ClearBeforeFill = true;
            // 
            // insert_StudentTableAdapter1
            // 
            this.insert_StudentTableAdapter1.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(72, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(249, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "view topics of course";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(72, 278);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(249, 45);
            this.button3.TabIndex = 2;
            this.button3.Text = "exam with student answer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(508, 78);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(203, 41);
            this.button4.TabIndex = 3;
            this.button4.Text = "view student in department";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnViewGrades
            // 
            this.btnViewGrades.Location = new System.Drawing.Point(573, 177);
            this.btnViewGrades.Name = "btnViewGrades";
            this.btnViewGrades.Size = new System.Drawing.Size(100, 100);
            this.btnViewGrades.TabIndex = 4;
            this.btnViewGrades.Text = "View Student Grades";
            this.btnViewGrades.UseVisualStyleBackColor = true;
            this.btnViewGrades.Click += new System.EventHandler(this.btnViewGrades_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnViewGrades);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private ExaminationDataSetTableAdapters.getAllStudentsTableAdapter getAllStudentsTableAdapter1;
        private ExaminationDataSetTableAdapters.Insert_StudentTableAdapter insert_StudentTableAdapter1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnViewGrades;
    }
}

