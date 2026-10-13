using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace OOP2_Project
{
    public partial class PassengerDeshboard : Form
    {
        public PassengerDeshboard()
        {
            InitializeComponent();
        }

        private void PassengerDeshboard_Load(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Hide();
            }

            this.LoadFromAndTo();
        }

        private void reset()
        {
            txtId.Text = "Auto Generated";
            txtCompanyName.Text = "";
            txtfrom.Text = "";
            txtto.Text = "";
            txtTicketPrice.Text = "";
            txtTicketCount.Text = "";
            txtTotalprice.Text = "";
            dob.Value = DateTime.Now;
            cmbPayment.SelectedIndex = -1;
        }

        private void LoadFromAndTo()
        {
            try
            {
                string queryFrom = "SELECT DISTINCT StartingPoint FROM VehicleManage";
                var resultFrom = DbHelper.GetQueryData(queryFrom);

                if (resultFrom.HasError)
                {
                    MessageBox.Show(resultFrom.Message);
                    return;
                }

                List<string> fromList = new List<string>();

                foreach (DataRow row in resultFrom.Data.Rows)
                {
                    fromList.Add(row["StartingPoint"].ToString());
                }

                cmbFrom.DataSource = fromList;


                string queryTo = "SELECT DISTINCT Destination FROM VehicleManage";
                var resultTo = DbHelper.GetQueryData(queryTo);

                if (resultTo.HasError)
                {
                    MessageBox.Show(resultTo.Message);
                    return;
                }

                List<string> toList = new List<string>();

                foreach (DataRow row in resultTo.Data.Rows)
                {
                    toList.Add(row["Destination"].ToString());
                }

                cmbTo.DataSource = toList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string from = cmbFrom.Text;
                string to = cmbTo.Text;
                string date = dobPassenger.Value.ToShortDateString();

                string query = @"SELECT 
                                v.VehicleID,
                                c.CompanyName,
                                v.StartingPoint,
                                v.Destination,
                                v.Date,
                                v.TicketPrice
                             FROM VehicleManage v
                             JOIN CompanyManage c 
                             ON v.VehicleComId = c.CompanyID
                             WHERE v.StartingPoint = '" + from +
                             "' AND v.Destination = '" + to +
                             "' AND CONVERT(date, v.Date) = CONVERT(date, '" + date + "')";

                var result = DbHelper.GetQueryData(query);

                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }

                dgvVehicleList.DataSource = result.Data;
                dgvVehicleList.Refresh();
                dgvVehicleList.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void dgvVehicleList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    return;

                txtVehicleId.Text =
                    dgvVehicleList.Rows[e.RowIndex].Cells["dgvVehicleid"].Value.ToString();

                txtCompanyName.Text =
                    dgvVehicleList.Rows[e.RowIndex].Cells["dgvCompanyName"].Value.ToString();

                txtfrom.Text =
                    dgvVehicleList.Rows[e.RowIndex].Cells["dgvFrom"].Value.ToString();

                txtto.Text =
                    dgvVehicleList.Rows[e.RowIndex].Cells["dgvTo"].Value.ToString();

                dob.Text =
                    dgvVehicleList.Rows[e.RowIndex].Cells["dgvDate"].Value.ToString();

                txtTicketPrice.Text =
                    dgvVehicleList.Rows[e.RowIndex].Cells["dgvTicketPrice"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void txtTicketCount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTicketPrice.Text) ||
                    string.IsNullOrEmpty(txtTicketCount.Text))
                {
                    txtTotalprice.Text = "";
                    return;
                }

                int price = int.Parse(txtTicketPrice.Text);
                int count = int.Parse(txtTicketCount.Text);

                txtTotalprice.Text = (price * count).ToString();
            }
            catch
            {
                txtTotalprice.Text = "";
            }
        }


        private void btnBooking_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtVehicleId.Text))
                {
                    MessageBox.Show("Please select a vehicle first!");
                    return;
                }

                if (string.IsNullOrEmpty(txtTicketCount.Text))
                {
                    MessageBox.Show("Please enter ticket count!");
                    return;
                }

                if (string.IsNullOrEmpty(cmbPayment.Text))
                {
                    MessageBox.Show("Please select a payment method!");
                    return;
                }


                string vehicleId = txtVehicleId.Text;
                string comName = txtCompanyName.Text;
                string from = txtfrom.Text;
                string to = txtto.Text;
                string ticketPrice = txtTicketPrice.Text;
                string ticketCount = txtTicketCount.Text;
                string totalPrice = txtTotalprice.Text;
                string payment = cmbPayment.Text;


                string queryToGetComId =
                    "SELECT CompanyID FROM CompanyManage WHERE CompanyName = '" +
                    comName + "'";

                var result = DbHelper.GetQueryData(queryToGetComId);

                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }

                if (result.Data.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "Company not found! Please check the company name.");
                    return;
                }

                int companyId =
                    int.Parse(result.Data.Rows[0]["CompanyID"].ToString());


                string query =
                    "INSERT INTO Booking " +
                    "(BookedVehicleId, BookedCompanyID, BookedFrom, BookedTo, " +
                    "Bookeddate, BookedTicketPrice, BookedTicketCount, " +
                    "BookedTotalPrice, BookedPayment) " +
                    "VALUES ('" + vehicleId + "', '" +
                    companyId + "', '" +
                    from + "', '" +
                    to + "', '" +
                    dob.Value + "', '" +
                    ticketPrice + "', '" +
                    ticketCount + "', '" +
                    totalPrice + "', '" +
                    payment + "')";


                var BookInsert =
                    DbHelper.ExecuteNonResultQuery(query);

                if (BookInsert.HasError)
                {
                    MessageBox.Show(BookInsert.Message);
                    return;
                }


                MessageBox.Show("Booking Confirmed Successfully!");

                this.reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            this.reset();
        }


        private void PassengerDeshboard_FormClosed(
            object sender,
            FormClosedEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
        }


        // Button 2 Click Event
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}