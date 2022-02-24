
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Dashboard));
            this.btnQuestions = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnCourses = new System.Windows.Forms.Button();
            this.btnDepts = new System.Windows.Forms.Button();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblStdID = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDept = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.groupActions = new System.Windows.Forms.GroupBox();
            this.panelInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQuestions
            // 
            this.btnQuestions.BackColor = System.Drawing.Color.DarkRed;
            this.btnQuestions.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnQuestions.ForeColor = System.Drawing.Color.White;
            this.btnQuestions.Location = new System.Drawing.Point(345, 79);
            this.btnQuestions.Name = "btnQuestions";
            this.btnQuestions.Size = new System.Drawing.Size(256, 100);
            this.btnQuestions.TabIndex = 1;
            this.btnQuestions.Text = "Manage Questions";
            this.btnQuestions.UseVisualStyleBackColor = false;
            this.btnQuestions.Click += new System.EventHandler(this.btnQuestions_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.DarkRed;
            this.btnReport.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Location = new System.Drawing.Point(345, 610);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(256, 100);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "Reports Dashboard";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnCourses
            // 
            this.btnCourses.BackColor = System.Drawing.Color.DarkRed;
            this.btnCourses.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCourses.ForeColor = System.Drawing.Color.White;
            this.btnCourses.Location = new System.Drawing.Point(345, 433);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(256, 100);
            this.btnCourses.TabIndex = 4;
            this.btnCourses.Text = "Manage Courses";
            this.btnCourses.UseVisualStyleBackColor = false;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // btnDepts
            // 
            this.btnDepts.BackColor = System.Drawing.Color.DarkRed;
            this.btnDepts.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnDepts.ForeColor = System.Drawing.Color.White;
            this.btnDepts.Location = new System.Drawing.Point(345, 256);
            this.btnDepts.Name = "btnDepts";
            this.btnDepts.Size = new System.Drawing.Size(256, 100);
            this.btnDepts.TabIndex = 5;
            this.btnDepts.Text = "Manage Departments";
            this.btnDepts.UseVisualStyleBackColor = false;
            this.btnDepts.Click += new System.EventHandler(this.btnDepts_Click);
            // 
            // panelInfo
            // 
            this.panelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelInfo.BackColor = System.Drawing.Color.DarkRed;
            this.panelInfo.Controls.Add(this.groupBox1);
            this.panelInfo.Controls.Add(this.pictureBox2);
            this.panelInfo.Controls.Add(this.pictureBox1);
            this.panelInfo.Controls.Add(this.label16);
            this.panelInfo.Controls.Add(this.btnLogout);
            this.panelInfo.Location = new System.Drawing.Point(0, 0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(607, 1080);
            this.panelInfo.TabIndex = 43;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblStdID);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblDept);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(16, 462);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 384);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Instructor Info";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(36, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 28);
            this.label6.TabIndex = 24;
            this.label6.Text = "Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(36, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 28);
            this.label7.TabIndex = 20;
            this.label7.Text = "Email:";
            // 
            // lblStdID
            // 
            this.lblStdID.AutoSize = true;
            this.lblStdID.BackColor = System.Drawing.Color.Transparent;
            this.lblStdID.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold);
            this.lblStdID.ForeColor = System.Drawing.Color.White;
            this.lblStdID.Location = new System.Drawing.Point(205, 84);
            this.lblStdID.Name = "lblStdID";
            this.lblStdID.Size = new System.Drawing.Size(55, 28);
            this.lblStdID.TabIndex = 27;
            this.lblStdID.Text = "[ID]";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(205, 243);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(93, 28);
            this.lblEmail.TabIndex = 21;
            this.lblEmail.Text = "[Email]";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(36, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 28);
            this.label10.TabIndex = 26;
            this.label10.Text = "Instructor ID:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(36, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 28);
            this.label11.TabIndex = 22;
            this.label11.Text = "Address:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(36, 303);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 28);
            this.label12.TabIndex = 28;
            this.label12.Text = "Department:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold);
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(205, 185);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(120, 28);
            this.lblAddress.TabIndex = 23;
            this.lblAddress.Text = "[Address]";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(205, 135);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(93, 28);
            this.lblName.TabIndex = 25;
            this.lblName.Text = "[Name]";
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.BackColor = System.Drawing.Color.Transparent;
            this.lblDept.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold);
            this.lblDept.ForeColor = System.Drawing.Color.White;
            this.lblDept.Location = new System.Drawing.Point(205, 305);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(83, 28);
            this.lblDept.TabIndex = 29;
            this.lblDept.Text = "[Dept]";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(165, 174);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(249, 220);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(124, 64);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(428, 32);
            this.label16.TabIndex = 30;
            this.label16.Text = "Information Technology Institute";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.DarkRed;
            this.btnLogout.Location = new System.Drawing.Point(165, 902);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(249, 60);
            this.btnLogout.TabIndex = 23;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // groupActions
            // 
            this.groupActions.Controls.Add(this.btnReport);
            this.groupActions.Controls.Add(this.btnCourses);
            this.groupActions.Controls.Add(this.btnDepts);
            this.groupActions.Controls.Add(this.btnQuestions);
            this.groupActions.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.groupActions.ForeColor = System.Drawing.Color.DarkRed;
            this.groupActions.Location = new System.Drawing.Point(807, 215);
            this.groupActions.Name = "groupActions";
            this.groupActions.Size = new System.Drawing.Size(933, 770);
            this.groupActions.TabIndex = 44;
            this.groupActions.TabStop = false;
            this.groupActions.Text = "Admin Dashboard";
            // 
            // Admin_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.ControlBox = false;
            this.Controls.Add(this.groupActions);
            this.Controls.Add(this.panelInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnQuestions;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Button btnDepts;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblStdID;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.GroupBox groupActions;
    }
}