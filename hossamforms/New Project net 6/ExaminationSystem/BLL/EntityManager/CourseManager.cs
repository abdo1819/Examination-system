using DAL;
using System;
using System.Collections.Generic;
using System.Data;
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

        public static CourseList GetAllCourses()
        {
            CourseList CrsList = new();
            try
            {
                DataTable CoursesTable = dbManager.ExecuteDataTable("GetAllCourses");

                CrsList = DataTable2CourseList(CoursesTable);

            }
            catch (Exception ex)
            {

            }

            return CrsList;
        }

        internal static CourseList DataTable2CourseList(DataTable CoursesTable)
        {
            CourseList MyCourses = new();
            try
            {
                for (int i = 0; i < CoursesTable?.Rows.Count; i++)
                {
                    Course Crs = DataRow2Course(CoursesTable.Rows[i]);
                    MyCourses.Add(Crs);
                }
            }
            catch (Exception ex)
            {

            }

            return MyCourses;

        }
        internal static Course DataRow2Course(DataRow Crs)
        {
            Course CrsObj = new();

            try
            {
                int Temp = 0;

                if (int.TryParse(Crs["crs_id"]?.ToString() ?? "-1", out Temp))
                    CrsObj.Crs_id = Temp;

                CrsObj.Crs_name = Crs["crs_name"]?.ToString() ?? "N/A";


                CrsObj.State = EntityState.Unchanged;

            }
            catch (Exception Ex)
            {

            }

            return CrsObj;
        }

    }
}
