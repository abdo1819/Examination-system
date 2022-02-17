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
        internal static Student DataRow2Student(DataRow std)
        {
            Student stdObj = new();
            
            try
            {
                int Temp = 0;

                if (int.TryParse(std["std_id"]?.ToString() ?? "-1", out Temp))
                    stdObj.Std_id = Temp;

                if (int.TryParse(std["dept_id"]?.ToString() ?? "-1", out Temp))
                    stdObj.Dept_id = Temp;

            }
            catch (Exception Ex)
            {

            }

            return stdObj;
        }


        //public static getStudentAnswer()
        //{

        //}

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


    }
}
