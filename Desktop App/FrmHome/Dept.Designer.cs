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
            this.btnViewDept = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnAddDept = new System.Windows.Forms.Button();
            this.btnDeleteDept = new System.Windows.Forms.Button();
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
            this.lblDept.Location = new System.Drawing.Point(32, 24);
            this.lblDept.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(138, 17);
            this.lblDept.TabIndex = 0;
            this.lblDept.Text = "Department Name";
            // 
            // txtDeptName
            // 
            this.txtDeptName.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDeptName.Location = new System.Drawing.Point(171, 28);
            this.txtDeptName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.Size = new System.Drawing.Size(209, 20);
            this.txtDeptName.TabIndex = 1;
            // 
            // btnViewDept
            // 
            this.btnViewDept.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnViewDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDept.Location = new System.Drawing.Point(518, 28);
            this.btnViewDept.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewDept.Name = "btnViewDept";
            this.btnViewDept.Size = new System.Drawing.Size(158, 54);
            this.btnViewDept.TabIndex = 2;
            this.btnViewDept.Text = "View Departments";
            this.btnViewDept.UseVisualStyleBackColor = true;
            this.btnViewDept.Click += new System.EventHandler(this.btnViewDept_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(218, 66);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(80, 54);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(90, 66);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(80, 54);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnAddDept
            // 
            this.btnAddDept.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDept.Location = new System.Drawing.Point(518, 101);
            this.btnAddDept.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddDept.Name = "btnAddDept";
            this.btnAddDept.Size = new System.Drawing.Size(158, 54);
            this.btnAddDept.TabIndex = 5;
            this.btnAddDept.Text = "Add Department";
            this.btnAddDept.UseVisualStyleBackColor = true;
            this.btnAddDept.Click += new System.EventHandler(this.btnAddDept_Click);
            // 
            // btnDeleteDept
            // 
            this.btnDeleteDept.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDeleteDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDept.Location = new System.Drawing.Point(518, 175);
            this.btnDeleteDept.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteDept.Name = "btnDeleteDept";
            this.btnDeleteDept.Size = new System.Drawing.Size(158, 54);
            this.btnDeleteDept.TabIndex = 6;
            this.btnDeleteDept.Text = "Delete Department";
            this.btnDeleteDept.UseVisualStyleBackColor = true;
            this.btnDeleteDept.Click += new System.EventHandler(this.btnDeleteDept_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(90, 175);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 54);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search Department";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSrchDept
            // 
            this.txtSrchDept.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSrchDept.BackColor = System.Drawing.SystemColors.Menu;
            this.txtSrchDept.Location = new System.Drawing.Point(90, 249);
            this.txtSrchDept.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSrchDept.Name = "txtSrchDept";
            this.txtSrchDept.Size = new System.Drawing.Size(106, 20);
            this.txtSrchDept.TabIndex = 8;
            // 
            // lblExists
            // 
            this.lblExists.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblExists.AutoSize = true;
            this.lblExists.BackColor = System.Drawing.Color.Transparent;
            this.lblExists.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblExists.Location = new System.Drawing.Point(88, 281);
            this.lblExists.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExists.Name = "lblExists";
            this.lblExists.Size = new System.Drawing.Size(62, 13);
            this.lblExists.TabIndex = 9;
            this.lblExists.Text = "Department";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(518, 249);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(158, 54);
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
            this.lblDeptID.Location = new System.Drawing.Point(394, 28);
            this.lblDeptID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeptID.Name = "lblDeptID";
            this.lblDeptID.Size = new System.Drawing.Size(34, 19);
            this.lblDeptID.TabIndex = 11;
            this.lblDeptID.Text = "ID";
            // 
            // frmDept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(721, 363);
            this.Controls.Add(this.lblDeptID);
            this.Controls.Add(this.btnUpdate);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(955, 634);
            this.MinimumSize = new System.Drawing.Size(737, 402);
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
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblDeptID;
    }
}