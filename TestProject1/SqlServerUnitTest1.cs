using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass()]
    public class SqlServerUnitTest1 : SqlDatabaseTestClass
    {

        public SqlServerUnitTest1()
        {
            InitializeComponent();
        }

        [TestInitialize()]
        public void TestInitialize()
        {
            base.InitializeTest();
        }
        [TestCleanup()]
        public void TestCleanup()
        {
            base.CleanupTest();
        }

        #region Designer support code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction PRIVATE_Insert_UserTest_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SqlServerUnitTest1));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction PRIVATE_insertQuestionTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_Assign_Course_to_InstructorTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition3;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_Courses_and_Students_of_InstructorTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition4;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_Delete_CourseTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition5;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_Delete_DepartmentTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition6;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_Delete_TopicTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition7;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_End_Course_for_StudentTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition8;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_End_Course_with_InstructorTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition9;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_Get_Questions_in_ExamTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition10;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_Insert_CourseTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition11;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_Insert_DepartmentTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition12;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_Insert_Department_With_ManagerTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_Insert_InstructorTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition14;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_Insert_StudentTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition15;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_Insert_TopicTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition16;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_Student_Take_course_with_InstructorTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition17;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_Topics_of_CourseTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition18;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_Update_Department_ManagerTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition19;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_deleteExamTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition20;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_deleteInstructorTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition21;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_deleteQuestionTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition22;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_deleteStudentTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition23;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_generateExamTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition24;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_getAllInstructorsTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition25;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_getAllStudentsTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition26;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_getDepartmentTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition27;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_getInstructorsInDepartmentTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition28;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_getStudentAnswerTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition29;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_getStudentsInDepartmentTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition30;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_insertMCQTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition31;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_insertTFQTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition32;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_returnGradesTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition33;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_setCourseNameTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition34;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_setTopicNameTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition35;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_updateInstructorDataTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition36;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_updateMCQTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition37;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_updateStudentDataTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition38;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_updateTFQTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition39;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_updateUserDataTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition40;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_viewCourseMCQTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition41;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_viewCourseTFQTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition42;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_viewExamQuestionsTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition43;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_viewMCQTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition44;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_viewTFQTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition45;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_viewTopicMCQTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition46;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_viewTopicTFQTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition47;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition1;
            this.PRIVATE_Insert_UserTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.PRIVATE_insertQuestionTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_Assign_Course_to_InstructorTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_Courses_and_Students_of_InstructorTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_Delete_CourseTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_Delete_DepartmentTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_Delete_TopicTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_End_Course_for_StudentTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_End_Course_with_InstructorTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_Get_Questions_in_ExamTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_Insert_CourseTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_Insert_DepartmentTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_Insert_Department_With_ManagerTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_Insert_InstructorTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_Insert_StudentTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_Insert_TopicTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_Student_Take_course_with_InstructorTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_Topics_of_CourseTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_Update_Department_ManagerTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_deleteExamTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_deleteInstructorTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_deleteQuestionTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_deleteStudentTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_generateExamTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_getAllInstructorsTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_getAllStudentsTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_getDepartmentTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_getInstructorsInDepartmentTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_getStudentAnswerTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_getStudentsInDepartmentTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_insertMCQTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_insertTFQTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_returnGradesTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_setCourseNameTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_setTopicNameTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_updateInstructorDataTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_updateMCQTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_updateStudentDataTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_updateTFQTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_updateUserDataTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_viewCourseMCQTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_viewCourseTFQTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_viewExamQuestionsTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_viewMCQTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_viewTFQTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_viewTopicMCQTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_viewTopicTFQTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            PRIVATE_Insert_UserTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            PRIVATE_insertQuestionTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            dbo_Assign_Course_to_InstructorTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition3 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            dbo_Courses_and_Students_of_InstructorTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition4 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            dbo_Delete_CourseTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition5 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            dbo_Delete_DepartmentTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition6 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            dbo_Delete_TopicTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition7 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            dbo_End_Course_for_StudentTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition8 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            dbo_End_Course_with_InstructorTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition9 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            dbo_Get_Questions_in_ExamTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition10 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            dbo_Insert_CourseTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition11 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            dbo_Insert_DepartmentTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition12 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            dbo_Insert_Department_With_ManagerTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            dbo_Insert_InstructorTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition14 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            dbo_Insert_StudentTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition15 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            dbo_Insert_TopicTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition16 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            dbo_Student_Take_course_with_InstructorTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition17 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            dbo_Topics_of_CourseTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition18 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            dbo_Update_Department_ManagerTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition19 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            dbo_deleteExamTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition20 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            dbo_deleteInstructorTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition21 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            dbo_deleteQuestionTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition22 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            dbo_deleteStudentTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition23 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            dbo_generateExamTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition24 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            dbo_getAllInstructorsTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition25 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            dbo_getAllStudentsTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition26 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            dbo_getDepartmentTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition27 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            dbo_getInstructorsInDepartmentTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition28 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            dbo_getStudentAnswerTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition29 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            dbo_getStudentsInDepartmentTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition30 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            dbo_insertMCQTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition31 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            dbo_insertTFQTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition32 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            dbo_returnGradesTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition33 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            dbo_setCourseNameTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition34 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            dbo_setTopicNameTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition35 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            dbo_updateInstructorDataTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition36 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            dbo_updateMCQTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition37 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            dbo_updateStudentDataTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition38 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            dbo_updateTFQTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition39 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            dbo_updateUserDataTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition40 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            dbo_viewCourseMCQTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition41 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            dbo_viewCourseTFQTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition42 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            dbo_viewExamQuestionsTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition43 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            dbo_viewMCQTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition44 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            dbo_viewTFQTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition45 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            dbo_viewTopicMCQTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition46 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            dbo_viewTopicTFQTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition47 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            rowCountCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            // 
            // PRIVATE_Insert_UserTest_TestAction
            // 
            PRIVATE_Insert_UserTest_TestAction.Conditions.Add(inconclusiveCondition1);
            resources.ApplyResources(PRIVATE_Insert_UserTest_TestAction, "PRIVATE_Insert_UserTest_TestAction");
            // 
            // inconclusiveCondition1
            // 
            inconclusiveCondition1.Enabled = true;
            inconclusiveCondition1.Name = "inconclusiveCondition1";
            // 
            // PRIVATE_insertQuestionTest_TestAction
            // 
            PRIVATE_insertQuestionTest_TestAction.Conditions.Add(inconclusiveCondition2);
            resources.ApplyResources(PRIVATE_insertQuestionTest_TestAction, "PRIVATE_insertQuestionTest_TestAction");
            // 
            // inconclusiveCondition2
            // 
            inconclusiveCondition2.Enabled = true;
            inconclusiveCondition2.Name = "inconclusiveCondition2";
            // 
            // dbo_Assign_Course_to_InstructorTest_TestAction
            // 
            dbo_Assign_Course_to_InstructorTest_TestAction.Conditions.Add(inconclusiveCondition3);
            resources.ApplyResources(dbo_Assign_Course_to_InstructorTest_TestAction, "dbo_Assign_Course_to_InstructorTest_TestAction");
            // 
            // inconclusiveCondition3
            // 
            inconclusiveCondition3.Enabled = true;
            inconclusiveCondition3.Name = "inconclusiveCondition3";
            // 
            // dbo_Courses_and_Students_of_InstructorTest_TestAction
            // 
            dbo_Courses_and_Students_of_InstructorTest_TestAction.Conditions.Add(inconclusiveCondition4);
            resources.ApplyResources(dbo_Courses_and_Students_of_InstructorTest_TestAction, "dbo_Courses_and_Students_of_InstructorTest_TestAction");
            // 
            // inconclusiveCondition4
            // 
            inconclusiveCondition4.Enabled = true;
            inconclusiveCondition4.Name = "inconclusiveCondition4";
            // 
            // dbo_Delete_CourseTest_TestAction
            // 
            dbo_Delete_CourseTest_TestAction.Conditions.Add(inconclusiveCondition5);
            resources.ApplyResources(dbo_Delete_CourseTest_TestAction, "dbo_Delete_CourseTest_TestAction");
            // 
            // inconclusiveCondition5
            // 
            inconclusiveCondition5.Enabled = true;
            inconclusiveCondition5.Name = "inconclusiveCondition5";
            // 
            // dbo_Delete_DepartmentTest_TestAction
            // 
            dbo_Delete_DepartmentTest_TestAction.Conditions.Add(inconclusiveCondition6);
            resources.ApplyResources(dbo_Delete_DepartmentTest_TestAction, "dbo_Delete_DepartmentTest_TestAction");
            // 
            // inconclusiveCondition6
            // 
            inconclusiveCondition6.Enabled = true;
            inconclusiveCondition6.Name = "inconclusiveCondition6";
            // 
            // dbo_Delete_TopicTest_TestAction
            // 
            dbo_Delete_TopicTest_TestAction.Conditions.Add(inconclusiveCondition7);
            resources.ApplyResources(dbo_Delete_TopicTest_TestAction, "dbo_Delete_TopicTest_TestAction");
            // 
            // inconclusiveCondition7
            // 
            inconclusiveCondition7.Enabled = true;
            inconclusiveCondition7.Name = "inconclusiveCondition7";
            // 
            // dbo_End_Course_for_StudentTest_TestAction
            // 
            dbo_End_Course_for_StudentTest_TestAction.Conditions.Add(inconclusiveCondition8);
            resources.ApplyResources(dbo_End_Course_for_StudentTest_TestAction, "dbo_End_Course_for_StudentTest_TestAction");
            // 
            // inconclusiveCondition8
            // 
            inconclusiveCondition8.Enabled = true;
            inconclusiveCondition8.Name = "inconclusiveCondition8";
            // 
            // dbo_End_Course_with_InstructorTest_TestAction
            // 
            dbo_End_Course_with_InstructorTest_TestAction.Conditions.Add(inconclusiveCondition9);
            resources.ApplyResources(dbo_End_Course_with_InstructorTest_TestAction, "dbo_End_Course_with_InstructorTest_TestAction");
            // 
            // inconclusiveCondition9
            // 
            inconclusiveCondition9.Enabled = true;
            inconclusiveCondition9.Name = "inconclusiveCondition9";
            // 
            // dbo_Get_Questions_in_ExamTest_TestAction
            // 
            dbo_Get_Questions_in_ExamTest_TestAction.Conditions.Add(inconclusiveCondition10);
            resources.ApplyResources(dbo_Get_Questions_in_ExamTest_TestAction, "dbo_Get_Questions_in_ExamTest_TestAction");
            // 
            // inconclusiveCondition10
            // 
            inconclusiveCondition10.Enabled = true;
            inconclusiveCondition10.Name = "inconclusiveCondition10";
            // 
            // dbo_Insert_CourseTest_TestAction
            // 
            dbo_Insert_CourseTest_TestAction.Conditions.Add(inconclusiveCondition11);
            resources.ApplyResources(dbo_Insert_CourseTest_TestAction, "dbo_Insert_CourseTest_TestAction");
            // 
            // inconclusiveCondition11
            // 
            inconclusiveCondition11.Enabled = true;
            inconclusiveCondition11.Name = "inconclusiveCondition11";
            // 
            // dbo_Insert_DepartmentTest_TestAction
            // 
            dbo_Insert_DepartmentTest_TestAction.Conditions.Add(inconclusiveCondition12);
            resources.ApplyResources(dbo_Insert_DepartmentTest_TestAction, "dbo_Insert_DepartmentTest_TestAction");
            // 
            // inconclusiveCondition12
            // 
            inconclusiveCondition12.Enabled = true;
            inconclusiveCondition12.Name = "inconclusiveCondition12";
            // 
            // dbo_Insert_Department_With_ManagerTest_TestAction
            // 
            dbo_Insert_Department_With_ManagerTest_TestAction.Conditions.Add(rowCountCondition1);
            resources.ApplyResources(dbo_Insert_Department_With_ManagerTest_TestAction, "dbo_Insert_Department_With_ManagerTest_TestAction");
            // 
            // dbo_Insert_InstructorTest_TestAction
            // 
            dbo_Insert_InstructorTest_TestAction.Conditions.Add(inconclusiveCondition14);
            resources.ApplyResources(dbo_Insert_InstructorTest_TestAction, "dbo_Insert_InstructorTest_TestAction");
            // 
            // inconclusiveCondition14
            // 
            inconclusiveCondition14.Enabled = true;
            inconclusiveCondition14.Name = "inconclusiveCondition14";
            // 
            // dbo_Insert_StudentTest_TestAction
            // 
            dbo_Insert_StudentTest_TestAction.Conditions.Add(inconclusiveCondition15);
            resources.ApplyResources(dbo_Insert_StudentTest_TestAction, "dbo_Insert_StudentTest_TestAction");
            // 
            // inconclusiveCondition15
            // 
            inconclusiveCondition15.Enabled = true;
            inconclusiveCondition15.Name = "inconclusiveCondition15";
            // 
            // dbo_Insert_TopicTest_TestAction
            // 
            dbo_Insert_TopicTest_TestAction.Conditions.Add(inconclusiveCondition16);
            resources.ApplyResources(dbo_Insert_TopicTest_TestAction, "dbo_Insert_TopicTest_TestAction");
            // 
            // inconclusiveCondition16
            // 
            inconclusiveCondition16.Enabled = true;
            inconclusiveCondition16.Name = "inconclusiveCondition16";
            // 
            // dbo_Student_Take_course_with_InstructorTest_TestAction
            // 
            dbo_Student_Take_course_with_InstructorTest_TestAction.Conditions.Add(inconclusiveCondition17);
            resources.ApplyResources(dbo_Student_Take_course_with_InstructorTest_TestAction, "dbo_Student_Take_course_with_InstructorTest_TestAction");
            // 
            // inconclusiveCondition17
            // 
            inconclusiveCondition17.Enabled = true;
            inconclusiveCondition17.Name = "inconclusiveCondition17";
            // 
            // dbo_Topics_of_CourseTest_TestAction
            // 
            dbo_Topics_of_CourseTest_TestAction.Conditions.Add(inconclusiveCondition18);
            resources.ApplyResources(dbo_Topics_of_CourseTest_TestAction, "dbo_Topics_of_CourseTest_TestAction");
            // 
            // inconclusiveCondition18
            // 
            inconclusiveCondition18.Enabled = true;
            inconclusiveCondition18.Name = "inconclusiveCondition18";
            // 
            // dbo_Update_Department_ManagerTest_TestAction
            // 
            dbo_Update_Department_ManagerTest_TestAction.Conditions.Add(inconclusiveCondition19);
            resources.ApplyResources(dbo_Update_Department_ManagerTest_TestAction, "dbo_Update_Department_ManagerTest_TestAction");
            // 
            // inconclusiveCondition19
            // 
            inconclusiveCondition19.Enabled = true;
            inconclusiveCondition19.Name = "inconclusiveCondition19";
            // 
            // dbo_deleteExamTest_TestAction
            // 
            dbo_deleteExamTest_TestAction.Conditions.Add(inconclusiveCondition20);
            resources.ApplyResources(dbo_deleteExamTest_TestAction, "dbo_deleteExamTest_TestAction");
            // 
            // inconclusiveCondition20
            // 
            inconclusiveCondition20.Enabled = true;
            inconclusiveCondition20.Name = "inconclusiveCondition20";
            // 
            // dbo_deleteInstructorTest_TestAction
            // 
            dbo_deleteInstructorTest_TestAction.Conditions.Add(inconclusiveCondition21);
            resources.ApplyResources(dbo_deleteInstructorTest_TestAction, "dbo_deleteInstructorTest_TestAction");
            // 
            // inconclusiveCondition21
            // 
            inconclusiveCondition21.Enabled = true;
            inconclusiveCondition21.Name = "inconclusiveCondition21";
            // 
            // dbo_deleteQuestionTest_TestAction
            // 
            dbo_deleteQuestionTest_TestAction.Conditions.Add(inconclusiveCondition22);
            resources.ApplyResources(dbo_deleteQuestionTest_TestAction, "dbo_deleteQuestionTest_TestAction");
            // 
            // inconclusiveCondition22
            // 
            inconclusiveCondition22.Enabled = true;
            inconclusiveCondition22.Name = "inconclusiveCondition22";
            // 
            // dbo_deleteStudentTest_TestAction
            // 
            dbo_deleteStudentTest_TestAction.Conditions.Add(inconclusiveCondition23);
            resources.ApplyResources(dbo_deleteStudentTest_TestAction, "dbo_deleteStudentTest_TestAction");
            // 
            // inconclusiveCondition23
            // 
            inconclusiveCondition23.Enabled = true;
            inconclusiveCondition23.Name = "inconclusiveCondition23";
            // 
            // dbo_generateExamTest_TestAction
            // 
            dbo_generateExamTest_TestAction.Conditions.Add(inconclusiveCondition24);
            resources.ApplyResources(dbo_generateExamTest_TestAction, "dbo_generateExamTest_TestAction");
            // 
            // inconclusiveCondition24
            // 
            inconclusiveCondition24.Enabled = true;
            inconclusiveCondition24.Name = "inconclusiveCondition24";
            // 
            // dbo_getAllInstructorsTest_TestAction
            // 
            dbo_getAllInstructorsTest_TestAction.Conditions.Add(inconclusiveCondition25);
            resources.ApplyResources(dbo_getAllInstructorsTest_TestAction, "dbo_getAllInstructorsTest_TestAction");
            // 
            // inconclusiveCondition25
            // 
            inconclusiveCondition25.Enabled = true;
            inconclusiveCondition25.Name = "inconclusiveCondition25";
            // 
            // dbo_getAllStudentsTest_TestAction
            // 
            dbo_getAllStudentsTest_TestAction.Conditions.Add(inconclusiveCondition26);
            resources.ApplyResources(dbo_getAllStudentsTest_TestAction, "dbo_getAllStudentsTest_TestAction");
            // 
            // inconclusiveCondition26
            // 
            inconclusiveCondition26.Enabled = true;
            inconclusiveCondition26.Name = "inconclusiveCondition26";
            // 
            // dbo_getDepartmentTest_TestAction
            // 
            dbo_getDepartmentTest_TestAction.Conditions.Add(inconclusiveCondition27);
            resources.ApplyResources(dbo_getDepartmentTest_TestAction, "dbo_getDepartmentTest_TestAction");
            // 
            // inconclusiveCondition27
            // 
            inconclusiveCondition27.Enabled = true;
            inconclusiveCondition27.Name = "inconclusiveCondition27";
            // 
            // dbo_getInstructorsInDepartmentTest_TestAction
            // 
            dbo_getInstructorsInDepartmentTest_TestAction.Conditions.Add(inconclusiveCondition28);
            resources.ApplyResources(dbo_getInstructorsInDepartmentTest_TestAction, "dbo_getInstructorsInDepartmentTest_TestAction");
            // 
            // inconclusiveCondition28
            // 
            inconclusiveCondition28.Enabled = true;
            inconclusiveCondition28.Name = "inconclusiveCondition28";
            // 
            // dbo_getStudentAnswerTest_TestAction
            // 
            dbo_getStudentAnswerTest_TestAction.Conditions.Add(inconclusiveCondition29);
            resources.ApplyResources(dbo_getStudentAnswerTest_TestAction, "dbo_getStudentAnswerTest_TestAction");
            // 
            // inconclusiveCondition29
            // 
            inconclusiveCondition29.Enabled = true;
            inconclusiveCondition29.Name = "inconclusiveCondition29";
            // 
            // dbo_getStudentsInDepartmentTest_TestAction
            // 
            dbo_getStudentsInDepartmentTest_TestAction.Conditions.Add(inconclusiveCondition30);
            resources.ApplyResources(dbo_getStudentsInDepartmentTest_TestAction, "dbo_getStudentsInDepartmentTest_TestAction");
            // 
            // inconclusiveCondition30
            // 
            inconclusiveCondition30.Enabled = true;
            inconclusiveCondition30.Name = "inconclusiveCondition30";
            // 
            // dbo_insertMCQTest_TestAction
            // 
            dbo_insertMCQTest_TestAction.Conditions.Add(inconclusiveCondition31);
            resources.ApplyResources(dbo_insertMCQTest_TestAction, "dbo_insertMCQTest_TestAction");
            // 
            // inconclusiveCondition31
            // 
            inconclusiveCondition31.Enabled = true;
            inconclusiveCondition31.Name = "inconclusiveCondition31";
            // 
            // dbo_insertTFQTest_TestAction
            // 
            dbo_insertTFQTest_TestAction.Conditions.Add(inconclusiveCondition32);
            resources.ApplyResources(dbo_insertTFQTest_TestAction, "dbo_insertTFQTest_TestAction");
            // 
            // inconclusiveCondition32
            // 
            inconclusiveCondition32.Enabled = true;
            inconclusiveCondition32.Name = "inconclusiveCondition32";
            // 
            // dbo_returnGradesTest_TestAction
            // 
            dbo_returnGradesTest_TestAction.Conditions.Add(inconclusiveCondition33);
            resources.ApplyResources(dbo_returnGradesTest_TestAction, "dbo_returnGradesTest_TestAction");
            // 
            // inconclusiveCondition33
            // 
            inconclusiveCondition33.Enabled = true;
            inconclusiveCondition33.Name = "inconclusiveCondition33";
            // 
            // dbo_setCourseNameTest_TestAction
            // 
            dbo_setCourseNameTest_TestAction.Conditions.Add(inconclusiveCondition34);
            resources.ApplyResources(dbo_setCourseNameTest_TestAction, "dbo_setCourseNameTest_TestAction");
            // 
            // inconclusiveCondition34
            // 
            inconclusiveCondition34.Enabled = true;
            inconclusiveCondition34.Name = "inconclusiveCondition34";
            // 
            // dbo_setTopicNameTest_TestAction
            // 
            dbo_setTopicNameTest_TestAction.Conditions.Add(inconclusiveCondition35);
            resources.ApplyResources(dbo_setTopicNameTest_TestAction, "dbo_setTopicNameTest_TestAction");
            // 
            // inconclusiveCondition35
            // 
            inconclusiveCondition35.Enabled = true;
            inconclusiveCondition35.Name = "inconclusiveCondition35";
            // 
            // dbo_updateInstructorDataTest_TestAction
            // 
            dbo_updateInstructorDataTest_TestAction.Conditions.Add(inconclusiveCondition36);
            resources.ApplyResources(dbo_updateInstructorDataTest_TestAction, "dbo_updateInstructorDataTest_TestAction");
            // 
            // inconclusiveCondition36
            // 
            inconclusiveCondition36.Enabled = true;
            inconclusiveCondition36.Name = "inconclusiveCondition36";
            // 
            // dbo_updateMCQTest_TestAction
            // 
            dbo_updateMCQTest_TestAction.Conditions.Add(inconclusiveCondition37);
            resources.ApplyResources(dbo_updateMCQTest_TestAction, "dbo_updateMCQTest_TestAction");
            // 
            // inconclusiveCondition37
            // 
            inconclusiveCondition37.Enabled = true;
            inconclusiveCondition37.Name = "inconclusiveCondition37";
            // 
            // dbo_updateStudentDataTest_TestAction
            // 
            dbo_updateStudentDataTest_TestAction.Conditions.Add(inconclusiveCondition38);
            resources.ApplyResources(dbo_updateStudentDataTest_TestAction, "dbo_updateStudentDataTest_TestAction");
            // 
            // inconclusiveCondition38
            // 
            inconclusiveCondition38.Enabled = true;
            inconclusiveCondition38.Name = "inconclusiveCondition38";
            // 
            // dbo_updateTFQTest_TestAction
            // 
            dbo_updateTFQTest_TestAction.Conditions.Add(inconclusiveCondition39);
            resources.ApplyResources(dbo_updateTFQTest_TestAction, "dbo_updateTFQTest_TestAction");
            // 
            // inconclusiveCondition39
            // 
            inconclusiveCondition39.Enabled = true;
            inconclusiveCondition39.Name = "inconclusiveCondition39";
            // 
            // dbo_updateUserDataTest_TestAction
            // 
            dbo_updateUserDataTest_TestAction.Conditions.Add(inconclusiveCondition40);
            resources.ApplyResources(dbo_updateUserDataTest_TestAction, "dbo_updateUserDataTest_TestAction");
            // 
            // inconclusiveCondition40
            // 
            inconclusiveCondition40.Enabled = true;
            inconclusiveCondition40.Name = "inconclusiveCondition40";
            // 
            // dbo_viewCourseMCQTest_TestAction
            // 
            dbo_viewCourseMCQTest_TestAction.Conditions.Add(inconclusiveCondition41);
            resources.ApplyResources(dbo_viewCourseMCQTest_TestAction, "dbo_viewCourseMCQTest_TestAction");
            // 
            // inconclusiveCondition41
            // 
            inconclusiveCondition41.Enabled = true;
            inconclusiveCondition41.Name = "inconclusiveCondition41";
            // 
            // dbo_viewCourseTFQTest_TestAction
            // 
            dbo_viewCourseTFQTest_TestAction.Conditions.Add(inconclusiveCondition42);
            resources.ApplyResources(dbo_viewCourseTFQTest_TestAction, "dbo_viewCourseTFQTest_TestAction");
            // 
            // inconclusiveCondition42
            // 
            inconclusiveCondition42.Enabled = true;
            inconclusiveCondition42.Name = "inconclusiveCondition42";
            // 
            // dbo_viewExamQuestionsTest_TestAction
            // 
            dbo_viewExamQuestionsTest_TestAction.Conditions.Add(inconclusiveCondition43);
            resources.ApplyResources(dbo_viewExamQuestionsTest_TestAction, "dbo_viewExamQuestionsTest_TestAction");
            // 
            // inconclusiveCondition43
            // 
            inconclusiveCondition43.Enabled = true;
            inconclusiveCondition43.Name = "inconclusiveCondition43";
            // 
            // dbo_viewMCQTest_TestAction
            // 
            dbo_viewMCQTest_TestAction.Conditions.Add(inconclusiveCondition44);
            resources.ApplyResources(dbo_viewMCQTest_TestAction, "dbo_viewMCQTest_TestAction");
            // 
            // inconclusiveCondition44
            // 
            inconclusiveCondition44.Enabled = true;
            inconclusiveCondition44.Name = "inconclusiveCondition44";
            // 
            // dbo_viewTFQTest_TestAction
            // 
            dbo_viewTFQTest_TestAction.Conditions.Add(inconclusiveCondition45);
            resources.ApplyResources(dbo_viewTFQTest_TestAction, "dbo_viewTFQTest_TestAction");
            // 
            // inconclusiveCondition45
            // 
            inconclusiveCondition45.Enabled = true;
            inconclusiveCondition45.Name = "inconclusiveCondition45";
            // 
            // dbo_viewTopicMCQTest_TestAction
            // 
            dbo_viewTopicMCQTest_TestAction.Conditions.Add(inconclusiveCondition46);
            resources.ApplyResources(dbo_viewTopicMCQTest_TestAction, "dbo_viewTopicMCQTest_TestAction");
            // 
            // inconclusiveCondition46
            // 
            inconclusiveCondition46.Enabled = true;
            inconclusiveCondition46.Name = "inconclusiveCondition46";
            // 
            // dbo_viewTopicTFQTest_TestAction
            // 
            dbo_viewTopicTFQTest_TestAction.Conditions.Add(inconclusiveCondition47);
            resources.ApplyResources(dbo_viewTopicTFQTest_TestAction, "dbo_viewTopicTFQTest_TestAction");
            // 
            // inconclusiveCondition47
            // 
            inconclusiveCondition47.Enabled = true;
            inconclusiveCondition47.Name = "inconclusiveCondition47";
            // 
            // PRIVATE_Insert_UserTestData
            // 
            this.PRIVATE_Insert_UserTestData.PosttestAction = null;
            this.PRIVATE_Insert_UserTestData.PretestAction = null;
            this.PRIVATE_Insert_UserTestData.TestAction = PRIVATE_Insert_UserTest_TestAction;
            // 
            // PRIVATE_insertQuestionTestData
            // 
            this.PRIVATE_insertQuestionTestData.PosttestAction = null;
            this.PRIVATE_insertQuestionTestData.PretestAction = null;
            this.PRIVATE_insertQuestionTestData.TestAction = PRIVATE_insertQuestionTest_TestAction;
            // 
            // dbo_Assign_Course_to_InstructorTestData
            // 
            this.dbo_Assign_Course_to_InstructorTestData.PosttestAction = null;
            this.dbo_Assign_Course_to_InstructorTestData.PretestAction = null;
            this.dbo_Assign_Course_to_InstructorTestData.TestAction = dbo_Assign_Course_to_InstructorTest_TestAction;
            // 
            // dbo_Courses_and_Students_of_InstructorTestData
            // 
            this.dbo_Courses_and_Students_of_InstructorTestData.PosttestAction = null;
            this.dbo_Courses_and_Students_of_InstructorTestData.PretestAction = null;
            this.dbo_Courses_and_Students_of_InstructorTestData.TestAction = dbo_Courses_and_Students_of_InstructorTest_TestAction;
            // 
            // dbo_Delete_CourseTestData
            // 
            this.dbo_Delete_CourseTestData.PosttestAction = null;
            this.dbo_Delete_CourseTestData.PretestAction = null;
            this.dbo_Delete_CourseTestData.TestAction = dbo_Delete_CourseTest_TestAction;
            // 
            // dbo_Delete_DepartmentTestData
            // 
            this.dbo_Delete_DepartmentTestData.PosttestAction = null;
            this.dbo_Delete_DepartmentTestData.PretestAction = null;
            this.dbo_Delete_DepartmentTestData.TestAction = dbo_Delete_DepartmentTest_TestAction;
            // 
            // dbo_Delete_TopicTestData
            // 
            this.dbo_Delete_TopicTestData.PosttestAction = null;
            this.dbo_Delete_TopicTestData.PretestAction = null;
            this.dbo_Delete_TopicTestData.TestAction = dbo_Delete_TopicTest_TestAction;
            // 
            // dbo_End_Course_for_StudentTestData
            // 
            this.dbo_End_Course_for_StudentTestData.PosttestAction = null;
            this.dbo_End_Course_for_StudentTestData.PretestAction = null;
            this.dbo_End_Course_for_StudentTestData.TestAction = dbo_End_Course_for_StudentTest_TestAction;
            // 
            // dbo_End_Course_with_InstructorTestData
            // 
            this.dbo_End_Course_with_InstructorTestData.PosttestAction = null;
            this.dbo_End_Course_with_InstructorTestData.PretestAction = null;
            this.dbo_End_Course_with_InstructorTestData.TestAction = dbo_End_Course_with_InstructorTest_TestAction;
            // 
            // dbo_Get_Questions_in_ExamTestData
            // 
            this.dbo_Get_Questions_in_ExamTestData.PosttestAction = null;
            this.dbo_Get_Questions_in_ExamTestData.PretestAction = null;
            this.dbo_Get_Questions_in_ExamTestData.TestAction = dbo_Get_Questions_in_ExamTest_TestAction;
            // 
            // dbo_Insert_CourseTestData
            // 
            this.dbo_Insert_CourseTestData.PosttestAction = null;
            this.dbo_Insert_CourseTestData.PretestAction = null;
            this.dbo_Insert_CourseTestData.TestAction = dbo_Insert_CourseTest_TestAction;
            // 
            // dbo_Insert_DepartmentTestData
            // 
            this.dbo_Insert_DepartmentTestData.PosttestAction = null;
            this.dbo_Insert_DepartmentTestData.PretestAction = null;
            this.dbo_Insert_DepartmentTestData.TestAction = dbo_Insert_DepartmentTest_TestAction;
            // 
            // dbo_Insert_Department_With_ManagerTestData
            // 
            this.dbo_Insert_Department_With_ManagerTestData.PosttestAction = null;
            this.dbo_Insert_Department_With_ManagerTestData.PretestAction = null;
            this.dbo_Insert_Department_With_ManagerTestData.TestAction = dbo_Insert_Department_With_ManagerTest_TestAction;
            // 
            // dbo_Insert_InstructorTestData
            // 
            this.dbo_Insert_InstructorTestData.PosttestAction = null;
            this.dbo_Insert_InstructorTestData.PretestAction = null;
            this.dbo_Insert_InstructorTestData.TestAction = dbo_Insert_InstructorTest_TestAction;
            // 
            // dbo_Insert_StudentTestData
            // 
            this.dbo_Insert_StudentTestData.PosttestAction = null;
            this.dbo_Insert_StudentTestData.PretestAction = null;
            this.dbo_Insert_StudentTestData.TestAction = dbo_Insert_StudentTest_TestAction;
            // 
            // dbo_Insert_TopicTestData
            // 
            this.dbo_Insert_TopicTestData.PosttestAction = null;
            this.dbo_Insert_TopicTestData.PretestAction = null;
            this.dbo_Insert_TopicTestData.TestAction = dbo_Insert_TopicTest_TestAction;
            // 
            // dbo_Student_Take_course_with_InstructorTestData
            // 
            this.dbo_Student_Take_course_with_InstructorTestData.PosttestAction = null;
            this.dbo_Student_Take_course_with_InstructorTestData.PretestAction = null;
            this.dbo_Student_Take_course_with_InstructorTestData.TestAction = dbo_Student_Take_course_with_InstructorTest_TestAction;
            // 
            // dbo_Topics_of_CourseTestData
            // 
            this.dbo_Topics_of_CourseTestData.PosttestAction = null;
            this.dbo_Topics_of_CourseTestData.PretestAction = null;
            this.dbo_Topics_of_CourseTestData.TestAction = dbo_Topics_of_CourseTest_TestAction;
            // 
            // dbo_Update_Department_ManagerTestData
            // 
            this.dbo_Update_Department_ManagerTestData.PosttestAction = null;
            this.dbo_Update_Department_ManagerTestData.PretestAction = null;
            this.dbo_Update_Department_ManagerTestData.TestAction = dbo_Update_Department_ManagerTest_TestAction;
            // 
            // dbo_deleteExamTestData
            // 
            this.dbo_deleteExamTestData.PosttestAction = null;
            this.dbo_deleteExamTestData.PretestAction = null;
            this.dbo_deleteExamTestData.TestAction = dbo_deleteExamTest_TestAction;
            // 
            // dbo_deleteInstructorTestData
            // 
            this.dbo_deleteInstructorTestData.PosttestAction = null;
            this.dbo_deleteInstructorTestData.PretestAction = null;
            this.dbo_deleteInstructorTestData.TestAction = dbo_deleteInstructorTest_TestAction;
            // 
            // dbo_deleteQuestionTestData
            // 
            this.dbo_deleteQuestionTestData.PosttestAction = null;
            this.dbo_deleteQuestionTestData.PretestAction = null;
            this.dbo_deleteQuestionTestData.TestAction = dbo_deleteQuestionTest_TestAction;
            // 
            // dbo_deleteStudentTestData
            // 
            this.dbo_deleteStudentTestData.PosttestAction = null;
            this.dbo_deleteStudentTestData.PretestAction = null;
            this.dbo_deleteStudentTestData.TestAction = dbo_deleteStudentTest_TestAction;
            // 
            // dbo_generateExamTestData
            // 
            this.dbo_generateExamTestData.PosttestAction = null;
            this.dbo_generateExamTestData.PretestAction = null;
            this.dbo_generateExamTestData.TestAction = dbo_generateExamTest_TestAction;
            // 
            // dbo_getAllInstructorsTestData
            // 
            this.dbo_getAllInstructorsTestData.PosttestAction = null;
            this.dbo_getAllInstructorsTestData.PretestAction = null;
            this.dbo_getAllInstructorsTestData.TestAction = dbo_getAllInstructorsTest_TestAction;
            // 
            // dbo_getAllStudentsTestData
            // 
            this.dbo_getAllStudentsTestData.PosttestAction = null;
            this.dbo_getAllStudentsTestData.PretestAction = null;
            this.dbo_getAllStudentsTestData.TestAction = dbo_getAllStudentsTest_TestAction;
            // 
            // dbo_getDepartmentTestData
            // 
            this.dbo_getDepartmentTestData.PosttestAction = null;
            this.dbo_getDepartmentTestData.PretestAction = null;
            this.dbo_getDepartmentTestData.TestAction = dbo_getDepartmentTest_TestAction;
            // 
            // dbo_getInstructorsInDepartmentTestData
            // 
            this.dbo_getInstructorsInDepartmentTestData.PosttestAction = null;
            this.dbo_getInstructorsInDepartmentTestData.PretestAction = null;
            this.dbo_getInstructorsInDepartmentTestData.TestAction = dbo_getInstructorsInDepartmentTest_TestAction;
            // 
            // dbo_getStudentAnswerTestData
            // 
            this.dbo_getStudentAnswerTestData.PosttestAction = null;
            this.dbo_getStudentAnswerTestData.PretestAction = null;
            this.dbo_getStudentAnswerTestData.TestAction = dbo_getStudentAnswerTest_TestAction;
            // 
            // dbo_getStudentsInDepartmentTestData
            // 
            this.dbo_getStudentsInDepartmentTestData.PosttestAction = null;
            this.dbo_getStudentsInDepartmentTestData.PretestAction = null;
            this.dbo_getStudentsInDepartmentTestData.TestAction = dbo_getStudentsInDepartmentTest_TestAction;
            // 
            // dbo_insertMCQTestData
            // 
            this.dbo_insertMCQTestData.PosttestAction = null;
            this.dbo_insertMCQTestData.PretestAction = null;
            this.dbo_insertMCQTestData.TestAction = dbo_insertMCQTest_TestAction;
            // 
            // dbo_insertTFQTestData
            // 
            this.dbo_insertTFQTestData.PosttestAction = null;
            this.dbo_insertTFQTestData.PretestAction = null;
            this.dbo_insertTFQTestData.TestAction = dbo_insertTFQTest_TestAction;
            // 
            // dbo_returnGradesTestData
            // 
            this.dbo_returnGradesTestData.PosttestAction = null;
            this.dbo_returnGradesTestData.PretestAction = null;
            this.dbo_returnGradesTestData.TestAction = dbo_returnGradesTest_TestAction;
            // 
            // dbo_setCourseNameTestData
            // 
            this.dbo_setCourseNameTestData.PosttestAction = null;
            this.dbo_setCourseNameTestData.PretestAction = null;
            this.dbo_setCourseNameTestData.TestAction = dbo_setCourseNameTest_TestAction;
            // 
            // dbo_setTopicNameTestData
            // 
            this.dbo_setTopicNameTestData.PosttestAction = null;
            this.dbo_setTopicNameTestData.PretestAction = null;
            this.dbo_setTopicNameTestData.TestAction = dbo_setTopicNameTest_TestAction;
            // 
            // dbo_updateInstructorDataTestData
            // 
            this.dbo_updateInstructorDataTestData.PosttestAction = null;
            this.dbo_updateInstructorDataTestData.PretestAction = null;
            this.dbo_updateInstructorDataTestData.TestAction = dbo_updateInstructorDataTest_TestAction;
            // 
            // dbo_updateMCQTestData
            // 
            this.dbo_updateMCQTestData.PosttestAction = null;
            this.dbo_updateMCQTestData.PretestAction = null;
            this.dbo_updateMCQTestData.TestAction = dbo_updateMCQTest_TestAction;
            // 
            // dbo_updateStudentDataTestData
            // 
            this.dbo_updateStudentDataTestData.PosttestAction = null;
            this.dbo_updateStudentDataTestData.PretestAction = null;
            this.dbo_updateStudentDataTestData.TestAction = dbo_updateStudentDataTest_TestAction;
            // 
            // dbo_updateTFQTestData
            // 
            this.dbo_updateTFQTestData.PosttestAction = null;
            this.dbo_updateTFQTestData.PretestAction = null;
            this.dbo_updateTFQTestData.TestAction = dbo_updateTFQTest_TestAction;
            // 
            // dbo_updateUserDataTestData
            // 
            this.dbo_updateUserDataTestData.PosttestAction = null;
            this.dbo_updateUserDataTestData.PretestAction = null;
            this.dbo_updateUserDataTestData.TestAction = dbo_updateUserDataTest_TestAction;
            // 
            // dbo_viewCourseMCQTestData
            // 
            this.dbo_viewCourseMCQTestData.PosttestAction = null;
            this.dbo_viewCourseMCQTestData.PretestAction = null;
            this.dbo_viewCourseMCQTestData.TestAction = dbo_viewCourseMCQTest_TestAction;
            // 
            // dbo_viewCourseTFQTestData
            // 
            this.dbo_viewCourseTFQTestData.PosttestAction = null;
            this.dbo_viewCourseTFQTestData.PretestAction = null;
            this.dbo_viewCourseTFQTestData.TestAction = dbo_viewCourseTFQTest_TestAction;
            // 
            // dbo_viewExamQuestionsTestData
            // 
            this.dbo_viewExamQuestionsTestData.PosttestAction = null;
            this.dbo_viewExamQuestionsTestData.PretestAction = null;
            this.dbo_viewExamQuestionsTestData.TestAction = dbo_viewExamQuestionsTest_TestAction;
            // 
            // dbo_viewMCQTestData
            // 
            this.dbo_viewMCQTestData.PosttestAction = null;
            this.dbo_viewMCQTestData.PretestAction = null;
            this.dbo_viewMCQTestData.TestAction = dbo_viewMCQTest_TestAction;
            // 
            // dbo_viewTFQTestData
            // 
            this.dbo_viewTFQTestData.PosttestAction = null;
            this.dbo_viewTFQTestData.PretestAction = null;
            this.dbo_viewTFQTestData.TestAction = dbo_viewTFQTest_TestAction;
            // 
            // dbo_viewTopicMCQTestData
            // 
            this.dbo_viewTopicMCQTestData.PosttestAction = null;
            this.dbo_viewTopicMCQTestData.PretestAction = null;
            this.dbo_viewTopicMCQTestData.TestAction = dbo_viewTopicMCQTest_TestAction;
            // 
            // dbo_viewTopicTFQTestData
            // 
            this.dbo_viewTopicTFQTestData.PosttestAction = null;
            this.dbo_viewTopicTFQTestData.PretestAction = null;
            this.dbo_viewTopicTFQTestData.TestAction = dbo_viewTopicTFQTest_TestAction;
            // 
            // rowCountCondition1
            // 
            rowCountCondition1.Enabled = true;
            rowCountCondition1.Name = "rowCountCondition1";
            rowCountCondition1.ResultSet = 1;
            rowCountCondition1.RowCount = 1;
        }

        #endregion


        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        #endregion

        [TestMethod()]
        public void PRIVATE_Insert_UserTest()
        {
            SqlDatabaseTestActions testActions = this.PRIVATE_Insert_UserTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void PRIVATE_insertQuestionTest()
        {
            SqlDatabaseTestActions testActions = this.PRIVATE_insertQuestionTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_Assign_Course_to_InstructorTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_Assign_Course_to_InstructorTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_Courses_and_Students_of_InstructorTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_Courses_and_Students_of_InstructorTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_Delete_CourseTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_Delete_CourseTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_Delete_DepartmentTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_Delete_DepartmentTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_Delete_TopicTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_Delete_TopicTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_End_Course_for_StudentTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_End_Course_for_StudentTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_End_Course_with_InstructorTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_End_Course_with_InstructorTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_Get_Questions_in_ExamTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_Get_Questions_in_ExamTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_Insert_CourseTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_Insert_CourseTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_Insert_DepartmentTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_Insert_DepartmentTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_Insert_Department_With_ManagerTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_Insert_Department_With_ManagerTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_Insert_InstructorTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_Insert_InstructorTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_Insert_StudentTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_Insert_StudentTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_Insert_TopicTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_Insert_TopicTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_Student_Take_course_with_InstructorTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_Student_Take_course_with_InstructorTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_Topics_of_CourseTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_Topics_of_CourseTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_Update_Department_ManagerTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_Update_Department_ManagerTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_deleteExamTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_deleteExamTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_deleteInstructorTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_deleteInstructorTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_deleteQuestionTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_deleteQuestionTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_deleteStudentTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_deleteStudentTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_generateExamTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_generateExamTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_getAllInstructorsTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_getAllInstructorsTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_getAllStudentsTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_getAllStudentsTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_getDepartmentTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_getDepartmentTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_getInstructorsInDepartmentTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_getInstructorsInDepartmentTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_getStudentAnswerTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_getStudentAnswerTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_getStudentsInDepartmentTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_getStudentsInDepartmentTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_insertMCQTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_insertMCQTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_insertTFQTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_insertTFQTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_returnGradesTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_returnGradesTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_setCourseNameTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_setCourseNameTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_setTopicNameTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_setTopicNameTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_updateInstructorDataTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_updateInstructorDataTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_updateMCQTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_updateMCQTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_updateStudentDataTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_updateStudentDataTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_updateTFQTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_updateTFQTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_updateUserDataTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_updateUserDataTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_viewCourseMCQTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_viewCourseMCQTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_viewCourseTFQTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_viewCourseTFQTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_viewExamQuestionsTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_viewExamQuestionsTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_viewMCQTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_viewMCQTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_viewTFQTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_viewTFQTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_viewTopicMCQTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_viewTopicMCQTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_viewTopicTFQTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_viewTopicTFQTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        private SqlDatabaseTestActions PRIVATE_Insert_UserTestData;
        private SqlDatabaseTestActions PRIVATE_insertQuestionTestData;
        private SqlDatabaseTestActions dbo_Assign_Course_to_InstructorTestData;
        private SqlDatabaseTestActions dbo_Courses_and_Students_of_InstructorTestData;
        private SqlDatabaseTestActions dbo_Delete_CourseTestData;
        private SqlDatabaseTestActions dbo_Delete_DepartmentTestData;
        private SqlDatabaseTestActions dbo_Delete_TopicTestData;
        private SqlDatabaseTestActions dbo_End_Course_for_StudentTestData;
        private SqlDatabaseTestActions dbo_End_Course_with_InstructorTestData;
        private SqlDatabaseTestActions dbo_Get_Questions_in_ExamTestData;
        private SqlDatabaseTestActions dbo_Insert_CourseTestData;
        private SqlDatabaseTestActions dbo_Insert_DepartmentTestData;
        private SqlDatabaseTestActions dbo_Insert_Department_With_ManagerTestData;
        private SqlDatabaseTestActions dbo_Insert_InstructorTestData;
        private SqlDatabaseTestActions dbo_Insert_StudentTestData;
        private SqlDatabaseTestActions dbo_Insert_TopicTestData;
        private SqlDatabaseTestActions dbo_Student_Take_course_with_InstructorTestData;
        private SqlDatabaseTestActions dbo_Topics_of_CourseTestData;
        private SqlDatabaseTestActions dbo_Update_Department_ManagerTestData;
        private SqlDatabaseTestActions dbo_deleteExamTestData;
        private SqlDatabaseTestActions dbo_deleteInstructorTestData;
        private SqlDatabaseTestActions dbo_deleteQuestionTestData;
        private SqlDatabaseTestActions dbo_deleteStudentTestData;
        private SqlDatabaseTestActions dbo_generateExamTestData;
        private SqlDatabaseTestActions dbo_getAllInstructorsTestData;
        private SqlDatabaseTestActions dbo_getAllStudentsTestData;
        private SqlDatabaseTestActions dbo_getDepartmentTestData;
        private SqlDatabaseTestActions dbo_getInstructorsInDepartmentTestData;
        private SqlDatabaseTestActions dbo_getStudentAnswerTestData;
        private SqlDatabaseTestActions dbo_getStudentsInDepartmentTestData;
        private SqlDatabaseTestActions dbo_insertMCQTestData;
        private SqlDatabaseTestActions dbo_insertTFQTestData;
        private SqlDatabaseTestActions dbo_returnGradesTestData;
        private SqlDatabaseTestActions dbo_setCourseNameTestData;
        private SqlDatabaseTestActions dbo_setTopicNameTestData;
        private SqlDatabaseTestActions dbo_updateInstructorDataTestData;
        private SqlDatabaseTestActions dbo_updateMCQTestData;
        private SqlDatabaseTestActions dbo_updateStudentDataTestData;
        private SqlDatabaseTestActions dbo_updateTFQTestData;
        private SqlDatabaseTestActions dbo_updateUserDataTestData;
        private SqlDatabaseTestActions dbo_viewCourseMCQTestData;
        private SqlDatabaseTestActions dbo_viewCourseTFQTestData;
        private SqlDatabaseTestActions dbo_viewExamQuestionsTestData;
        private SqlDatabaseTestActions dbo_viewMCQTestData;
        private SqlDatabaseTestActions dbo_viewTFQTestData;
        private SqlDatabaseTestActions dbo_viewTopicMCQTestData;
        private SqlDatabaseTestActions dbo_viewTopicTFQTestData;
    }
}
