using Microsoft.EntityFrameworkCore;
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
    public partial class Student_Dashboard : Form
    {
        private readonly Login frmLogin;
        public string DeptID { get; set; }
        public Student_Dashboard(Login _frmLogin)
        {
            InitializeComponent();
            this.Resize += (sender, e) => Invalidate();
            this.frmLogin = _frmLogin;
        }
        public void UpdateUserInfo(string Dept, string UsrID, string Name, string Email, string Address )
        {
            lblDept.Text = Dept;
            lblStdID.Text = UsrID;
            lblName.Text = Name;
            lblEmail.Text = Email;
            lblAddress.Text = Address;
            DeptID = Dept;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            var str = "Student Dashboard";
            var font = new Font(FontFamily.GenericSansSerif, 10f, FontStyle.Bold);
            var strSize = e.Graphics.MeasureString(str, font);
            e.Graphics.DrawString(str, font, Brushes.DarkBlue, (this.ClientSize.Width - strSize.Width) / 3, 20);
            base.OnPaint(e);
        }
        protected override void OnLoad(EventArgs e)
        {
            frmLogin.Ctx.Department.Load();
            frmLogin.Ctx.Student.Load();
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
    
        protected override void OnFormClosing(FormClosingEventArgs e)
        {   
             frmLogin.Close();
            if (frmLogin.IsDisposed == false)
                e.Cancel = true;
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

        private void btnGrades_Click(object sender, EventArgs e)
        {
            Student_ViewGrades frmGrades = new Student_ViewGrades(this.frmLogin);
            frmGrades.ShowDialog();
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            Student_UpdateInfo frmUpdateInfo = new Student_UpdateInfo(frmLogin, this);
            frmUpdateInfo.ShowDialog();
        }
    }
}
