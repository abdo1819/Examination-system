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
            this.btnViewMCQQuestions = new System.Windows.Forms.Button();
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
            this.btnVieqTFQQuestions = new System.Windows.Forms.Button();
            this.btnSearchTFQ = new System.Windows.Forms.Button();
            this.btnTFQNext = new System.Windows.Forms.Button();
            this.btnDeleteTFQ = new System.Windows.Forms.Button();
            this.btnTFQPrevious = new System.Windows.Forms.Button();
            this.btnAddTFQ = new System.Windows.Forms.Button();
            this.rdbtnTFQ = new System.Windows.Forms.RadioButton();
            this.rdbtnMCQ = new System.Windows.Forms.RadioButton();
            this.grpBoxMCQ.SuspendLayout();
            this.grpBoxTFQ.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.BackColor = System.Drawing.SystemColors.Control;
            this.comboBoxCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCourse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(265, 77);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(365, 28);
            this.comboBoxCourse.TabIndex = 0;
            // 
            // lblChooseCourse
            // 
            this.lblChooseCourse.AutoSize = true;
            this.lblChooseCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseCourse.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblChooseCourse.Location = new System.Drawing.Point(260, 47);
            this.lblChooseCourse.Name = "lblChooseCourse";
            this.lblChooseCourse.Size = new System.Drawing.Size(373, 25);
            this.lblChooseCourse.TabIndex = 1;
            this.lblChooseCourse.Text = "Select Course to review its Questions";
            // 
            // grpBoxMCQ
            // 
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
            this.grpBoxMCQ.Controls.Add(this.btnViewMCQQuestions);
            this.grpBoxMCQ.Controls.Add(this.richTextBoxMCQBody);
            this.grpBoxMCQ.Controls.Add(this.lblMCQBody);
            this.grpBoxMCQ.Location = new System.Drawing.Point(156, 163);
            this.grpBoxMCQ.Name = "grpBoxMCQ";
            this.grpBoxMCQ.Size = new System.Drawing.Size(566, 411);
            this.grpBoxMCQ.TabIndex = 6;
            this.grpBoxMCQ.TabStop = false;
            // 
            // txtAnsMCQ
            // 
            this.txtAnsMCQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnsMCQ.Location = new System.Drawing.Point(525, 15);
            this.txtAnsMCQ.Name = "txtAnsMCQ";
            this.txtAnsMCQ.Size = new System.Drawing.Size(34, 24);
            this.txtAnsMCQ.TabIndex = 33;
            // 
            // lblAnsMCQ
            // 
            this.lblAnsMCQ.AutoSize = true;
            this.lblAnsMCQ.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblAnsMCQ.Location = new System.Drawing.Point(422, 18);
            this.lblAnsMCQ.Name = "lblAnsMCQ";
            this.lblAnsMCQ.Size = new System.Drawing.Size(97, 16);
            this.lblAnsMCQ.TabIndex = 31;
            this.lblAnsMCQ.Text = "Correct Answer";
            // 
            // btnUpdateMCQ
            // 
            this.btnUpdateMCQ.BackColor = System.Drawing.Color.Snow;
            this.btnUpdateMCQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateMCQ.Location = new System.Drawing.Point(6, 246);
            this.btnUpdateMCQ.Name = "btnUpdateMCQ";
            this.btnUpdateMCQ.Size = new System.Drawing.Size(175, 37);
            this.btnUpdateMCQ.TabIndex = 9;
            this.btnUpdateMCQ.Text = "Update Question";
            this.btnUpdateMCQ.UseVisualStyleBackColor = false;
            this.btnUpdateMCQ.Click += new System.EventHandler(this.btnUpdateMCQ_Click);
            // 
            // lblMCQID
            // 
            this.lblMCQID.AutoSize = true;
            this.lblMCQID.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblMCQID.Location = new System.Drawing.Point(6, 225);
            this.lblMCQID.Name = "lblMCQID";
            this.lblMCQID.Size = new System.Drawing.Size(20, 16);
            this.lblMCQID.TabIndex = 9;
            this.lblMCQID.Text = "ID";
            // 
            // lblSearchMCQ
            // 
            this.lblSearchMCQ.AutoSize = true;
            this.lblSearchMCQ.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblSearchMCQ.Location = new System.Drawing.Point(277, 313);
            this.lblSearchMCQ.Name = "lblSearchMCQ";
            this.lblSearchMCQ.Size = new System.Drawing.Size(20, 16);
            this.lblSearchMCQ.TabIndex = 25;
            this.lblSearchMCQ.Text = "ID";
            // 
            // richTextBoxD
            // 
            this.richTextBoxD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxD.Location = new System.Drawing.Point(190, 179);
            this.richTextBoxD.Name = "richTextBoxD";
            this.richTextBoxD.Size = new System.Drawing.Size(369, 43);
            this.richTextBoxD.TabIndex = 24;
            this.richTextBoxD.Text = "";
            // 
            // richTextBoxC
            // 
            this.richTextBoxC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxC.Location = new System.Drawing.Point(190, 132);
            this.richTextBoxC.Name = "richTextBoxC";
            this.richTextBoxC.Size = new System.Drawing.Size(369, 43);
            this.richTextBoxC.TabIndex = 23;
            this.richTextBoxC.Text = "";
            // 
            // richTextBoxB
            // 
            this.richTextBoxB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxB.Location = new System.Drawing.Point(191, 85);
            this.richTextBoxB.Name = "richTextBoxB";
            this.richTextBoxB.Size = new System.Drawing.Size(369, 43);
            this.richTextBoxB.TabIndex = 22;
            this.richTextBoxB.Text = "";
            // 
            // richTextBoxA
            // 
            this.richTextBoxA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxA.Location = new System.Drawing.Point(191, 38);
            this.richTextBoxA.Name = "richTextBoxA";
            this.richTextBoxA.Size = new System.Drawing.Size(369, 43);
            this.richTextBoxA.TabIndex = 21;
            this.richTextBoxA.Text = "";
            // 
            // lblChoices
            // 
            this.lblChoices.AutoSize = true;
            this.lblChoices.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblChoices.Location = new System.Drawing.Point(188, 18);
            this.lblChoices.Name = "lblChoices";
            this.lblChoices.Size = new System.Drawing.Size(115, 16);
            this.lblChoices.TabIndex = 20;
            this.lblChoices.Text = "Question Choices:";
            // 
            // lblExists
            // 
            this.lblExists.AutoSize = true;
            this.lblExists.Location = new System.Drawing.Point(319, 246);
            this.lblExists.Name = "lblExists";
            this.lblExists.Size = new System.Drawing.Size(0, 16);
            this.lblExists.TabIndex = 18;
            // 
            // txtBoxSearchMCQ
            // 
            this.txtBoxSearchMCQ.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtBoxSearchMCQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearchMCQ.Location = new System.Drawing.Point(219, 310);
            this.txtBoxSearchMCQ.Name = "txtBoxSearchMCQ";
            this.txtBoxSearchMCQ.Size = new System.Drawing.Size(39, 24);
            this.txtBoxSearchMCQ.TabIndex = 17;
            // 
            // btnSearchMCQ
            // 
            this.btnSearchMCQ.BackColor = System.Drawing.Color.Snow;
            this.btnSearchMCQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMCQ.Location = new System.Drawing.Point(6, 307);
            this.btnSearchMCQ.Name = "btnSearchMCQ";
            this.btnSearchMCQ.Size = new System.Drawing.Size(175, 29);
            this.btnSearchMCQ.TabIndex = 16;
            this.btnSearchMCQ.Text = "Search Question with ID";
            this.btnSearchMCQ.UseVisualStyleBackColor = false;
            this.btnSearchMCQ.Click += new System.EventHandler(this.btnSearchMCQ_Click);
            // 
            // btnDeleteMCQ
            // 
            this.btnDeleteMCQ.BackColor = System.Drawing.Color.Snow;
            this.btnDeleteMCQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMCQ.Location = new System.Drawing.Point(219, 358);
            this.btnDeleteMCQ.Name = "btnDeleteMCQ";
            this.btnDeleteMCQ.Size = new System.Drawing.Size(157, 33);
            this.btnDeleteMCQ.TabIndex = 15;
            this.btnDeleteMCQ.Text = "Delete Question";
            this.btnDeleteMCQ.UseVisualStyleBackColor = false;
            this.btnDeleteMCQ.Click += new System.EventHandler(this.btnDeleteMCQ_Click);
            // 
            // btnAddMCQ
            // 
            this.btnAddMCQ.BackColor = System.Drawing.Color.Snow;
            this.btnAddMCQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMCQ.Location = new System.Drawing.Point(6, 358);
            this.btnAddMCQ.Name = "btnAddMCQ";
            this.btnAddMCQ.Size = new System.Drawing.Size(175, 33);
            this.btnAddMCQ.TabIndex = 14;
            this.btnAddMCQ.Text = "Add Question";
            this.btnAddMCQ.UseVisualStyleBackColor = false;
            this.btnAddMCQ.Click += new System.EventHandler(this.btnAddMCQ_Click);
            // 
            // btnMCQPrevious
            // 
            this.btnMCQPrevious.BackColor = System.Drawing.Color.Snow;
            this.btnMCQPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMCQPrevious.Location = new System.Drawing.Point(219, 246);
            this.btnMCQPrevious.Name = "btnMCQPrevious";
            this.btnMCQPrevious.Size = new System.Drawing.Size(78, 37);
            this.btnMCQPrevious.TabIndex = 13;
            this.btnMCQPrevious.Text = "Previous";
            this.btnMCQPrevious.UseVisualStyleBackColor = false;
            this.btnMCQPrevious.Click += new System.EventHandler(this.btnMCQPrevious_Click);
            // 
            // btnMCQNext
            // 
            this.btnMCQNext.BackColor = System.Drawing.Color.Snow;
            this.btnMCQNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMCQNext.Location = new System.Drawing.Point(335, 246);
            this.btnMCQNext.Name = "btnMCQNext";
            this.btnMCQNext.Size = new System.Drawing.Size(78, 37);
            this.btnMCQNext.TabIndex = 12;
            this.btnMCQNext.Text = "Next";
            this.btnMCQNext.UseVisualStyleBackColor = false;
            this.btnMCQNext.Click += new System.EventHandler(this.btnMCQNext_Click);
            // 
            // btnViewMCQQuestions
            // 
            this.btnViewMCQQuestions.BackColor = System.Drawing.Color.Snow;
            this.btnViewMCQQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewMCQQuestions.Location = new System.Drawing.Point(411, 358);
            this.btnViewMCQQuestions.Name = "btnViewMCQQuestions";
            this.btnViewMCQQuestions.Size = new System.Drawing.Size(149, 33);
            this.btnViewMCQQuestions.TabIndex = 11;
            this.btnViewMCQQuestions.Text = "View Questions";
            this.btnViewMCQQuestions.UseVisualStyleBackColor = false;
            this.btnViewMCQQuestions.Click += new System.EventHandler(this.btnViewMCQQuestions_Click);
            // 
            // richTextBoxMCQBody
            // 
            this.richTextBoxMCQBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxMCQBody.Location = new System.Drawing.Point(6, 37);
            this.richTextBoxMCQBody.Name = "richTextBoxMCQBody";
            this.richTextBoxMCQBody.Size = new System.Drawing.Size(178, 185);
            this.richTextBoxMCQBody.TabIndex = 9;
            this.richTextBoxMCQBody.Text = "";
            // 
            // lblMCQBody
            // 
            this.lblMCQBody.AutoSize = true;
            this.lblMCQBody.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblMCQBody.Location = new System.Drawing.Point(17, 18);
            this.lblMCQBody.Name = "lblMCQBody";
            this.lblMCQBody.Size = new System.Drawing.Size(98, 16);
            this.lblMCQBody.TabIndex = 9;
            this.lblMCQBody.Text = "Question Body:";
            // 
            // grpBoxTFQ
            // 
            this.grpBoxTFQ.Controls.Add(this.txtAnsTFQ);
            this.grpBoxTFQ.Controls.Add(this.lblAnsTFQ);
            this.grpBoxTFQ.Controls.Add(this.lblTFQID);
            this.grpBoxTFQ.Controls.Add(this.lblSearchTFQ);
            this.grpBoxTFQ.Controls.Add(this.btnUpdateTFQ);
            this.grpBoxTFQ.Controls.Add(this.lblTFQbody);
            this.grpBoxTFQ.Controls.Add(this.label2);
            this.grpBoxTFQ.Controls.Add(this.richTextBoxTFQbody);
            this.grpBoxTFQ.Controls.Add(this.txtBoxSearchTFQ);
            this.grpBoxTFQ.Controls.Add(this.btnVieqTFQQuestions);
            this.grpBoxTFQ.Controls.Add(this.btnSearchTFQ);
            this.grpBoxTFQ.Controls.Add(this.btnTFQNext);
            this.grpBoxTFQ.Controls.Add(this.btnDeleteTFQ);
            this.grpBoxTFQ.Controls.Add(this.btnTFQPrevious);
            this.grpBoxTFQ.Controls.Add(this.btnAddTFQ);
            this.grpBoxTFQ.Location = new System.Drawing.Point(156, 163);
            this.grpBoxTFQ.Name = "grpBoxTFQ";
            this.grpBoxTFQ.Size = new System.Drawing.Size(566, 411);
            this.grpBoxTFQ.TabIndex = 7;
            this.grpBoxTFQ.TabStop = false;
            // 
            // txtAnsTFQ
            // 
            this.txtAnsTFQ.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtAnsTFQ.Location = new System.Drawing.Point(525, 11);
            this.txtAnsTFQ.Name = "txtAnsTFQ";
            this.txtAnsTFQ.Size = new System.Drawing.Size(34, 22);
            this.txtAnsTFQ.TabIndex = 34;
            // 
            // lblAnsTFQ
            // 
            this.lblAnsTFQ.AutoSize = true;
            this.lblAnsTFQ.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblAnsTFQ.Location = new System.Drawing.Point(420, 16);
            this.lblAnsTFQ.Name = "lblAnsTFQ";
            this.lblAnsTFQ.Size = new System.Drawing.Size(97, 16);
            this.lblAnsTFQ.TabIndex = 32;
            this.lblAnsTFQ.Text = "Correct Answer";
            // 
            // lblTFQID
            // 
            this.lblTFQID.AutoSize = true;
            this.lblTFQID.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTFQID.Location = new System.Drawing.Point(6, 225);
            this.lblTFQID.Name = "lblTFQID";
            this.lblTFQID.Size = new System.Drawing.Size(20, 16);
            this.lblTFQID.TabIndex = 26;
            this.lblTFQID.Text = "ID";
            // 
            // lblSearchTFQ
            // 
            this.lblSearchTFQ.AutoSize = true;
            this.lblSearchTFQ.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblSearchTFQ.Location = new System.Drawing.Point(277, 309);
            this.lblSearchTFQ.Name = "lblSearchTFQ";
            this.lblSearchTFQ.Size = new System.Drawing.Size(20, 16);
            this.lblSearchTFQ.TabIndex = 26;
            this.lblSearchTFQ.Text = "ID";
            // 
            // btnUpdateTFQ
            // 
            this.btnUpdateTFQ.BackColor = System.Drawing.Color.Snow;
            this.btnUpdateTFQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTFQ.Location = new System.Drawing.Point(6, 245);
            this.btnUpdateTFQ.Name = "btnUpdateTFQ";
            this.btnUpdateTFQ.Size = new System.Drawing.Size(175, 37);
            this.btnUpdateTFQ.TabIndex = 26;
            this.btnUpdateTFQ.Text = "Update Question";
            this.btnUpdateTFQ.UseVisualStyleBackColor = false;
            this.btnUpdateTFQ.Click += new System.EventHandler(this.btnUpdateTFQ_Click);
            // 
            // lblTFQbody
            // 
            this.lblTFQbody.AutoSize = true;
            this.lblTFQbody.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTFQbody.Location = new System.Drawing.Point(17, 16);
            this.lblTFQbody.Name = "lblTFQbody";
            this.lblTFQbody.Size = new System.Drawing.Size(98, 16);
            this.lblTFQbody.TabIndex = 22;
            this.lblTFQbody.Text = "Question Body:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 30;
            // 
            // richTextBoxTFQbody
            // 
            this.richTextBoxTFQbody.BackColor = System.Drawing.SystemColors.HighlightText;
            this.richTextBoxTFQbody.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxTFQbody.Location = new System.Drawing.Point(6, 34);
            this.richTextBoxTFQbody.Name = "richTextBoxTFQbody";
            this.richTextBoxTFQbody.Size = new System.Drawing.Size(554, 185);
            this.richTextBoxTFQbody.TabIndex = 21;
            this.richTextBoxTFQbody.Text = "";
            // 
            // txtBoxSearchTFQ
            // 
            this.txtBoxSearchTFQ.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtBoxSearchTFQ.Location = new System.Drawing.Point(219, 307);
            this.txtBoxSearchTFQ.Name = "txtBoxSearchTFQ";
            this.txtBoxSearchTFQ.Size = new System.Drawing.Size(39, 22);
            this.txtBoxSearchTFQ.TabIndex = 29;
            // 
            // btnVieqTFQQuestions
            // 
            this.btnVieqTFQQuestions.BackColor = System.Drawing.Color.Snow;
            this.btnVieqTFQQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVieqTFQQuestions.Location = new System.Drawing.Point(411, 358);
            this.btnVieqTFQQuestions.Name = "btnVieqTFQQuestions";
            this.btnVieqTFQQuestions.Size = new System.Drawing.Size(149, 33);
            this.btnVieqTFQQuestions.TabIndex = 23;
            this.btnVieqTFQQuestions.Text = "View Questions";
            this.btnVieqTFQQuestions.UseVisualStyleBackColor = false;
            this.btnVieqTFQQuestions.Click += new System.EventHandler(this.btnVieqTFQQuestions_Click);
            // 
            // btnSearchTFQ
            // 
            this.btnSearchTFQ.BackColor = System.Drawing.Color.Snow;
            this.btnSearchTFQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchTFQ.Location = new System.Drawing.Point(6, 304);
            this.btnSearchTFQ.Name = "btnSearchTFQ";
            this.btnSearchTFQ.Size = new System.Drawing.Size(175, 29);
            this.btnSearchTFQ.TabIndex = 28;
            this.btnSearchTFQ.Text = "Search Question with ID";
            this.btnSearchTFQ.UseVisualStyleBackColor = false;
            this.btnSearchTFQ.Click += new System.EventHandler(this.btnSearchTFQ_Click);
            // 
            // btnTFQNext
            // 
            this.btnTFQNext.BackColor = System.Drawing.Color.Snow;
            this.btnTFQNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTFQNext.Location = new System.Drawing.Point(332, 245);
            this.btnTFQNext.Name = "btnTFQNext";
            this.btnTFQNext.Size = new System.Drawing.Size(78, 37);
            this.btnTFQNext.TabIndex = 24;
            this.btnTFQNext.Text = "Next";
            this.btnTFQNext.UseVisualStyleBackColor = false;
            this.btnTFQNext.Click += new System.EventHandler(this.btnTFQNext_Click);
            // 
            // btnDeleteTFQ
            // 
            this.btnDeleteTFQ.BackColor = System.Drawing.Color.Snow;
            this.btnDeleteTFQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTFQ.Location = new System.Drawing.Point(219, 358);
            this.btnDeleteTFQ.Name = "btnDeleteTFQ";
            this.btnDeleteTFQ.Size = new System.Drawing.Size(157, 33);
            this.btnDeleteTFQ.TabIndex = 27;
            this.btnDeleteTFQ.Text = "Delete Question";
            this.btnDeleteTFQ.UseVisualStyleBackColor = false;
            this.btnDeleteTFQ.Click += new System.EventHandler(this.btnDeleteTFQ_Click);
            // 
            // btnTFQPrevious
            // 
            this.btnTFQPrevious.BackColor = System.Drawing.Color.Snow;
            this.btnTFQPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTFQPrevious.Location = new System.Drawing.Point(219, 245);
            this.btnTFQPrevious.Name = "btnTFQPrevious";
            this.btnTFQPrevious.Size = new System.Drawing.Size(78, 37);
            this.btnTFQPrevious.TabIndex = 25;
            this.btnTFQPrevious.Text = "Previous";
            this.btnTFQPrevious.UseVisualStyleBackColor = false;
            this.btnTFQPrevious.Click += new System.EventHandler(this.btnTFQPrevious_Click);
            // 
            // btnAddTFQ
            // 
            this.btnAddTFQ.BackColor = System.Drawing.Color.Snow;
            this.btnAddTFQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTFQ.Location = new System.Drawing.Point(6, 358);
            this.btnAddTFQ.Name = "btnAddTFQ";
            this.btnAddTFQ.Size = new System.Drawing.Size(175, 33);
            this.btnAddTFQ.TabIndex = 26;
            this.btnAddTFQ.Text = "Add Question";
            this.btnAddTFQ.UseVisualStyleBackColor = false;
            this.btnAddTFQ.Click += new System.EventHandler(this.btnAddTFQ_Click);
            // 
            // rdbtnTFQ
            // 
            this.rdbtnTFQ.AutoSize = true;
            this.rdbtnTFQ.Checked = true;
            this.rdbtnTFQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnTFQ.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rdbtnTFQ.Location = new System.Drawing.Point(473, 124);
            this.rdbtnTFQ.Name = "rdbtnTFQ";
            this.rdbtnTFQ.Size = new System.Drawing.Size(58, 20);
            this.rdbtnTFQ.TabIndex = 9;
            this.rdbtnTFQ.TabStop = true;
            this.rdbtnTFQ.Text = "TFQ";
            this.rdbtnTFQ.UseVisualStyleBackColor = true;
            this.rdbtnTFQ.CheckedChanged += new System.EventHandler(this.rdbtnTFQ_CheckedChanged);
            // 
            // rdbtnMCQ
            // 
            this.rdbtnMCQ.AutoSize = true;
            this.rdbtnMCQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnMCQ.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rdbtnMCQ.Location = new System.Drawing.Point(346, 124);
            this.rdbtnMCQ.Name = "rdbtnMCQ";
            this.rdbtnMCQ.Size = new System.Drawing.Size(61, 20);
            this.rdbtnMCQ.TabIndex = 10;
            this.rdbtnMCQ.Text = "MCQ";
            this.rdbtnMCQ.UseVisualStyleBackColor = true;
            this.rdbtnMCQ.CheckedChanged += new System.EventHandler(this.rdbtnMCQ_CheckedChanged);
            // 
            // frmManageQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.BackgroundImage = global::FrmHome.Properties.Resources.c9cc119b_01d8_416a_8ec6_3409711df3b2_cover_1__2_;
            this.ClientSize = new System.Drawing.Size(879, 707);
            this.Controls.Add(this.rdbtnMCQ);
            this.Controls.Add(this.grpBoxTFQ);
            this.Controls.Add(this.rdbtnTFQ);
            this.Controls.Add(this.grpBoxMCQ);
            this.Controls.Add(this.lblChooseCourse);
            this.Controls.Add(this.comboBoxCourse);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManageQuestions";
            this.Text = "Manage Questions";
            this.Load += new System.EventHandler(this.ManageQuestions_Load);
            this.grpBoxMCQ.ResumeLayout(false);
            this.grpBoxMCQ.PerformLayout();
            this.grpBoxTFQ.ResumeLayout(false);
            this.grpBoxTFQ.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button btnViewMCQQuestions;
        private System.Windows.Forms.Label lblChoices;
        private System.Windows.Forms.Label lblTFQbody;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBoxTFQbody;
        private System.Windows.Forms.TextBox txtBoxSearchTFQ;
        private System.Windows.Forms.Button btnVieqTFQQuestions;
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
    }
}