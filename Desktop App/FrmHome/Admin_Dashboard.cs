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
    public partial class Admin_Dashboard : Form
    {
        private readonly Login frmLogin;
        public string DeptID { get; set; }
        public Admin_Dashboard(Login _frmLogin)
        {
            InitializeComponent();
            frmLogin = _frmLogin;
        }
        public void UpdateUserInfo(string Dept, string UsrID, string Name, string Email, string Address)
        {
            lblDept.Text = Dept;
            lblStdID.Text = UsrID;
            lblName.Text = Name;
            lblEmail.Text = Email;
            lblAddress.Text = Address;
            lblDept.Text = Dept;
            DeptID = Dept;
        }
        protected override void OnLoad(EventArgs e)
        {
            string Dept = (from D in frmLogin.Ctx.Department
                           join S in frmLogin.Ctx.Student on D.dept_id equals S.dept_id
                           select D.dept_name).FirstOrDefault();
            string UsrID = $"{frmLogin.userInfo.usr_id}";
            string Name = $"{frmLogin.userInfo.f_name} {frmLogin.userInfo.l_name}";
            string Email = $"{frmLogin.userInfo.email}";
            string Address = $"{frmLogin.userInfo.address}";
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
           // Form1 frmReports = new Form1();
            // frmReports.ShowDialog();
            // There is an issue with opening this form
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {

        }
    }
}
