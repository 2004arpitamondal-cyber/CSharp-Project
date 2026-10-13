using System;
using System.Collections;
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
    public partial class DriverDetails : Form
    {
        public DriverDetails()
        {
            InitializeComponent();
        }

        private void DriverDetails_Load(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Hide();
            }
        }

        private void DriverDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show(); 
            }
        }


        private void LoadDriverData(string searchValue = "")
        {

            try
            {
                string getDriverDetails = "select * from DriverDetails";

                var getDetails = DbHelper.GetQueryData(getDriverDetails);

                if (getDetails.HasError)
                {
                    MessageBox.Show(getDetails.Message);
                    return;
                }

                dgvDriverDetails.DataSource = getDetails.Data;
                dgvDriverDetails.Refresh(); 
                dgvDriverDetails.ClearSelection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.LoadDriverData(txtSearch.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadDriverData();
        }
    }
}
