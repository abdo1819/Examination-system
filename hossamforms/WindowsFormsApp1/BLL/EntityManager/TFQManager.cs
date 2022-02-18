using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class TFQManager
    {
        static DBManager dbManager = new();
        
        public static bool insertTFQ(int _top_id, string _q_text, char _corr_answer, int _q_id)
        {
            try
            {
                Dictionary<string, object> parms = new() { ["top_id"] = _top_id, ["q_text"] = _q_text, ["corr_answer"] = _corr_answer, ["q_id"] = _q_id };
                if (dbManager.ExecuteNonQuery("insertTFQ", parms) > 0)
                    return true;

            }
            catch (Exception Ex)
            {

            }
            return false;
        }

        public static bool updateTFQ(int _q_id, int _top_id, string _q_text, char _corr_answer)
        {
            try
            {
                Dictionary<string, object> parms = new() { ["q_id"] = _q_id, ["top_id"] = _top_id, ["q_text"] = _q_text, ["corr_answer"] = _corr_answer };
                if (dbManager.ExecuteNonQuery("updateTFQ", parms) > 0)
                    return true;

            }
            catch (Exception Ex)
            {

            }
            return false;
        }

        public static TFQList viewCourseTFQ(string _crs_name)
        {
            TFQList QuestList = new();
            try
            {
                Dictionary<string, object> parms = new() { ["crs_name"] = _crs_name };
                DataTable QuestionsTable = dbManager.ExecuteDataTable("viewCourseTFQ", parms);

                QuestList = DataTable2TFQestionList(QuestionsTable);

            }
            catch (Exception ex)
            {

            }

            return QuestList;
        }
        internal static TFQList DataTable2TFQestionList(DataTable QuestionsTable)
        {
            TFQList MyQuestions = new();
            try
            {
                for (int i = 0; i < QuestionsTable?.Rows.Count; i++)
                {
                    TFQ Quest = DataRow2TFQ(QuestionsTable.Rows[i]);
                    MyQuestions.Add(Quest);
                }
            }
            catch (Exception ex)
            {

            }

            return MyQuestions;

        }
        internal static TFQ DataRow2TFQ(DataRow Quest)
        {
            TFQ TFQObj = new();

            try
            {
                int Temp = 0;
                char TempCh = 'N';

                if (int.TryParse(Quest["q_id"]?.ToString() ?? "-1", out Temp))
                    TFQObj.Q_id = Temp;


                //TFQObj.Q_type = Quest["q_type"]?.ToString() ?? "N/A";
                TFQObj.Q_text = Quest["q_text"]?.ToString() ?? "N/A";

                if (char.TryParse(Quest["corr_answer"]?.ToString() ?? "N", out TempCh))
                    TFQObj.Corr_answer = TempCh;

                //if (int.TryParse(Quest["top_id"]?.ToString() ?? "-1", out Temp))
                    //TFQObj.Top_id = Temp;


                TFQObj.State = EntityState.Unchanged;

            }
            catch (Exception Ex)
            {

            }

            return TFQObj;
        }

        public static TFQList viewTFQ()
        {
            TFQList QuestList = new();
            try
            {
                DataTable QuestionsTable = dbManager.ExecuteDataTable("viewTFQ");

                QuestList = DataTable2TFQestionList(QuestionsTable);

            }
            catch (Exception ex)
            {

            }

            return QuestList;
        }

        public static TFQList viewTopicTFQ(string _top_name)
        {
            TFQList QuestList = new();
            try
            {
                Dictionary<string, object> parms = new() { ["top_name"] = _top_name };
                DataTable QuestionsTable = dbManager.ExecuteDataTable("viewTopicTFQ", parms);

                QuestList = DataTable2TFQestionList(QuestionsTable);

            }
            catch (Exception ex)
            {

            }

            return QuestList;
        }


    }
}
