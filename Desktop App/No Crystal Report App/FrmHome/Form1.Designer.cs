
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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(315, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 55);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

