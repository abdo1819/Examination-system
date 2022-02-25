namespace FrmHome
{
    partial class frmManageQuestions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageQuestions));
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.lblChooseCourse = new System.Windows.Forms.Label();
            this.grpBoxMCQ = new System.Windows.Forms.GroupBox();
            this.txtAnsMCQ = new System.Windows.Forms.TextBox();
            this.lblAnsMCQ = new System.Windows.Forms.Label();
            this.btnUpdateMCQ = new System.Windows.Forms.Button();
            this.lblMCQID = new System.Windows.Forms.Label();
            this.lblSearchMCQ = new System.Windows.Forms.Label();
            this.richTextBoxD = new System.Windows.Forms.RichTextBox();
            this.richTextBoxC = new System.Windows.Forms.RichTextBox();
            this.richTextBoxB = new System.Windows.Forms.RichTextBox();
            this.richTextBoxA = new System.Windows.Forms.RichTextBox();
            this.lblChoices = new System.Windows.Forms.Label();
            this.lblExists = new System.Windows.Forms.Label();
            this.txtBoxSearchMCQ = new System.Windows.Forms.TextBox();
            this.btnSearchMCQ = new System.Windows.Forms.Button();
            this.btnDeleteMCQ = new System.Windows.Forms.Button();
            this.btnAddMCQ = new System.Windows.Forms.Button();
            this.btnMCQPrevious = new System.Windows.Forms.Button();
            this.btnMCQNext = new System.Windows.Forms.Button();
            this.richTextBoxMCQBody = new System.Windows.Forms.RichTextBox();
            this.lblMCQBody = new System.Windows.Forms.Label();
            this.grpBoxTFQ = new System.Windows.Forms.GroupBox();
            this.txtAnsTFQ = new System.Windows.Forms.TextBox();
            this.lblAnsTFQ = new System.Windows.Forms.Label();
            this.lblTFQID = new System.Windows.Forms.Label();
            this.lblSearchTFQ = new System.Windows.Forms.Label();
            this.btnUpdateTFQ = new System.Windows.Forms.Button();
            this.lblTFQbody = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxTFQbody = new System.Windows.Forms.RichTextBox();
            this.txtBoxSearchTFQ = new System.Windows.Forms.TextBox();
            this.btnSearchTFQ = new System.Windows.Forms.Button();
            this.btnTFQNext = new System.Windows.Forms.Button();
            this.btnDeleteTFQ = new System.Windows.Forms.Button();
            this.btnTFQPrevious = new System.Windows.Forms.Button();
            this.btnAddTFQ = new System.Windows.Forms.Button();
            this.rdbtnTFQ = new System.Windows.Forms.RadioButton();
            this.rdbtnMCQ = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.grpBoxMCQ.SuspendLayout();
            this.grpBoxTFQ.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxCourse.BackColor = System.Drawing.SystemColors.Control;
            this.comboBoxCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCourse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(159, 82);
            this.comboBoxCourse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(275, 25);
            this.comboBoxCourse.TabIndex = 0;
            this.comboBoxCourse.SelectedIndexChanged += new System.EventHandler(this.comboBoxCourse_SelectedIndexChanged);
            // 
            // lblChooseCourse
            // 
            this.lblChooseCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblChooseCourse.AutoSize = true;
            this.lblChooseCourse.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblChooseCourse.ForeColor = System.Drawing.Color.Black;
            this.lblChooseCourse.Location = new System.Drawing.Point(118, 43);
            this.lblChooseCourse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChooseCourse.Name = "lblChooseCourse";
            this.lblChooseCourse.Size = new System.Drawing.Size(379, 25);
            this.lblChooseCourse.TabIndex = 1;
            this.lblChooseCourse.Text = "Select Course to review its Questions";
            // 
            // grpBoxMCQ
            // 
            this.grpBoxMCQ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpBoxMCQ.Controls.Add(this.txtAnsMCQ);
            this.grpBoxMCQ.Controls.Add(this.lblAnsMCQ);
            this.grpBoxMCQ.Controls.Add(this.btnUpdateMCQ);
            this.grpBoxMCQ.Controls.Add(this.lblMCQID);
            this.grpBoxMCQ.Controls.Add(this.lblSearchMCQ);
            this.grpBoxMCQ.Controls.Add(this.richTextBoxD);
            this.grpBoxMCQ.Controls.Add(this.richTextBoxC);
            this.grpBoxMCQ.Controls.Add(this.richTextBoxB);
            this.grpBoxMCQ.Controls.Add(this.richTextBoxA);
            this.grpBoxMCQ.Controls.Add(this.lblChoices);
            this.grpBoxMCQ.Controls.Add(this.lblExists);
            this.grpBoxMCQ.Controls.Add(this.txtBoxSearchMCQ);
            this.grpBoxMCQ.Controls.Add(this.btnSearchMCQ);
            this.grpBoxMCQ.Controls.Add(this.btnDeleteMCQ);
            this.grpBoxMCQ.Controls.Add(this.btnAddMCQ);
            this.grpBoxMCQ.Controls.Add(this.btnMCQPrevious);
            this.grpBoxMCQ.Controls.Add(this.btnMCQNext);
            this.grpBoxMCQ.Controls.Add(this.richTextBoxMCQBody);
            this.grpBoxMCQ.Controls.Add(this.lblMCQBody);
            this.grpBoxMCQ.ForeColor = System.Drawing.Color.Black;
            this.grpBoxMCQ.Location = new System.Drawing.Point(77, 171);
            this.grpBoxMCQ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBoxMCQ.Name = "grpBoxMCQ";
            this.grpBoxMCQ.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBoxMCQ.Size = new System.Drawing.Size(424, 334);
            this.grpBoxMCQ.TabIndex = 6;
            this.grpBoxMCQ.TabStop = false;
            // 
            // txtAnsMCQ
            // 
            this.txtAnsMCQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnsMCQ.Location = new System.Drawing.Point(394, 12);
            this.txtAnsMCQ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAnsMCQ.Name = "txtAnsMCQ";
            this.txtAnsMCQ.Size = new System.Drawing.Size(26, 21);
            this.txtAnsMCQ.TabIndex = 33;
            // 
            // lblAnsMCQ
            // 
            this.lblAnsMCQ.AutoSize = true;
            this.lblAnsMCQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnsMCQ.ForeColor = System.Drawing.Color.Black;
            this.lblAnsMCQ.Location = new System.Drawing.Point(306, 15);
            this.lblAnsMCQ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnsMCQ.Name = "lblAnsMCQ";
            this.lblAnsMCQ.Size = new System.Drawing.Size(93, 13);
            this.lblAnsMCQ.TabIndex = 31;
            this.lblAnsMCQ.Text = "Correct Answer";
            // 
            // btnUpdateMCQ
            // 
            this.btnUpdateMCQ.BackColor = System.Drawing.Color.DarkRed;
            this.btnUpdateMCQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateMCQ.ForeColor = System.Drawing.Color.White;
            this.btnUpdateMCQ.Location = new System.Drawing.Point(4, 200);
            this.btnUpdateMCQ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdateMCQ.Name = "btnUpdateMCQ";
            this.btnUpdateMCQ.Size = new System.Drawing.Size(134, 26);
            this.btnUpdateMCQ.TabIndex = 9;
            this.btnUpdateMCQ.Text = "Update Question";
            this.btnUpdateMCQ.UseVisualStyleBackColor = false;
            this.btnUpdateMCQ.Click += new System.EventHandler(this.btnUpdateMCQ_Click);
            // 
            // lblMCQID
            // 
            this.lblMCQID.AutoSize = true;
            this.lblMCQID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMCQID.ForeColor = System.Drawing.Color.Black;
            this.lblMCQID.Location = new System.Drawing.Point(4, 183);
            this.lblMCQID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMCQID.Name = "lblMCQID";
            this.lblMCQID.Size = new System.Drawing.Size(20, 13);
            this.lblMCQID.TabIndex = 9;
            this.lblMCQID.Text = "ID";
            // 
            // lblSearchMCQ
            // 
            this.lblSearchMCQ.AutoSize = true;
            this.lblSearchMCQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchMCQ.ForeColor = System.Drawing.Color.Black;
            this.lblSearchMCQ.Location = new System.Drawing.Point(208, 254);
            this.lblSearchMCQ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchMCQ.Name = "lblSearchMCQ";
            this.lblSearchMCQ.Size = new System.Drawing.Size(20, 13);
            this.lblSearchMCQ.TabIndex = 25;
            this.lblSearchMCQ.Text = "ID";
            // 
            // richTextBoxD
            // 
            this.richTextBoxD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxD.Location = new System.Drawing.Point(142, 145);
            this.richTextBoxD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBoxD.Name = "richTextBoxD";
            this.richTextBoxD.Size = new System.Drawing.Size(278, 36);
            this.richTextBoxD.TabIndex = 24;
            this.richTextBoxD.Text = "";
            // 
            // richTextBoxC
            // 
            this.richTextBoxC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxC.Location = new System.Drawing.Point(142, 107);
            this.richTextBoxC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBoxC.Name = "richTextBoxC";
            this.richTextBoxC.Size = new System.Drawing.Size(278, 36);
            this.richTextBoxC.TabIndex = 23;
            this.richTextBoxC.Text = "";
            // 
            // richTextBoxB
            // 
            this.richTextBoxB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxB.Location = new System.Drawing.Point(143, 69);
            this.richTextBoxB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBoxB.Name = "richTextBoxB";
            this.richTextBoxB.Size = new System.Drawing.Size(278, 36);
            this.richTextBoxB.TabIndex = 22;
            this.richTextBoxB.Text = "";
            // 
            // richTextBoxA
            // 
            this.richTextBoxA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxA.Location = new System.Drawing.Point(143, 31);
            this.richTextBoxA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBoxA.Name = "richTextBoxA";
            this.richTextBoxA.Size = new System.Drawing.Size(278, 36);
            this.richTextBoxA.TabIndex = 21;
            this.richTextBoxA.Text = "";
            // 
            // lblChoices
            // 
            this.lblChoices.AutoSize = true;
            this.lblChoices.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblChoices.Location = new System.Drawing.Point(141, 15);
            this.lblChoices.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChoices.Name = "lblChoices";
            this.lblChoices.Size = new System.Drawing.Size(93, 13);
            this.lblChoices.TabIndex = 20;
            this.lblChoices.Text = "Question Choices:";
            // 
            // lblExists
            // 
            this.lblExists.AutoSize = true;
            this.lblExists.Location = new System.Drawing.Point(239, 200);
            this.lblExists.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExists.Name = "lblExists";
            this.lblExists.Size = new System.Drawing.Size(0, 13);
            this.lblExists.TabIndex = 18;
            // 
            // txtBoxSearchMCQ
            // 
            this.txtBoxSearchMCQ.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtBoxSearchMCQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearchMCQ.Location = new System.Drawing.Point(164, 252);
            this.txtBoxSearchMCQ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxSearchMCQ.Name = "txtBoxSearchMCQ";
            this.txtBoxSearchMCQ.Size = new System.Drawing.Size(30, 21);
            this.txtBoxSearchMCQ.TabIndex = 17;
            // 
            // btnSearchMCQ
            // 
            this.btnSearchMCQ.BackColor = System.Drawing.Color.DarkRed;
            this.btnSearchMCQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMCQ.ForeColor = System.Drawing.Color.White;
            this.btnSearchMCQ.Location = new System.Drawing.Point(4, 249);
            this.btnSearchMCQ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchMCQ.Name = "btnSearchMCQ";
            this.btnSearchMCQ.Size = new System.Drawing.Size(134, 26);
            this.btnSearchMCQ.TabIndex = 16;
            this.btnSearchMCQ.Text = "Search Question with ID";
            this.btnSearchMCQ.UseVisualStyleBackColor = false;
            this.btnSearchMCQ.Click += new System.EventHandler(this.btnSearchMCQ_Click);
            // 
            // btnDeleteMCQ
            // 
            this.btnDeleteMCQ.BackColor = System.Drawing.Color.DarkRed;
            this.btnDeleteMCQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMCQ.ForeColor = System.Drawing.Color.White;
            this.btnDeleteMCQ.Location = new System.Drawing.Point(302, 302);
            this.btnDeleteMCQ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteMCQ.Name = "btnDeleteMCQ";
            this.btnDeleteMCQ.Size = new System.Drawing.Size(118, 27);
            this.btnDeleteMCQ.TabIndex = 15;
            this.btnDeleteMCQ.Text = "Delete Question";
            this.btnDeleteMCQ.UseVisualStyleBackColor = false;
            this.btnDeleteMCQ.Click += new System.EventHandler(this.btnDeleteMCQ_Click);
            // 
            // btnAddMCQ
            // 
            this.btnAddMCQ.BackColor = System.Drawing.Color.DarkRed;
            this.btnAddMCQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMCQ.ForeColor = System.Drawing.Color.White;
            this.btnAddMCQ.Location = new System.Drawing.Point(4, 302);
            this.btnAddMCQ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddMCQ.Name = "btnAddMCQ";
            this.btnAddMCQ.Size = new System.Drawing.Size(131, 27);
            this.btnAddMCQ.TabIndex = 14;
            this.btnAddMCQ.Text = "Add Question";
            this.btnAddMCQ.UseVisualStyleBackColor = false;
            this.btnAddMCQ.Click += new System.EventHandler(this.btnAddMCQ_Click);
            // 
            // btnMCQPrevious
            // 
            this.btnMCQPrevious.BackColor = System.Drawing.Color.DarkRed;
            this.btnMCQPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMCQPrevious.ForeColor = System.Drawing.Color.White;
            this.btnMCQPrevious.Location = new System.Drawing.Point(238, 199);
            this.btnMCQPrevious.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMCQPrevious.Name = "btnMCQPrevious";
            this.btnMCQPrevious.Size = new System.Drawing.Size(42, 26);
            this.btnMCQPrevious.TabIndex = 13;
            this.btnMCQPrevious.Text = "<";
            this.btnMCQPrevious.UseVisualStyleBackColor = false;
            this.btnMCQPrevious.Click += new System.EventHandler(this.btnMCQPrevious_Click);
            // 
            // btnMCQNext
            // 
            this.btnMCQNext.BackColor = System.Drawing.Color.DarkRed;
            this.btnMCQNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMCQNext.ForeColor = System.Drawing.Color.White;
            this.btnMCQNext.Location = new System.Drawing.Point(290, 199);
            this.btnMCQNext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMCQNext.Name = "btnMCQNext";
            this.btnMCQNext.Size = new System.Drawing.Size(42, 26);
            this.btnMCQNext.TabIndex = 12;
            this.btnMCQNext.Text = ">";
            this.btnMCQNext.UseVisualStyleBackColor = false;
            this.btnMCQNext.Click += new System.EventHandler(this.btnMCQNext_Click);
            // 
            // richTextBoxMCQBody
            // 
            this.richTextBoxMCQBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxMCQBody.Location = new System.Drawing.Point(4, 30);
            this.richTextBoxMCQBody.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBoxMCQBody.Name = "richTextBoxMCQBody";
            this.richTextBoxMCQBody.Size = new System.Drawing.Size(134, 151);
            this.richTextBoxMCQBody.TabIndex = 9;
            this.richTextBoxMCQBody.Text = "";
            // 
            // lblMCQBody
            // 
            this.lblMCQBody.AutoSize = true;
            this.lblMCQBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMCQBody.ForeColor = System.Drawing.Color.Black;
            this.lblMCQBody.Location = new System.Drawing.Point(13, 15);
            this.lblMCQBody.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMCQBody.Name = "lblMCQBody";
            this.lblMCQBody.Size = new System.Drawing.Size(93, 13);
            this.lblMCQBody.TabIndex = 9;
            this.lblMCQBody.Text = "Question Body:";
            // 
            // grpBoxTFQ
            // 
            this.grpBoxTFQ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpBoxTFQ.Controls.Add(this.txtAnsTFQ);
            this.grpBoxTFQ.Controls.Add(this.lblAnsTFQ);
            this.grpBoxTFQ.Controls.Add(this.lblTFQID);
            this.grpBoxTFQ.Controls.Add(this.lblSearchTFQ);
            this.grpBoxTFQ.Controls.Add(this.btnUpdateTFQ);
            this.grpBoxTFQ.Controls.Add(this.lblTFQbody);
            this.grpBoxTFQ.Controls.Add(this.label2);
            this.grpBoxTFQ.Controls.Add(this.richTextBoxTFQbody);
            this.grpBoxTFQ.Controls.Add(this.txtBoxSearchTFQ);
            this.grpBoxTFQ.Controls.Add(this.btnSearchTFQ);
            this.grpBoxTFQ.Controls.Add(this.btnTFQNext);
            this.grpBoxTFQ.Controls.Add(this.btnDeleteTFQ);
            this.grpBoxTFQ.Controls.Add(this.btnTFQPrevious);
            this.grpBoxTFQ.Controls.Add(this.btnAddTFQ);
            this.grpBoxTFQ.ForeColor = System.Drawing.Color.Black;
            this.grpBoxTFQ.Location = new System.Drawing.Point(77, 171);
            this.grpBoxTFQ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBoxTFQ.Name = "grpBoxTFQ";
            this.grpBoxTFQ.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBoxTFQ.Size = new System.Drawing.Size(424, 334);
            this.grpBoxTFQ.TabIndex = 7;
            this.grpBoxTFQ.TabStop = false;
            // 
            // txtAnsTFQ
            // 
            this.txtAnsTFQ.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtAnsTFQ.Location = new System.Drawing.Point(394, 9);
            this.txtAnsTFQ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAnsTFQ.Name = "txtAnsTFQ";
            this.txtAnsTFQ.Size = new System.Drawing.Size(26, 20);
            this.txtAnsTFQ.TabIndex = 34;
            // 
            // lblAnsTFQ
            // 
            this.lblAnsTFQ.AutoSize = true;
            this.lblAnsTFQ.BackColor = System.Drawing.Color.Transparent;
            this.lblAnsTFQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblAnsTFQ.ForeColor = System.Drawing.Color.Black;
            this.lblAnsTFQ.Location = new System.Drawing.Point(296, 12);
            this.lblAnsTFQ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnsTFQ.Name = "lblAnsTFQ";
            this.lblAnsTFQ.Size = new System.Drawing.Size(93, 13);
            this.lblAnsTFQ.TabIndex = 32;
            this.lblAnsTFQ.Text = "Correct Answer";
            // 
            // lblTFQID
            // 
            this.lblTFQID.AutoSize = true;
            this.lblTFQID.BackColor = System.Drawing.Color.Transparent;
            this.lblTFQID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblTFQID.ForeColor = System.Drawing.Color.Black;
            this.lblTFQID.Location = new System.Drawing.Point(4, 183);
            this.lblTFQID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTFQID.Name = "lblTFQID";
            this.lblTFQID.Size = new System.Drawing.Size(20, 13);
            this.lblTFQID.TabIndex = 26;
            this.lblTFQID.Text = "ID";
            // 
            // lblSearchTFQ
            // 
            this.lblSearchTFQ.AutoSize = true;
            this.lblSearchTFQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchTFQ.ForeColor = System.Drawing.Color.Black;
            this.lblSearchTFQ.Location = new System.Drawing.Point(208, 251);
            this.lblSearchTFQ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchTFQ.Name = "lblSearchTFQ";
            this.lblSearchTFQ.Size = new System.Drawing.Size(20, 13);
            this.lblSearchTFQ.TabIndex = 26;
            this.lblSearchTFQ.Text = "ID";
            // 
            // btnUpdateTFQ
            // 
            this.btnUpdateTFQ.BackColor = System.Drawing.Color.DarkRed;
            this.btnUpdateTFQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTFQ.ForeColor = System.Drawing.Color.White;
            this.btnUpdateTFQ.Location = new System.Drawing.Point(4, 199);
            this.btnUpdateTFQ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdateTFQ.Name = "btnUpdateTFQ";
            this.btnUpdateTFQ.Size = new System.Drawing.Size(134, 26);
            this.btnUpdateTFQ.TabIndex = 26;
            this.btnUpdateTFQ.Text = "Update Question";
            this.btnUpdateTFQ.UseVisualStyleBackColor = false;
            this.btnUpdateTFQ.Click += new System.EventHandler(this.btnUpdateTFQ_Click);
            // 
            // lblTFQbody
            // 
            this.lblTFQbody.AutoSize = true;
            this.lblTFQbody.BackColor = System.Drawing.Color.Transparent;
            this.lblTFQbody.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblTFQbody.ForeColor = System.Drawing.Color.Black;
            this.lblTFQbody.Location = new System.Drawing.Point(13, 13);
            this.lblTFQbody.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTFQbody.Name = "lblTFQbody";
            this.lblTFQbody.Size = new System.Drawing.Size(93, 13);
            this.lblTFQbody.TabIndex = 22;
            this.lblTFQbody.Text = "Question Body:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 199);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 30;
            // 
            // richTextBoxTFQbody
            // 
            this.richTextBoxTFQbody.BackColor = System.Drawing.SystemColors.HighlightText;
            this.richTextBoxTFQbody.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxTFQbody.Location = new System.Drawing.Point(4, 28);
            this.richTextBoxTFQbody.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBoxTFQbody.Name = "richTextBoxTFQbody";
            this.richTextBoxTFQbody.Size = new System.Drawing.Size(416, 151);
            this.richTextBoxTFQbody.TabIndex = 21;
            this.richTextBoxTFQbody.Text = "";
            // 
            // txtBoxSearchTFQ
            // 
            this.txtBoxSearchTFQ.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtBoxSearchTFQ.Location = new System.Drawing.Point(164, 249);
            this.txtBoxSearchTFQ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxSearchTFQ.Name = "txtBoxSearchTFQ";
            this.txtBoxSearchTFQ.Size = new System.Drawing.Size(30, 20);
            this.txtBoxSearchTFQ.TabIndex = 29;
            // 
            // btnSearchTFQ
            // 
            this.btnSearchTFQ.BackColor = System.Drawing.Color.DarkRed;
            this.btnSearchTFQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchTFQ.ForeColor = System.Drawing.Color.White;
            this.btnSearchTFQ.Location = new System.Drawing.Point(4, 247);
            this.btnSearchTFQ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchTFQ.Name = "btnSearchTFQ";
            this.btnSearchTFQ.Size = new System.Drawing.Size(134, 26);
            this.btnSearchTFQ.TabIndex = 28;
            this.btnSearchTFQ.Text = "Search Question with ID";
            this.btnSearchTFQ.UseVisualStyleBackColor = false;
            this.btnSearchTFQ.Click += new System.EventHandler(this.btnSearchTFQ_Click);
            // 
            // btnTFQNext
            // 
            this.btnTFQNext.BackColor = System.Drawing.Color.DarkRed;
            this.btnTFQNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTFQNext.ForeColor = System.Drawing.Color.White;
            this.btnTFQNext.Location = new System.Drawing.Point(290, 199);
            this.btnTFQNext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTFQNext.Name = "btnTFQNext";
            this.btnTFQNext.Size = new System.Drawing.Size(42, 26);
            this.btnTFQNext.TabIndex = 24;
            this.btnTFQNext.Text = ">";
            this.btnTFQNext.UseVisualStyleBackColor = false;
            this.btnTFQNext.Click += new System.EventHandler(this.btnTFQNext_Click);
            // 
            // btnDeleteTFQ
            // 
            this.btnDeleteTFQ.BackColor = System.Drawing.Color.DarkRed;
            this.btnDeleteTFQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTFQ.ForeColor = System.Drawing.Color.White;
            this.btnDeleteTFQ.Location = new System.Drawing.Point(302, 302);
            this.btnDeleteTFQ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteTFQ.Name = "btnDeleteTFQ";
            this.btnDeleteTFQ.Size = new System.Drawing.Size(118, 27);
            this.btnDeleteTFQ.TabIndex = 27;
            this.btnDeleteTFQ.Text = "Delete Question";
            this.btnDeleteTFQ.UseVisualStyleBackColor = false;
            this.btnDeleteTFQ.Click += new System.EventHandler(this.btnDeleteTFQ_Click);
            // 
            // btnTFQPrevious
            // 
            this.btnTFQPrevious.BackColor = System.Drawing.Color.DarkRed;
            this.btnTFQPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTFQPrevious.ForeColor = System.Drawing.Color.White;
            this.btnTFQPrevious.Location = new System.Drawing.Point(238, 199);
            this.btnTFQPrevious.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTFQPrevious.Name = "btnTFQPrevious";
            this.btnTFQPrevious.Size = new System.Drawing.Size(42, 26);
            this.btnTFQPrevious.TabIndex = 25;
            this.btnTFQPrevious.Text = "<";
            this.btnTFQPrevious.UseVisualStyleBackColor = false;
            this.btnTFQPrevious.Click += new System.EventHandler(this.btnTFQPrevious_Click);
            // 
            // btnAddTFQ
            // 
            this.btnAddTFQ.BackColor = System.Drawing.Color.DarkRed;
            this.btnAddTFQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTFQ.ForeColor = System.Drawing.Color.White;
            this.btnAddTFQ.Location = new System.Drawing.Point(4, 303);
            this.btnAddTFQ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddTFQ.Name = "btnAddTFQ";
            this.btnAddTFQ.Size = new System.Drawing.Size(134, 26);
            this.btnAddTFQ.TabIndex = 26;
            this.btnAddTFQ.Text = "Add Question";
            this.btnAddTFQ.UseVisualStyleBackColor = false;
            this.btnAddTFQ.Click += new System.EventHandler(this.btnAddTFQ_Click);
            // 
            // rdbtnTFQ
            // 
            this.rdbtnTFQ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdbtnTFQ.AutoSize = true;
            this.rdbtnTFQ.Checked = true;
            this.rdbtnTFQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnTFQ.ForeColor = System.Drawing.Color.Black;
            this.rdbtnTFQ.Location = new System.Drawing.Point(315, 120);
            this.rdbtnTFQ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbtnTFQ.Name = "rdbtnTFQ";
            this.rdbtnTFQ.Size = new System.Drawing.Size(49, 17);
            this.rdbtnTFQ.TabIndex = 9;
            this.rdbtnTFQ.TabStop = true;
            this.rdbtnTFQ.Text = "TFQ";
            this.rdbtnTFQ.UseVisualStyleBackColor = true;
            this.rdbtnTFQ.CheckedChanged += new System.EventHandler(this.rdbtnTFQ_CheckedChanged);
            // 
            // rdbtnMCQ
            // 
            this.rdbtnMCQ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdbtnMCQ.AutoSize = true;
            this.rdbtnMCQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnMCQ.ForeColor = System.Drawing.Color.Black;
            this.rdbtnMCQ.Location = new System.Drawing.Point(220, 120);
            this.rdbtnMCQ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbtnMCQ.Name = "rdbtnMCQ";
            this.rdbtnMCQ.Size = new System.Drawing.Size(52, 17);
            this.rdbtnMCQ.TabIndex = 10;
            this.rdbtnMCQ.Text = "MCQ";
            this.rdbtnMCQ.UseVisualStyleBackColor = true;
            this.rdbtnMCQ.CheckedChanged += new System.EventHandler(this.rdbtnMCQ_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnGoBack);
            this.panel1.Controls.Add(this.lblChooseCourse);
            this.panel1.Controls.Add(this.rdbtnMCQ);
            this.panel1.Controls.Add(this.comboBoxCourse);
            this.panel1.Controls.Add(this.grpBoxTFQ);
            this.panel1.Controls.Add(this.grpBoxMCQ);
            this.panel1.Controls.Add(this.rdbtnTFQ);
            this.panel1.Location = new System.Drawing.Point(11, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 598);
            this.panel1.TabIndex = 11;
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.DarkRed;
            this.btnGoBack.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnGoBack.ForeColor = System.Drawing.Color.White;
            this.btnGoBack.Location = new System.Drawing.Point(12, 536);
            this.btnGoBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(117, 50);
            this.btnGoBack.TabIndex = 12;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // frmManageQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(620, 619);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(650, 125);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(620, 590);
            this.Name = "frmManageQuestions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Manage Questions";
            this.Load += new System.EventHandler(this.ManageQuestions_Load);
            this.grpBoxMCQ.ResumeLayout(false);
            this.grpBoxMCQ.PerformLayout();
            this.grpBoxTFQ.ResumeLayout(false);
            this.grpBoxTFQ.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCourse;
        private System.Windows.Forms.Label lblChooseCourse;
        private System.Windows.Forms.GroupBox grpBoxMCQ;
        private System.Windows.Forms.GroupBox grpBoxTFQ;
        private System.Windows.Forms.RichTextBox richTextBoxMCQBody;
        private System.Windows.Forms.Label lblMCQBody;
        private System.Windows.Forms.Label lblExists;
        private System.Windows.Forms.TextBox txtBoxSearchMCQ;
        private System.Windows.Forms.Button btnSearchMCQ;
        private System.Windows.Forms.Button btnDeleteMCQ;
        private System.Windows.Forms.Button btnAddMCQ;
        private System.Windows.Forms.Button btnMCQPrevious;
        private System.Windows.Forms.Button btnMCQNext;
        private System.Windows.Forms.Label lblChoices;
        private System.Windows.Forms.Label lblTFQbody;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBoxTFQbody;
        private System.Windows.Forms.TextBox txtBoxSearchTFQ;
        private System.Windows.Forms.Button btnSearchTFQ;
        private System.Windows.Forms.Button btnTFQNext;
        private System.Windows.Forms.Button btnDeleteTFQ;
        private System.Windows.Forms.Button btnTFQPrevious;
        private System.Windows.Forms.Button btnAddTFQ;
        private System.Windows.Forms.RichTextBox richTextBoxD;
        private System.Windows.Forms.RichTextBox richTextBoxC;
        private System.Windows.Forms.RichTextBox richTextBoxB;
        private System.Windows.Forms.RichTextBox richTextBoxA;
        private System.Windows.Forms.Label lblSearchMCQ;
        private System.Windows.Forms.Label lblMCQID;
        private System.Windows.Forms.Button btnUpdateMCQ;
        private System.Windows.Forms.Button btnUpdateTFQ;
        private System.Windows.Forms.Label lblSearchTFQ;
        private System.Windows.Forms.Label lblTFQID;
        private System.Windows.Forms.Label lblAnsMCQ;
        private System.Windows.Forms.Label lblAnsTFQ;
        private System.Windows.Forms.TextBox txtAnsMCQ;
        private System.Windows.Forms.TextBox txtAnsTFQ;
        private System.Windows.Forms.RadioButton rdbtnTFQ;
        private System.Windows.Forms.RadioButton rdbtnMCQ;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGoBack;
    }
}