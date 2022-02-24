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
    public partial class Admin_EndCourseForStudent : Form
    {
        Login frmLogin;
        List<Entities.getAllStudentsResult> Students;
        List<Entities.Course> allCourses;
        public Admin_EndCourseForStudent(Login _frmLogin, List<Entities.getAllStudentsResult> _Students)
        {
            InitializeComponent();
            frmLogin = _frmLogin;
            btnGoBack.Click += btnGoBack_Click;
            btnConfirm.Click += btnConfirm_Click;
            comboStudent.SelectedIndexChanged += comboStudent_SelectedIndexChanged;
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
        private void comboStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelNotEnrolled.Visible = false;
            comboCourse.Visible = true;
            label2.Visible = true;
            var selectedStudent = (Entities.getAllStudentsResult)comboStudent.SelectedItem;
            var selectedStudentID = selectedStudent.usr_id;
            var takenCoursesEntity = frmLogin.Ctx.Course_Attendance.Where(s => s.std_id == selectedStudentID).ToList();
            var takenCourses = new List<Entities.Course>();
            var Course = new Entities.Course();
            for (int i = 0; i < takenCoursesEntity.Count; i++)
            {
                Course = allCourses.Where(c => c.crs_id == takenCoursesEntity[i].crs_id).SingleOrDefault();
                takenCourses.Add(Course);
            }
            if (takenCourses.Count != 0)
            {
                comboCourse.DataSource = takenCourses;
                comboCourse.DisplayMember = "crs_name";
                comboCourse.ValueMember = "crs_id";
            }
            else
            {
                labelNotEnrolled.Visible = true;
                comboCourse.Visible = false;
                label2.Visible = false;
            }

        }
        private async void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                var Student = (Entities.getAllStudentsResult)comboStudent.SelectedItem;
                var stdid = Student.usr_id;
                var crsname = comboCourse.Text;

                if (MessageBox.Show($"You are about to remove Student No. {stdid} from {crsname}, press Ok to confirm", "Student Removal"
                         , MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    var resultCode = await frmLogin.Procedures.End_Course_for_StudentAsync(crsname, stdid, new OutputParameter<int>());
                    if (resultCode == 1)
                        MessageBox.Show($"Successfully removed Student No. {stdid} in {crsname}.", "Student Removal"
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
        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
