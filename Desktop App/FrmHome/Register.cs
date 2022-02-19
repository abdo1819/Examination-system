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
    public partial class Register : Form
    {
        private readonly Login frmLogin;

        public Register(Login _frmLogin)
        {
            InitializeComponent();
            this.Resize += (sender, e) => Invalidate();
            frmLogin = _frmLogin;
            frmLogin.Ctx.Student.Load();
            var Depts = frmLogin.Ctx.Department.ToList();
            comboDepts.DataSource = Depts;
            comboDepts.DisplayMember = "dept_name";
            comboDepts.ValueMember = "dept_id";
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            var str = "Enter your data";
            var font = new Font(FontFamily.GenericSansSerif, 10f, FontStyle.Bold);
            var strSize = e.Graphics.MeasureString(str, font);
            e.Graphics.DrawString(str, font, Brushes.DarkBlue, (this.ClientSize.Width - strSize.Width) / 2, 20);
            base.OnPaint(e);
        }

        private void button2_Click(object sender, EventArgs e)
        {     
            this.Close();
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                var std_id = new OutputParameter<int?>();

                var result = new OutputParameter<int>();

                await frmLogin.Procedures.Insert_StudentAsync(txtFname.Text, txtLname.Text, txtAddress.Text,
                   txtEmail.Text, txtPassword.Text, (int?)comboDepts.SelectedValue, std_id, result);

                if (result.Value == 1)
                {
                    MessageBox.Show($"Welcome {txtFname.Text}, your Student ID is {std_id.Value}.", "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Error, please make sure you entered correct data or Email already exists.", "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }

                
            }
            catch
            {
                MessageBox.Show($"Error, please make sure you entered correct data or Email already exists.", "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

     
    }
}
