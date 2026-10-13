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
    public partial class AdminDeshboard : Form
    {
        public AdminDeshboard()
        {
            InitializeComponent();
        }

        
        

        private void BtnCompanymanage_Click_1(object sender, EventArgs e)
        {
            CompanyManage cm = new CompanyManage();
            cm.Show(this);
        }

        private void btnManageUser_Click(object sender, EventArgs e)
        {
            ManageUser cm = new ManageUser();
            cm.Show(this);
        }

        private void btnVehicleManage_Click(object sender, EventArgs e)
        {
            VehicleManage cm = new VehicleManage();
            cm.Show(this);
        }

        private void btnPassengerDetails_Click(object sender, EventArgs e)
        {
            PassengerDetails cm = new PassengerDetails();
            cm.Show(this);
        }

        private void AdminDeshboard_Load(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Hide();
            }
        }

        private void AdminDeshboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DriverDetails cm = new DriverDetails();
            cm.Show(this);
        }
    }
}
