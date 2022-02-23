namespace FrmHome
{
    partial class frmNewMCQ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewMCQ));
            this.lblText = new System.Windows.Forms.Label();
            this.lblAns = new System.Windows.Forms.Label();
            this.lblchA = new System.Windows.Forms.Label();
            this.lblchC = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxAns = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.textBoxD = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.lblchD = new System.Windows.Forms.Label();
            this.lblchB = new System.Windows.Forms.Label();
            this.richTextBoxText = new System.Windows.Forms.RichTextBox();
            this.lblTopic = new System.Windows.Forms.Label();
            this.comboBoxTopic = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblText.Location = new System.Drawing.Point(30, 58);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(126, 20);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Question Text";
            // 
            // lblAns
            // 
            this.lblAns.AutoSize = true;
            this.lblAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAns.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAns.Location = new System.Drawing.Point(22, 318);
            this.lblAns.Name = "lblAns";
            this.lblAns.Size = new System.Drawing.Size(140, 20);
            this.lblAns.TabIndex = 1;
            this.lblAns.Text = "Correct Answer";
            // 
            // lblchA
            // 
            this.lblchA.AutoSize = true;
            this.lblchA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblchA.Location = new System.Drawing.Point(60, 133);
            this.lblchA.Name = "lblchA";
            this.lblchA.Size = new System.Drawing.Size(85, 20);
            this.lblchA.TabIndex = 2;
            this.lblchA.Text = "Choice A";
            // 
            // lblchC
            // 
            this.lblchC.AutoSize = true;
            this.lblchC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblchC.Location = new System.Drawing.Point(60, 229);
            this.lblchC.Name = "lblchC";
            this.lblchC.Size = new System.Drawing.Size(86, 20);
            this.lblchC.TabIndex = 3;
            this.lblchC.Text = "Choice C";
            // 
            // textBoxA
            // 
            this.textBoxA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxA.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxA.Location = new System.Drawing.Point(176, 130);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(590, 24);
            this.textBoxA.TabIndex = 5;
            // 
            // textBoxAns
            // 
            this.textBoxAns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAns.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAns.Location = new System.Drawing.Point(174, 315);
            this.textBoxAns.Name = "textBoxAns";
            this.textBoxAns.Size = new System.Drawing.Size(592, 24);
            this.textBoxAns.TabIndex = 5;
            // 
            // textBoxC
            // 
            this.textBoxC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxC.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxC.Location = new System.Drawing.Point(176, 223);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(590, 24);
            this.textBoxC.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(602, 459);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(164, 53);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOk.BackColor = System.Drawing.Color.Transparent;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(176, 459);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(159, 53);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // textBoxD
            // 
            this.textBoxD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxD.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxD.Location = new System.Drawing.Point(176, 274);
            this.textBoxD.Name = "textBoxD";
            this.textBoxD.Size = new System.Drawing.Size(590, 24);
            this.textBoxD.TabIndex = 12;
            // 
            // textBoxB
            // 
            this.textBoxB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxB.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxB.Location = new System.Drawing.Point(176, 175);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(590, 24);
            this.textBoxB.TabIndex = 11;
            // 
            // lblchD
            // 
            this.lblchD.AutoSize = true;
            this.lblchD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblchD.Location = new System.Drawing.Point(60, 277);
            this.lblchD.Name = "lblchD";
            this.lblchD.Size = new System.Drawing.Size(87, 20);
            this.lblchD.TabIndex = 10;
            this.lblchD.Text = "Choice D";
            // 
            // lblchB
            // 
            this.lblchB.AutoSize = true;
            this.lblchB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblchB.Location = new System.Drawing.Point(60, 178);
            this.lblchB.Name = "lblchB";
            this.lblchB.Size = new System.Drawing.Size(86, 20);
            this.lblchB.TabIndex = 9;
            this.lblchB.Text = "Choice B";
            // 
            // richTextBoxText
            // 
            this.richTextBoxText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxText.BackColor = System.Drawing.SystemColors.HighlightText;
            this.richTextBoxText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxText.Location = new System.Drawing.Point(174, 28);
            this.richTextBoxText.Name = "richTextBoxText";
            this.richTextBoxText.Size = new System.Drawing.Size(592, 84);
            this.richTextBoxText.TabIndex = 13;
            this.richTextBoxText.Text = "";
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopic.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTopic.Location = new System.Drawing.Point(77, 364);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(55, 20);
            this.lblTopic.TabIndex = 14;
            this.lblTopic.Text = "Topic";
            // 
            // comboBoxTopic
            // 
            this.comboBoxTopic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxTopic.BackColor = System.Drawing.SystemColors.HighlightText;
            this.comboBoxTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTopic.ForeColor = System.Drawing.SystemColors.MenuText;
            this.comboBoxTopic.FormattingEnabled = true;
            this.comboBoxTopic.Location = new System.Drawing.Point(176, 361);
            this.comboBoxTopic.Name = "comboBoxTopic";
            this.comboBoxTopic.Size = new System.Drawing.Size(590, 26);
            this.comboBoxTopic.TabIndex = 15;
            // 
            // frmNewMCQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(842, 548);
            this.Controls.Add(this.comboBoxTopic);
            this.Controls.Add(this.lblTopic);
            this.Controls.Add(this.richTextBoxText);
            this.Controls.Add(this.textBoxD);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.lblchD);
            this.Controls.Add(this.lblchB);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.textBoxAns);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.lblchC);
            this.Controls.Add(this.lblchA);
            this.Controls.Add(this.lblAns);
            this.Controls.Add(this.lblText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1063, 721);
            this.MinimumSize = new System.Drawing.Size(860, 595);
            this.Name = "frmNewMCQ";
            this.Text = "Add New Multiple Choice Question";
            this.Load += new System.EventHandler(this.frmNewMCQ_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblAns;
        private System.Windows.Forms.Label lblchA;
        private System.Windows.Forms.Label lblchC;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxAns;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox textBoxD;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label lblchD;
        private System.Windows.Forms.Label lblchB;
        private System.Windows.Forms.RichTextBox richTextBoxText;
        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.ComboBox comboBoxTopic;
    }
}