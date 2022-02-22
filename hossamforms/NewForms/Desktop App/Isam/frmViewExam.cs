using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Isam
{
    public partial class frmViewExam : Form
    {
        public frmViewExam()
        {
            InitializeComponent();
        }


        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.get_Questions_in_ExamTableAdapter.Fill(this.examinationDataSet.Get_Questions_in_Exam, new System.Nullable<int>(((int)(System.Convert.ChangeType(ex_idToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
