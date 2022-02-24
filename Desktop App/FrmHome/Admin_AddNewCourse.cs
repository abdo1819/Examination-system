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
    public partial class Admin_AddNewCourse : Form
    {
        Login frmLogin;
        public Admin_AddNewCourse(Login _frmLogin)
        {
            InitializeComponent();
            frmLogin = _frmLogin;
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                var resultCode = await frmLogin.Procedures.Insert_CourseAsync(txtCrsName.Text, new OutputParameter<int>());
                if (resultCode == 1)
                    MessageBox.Show($"Successfully added {txtCrsName.Text} to the system.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("An error occurred, course already exists on the system", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            catch
            {
                MessageBox.Show("An error occurred, course already exists on the system", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }                   
        }
    }
}
