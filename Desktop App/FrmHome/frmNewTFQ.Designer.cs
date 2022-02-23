namespace FrmHome
{
    partial class frmNewTFQ
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
            this.comboBoxTopic = new System.Windows.Forms.ComboBox();
            this.lblTopic = new System.Windows.Forms.Label();
            this.richTextBoxText = new System.Windows.Forms.RichTextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.textBoxAns = new System.Windows.Forms.TextBox();
            this.lblAns = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxTopic
            // 
            this.comboBoxTopic.FormattingEnabled = true;
            this.comboBoxTopic.Location = new System.Drawing.Point(125, 193);
            this.comboBoxTopic.Name = "comboBoxTopic";
            this.comboBoxTopic.Size = new System.Drawing.Size(592, 24);
            this.comboBoxTopic.TabIndex = 31;
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.Location = new System.Drawing.Point(73, 196);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(42, 16);
            this.lblTopic.TabIndex = 30;
            this.lblTopic.Text = "Topic";
            // 
            // richTextBoxText
            // 
            this.richTextBoxText.Location = new System.Drawing.Point(125, 32);
            this.richTextBoxText.Name = "richTextBoxText";
            this.richTextBoxText.Size = new System.Drawing.Size(592, 84);
            this.richTextBoxText.TabIndex = 29;
            this.richTextBoxText.Text = "";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(127, 258);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(159, 53);
            this.btnOk.TabIndex = 24;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(553, 258);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(164, 53);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // textBoxAns
            // 
            this.textBoxAns.Location = new System.Drawing.Point(125, 147);
            this.textBoxAns.Name = "textBoxAns";
            this.textBoxAns.Size = new System.Drawing.Size(592, 22);
            this.textBoxAns.TabIndex = 20;
            // 
            // lblAns
            // 
            this.lblAns.AutoSize = true;
            this.lblAns.Location = new System.Drawing.Point(18, 150);
            this.lblAns.Name = "lblAns";
            this.lblAns.Size = new System.Drawing.Size(97, 16);
            this.lblAns.TabIndex = 17;
            this.lblAns.Text = "Correct Answer";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(18, 63);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(89, 16);
            this.lblText.TabIndex = 16;
            this.lblText.Text = "Question Text";
            // 
            // frmNewTFQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 344);
            this.Controls.Add(this.comboBoxTopic);
            this.Controls.Add(this.lblTopic);
            this.Controls.Add(this.richTextBoxText);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.textBoxAns);
            this.Controls.Add(this.lblAns);
            this.Controls.Add(this.lblText);
            this.Name = "frmNewTFQ";
            this.Text = "New Question";
            this.Load += new System.EventHandler(this.frmNewTFQ_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTopic;
        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.RichTextBox richTextBoxText;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox textBoxAns;
        private System.Windows.Forms.Label lblAns;
        private System.Windows.Forms.Label lblText;
    }
}