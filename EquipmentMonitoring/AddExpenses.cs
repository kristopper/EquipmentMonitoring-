using EquipmentMonitoring.Repository;
using System;
using System.Collections;
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
    public partial class AddExpenses : Form
    {

        MonitoringRepository monitoring = new MonitoringRepository();
        string Connection = ConfigurationManager.ConnectionStrings["Maintenancedb"].ToString();
        DataTable dt = new DataTable();
        DataTable dtemployee = new DataTable();
        DataTable dtProjectsite = new DataTable();
        DataTable unit = new DataTable();

        ArrayList EquipArray = new ArrayList();
        ArrayList DriverArray = new ArrayList();
        ArrayList Projectsitearray = new ArrayList();

        DataGridViewComboBoxColumn dgvcmdCategory = new DataGridViewComboBoxColumn();
        public string userlogin { get; set; }

        public AddExpenses()
        {
            InitializeComponent();
        }

        public void param(string userid)
        {
            userlogin = userid;
        }

        private void AddExpenses_Load(object sender, EventArgs e)
        {
            /*
            dgvExpenses.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvExpenses.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.;
            dgvExpenses.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            */
            dgvExpenses.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvExpenses.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
           // dgvExpenses.Columns[5].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvExpenses.Columns[6].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            // dgvExpenses.Columns[7].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
           // dgvExpenses.Columns[7]. = true;

            using (SqlConnection Con = new SqlConnection(Connection))
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from m_SubCategoryList with (nolock) where [Sub-Category] != 'ALL' and IsDelete = 1 order by Category asc, id asc", Con);

                da.Fill(dt);

                dgvcmdCategory.HeaderText = "CATEGORY";
                dgvcmdCategory.Name = "Category";
                
                ArrayList row = new ArrayList();

                foreach (DataRow dr in dt.Rows)
                {
                    row.Add(dr["Sub-Category"].ToString());
                }


                dgvcmdCategory.Items.AddRange(row.ToArray());
                dgvExpenses.Columns.Add(dgvcmdCategory);
                dgvExpenses.Columns[15].Width = 180;

            }

            using (SqlConnection Con = new SqlConnection(Connection))
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from m_ServiceUnitList with (nolock) where IsDelete = 1", Con);

                da.Fill(unit);


                foreach (DataRow dr in unit.Rows)
                {
                    EquipArray.Add(dr["EquipmentNo"].ToString());
                    EquipArray.Add(dr["Model"].ToString());
                    EquipArray.Add(dr["PlateNo"].ToString());
                }
            }

            using (SqlConnection Con = new SqlConnection(Connection))
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from m_Employee with (nolock) where IsDelete = 1", Con);

                da.Fill(dtemployee);

                foreach (DataRow dr in dtemployee.Rows)
                {
                    DriverArray.Add(dr["Name"].ToString());
                }
            }
            using (SqlConnection Con = new SqlConnection(Connection))
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from m_ProjectSite with (nolock) where IsDelete = 1", Con);

                da.Fill(dtProjectsite);

                foreach (DataRow dr in dtProjectsite.Rows)
                {
                    Projectsitearray.Add(dr["ProjectNo"].ToString());
                }
            }

        }

        private void lnkClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*
            mainform main = new mainform();
            this.Hide();
            main.ShowDialog();
            */
            this.Close();
        }

        private void dgvExpenses_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox auto = e.Control as TextBox;

            //if (!char.IsControl(e.KeyChar)
            //         && !char.IsDigit(e.KeyChar)
            //         && e.KeyChar != '/')
            //{
            //    e.Handled = true;
            //}
            if (dgvExpenses.CurrentCell.ColumnIndex == 1)
            {
                try
                {
                    if (auto != null)
                    {
                        auto.AutoCompleteCustomSource.Clear();
                        auto.AutoCompleteMode = AutoCompleteMode.Suggest;
                        auto.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        AutoCompleteStringCollection data = new AutoCompleteStringCollection();
                        Equip(data);
                        auto.AutoCompleteCustomSource = data;
                    }
                }
                catch { }
            }
            //else if (dgvExpenses.CurrentCell.ColumnIndex == 0)
            //{
            //    try
            //    {
            //        if (!char.IsControl(e.KeyChar)
            //                 && !char.IsDigit(e.KeyChar)
            //                 && e.KeyChar != '/')
            //        {
            //            e.Handled = true;
            //        }
            //    }
            //    catch { }
            //}
            else if (dgvExpenses.CurrentCell.ColumnIndex == 7)
            {
                try
                {
                    auto.AutoCompleteCustomSource.Clear();
                    auto.AutoCompleteMode = AutoCompleteMode.Suggest;
                    auto.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    AutoCompleteStringCollection data = new AutoCompleteStringCollection();
                    FillDriver(data);
                    auto.AutoCompleteCustomSource = data;
                }
                catch { }
            }
            else if (dgvExpenses.CurrentCell.ColumnIndex == 8)
            {
                try
                {
                    auto.AutoCompleteCustomSource.Clear();
                    auto.AutoCompleteMode = AutoCompleteMode.Suggest;
                    auto.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    AutoCompleteStringCollection data = new AutoCompleteStringCollection();
                    FillDriver(data);
                    auto.AutoCompleteCustomSource = data;
                }
                catch { }
            }
            else if (dgvExpenses.CurrentCell.ColumnIndex == 9)
            {
                try
                {
                    auto.AutoCompleteCustomSource.Clear();
                    auto.AutoCompleteMode = AutoCompleteMode.Suggest;
                    auto.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    AutoCompleteStringCollection data = new AutoCompleteStringCollection();
                    FillProjectsite(data);
                    auto.AutoCompleteCustomSource = data;
                }
                catch { }
            }
            /*
            else if (dgvExpenses.CurrentCell.ColumnIndex == 13)
            {
            }
            */
            else
            {
                try
                {
                    auto.AutoCompleteCustomSource.Clear();
                }
                catch { }
            }
        }

        private void Equip(AutoCompleteStringCollection data)
        {
            foreach (var item in EquipArray)
                data.AddRange(new string[] { item.ToString() });
        }

        private void FillDriver(AutoCompleteStringCollection data)
        {
            foreach (var item in DriverArray)
                data.AddRange(new string[] { item.ToString() });
        }
        private void FillProjectsite(AutoCompleteStringCollection data)
        {
            foreach (var item in Projectsitearray)
                data.AddRange(new string[] { item.ToString() });
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Please Click Yes To Continue", "Save", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string result = "";
                SqlDataReader reader;
                string Date = "'" + "'";
                string Equipmentno = "'" + "'";
                string Problem = "'" + "'";
                string Diagnosis = "'" + "'";
                string DriversName = "'" + "'";
                string Projectsite = "'" + "'";
                string Remarks = "'" + "'";
                string StartRepair = "'" + "'";
                string DateofPurchase = "'" + "'";
                string CategoryL = "'" + "'";
                string spName = "sp_Add_Expenses";
                string IsPurchase = "'" + "'";
                string pms = "'" + "'";
                string repair = "'" + "'";
                string tire = "'" + "'";
                string userid = "'" + userlogin + "'";

                //add
                string item = "''";
                string pcs = "''";
                string mechanic = "''";
                string mileage = "''";

                int ok;

                int count = 0;
                int numRows = dgvExpenses.Rows.Count;
                int loop = numRows - 1;

                for (int i = 0; i < loop; i++)
                {
   
                    //  string DriversName = (row.Cells[1].Value.ToString()) == string.Empty ? "" : row.Cells["DriversName"].Value.ToString();
                    if (Convert.ToString(dgvExpenses.Rows[i].Cells[0].FormattedValue) != string.Empty)
                    {
                        Date = "'" + (dgvExpenses.Rows[i].Cells[0].FormattedValue.ToString()) + "'";
                    }
                    if (Convert.ToString(dgvExpenses.Rows[i].Cells[1].FormattedValue) != string.Empty)
                    {
                        Equipmentno = "'" + dgvExpenses.Rows[i].Cells[1].FormattedValue.ToString() + "'";
                    }
                    if (Convert.ToString(dgvExpenses.Rows[i].Cells[2].FormattedValue) != string.Empty)
                    {
                        mileage = "'" + dgvExpenses.Rows[i].Cells[2].FormattedValue.ToString() + "'";
                    }
                    if (Convert.ToString(dgvExpenses.Rows[i].Cells[3].FormattedValue) != string.Empty)
                    {
                        Problem = "'" + dgvExpenses.Rows[i].Cells[3].FormattedValue.ToString() + "'";
                    }


                    if (Convert.ToString(dgvExpenses.Rows[i].Cells[4].FormattedValue) != string.Empty)
                    {
                        Diagnosis = "'" + dgvExpenses.Rows[i].Cells[4].FormattedValue.ToString() + "'";
                    }


                    if (Convert.ToString(dgvExpenses.Rows[i].Cells[5].FormattedValue) != string.Empty)
                    {
                        item = "'" + dgvExpenses.Rows[i].Cells[5].FormattedValue.ToString() + "'";
                    }


                    if (Convert.ToString(dgvExpenses.Rows[i].Cells[6].FormattedValue) != string.Empty)
                    {
                        pcs = "'" + dgvExpenses.Rows[i].Cells[6].FormattedValue.ToString() + "'";
                    }
                    else
                    {
                        pcs = "0";
                    }
                    //   if (Convert.ToBoolean(dgvDailySheet.Rows[i].Cells["tank"].Value) == true)



                    if (Convert.ToString(dgvExpenses.Rows[i].Cells[7].FormattedValue) != string.Empty)
                    {
                        DriversName = "'" + dgvExpenses.Rows[i].Cells[7].FormattedValue.ToString().Replace(",", "") + "'";
                    }
                    
                    if (Convert.ToString(dgvExpenses.Rows[i].Cells[8].FormattedValue) != string.Empty)
                    {
                        mechanic = "'" + dgvExpenses.Rows[i].Cells[8].FormattedValue.ToString().Replace(",", "") + "'";
                    }
                    if (Convert.ToString(dgvExpenses.Rows[i].Cells[9].FormattedValue) != string.Empty)
                    {
                        Projectsite = "'" + dgvExpenses.Rows[i].Cells[9].FormattedValue.ToString() + "'";
                    }

                    if (Convert.ToString(dgvExpenses.Rows[i].Cells[10].FormattedValue) != string.Empty)
                    {
                        Remarks = "'" + dgvExpenses.Rows[i].Cells[10].FormattedValue.ToString() + "'";
                    }



                    if (Convert.ToString(dgvExpenses.Rows[i].Cells["Purchase"].Value) == "1")
                    // if (Convert.ToBoolean(dgvExpenses.Rows[i].Cells[7].Value) == true)
                    {
                        IsPurchase = "1";
                    }
                    else
                    {
                        IsPurchase = "0";
                    }
                    ////////
                    if (Convert.ToString(dgvExpenses.Rows[i].Cells[12].FormattedValue) != string.Empty)
                    {
                        pms = "'" + dgvExpenses.Rows[i].Cells[12].FormattedValue.ToString().Replace(",", "") + "'";
                    }
                    else
                    {
                        pms = "0";
                    }

                    if (Convert.ToString(dgvExpenses.Rows[i].Cells[13].FormattedValue) != string.Empty)
                    {
                        repair = "'" + dgvExpenses.Rows[i].Cells[13].FormattedValue.ToString().Replace(",", "") + "'";
                    }
                    else
                    {
                        repair = "0";
                    }

                    if (Convert.ToString(dgvExpenses.Rows[i].Cells[14].FormattedValue) != string.Empty)
                    {
                        tire = "'" + dgvExpenses.Rows[i].Cells[14].FormattedValue.ToString().Replace(",", "") + "'";
                    }
                    else
                    {
                        tire = "0";
                    }
                    /*
                  if (Convert.ToString(dgvExpenses.Rows[i].Cells[7].FormattedValue) != string.Empty)
                  {
                      StartRepair = "'" + dgvExpenses.Rows[i].Cells[7].FormattedValue.ToString() + "'";
                  }
                  else
                  {
                      StartRepair = "0";
                  }

                  if (Convert.ToString(dgvExpenses.Rows[i].Cells[8].FormattedValue) != string.Empty)
                  {
                      DateofPurchase = "'" + dgvExpenses.Rows[i].Cells[8].FormattedValue.ToString() + "'";
                  }
                  if (Convert.ToString(dgvExpenses.Rows[i].Cells[8].FormattedValue) != string.Empty)
                  {
                      DateofPurchase = "'" + dgvExpenses.Rows[i].Cells[8].FormattedValue.ToString() + "'";
                  }
                  else
                  {
                      DateofPurchase = "0";
                  }
                  */
                    if (Convert.ToString(dgvExpenses.Rows[i].Cells[15].FormattedValue) != string.Empty)
                    {
                        CategoryL = "'" + dgvExpenses.Rows[i].Cells[15].FormattedValue.ToString() + "'";
                    }
                    else
                    {
                        CategoryL = "0";
                    }
                    
                    if (CategoryL == "0")
                    {
                        MessageBox.Show("Please Select Category");
                    }
                    else
                    {
                        reader = monitoring.ExecuteReader(spName, Date, Equipmentno, Problem, Diagnosis, DriversName, Projectsite, Remarks, CategoryL, IsPurchase, pms, repair, tire, item, pcs, mechanic, mileage, userid);
                        DataTable Detail = new DataTable();
                        Detail.Load(reader);
                        result = Detail.Rows[0]["Result"].ToString();

                        if (result == "1")
                        {
                            dgvExpenses.Rows.Remove(dgvExpenses.Rows[i]);
                            i = i - 1;
                            loop = loop - 1;
                        }
                        else if (result == "2")
                        {
                            MessageBox.Show("You already requested for this Item :" + dgvExpenses.Rows[i].Cells[11].FormattedValue.ToString() + "Please Close to Continue");
                            dgvExpenses.Rows.Remove(dgvExpenses.Rows[i]);
                            i = i - 1;
                            loop = loop - 1;
                        }
                        else
                        {
                            dgvExpenses.Rows[i].DefaultCellStyle = new DataGridViewCellStyle { ForeColor = Color.Red };
                            //dgvExpenses.RowsDefaultCellStyle.ForeColor = Color.Red;
                        }

                    }

                    // ok = 0;
                }
            }
        }
    }
}
