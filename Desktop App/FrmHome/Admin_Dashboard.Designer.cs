
namespace FrmHome
{
    partial class Admin_Dashboard
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
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnQuestions = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnExams = new System.Windows.Forms.Button();
            this.btnCourses = new System.Windows.Forms.Button();
            this.btnDepts = new System.Windows.Forms.Button();
            this.groupInfo = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDept = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStdID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.groupInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStudents
            // 
            this.btnStudents.Location = new System.Drawing.Point(407, 187);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(94, 46);
            this.btnStudents.TabIndex = 0;
            this.btnStudents.Text = "Manage Students";
            this.btnStudents.UseVisualStyleBackColor = true;
            // 
            // btnQuestions
            // 
            this.btnQuestions.Location = new System.Drawing.Point(589, 174);
            this.btnQuestions.Name = "btnQuestions";
            this.btnQuestions.Size = new System.Drawing.Size(116, 62);
            this.btnQuestions.TabIndex = 1;
            this.btnQuestions.Text = "Manage Questions";
            this.btnQuestions.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(397, 51);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(104, 55);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "Reports Dashboard";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnExams
            // 
            this.btnExams.Location = new System.Drawing.Point(397, 310);
            this.btnExams.Name = "btnExams";
            this.btnExams.Size = new System.Drawing.Size(106, 43);
            this.btnExams.TabIndex = 3;
            this.btnExams.Text = "Manage Exams";
            this.btnExams.UseVisualStyleBackColor = true;
            // 
            // btnCourses
            // 
            this.btnCourses.Location = new System.Drawing.Point(589, 310);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(126, 46);
            this.btnCourses.TabIndex = 4;
            this.btnCourses.Text = "Manage Courses";
            this.btnCourses.UseVisualStyleBackColor = true;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // btnDepts
            // 
            this.btnDepts.Location = new System.Drawing.Point(589, 51);
            this.btnDepts.Name = "btnDepts";
            this.btnDepts.Size = new System.Drawing.Size(99, 55);
            this.btnDepts.TabIndex = 5;
            this.btnDepts.Text = "Manage Departments";
            this.btnDepts.UseVisualStyleBackColor = true;
            // 
            // groupInfo
            // 
            this.groupInfo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupInfo.Controls.Add(this.label4);
            this.groupInfo.Controls.Add(this.lblDept);
            this.groupInfo.Controls.Add(this.label2);
            this.groupInfo.Controls.Add(this.lblStdID);
            this.groupInfo.Controls.Add(this.label1);
            this.groupInfo.Controls.Add(this.lblEmail);
            this.groupInfo.Controls.Add(this.label3);
            this.groupInfo.Controls.Add(this.lblAddress);
            this.groupInfo.Controls.Add(this.label5);
            this.groupInfo.Controls.Add(this.lblName);
            this.groupInfo.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold);
            this.groupInfo.ForeColor = System.Drawing.Color.DarkRed;
            this.groupInfo.Location = new System.Drawing.Point(12, 40);
            this.groupInfo.Name = "groupInfo";
            this.groupInfo.Size = new System.Drawing.Size(358, 362);
            this.groupInfo.TabIndex = 21;
            this.groupInfo.TabStop = false;
            this.groupInfo.Text = "Instructor Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(27, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 24);
            this.label4.TabIndex = 28;
            this.label4.Text = "Department:";
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDept.ForeColor = System.Drawing.Color.Black;
            this.lblDept.Location = new System.Drawing.Point(230, 296);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(55, 20);
            this.lblDept.TabIndex = 29;
            this.lblDept.Text = "[Dept]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(27, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "Instructor ID:";
            // 
            // lblStdID
            // 
            this.lblStdID.AutoSize = true;
            this.lblStdID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblStdID.ForeColor = System.Drawing.Color.Black;
            this.lblStdID.Location = new System.Drawing.Point(243, 75);
            this.lblStdID.Name = "lblStdID";
            this.lblStdID.Size = new System.Drawing.Size(36, 20);
            this.lblStdID.TabIndex = 27;
            this.lblStdID.Text = "[ID]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(27, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Email:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(230, 234);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(61, 20);
            this.lblEmail.TabIndex = 21;
            this.lblEmail.Text = "[Email]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(27, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "Address:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAddress.ForeColor = System.Drawing.Color.Black;
            this.lblAddress.Location = new System.Drawing.Point(211, 176);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(81, 20);
            this.lblAddress.TabIndex = 23;
            this.lblAddress.Text = "[Address]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(27, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "Name:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(228, 126);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 20);
            this.lblName.TabIndex = 25;
            this.lblName.Text = "[Name]";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(679, 406);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(82, 32);
            this.btnLogout.TabIndex = 22;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Admin_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.groupInfo);
            this.Controls.Add(this.btnDepts);
            this.Controls.Add(this.btnCourses);
            this.Controls.Add(this.btnExams);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnQuestions);
            this.Controls.Add(this.btnStudents);
            this.Name = "Admin_Dashboard";
            this.Text = "Admin Dashboard";
            this.groupInfo.ResumeLayout(false);
            this.groupInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnQuestions;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnExams;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Button btnDepts;
        private System.Windows.Forms.GroupBox groupInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStdID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnLogout;
    }
}