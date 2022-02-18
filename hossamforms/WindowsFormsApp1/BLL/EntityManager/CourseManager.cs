using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class CourseManager
    {
        static DBManager dbManager = new();

        public static bool Delete_Course(string _crs_name)
        {
            try
            {
                Dictionary<string, object> parms = new() { ["crs_name"] = _crs_name };
                if (dbManager.ExecuteNonQuery("Delete_Course", parms) > 0)
                    return true;

            }
            catch (Exception Ex)
            {

            }
            return false;
        }

        public static bool Insert_Course(string _crs_name)
        {
            try
            {
                Dictionary<string, object> parms = new() { ["crs_name"] = _crs_name };
                if (dbManager.ExecuteNonQuery("Insert_Course", parms) > 0)
                    return true;

            }
            catch (Exception Ex)
            {

            }
            return false;
        }

        public static bool setCourseName(int _crs_id, string _crs_name)
        {
            try
            {
                Dictionary<string, object> parms = new() { ["crs_id"] = _crs_id, ["crs_name"] = _crs_name };
                if (dbManager.ExecuteNonQuery("setCourseName", parms) > 0)
                    return true;

            }
            catch (Exception Ex)
            {

            }
            return false;
        }

    }
}
