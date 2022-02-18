using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ExaminationDataSet.Get_Questions_in_ExamDataTable DT;
        BindingSource Bsourse;
        private void Form1_Load(object sender, EventArgs e)
        {
            DT = new ExaminationDataSet.Get_Questions_in_ExamDataTable();

            get_Questions_in_ExamTableAdapter1.Fill(DT, 40);

            Bsourse = new BindingSource(DT, "");
            
            lblQuestionText.DataBindings.Add("text", Bsourse, "q_text");
            lblQuestionType.DataBindings.Add("text", Bsourse, "q_type");
            rdbtnA.DataBindings.Add("text", Bsourse, "ch_a");
            rdbtnB.DataBindings.Add("text", Bsourse, "ch_b");
            rdbtnC.DataBindings.Add("text", Bsourse, "ch_c");
            rdbtnD.DataBindings.Add("text", Bsourse, "ch_d");

            if (lblQuestionType.Text != "MCQ")
            {
                rdbtnA.Text = "True";
                rdbtnB.Text = "False";
                rdbtnC.Visible = false;
                rdbtnD.Visible = false;
            }
            else
            {
                rdbtnC.Visible = true;
                rdbtnD.Visible = true;
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Bsourse.MoveNext();
            if (lblQuestionType.Text != "MCQ")
            {
                rdbtnA.Text = "True";
                rdbtnB.Text = "False";
                rdbtnC.Visible = false;
                rdbtnD.Visible = false;
            }
            else
            {
                rdbtnC.Visible = true;
                rdbtnD.Visible = true;
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Bsourse.MovePrevious();
            if (lblQuestionType.Text != "MCQ")
            {
                rdbtnA.Text = "True";
                rdbtnB.Text = "False";
                rdbtnC.Visible = false;
                rdbtnD.Visible = false;
            }
            else
            {
                rdbtnC.Visible = true;
                rdbtnD.Visible = true;
            }
        }
    }
}
