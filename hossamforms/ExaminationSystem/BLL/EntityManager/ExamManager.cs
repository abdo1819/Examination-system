using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class ExamManager
    {
        static DBManager dbManager = new();
        
        public static bool deleteExam(int _ex_id)
        {
            try
            {
                Dictionary<string, object> parms = new() { ["ex_id"] = _ex_id };
                if (dbManager.ExecuteNonQuery("deleteExam", parms) > 0)
                    return true;

            }
            catch (Exception Ex)
            {

            }
            return false;
        }

        public static bool generateExam(string _crs_name, int _std_id, int _ex_id)
        {
            try
            {
                Dictionary<string, object> parms = new() { ["crs_name"] = _crs_name, ["std_id"] = _std_id, ["ex_id"] = _ex_id };
                if (dbManager.ExecuteNonQuery("generateExam", parms) > 0)
                        return true;

            }
            catch (Exception Ex)
            {

            }
            return false;
            }


    }
}
