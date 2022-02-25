using FrmHome.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmHome
{
    public partial class frmNewTFQ : Form
    {
        ExaminationContext ExaminationContext { get; set; }
        public frmNewTFQ(int c_id, ExaminationContext examinationContext)
        {
            InitializeComponent();
            C_id = c_id;
            ExaminationContext = examinationContext;
        }

        int C_id;

        private void btnOk_Click(object sender, EventArgs e)
        {

            Question MyQuestion = new Question();

            MyQuestion.q_text = richTextBoxText.Text;

            if (textBoxAns.Text.ToLower() != "t" && textBoxAns.Text.ToLower() != "f")
                textBoxAns.Text = "F";

            MyQuestion.corr_answer = textBoxAns.Text;
            MyQuestion.top_id = (int)comboBoxTopic.SelectedValue;
            MyQuestion.q_type = "TF";

            ExaminationContext.Question.Add(MyQuestion);
            ExaminationContext.SaveChanges();

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNewTFQ_Load(object sender, EventArgs e)
        {
            ExaminationContext.Topic.Load();
            comboBoxTopic.DataSource = ExaminationContext.Topic.Where(ele => ele.crs_id == C_id).ToList();
            comboBoxTopic.DisplayMember = "top_name";
            comboBoxTopic.ValueMember = "top_id";
        }
    }
}
