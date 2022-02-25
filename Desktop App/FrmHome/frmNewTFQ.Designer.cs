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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewTFQ));
            this.comboBoxTopic = new System.Windows.Forms.ComboBox();
            this.lblTopic = new System.Windows.Forms.Label();
            this.richTextBoxText = new System.Windows.Forms.RichTextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.textBoxAns = new System.Windows.Forms.TextBox();
            this.lblAns = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxTopic
            // 
            this.comboBoxTopic.FormattingEnabled = true;
            this.comboBoxTopic.Location = new System.Drawing.Point(332, 160);
            this.comboBoxTopic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxTopic.Name = "comboBoxTopic";
            this.comboBoxTopic.Size = new System.Drawing.Size(115, 21);
            this.comboBoxTopic.TabIndex = 31;
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopic.ForeColor = System.Drawing.Color.Black;
            this.lblTopic.Location = new System.Drawing.Point(284, 160);
            this.lblTopic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(48, 17);
            this.lblTopic.TabIndex = 30;
            this.lblTopic.Text = "Topic";
            // 
            // richTextBoxText
            // 
            this.richTextBoxText.Location = new System.Drawing.Point(30, 60);
            this.richTextBoxText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBoxText.Name = "richTextBoxText";
            this.richTextBoxText.Size = new System.Drawing.Size(563, 69);
            this.richTextBoxText.TabIndex = 29;
            this.richTextBoxText.Text = "";
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOk.BackColor = System.Drawing.Color.DarkRed;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(474, 301);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(119, 43);
            this.btnOk.TabIndex = 24;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(37, 301);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 43);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // textBoxAns
            // 
            this.textBoxAns.Location = new System.Drawing.Point(152, 160);
            this.textBoxAns.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAns.Name = "textBoxAns";
            this.textBoxAns.Size = new System.Drawing.Size(115, 20);
            this.textBoxAns.TabIndex = 20;
            // 
            // lblAns
            // 
            this.lblAns.AutoSize = true;
            this.lblAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAns.ForeColor = System.Drawing.Color.Black;
            this.lblAns.Location = new System.Drawing.Point(29, 160);
            this.lblAns.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAns.Name = "lblAns";
            this.lblAns.Size = new System.Drawing.Size(118, 17);
            this.lblAns.TabIndex = 17;
            this.lblAns.Text = "Correct Answer";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.ForeColor = System.Drawing.Color.Black;
            this.lblText.Location = new System.Drawing.Point(29, 34);
            this.lblText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(109, 17);
            this.lblText.TabIndex = 16;
            this.lblText.Text = "Question Text";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.comboBoxTopic);
            this.panel1.Controls.Add(this.lblText);
            this.panel1.Controls.Add(this.lblTopic);
            this.panel1.Controls.Add(this.lblAns);
            this.panel1.Controls.Add(this.richTextBoxText);
            this.panel1.Controls.Add(this.textBoxAns);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Location = new System.Drawing.Point(11, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 361);
            this.panel1.TabIndex = 32;
            // 
            // frmNewTFQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(639, 383);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(660, 200);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmNewTFQ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Add New True/False Question";
            this.Load += new System.EventHandler(this.frmNewTFQ_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel1;
    }
}