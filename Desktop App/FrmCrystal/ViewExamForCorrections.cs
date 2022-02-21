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

        public int Exam_id { get; set;}
        public int Student_id { get; set; }
        private Reports.ViewExamWithAnswers report;
        private void ViewExamForCorrections_Load(object sender, EventArgs e)
        {
            report = new Reports.ViewExamWithAnswers();
            report.SetParameterValue("@stduent_id", Student_id); 
            report.SetParameterValue("@exam_id", Exam_id);

            crystalReportViewer1.ReportSource = report;
        }
    }
}
