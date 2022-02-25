using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportsForm
{
    public partial class customSelectionUserExam : Form
    {
        public customSelectionUserExam()
        {
            InitializeComponent();
        }
        ExaminationDataSet.getStudentsWhoSolvedExamsDataTable studentDT = new ExaminationDataSet.getStudentsWhoSolvedExamsDataTable();
        ExaminationDataSet.getSolvedExamsForStudentsDataTable examsDT = new ExaminationDataSet.getSolvedExamsForStudentsDataTable();
        private void customSelectionUserExam_Load(object sender, EventArgs e)
        {
            
            ExaminationDataSetTableAdapters.getStudentsWhoSolvedExamsTableAdapter
                getStudentsWhoSolvedExams = new ExaminationDataSetTableAdapters.getStudentsWhoSolvedExamsTableAdapter();
            cmbStudent.DataSource = studentDT;
            studentDT.Columns.Add("fullName", typeof(String), "dept_name+' - '+f_name+' '+l_name");            
            cmbStudent.DisplayMember = "fullName";
            cmbStudent.ValueMember = "usr_id";
            getStudentsWhoSolvedExams.Fill(studentDT);

        }

        private void cmbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = (int)cmbStudent.SelectedValue;
            try
            {
                ExaminationDataSetTableAdapters.getSolvedExamsForStudentsTableAdapter examsAD = new ExaminationDataSetTableAdapters.getSolvedExamsForStudentsTableAdapter();
                examsAD.Fill(examsDT,selected);
                cmbExam.DataSource = examsDT;
                cmbExam.DisplayMember = "ex_id";
                cmbExam.ValueMember = "ex_id";
                //TODO add the course name
            }
            catch 
            {
                Console.WriteLine("error");
            }
            //var selected = (ExaminationDataSet.getStudentsWhoSolvedExamsRow)cmbStudent.SelectedItem;
            //Trace.WriteLine(selected["fullName"]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var exam_id = (int)cmbExam.SelectedValue;
            var usr_id = (int)cmbStudent.SelectedValue;

            
            var frm = new ViewExamForCorrections();
            frm.Exam_id = exam_id;
            frm.Student_id = usr_id;
            frm.Show();
            this.Hide();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
