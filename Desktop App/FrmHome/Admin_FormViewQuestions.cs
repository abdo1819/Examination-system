using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmHome
{
    public partial class Admin_FormViewQuestions : Form
    {
        Login frmLogin;
        Entities.Course selectedCourse;
        List<Entities.Topic> topics;
        public Admin_FormViewQuestions(Login _frmLogin)
        {
            InitializeComponent();
            frmLogin = _frmLogin;
        }
        public void ChangeTopic()
        {
            var MCQs = frmLogin.Ctx.Question
                .Where(q => q.q_type == "MCQ" && q.top_id == topics[comboTopics.SelectedIndex].top_id).ToList().Count;
            var TFQs = frmLogin.Ctx.Question
                .Where(q => q.q_type == "TF" && q.top_id == topics[comboTopics.SelectedIndex].top_id).ToList().Count;
            lblTID.Text = topics[comboTopics.SelectedIndex].top_id.ToString();
            lblMCQs.Text = MCQs.ToString();
            lblTFQs.Text = TFQs.ToString();
        }
        protected override void OnLoad(EventArgs e)
        {
            var courses = frmLogin.Ctx.Course.ToList();
            comboCourses.DataSource = courses;
            comboCourses.DisplayMember = "crs_name";
            base.OnLoad(e);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCourse = (Entities.Course)comboCourses.SelectedItem;
            topics = frmLogin.Ctx.Topic.Where(t => t.crs_id == selectedCourse.crs_id).ToList();
            comboTopics.DataSource = topics;
            comboTopics.DisplayMember = "top_name";
            ChangeTopic();
        }

        private void comboTopics_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTID.Text = topics[comboTopics.SelectedIndex].top_id.ToString();
            ChangeTopic();
        }

        private async void btnViewMCQ_Click(object sender, EventArgs e)
        {
            var result = await frmLogin.Procedures.viewTopicMCQAsync(topics[comboTopics.SelectedIndex].top_name, new OutputParameter<int>());
            dataGridQuestions.DataSource = result;
            dataGridQuestions.Columns["Course"].Visible = false;
            dataGridQuestions.Columns["Topic"].Visible = false;
        }

        private async void btnViewTFQ_Click(object sender, EventArgs e)
        {
            var result = await frmLogin.Procedures.viewTopicTFQAsync(topics[comboTopics.SelectedIndex].top_name, new OutputParameter<int>());
            dataGridQuestions.DataSource = result;
            dataGridQuestions.Columns["Course"].Visible = false;
            dataGridQuestions.Columns["Topic"].Visible = false;
        }
    }
}
