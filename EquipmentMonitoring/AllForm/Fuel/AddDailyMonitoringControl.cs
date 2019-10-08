using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using EquipmentMonitoring.Repository;
using System.Collections;
using System.Data.SqlClient;

namespace EquipmentMonitoring.AllForm.Fuel
{
    public partial class AddDailyMonitoringControl : UserControl
    {

        //MonitoringRepository monitoring = new MonitoringRepository();
        //string Connection = ConfigurationManager.ConnectionStrings["Maintenancedb"].ToString();
        //ArrayList EquipArray = new ArrayList();
        //DataTable dt = new DataTable();
        //DataTable unit = new DataTable();
        //ArrayList EmployeeArray = new ArrayList();

        DataGridViewComboBoxColumn combo = new DataGridViewComboBoxColumn();

        public AddDailyMonitoringControl()
        {
            InitializeComponent();
        }

        private void FillEquipment(AutoCompleteStringCollection data)
        {
            //foreach (var item in EquipArray)
            //    data.AddRange(new string[] { item.ToString() });
        }

        private void FillEmployee(AutoCompleteStringCollection data)
        {
            //foreach (var item in EmployeeArray)
            //    data.AddRange(new string[] { item.ToString() });
        }
        public void Param()
        {
            //using (SqlConnection Con = new SqlConnection(Connection))
            //{
            //    SqlDataAdapter da = new SqlDataAdapter("Select m_TankList.TankName from m_TankList with (nolock)  order by id asc", Con);

            //    da.Fill(dt);

            //    combo.HeaderText = "SOURCE OF FUEL";
            //    combo.Name = "Source";

            //    ArrayList row = new ArrayList();

            //    foreach (DataRow dr in dt.Rows)
            //    {
            //        row.Add(dr["TankName"].ToString());
            //    }


            //    combo.Items.AddRange(row.ToArray());

            //    dgvDailySheet.Columns.Add(combo);
            //    dgvDailySheet.Columns[11].Width = 150;

            //}


            //using (SqlConnection Con = new SqlConnection(Connection))
            //{
            //    SqlDataAdapter da = new SqlDataAdapter("Select * from m_ServiceUnitList with (nolock)", Con);

            //    da.Fill(unit);


            //    foreach (DataRow dr in unit.Rows)
            //    {
            //        EquipArray.Add(dr["EquipmentNo"].ToString());
            //        EquipArray.Add(dr["Model"].ToString());
            //        EquipArray.Add(dr["PlateNo"].ToString());
            //    }
            //}

            //using (SqlConnection Con = new SqlConnection(Connection))
            //{
            //    SqlDataAdapter da = new SqlDataAdapter("Select * from m_Drivelist with (nolock)", Con);

            //    da.Fill(unit);

            //    foreach (DataRow dr in unit.Rows)
            //    {
            //        EmployeeArray.Add(dr["Name"].ToString());
            //    }
            //}

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            //DialogResult dialogResult = MessageBox.Show("Please Click Yes To Continue SAVE", "Save", MessageBoxButtons.YesNo);
            //if (dialogResult == DialogResult.Yes)
            //{
            //    MessageBox.Show("YES");
            //}
            //else
            //{
            //    MessageBox.Show("No");
            //}
        }

        private void dgvDailySheet_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //TextBox auto = e.Control as TextBox;

            //if (dgvDailySheet.CurrentCell.ColumnIndex == 2)
            //{
            //    try
            //    {
            //        if (auto != null)
            //        {
            //            auto.AutoCompleteCustomSource.Clear();
            //            auto.AutoCompleteMode = AutoCompleteMode.Suggest;
            //            auto.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            //            FillEquipment(data);
            //            auto.AutoCompleteCustomSource = data;
            //        }
            //    }
            //    catch { }
            //}
            //else if (dgvDailySheet.CurrentCell.ColumnIndex == 3)
            //{
            //    try
            //    {
            //        auto.AutoCompleteCustomSource.Clear();
            //        auto.AutoCompleteMode = AutoCompleteMode.Suggest;
            //        auto.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //        AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            //        FillEmployee(data);
            //        auto.AutoCompleteCustomSource = data;
            //    }
            //    catch { }
            //}
            //else if (dgvDailySheet.CurrentCell.ColumnIndex == 10)
            //{
            //    try
            //    {
            //        auto.AutoCompleteCustomSource.Clear();
            //        auto.AutoCompleteMode = AutoCompleteMode.Suggest;
            //        auto.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //        AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            //        FillEmployee(data);
            //        auto.AutoCompleteCustomSource = data;
            //    }
            //    catch { }
            //}
            //else if (dgvDailySheet.CurrentCell.ColumnIndex == 13)
            //{
            //}
            //else
            //{
            //    try
            //    {
            //        auto.AutoCompleteCustomSource.Clear();
            //    }
            //    catch { }
            //}
        }

        /*


        private void dgvDailySheet_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

        }
        */

    }
}
