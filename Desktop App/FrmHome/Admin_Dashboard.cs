using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReportsForm;

namespace FrmHome
{
    public partial class Admin_Dashboard : Form
    {
        private readonly Login frmLogin;
        public string Dept { get; set; }
        public string UsrID { get; set; }
        public string EmpName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string DeptID { get; set; }
        public Admin_Dashboard(Login _frmLogin)
        {
            InitializeComponent();
            frmLogin = _frmLogin;
            btnLogout.Click += btnLogout_Click;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            frmLogin.Close();
            if (frmLogin.IsDisposed == false)
                e.Cancel = true;
        }
        public void UpdateUserInfo(string Dept, string UsrID, string Name, string Email, string Address)
        {
            lblDept.Text = Dept;
            lblStdID.Text = UsrID;
            lblName.Text = EmpName;
            lblEmail.Text = Email;
            lblAddress.Text = Address;
            lblDept.Text = Dept;
            DeptID = Dept;
        }
        protected override void OnLoad(EventArgs e)
        {
            Dept = (from D in frmLogin.Ctx.Department
                           join S in frmLogin.Ctx.Student on D.dept_id equals S.dept_id
                           select D.dept_name).FirstOrDefault();
            UsrID = $"{frmLogin.userInfo.usr_id}";
            EmpName = $"{frmLogin.userInfo.f_name} {frmLogin.userInfo.l_name}";
            Email = $"{frmLogin.userInfo.email}";
            Address = $"{frmLogin.userInfo.address}";
            UpdateUserInfo(Dept, UsrID, Name, Email, Address);
            base.OnLoad(e);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            const string message =
            "Are you sure that you would like to logout?";
            const string caption = "Confirmation";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frmLogin.Show();
                this.Hide();
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportsForm.reportsForm frmReports = new reportsForm();
            frmReports.ShowDialog();
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            Admin_ManageCourses frmManageCourses = new Admin_ManageCourses(frmLogin, this);
            frmManageCourses.Show();
            this.Hide();
        }

        private void btnQuestions_Click(object sender, EventArgs e)
        {
            var frm = new frmManageQuestions(this.frmLogin);
            groupActions.Visible = false;
            frm.ShowDialog();
            groupActions.Visible = true;
        }

        private void btnDepts_Click(object sender, EventArgs e)
        {
            var frm = new frmDept();
            frm.Show();
        }

    }
}
