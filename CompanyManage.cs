using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2_Project
{
    public partial class CompanyManage : Form
    {
        public CompanyManage()
        {
            InitializeComponent();
        }

        private void Reset()
        {
            txtId.Text = "Auto Generated";
            txtLNo.Text = txtName.Text = "";
            cmbApprovedBy.SelectedIndex = -1;
            cmbCompanyType.SelectedIndex = -1;

        }

        private void loadCompanyInfoComm(string search="")
        {
            try
            {
                string query = "select * from CompanyManage";

                if (!string.IsNullOrEmpty(search))
                {
                    int id;
                    if (int.TryParse(search, out id))
                    {
                        query += " where CompanyID=" + id + " OR CompanyName LIKE '%" + search + "%'";

                    }
                    else
                    {
                        query += " where CompanyName LIKE '%" + search + "%'";
                    }
                }

                var result = DbHelper.GetQueryData(query);
                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }

                

                dgvCompanyManage.DataSource = result.Data;
                dgvCompanyManage.Refresh();
                dgvCompanyManage.ClearSelection();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }



        }


        private void CompanyManage_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
        }

        private void CompanyManage_Load(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Hide();
               
            }
            this.loadCompanyInfoComm() ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string companyName = txtName.Text;
            string companyType = cmbCompanyType.Text;
            string lisenceNo = txtLNo.Text;
            string approveBy = cmbApprovedBy.Text;

            try
            {
                if (txtId.Text == "Auto Generated")
                {
                    string query = "insert into CompanyManage values('" + companyName + "' , '" + companyType + "', '" + lisenceNo + "' , '" + approveBy + "')";

                    var result = DbHelper.ExecuteNonResultQuery(query);
                    if (result.HasError)
                    {
                        MessageBox.Show(result.Message);
                        return;
                    }

                    MessageBox.Show("Saved");

                    this.loadCompanyInfoComm();
                    this.Reset();

                }

                else
                {
                    string query = "UPDATE CompanyManage SET " +
                        "CompanyName='" + companyName + "', " +
                        "CompanyType='" + companyType + "', " +
                        "LisenceNo='" + lisenceNo + "', " +
                         "ApprovedBy='" + approveBy + "'" +
                         "WHERE CompanyID=" + txtId.Text;



                    var result = DbHelper.ExecuteNonResultQuery(query);
                    if (result.HasError)
                    {
                        MessageBox.Show(result.Message);
                        return;
                    }

                    MessageBox.Show("Updated");


                    this.loadCompanyInfoComm();

                    this.Reset();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); return;
            }



        }

        private void dgvCompanyManage_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string query = "select * from CompanyManage";
                var result = DbHelper.GetQueryData(query);
                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }


                DataTable dt = result.Data;

                txtId.Text = dgvCompanyManage.Rows[e.RowIndex].Cells["dgvId"].Value.ToString();
                txtName.Text = dgvCompanyManage.Rows[e.RowIndex].Cells["dgvCompanyName"].Value.ToString();
                txtLNo.Text = dgvCompanyManage.Rows[e.RowIndex].Cells["dgvLisNo"].Value.ToString();
                cmbCompanyType.SelectedItem = dgvCompanyManage.Rows[e.RowIndex].Cells["dgvComType"].Value.ToString();
                cmbApprovedBy.SelectedItem = dgvCompanyManage.Rows[e.RowIndex].Cells["dgvApprovedBy"].Value.ToString();

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
                
                string deleteBookingQuery = "DELETE FROM Booking WHERE BookedCompanyID = " + txtId.Text;
                var resultBooking = DbHelper.ExecuteNonResultQuery(deleteBookingQuery);
                if (resultBooking.HasError)
                {
                    MessageBox.Show(resultBooking.Message);
                    return;
                }

                
                string deleteVehicleQuery = "DELETE FROM VehicleManage WHERE VehicleComId = " + txtId.Text;
                var resultVehicle = DbHelper.ExecuteNonResultQuery(deleteVehicleQuery);
                if (resultVehicle.HasError)
                {
                    MessageBox.Show(resultVehicle.Message);
                    return;
                }

                
                string deleteCompanyQuery = "DELETE FROM CompanyManage WHERE CompanyID = " + txtId.Text;
                var resultCompany = DbHelper.ExecuteNonResultQuery(deleteCompanyQuery);
                if (resultCompany.HasError)
                {
                    MessageBox.Show(resultCompany.Message);
                    return;
                }

                MessageBox.Show("Company and all related data (vehicles + bookings) deleted successfully.");
                this.loadCompanyInfoComm();
                this.Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Reset();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.loadCompanyInfoComm(txtSearch.Text);
            
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            this.loadCompanyInfoComm();
        }

        
    }
}
