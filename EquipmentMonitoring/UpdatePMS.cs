﻿using EquipmentMonitoring.Libs;
using EquipmentMonitoring.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipmentMonitoring
{
    public partial class UpdatePMS : Form
    {
        MonitoringRepository monitoring = new MonitoringRepository();
        GenericFunctions GenericFunc = new GenericFunctions();
        string Connection = ConfigurationManager.ConnectionStrings["Maintenancedb"].ToString();

        public string PEquipmentNo { get; set; }
        public string PModel { get; set; }
        public string PPlateno { get; set; }
        public string Ppreventive { get; set; }
        public string PMaintenanceId { get; set; }
        public string userlogin { get; set; }
        public UpdatePMS()
        {
            InitializeComponent();
        }


        public void param(string EquipmentNo, string Model, string Plateno, string preventive, string MaintenanceId, string userid)
        {
            PEquipmentNo = EquipmentNo;
            PModel = Model;
            PPlateno = Plateno;
            Ppreventive = preventive;
            PMaintenanceId = MaintenanceId;
            cmbPreventive.SelectedIndex = Int32.Parse(preventive);
            userlogin = userid;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string Equipmentno = "'" + PEquipmentNo + "'";
            string Model = "'" + PModel + "'";
            string Plateno = "'" + PPlateno + "'";
            string Maintenance = "'" + PMaintenanceId + "'";
            string userid = "'" + userlogin + "'";
            //string Preventive = "'" + Ppreventive  + "'"; 
            //string Preventive = cmbPreventive.SelectedValue.ToString().ToUpper();
            string Preventive = cmbPreventive.SelectedItem.ToString();
            string IsSave;

            string spName = "sp_Update_PMS";
            SqlDataReader reader;


            reader = monitoring.ExecuteReader(spName, Equipmentno, Model, Plateno, Preventive, Maintenance, userid);
            DataTable result = new DataTable();
            result.Load(reader);
            IsSave = result.Rows[0]["Result"].ToString();

            if (IsSave == "0")
            {
                MessageBox.Show("Failed To Save..");
            }
            else
            {
                this.Close();
                MessageBox.Show("Successfully Saved..");

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lnkDelete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string Equipmentno = "'" + PEquipmentNo + "'";
            string Model = "'" + PModel + "'";
            string Plateno = "'" + PPlateno + "'";
            string Maintenance = "'" + PMaintenanceId + "'";
            string userid = "'" + userlogin + "'";
            //string Preventive = "'" + Ppreventive  + "'"; 
            //string Preventive = cmbPreventive.SelectedValue.ToString().ToUpper();
            string IsSave;

            string spName = "sp_Delete_Maintenance";
            SqlDataReader reader;


            reader = monitoring.ExecuteReader(spName, Equipmentno, Model, Plateno, Maintenance, userid);
            DataTable result = new DataTable();
            result.Load(reader);
            IsSave = result.Rows[0]["Result"].ToString();

            if (IsSave == "0")
            {
                MessageBox.Show("Failed To Save..");
            }
            else
            {
                this.Close();
                MessageBox.Show("Successfully Saved..");

            }
        }
    }
}
