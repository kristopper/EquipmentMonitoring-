using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentMonitoring.Libs
{
    class GenericFunctions
    {
        public DataTableReader MSsqlDataReader(string msConnection, string msSQL)
        {
            DataTableReader dr = (TableFromMSSQL(msConnection, msSQL)).CreateDataReader();
            return dr;
        }

        //SqlConnection dbConnect = new SqlConnection();
        //bool IsConnected()
        //{
        //    if (dbConnect.State != ConnectionState.Open)
        //    {
        //        dbConnect = new SqlConnection(ConfigurationManager.ConnectionStrings["Maintenancedb"].ToString());
        //        dbConnect.Open();
        //    }
        //    return dbConnect.State == ConnectionState.Open;
        //}

        //public SqlDataReader ExecuteReader(string spName, params string[] parameters)
        //{
        //    SqlDataReader dbReader;
        //    SqlCommand dbCommand;
        //    try
        //    {
        //        dbCommand = dbConnect.CreateCommand();
        //        dbCommand.CommandType = CommandType.Text;
        //        dbCommand.CommandTimeout = 0;
        //        dbCommand.CommandText = spName + " ";
        //        for (int i = 0; i < parameters.Length; i++)
        //        {
        //            dbCommand.CommandText += parameters[i] + (i < parameters.Length - 1 ? ", " : " ");
        //        }
        //        dbReader = dbCommand.ExecuteReader();
        //    }
        //    catch (Exception ex) { throw ex; }
        //    return dbReader;
        //}


        public DataTable TableFromMSSQL(string strConnection, string strSQl)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(strConnection))
            {
                SqlCommand cmd = new SqlCommand(strSQl, conn);
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 0;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(dt);
            }
            return dt;
        }

        public DataSet DataSetFromMSSQL(string strConnection, string strSQl)
        {
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(strConnection))
            {
                SqlCommand cmd = new SqlCommand(strSQl, conn);
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 0;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            return ds;
        }
    }
}
