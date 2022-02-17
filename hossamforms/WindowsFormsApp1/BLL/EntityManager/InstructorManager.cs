using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public static class InstructorManager
    {
        static DBManager dbManager = new();
        
        public static bool Assign_Course_to_Instructor(string _crs_name, int _ins_id)
        {
            try
            {
                Dictionary<string, object> parms = new() { ["crs_name"] = _crs_name, ["ins_id"] = _ins_id };
                if (dbManager.ExecuteNonQuery("Assign_Course_to_Instructor", parms) > 0)
                    return true;

            }
            catch (Exception Ex)
            {

            }
            return false;
        }

        public static DataTable Courses_and_Students_of_Instructor(int _ins_id)
        {
            DataTable ResultTable = new();
            try
            {

                Dictionary<string, object> parms = new() { ["ins_id"] = _ins_id };

                ResultTable = dbManager.ExecuteDataTable("Courses_and_Students_of_Instructor", parms);

            }
            catch (Exception ex)
            {

            }

            return ResultTable;
        }

        internal static InstructorList DataTable2InstructorList(DataTable InstructorsTable)
        {
            InstructorList MyInstructors = new();
            try
            {
                for (int i = 0; i < InstructorsTable?.Rows.Count; i++)
                {
                    Instructor ins = DataRow2Instructor(InstructorsTable.Rows[i]);
                    MyInstructors.Add(ins);
                }
            }
            catch (Exception ex)
            {

            }

            return MyInstructors;

        }
        internal static Instructor DataRow2Instructor(DataRow ins)
        {
            Instructor insObj = new();
            try
            {
                int Temp = 0;
                decimal TempDec = 0;

                if (int.TryParse(ins["ins_id"]?.ToString() ?? "-1", out Temp))
                    insObj.Ins_id = Temp;

                if (decimal.TryParse(ins["salary"]?.ToString() ?? "-1", out TempDec))
                    insObj.Salary = Temp;

                insObj.Degree = ins["degree"]?.ToString() ?? "N/A";

                if (int.TryParse(ins["dept_id"]?.ToString() ?? "-1", out Temp))
                    insObj.Dept_id = Temp;

                insObj.Hire_date = (DateTime)ins["hire_date"];

                insObj.State = EntityState.Unchanged;

            }
            catch (Exception Ex)
            {

            }

            return insObj;
        }
        
        public static bool deleteInstructor(int _ins_id)
        {
            try
            {
                Dictionary<string, object> parms = new() { ["ins_id"] = _ins_id };
                if (dbManager.ExecuteNonQuery("deleteInstructor", parms) > 0)
                    return true;

            }
            catch (Exception Ex)
            {

            }
            return false;
        }

        public static bool End_Course_with_Instructor(string _crs_name, int _ins_id)
        {
            try
            {
                Dictionary<string, object> parms = new() { ["crs_name"] = _crs_name, ["ins_id"] = _ins_id };
                if (dbManager.ExecuteNonQuery("End_Course_with_Instructor", parms) > 0)
                    return true;

            }
            catch (Exception Ex)
            {

            }
            return false;
        }

        public static InstructorList getAllInstructors()
        {
            InstructorList InsList = new();
            try
            {

                DataTable InstructorsTable = dbManager.ExecuteDataTable("getAllInstructors");

                InsList = DataTable2InstructorList(InstructorsTable);

            }
            catch (Exception ex)
            {

            }

            return InsList;
        }

        public static InstructorList getInstructorsInDepartment(int _dept_id)
        {
            InstructorList InsList = new();
            try
            {
                Dictionary<string, object> parms = new() { ["dept_id"] = _dept_id };
                DataTable InstructorsTable = dbManager.ExecuteDataTable("getInstructorsInDepartment", parms);

                InsList = DataTable2InstructorList(InstructorsTable);

            }
            catch (Exception ex)
            {

            }

            return InsList;
        }

        public static bool Insert_Instructor(string _f_name, string _l_name, string _address, string _email, string _password, decimal _salary, string _degree, int _dept_id, int _ins_id)
        {
            try
            {
                Dictionary<string, object> parms = new() { ["f_name"] = _f_name, ["l_name"] = _l_name, ["address"] = _address, ["email"] = _email, ["password"] = _password, ["salary"] = _salary, ["degree"] = _degree, ["dept_id"] = _dept_id, ["ins_id"] = _ins_id };
                if (dbManager.ExecuteNonQuery("Insert_Instructor", parms) > 0)
                    return true;

            }
            catch (Exception Ex)
            {

            }
            return false;
        }

        public static bool Student_Take_course_with_Instructor(int _std_id, int _crs_id, int _ins_id)
        {
            try
            {
                Dictionary<string, object> parms = new() { ["std_id"] = _std_id, ["crs_id"] = _crs_id, ["ins_id"] = _ins_id };
                if (dbManager.ExecuteNonQuery("Student_Take_course_with_Instructor", parms) > 0)
                    return true;

            }
            catch (Exception Ex)
            {

            }
            return false;
        }

        public static bool updateInstructorData(string _f_name, string _l_name, string _address, string _email, decimal _salary, string _degree, int _dept_id, int _ins_id)
        {
            try
            {
                Dictionary<string, object> parms = new() { ["f_name"] = _f_name, ["l_name"] = _l_name, ["address"] = _address, ["email"] = _email, ["salary"] = _salary, ["degree"] = _degree, ["dept_id"] = _dept_id, ["ins_id"] = _ins_id };
                if (dbManager.ExecuteNonQuery("updateInstructorData", parms) > 0)
                    return true;

            }
            catch (Exception Ex)
            {

            }
            return false;
        }


    }
}
