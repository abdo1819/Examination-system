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
    public partial class Admin_ManageCourses : Form
    {
        Login frmLogin;
        Admin_Dashboard frmAdmin;
        Entities.Course selectedCourse;
        List<Entities.Topic> topics;
        public Admin_ManageCourses(Login _frmLogin, Admin_Dashboard _frmAdmin)
        {
            frmLogin = _frmLogin;
            frmAdmin = _frmAdmin;
            InitializeComponent();
        }
        public void ChangeTopic()
        {
            var MCQs = frmLogin.Ctx.Question
                .Where(q => q.q_type == "MCQ" && q.top_id == topics[comboTopics.SelectedIndex].top_id).ToList().Count;
            var TFQs = frmLogin.Ctx.Question
                .Where(q => q.q_type == "TF" && q.top_id == topics[comboTopics.SelectedIndex].top_id).ToList().Count;
            lblTName.Text = topics[comboTopics.SelectedIndex].top_name;
            lblMCQs.Text = MCQs.ToString();
            lblTFQs.Text = TFQs.ToString();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            frmLogin.Close();
            if (frmLogin.IsDisposed == false)
                e.Cancel = true;
        }
        protected override void OnLoad(EventArgs e)
        {
            lblStdID.Text = frmAdmin.UsrID;
            lblName.Text = frmAdmin.EmpName;
            lblDept.Text = frmAdmin.Dept;
            lblEmail.Text = frmAdmin.Email;
            lblAddress.Text = frmAdmin.Address;

            var courses = frmLogin.Ctx.Course.ToList();
            comboCourses.DataSource = courses;
            comboCourses.DisplayMember = "crs_name";
            base.OnLoad(e);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmAdmin.Show();
            this.Close();
        }

        private void comboCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCourse = (Entities.Course)comboCourses.SelectedItem;
            topics = frmLogin.Ctx.Topic.Where(t => t.crs_id == selectedCourse.crs_id).ToList();
            comboTopics.DataSource = topics;
            comboTopics.DisplayMember = "top_id";
            ChangeTopic();
        }

        private void comboTopics_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTName.Text = topics[comboTopics.SelectedIndex].top_name;
            ChangeTopic();
        }

        private async void btnViewQuestions_Click(object sender, EventArgs e)
        {
            var result = await frmLogin.Procedures.viewTopicMCQAsync(topics[comboTopics.SelectedIndex].top_name, new OutputParameter<int>());
            dataGridQuestions.DataSource = result;
        }

        private async void btnViewTFQ_Click(object sender, EventArgs e)
        {
            var result = await frmLogin.Procedures.viewTopicTFQAsync(topics[comboTopics.SelectedIndex].top_name, new OutputParameter<int>());
            dataGridQuestions.DataSource = result;
        }
    }
}
