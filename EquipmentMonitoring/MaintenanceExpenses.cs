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
    public partial class MaintenanceExpenses : Form
    {

        MonitoringRepository monitoring = new MonitoringRepository();
        string Connection = ConfigurationManager.ConnectionStrings["Maintenancedb"].ToString();

        public MaintenanceExpenses()
        {
            InitializeComponent();
            CategoryParent();
            
            //dgvMaintenance
            dgvMaintenance.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            
        }

        private void CategoryParent()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from m_CategoryList with(nolock)", Connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbCategory.DataSource = dt;
            cmbCategory.DisplayMember = "Category";
            cmbCategory.ValueMember = "Category";

        }

        private void CategorysList()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select Category, [Sub-Category] from m_SubCategoryList with(nolock) where [Sub-Category] != 'All'" +
                    "and Category = '" + cmbCategory.Text + "' and [Sub-Category] not in (Select Category from m_CategoryList with(nolock) where Category != 'All')", Connection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbSubCategory.DataSource = dt;
            cmbSubCategory.DisplayMember = "Sub-Category";
            cmbSubCategory.ValueMember = "Sub-Category";
        }

        private void lnkClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            CategorysList();
        }
    }
}
