
namespace FrmHome
{
    partial class Admin_AssignStudentToCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_AssignStudentToCourse));
            this.btnGoBack = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.comboStudent = new System.Windows.Forms.ComboBox();
            this.comboCourse = new System.Windows.Forms.ComboBox();
            this.comboInstructor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.DarkRed;
            this.btnGoBack.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnGoBack.ForeColor = System.Drawing.Color.White;
            this.btnGoBack.Location = new System.Drawing.Point(14, 343);
            this.btnGoBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(117, 65);
            this.btnGoBack.TabIndex = 0;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnConfirm.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(423, 343);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(117, 65);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboStudent);
            this.panel1.Controls.Add(this.comboCourse);
            this.panel1.Controls.Add(this.comboInstructor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnConfirm);
            this.panel1.Controls.Add(this.btnGoBack);
            this.panel1.Location = new System.Drawing.Point(11, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 427);
            this.panel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(158, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Enroll Student in a Course";
            // 
            // comboStudent
            // 
            this.comboStudent.FormattingEnabled = true;
            this.comboStudent.Location = new System.Drawing.Point(206, 128);
            this.comboStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboStudent.Name = "comboStudent";
            this.comboStudent.Size = new System.Drawing.Size(244, 21);
            this.comboStudent.TabIndex = 9;
            this.comboStudent.SelectedIndexChanged += new System.EventHandler(this.comboStudent_SelectedIndexChanged);
            // 
            // comboCourse
            // 
            this.comboCourse.FormattingEnabled = true;
            this.comboCourse.Location = new System.Drawing.Point(206, 188);
            this.comboCourse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboCourse.Name = "comboCourse";
            this.comboCourse.Size = new System.Drawing.Size(244, 21);
            this.comboCourse.TabIndex = 8;
            this.comboCourse.SelectedIndexChanged += new System.EventHandler(this.comboCourse_SelectedIndexChanged);
            // 
            // comboInstructor
            // 
            this.comboInstructor.FormattingEnabled = true;
            this.comboInstructor.Location = new System.Drawing.Point(206, 249);
            this.comboInstructor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboInstructor.Name = "comboInstructor";
            this.comboInstructor.Size = new System.Drawing.Size(244, 21);
            this.comboInstructor.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(85, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select Student";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(85, 189);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select Course";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(85, 249);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select Instructor";
            // 
            // Admin_AssignStudentToCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(577, 451);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(700, 200);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Admin_AssignStudentToCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Admin_AssignStudentToCourse";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboStudent;
        private System.Windows.Forms.ComboBox comboCourse;
        private System.Windows.Forms.ComboBox comboInstructor;
        private System.Windows.Forms.Label label4;
    }
}