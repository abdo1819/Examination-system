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
            this.btnCancel.Location = new System.Drawing.Point(330, 228);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(145, 51);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
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
            this.txtDeptName.Location = new System.Drawing.Point(208, 71);
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.Size = new System.Drawing.Size(267, 22);
            this.txtDeptName.TabIndex = 2;
            // 
            // lblDeptName
            // 
            this.lblDeptName.AutoSize = true;
            this.lblDeptName.Location = new System.Drawing.Point(69, 71);
            this.lblDeptName.Name = "lblDeptName";
            this.lblDeptName.Size = new System.Drawing.Size(117, 16);
            this.lblDeptName.TabIndex = 4;
            this.lblDeptName.Text = "Department Name";
            // 
            // lblMgrID
            // 
            this.lblMgrID.AutoSize = true;
            this.lblMgrID.Location = new System.Drawing.Point(69, 139);
            this.lblMgrID.Name = "lblMgrID";
            this.lblMgrID.Size = new System.Drawing.Size(77, 16);
            this.lblMgrID.TabIndex = 5;
            this.lblMgrID.Text = "Manager ID";
            // 
            // comboBoxMgrID
            // 
            this.comboBoxMgrID.FormattingEnabled = true;
            this.comboBoxMgrID.Location = new System.Drawing.Point(208, 139);
            this.comboBoxMgrID.Name = "comboBoxMgrID";
            this.comboBoxMgrID.Size = new System.Drawing.Size(267, 24);
            this.comboBoxMgrID.TabIndex = 6;
            // 
            // frmNewDept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 312);
            this.Controls.Add(this.comboBoxMgrID);
            this.Controls.Add(this.lblMgrID);
            this.Controls.Add(this.lblDeptName);
            this.Controls.Add(this.txtDeptName);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Name = "frmNewDept";
            this.Text = "NewDept";
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