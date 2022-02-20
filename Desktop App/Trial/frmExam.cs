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
        public frmExam(int? std_id, int?ex_id, string std_name, string dept_name, string instructor_name)
        {
            Ex_id = ex_id;
            Std_id = std_id;
            Std_name = std_name;
            Dept_name = dept_name;
            Instructor_name = instructor_name;
            InitializeComponent();
        }

        public int? Ex_id;
        public int? Std_id;
        public string Std_name;
        public string Dept_name;
        public string Instructor_name;
        public int counter;
        public ExaminationDataSet.Get_Questions_in_ExamDataTable DT;
        public ExaminationDataSet.getQuestionAndStudentAnswerDataTable ExAnsDT;

        public BindingSource Bsourse;
        public BindingSource Bsourse2;
        public BindingSource Bsource3;

        public SqlConnection sqlCN;
        public SqlDataAdapter DA;
        public SqlCommand sqlCMD;
        public List<RadioButton> radioButtons = new List<RadioButton>();
        public Dictionary<int, string> StdAnswers = new Dictionary<int, string>();
        public List<Label> ansLabels = new List<Label>();
        TimeSpan CountDown = new TimeSpan(0, 0, 30);


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

            ansLabels.Add(lblAns1);
            ansLabels.Add(lblAns2);
            ansLabels.Add(lblAns3);
            ansLabels.Add(lblAns4);
            ansLabels.Add(lblAns5);
            ansLabels.Add(lblAns6);
            ansLabels.Add(lblAns7);
            ansLabels.Add(lblAns8);
            ansLabels.Add(lblAns9);
            ansLabels.Add(lblAns10);

            foreach(var item in ansLabels)
            {
                item.Text = "";
            }

            DT = new ExaminationDataSet.Get_Questions_in_ExamDataTable();
            ExAnsDT = new ExaminationDataSet.getQuestionAndStudentAnswerDataTable();


            get_Questions_in_ExamTableAdapter1.Fill(DT, Ex_id);
            getQuestionAndStudentAnswerTableAdapter.Fill(ExAnsDT, Ex_id);
            
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
            lblCourse.DataBindings.Add("text", Bsourse2, "crs_name");
            lblTopic.DataBindings.Add("text", Bsourse2, "top_name");



            lblStdName.Text = this.Std_name;
            lblInstructor.Text = this.Instructor_name;
            lblDepartment.Text = this.Dept_name;
            
            counter = 1;
            lblQNum.Text = counter.ToString();

            RadioButtonsClear();
            lblTimer.Text = CountDown.ToString();
            timer1.Start();
        }
        public void SubmitChanges()
        {
            sqlCMD.Parameters.Clear();
            foreach(var item in StdAnswers)
            {
                sqlCMD.Parameters.Clear();
                sqlCMD.Parameters.Add(new SqlParameter("@ex_id", Ex_id));
                sqlCMD.Parameters.Add(new SqlParameter("@q_id", item.Key));
                sqlCMD.Parameters.Add(new SqlParameter("@std_answer", item.Value));
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
                if (StdAnswers.ContainsKey(int.Parse(lblQID.Text)))
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
        private void btnNext_Click_1(object sender, EventArgs e)
        {
            foreach (var btn in radioButtons)
            {
                if (btn.Checked)
                {
                    StdAnswers[int.Parse(lblQID.Text)] = btn.Tag.ToString();
                    ansLabels[counter-1].Text = btn.Tag.ToString().ToUpper();
                }
            }
            
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

        private void btnPrevious_Click_1(object sender, EventArgs e)
        {
            foreach (var btn in radioButtons)
            {
                if (btn.Checked)
                {
                    StdAnswers[int.Parse(lblQID.Text)] = btn.Tag.ToString();
                    ansLabels[counter-1].Text = btn.Tag.ToString().ToUpper();
                }
            }
            
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
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to submit all the answers?", "Info", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    timer1.Stop();
                    MessageBox.Show("Answers submitted successfuly", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
            SubmitChanges();
            sqlCN.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            
            if(CountDown == TimeSpan.Zero)
            {
                timer1.Stop();
                MessageBox.Show("Time's up! We hope you finished answering all the questions correctly!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                CountDown -= TimeSpan.FromSeconds(1);
                lblTimer.Text = CountDown.ToString();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmExam_SizeChanged(object sender, EventArgs e)
        {
            CenterControlInParent(groupBox3);
            CenterControlInParent(groupBox4);

        }
        private void CenterControlInParent(Control ctrlToCenter)
        {
            ctrlToCenter.Left = (ctrlToCenter.Parent.Width - ctrlToCenter.Width) / 2;
            ctrlToCenter.Top = (ctrlToCenter.Parent.Height - ctrlToCenter.Height) / 2;
        }
    }
}
