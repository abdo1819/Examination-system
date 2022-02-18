using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationSystem
{
    public partial class frmDept : Form
    {
        BindingSource bindingSource;
        DepartmentList Depts;
        public frmDept()
        {

            InitializeComponent();
        }

        private void btnViewDept_Click(object sender, EventArgs e)
        {
            Depts = DepartmentManager.GetAllDepts();
            bindingSource = new BindingSource();
            bindingSource.DataSource = Depts;
            grdDept.DataSource = bindingSource;
            grdDept.Columns["State"].Visible = false;
        }
    }
}
