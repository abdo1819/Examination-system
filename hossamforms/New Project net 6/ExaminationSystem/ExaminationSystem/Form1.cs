using BLL;
using System.Diagnostics;

namespace ExaminationSystem
{
    public partial class Form1 : Form
    {
        BindingSource bindingSourceforCourses;
        BindingSource bindingSourceforTFQuestions;
        BindingSource bindingSourceforMCQuestions;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CourseList courses = CourseManager.GetAllCourses();
            bindingSourceforCourses = new BindingSource(courses, "");
            
            cmboxCourses.DataSource = courses;
            cmboxCourses.DisplayMember = "Crs_name";
            cmboxCourses.ValueMember = "Crs_id";

        }

        private void btnViewQuestion_Click(object sender, EventArgs e)
        {

            MCQList mcquestions = MCQManager.viewCourseMCQ(cmboxCourses.Text);
            TFQList tfquestions = TFQManager.viewCourseTFQ(cmboxCourses.Text);
            QuestionList questions = new();

            foreach (var Q in mcquestions)
            {
                questions.Add(QuestionManager.GetQuestionText(Q.Q_id));
            }



            bindingSourceforTFQuestions = new BindingSource();
            bindingSourceforTFQuestions.DataSource = tfquestions;
            grdQuestions.DataSource = bindingSourceforTFQuestions;

            grdQuestions.Columns["Q_type"].Visible = false;
            grdQuestions.Columns["Q_id"].Visible = false;
            grdQuestions.Columns["State"].Visible = false;
            grdQuestions.Columns["Top_id"].Visible = false;

            bindingSourceforMCQuestions = new BindingSource();
            bindingSourceforMCQuestions.DataSource = mcquestions;
            grdQuestions2.DataSource = bindingSourceforMCQuestions;

            grdQuestions2.Columns["Q_type"].Visible = false;
            grdQuestions2.Columns["Top_id"].Visible = false;
            grdQuestions2.Columns["Q_id"].Visible = false;
            grdQuestions2.Columns["Corr_answer"].Visible = false;
            grdQuestions2.Columns["State"].Visible = false;
        }
    }
}