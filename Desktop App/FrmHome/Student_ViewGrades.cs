using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
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
    public partial class Student_ViewGrades : Form
    {
        private readonly Login frmLogin;
        public Student_ViewGrades(Login _frmLogin)
        {
            InitializeComponent();
            this.frmLogin = _frmLogin;
            this.Resize += (sender, e) => Invalidate();       
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            
        }
  
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var result = frmLogin.Ctx.Course_Attendance.Where(a => a.std_id == frmLogin.userInfo.usr_id).ToList();

            if (result == null || result?.Count == 0)
            {
                lblNoCourse.Visible = true;
            }
            else
            {
                var Courses = (from C in frmLogin.Ctx.Course
                              join CA in frmLogin.Ctx.Course_Attendance on C.crs_id equals CA.crs_id
                              join Std in frmLogin.Ctx.Student on CA.std_id equals Std.std_id
                              select new { Std.std_id,  CA.crs_id, C.crs_name, CA.grade })
                              .Where(g => g.grade != null).Where(s=>s.std_id == frmLogin.userInfo.usr_id).ToList();

                comboBoxCourses.DataSource = Courses;
                comboBoxCourses.DisplayMember = "crs_name";
                comboBoxCourses.ValueMember = "crs_id";
                lblSelectCourse.Show();
                comboBoxCourses.Show();
            }
            btnShow.Enabled = false;
        }

        private void comboBoxCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lblStdGrade.Visible == false || lblStdGradeValue.Visible == false)
            {
                lblStdGrade.Show();
                lblStdGradeValue.Show();            
            }

            var Courses = (from C in frmLogin.Ctx.Course
                           join CA in frmLogin.Ctx.Course_Attendance on C.crs_id equals CA.crs_id
                           join Std in frmLogin.Ctx.Student on CA.std_id equals Std.std_id
                           select new { Std.std_id, CA.crs_id, C.crs_name, CA.grade })
                           .Where(g => g.grade != null).Where(s => s.std_id == frmLogin.userInfo.usr_id).ToList();

            lblStdGradeValue.Text = $"{Courses[comboBoxCourses.SelectedIndex]?.grade.ToString()} / 10";
            if (Courses[comboBoxCourses.SelectedIndex]?.grade >= 5)
            {
                lblStdGradeValue.ForeColor = Color.SeaGreen;
            }
            else
            {
                lblStdGradeValue.ForeColor = Color.Red;
            }

        }
        
    }
}
