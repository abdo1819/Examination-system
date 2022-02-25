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
    public partial class reportsForm : Form
    {
        public reportsForm(string _Dept, string _UsrID, string _EmpName, string _Email, string _Address)
        {
            InitializeComponent();
            lblDept.Text = _Dept;
            lblUsrID.Text = _UsrID;
            lblName.Text = _EmpName;
            lblEmail.Text = _Email;
            lblAddress.Text = _Address;
        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewExam r = new ViewExam();
            r.ShowDialog();
            //Form1 frm = new Form1();
            //frm.Show();
        }
        ExaminationDataSet.getAllStudentsDataTable dt = new ExaminationDataSet.getAllStudentsDataTable();
        ExaminationDataSet.Insert_StudentDataTable dtIns = new ExaminationDataSet.Insert_StudentDataTable();
        private void Form1_Load(object sender, EventArgs e)
        {

            //getAllStudentsTableAdapter1.Fill(dt);
            //foreach (var row in dt)
            //{
            //    Trace.WriteLine(row.l_name);
            //}
            int? stuId = 0;
            insert_StudentTableAdapter1.Fill(dtIns, "das", "das", "address", "adsf@fssa", "dasda", 100, ref stuId);
            dtIns.AcceptChanges();

            //Trace.WriteLine(stuId);
            //foreach (var row in dtIns)
            //{
            //    Trace.WriteLine(row.);
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CourseTopic topics_report = new CourseTopic();
            topics_report.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            grbDashBoard.Visible = false;
            customSelectionUserExam frm = new customSelectionUserExam();
            frm.ShowDialog();
            grbDashBoard.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            viewStudnetIndepartment frm = new viewStudnetIndepartment();
            frm.ShowDialog();
        }

        private void btnViewGrades_Click(object sender, EventArgs e)
        {
            ViewStudentGrades frmGrades = new ViewStudentGrades();
            frmGrades.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ViewInstructorCourses frmIns = new ViewInstructorCourses();
            frmIns.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
