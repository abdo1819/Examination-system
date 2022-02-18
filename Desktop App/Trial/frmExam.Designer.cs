
namespace Trial
{
    partial class frmExam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExam));
            this.rdbtnA = new System.Windows.Forms.RadioButton();
            this.rdbtnB = new System.Windows.Forms.RadioButton();
            this.rdbtnC = new System.Windows.Forms.RadioButton();
            this.rdbtnD = new System.Windows.Forms.RadioButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.lblQuestionType = new System.Windows.Forms.Label();
            this.lblQuestionText = new System.Windows.Forms.RichTextBox();
            this.lblStdAns = new System.Windows.Forms.Label();
            this.lblQID = new System.Windows.Forms.Label();
            this.exam_AnswerTableAdapter1 = new Trial.ExaminationDataSetTableAdapters.Exam_AnswerTableAdapter();
            this.get_Questions_in_ExamTableAdapter1 = new Trial.ExaminationDataSetTableAdapters.Get_Questions_in_ExamTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label111 = new System.Windows.Forms.Label();
            this.lblQNum = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbtnA
            // 
            this.rdbtnA.AutoSize = true;
            this.rdbtnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnA.Location = new System.Drawing.Point(17, 42);
            this.rdbtnA.Name = "rdbtnA";
            this.rdbtnA.Size = new System.Drawing.Size(34, 22);
            this.rdbtnA.TabIndex = 1;
            this.rdbtnA.Tag = "a";
            this.rdbtnA.Text = "a";
            this.rdbtnA.UseVisualStyleBackColor = true;
            this.rdbtnA.CheckedChanged += new System.EventHandler(this.rdbtnA_CheckedChanged);
            // 
            // rdbtnB
            // 
            this.rdbtnB.AutoSize = true;
            this.rdbtnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnB.Location = new System.Drawing.Point(17, 71);
            this.rdbtnB.Name = "rdbtnB";
            this.rdbtnB.Size = new System.Drawing.Size(34, 22);
            this.rdbtnB.TabIndex = 2;
            this.rdbtnB.Tag = "b";
            this.rdbtnB.Text = "b";
            this.rdbtnB.UseVisualStyleBackColor = true;
            // 
            // rdbtnC
            // 
            this.rdbtnC.AutoSize = true;
            this.rdbtnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnC.Location = new System.Drawing.Point(17, 100);
            this.rdbtnC.Name = "rdbtnC";
            this.rdbtnC.Size = new System.Drawing.Size(34, 22);
            this.rdbtnC.TabIndex = 3;
            this.rdbtnC.Tag = "c";
            this.rdbtnC.Text = "c";
            this.rdbtnC.UseVisualStyleBackColor = true;
            // 
            // rdbtnD
            // 
            this.rdbtnD.AutoSize = true;
            this.rdbtnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnD.Location = new System.Drawing.Point(16, 129);
            this.rdbtnD.Name = "rdbtnD";
            this.rdbtnD.Size = new System.Drawing.Size(34, 22);
            this.rdbtnD.TabIndex = 4;
            this.rdbtnD.Tag = "d";
            this.rdbtnD.Text = "d";
            this.rdbtnD.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Location = new System.Drawing.Point(922, 432);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(191, 32);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSubmit.Location = new System.Drawing.Point(468, 432);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(191, 32);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrevious.Location = new System.Drawing.Point(15, 432);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(191, 32);
            this.btnPrevious.TabIndex = 7;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // lblQuestionType
            // 
            this.lblQuestionType.AutoSize = true;
            this.lblQuestionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionType.Location = new System.Drawing.Point(12, 89);
            this.lblQuestionType.Name = "lblQuestionType";
            this.lblQuestionType.Size = new System.Drawing.Size(109, 16);
            this.lblQuestionType.TabIndex = 8;
            this.lblQuestionType.Text = "Question Type";
            // 
            // lblQuestionText
            // 
            this.lblQuestionText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuestionText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQuestionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblQuestionText.Location = new System.Drawing.Point(15, 108);
            this.lblQuestionText.Name = "lblQuestionText";
            this.lblQuestionText.ReadOnly = true;
            this.lblQuestionText.Size = new System.Drawing.Size(1098, 131);
            this.lblQuestionText.TabIndex = 9;
            this.lblQuestionText.Text = "";
            // 
            // lblStdAns
            // 
            this.lblStdAns.AutoSize = true;
            this.lblStdAns.ForeColor = System.Drawing.SystemColors.Control;
            this.lblStdAns.Location = new System.Drawing.Point(171, 27);
            this.lblStdAns.Name = "lblStdAns";
            this.lblStdAns.Size = new System.Drawing.Size(35, 13);
            this.lblStdAns.TabIndex = 10;
            this.lblStdAns.Text = "label1";
            // 
            // lblQID
            // 
            this.lblQID.AutoSize = true;
            this.lblQID.ForeColor = System.Drawing.SystemColors.Control;
            this.lblQID.Location = new System.Drawing.Point(126, 27);
            this.lblQID.Name = "lblQID";
            this.lblQID.Size = new System.Drawing.Size(35, 13);
            this.lblQID.TabIndex = 11;
            this.lblQID.Text = "label1";
            // 
            // exam_AnswerTableAdapter1
            // 
            this.exam_AnswerTableAdapter1.ClearBeforeFill = true;
            // 
            // get_Questions_in_ExamTableAdapter1
            // 
            this.get_Questions_in_ExamTableAdapter1.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rdbtnB);
            this.groupBox1.Controls.Add(this.rdbtnA);
            this.groupBox1.Controls.Add(this.rdbtnC);
            this.groupBox1.Controls.Add(this.rdbtnD);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1098, 164);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose the correct answer: ";
            // 
            // label111
            // 
            this.label111.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label111.AutoSize = true;
            this.label111.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label111.Location = new System.Drawing.Point(1059, 89);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(33, 16);
            this.label111.TabIndex = 13;
            this.label111.Text = "10 /";
            // 
            // lblQNum
            // 
            this.lblQNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQNum.AutoSize = true;
            this.lblQNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQNum.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblQNum.Location = new System.Drawing.Point(1089, 89);
            this.lblQNum.Name = "lblQNum";
            this.lblQNum.Size = new System.Drawing.Size(24, 16);
            this.lblQNum.TabIndex = 14;
            this.lblQNum.Text = "10";
            this.lblQNum.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // frmExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 476);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblQNum);
            this.Controls.Add(this.label111);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblQID);
            this.Controls.Add(this.lblStdAns);
            this.Controls.Add(this.lblQuestionText);
            this.Controls.Add(this.lblQuestionType);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnNext);
            this.Name = "frmExam";
            this.Text = "Exam Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rdbtnA;
        private System.Windows.Forms.RadioButton rdbtnB;
        private System.Windows.Forms.RadioButton rdbtnC;
        private System.Windows.Forms.RadioButton rdbtnD;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnPrevious;

        private System.Windows.Forms.Label lblQuestionType;
        private System.Windows.Forms.RichTextBox lblQuestionText;
        private ExaminationDataSetTableAdapters.Exam_AnswerTableAdapter exam_AnswerTableAdapter1;
        private System.Windows.Forms.Label lblStdAns;
        private System.Windows.Forms.Label lblQID;
        private ExaminationDataSetTableAdapters.Get_Questions_in_ExamTableAdapter get_Questions_in_ExamTableAdapter1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.Label lblQNum;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}