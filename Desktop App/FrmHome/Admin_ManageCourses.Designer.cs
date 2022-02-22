
namespace FrmHome
{
    partial class Admin_ManageCourses
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.btnBack = new System.Windows.Forms.Button();
            this.comboCourses = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTName = new System.Windows.Forms.Label();
            this.lblMCQs = new System.Windows.Forms.Label();
            this.lblTFQs = new System.Windows.Forms.Label();
            this.dataGridQuestions = new System.Windows.Forms.DataGridView();
            this.btnViewQuestions = new System.Windows.Forms.Button();
            this.comboTopics = new System.Windows.Forms.ComboBox();
            this.btnViewTFQ = new System.Windows.Forms.Button();
            this.groupInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1435, 915);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 59);
            this.button2.TabIndex = 1;
            this.button2.Text = "Assign Student to Selected Course";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1754, 915);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 54);
            this.button3.TabIndex = 2;
            this.button3.Text = "Add New Course";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupInfo
            // 
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
            this.groupInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupInfo.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold);
            this.groupInfo.ForeColor = System.Drawing.Color.DarkRed;
            this.groupInfo.Location = new System.Drawing.Point(0, 0);
            this.groupInfo.Name = "groupInfo";
            this.groupInfo.Size = new System.Drawing.Size(399, 1033);
            this.groupInfo.TabIndex = 22;
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
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(459, 925);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(110, 49);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "Go Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // comboCourses
            // 
            this.comboCourses.FormattingEnabled = true;
            this.comboCourses.Location = new System.Drawing.Point(1004, 65);
            this.comboCourses.Name = "comboCourses";
            this.comboCourses.Size = new System.Drawing.Size(354, 24);
            this.comboCourses.TabIndex = 24;
            this.comboCourses.SelectedIndexChanged += new System.EventHandler(this.comboCourses_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(697, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Select a Course to View topics:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(845, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Topics:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1611, 915);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 54);
            this.button4.TabIndex = 27;
            this.button4.Text = "Add New Topic";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(999, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "Topic Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1157, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 17);
            this.label10.TabIndex = 30;
            this.label10.Text = "MCQs";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1277, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 17);
            this.label11.TabIndex = 31;
            this.label11.Text = "TFQs";
            // 
            // lblTName
            // 
            this.lblTName.AutoSize = true;
            this.lblTName.Location = new System.Drawing.Point(1021, 211);
            this.lblTName.Name = "lblTName";
            this.lblTName.Size = new System.Drawing.Size(78, 17);
            this.lblTName.TabIndex = 33;
            this.lblTName.Text = "[TopName]";
            // 
            // lblMCQs
            // 
            this.lblMCQs.AutoSize = true;
            this.lblMCQs.Location = new System.Drawing.Point(1157, 211);
            this.lblMCQs.Name = "lblMCQs";
            this.lblMCQs.Size = new System.Drawing.Size(77, 17);
            this.lblMCQs.TabIndex = 34;
            this.lblMCQs.Text = "[NoofMCQ]";
            // 
            // lblTFQs
            // 
            this.lblTFQs.AutoSize = true;
            this.lblTFQs.Location = new System.Drawing.Point(1274, 211);
            this.lblTFQs.Name = "lblTFQs";
            this.lblTFQs.Size = new System.Drawing.Size(63, 17);
            this.lblTFQs.TabIndex = 35;
            this.lblTFQs.Text = "[NoofTF]";
            // 
            // dataGridQuestions
            // 
            this.dataGridQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridQuestions.Location = new System.Drawing.Point(638, 317);
            this.dataGridQuestions.Name = "dataGridQuestions";
            this.dataGridQuestions.RowHeadersWidth = 51;
            this.dataGridQuestions.RowTemplate.Height = 24;
            this.dataGridQuestions.Size = new System.Drawing.Size(905, 568);
            this.dataGridQuestions.TabIndex = 36;
            // 
            // btnViewQuestions
            // 
            this.btnViewQuestions.Location = new System.Drawing.Point(1423, 153);
            this.btnViewQuestions.Name = "btnViewQuestions";
            this.btnViewQuestions.Size = new System.Drawing.Size(129, 49);
            this.btnViewQuestions.TabIndex = 37;
            this.btnViewQuestions.Text = "View MCQs for Topic";
            this.btnViewQuestions.UseVisualStyleBackColor = true;
            this.btnViewQuestions.Click += new System.EventHandler(this.btnViewQuestions_Click);
            // 
            // comboTopics
            // 
            this.comboTopics.FormattingEnabled = true;
            this.comboTopics.Location = new System.Drawing.Point(1004, 119);
            this.comboTopics.Name = "comboTopics";
            this.comboTopics.Size = new System.Drawing.Size(354, 24);
            this.comboTopics.TabIndex = 38;
            this.comboTopics.SelectedIndexChanged += new System.EventHandler(this.comboTopics_SelectedIndexChanged);
            // 
            // btnViewTFQ
            // 
            this.btnViewTFQ.Location = new System.Drawing.Point(1423, 226);
            this.btnViewTFQ.Name = "btnViewTFQ";
            this.btnViewTFQ.Size = new System.Drawing.Size(129, 49);
            this.btnViewTFQ.TabIndex = 39;
            this.btnViewTFQ.Text = "View TFQs for Topic";
            this.btnViewTFQ.UseVisualStyleBackColor = true;
            this.btnViewTFQ.Click += new System.EventHandler(this.btnViewTFQ_Click);
            // 
            // Admin_ManageCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.btnViewTFQ);
            this.Controls.Add(this.comboTopics);
            this.Controls.Add(this.btnViewQuestions);
            this.Controls.Add(this.dataGridQuestions);
            this.Controls.Add(this.lblTFQs);
            this.Controls.Add(this.lblMCQs);
            this.Controls.Add(this.lblTName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboCourses);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupInfo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Name = "Admin_ManageCourses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Courses";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupInfo.ResumeLayout(false);
            this.groupInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQuestions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
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
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox comboCourses;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTName;
        private System.Windows.Forms.Label lblMCQs;
        private System.Windows.Forms.Label lblTFQs;
        private System.Windows.Forms.DataGridView dataGridQuestions;
        private System.Windows.Forms.Button btnViewQuestions;
        private System.Windows.Forms.ComboBox comboTopics;
        private System.Windows.Forms.Button btnViewTFQ;
    }
}