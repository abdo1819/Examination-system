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
    public partial class customSelectionUserExam : Form
    {
        public customSelectionUserExam()
        {
            InitializeComponent();
        }
        ExaminationDataSet.getStudentsWhoSolvedExamsDataTable studentDT = new ExaminationDataSet.getStudentsWhoSolvedExamsDataTable();
        
        private void customSelectionUserExam_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'examinationDataSet.getAllInstructors' table. You can move, or remove it, as needed.
            this.getAllInstructorsTableAdapter.Fill(this.examinationDataSet.getAllInstructors);
            ExaminationDataSetTableAdapters.getStudentsWhoSolvedExamsTableAdapter
                getStudentsWhoSolvedExams = new ExaminationDataSetTableAdapters.getStudentsWhoSolvedExamsTableAdapter();
            cmbStudent.DataSource = studentDT;
            studentDT.Columns.Add("fullName", typeof(String), "f_name+' '+l_name");
            
            cmbStudent.DisplayMember = "fullName";
            cmbStudent.ValueMember = "user_id";
            Trace.WriteLine(cmbStudent.SelectedItem);

            getStudentsWhoSolvedExams.Fill(studentDT);

            
        }
    }
}
