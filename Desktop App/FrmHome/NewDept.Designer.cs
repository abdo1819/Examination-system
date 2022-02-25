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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(16, 333);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 41);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.BackColor = System.Drawing.Color.DarkRed;
            this.btnOk.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(414, 333);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(109, 41);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtDeptName
            // 
            this.txtDeptName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDeptName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtDeptName.Location = new System.Drawing.Point(174, 139);
            this.txtDeptName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.Size = new System.Drawing.Size(337, 20);
            this.txtDeptName.TabIndex = 2;
            // 
            // lblDeptName
            // 
            this.lblDeptName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDeptName.AutoSize = true;
            this.lblDeptName.BackColor = System.Drawing.Color.Transparent;
            this.lblDeptName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptName.ForeColor = System.Drawing.Color.Black;
            this.lblDeptName.Location = new System.Drawing.Point(40, 139);
            this.lblDeptName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeptName.Name = "lblDeptName";
            this.lblDeptName.Size = new System.Drawing.Size(138, 17);
            this.lblDeptName.TabIndex = 4;
            this.lblDeptName.Text = "Department Name";
            // 
            // lblMgrID
            // 
            this.lblMgrID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMgrID.AutoSize = true;
            this.lblMgrID.BackColor = System.Drawing.Color.Transparent;
            this.lblMgrID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMgrID.ForeColor = System.Drawing.Color.Black;
            this.lblMgrID.Location = new System.Drawing.Point(40, 194);
            this.lblMgrID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMgrID.Name = "lblMgrID";
            this.lblMgrID.Size = new System.Drawing.Size(117, 17);
            this.lblMgrID.TabIndex = 5;
            this.lblMgrID.Text = "Manager Name";
            // 
            // comboBoxMgrID
            // 
            this.comboBoxMgrID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxMgrID.BackColor = System.Drawing.SystemColors.HighlightText;
            this.comboBoxMgrID.FormattingEnabled = true;
            this.comboBoxMgrID.Location = new System.Drawing.Point(174, 194);
            this.comboBoxMgrID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxMgrID.Name = "comboBoxMgrID";
            this.comboBoxMgrID.Size = new System.Drawing.Size(337, 21);
            this.comboBoxMgrID.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.comboBoxMgrID);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Controls.Add(this.lblMgrID);
            this.panel1.Controls.Add(this.txtDeptName);
            this.panel1.Controls.Add(this.lblDeptName);
            this.panel1.Location = new System.Drawing.Point(11, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 386);
            this.panel1.TabIndex = 7;
            // 
            // frmNewDept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(555, 408);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(660, 200);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmNewDept";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Add New Department";
            this.Load += new System.EventHandler(this.frmNewDept_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtDeptName;
        private System.Windows.Forms.Label lblDeptName;
        private System.Windows.Forms.Label lblMgrID;
        private System.Windows.Forms.ComboBox comboBoxMgrID;
        private System.Windows.Forms.Panel panel1;
    }
}