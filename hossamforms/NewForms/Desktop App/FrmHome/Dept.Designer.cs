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
            this.lblDept = new System.Windows.Forms.Label();
            this.txtDeptName = new System.Windows.Forms.TextBox();
            this.btnViewDept = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnAddDept = new System.Windows.Forms.Button();
            this.btnDeleteDept = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSrchDept = new System.Windows.Forms.TextBox();
            this.lblExists = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Location = new System.Drawing.Point(138, 137);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(117, 16);
            this.lblDept.TabIndex = 0;
            this.lblDept.Text = "Department Name";
            // 
            // txtDeptName
            // 
            this.txtDeptName.Location = new System.Drawing.Point(330, 134);
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.Size = new System.Drawing.Size(277, 22);
            this.txtDeptName.TabIndex = 1;
            // 
            // btnViewDept
            // 
            this.btnViewDept.Location = new System.Drawing.Point(602, 412);
            this.btnViewDept.Name = "btnViewDept";
            this.btnViewDept.Size = new System.Drawing.Size(144, 66);
            this.btnViewDept.TabIndex = 2;
            this.btnViewDept.Text = "View Departments";
            this.btnViewDept.UseVisualStyleBackColor = true;
            this.btnViewDept.Click += new System.EventHandler(this.btnViewDept_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(467, 195);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(140, 66);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(297, 195);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(140, 66);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnAddDept
            // 
            this.btnAddDept.Location = new System.Drawing.Point(82, 412);
            this.btnAddDept.Name = "btnAddDept";
            this.btnAddDept.Size = new System.Drawing.Size(140, 66);
            this.btnAddDept.TabIndex = 5;
            this.btnAddDept.Text = "Add Department";
            this.btnAddDept.UseVisualStyleBackColor = true;
            this.btnAddDept.Click += new System.EventHandler(this.btnAddDept_Click);
            // 
            // btnDeleteDept
            // 
            this.btnDeleteDept.Location = new System.Drawing.Point(251, 412);
            this.btnDeleteDept.Name = "btnDeleteDept";
            this.btnDeleteDept.Size = new System.Drawing.Size(140, 66);
            this.btnDeleteDept.TabIndex = 6;
            this.btnDeleteDept.Text = "Delete Department";
            this.btnDeleteDept.UseVisualStyleBackColor = true;
            this.btnDeleteDept.Click += new System.EventHandler(this.btnDeleteDept_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(82, 302);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(140, 66);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search Department";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSrchDept
            // 
            this.txtSrchDept.Location = new System.Drawing.Point(251, 324);
            this.txtSrchDept.Name = "txtSrchDept";
            this.txtSrchDept.Size = new System.Drawing.Size(140, 22);
            this.txtSrchDept.TabIndex = 8;
            // 
            // lblExists
            // 
            this.lblExists.AutoSize = true;
            this.lblExists.Location = new System.Drawing.Point(425, 330);
            this.lblExists.Name = "lblExists";
            this.lblExists.Size = new System.Drawing.Size(0, 16);
            this.lblExists.TabIndex = 9;
            // 
            // frmDept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 517);
            this.Controls.Add(this.lblExists);
            this.Controls.Add(this.txtSrchDept);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDeleteDept);
            this.Controls.Add(this.btnAddDept);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnViewDept);
            this.Controls.Add(this.txtDeptName);
            this.Controls.Add(this.lblDept);
            this.Name = "frmDept";
            this.Text = "Department";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.TextBox txtDeptName;
        private System.Windows.Forms.Button btnViewDept;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnAddDept;
        private System.Windows.Forms.Button btnDeleteDept;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSrchDept;
        private System.Windows.Forms.Label lblExists;
    }
}