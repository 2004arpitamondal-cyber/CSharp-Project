using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OOP2_Project
{
    public partial class VehicleManage : Form
    {
        public VehicleManage()
        {
            InitializeComponent();
        }

       

    private void VehicleManage_FormClosed(object sender, FormClosedEventArgs e)
    {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
    }
        private void Reset()
        {
            txtId.Text = "Auto Generated";

           
            txtCapacity.Clear();
            txtStartingPoint.Clear();
            txtDestination.Clear();
            txtTicketPrice.Clear();
            txtSearch.Clear();
            txtDriverId.Clear();

            cmbVehicleType.SelectedIndex = -1;
            cmbFitnessInfo.SelectedIndex = -1;
            cmbCompanyName.SelectedIndex = -1;

            
            DOB.Value = DateTime.Now;

            
            dgvVehicleManage.ClearSelection();

        }
        private void loadCompany()
        {
            try
            {
                string query = "select CompanyName from CompanyManage";
                var result = DbHelper.GetQueryData(query);
                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }

                List<string> list = new List<string>();
                foreach (DataRow row in result.Data.Rows)
                {
                   
                    list.Add(row["CompanyName"].ToString());
                }


                cmbCompanyName.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void loadVehicleInfoComm(string search = "")
        {
            try
            {
                string query = @"SELECT 
                    VehicleID,
                    VehicleType,
                    Capacity,
                    FitnessInfo,
                    StartingPoint,
                    Destination,
                    
                    [Date] AS VehicleDate,
                    TicketPrice,
                    driverId,
                    (SELECT CompanyName FROM CompanyManage WHERE CompanyManage.CompanyID = VehicleManage.VehicleComId) AS Company
                 FROM VehicleManage";

                if (!string.IsNullOrEmpty(search))
                {
                    int id;
                    if (int.TryParse(search, out id))
                    {
                        query += " WHERE (VehicleID=" + id +
                                 " OR (SELECT CompanyName FROM CompanyManage WHERE CompanyManage.CompanyID = VehicleManage.VehicleComId) LIKE '%" + search + "%')";
                    }
                    else
                    {
                        query += " WHERE (SELECT CompanyName FROM CompanyManage WHERE CompanyManage.CompanyID = VehicleManage.VehicleComId) LIKE '%" + search + "%'";
                    }
                }

                var result = DbHelper.GetQueryData(query);
                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }



                dgvVehicleManage.DataSource = result.Data;
                dgvVehicleManage.Refresh();
                dgvVehicleManage.ClearSelection();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }



        }

        private void VehicleManage_Load(object sender, EventArgs e)
        {
            this.loadCompany();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string vehicleType = cmbVehicleType.Text;
            string capacity = txtCapacity.Text;
            string comName = cmbCompanyName.Text;
            string fitnessInfo = cmbFitnessInfo.Text;
            string from = txtStartingPoint.Text;
            string to = txtDestination.Text;
            string date = DOB.Value.ToString();
            string ticketPrice = txtTicketPrice.Text;
            string driverId = txtDriverId.Text;

            try
            {
                
                if (string.IsNullOrEmpty(comName))
                {
                    MessageBox.Show("Please select a company.");
                    return;
                }

               
                string query1 = "SELECT CompanyID FROM CompanyManage WHERE CompanyName='" + comName + "'";
                var result2 = DbHelper.GetQueryData(query1);
                if (result2.HasError)
                {
                    MessageBox.Show(result2.Message);
                    return;
                }

                if (result2.Data.Rows.Count == 0)
                {
                    MessageBox.Show("Selected company not found in database.");
                    return;
                }

                int comId = int.Parse(result2.Data.Rows[0]["CompanyID"].ToString());

                if (txtId.Text == "Auto Generated")
                {
                    
                    string query = "INSERT INTO VehicleManage " +
                                   "(VehicleType, Capacity, FitnessInfo, StartingPoint, Destination, Date, TicketPrice, VehicleComId, driverId) " +
                                   "VALUES ('" + vehicleType + "', '" + capacity + "', '" + fitnessInfo + "', '" + from + "', '" + to + "', '" + DOB.Value + "', '" + ticketPrice + "', '" + comId + "', '" + driverId + "')";

                    var result = DbHelper.ExecuteNonResultQuery(query);
                    if (result.HasError)
                    {
                        MessageBox.Show(result.Message);
                        return;
                    }

                    MessageBox.Show("Saved successfully.");
                }
                else
                {
                   
                    string query = "UPDATE VehicleManage SET " +
                                   "VehicleType='" + vehicleType + "', " +
                                   "Capacity='" + capacity + "', " +
                                   "FitnessInfo='" + fitnessInfo + "', " +
                                   "StartingPoint='" + from + "', " +
                                   "Destination='" + to + "', " +
                                   "Date='" + Convert.ToDateTime(date) + "', " +
                                   "TicketPrice='" + ticketPrice + "', " +
                                   "VehicleComId='" + comId + "', " +
                                   "driverId='" + driverId + "' " +
                                   "WHERE VehicleID=" + txtId.Text;

                    var result = DbHelper.ExecuteNonResultQuery(query);
                    if (result.HasError)
                    {
                        MessageBox.Show(result.Message);
                        return;
                    }

                    MessageBox.Show("Updated successfully.");
                }

               
                this.loadVehicleInfoComm();
                this.Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }

        private void dgvVehicleManage_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string query = "select * from VehicleManage";
                var result = DbHelper.GetQueryData(query);
                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }


                DataTable dt = result.Data;

                txtId.Text = dgvVehicleManage.Rows[e.RowIndex].Cells["dgvVehicleId"].Value.ToString();
                cmbCompanyName.SelectedItem = dgvVehicleManage.Rows[e.RowIndex].Cells["Company"].Value.ToString();
                cmbVehicleType.SelectedItem = dgvVehicleManage.Rows[e.RowIndex].Cells["dgvVehicleType"].Value.ToString();
                txtCapacity.Text = dgvVehicleManage.Rows[e.RowIndex].Cells["dgvCapacity"].Value.ToString();
                cmbFitnessInfo.SelectedItem = dgvVehicleManage.Rows[e.RowIndex].Cells["dgvFitnessInfo"].Value.ToString();
                txtStartingPoint.Text = dgvVehicleManage.Rows[e.RowIndex].Cells["dgvFrom"].Value.ToString();
                txtDestination.Text = dgvVehicleManage.Rows[e.RowIndex].Cells["dgvTo"].Value.ToString();
                DOB.Value = Convert.ToDateTime(dgvVehicleManage.Rows[e.RowIndex].Cells["VehicleDate"].Value);

                txtTicketPrice.Text = dgvVehicleManage.Rows[e.RowIndex].Cells["dgvTicketPrice"].Value.ToString();
                txtDriverId.Text = dgvVehicleManage.Rows[e.RowIndex].Cells["dgvDriverid"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "DELETE from VehicleManage where VehicleID=" + txtId.Text;

                var result = DbHelper.ExecuteNonResultQuery(query);
                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }

                MessageBox.Show("Deleted");
                this.loadVehicleInfoComm();
                this.Reset();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return; }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.loadVehicleInfoComm(txtSearch.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Reset();
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            this.loadVehicleInfoComm();
        }

       
        private void VehicleManage_Load_1(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Hide();
            }
            this.loadCompany();
        }

        private void VehicleManage_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
