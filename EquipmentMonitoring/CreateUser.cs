using EquipmentMonitoring.Libs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipmentMonitoring
{
    public partial class CreateUser : Form
    {
        string userid = "";
        GenericFunctions GenericFunc = new GenericFunctions();
        string strConnection = "";
        public string Result { get; set; }
        public CreateUser()
        {
            InitializeComponent();
            strConnection = ConfigurationManager.ConnectionStrings["Maintenancedb"].ToString();
        }

        public void Param(string user)
        {
            userid = user;
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            bool isValid = txtUserid.Text.Length <= 3;
            string User_id = txtUserid.Text;
            string a = Regex.Replace(User_id, @"\s+", "");
            if (isValid == false)
            {
                if (Regex.Replace(User_id, @"\s+", "") != "")
                {
                    object pIPAddress;
                    string str = "";
                    System.Net.Dns.GetHostName();
                    IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(str);
                    IPAddress[] addr = ipEntry.AddressList;
                    pIPAddress = addr[addr.Length - 1].ToString();
                    string IsAdmin;
                    string password = Encryptor.EnDe_crypt("12345", true);

                    if (chkIsAdmin.Checked == true)
                    {
                        IsAdmin = "1";
                    }
                    else
                    {
                        IsAdmin = "0";
                    }

                    string strSQL = "exec sp_CreateAccount" + " '" + User_id + "','" + password + "','" + userid + "','" + IsAdmin + "','" + pIPAddress + "'";
                    //reader = GenericFunc.ExecuteReader(spName, Userid, parmcurrentpass, parmnewpass, parmpIPAddress);
                    DataTable data = new DataTable();
                    DataTableReader readesr = GenericFunc.MSsqlDataReader(strConnection, strSQL);

                    if (readesr.Read())
                    {
                        Result = readesr["Result"].ToString();
                        //strUsrBranch = reader["Branch"].ToString();
                    }

                    if (Result == "0")
                    {
                        MessageBox.Show("Successfully Created");
                        this.Close();
                    }
                    else if (Result == "3")
                    {
                        MessageBox.Show("UserID already created but InActive");
                    }
                    else if (Result == "4")
                    {
                        MessageBox.Show("UserID already created");
                    }
                    else if (Result == "4")
                    {
                        MessageBox.Show("UserId Empty");
                    }
                    //string UserID = Encryptor.EnDe_crypt(txtcurrentpass.Text, true);
                    //string newpass = Encryptor.EnDe_crypt(txtnewpass.Text, true);
                    //string confirmpass = Encryptor.EnDe_crypt(txtconfirm.Text, true);

                }
                else
                {
                    MessageBox.Show("UserId Empty");
                }
            }


        }
    }
}
