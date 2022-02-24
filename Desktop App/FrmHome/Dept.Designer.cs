namespace FrmHome
{
    partial class frmDept
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDept));
            this.lblDept = new System.Windows.Forms.Label();
            this.txtDeptName = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnAddDept = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSrchDept = new System.Windows.Forms.TextBox();
            this.lblExists = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblDeptID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.BackColor = System.Drawing.Color.Transparent;
            this.lblDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDept.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDept.Location = new System.Drawing.Point(43, 30);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(161, 20);
            this.lblDept.TabIndex = 0;
            this.lblDept.Text = "Department Name";
            // 
            // txtDeptName
            // 
            this.txtDeptName.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDeptName.Location = new System.Drawing.Point(228, 34);
            this.txtDeptName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.Size = new System.Drawing.Size(277, 22);
            this.txtDeptName.TabIndex = 1;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(291, 81);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(107, 66);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(120, 81);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(107, 66);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnAddDept
            // 
            this.btnAddDept.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDept.Location = new System.Drawing.Point(691, 48);
            this.btnAddDept.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddDept.Name = "btnAddDept";
            this.btnAddDept.Size = new System.Drawing.Size(211, 66);
            this.btnAddDept.TabIndex = 5;
            this.btnAddDept.Text = "Add Department";
            this.btnAddDept.UseVisualStyleBackColor = true;
            this.btnAddDept.Click += new System.EventHandler(this.btnAddDept_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(120, 215);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(140, 66);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search Department";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSrchDept
            // 
            this.txtSrchDept.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSrchDept.BackColor = System.Drawing.SystemColors.Menu;
            this.txtSrchDept.Location = new System.Drawing.Point(120, 306);
            this.txtSrchDept.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSrchDept.Name = "txtSrchDept";
            this.txtSrchDept.Size = new System.Drawing.Size(140, 22);
            this.txtSrchDept.TabIndex = 8;
            // 
            // lblExists
            // 
            this.lblExists.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblExists.AutoSize = true;
            this.lblExists.BackColor = System.Drawing.Color.Transparent;
            this.lblExists.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblExists.Location = new System.Drawing.Point(117, 346);
            this.lblExists.Name = "lblExists";
            this.lblExists.Size = new System.Drawing.Size(77, 16);
            this.lblExists.TabIndex = 9;
            this.lblExists.Text = "Department";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(691, 346);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(211, 66);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update Department Name";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblDeptID
            // 
            this.lblDeptID.BackColor = System.Drawing.Color.Transparent;
            this.lblDeptID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptID.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblDeptID.Location = new System.Drawing.Point(525, 34);
            this.lblDeptID.Name = "lblDeptID";
            this.lblDeptID.Size = new System.Drawing.Size(45, 23);
            this.lblDeptID.TabIndex = 11;
            this.lblDeptID.Text = "ID";
            // 
            // frmDept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(961, 447);
            this.Controls.Add(this.lblDeptID);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblExists);
            this.Controls.Add(this.txtSrchDept);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAddDept);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtDeptName);
            this.Controls.Add(this.lblDept);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1267, 769);
            this.MinimumSize = new System.Drawing.Size(977, 484);
            this.Name = "frmDept";
            this.Text = "Department";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.TextBox txtDeptName;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnAddDept;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSrchDept;
        private System.Windows.Forms.Label lblExists;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblDeptID;
    }
}