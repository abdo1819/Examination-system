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
        ExaminationContext DeptContext;
        public frmDept(ExaminationContext _Ctx)
        {
            InitializeComponent();
            this.DeptContext = _Ctx;
            ReloadDepts();
        }

        private void ReloadDepts()
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

        private void btnNext_Click(object sender, EventArgs e)
        {
            bindingSource.MoveNext();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            bindingSource.MovePrevious();
        }

        private void btnAddDept_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            panel1.Visible = false;
            var NewDept = new frmNewDept(DeptContext);
            if (NewDept.ShowDialog() == DialogResult.OK)
                ReloadDepts();
            this.BackColor = Color.DarkRed;
            panel1.Visible = true;

        }

        private void btnDeleteDept_Click(object sender, EventArgs e)
        {
            Department cuurentDept = (Department)bindingSource.Current;
            DeptContext.Department.Remove(cuurentDept);
            DeptContext.SaveChanges();
            ReloadDepts();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSrchDept.Text == "")
            {
                MessageBox.Show("Please enter a valid Department name.", "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                lblExists.Visible = true;
                var result = (from D in DeptContext.Department
                              select D).ToList();

                var index = result.FindIndex(D => D.dept_name.ToLower() == txtSrchDept.Text.ToLower());
                if (index >= 0)
                {
                    bindingSource.MoveFirst();
                    for (int i = 0; i < index; i++)
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
            var NewDeptName = txtDeptName.Text;
            var OldDept = DeptContext.Department.Find(int.Parse(lblDeptID.Text));

            if (MessageBox.Show($"Are you sure you would like to update Dept No. {lblDeptID.Text} name to {NewDeptName}?", "Confirmation",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                OldDept.dept_name = NewDeptName;
                DeptContext.SaveChanges();
                ReloadDepts();
                MessageBox.Show($"Successfully updated Department name", "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
