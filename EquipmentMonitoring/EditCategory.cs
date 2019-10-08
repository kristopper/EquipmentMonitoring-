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
    public partial class EditCategory : Form
    {

        MonitoringRepository monitoring = new MonitoringRepository();
        string Connection = ConfigurationManager.ConnectionStrings["Maintenancedb"].ToString();

        public string PCategory { get; set; }
        public string PSubCategory { get; set; }

        public EditCategory()
        {
            InitializeComponent();
            CategoryParent();
        }


        private void CategoryParent()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from m_CategoryList with(nolock) where Category != 'ALL'", Connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbCategory.DataSource = dt;
            cmbCategory.DisplayMember = "Category";
            cmbCategory.ValueMember = "Category";

        }

        public void param(string Category, string Subcategory)
        {
            PCategory = Category;
            PSubCategory = Subcategory;
            lblCategory.Text = Category;
            lblSubCategory.Text = Subcategory;
            txtSubCategory.Text = Subcategory;
            cmbCategory.SelectedValue = Category;
        }

        private void lnkClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            CategoryList category = new CategoryList();
            this.Close();
            category.ShowDialog();
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
                string NewCategory = "'" + cmbCategory.SelectedValue.ToString() + "'";
                string OrigSub = "'" + lblSubCategory.Text + "'";
                string NewSub = "'" + txtSubCategory.Text + "'";
                string spName = "sp_Update_SubCategory";

                reader = monitoring.ExecuteReader(spName, OrigCategory, NewCategory, OrigSub, NewSub);
                DataTable Detail = new DataTable();
                Detail.Load(reader);
                result = Detail.Rows[0]["Result"].ToString();

                if (result == "1")
                {
                    MessageBox.Show("Successfully Saved..");
                    this.Hide();
                    CategoryList category = new CategoryList();
                    this.Close();
                    category.ShowDialog();
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
                string OrigSub = "'" + lblSubCategory.Text + "'";
                string spName = "sp_Delete_SubCategory";

                reader = monitoring.ExecuteReader(spName, OrigCategory, OrigSub);
                DataTable Detail = new DataTable();
                Detail.Load(reader);
                result = Detail.Rows[0]["Result"].ToString();

                if (result == "1")
                {
                    MessageBox.Show("Successfully Deleted..");
                }
                else
                {
                    MessageBox.Show("Failed To Delete..");
                }
            }
        }
    }
}
