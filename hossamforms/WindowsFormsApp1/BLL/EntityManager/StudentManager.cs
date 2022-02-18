using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class StudentManager
    {
        static DBManager dbManager = new();

        public static bool deleteStudent(int _std_id)
        {
            try
            {
                Dictionary<string, object> parms = new() { ["std_id"] = _std_id };
                if (dbManager.ExecuteNonQuery("deleteStudent", parms) > 0)
                    return true;

            }
            catch (Exception Ex)
            {

            }
            return false;
        }

        public static bool End_Course_for_Student(string _crs_name, int _std_id)
        {
            try
            {
                Dictionary<string, object> parms = new() { ["crs_name"] = _crs_name, ["std_id"] = _std_id };
                if (dbManager.ExecuteNonQuery("End_Course_for_Student", parms) > 0)
                    return true;

            }
            catch (Exception Ex)
            {

            }
            return false;
        }

        public static StudentList getAllStudents()
        {
            StudentList StdList = new();
            try
            {

                DataTable StudentsTable = dbManager.ExecuteDataTable("getAllStudents");

                StdList = DataTable2StudentList(StudentsTable);

            }
            catch (Exception ex)
            {

            }

            return StdList;
        }

        internal static StudentList DataTable2StudentList(DataTable StudentsTable)
        {
            StudentList MyStudents = new();
            try
            {
                for (int i = 0; i < StudentsTable?.Rows.Count; i++)
                {
                    Student std = DataRow2Student(StudentsTable.Rows[i]);
                    MyStudents.Add(std);
                }
            }
            catch (Exception ex)
            {

            }

            return MyStudents;

        }
        internal static Student DataRow2Student(DataRow Std)
        {
            Student StdObj = new();
            
            try
            {
                int Temp = 0;

                if (int.TryParse(Std["std_id"]?.ToString() ?? "-1", out Temp))
                    StdObj.Std_id = Temp;

                if (int.TryParse(Std["usr_id"]?.ToString() ?? "-1", out Temp))
                    StdObj.Usr_id = Temp;

                StdObj.User_type = Std["user_type"].ToString() ?? "N/A";
                StdObj.F_name = Std["f_name"].ToString() ?? "N/A";
                StdObj.L_name = Std["l_name"].ToString() ?? "N/A";
                StdObj.Address = Std["address"].ToString() ?? "N/A";
                StdObj.Email = Std["email"].ToString() ?? "N/A";
                StdObj.Hashed_password = Std["hashed_password"].ToString() ?? "N/A";

                if (int.TryParse(Std["dept_id"]?.ToString() ?? "-1", out Temp))
                    StdObj.Dept_id = Temp;

                StdObj.State = EntityState.Unchanged;

            }
            catch (Exception Ex)
            {

            }

            return StdObj;
        }

        public static DataTable getStudentAnswer(int _exam_id, int _student_id)
        {
            DataTable ResultTable = new();
            try
            {

                Dictionary<string, object> parms = new() { ["exam_id"] = _exam_id, ["student_id"] = _student_id };

                ResultTable = dbManager.ExecuteDataTable("getStudentAnswer", parms);

            }
            catch (Exception ex)
            {

            }

            return ResultTable;
        }

        public static StudentList getStudentsInDepartment(int _dept_id)
        {
            StudentList StdList = new();
            try
            {
                Dictionary<string, object> parms = new() { ["dept_id"] = _dept_id };
                DataTable InstructorsTable = dbManager.ExecuteDataTable("getStudentsInDepartment", parms);

                StdList = DataTable2StudentList(InstructorsTable);

            }
            catch (Exception ex)
            {

            }

            return StdList;
        }

        public static bool Insert_Student(string _f_name, string _l_name, string _address, string _email, string _password, int _dept_id, int _std_id)
        {
            try
            {
                Dictionary<string, object> parms = new() { ["f_name"] = _f_name, ["l_name"] = _l_name, ["address"] = _address, ["email"] = _email, ["password"] = _password, ["dept_id"] = _dept_id, ["std_id"] = _std_id };
                if (dbManager.ExecuteNonQuery("Insert_Student", parms) > 0)
                    return true;

            }
            catch (Exception Ex)
            {

            }
            return false;
        }

        public static bool updateStudentData(string _f_name, string _l_name, string _address, string _email, int _dept_id, int _std_id)
        {
            try
            {
                Dictionary<string, object> parms = new() { ["f_name"] = _f_name, ["l_name"] = _l_name, ["address"] = _address, ["email"] = _email, ["dept_id"] = _dept_id, ["std_id"] = _std_id };
                if (dbManager.ExecuteNonQuery("updateStudentData", parms) > 0)
                    return true;

            }
            catch (Exception Ex)
            {

            }
            return false;
        }

        public static DataTable returnGrades(int _std_id)
        {
            DataTable ResultTable = new();
            try
            {

                Dictionary<string, object> parms = new() { ["std_id"] = _std_id };

                ResultTable = dbManager.ExecuteDataTable("returnGrades", parms);

            }
            catch (Exception ex)
            {

            }

            return ResultTable;
        }


    }
}
