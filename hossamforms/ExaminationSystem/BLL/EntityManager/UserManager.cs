using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class UserManager
    {
        static DBManager dbManager = new();
        
        public static bool updateUserData(int _usr_id, string _f_name, string _l_name, string _address, string _email)
        {
            try
            {
                Dictionary<string, object> parms = new() { ["usr_id"] = _usr_id, ["f_name"] = _f_name, ["l_name"] = _l_name, ["address"] = _address, ["email"] = _email };
                if (dbManager.ExecuteNonQuery("updateUserData", parms) > 0)
                    return true;

            }
            catch (Exception Ex)
            {

            }
            return false;
        }

        public static bool Insert_User(char _user_type, string _f_name, string _l_name, string _address, string _email, string _password, int _usr_id)
        {
            try
            {
                Dictionary<string, object> parms = new() { ["user_type"] = _user_type, ["f_name"] = _f_name, ["l_name"] = _l_name, ["address"] = _address, ["email"] = _email, ["password"] = _password, ["usr_id"] = _usr_id };
                if (dbManager.ExecuteNonQuery("Insert_User", parms) > 0)
                    return true;

            }
            catch (Exception Ex)
            {

            }
            return false;
        }



    }
}
