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
    public partial class Admin_AssignStudentToCourse : Form
    {
        Login frmLogin;
        List<Entities.getAllStudentsResult> Students;
        List<Entities.Course> allCourses;
        public Admin_AssignStudentToCourse(Login _frmLogin, List<Entities.getAllStudentsResult> _Students)
        {
            InitializeComponent();
            frmLogin = _frmLogin;
            Students = _Students;
        }
        protected override void OnLoad(EventArgs e)
        {

            allCourses = frmLogin.Ctx.Course.ToList();
            comboStudent.DataSource = Students;
            comboStudent.DisplayMember = "usr_id";
            comboStudent.ValueMember = "usr_id";
            base.OnLoad(e);
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedStudent = (Entities.getAllStudentsResult)comboStudent.SelectedItem;
            var selectedStudentID = selectedStudent.usr_id;
            var takenCoursesEntity = frmLogin.Ctx.Course_Attendance.Where(s => s.std_id == selectedStudentID).ToList();
            var availableCourses = new List<Entities.Course>();
            availableCourses.AddRange(allCourses); 
            for (int i = 0; i< takenCoursesEntity.Count; i++)
            {
                availableCourses.RemoveAll(c => c.crs_id == takenCoursesEntity[i].crs_id);
            }
            comboCourse.DataSource = availableCourses;
            comboCourse.DisplayMember = "crs_name";
            comboCourse.ValueMember = "crs_id";
        }

        private void comboCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Course = (Entities.Course)comboCourse.SelectedItem;
            var CourseID = Course.crs_id;
            var InstructorIDs = frmLogin.Ctx.Ins_Course.Where(i => i.crs_id == CourseID).ToList();
            comboInstructor.DataSource = InstructorIDs;
            comboInstructor.ValueMember = "ins_id";
            comboInstructor.DisplayMember = "ins_id";
        }

        private async void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                var Student = (Entities.getAllStudentsResult)comboStudent.SelectedItem;
                var Course = (Entities.Course)comboCourse.SelectedItem;
                var Instructor = (Entities.Ins_Course)comboInstructor.SelectedItem;
                var stdid = Student.usr_id;
                var crsid = Course.crs_id;
                var insid = Instructor.ins_id;
                var crsname = comboCourse.Text;
                if (MessageBox.Show($"You are about to enroll Student No. {stdid} in {crsname} with Instructor No. {insid}, press Ok to confirm", "Student Enrollement"
                         , MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    var resultCode = await frmLogin.Procedures.Student_Take_course_with_InstructorAsync(stdid, crsid, insid, new OutputParameter<int>());
                    if (resultCode == 1)
                        MessageBox.Show($"Successfully enrolled Student No. {stdid} in {crsname} with Instructor No. {insid}", "Student Enrollement"
                            , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("An error occurred, please contact your system's database admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("An error occurred, please contact your system's database admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
