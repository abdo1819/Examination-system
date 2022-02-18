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

namespace FrmHome
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewExam r = new ViewExam();
            r.Show();
        }
        ExaminationDataSet.getAllStudentsDataTable dt = new ExaminationDataSet.getAllStudentsDataTable();
        ExaminationDataSet.Insert_StudentDataTable dtIns = new ExaminationDataSet.Insert_StudentDataTable();
        private void Form1_Load(object sender, EventArgs e)
        {

            //getAllStudentsTableAdapter1.Fill(dt);
            //foreach (var row in dt)
            //{
            //    Trace.WriteLine(row.l_name);
            //}
            int? stuId = 0;
            insert_StudentTableAdapter1.Fill(dtIns, "das", "das", "address", "adsf@fssa", "dasda", 100, ref stuId);
            dtIns.AcceptChanges();

            Trace.WriteLine(stuId);
            //foreach (var row in dtIns)
            //{
            //    Trace.WriteLine(row.);
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CourseTopic topics_report = new CourseTopic();
            topics_report.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewExamForCorrections examForCorrections = new ViewExamForCorrections();
            examForCorrections.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            viewStudnetIndepartment frm = new viewStudnetIndepartment();
            frm.Show();
        }
    }
}
