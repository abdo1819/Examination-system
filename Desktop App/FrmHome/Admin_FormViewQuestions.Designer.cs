
namespace FrmHome
{
    partial class Admin_FormViewQuestions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_FormViewQuestions));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridQuestions = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTID = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblMCQs = new System.Windows.Forms.Label();
            this.btnViewTFQ = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTFQs = new System.Windows.Forms.Label();
            this.comboCourses = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnViewMCQ = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboTopics = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQuestions)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(21, 430);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Go Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridQuestions
            // 
            this.dataGridQuestions.AllowUserToAddRows = false;
            this.dataGridQuestions.AllowUserToDeleteRows = false;
            this.dataGridQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridQuestions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridQuestions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridQuestions.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridQuestions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridQuestions.ColumnHeadersHeight = 29;
            this.dataGridQuestions.Location = new System.Drawing.Point(21, 172);
            this.dataGridQuestions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridQuestions.Name = "dataGridQuestions";
            this.dataGridQuestions.RowHeadersWidth = 51;
            this.dataGridQuestions.RowTemplate.Height = 24;
            this.dataGridQuestions.Size = new System.Drawing.Size(670, 233);
            this.dataGridQuestions.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(15, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 18);
            this.label6.TabIndex = 25;
            this.label6.Text = "Select a Course to View topics:";
            // 
            // lblTID
            // 
            this.lblTID.AutoSize = true;
            this.lblTID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblTID.Location = new System.Drawing.Point(231, 137);
            this.lblTID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTID.Name = "lblTID";
            this.lblTID.Size = new System.Drawing.Size(59, 18);
            this.lblTID.TabIndex = 33;
            this.lblTID.Text = "[TopID]";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(491, 104);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 18);
            this.label11.TabIndex = 31;
            this.label11.Text = "TFQs";
            // 
            // lblMCQs
            // 
            this.lblMCQs.AutoSize = true;
            this.lblMCQs.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblMCQs.Location = new System.Drawing.Point(349, 137);
            this.lblMCQs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMCQs.Name = "lblMCQs";
            this.lblMCQs.Size = new System.Drawing.Size(92, 18);
            this.lblMCQs.TabIndex = 34;
            this.lblMCQs.Text = "[NoofMCQ]";
            // 
            // btnViewTFQ
            // 
            this.btnViewTFQ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewTFQ.BackColor = System.Drawing.Color.DarkRed;
            this.btnViewTFQ.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnViewTFQ.ForeColor = System.Drawing.Color.White;
            this.btnViewTFQ.Location = new System.Drawing.Point(574, 90);
            this.btnViewTFQ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewTFQ.Name = "btnViewTFQ";
            this.btnViewTFQ.Size = new System.Drawing.Size(117, 65);
            this.btnViewTFQ.TabIndex = 39;
            this.btnViewTFQ.Text = "View TFQs for Topic";
            this.btnViewTFQ.UseVisualStyleBackColor = false;
            this.btnViewTFQ.Click += new System.EventHandler(this.btnViewTFQ_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(349, 104);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 18);
            this.label10.TabIndex = 30;
            this.label10.Text = "MCQs";
            // 
            // lblTFQs
            // 
            this.lblTFQs.AutoSize = true;
            this.lblTFQs.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblTFQs.Location = new System.Drawing.Point(488, 137);
            this.lblTFQs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTFQs.Name = "lblTFQs";
            this.lblTFQs.Size = new System.Drawing.Size(66, 18);
            this.lblTFQs.TabIndex = 35;
            this.lblTFQs.Text = "[NoofTF]";
            // 
            // comboCourses
            // 
            this.comboCourses.FormattingEnabled = true;
            this.comboCourses.Location = new System.Drawing.Point(254, 15);
            this.comboCourses.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboCourses.Name = "comboCourses";
            this.comboCourses.Size = new System.Drawing.Size(266, 21);
            this.comboCourses.TabIndex = 24;
            this.comboCourses.SelectedIndexChanged += new System.EventHandler(this.comboCourses_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(223, 104);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 18);
            this.label8.TabIndex = 28;
            this.label8.Text = "Topic ID";
            // 
            // btnViewMCQ
            // 
            this.btnViewMCQ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewMCQ.BackColor = System.Drawing.Color.DarkRed;
            this.btnViewMCQ.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnViewMCQ.ForeColor = System.Drawing.Color.White;
            this.btnViewMCQ.Location = new System.Drawing.Point(574, 14);
            this.btnViewMCQ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewMCQ.Name = "btnViewMCQ";
            this.btnViewMCQ.Size = new System.Drawing.Size(117, 65);
            this.btnViewMCQ.TabIndex = 37;
            this.btnViewMCQ.Text = "View MCQs for Topic";
            this.btnViewMCQ.UseVisualStyleBackColor = false;
            this.btnViewMCQ.Click += new System.EventHandler(this.btnViewMCQ_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(119, 61);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 18);
            this.label7.TabIndex = 26;
            this.label7.Text = "Topics:";
            // 
            // comboTopics
            // 
            this.comboTopics.FormattingEnabled = true;
            this.comboTopics.Location = new System.Drawing.Point(254, 58);
            this.comboTopics.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboTopics.Name = "comboTopics";
            this.comboTopics.Size = new System.Drawing.Size(266, 21);
            this.comboTopics.TabIndex = 38;
            this.comboTopics.SelectedIndexChanged += new System.EventHandler(this.comboTopics_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.comboTopics);
            this.panel1.Controls.Add(this.lblTID);
            this.panel1.Controls.Add(this.comboCourses);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.dataGridQuestions);
            this.panel1.Controls.Add(this.lblMCQs);
            this.panel1.Controls.Add(this.btnViewMCQ);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnViewTFQ);
            this.panel1.Controls.Add(this.lblTFQs);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 497);
            this.panel1.TabIndex = 40;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Admin_FormViewQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(731, 521);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(500, 70);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Admin_FormViewQuestions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormViewQuestions";
            this.Load += new System.EventHandler(this.Admin_FormViewQuestions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQuestions)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridQuestions;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblMCQs;
        private System.Windows.Forms.Button btnViewTFQ;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTFQs;
        private System.Windows.Forms.ComboBox comboCourses;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnViewMCQ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboTopics;
        private System.Windows.Forms.Panel panel1;
    }
}