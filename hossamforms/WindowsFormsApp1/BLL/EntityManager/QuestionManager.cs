using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.EntityManager
{
    public static class QuestionManager
    {

        static DBManager dbManager = new();

        public static bool deleteQuestion(int _q_id)
        {
            try
            {
                Dictionary<string, object> parms = new() { ["q_id"] = _q_id };
                if (dbManager.ExecuteNonQuery("deleteQuestion", parms) > 0)
                    return true;

            }
            catch (Exception Ex)
            {

            }
            return false;
        }

        public static QuestionList Get_Questions_in_Exam(int _ex_id)
        {
            QuestionList QuesTList = new();
            try
            {
                Dictionary<string, object> parms = new() { ["ex_id"] = _ex_id };
                DataTable QuestionsTable = dbManager.ExecuteDataTable("Get_Questions_in_Exam", parms);

                QuesTList = DataTable2QuestionList(QuestionsTable);

            }
            catch (Exception ex)
            {

            }

            return QuesTList;
        }

        internal static QuestionList DataTable2QuestionList(DataTable QuestionsTable)
        {
            QuestionList MyQuestions = new();
            try
            {
                for (int i = 0; i < QuestionsTable?.Rows.Count; i++)
                {
                    Question Q = DataRow2Question(QuestionsTable.Rows[i]);
                    MyQuestions.Add(Q);
                }
            }
            catch (Exception ex)
            {

            }

            return MyQuestions;

        }
        internal static Question DataRow2Question(DataRow Q)
        {
            Question QuestObj = new();

            try
            {
                int Temp = 0;
                char TempCh = 'N';

                if (int.TryParse(Q["q_id"]?.ToString() ?? "-1", out Temp))
                    QuestObj.Q_id = Temp;

                QuestObj.Q_type = Q["q_type"]?.ToString() ?? "N/A";

                QuestObj.Q_text = Q["q_text"]?.ToString() ?? "N/A";

                if(char.TryParse(Q["corr_answer"]?.ToString() ?? "N", out TempCh))
                    QuestObj.Corr_answer = TempCh;

                if (int.TryParse(Q["top_id"]?.ToString() ?? "-1", out Temp))
                    QuestObj.Top_id = Temp;


                QuestObj.State = EntityState.Unchanged;


            }
            catch (Exception Ex)
            {

            }

            return QuestObj;
        }

        public static QuestionList viewExamQuestions(int _ex_id)
        {
            QuestionList QuestList = new();
            try
            {
                Dictionary<string, object> parms = new() { ["ex_id"] = _ex_id };
                DataTable QuestionsTable = dbManager.ExecuteDataTable("viewExamQuestions", parms);

                QuestList = DataTable2QuestionList(QuestionsTable);

            }
            catch (Exception ex)
            {

            }

            return QuestList;
        }

        public static bool insertQuestion(int _top_id, string _q_type, string _q_text, char _corr_answer, int _q_id)
        {
            try
            {
                Dictionary<string, object> parms = new() { ["top_id"] = _top_id, ["q_type"] = _q_type, ["q_text"] = _q_text, ["corr_answer"] = _corr_answer, ["q_id"] = _q_id };
                if (dbManager.ExecuteNonQuery("insertQuestion", parms) > 0)
                    return true;

            }
            catch (Exception Ex)
            {

            }
            return false;
        }

    }
}
