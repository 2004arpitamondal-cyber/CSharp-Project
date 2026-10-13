using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2_Project
{
    public partial class PassengerDetails : Form
    {
        public PassengerDetails()
        {
            InitializeComponent();
        }
        private void LoadBookingData(string searchValue = "")
        {
            try
            {
                string query = @"SELECT 
                                 b.BookId,
                                 b.BookedVehicleId,
                                 c.CompanyName,
                                 b.BookedFrom,
                                 b.BookedTo,
                                 b.Bookeddate,
                                 b.BookedTotalPrice,
                                 b.BookedPayment
                                 FROM Booking b
    
                                  INNER JOIN CompanyManage c ON b.BookedCompanyID = c.CompanyID ";

                if (!string.IsNullOrEmpty(searchValue))
                {
                    int id;
                    if (int.TryParse(searchValue, out id))
                    {
                        
                        query += " AND (b.BookId = " + id + " OR c.CompanyName LIKE '%" + searchValue + "%')";
                    }
                    else
                    {
                        
                        query += " AND c.CompanyName LIKE '%" + searchValue + "%'";
                    }
                }

                var result = DbHelper.GetQueryData(query);
                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }

                dgvPassengerDetails.DataSource = result.Data;
                dgvPassengerDetails.Refresh();
                dgvPassengerDetails.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


       
        private void OrderDetailsShow_Load(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Hide();
            }

            LoadBookingData();
        }

        
      
        private void PassengerDetails_Load(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Hide();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadBookingData(txtSearch.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadBookingData();
        }

        private void dgvPassengerDetails_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void PassengerDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
        }
    }
}
