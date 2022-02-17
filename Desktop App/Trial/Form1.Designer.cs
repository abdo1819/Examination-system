
namespace Trial
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
            this.rdbtnA = new System.Windows.Forms.RadioButton();
            this.rdbtnB = new System.Windows.Forms.RadioButton();
            this.rdbtnC = new System.Windows.Forms.RadioButton();
            this.rdbtnD = new System.Windows.Forms.RadioButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.lblQuestionType = new System.Windows.Forms.Label();
            this.lblQuestionText = new System.Windows.Forms.RichTextBox();
            this.get_Questions_in_ExamTableAdapter1 = new Trial.ExaminationDataSetTableAdapters.Get_Questions_in_ExamTableAdapter();
            this.SuspendLayout();
            // 
            // rdbtnA
            // 
            this.rdbtnA.AutoSize = true;
            this.rdbtnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnA.Location = new System.Drawing.Point(53, 165);
            this.rdbtnA.Name = "rdbtnA";
            this.rdbtnA.Size = new System.Drawing.Size(34, 22);
            this.rdbtnA.TabIndex = 1;
            this.rdbtnA.TabStop = true;
            this.rdbtnA.Text = "a";
            this.rdbtnA.UseVisualStyleBackColor = true;
            // 
            // rdbtnB
            // 
            this.rdbtnB.AutoSize = true;
            this.rdbtnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnB.Location = new System.Drawing.Point(53, 194);
            this.rdbtnB.Name = "rdbtnB";
            this.rdbtnB.Size = new System.Drawing.Size(34, 22);
            this.rdbtnB.TabIndex = 2;
            this.rdbtnB.TabStop = true;
            this.rdbtnB.Text = "b";
            this.rdbtnB.UseVisualStyleBackColor = true;
            // 
            // rdbtnC
            // 
            this.rdbtnC.AutoSize = true;
            this.rdbtnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnC.Location = new System.Drawing.Point(53, 223);
            this.rdbtnC.Name = "rdbtnC";
            this.rdbtnC.Size = new System.Drawing.Size(34, 22);
            this.rdbtnC.TabIndex = 3;
            this.rdbtnC.TabStop = true;
            this.rdbtnC.Text = "c";
            this.rdbtnC.UseVisualStyleBackColor = true;
            // 
            // rdbtnD
            // 
            this.rdbtnD.AutoSize = true;
            this.rdbtnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnD.Location = new System.Drawing.Point(52, 252);
            this.rdbtnD.Name = "rdbtnD";
            this.rdbtnD.Size = new System.Drawing.Size(34, 22);
            this.rdbtnD.TabIndex = 4;
            this.rdbtnD.TabStop = true;
            this.rdbtnD.Text = "d";
            this.rdbtnD.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(405, 302);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(91, 32);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(230, 302);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(91, 32);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(53, 302);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(91, 32);
            this.btnPrevious.TabIndex = 7;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // lblQuestionType
            // 
            this.lblQuestionType.AutoSize = true;
            this.lblQuestionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionType.Location = new System.Drawing.Point(12, 26);
            this.lblQuestionType.Name = "lblQuestionType";
            this.lblQuestionType.Size = new System.Drawing.Size(109, 16);
            this.lblQuestionType.TabIndex = 8;
            this.lblQuestionType.Text = "Question Type";
            // 
            // lblQuestionText
            // 
            this.lblQuestionText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQuestionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblQuestionText.Location = new System.Drawing.Point(12, 61);
            this.lblQuestionText.Name = "lblQuestionText";
            this.lblQuestionText.ReadOnly = true;
            this.lblQuestionText.Size = new System.Drawing.Size(518, 77);
            this.lblQuestionText.TabIndex = 9;
            this.lblQuestionText.Text = "";
            // 
            // get_Questions_in_ExamTableAdapter1
            // 
            this.get_Questions_in_ExamTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 378);
            this.Controls.Add(this.lblQuestionText);
            this.Controls.Add(this.lblQuestionType);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.rdbtnD);
            this.Controls.Add(this.rdbtnC);
            this.Controls.Add(this.rdbtnB);
            this.Controls.Add(this.rdbtnA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private ExaminationDataSetTableAdapters.Get_Questions_in_ExamTableAdapter get_Questions_in_ExamTableAdapter1;
        private System.Windows.Forms.Label lblQuestionType;
        private System.Windows.Forms.RichTextBox lblQuestionText;
    }
}