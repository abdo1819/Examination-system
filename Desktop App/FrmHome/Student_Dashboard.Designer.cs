
namespace FrmHome
{
    partial class Student_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Dashboard));
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.btnUpdateInfo = new System.Windows.Forms.Button();
            this.btnGrades = new System.Windows.Forms.Button();
            this.btnExam = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.Location = new System.Drawing.Point(24, 381);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(97, 36);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
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
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
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
            this.groupInfo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupInfo.Location = new System.Drawing.Point(442, 13);
            this.groupInfo.Name = "groupInfo";
            this.groupInfo.Size = new System.Drawing.Size(346, 425);
            this.groupInfo.TabIndex = 19;
            this.groupInfo.TabStop = false;
            this.groupInfo.Text = "Student Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 24);
            this.label4.TabIndex = 28;
            this.label4.Text = "Department:";
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDept.Location = new System.Drawing.Point(172, 300);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(53, 21);
            this.lblDept.TabIndex = 29;
            this.lblDept.Text = "[Dept]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "Student ID:";
            // 
            // lblStdID
            // 
            this.lblStdID.AutoSize = true;
            this.lblStdID.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStdID.Location = new System.Drawing.Point(185, 79);
            this.lblStdID.Name = "lblStdID";
            this.lblStdID.Size = new System.Drawing.Size(34, 21);
            this.lblStdID.TabIndex = 27;
            this.lblStdID.Text = "[ID]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Email:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(172, 238);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 21);
            this.lblEmail.TabIndex = 21;
            this.lblEmail.Text = "[Email]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "Address:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(153, 180);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(76, 21);
            this.lblAddress.TabIndex = 23;
            this.lblAddress.Text = "[Address]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "Name:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(170, 130);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 21);
            this.lblName.TabIndex = 25;
            this.lblName.Text = "[Name]";
            // 
            // btnUpdateInfo
            // 
            this.btnUpdateInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateInfo.Location = new System.Drawing.Point(227, 90);
            this.btnUpdateInfo.Name = "btnUpdateInfo";
            this.btnUpdateInfo.Size = new System.Drawing.Size(173, 36);
            this.btnUpdateInfo.TabIndex = 20;
            this.btnUpdateInfo.Text = "Update your info";
            this.btnUpdateInfo.UseVisualStyleBackColor = true;
            this.btnUpdateInfo.Click += new System.EventHandler(this.btnUpdateInfo_Click);
            // 
            // btnGrades
            // 
            this.btnGrades.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrades.Location = new System.Drawing.Point(227, 330);
            this.btnGrades.Name = "btnGrades";
            this.btnGrades.Size = new System.Drawing.Size(173, 36);
            this.btnGrades.TabIndex = 21;
            this.btnGrades.Text = "View your grades";
            this.btnGrades.UseVisualStyleBackColor = true;
            this.btnGrades.Click += new System.EventHandler(this.btnGrades_Click);
            // 
            // btnExam
            // 
            this.btnExam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExam.Location = new System.Drawing.Point(227, 210);
            this.btnExam.Name = "btnExam";
            this.btnExam.Size = new System.Drawing.Size(173, 36);
            this.btnExam.TabIndex = 22;
            this.btnExam.Text = "Take an Exam";
            this.btnExam.UseVisualStyleBackColor = true;
            this.btnExam.Click += new System.EventHandler(this.btnExam_Click);
            // 
            // Student_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExam);
            this.Controls.Add(this.btnGrades);
            this.Controls.Add(this.btnUpdateInfo);
            this.Controls.Add(this.groupInfo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Student_Dashboard";
            this.Text = "Student Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupInfo.ResumeLayout(false);
            this.groupInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStdID;
        private System.Windows.Forms.Button btnUpdateInfo;
        private System.Windows.Forms.Button btnGrades;
        private System.Windows.Forms.Button btnExam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDept;
    }
}