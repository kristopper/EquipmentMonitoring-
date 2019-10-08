using EquipmentMonitoring.model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentMonitoring.Repository
{
    public interface IMonitoringRepository
    {
        bool isConnected { get; }
        string connectionString { get; }
        string GetStrValue(string strSQL, string strVal);
        void ExecuteNonQuery(string spName, params object[] parameters);        
        SqlDataReader ExecuteReader(string spName, params string[] parameters);
        void Dispose();
        //  DataTable TableFromMSSQL(string strConnection, string strSQl);
        //  DataTableReader MSsqlDataReader(string msConnection, string msSQL);
        // SqlDataReader ExecuteReaderFn(string spName, params string[] parameters);
        // DataTable GetTemplate(string templateType, string templateName, params object[] values);

    }
    public class MonitoringRepository : IMonitoringRepository
    {

        string Connection = ConfigurationManager.ConnectionStrings["Maintenancedb"].ToString();

        private string _connectionString { get; set; }
        
        public MonitoringRepository()
        {

        }

        public bool isConnected
        {
            get { return IsConnected(); }
        }

        public string connectionString
        {
            get { return this._connectionString; }
        }

        SqlConnection dbConnect = new SqlConnection();
        bool IsConnected()
        {
            if (dbConnect.State != ConnectionState.Open)
            {
                //   dbConnect = new SqlConnection(strDisaster);
                dbConnect = new SqlConnection(Connection);
                dbConnect.Open();
            }
            return dbConnect.State == ConnectionState.Open;
        }

        //DB to Data Table
        public static DataTable TableFromMSSQL(string strConnection, string strSQl)
        {
            DataTable dt = new DataTable();

            try
            {

                using (SqlConnection conn = new SqlConnection(strConnection))
                {
                    SqlCommand cmd = new SqlCommand(strSQl, conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandTimeout = 0;

                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
            }
            return dt;
        }
        
        //DB to Data Reader
        public static DataTableReader MSsqlDataReader(string msConnection, string msSQL)
        {
            DataTableReader dr = (TableFromMSSQL(msConnection, msSQL)).CreateDataReader();
            return dr;
        }

        public void ExecuteNonQuery(string spName, params object[] parameters)
        {
            SqlCommand dbCommand;

            try
            {
                if (!IsConnected()) return;
                dbCommand = dbConnect.CreateCommand();
                dbCommand.CommandType = CommandType.StoredProcedure;
                dbCommand.CommandTimeout = 300;
                dbCommand.CommandText = spName;
                SqlCommandBuilder.DeriveParameters(dbCommand);
                for (int i = 0; i < parameters.Length; i++)
                {
                    dbCommand.Parameters[i + 1].Value = parameters[i];
                }
                dbCommand.ExecuteNonQuery();
            }
            catch (Exception ex) { throw ex; }
        }


       
        /**/
        public void ExecuteNonQueryMonitoring(string spName, DataTable parameters, string EquipmentNo, string PltNo_MdlName, string id)
        {
            //SqlCommand dbCommand;

            try
            {
             
                using (SqlConnection con = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_Add_Monitoring"))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = con;
                        cmd.Parameters.AddWithValue("@tblCustomers", parameters);
                        cmd.Parameters.AddWithValue("@EquipmentNo", EquipmentNo);
                        cmd.Parameters.AddWithValue("@PltNo_MdlName", PltNo_MdlName);
                        cmd.Parameters.AddWithValue("@serviceid", id);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
             
            }
            catch (Exception ex) { throw ex; }
        }

        public SqlDataReader ExecuteReader(string spName, params string[] parameters)
        {
            SqlDataReader dbReader;
            SqlCommand dbCommand;
            try
            {
                if (!IsConnected()) return null;
                dbCommand = dbConnect.CreateCommand();
                dbCommand.CommandType = CommandType.Text;
                dbCommand.CommandTimeout = 300;
                dbCommand.CommandText = spName + " ";
                for (int i = 0; i < parameters.Length; i++)
                {
                    dbCommand.CommandText += parameters[i] + (i < parameters.Length - 1 ? ", " : " ");
                }
                dbReader = dbCommand.ExecuteReader();
            }
            catch (Exception ex) { throw ex; }
            return dbReader;
        }

        public string GetStrValue(string strSQL, string strVal)
        {
            string returnVal = "";
            DataTableReader dr = MSsqlDataReader(Connection, strSQL);

            while (dr.Read())
            {
                returnVal = dr[strVal].ToString();
            }

            return returnVal;
        }
        
        public void Dispose()
        {
          //  sql_con.Close();
        }
    }
}
