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
        List<Entities.getAllInstructorsResult> Instructors;
        public Admin_AddNewCourse(Login _frmLogin, List<Entities.getAllInstructorsResult> _Instructors)
        {
            InitializeComponent();
            frmLogin = _frmLogin;
            Instructors = _Instructors;
        }
        protected override void OnLoad(EventArgs e)
        {
            comboInstructors.DataSource = Instructors;
            comboInstructors.DisplayMember = "usr_id";
            comboInstructors.ValueMember = "usr_id";
            base.OnLoad(e);
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtCrsName.Text == "")
                MessageBox.Show("Please enter a valid course name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    var resultCode = await frmLogin.Procedures.Insert_CourseAsync(txtCrsName.Text, new OutputParameter<int>());
                    if (resultCode == 1)
                    {
                        var insID = ((Entities.getAllInstructorsResult)comboInstructors.SelectedItem).usr_id;
                        await frmLogin.Procedures.Assign_Course_to_InstructorAsync(txtCrsName.Text, insID, new OutputParameter<int>());
                        MessageBox.Show($"Successfully added {txtCrsName.Text} under Instructor No. {insID} to the system.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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
}
