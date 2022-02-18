namespace ExaminationSystem
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
            this.btnRemoveDept = new System.Windows.Forms.Button();
            this.btnAddDept = new System.Windows.Forms.Button();
            this.btnViewDept = new System.Windows.Forms.Button();
            this.grdDept = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdDept)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemoveDept
            // 
            this.btnRemoveDept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveDept.Location = new System.Drawing.Point(12, 367);
            this.btnRemoveDept.Name = "btnRemoveDept";
            this.btnRemoveDept.Size = new System.Drawing.Size(162, 71);
            this.btnRemoveDept.TabIndex = 0;
            this.btnRemoveDept.Text = "Remove Department";
            this.btnRemoveDept.UseVisualStyleBackColor = true;
            // 
            // btnAddDept
            // 
            this.btnAddDept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddDept.Location = new System.Drawing.Point(306, 367);
            this.btnAddDept.Name = "btnAddDept";
            this.btnAddDept.Size = new System.Drawing.Size(162, 71);
            this.btnAddDept.TabIndex = 1;
            this.btnAddDept.Text = "Add Department";
            this.btnAddDept.UseVisualStyleBackColor = true;
            // 
            // btnViewDept
            // 
            this.btnViewDept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewDept.Location = new System.Drawing.Point(626, 367);
            this.btnViewDept.Name = "btnViewDept";
            this.btnViewDept.Size = new System.Drawing.Size(162, 71);
            this.btnViewDept.TabIndex = 2;
            this.btnViewDept.TabStop = false;
            this.btnViewDept.Text = "View Departments";
            this.btnViewDept.UseVisualStyleBackColor = true;
            this.btnViewDept.Click += new System.EventHandler(this.btnViewDept_Click);
            // 
            // grdDept
            // 
            this.grdDept.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDept.Location = new System.Drawing.Point(12, 34);
            this.grdDept.Name = "grdDept";
            this.grdDept.RowHeadersWidth = 51;
            this.grdDept.RowTemplate.Height = 29;
            this.grdDept.Size = new System.Drawing.Size(776, 307);
            this.grdDept.TabIndex = 3;
            // 
            // frmDept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdDept);
            this.Controls.Add(this.btnViewDept);
            this.Controls.Add(this.btnAddDept);
            this.Controls.Add(this.btnRemoveDept);
            this.Name = "frmDept";
            this.Text = "Department Form";
            ((System.ComponentModel.ISupportInitialize)(this.grdDept)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnRemoveDept;
        private Button btnAddDept;
        private Button btnViewDept;
        private DataGridView grdDept;
    }
}