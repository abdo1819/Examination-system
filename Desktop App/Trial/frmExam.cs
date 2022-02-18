using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trial
{
    public partial class frmExam : Form
    {
        public frmExam()
        {
            InitializeComponent();
        }

        public int? Ex_id;
        public int? Std_id;
        public int counter;
        public ExaminationDataSet.Get_Questions_in_ExamDataTable DT;
        public ExaminationDataSet.Exam_AnswerDataTable ExAnsDT;
        public BindingSource Bsourse;
        public BindingSource Bsourse2;
        public BindingSource Bsource3;
        public SqlConnection sqlCN;
        public SqlDataAdapter DA;
        public SqlCommand sqlCMD;
        public Dictionary<string, object> Params = new Dictionary<string, object>();
        public List<RadioButton> radioButtons = new List<RadioButton>();
        public Dictionary<int, string> StdAnswers = new Dictionary<int, string>();


        private void Form1_Load(object sender, EventArgs e)
        {
            
            sqlCN = new SqlConnection("Data Source=.;Initial Catalog=Examination;Integrated Security=True");
            sqlCMD = new SqlCommand();
            sqlCMD.Connection = sqlCN;
            sqlCMD.CommandType = CommandType.StoredProcedure;
            sqlCMD.CommandText = "answerExamQuestion";
            sqlCN.Open();

            radioButtons.Add(rdbtnA);
            radioButtons.Add(rdbtnB);
            radioButtons.Add(rdbtnC);
            radioButtons.Add(rdbtnD);


            DT = new ExaminationDataSet.Get_Questions_in_ExamDataTable();
            ExAnsDT = new ExaminationDataSet.Exam_AnswerDataTable();

            get_Questions_in_ExamTableAdapter1.Fill(DT, Ex_id);
            exam_AnswerTableAdapter1.Fill(ExAnsDT);
            

            Bsourse = new BindingSource(DT, "");
            Bsourse2 = new BindingSource(ExAnsDT, "");
            Bsource3 = new BindingSource(StdAnswers, "");

            lblQuestionText.DataBindings.Add("text", Bsourse, "q_text");
            lblQuestionType.DataBindings.Add("text", Bsourse, "q_type");
            rdbtnA.DataBindings.Add("text", Bsourse, "ch_a");
            rdbtnB.DataBindings.Add("text", Bsourse, "ch_b");
            rdbtnC.DataBindings.Add("text", Bsourse, "ch_c");
            rdbtnD.DataBindings.Add("text", Bsourse, "ch_d");

            lblStdAns.DataBindings.Add("text", Bsourse2, "std_answer");
            lblQID.DataBindings.Add("text", Bsourse2, "q_id");

            counter = 1;
            lblQNum.Text = counter.ToString();

            Params["@ex_id"] = Ex_id;
            Params["@q_id"] = int.Parse(lblQID.Text);


            RadioButtonsClear();
        }
        public void SubmitChanges()
        {
            sqlCMD.Parameters.Clear();
            foreach(var item in StdAnswers)
            {
                sqlCMD.Parameters.Clear();
                sqlCMD.Parameters.Add(new SqlParameter("@q_id", item.Key));
                sqlCMD.Parameters.Add(new SqlParameter("@std_answer", item.Value));
                sqlCMD.Parameters.Add(new SqlParameter("@ex_id", Ex_id));
                sqlCMD.ExecuteNonQuery();
            }
        }
        public void RadioButtonsClear()
        {
            if (lblQuestionType.Text != "MCQ")
            {
                rdbtnA.Text = "True";
                rdbtnA.Tag = 't';
                rdbtnB.Text = "False";
                rdbtnB.Tag = 'f';
                rdbtnC.Visible = false;
                rdbtnD.Visible = false;
            }
            else
            {
                rdbtnA.Tag = 'a';
                rdbtnB.Tag = 'b';
                rdbtnC.Visible = true;
                rdbtnD.Visible = true;
            }
            foreach(var btn in radioButtons)
            {
                btn.Checked = false;
                
            }
            
            foreach(var btn in radioButtons)
            {
                if(StdAnswers.ContainsKey(int.Parse(lblQID.Text)))
                {
                    if (btn.Tag.ToString() == StdAnswers[int.Parse(lblQID.Text)])
                    {
                        btn.Checked = true;
                    }
                }
                else
                {
                    btn.Checked = false;
                }
                
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            foreach (var btn in radioButtons)
            {
                if (btn.Checked)
                {
                    StdAnswers[int.Parse(lblQID.Text)] = btn.Tag.ToString();
                }
            }
            //sqlCMD.Parameters.Clear();
            //foreach(var item in Params)
            //{
            //    sqlCMD.Parameters.AddWithValue(item.Key, item.Value);
            //}
            //sqlCMD.ExecuteNonQuery();
            
            Bsourse.MoveNext();
            Bsourse2.MoveNext();
            counter++;
            if (counter >= 10)
            {
                counter = 10;
            }
            lblQNum.Text = counter.ToString();
            this.RadioButtonsClear();

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            foreach (var btn in radioButtons)
            {
                if (btn.Checked)
                {
                    StdAnswers[int.Parse(lblQID.Text)] = btn.Tag.ToString();
                }
            }

            //sqlCMD.Parameters.Clear();
            //foreach (var item in Params)
            //{
            //    sqlCMD.Parameters.AddWithValue(item.Key, item.Value);
            //}
            //sqlCMD.ExecuteNonQuery();
            
            Bsourse.MovePrevious();
            Bsourse2.MovePrevious();
            counter--;
            if (counter <= 1)
            {
                counter = 1;
                
            }

            lblQNum.Text = counter.ToString();

            this.RadioButtonsClear();

        }

        private void rdbtnA_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (StdAnswers.Keys.Count < 10)
            {
                MessageBox.Show("You didn't answer all the questions!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to sumbit all the answers?", "Info", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SubmitChanges();
                    this.Close();
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            sqlCN.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
