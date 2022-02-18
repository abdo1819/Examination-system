using Microsoft.Data;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Configuration;
using System;
using Microsoft.IdentityModel.Protocols;
using System.Collections.Generic;

namespace DAL
{
    public class DBManager : IDisposable
    {
        SqlConnection SqlCN;
        SqlCommand SqlCMD;
        SqlDataAdapter SqlDA;
        DataTable DT;

        public DBManager()
        {
            try
            {
                SqlCN = new SqlConnection(ConfigurationManager.ConnectionStrings["Examination"].ConnectionString);
                SqlCMD = new SqlCommand("", SqlCN);
                SqlCMD.CommandType = CommandType.StoredProcedure;
                SqlDA = new SqlDataAdapter(SqlCMD);
                DT = new DataTable();

            }
            catch (Exception ex)
            {
                //log Eception
            }
        }

        public int ExecuteNonQuery(string SPName)
        {
            int R = -1;
            try
            {
                SqlCMD.Parameters.Clear();
                SqlCMD.CommandText = SPName;

                if (SqlCN.State == ConnectionState.Closed)
                    SqlCN.Open();

                R = SqlCMD.ExecuteNonQuery(); // returns int (no of rows affected) (fn in SqlCommand)

                SqlCN.Close();

            }
            catch (Exception ex)
            {

            }

            return R;
        }

        public object ExecuteScalar(string SPName)
        {
            object R = new();
            try
            {
                SqlCMD.Parameters.Clear();
                SqlCMD.CommandText = SPName;

                if (SqlCN.State == ConnectionState.Closed)
                    SqlCN.Open();

                R = SqlCMD.ExecuteScalar(); // returns the first coloumn of the first row of the result set of the query (fn in SqlCommand)

                SqlCN.Close();

            }
            catch (Exception ex)
            {

            }

            return R;
        }

        public DataTable ExecuteDataTable(string SPName)
        {
            try
            {
                DT.Clear();
                SqlCMD.Parameters.Clear();
                SqlCMD.CommandText = SPName;
                SqlDA.Fill(DT);

                return DT;
            }
            catch (Exception ex)
            {

            }
            return new();
        }

        public int ExecuteNonQuery(string SPName, Dictionary<string, object> parms)
        {
            int R = -1;
            try
            {
                SqlCMD.Parameters.Clear();
                SqlCMD.CommandText = SPName;

                foreach (var item in parms)
                {
                    SqlCMD.Parameters.Add(new SqlParameter(item.Key, item.Value));
                }

                if (SqlCN.State == ConnectionState.Closed)
                    SqlCN.Open();

                R = SqlCMD.ExecuteNonQuery(); // returns int (no of rows affected) (fn in SqlCommand)

                SqlCN.Close();

            }
            catch (Exception ex)
            {

            }

            return R;
        }

        public object ExecuteScalar(string SPName, Dictionary<string, object> parms)
        {
            object R = new();

            try
            {

                SqlCMD.Parameters.Clear();
                SqlCMD.CommandText = SPName;

                foreach (var item in parms)
                {
                    SqlCMD.Parameters.Add(new SqlParameter(item.Key, item.Value));
                }

                if (SqlCN.State == ConnectionState.Closed)
                    SqlCN.Open();

                R = SqlCMD.ExecuteScalar(); // returns the first coloumn of the first row of the result set of the query (fn in SqlCommand)

                SqlCN.Close();

            }
            catch (Exception ex)
            {

            }

            return R;
        }

        public DataTable ExecuteDataTable(string SPName, Dictionary<string, object> parms)
        {
            try
            {
                DT.Clear();
                SqlCMD.Parameters.Clear();
                SqlCMD.CommandText = SPName;

                foreach (var item in parms)
                {
                    SqlCMD.Parameters.Add(new SqlParameter(item.Key, item.Value));
                }

                SqlDA.Fill(DT);

                return DT;
            }
            catch (Exception ex)
            {

            }
            return new();
        }


        public void Dispose()
        {
            try
            {
                SqlCN?.Dispose();
            }
            catch (Exception ex)
            {

            }
        }
    }
}