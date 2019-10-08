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
    public partial class RenameCategory : Form
    {

        MonitoringRepository monitoring = new MonitoringRepository();
        string Connection = ConfigurationManager.ConnectionStrings["Maintenancedb"].ToString();

        public string PCategory { get; set; }

        public RenameCategory()
        {
            InitializeComponent();
        }

        public void param(string Category)
        {
            PCategory = Category;
            lblCategory.Text = Category;
            txtCategory.Text = Category;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Please Click Yes To Continue to Save", "Save", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                string result = "";
                SqlDataReader reader;
                // "'" + Equipmentno + "'";
                string OrigCategory = "'" + lblCategory.Text + "'";
                string NewCategory = "'" + txtCategory.Text + "'";
                string RType = "'" + cmbCategoryRType.SelectedItem.ToString().Replace("N/A","NA") + "'";
                string spName = "sp_Update_Category";

                reader = monitoring.ExecuteReader(spName, OrigCategory, NewCategory, RType);
                DataTable Detail = new DataTable();
                Detail.Load(reader);
                result = Detail.Rows[0]["Result"].ToString();

                if (result == "1")
                {
                    MessageBox.Show("Successfully Saved..");
                    this.Hide();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed To Saved..");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Please Click Yes To Continue to Delete", "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                string result = "";
                SqlDataReader reader;
                // "'" + Equipmentno + "'";
                string OrigCategory = "'" + lblCategory.Text + "'";
                string NewCategory = "'" + txtCategory.Text + "'";
                string spName = "sp_Delete_Category";

                reader = monitoring.ExecuteReader(spName, OrigCategory);
                DataTable Detail = new DataTable();
                Detail.Load(reader);
                result = Detail.Rows[0]["Result"].ToString();

                if (result == "1")
                {
                    MessageBox.Show("Successfully Deleted..");
                    this.Hide();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed To Delete..");
                }
            }
        }

        private void lnkClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void txtCategory_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
            }
        }
    }
}
