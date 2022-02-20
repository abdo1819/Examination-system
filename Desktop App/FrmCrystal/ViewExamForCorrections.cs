using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportsForm
{
    public partial class ViewExamForCorrections : Form
    {
        public ViewExamForCorrections()
        {
            InitializeComponent();
        }
        private ExaminationDataSetTableAdapters.GetAllExamAnswersTableAdapter getAllExamStudents;
        private ExaminationDataSet.GetAllExamAnswersDataTable examsStudetns;
        

        private Reports.CrystalReport1 report;
        private void ViewExamForCorrections_Load(object sender, EventArgs e)
        {
            


            //TODO show a dialog to select the student and his exam
            getAllExamStudents = new ExaminationDataSetTableAdapters.GetAllExamAnswersTableAdapter();
            examsStudetns = new ExaminationDataSet.GetAllExamAnswersDataTable();
            getAllExamStudents.Fill(examsStudetns);
                        

            report = new ReportsForm.Reports.CrystalReport1();
            report.SetParameterValue("@stduent_id", 26); 
            report.SetParameterValue("@exam_id", 10);

            crystalReportViewer1.ReportSource = report;
        }
    }
}
