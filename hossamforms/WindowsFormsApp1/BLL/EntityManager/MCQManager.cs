using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.EntityManager
{
    public static class MCQManager
    {
        static DBManager dbManager = new();
        
        public static bool insertMCQ(int _top_id, string _q_text, string _ch_a, string _ch_b, string _ch_c, string _ch_d, char _corr_answer, int _q_id)
        {
            try
            {
                Dictionary<string, object> parms = new() { ["top_id"] = _top_id, ["q_text"] = _q_text, ["ch_a"] = _ch_a, ["ch_b"] = _ch_b, ["ch_c"] = _ch_c, ["ch_d"] = _ch_d, ["corr_answer"] = _corr_answer, ["q_id"] = _q_id };
                if (dbManager.ExecuteNonQuery("insertMCQ", parms) > 0)
                    return true;

            }
            catch (Exception Ex)
            {

            }
            return false;
        }

        public static bool updateMCQ(int _q_id, int _top_id, string _q_text, string _ch_a, string _ch_b, string _ch_c, string _ch_d, char _corr_answer)
        {
            try
            {
                Dictionary<string, object> parms = new() { ["q_id"] = _q_id, ["top_id"] = _top_id, ["q_text"] = _q_text, ["ch_a"] = _ch_a, ["ch_b"] = _ch_b, ["ch_c"] = _ch_c, ["ch_d"] = _ch_d, ["corr_answer"] = _corr_answer };
                if (dbManager.ExecuteNonQuery("updateMCQ", parms) > 0)
                    return true;

            }
            catch (Exception Ex)
            {

            }
            return false;
        }

        public static MCQList viewCourseMCQ(string _crs_name)
        {
            MCQList QuestList = new();
            try
            {
                Dictionary<string, object> parms = new() { ["crs_name"] = _crs_name };
                DataTable QuestionsTable = dbManager.ExecuteDataTable("viewCourseMCQ", parms);

                QuestList = DataTable2MCQestionList(QuestionsTable);

            }
            catch (Exception ex)
            {

            }

            return QuestList;
        }

        internal static MCQList DataTable2MCQestionList(DataTable QuestionsTable)
        {
            MCQList MyQuestions = new();
            try
            {
                for (int i = 0; i < QuestionsTable?.Rows.Count; i++)
                {
                    MCQ Quest = DataRow2MCQ(QuestionsTable.Rows[i]);
                    MyQuestions.Add(Quest);
                }
            }
            catch (Exception ex)
            {

            }

            return MyQuestions;

        }
        internal static MCQ DataRow2MCQ(DataRow Quest)
        {
            MCQ MCQObj = new();

            try
            {
                int Temp = 0;
                char TempCh = 'N';

                if (int.TryParse(Quest["q_id"]?.ToString() ?? "-1", out Temp))
                    MCQObj.Q_id = Temp;

                MCQObj.Q_type = Quest["q_type"]?.ToString() ?? "N/A";
                MCQObj.Q_text = Quest["q_text"]?.ToString() ?? "N/A";

                if (char.TryParse(Quest["corr_answer"]?.ToString() ?? "N", out TempCh))
                    MCQObj.Corr_answer = TempCh;

                if (int.TryParse(Quest["top_id"]?.ToString() ?? "-1", out Temp))
                    MCQObj.Top_id = Temp;

                MCQObj.Ch_a = Quest["ch_a"]?.ToString() ?? "N/A";
                MCQObj.Ch_b = Quest["ch_b"]?.ToString() ?? "N/A";
                MCQObj.Ch_c = Quest["ch_c"]?.ToString() ?? "N/A";
                MCQObj.Ch_d = Quest["ch_d"]?.ToString() ?? "N/A";


                MCQObj.State = EntityState.Unchanged;

            }
            catch (Exception Ex)
            {

            }

            return MCQObj;
        }

        public static MCQList viewMCQ()
        {
            MCQList QuestList = new();
            try
            {
                DataTable QuestionsTable = dbManager.ExecuteDataTable("viewMCQ");

                QuestList = DataTable2MCQestionList(QuestionsTable);

            }
            catch (Exception ex)
            {

            }

            return QuestList;
        }

        public static MCQList viewTopicMCQ(string _top_name)
        {
            MCQList QuestList = new();
            try
            {
                Dictionary<string, object> parms = new() { ["top_name"] = _top_name };
                DataTable QuestionsTable = dbManager.ExecuteDataTable("viewTopicMCQ", parms);

                QuestList = DataTable2MCQestionList(QuestionsTable);

            }
            catch (Exception ex)
            {

            }

            return QuestList;
        }



    }
}
