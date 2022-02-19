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
    public partial class Student_UpdateInfo : Form
    {
        private readonly Login frmLogin;

        public Student_UpdateInfo(Login _frmLogin)
        {
            InitializeComponent();
            this.Resize += (sender, e) => Invalidate();
            frmLogin = _frmLogin;

            //frmLogin.Ctx.Student.Load();


        }
        protected override void OnPaint(PaintEventArgs e)
        {
            var str = "Update your information in the fields below";
            var font = new Font(FontFamily.GenericSansSerif, 10f, FontStyle.Bold);
            var strSize = e.Graphics.MeasureString(str, font);
            e.Graphics.DrawString(str, font, Brushes.DarkBlue, (this.ClientSize.Width - strSize.Width) / 2, 20);
            base.OnPaint(e);
        }

        private void button2_Click(object sender, EventArgs e)
        {     
            this.Close();
        }

        private async void btnInfo_Click(object sender, EventArgs e)
        {

                var result = new OutputParameter<int>();
                await frmLogin.Procedures.updateUserDataAsync(frmLogin.userInfo.usr_id, txtFname.Text, txtLname.Text,
                    txtAddress.Text, txtEmail.Text, txtPassword.Text, result);

            if (result.Value == 1)
            {
                MessageBox.Show($"Your information was updated successfully.", "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error, please make sure you entered correct data or Email already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
