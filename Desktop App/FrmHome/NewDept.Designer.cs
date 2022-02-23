namespace FrmHome
{
    partial class frmNewDept
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewDept));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtDeptName = new System.Windows.Forms.TextBox();
            this.lblDeptName = new System.Windows.Forms.Label();
            this.lblMgrID = new System.Windows.Forms.Label();
            this.comboBoxMgrID = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(454, 228);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(145, 51);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOk.Location = new System.Drawing.Point(72, 228);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(145, 51);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtDeptName
            // 
            this.txtDeptName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDeptName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtDeptName.Location = new System.Drawing.Point(225, 71);
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.Size = new System.Drawing.Size(389, 22);
            this.txtDeptName.TabIndex = 2;
            // 
            // lblDeptName
            // 
            this.lblDeptName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDeptName.AutoSize = true;
            this.lblDeptName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblDeptName.Location = new System.Drawing.Point(33, 71);
            this.lblDeptName.Name = "lblDeptName";
            this.lblDeptName.Size = new System.Drawing.Size(161, 20);
            this.lblDeptName.TabIndex = 4;
            this.lblDeptName.Text = "Department Name";
            // 
            // lblMgrID
            // 
            this.lblMgrID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMgrID.AutoSize = true;
            this.lblMgrID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMgrID.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblMgrID.Location = new System.Drawing.Point(88, 139);
            this.lblMgrID.Name = "lblMgrID";
            this.lblMgrID.Size = new System.Drawing.Size(106, 20);
            this.lblMgrID.TabIndex = 5;
            this.lblMgrID.Text = "Manager ID";
            // 
            // comboBoxMgrID
            // 
            this.comboBoxMgrID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxMgrID.BackColor = System.Drawing.SystemColors.HighlightText;
            this.comboBoxMgrID.FormattingEnabled = true;
            this.comboBoxMgrID.Location = new System.Drawing.Point(225, 139);
            this.comboBoxMgrID.Name = "comboBoxMgrID";
            this.comboBoxMgrID.Size = new System.Drawing.Size(389, 24);
            this.comboBoxMgrID.TabIndex = 6;
            // 
            // frmNewDept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(668, 320);
            this.Controls.Add(this.comboBoxMgrID);
            this.Controls.Add(this.lblMgrID);
            this.Controls.Add(this.lblDeptName);
            this.Controls.Add(this.txtDeptName);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(957, 616);
            this.MinimumSize = new System.Drawing.Size(686, 367);
            this.Name = "frmNewDept";
            this.Text = "Add New Department";
            this.Load += new System.EventHandler(this.frmNewDept_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtDeptName;
        private System.Windows.Forms.Label lblDeptName;
        private System.Windows.Forms.Label lblMgrID;
        private System.Windows.Forms.ComboBox comboBoxMgrID;
    }
}