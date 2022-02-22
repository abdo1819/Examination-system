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
        List<Department> departments;
        public frmNewDept()
        {
            InitializeComponent();


        }
        public string DeptName;
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            using (ExaminationContext MyDeptContext = new ExaminationContext())
            {
                Department MyNewDept = new Department();
                MyNewDept.dept_name = txtDeptName.Text;
                MyNewDept.mgr_id = (int)comboBoxMgrID.SelectedValue;

                MyDeptContext.Department.Add(MyNewDept);
                MyDeptContext.SaveChanges();
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void frmNewDept_Load(object sender, EventArgs e)
        {
            using (ExaminationContext MyInstructorContext = new ExaminationContext())
            {
                MyInstructorContext.User.Load();

                //departments = MyDeptContext.Department.Local.ToList();

                DeptName = txtDeptName.Text;
                comboBoxMgrID.DataSource = MyInstructorContext.User.Local.Where(U => U.user_type == "I").ToList();
                comboBoxMgrID.DisplayMember = "f_name";
                comboBoxMgrID.ValueMember = "usr_id";

            }
        }
    }
}
