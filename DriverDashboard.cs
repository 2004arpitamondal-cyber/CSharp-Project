using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2_Project
{
    public partial class DriverDashboard : Form
    {
        private string driverId;

        public DriverDashboard()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DriverDashboard_Load(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Hide();
            }
        }

        private void DriverDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
        }
        private void reset()
        {
            txtId.Text = "Auto Generated";
            txtVehicleId.Text = txtCompanyName.Text = txtFrom.Text = txtTo.Text = "";
            dtp.Value = DateTime.Now;
            cmbTrip.SelectedIndex = -1;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                
                string query = @"SELECT v.VehicleID, c.CompanyName, v.StartingPoint, v.Destination, v.Date 
                                 FROM VehicleManage v
                                 JOIN CompanyManage c ON v.VehicleComId = c.CompanyID
                                 WHERE v.driverId = " + txtUserId.Text;

                var result = DbHelper.GetQueryData(query);
                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }

                dgvDriverDashboard.DataSource = result.Data;
                dgvDriverDashboard.Refresh();
                dgvDriverDashboard.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDriverDashboard_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

                txtVehicleId.Text = dgvDriverDashboard.Rows[e.RowIndex].Cells["VehicleID"].Value.ToString();
                txtCompanyName.Text = dgvDriverDashboard.Rows[e.RowIndex].Cells["CompanyName"].Value.ToString();
                txtFrom.Text = dgvDriverDashboard.Rows[e.RowIndex].Cells["StartingPoint"].Value.ToString();
                txtTo.Text = dgvDriverDashboard.Rows[e.RowIndex].Cells["Destination"].Value.ToString();
                var dateValue = dgvDriverDashboard.Rows[e.RowIndex].Cells["Date"].Value;

                if (dateValue != DBNull.Value && !string.IsNullOrEmpty(dateValue.ToString()))
                    dtp.Value = Convert.ToDateTime(dateValue);
                else
                    dtp.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtVehicleId.Text))
                {
                    MessageBox.Show("Please select a vehicle first!");
                    return;
                }

                if (cmbTrip.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select a trip.");
                    return;
                }

                string vehicleId = txtVehicleId.Text;
                string companyName = txtCompanyName.Text;
                string from = txtFrom.Text;
                string to = txtTo.Text;
                //string date = dtp.Value.ToString("yyyy-MM-dd"); 
                string trip = cmbTrip.Text;

                

                string query = @"INSERT INTO DriverDetails 
                        (DriDetVehicleId, DriDetCompanyName, DriDetFrom, DriDetTo, DriDetDate, DriDetTrip)
                        VALUES ('" + vehicleId + "', '" + companyName + "', '" + from + "', '" + to + "', '" + dtp.Value + "', '" + trip + "')";

                var result = DbHelper.ExecuteNonResultQuery(query);

                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }







                MessageBox.Show("Trip information updated successfully!");
                this.reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.reset();
        }
    }
}
