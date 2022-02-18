using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class TopicManager
    {
        static DBManager dbManager = new();

        public static bool Delete_Topic(string _top_name)
        {
            try
            {
                Dictionary<string, object> parms = new() { ["top_name"] = _top_name };
                if (dbManager.ExecuteNonQuery("Delete_Topic", parms) > 0)
                    return true;

            }
            catch (Exception Ex)
            {

            }
            return false;
        }

        public static bool Insert_Topic(string _top_name, string _crs_name)
        {
            try
            {
                Dictionary<string, object> parms = new() { ["top_name"] = _top_name, ["crs_name"] = _crs_name };
                if (dbManager.ExecuteNonQuery("Insert_Topic", parms) > 0)
                    return true;

            }
            catch (Exception Ex)
            {

            }
            return false;
        }

        public static bool setTopicName(int _top_id, string _top_name)
        {
            try
            {
                Dictionary<string, object> parms = new() { ["top_id"] = _top_id, ["top_name"] = _top_name };
                if (dbManager.ExecuteNonQuery("setTopicName", parms) > 0)
                    return true;

            }
            catch (Exception Ex)
            {

            }
            return false;
        }

        public static TopicList Topics_of_Course(string _crs_name)
        {
            TopicList TopList = new();
            try
            {
                Dictionary<string, object> parms = new() { ["crs_name"] = _crs_name };
                DataTable TopicsTable = dbManager.ExecuteDataTable("Topics_of_Course", parms);

                TopList = DataTable2TopicList(TopicsTable);

            }
            catch (Exception ex)
            {

            }

            return TopList;
        }

        internal static TopicList DataTable2TopicList(DataTable TopicsTable)
        {
            TopicList MyTopics = new();
            try
            {
                for (int i = 0; i < TopicsTable?.Rows.Count; i++)
                {
                    Topic T = DataRow2Topic(TopicsTable.Rows[i]);
                    MyTopics.Add(T);
                }
            }
            catch (Exception ex)
            {

            }

            return MyTopics;

        }
        internal static Topic DataRow2Topic(DataRow T)
        {
            Topic TopicObj = new();

            try
            {
                int Temp = 0;

                if (int.TryParse(T["top_id"]?.ToString() ?? "-1", out Temp))
                    TopicObj.Top_id = Temp;

                TopicObj.Top_name = T["top_name"]?.ToString() ?? "N/A";

                if (int.TryParse(T["crs_id"]?.ToString() ?? "-1", out Temp))
                    TopicObj.Crs_id = Temp;

                TopicObj.State = EntityState.Unchanged;

            }
            catch (Exception Ex)
            {

            }

            return TopicObj;
        }


    }
}
