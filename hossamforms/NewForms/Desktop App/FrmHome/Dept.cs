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
    public partial class frmDept : Form
    {
        BindingSource bindingSource;
        public frmDept()
        {
            InitializeComponent();
        }

        bool btnViewDept_Clicked = false;
        private void btnViewDept_Click(object sender, EventArgs e)
        {
            //if (btnViewDept_Clicked)
            //    return;

            btnViewDept_Clicked = true;

            using (ExaminationContext DeptContext = new ExaminationContext())
            {
                DeptContext.Department.Load();

                var depts = DeptContext.Department.Local.ToBindingList();

                bindingSource = new BindingSource();

                bindingSource.DataSource = depts;

                txtDeptName.DataBindings.Clear();
                txtDeptName.DataBindings.Add("Text", bindingSource, "dept_name");
                
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(btnViewDept_Clicked)
                bindingSource.MoveNext();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (btnViewDept_Clicked)
                bindingSource.MovePrevious();
        }

        private void btnAddDept_Click(object sender, EventArgs e)
        {
            if (!btnViewDept_Clicked)
                return;
            
            using (ExaminationContext DeptContext = new ExaminationContext())
            {
               
                frmNewDept NewDept = new frmNewDept();
                NewDept.Show();
                                
            }
        }

        private void btnDeleteDept_Click(object sender, EventArgs e)
        {
            if (!btnViewDept_Clicked)
                return;

            using (ExaminationContext DeptContext = new ExaminationContext())
            {
                Department cuurentDept = (Department)bindingSource.Current;
                DeptContext.Department.Remove(cuurentDept);
                DeptContext.SaveChanges();

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (ExaminationContext DeptContext = new ExaminationContext())
            {
                var result = (from D in DeptContext.Department
                             where D.dept_name.ToLower() == txtSrchDept.Text.ToLower()
                             select D).ToList();

                if (result.Count > 0)
                   lblExists.Text = $"{txtSrchDept.Text} Department exists";

                else
                    lblExists.Text = $"{txtSrchDept.Text} Department doesn't exist";

            }
        }
    }
}
