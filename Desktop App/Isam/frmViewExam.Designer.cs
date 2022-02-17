
namespace Isam
{
    partial class frmViewExam
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewExam));
            System.Windows.Forms.Label q_textLabel;
            System.Windows.Forms.Label q_typeLabel;
            System.Windows.Forms.Label ch_aLabel;
            System.Windows.Forms.Label ch_bLabel;
            System.Windows.Forms.Label ch_cLabel;
            System.Windows.Forms.Label ch_dLabel;
            this.viewExamQuestionsTableAdapter1 = new Isam.ExaminationDataSet1TableAdapters.viewExamQuestionsTableAdapter();
            this.examinationDataSet = new Isam.ExaminationDataSet();
            this.get_Questions_in_ExamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_Questions_in_ExamTableAdapter = new Isam.ExaminationDataSetTableAdapters.Get_Questions_in_ExamTableAdapter();
            this.tableAdapterManager = new Isam.ExaminationDataSetTableAdapters.TableAdapterManager();
            this.get_Questions_in_ExamBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.get_Questions_in_ExamBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.ex_idToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.ex_idToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.q_textTextBox = new System.Windows.Forms.TextBox();
            this.q_typeTextBox = new System.Windows.Forms.TextBox();
            this.ch_aTextBox = new System.Windows.Forms.TextBox();
            this.ch_bTextBox = new System.Windows.Forms.TextBox();
            this.ch_cTextBox = new System.Windows.Forms.TextBox();
            this.ch_dTextBox = new System.Windows.Forms.TextBox();
            q_textLabel = new System.Windows.Forms.Label();
            q_typeLabel = new System.Windows.Forms.Label();
            ch_aLabel = new System.Windows.Forms.Label();
            ch_bLabel = new System.Windows.Forms.Label();
            ch_cLabel = new System.Windows.Forms.Label();
            ch_dLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.examinationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_Questions_in_ExamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_Questions_in_ExamBindingNavigator)).BeginInit();
            this.get_Questions_in_ExamBindingNavigator.SuspendLayout();
            this.fillToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewExamQuestionsTableAdapter1
            // 
            this.viewExamQuestionsTableAdapter1.ClearBeforeFill = true;
            // 
            // examinationDataSet
            // 
            this.examinationDataSet.DataSetName = "ExaminationDataSet";
            this.examinationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // get_Questions_in_ExamBindingSource
            // 
            this.get_Questions_in_ExamBindingSource.DataMember = "Get_Questions_in_Exam";
            this.get_Questions_in_ExamBindingSource.DataSource = this.examinationDataSet;
            // 
            // get_Questions_in_ExamTableAdapter
            // 
            this.get_Questions_in_ExamTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Isam.ExaminationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // get_Questions_in_ExamBindingNavigator
            // 
            this.get_Questions_in_ExamBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.get_Questions_in_ExamBindingNavigator.BindingSource = this.get_Questions_in_ExamBindingSource;
            this.get_Questions_in_ExamBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.get_Questions_in_ExamBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.get_Questions_in_ExamBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.get_Questions_in_ExamBindingNavigatorSaveItem});
            this.get_Questions_in_ExamBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.get_Questions_in_ExamBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.get_Questions_in_ExamBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.get_Questions_in_ExamBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.get_Questions_in_ExamBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.get_Questions_in_ExamBindingNavigator.Name = "get_Questions_in_ExamBindingNavigator";
            this.get_Questions_in_ExamBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.get_Questions_in_ExamBindingNavigator.Size = new System.Drawing.Size(580, 25);
            this.get_Questions_in_ExamBindingNavigator.TabIndex = 0;
            this.get_Questions_in_ExamBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // get_Questions_in_ExamBindingNavigatorSaveItem
            // 
            this.get_Questions_in_ExamBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.get_Questions_in_ExamBindingNavigatorSaveItem.Enabled = false;
            this.get_Questions_in_ExamBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("get_Questions_in_ExamBindingNavigatorSaveItem.Image")));
            this.get_Questions_in_ExamBindingNavigatorSaveItem.Name = "get_Questions_in_ExamBindingNavigatorSaveItem";
            this.get_Questions_in_ExamBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 20);
            this.get_Questions_in_ExamBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ex_idToolStripLabel,
            this.ex_idToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 25);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(580, 25);
            this.fillToolStrip.TabIndex = 1;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // ex_idToolStripLabel
            // 
            this.ex_idToolStripLabel.Name = "ex_idToolStripLabel";
            this.ex_idToolStripLabel.Size = new System.Drawing.Size(37, 22);
            this.ex_idToolStripLabel.Text = "ex_id:";
            // 
            // ex_idToolStripTextBox
            // 
            this.ex_idToolStripTextBox.Name = "ex_idToolStripTextBox";
            this.ex_idToolStripTextBox.Size = new System.Drawing.Size(100, 23);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(26, 19);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click_1);
            // 
            // q_textLabel
            // 
            q_textLabel.AutoSize = true;
            q_textLabel.Location = new System.Drawing.Point(227, 175);
            q_textLabel.Name = "q_textLabel";
            q_textLabel.Size = new System.Drawing.Size(36, 13);
            q_textLabel.TabIndex = 2;
            q_textLabel.Text = "q text:";
            // 
            // q_textTextBox
            // 
            this.q_textTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.get_Questions_in_ExamBindingSource, "q_text", true));
            this.q_textTextBox.Location = new System.Drawing.Point(272, 172);
            this.q_textTextBox.Name = "q_textTextBox";
            this.q_textTextBox.Size = new System.Drawing.Size(100, 20);
            this.q_textTextBox.TabIndex = 3;
            // 
            // q_typeLabel
            // 
            q_typeLabel.AutoSize = true;
            q_typeLabel.Location = new System.Drawing.Point(227, 201);
            q_typeLabel.Name = "q_typeLabel";
            q_typeLabel.Size = new System.Drawing.Size(39, 13);
            q_typeLabel.TabIndex = 4;
            q_typeLabel.Text = "q type:";
            // 
            // q_typeTextBox
            // 
            this.q_typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.get_Questions_in_ExamBindingSource, "q_type", true));
            this.q_typeTextBox.Location = new System.Drawing.Point(272, 198);
            this.q_typeTextBox.Name = "q_typeTextBox";
            this.q_typeTextBox.Size = new System.Drawing.Size(100, 20);
            this.q_typeTextBox.TabIndex = 5;
            // 
            // ch_aLabel
            // 
            ch_aLabel.AutoSize = true;
            ch_aLabel.Location = new System.Drawing.Point(227, 227);
            ch_aLabel.Name = "ch_aLabel";
            ch_aLabel.Size = new System.Drawing.Size(31, 13);
            ch_aLabel.TabIndex = 6;
            ch_aLabel.Text = "ch a:";
            // 
            // ch_aTextBox
            // 
            this.ch_aTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.get_Questions_in_ExamBindingSource, "ch_a", true));
            this.ch_aTextBox.Location = new System.Drawing.Point(272, 224);
            this.ch_aTextBox.Name = "ch_aTextBox";
            this.ch_aTextBox.Size = new System.Drawing.Size(100, 20);
            this.ch_aTextBox.TabIndex = 7;
            // 
            // ch_bLabel
            // 
            ch_bLabel.AutoSize = true;
            ch_bLabel.Location = new System.Drawing.Point(227, 253);
            ch_bLabel.Name = "ch_bLabel";
            ch_bLabel.Size = new System.Drawing.Size(31, 13);
            ch_bLabel.TabIndex = 8;
            ch_bLabel.Text = "ch b:";
            // 
            // ch_bTextBox
            // 
            this.ch_bTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.get_Questions_in_ExamBindingSource, "ch_b", true));
            this.ch_bTextBox.Location = new System.Drawing.Point(272, 250);
            this.ch_bTextBox.Name = "ch_bTextBox";
            this.ch_bTextBox.Size = new System.Drawing.Size(100, 20);
            this.ch_bTextBox.TabIndex = 9;
            // 
            // ch_cLabel
            // 
            ch_cLabel.AutoSize = true;
            ch_cLabel.Location = new System.Drawing.Point(227, 279);
            ch_cLabel.Name = "ch_cLabel";
            ch_cLabel.Size = new System.Drawing.Size(31, 13);
            ch_cLabel.TabIndex = 10;
            ch_cLabel.Text = "ch c:";
            // 
            // ch_cTextBox
            // 
            this.ch_cTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.get_Questions_in_ExamBindingSource, "ch_c", true));
            this.ch_cTextBox.Location = new System.Drawing.Point(272, 276);
            this.ch_cTextBox.Name = "ch_cTextBox";
            this.ch_cTextBox.Size = new System.Drawing.Size(100, 20);
            this.ch_cTextBox.TabIndex = 11;
            // 
            // ch_dLabel
            // 
            ch_dLabel.AutoSize = true;
            ch_dLabel.Location = new System.Drawing.Point(227, 305);
            ch_dLabel.Name = "ch_dLabel";
            ch_dLabel.Size = new System.Drawing.Size(31, 13);
            ch_dLabel.TabIndex = 12;
            ch_dLabel.Text = "ch d:";
            // 
            // ch_dTextBox
            // 
            this.ch_dTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.get_Questions_in_ExamBindingSource, "ch_d", true));
            this.ch_dTextBox.Location = new System.Drawing.Point(272, 302);
            this.ch_dTextBox.Name = "ch_dTextBox";
            this.ch_dTextBox.Size = new System.Drawing.Size(100, 20);
            this.ch_dTextBox.TabIndex = 13;
            // 
            // frmViewExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 462);
            this.Controls.Add(q_textLabel);
            this.Controls.Add(this.q_textTextBox);
            this.Controls.Add(q_typeLabel);
            this.Controls.Add(this.q_typeTextBox);
            this.Controls.Add(ch_aLabel);
            this.Controls.Add(this.ch_aTextBox);
            this.Controls.Add(ch_bLabel);
            this.Controls.Add(this.ch_bTextBox);
            this.Controls.Add(ch_cLabel);
            this.Controls.Add(this.ch_cTextBox);
            this.Controls.Add(ch_dLabel);
            this.Controls.Add(this.ch_dTextBox);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.get_Questions_in_ExamBindingNavigator);
            this.Name = "frmViewExam";
            this.Text = "frmViewExam";
            ((System.ComponentModel.ISupportInitialize)(this.examinationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_Questions_in_ExamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_Questions_in_ExamBindingNavigator)).EndInit();
            this.get_Questions_in_ExamBindingNavigator.ResumeLayout(false);
            this.get_Questions_in_ExamBindingNavigator.PerformLayout();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ExaminationDataSet1TableAdapters.viewExamQuestionsTableAdapter viewExamQuestionsTableAdapter1;
        private ExaminationDataSet examinationDataSet;
        private System.Windows.Forms.BindingSource get_Questions_in_ExamBindingSource;
        private ExaminationDataSetTableAdapters.Get_Questions_in_ExamTableAdapter get_Questions_in_ExamTableAdapter;
        private ExaminationDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator get_Questions_in_ExamBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton get_Questions_in_ExamBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel ex_idToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox ex_idToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.TextBox q_textTextBox;
        private System.Windows.Forms.TextBox q_typeTextBox;
        private System.Windows.Forms.TextBox ch_aTextBox;
        private System.Windows.Forms.TextBox ch_bTextBox;
        private System.Windows.Forms.TextBox ch_cTextBox;
        private System.Windows.Forms.TextBox ch_dTextBox;
    }
}