using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class DepartmentManager
    {
        static DBManager dbManager = new();
        
        public static bool Delete_Department(int _dept_name)
        {
            try
            {
                Dictionary<string, object> parms = new() { ["dept_name"] = _dept_name };
                if (dbManager.ExecuteNonQuery("Delete_Department", parms) > 0)
                    return true;

            }
            catch (Exception Ex)
            {

            }
            return false;
        }
        
        public static DepartmentList GetDepartment(int _dept_id)
        {
            DepartmentList DeptList = new();
            try
            {
                Dictionary<string, object> parms = new() { ["dept_id"] = _dept_id };
                DataTable DepartmentsTable = dbManager.ExecuteDataTable("GetDepartment", parms);

                DeptList = DataTable2DepartmentList(DepartmentsTable);

            }
            catch (Exception ex)
            {

            }

            return DeptList;
        }
        
        internal static DepartmentList DataTable2DepartmentList(DataTable DepartmentsTable)
        {
            DepartmentList MyDepartments = new();
            try
            {
                for (int i = 0; i < DepartmentsTable?.Rows.Count; i++)
                {
                    Department D = DataRow2Department(DepartmentsTable.Rows[i]);
                    MyDepartments.Add(D);
                }
            }
            catch (Exception ex)
            {

            }

            return MyDepartments;

        }
        internal static Department DataRow2Department(DataRow D)
        {
            Department DeptObj = new();

            try
            {
                int Temp = 0;

                if (int.TryParse(D["dept_id"]?.ToString() ?? "-1", out Temp))
                    DeptObj.Dept_id = Temp;

                DeptObj.Dept_name = D["dept_name"]?.ToString() ?? "N/A";

                if (int.TryParse(D["mgr_id"]?.ToString() ?? "-1", out Temp))
                    DeptObj.Mgr_id = Temp;

                DeptObj.State = EntityState.Unchanged;


            }
            catch (Exception Ex)
            {

            }

            return DeptObj;
        }

        public static bool Insert_Department(string _dept_name, int _id_mgr, int _dept_id)
        {
            try
            {
                Dictionary<string, object> parms = new() { ["dept_name"] = _dept_name, ["id_mgr"] = _id_mgr, ["dept_id"] = _dept_id };
                if (dbManager.ExecuteNonQuery("Insert_Department", parms) > 0)
                    return true;

            }
            catch (Exception Ex)
            {

            }
            return false;
        }

        public static bool Insert_Department_With_Manager(string _dept_name, string _f_name, string _l_name, string _address, string _email, string _password, decimal _salary, string _degree, int _dept_id, int _mgr_id)
        {
            try
            {
                Dictionary<string, object> parms = new() { ["dept_name"] = _dept_name, ["f_name"] = _f_name, ["l_name"] = _l_name, ["address"] = _address, ["email"] = _email, ["password"] = _password, ["salary"] = _salary, ["degree"] = _degree, ["dept_id"] = _dept_id , ["mgr_id"] = _mgr_id };
                if (dbManager.ExecuteNonQuery("Insert_Department_With_Manager", parms) > 0)
                    return true;

            }
            catch (Exception Ex)
            {

            }
            return false;
        }

        public static bool Update_Department_Manager(string _dept_name, int _mgr_id)
        {
            try
            {
                Dictionary<string, object> parms = new() { ["dept_name"] = _dept_name, ["mgr_id"] = _mgr_id };
                if (dbManager.ExecuteNonQuery("Update_Department_Manager", parms) > 0)
                    return true;

            }
            catch (Exception Ex)
            {

            }
            return false;
        }

        public static DepartmentList GetAllDepts()
        {
            DepartmentList DeptList = new();
            try
            {
                DataTable DepartmentsTable = dbManager.ExecuteDataTable("GetAllDepts");

                DeptList = DataTable2DepartmentList(DepartmentsTable);

            }
            catch (Exception ex)
            {

            }

            return DeptList;
        }
    }
}
