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

            btnViewDept_Clicked = true;

            ReloadDepts();
        }

        private void ReloadDepts()
        {
            using (ExaminationContext DeptContext = new ExaminationContext())
            {
                DeptContext.Department.Load();

                var depts = DeptContext.Department.Local.ToBindingList();

                bindingSource = new BindingSource();

                bindingSource.DataSource = depts;

                txtDeptName.DataBindings.Clear();
                lblDeptID.DataBindings.Clear();

                txtDeptName.DataBindings.Add("Text", bindingSource, "dept_name");
                lblDeptID.DataBindings.Add("Text", bindingSource, "dept_id");
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
               
                var NewDept = new frmNewDept();
                
                if(NewDept.ShowDialog() == DialogResult.OK)
                    ReloadDepts();
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
            ReloadDepts();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSrchDept.Text == "")
                return;

            using (ExaminationContext DeptContext = new ExaminationContext())
            {
                var result = (from D in DeptContext.Department
                             select D).ToList();

                var index = result.FindIndex(D => D.dept_name.ToLower() == txtSrchDept.Text.ToLower());
                if (index > 0)
                {
                    bindingSource.MoveFirst();
                    for(int i = 0; i < index; i++)
                    {
                        bindingSource.MoveNext();
                    }
                    lblExists.Text = $"{txtSrchDept.Text} Department exists";
                }

                else
                    lblExists.Text = $"{txtSrchDept.Text} Department doesn't exist";

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using(ExaminationContext DeptContext = new ExaminationContext())
            {

                var NewDeptName = txtDeptName.Text;
                var OldDept = DeptContext.Department.Find(int.Parse(lblDeptID.Text));

                OldDept.dept_name = NewDeptName;
                DeptContext.SaveChanges();
           
            }
            ReloadDepts();
        }
    }
}
