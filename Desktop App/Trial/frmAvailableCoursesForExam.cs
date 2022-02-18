using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trial
{
    public partial class frmAvailableCoursesForExam : Form
    {
        public frmAvailableCoursesForExam()
        {
            InitializeComponent();
            Std_id = 32;
        }

        public int? Std_id;
        public string crs_name;
        public int? Ex_id;
        ExaminationDataSet.getAvailableCoursesForExamDataTable DT;
        ExaminationDataSet.generateExamDataTable DTExam;
        public SqlConnection sqlCN;
        public SqlDataAdapter DA;
        public SqlCommand sqlCMD;

        private void frmAvailableCoursesForExam_Load(object sender, EventArgs e)
        {
            DT = new ExaminationDataSet.getAvailableCoursesForExamDataTable();
            DTExam = new ExaminationDataSet.generateExamDataTable();

            getAvailableCoursesForExamTableAdapter.Fill(DT, Std_id);
            
            cmbAvailableCourses.DataSource = DT;
            cmbAvailableCourses.DisplayMember = "crs_name";
            cmbAvailableCourses.ValueMember = "crs_name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            crs_name = cmbAvailableCourses.Text;

            if (crs_name.Length < 1)
            {
                DialogResult dialogResult = MessageBox.Show("There is no available courses for you, please call your instructor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if(dialogResult == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                generateExamTableAdapter1.Fill(DTExam, crs_name, Std_id, ref this.Ex_id);

                frmExam frmExam = new frmExam();
                frmExam.Ex_id = Ex_id;
                frmExam.Std_id = Std_id;

                frmExam.ShowDialog();
                this.Close();
            }
        }
    }
}
