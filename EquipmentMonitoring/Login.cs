using EquipmentMonitoring.Libs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipmentMonitoring
{
    public partial class Login : Form
    {
        GenericFunctions GenericFunc = new GenericFunctions();

        public string a { get; set; }
        public string b { get; set; }
        public string IsLogin { get; set; }
        public string IsAdmin { get; set; }
        public string UserRole { get; set; }
        public string strReturnUser { get; set; }
        public string IsResetPassword { get; set; }

        string strConnection = "";
        public Login()
        {
            InitializeComponent();
            IsLogin = "0";
            strReturnUser = " ";
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            strConnection = ConfigurationManager.ConnectionStrings["Maintenancedb"].ToString();
            a = txtUser.Text;
            b = Encryptor.EnDe_crypt(txtPassword.Text, true);

            string verifyResult = CheckUserFromSQL(CheckUserLogin(a, b));

            if (verifyResult == "1")
            {
                IsLogin = "1";
                MessageBox.Show("Success");
                this.Close();

            }
            else if (verifyResult == "2")
            {
                MessageBox.Show("System Locked-Out");

            }
            else
            {
                MessageBox.Show("Failed");
            }

        }

        private DataTableReader CheckUserLogin(string Username, string Password)
        {

            object pIPAddress;
            string str = "";
            System.Net.Dns.GetHostName();
            IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(str);
            IPAddress[] addr = ipEntry.AddressList;
            pIPAddress = addr[addr.Length - 1].ToString();
            string ip = pIPAddress.ToString();


            string strSQL = "exec sp_Login'" + Username + "','" + Password + "','" + pIPAddress + "'";
            return GenericFunc.MSsqlDataReader(strConnection, strSQL);

        }

        private string CheckUserFromSQL(DataTableReader reader)
        {
            string UserID = "";
            string result = "";

            //var csv = new StringBuilder();

            if (reader.Read())
            {
                strReturnUser = reader["Username"].ToString();
                IsAdmin = reader["IsAdmin"].ToString();
                UserRole = reader["UserRole"].ToString();
                //strUsrBRSTN = reader["BRSTN"].ToString();
                //strBankId = reader["strBankId"].ToString();
                //strBranchId = reader["strBranchId"].ToString();
                //UserID = reader["Username"].ToString();
                //strRules = reader["Rules"].ToString();
                IsResetPassword = reader["ResetPassword"].ToString();
                result = reader["Result"].ToString();
                //strUsrBranch = reader["Branch"].ToString();
            }
            return result;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnLogin_Click(BtnLogin, EventArgs.Empty);
            }
        }
    }
}
