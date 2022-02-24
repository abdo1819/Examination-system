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
    public partial class Admin_AddTopic : Form
    {
        Login frmLogin;
        public Admin_AddTopic(Login _frmLogin)
        {
            InitializeComponent();
            frmLogin = _frmLogin;
        }
        protected override void OnLoad(EventArgs e)
        {
            var courses = frmLogin.Ctx.Course.ToList();
            comboCourses.DataSource = courses;
            comboCourses.DisplayMember = "crs_name";
            comboCourses.ValueMember = "crs_id";
            base.OnLoad(e);
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                var crsName = ((Entities.Course)comboCourses.SelectedItem).crs_name;
                var resultCode = await frmLogin.Procedures.Insert_TopicAsync(txtTopName.Text, crsName, new OutputParameter<int>());
                if (resultCode == 1)
                    MessageBox.Show($"Successfully added {txtTopName.Text} to the {crsName}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("An error occurred, topic already exists under the same course", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            catch
            {
                MessageBox.Show("An error occurred, topic already exists under the same course", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
