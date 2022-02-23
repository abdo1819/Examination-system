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
    public partial class frmNewMCQ : Form
    {
        public frmNewMCQ(int c_id)
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
                MCQ MyMCQ = new MCQ();

                MyQuestion.q_text = richTextBoxText.Text;

                if (textBoxAns.Text.ToLower() != "a" && textBoxAns.Text.ToLower() != "b" && textBoxAns.Text.ToLower() != "c" && textBoxAns.Text.ToLower() != "d")
                    textBoxAns.Text = "A";

                MyQuestion.corr_answer = textBoxAns.Text;
                MyQuestion.top_id = (int)comboBoxTopic.SelectedValue;
                MyQuestion.q_type = "MCQ";

                MyMCQ.ch_a = textBoxA.Text;
                MyMCQ.ch_b = textBoxB.Text;
                MyMCQ.ch_c = textBoxC.Text;
                MyMCQ.ch_d = textBoxD.Text;

                MyQuestionContext.Question.Add(MyQuestion);
                MyQuestionContext.SaveChanges();

                var R = (from Q in MyQuestionContext.Question
                        select Q).ToList();

                //MyQuestionContext.MCQ.FromSqlInterpolated($"INSERT INTO Question(q_type, q_text, corr_answer, top_id) VALUES('MCQ', {MyQuestion.q_text}, {MyQuestion.corr_answer}, {MyQuestion.top_id}) INSERT INTO MCQ(q_id, ch_a, ch_b, ch_c, ch_d) VALUES({@q_id}, {textBoxA.Text}, {textBoxB.Text}, {textBoxC.Text}, {textBoxD.Text})");

                MyMCQ.q_id = R.LastOrDefault().q_id;

                MyQuestionContext.MCQ.Add(MyMCQ);
                MyQuestionContext.SaveChanges();

            }
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void frmNewMCQ_Load(object sender, EventArgs e)
        {
            using (ExaminationContext MyTopicContext = new ExaminationContext())
            {
                MyTopicContext.Topic.Load();

                comboBoxTopic.DataSource = MyTopicContext.Topic.Where(ele => ele.crs_id == C_id).ToList();
                comboBoxTopic.DisplayMember = "top_name";
                comboBoxTopic.ValueMember = "top_id";

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
