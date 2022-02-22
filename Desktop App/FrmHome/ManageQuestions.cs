using FrmHome.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmHome
{
    public partial class frmManageQuestions : Form
    {
        BindingSource bindingSourceMCQ;
        BindingSource bindingSourceTFQ;
        List<CourseMCQ> MCQList;
        List<CourseTFQ> TFQList;

        bool btnViewMCQuetions_Clicked = false;

        bool btnViewTFQuetions_Clicked = false;

        int C_id = 0;
        public frmManageQuestions()
        {
            InitializeComponent();
        }

        private void ManageQuestions_Load(object sender, EventArgs e)
        {

            ExaminationContext.Course.Load();
            comboBoxCourse.DataSource = ExaminationContext.Course.Local.ToBindingList();
            comboBoxCourse.DisplayMember = "crs_name";
            comboBoxCourse.ValueMember = "crs_id";


        }

        private void btnViewMCQQuestions_Click(object sender, EventArgs e)
        {
            ViewMCQQuestion();
        }

        private void btnMCQNext_Click(object sender, EventArgs e)
        {
            if (!btnViewMCQuetions_Clicked)
                return;

            bindingSourceMCQ.MoveNext();
        }

        private void btnMCQPrevious_Click(object sender, EventArgs e)
        {
            if (!btnViewMCQuetions_Clicked)
                return;

            bindingSourceMCQ.MovePrevious();
        }

        private void btnSearchMCQ_Click(object sender, EventArgs e)
        {
            if (!btnViewMCQuetions_Clicked || txtBoxSearchMCQ.Text == "")
                return;


            //CourseMCQ MyCourseMCQ = new CourseMCQ();

            var result = ExaminationContext.CourseMCQs.FromSqlInterpolated<CourseMCQ>($"Select q.q_id,c.crs_name,T.top_name,q.q_text,m.ch_a,m.ch_b,m.ch_c,m.ch_d,q.corr_answer from Question q, MCQ m, Topic t, Course c where q.q_id = m.q_id and t.top_id = q.top_id and c.crs_id = t.crs_id and c.crs_name = {comboBoxCourse.Text}").ToList();

            if (result.Any(ele => ele.q_id == int.Parse(txtBoxSearchMCQ.Text)))
            {
                lblSearchMCQ.Text = $"Question with this ID {txtBoxSearchMCQ.Text} exists";

                var indx = MCQList.FindIndex(q => q.q_id == int.Parse(txtBoxSearchMCQ.Text));
                bindingSourceMCQ.MoveFirst();
                for(int i = 0; i < indx; i++)
                {
                    bindingSourceMCQ.MoveNext();
                }


            }


            else
                lblSearchMCQ.Text = $"Question with this ID {txtBoxSearchMCQ.Text} doesn't exist";


        }

        private void btnAddMCQ_Click(object sender, EventArgs e)
        {
            if (!btnViewMCQuetions_Clicked)
                return;

            C_id = (int)comboBoxCourse.SelectedValue;

            new frmNewMCQ(C_id).Show();
            refreshQuestion();
        }

        private void btnDeleteMCQ_Click(object sender, EventArgs e)
        {
            if (!btnViewMCQuetions_Clicked)
                return;


            //MCQ MyMcq = (MCQ)bindingSourceMCQ.Current;
            Question cuurentQ = ExaminationContext.Question.Find(int.Parse(lblMCQID.Text));

            int qq = cuurentQ.q_id;
            ExaminationContext.Question.Remove(cuurentQ);

            MCQ currMCQ = ExaminationContext.MCQ.Find(qq);
            ExaminationContext.MCQ.Remove(currMCQ);
            ExaminationContext.SaveChanges();


            refreshQuestion();
        }

        private void btnUpdateMCQ_Click(object sender, EventArgs e)
        {

            if (!btnViewMCQuetions_Clicked)
                return;

            C_id = (int)comboBoxCourse.SelectedValue;


            var q_Text = richTextBoxMCQBody.Text;
            var choose_A = richTextBoxA.Text;
            var choose_B = richTextBoxB.Text;
            var choose_C = richTextBoxC.Text;
            var choose_D = richTextBoxD.Text;

            string Corr_Ans;
            if (txtAnsMCQ.Text.ToLower() != "a" && txtAnsMCQ.Text.ToLower() != "b" && txtAnsMCQ.Text.ToLower() != "c" && txtAnsMCQ.Text.ToLower() != "d")
                Corr_Ans = "A";
            else
                Corr_Ans = txtAnsMCQ.Text;

            var question_ID = int.Parse(lblMCQID.Text);

            //QuestionContext.Question.FromSqlRaw<Question>($"update Question set q_text = {q_text} where q_id = {question_ID}");
            var QQQ = ExaminationContext.Question.Find(question_ID);
            QQQ.q_text = q_Text;
            QQQ.corr_answer = Corr_Ans;

            //QuestionContext.MCQ.FromSqlRaw<MCQ>($"update MCQ set ch_a = {choose_A}, ch_b = {choose_B}, ch_c = {choose_C}, ch_d = {choose_D} where q_id = {question_ID}");
            var qqq = ExaminationContext.MCQ.Find(question_ID);
            qqq.ch_a = choose_A;
            qqq.ch_b = choose_B;
            qqq.ch_c = choose_C;
            qqq.ch_d = choose_D;

            ExaminationContext.SaveChanges();
            MessageBox.Show("update succeeded");

            refreshQuestion();
        }

        private void btnVieqTFQQuestions_Click(object sender, EventArgs e)
        {
            viewTFQquestion();
        }
        void viewTFQquestion()
        {
            btnViewTFQuetions_Clicked = true;


            var result = ExaminationContext.CourseTFQs.FromSqlInterpolated<CourseTFQ>($"Select q.q_id, c.crs_name, T.top_name, q.q_text, q.corr_answer from Question q, Topic t, Course c where t.top_id = q.top_id and c.crs_id = t.crs_id and c.crs_name = {comboBoxCourse.Text} and q.q_type = 'TF'").ToList();

            richTextBoxTFQbody.DataBindings.Clear();
            txtAnsTFQ.DataBindings.Clear();

            lblTFQID.DataBindings.Clear();

            bindingSourceTFQ = new BindingSource(result, "");
            TFQList = result;

            richTextBoxTFQbody.DataBindings.Add("Text", bindingSourceTFQ, "q_text");
            txtAnsTFQ.DataBindings.Add("Text", bindingSourceTFQ, "corr_answer");

            lblTFQID.DataBindings.Add("Text", bindingSourceTFQ, "q_id");


        }
        private void btnTFQNext_Click(object sender, EventArgs e)
        {
            if (!btnViewTFQuetions_Clicked)
                return;

            bindingSourceTFQ.MoveNext();
        }

        private void btnTFQPrevious_Click(object sender, EventArgs e)
        {
            if (!btnViewTFQuetions_Clicked)
                return;

            bindingSourceTFQ.MovePrevious();
        }

        private void btnSearchTFQ_Click(object sender, EventArgs e)
        {
            if (!btnViewTFQuetions_Clicked || txtBoxSearchTFQ.Text == "")
                return;



            var result = ExaminationContext.CourseTFQs.FromSqlInterpolated<CourseTFQ>($"Select q.q_id, c.crs_name, T.top_name, q.q_text, q.corr_answer from Question q, Topic t, Course c where t.top_id = q.top_id and c.crs_id = t.crs_id and c.crs_name = {comboBoxCourse.Text} and q.q_type = 'TF'").ToList();

            if (result.Any(ele => ele.q_id == int.Parse(txtBoxSearchTFQ.Text)))
            {
                lblSearchTFQ.Text = $"Question with this ID {txtBoxSearchTFQ.Text} exists";

                var indx = TFQList.FindIndex(q => q.q_id == int.Parse(txtBoxSearchTFQ.Text));
                bindingSourceTFQ.MoveFirst();
                for (int i = 0; i < indx; i++)
                {
                    bindingSourceTFQ.MoveNext();
                }
            }

            else
                lblSearchTFQ.Text = $"Question with this ID {txtBoxSearchTFQ.Text} doesn't exist";


        }

        private void btnAddTFQ_Click(object sender, EventArgs e)
        {
            if (!btnViewTFQuetions_Clicked)
                return;

            C_id = (int)comboBoxCourse.SelectedValue;

            new frmNewTFQ(C_id).Show();
            refreshQuestion();
        }
        #warning handle disposing
        ExaminationContext ExaminationContext = new ExaminationContext();
        private void btnDeleteTFQ_Click(object sender, EventArgs e)
        {
            if (!btnViewTFQuetions_Clicked)
                return;


            Question cuurentQ = ExaminationContext.Question.Find(int.Parse(lblTFQID.Text));

            ExaminationContext.Question.Remove(cuurentQ);

            ExaminationContext.SaveChanges();


            refreshQuestion();
        }

        private void btnUpdateTFQ_Click(object sender, EventArgs e)
        {

            if (!btnViewTFQuetions_Clicked)
                return;

            C_id = (int)comboBoxCourse.SelectedValue;

            var q_Text = richTextBoxTFQbody.Text;
            var question_ID = int.Parse(lblTFQID.Text);

            string Corr_Ans;

            if (txtAnsTFQ.Text.ToLower() != "t" && txtAnsTFQ.Text.ToLower() != "f")
                Corr_Ans = "F";
            else
                Corr_Ans = txtAnsTFQ.Text;


            var QQQ = ExaminationContext.Question.Find(question_ID);
            QQQ.q_text = q_Text;
            QQQ.corr_answer = Corr_Ans;

            ExaminationContext.SaveChanges();
            refreshQuestion();

        }
        
        private void comboBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshQuestion();
        }
        void refreshQuestion()
        {
            viewTFQquestion();
            ViewMCQQuestion();
        }
        void ViewMCQQuestion()
        {
            btnViewMCQuetions_Clicked = true;


            //CourseMCQ MyCourseMCQ = new CourseMCQ();

            var result = ExaminationContext.CourseMCQs.FromSqlInterpolated<CourseMCQ>($"Select q.q_id,c.crs_name,T.top_name,q.q_text,m.ch_a,m.ch_b,m.ch_c,m.ch_d,q.corr_answer from Question q, MCQ m, Topic t, Course c where q.q_id = m.q_id and t.top_id = q.top_id and c.crs_id = t.crs_id and c.crs_name = {comboBoxCourse.Text}").ToList();

            richTextBoxMCQBody.DataBindings.Clear();
            richTextBoxA.DataBindings.Clear();
            richTextBoxB.DataBindings.Clear();
            richTextBoxC.DataBindings.Clear();
            richTextBoxD.DataBindings.Clear();
            txtAnsMCQ.DataBindings.Clear();
            lblMCQID.DataBindings.Clear();

            bindingSourceMCQ = new BindingSource();
            MCQList = result;
            bindingSourceMCQ.DataSource = result;

            richTextBoxMCQBody.DataBindings.Add("Text", bindingSourceMCQ, "q_text");

            richTextBoxA.DataBindings.Add("Text", bindingSourceMCQ, "ch_a");
            richTextBoxB.DataBindings.Add("Text", bindingSourceMCQ, "ch_b");
            richTextBoxC.DataBindings.Add("Text", bindingSourceMCQ, "ch_c");
            richTextBoxD.DataBindings.Add("Text", bindingSourceMCQ, "ch_d");
            txtAnsMCQ.DataBindings.Add("Text", bindingSourceMCQ, "corr_answer");
            lblMCQID.DataBindings.Add("Text", bindingSourceMCQ, "q_id");


        }
    }
}
