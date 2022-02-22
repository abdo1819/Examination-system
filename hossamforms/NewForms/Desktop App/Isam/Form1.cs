using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Isam
{
    public partial class frmStudent : Form
    {
        int? EXID;
        public frmStudent()
        {
            InitializeComponent();
        }
        frmViewExam frmViewExam;
        private void btnGenerateExam_Click(object sender, EventArgs e)
        {
            
            this.Text = EXID.ToString();

            ExaminationDataSet1.generateExamDataTable DT = new ExaminationDataSet1.generateExamDataTable();
            generateExamTableAdapter1.Fill(DT, txtCourseID.Text, int.Parse(txtStudenID.Text), ref EXID);
            DT.AcceptChanges();
            frmViewExam = new frmViewExam();
            
            this.Text = EXID.ToString();
            frmViewExam.Show();
        }

        
    }
}
