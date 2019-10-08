using EquipmentMonitoring.Libs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using EquipmentMonitoring.Repository;

namespace EquipmentMonitoring
{
    public partial class AddEquipmentType : Form
    {
      //  string Connection = ConfigurationManager.ConnectionStrings["Maintenancedb"].ToString();
        MonitoringRepository monitoring = new MonitoringRepository();
       
        RegistryLocator fldrLocator = new RegistryLocator();

        public AddEquipmentType()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Please Click Yes if you want to SAVE", "Save", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (txtTrucktype.Text.Replace(" ","") == string.Empty)
            {
                MessageBox.Show("Please enter a value to TruckType!");
                return;
            }
            else if (txtLimit.Text.Replace(" ", "") == string.Empty)
            {
                MessageBox.Show("Please select a value from Limit to Maintenance!");
                return;
            }
            else if (txtkmLimit.Text.Replace(" ", "") == string.Empty)
            {
                MessageBox.Show("Please select a value from KM!");
                return;
            }
            else if (txtHr.Text.Replace(" ", "") == string.Empty)
            {
                MessageBox.Show("Please select a value from HR!");
                return;
            }
            else if (cmbLimitBase.Text == string.Empty)
            {
                MessageBox.Show("Please select a value from Limit Base!");
                return;
            }
            else
            {
                /*
                string Trucktype = " ";
                string Description = " ";
                string partialType = " ";
                string partialDescrip = " ";
                string Limit = "";
                */
                SqlDataReader reader;
                string spName = "sp_Add_Trucktype";
                string partialType = txtTrucktype.Text;
                string partialDescrip = txtDescription.Text;
                string Trucktype = "'" + txtTrucktype.Text + "'";
                string Description = "'" + txtDescription.Text + "'";
                string Limit = "'" + txtLimit.Text + "'";
                string Km = "'" + txtkmLimit.Text + "'";
                string Hr = "'" + txtHr.Text + "'";
                string LimitBase = "'" + cmbLimitBase.SelectedItem.ToString() + "'";


                    reader = monitoring.ExecuteReader(spName, Trucktype, Description, Km, Hr, LimitBase, Limit);
                        DataTable result = new DataTable();
                        result.Load(reader);
                        string Result = result.Rows[0]["Result"].ToString();
                        if (Result == "0")
                        {
                            MessageBox.Show("Failed To Save..");
                        }
                        else if (Result == "1")
                        {
                            MessageBox.Show("Successfully Saved..");
                            txtTrucktype.Text = "";
                            txtDescription.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Already Saved..");
                        }

                }
            }
            else
            {

            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mainform main = new mainform();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }

        private void txtTruckType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnSave_Click(btnSave, EventArgs.Empty);
            }
        }

        private void lnkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainform main = new mainform();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }

        private void txtLimit_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtkmLimit_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtHr_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void test(object sender, KeyPressEventArgs e)
        {

        }


        /*
        public interface IService
        {
            bool isConnected { get; }
            string connectionString { get; }
            SqlDataReader ExecuteReader(string spName, params string[] parameters);
            SqlDataReader ExecuteReaderFn(string spName, params string[] parameters);
            void ExecuteNonQuery(string spName, params object[] parameters);
            DataTable GetTemplate(string templateType, string templateName, params object[] values);

        }
        public interface IServiceOptional
        {
            DataTable SetTemplate(string templateType, string templateName, params object[] values);
        }

        public string connectionString
        {
            get { return this._connectionString; }
        }
        public bool isConnected
        {
            get { return IsConnected(); }
        }

        private string _connectionString { get; set; }
        private string FileName { get; set; }
        public string FolderType { get; set; }
        public object CheckImage { get; set; }

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

        public static DataTableReader MSsqlDataReader(string msConnection, string msSQL)
        {
            DataTableReader dr = (TableFromMSSQL(msConnection, msSQL)).CreateDataReader();
            return dr;
        }

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
        */
    }
}
