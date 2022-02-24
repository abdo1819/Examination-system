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

namespace FrmHome
{
    public partial class Admin_ManageCourses : Form
    {
        Login frmLogin;
        Admin_Dashboard frmAdmin;
        List<Entities.getAllStudentsResult> Students;
        List<Entities.getAllInstructorsResult> Instructors;

        public Admin_ManageCourses(Login _frmLogin, Admin_Dashboard _frmAdmin)
        {
            InitializeComponent();
            frmLogin = _frmLogin;
            frmAdmin = _frmAdmin;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            frmAdmin.Show();
        }
        protected override async void OnLoad(EventArgs e)
        {
            lblStdID.Text = frmAdmin.UsrID;
            lblName.Text = frmAdmin.EmpName;
            lblDept.Text = frmAdmin.Dept;
            lblEmail.Text = frmAdmin.Email;
            lblAddress.Text = frmAdmin.Address;
            Students = await frmLogin.Procedures.getAllStudentsAsync(new OutputParameter<int>());
            Instructors = await frmLogin.Procedures.getAllInstructorsAsync(new OutputParameter<int>());
            base.OnLoad(e);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmAdmin.Show();
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            groupActions.Visible = false;
            Admin_AssignStudentToCourse frmAssignCourse = new Admin_AssignStudentToCourse(frmLogin, Students);
            frmAssignCourse.ShowDialog();
            groupActions.Visible = true;
        }

        private void btnEndCourse_Click(object sender, EventArgs e)
        {
            groupActions.Visible = false;
            Admin_EndCourseForStudent frmRemoveCourse = new Admin_EndCourseForStudent(frmLogin, Students);
            frmRemoveCourse.ShowDialog();
            groupActions.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupActions.Visible = false;
            Admin_AddNewCourse frmAddCourse = new Admin_AddNewCourse(frmLogin, Instructors);
            frmAddCourse.ShowDialog();
            groupActions.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupActions.Visible = false;
            Admin_AddTopic frmAddTopic = new Admin_AddTopic(frmLogin);
            frmAddTopic.ShowDialog();
            groupActions.Visible = true;
        }

        private void btnCoursesQuestions_Click(object sender, EventArgs e)
        {
            Admin_FormViewQuestions frmViewQuestions = new Admin_FormViewQuestions(frmLogin);
            groupActions.Visible = false;
            frmViewQuestions.ShowDialog();
            groupActions.Visible = true;
        }
    }
}
