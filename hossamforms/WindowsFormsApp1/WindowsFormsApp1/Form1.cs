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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        DataTable Courses;
        BindingSource bindingSource;
        string ChosenCourse;
        public Form1()
        {
            InitializeComponent();

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'examinationDataSet.viewMCQ' table. You can move, or remove it, as needed.
            this.viewMCQTableAdapter.Fill(this.examinationDataSet.viewMCQ);
            // TODO: This line of code loads data into the 'examinationDataSet.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.examinationDataSet.Course);

        }
    }
}
