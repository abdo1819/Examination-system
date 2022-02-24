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
        public frmNewTFQ(int c_id)
        {
            InitializeComponent();
            C_id = c_id;
        }

        int C_id;

        private void btnOk_Click(object sender, EventArgs e)
        {
            using (ExaminationContext MyQuestionContext = new ExaminationContext())
            {
                Question MyQuestion = new Question();

                MyQuestion.q_text = richTextBoxText.Text;
                
                if(textBoxAns.Text.ToLower() != "t" && textBoxAns.Text.ToLower() != "f")
                    textBoxAns.Text = "F";

                MyQuestion.corr_answer = textBoxAns.Text;
                MyQuestion.top_id = (int)comboBoxTopic.SelectedValue;
                MyQuestion.q_type = "TF";

                MyQuestionContext.Question.Add(MyQuestion);
                MyQuestionContext.SaveChanges();
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNewTFQ_Load(object sender, EventArgs e)
        {
            using (ExaminationContext MyTopicContext = new ExaminationContext())
            {
                MyTopicContext.Topic.Load();

                comboBoxTopic.DataSource = MyTopicContext.Topic.Where(ele => ele.crs_id == C_id).ToList();
                comboBoxTopic.DisplayMember = "top_name";
                comboBoxTopic.ValueMember = "top_id";

            }
        }
    }
}
