using FrmHome.Entities;
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
    public partial class frmNewDept : Form
    {
        ExaminationContext MyDeptContext;
        public frmNewDept(ExaminationContext myDeptContext)
        {
            InitializeComponent();
            MyDeptContext = myDeptContext;
        }
        public string DeptName;
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtDeptName.Text == "")
                MessageBox.Show("Please enter a valid Department name.", "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            else
            {
                Department MyNewDept = new Department();
                MyNewDept.dept_name = txtDeptName.Text;
                MyNewDept.mgr_id = (int)comboBoxMgrID.SelectedValue;

                MyDeptContext.Department.Add(MyNewDept);
                MyDeptContext.SaveChanges();
                MessageBox.Show($"Inserted {txtDeptName.Text} into the system successfully.", "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void frmNewDept_Load(object sender, EventArgs e)
        {
            using (ExaminationContext MyInstructorContext = new ExaminationContext())
            {
                MyInstructorContext.User.Load();

                DeptName = txtDeptName.Text;
                comboBoxMgrID.DataSource = MyInstructorContext.User.Local.Where(U => U.user_type == "I").ToList();
                comboBoxMgrID.DisplayMember = "f_name";
                comboBoxMgrID.ValueMember = "usr_id";

            }
        }
    }
}
