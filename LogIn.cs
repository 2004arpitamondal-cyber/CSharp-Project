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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        public static int LoggedInUserId { get; set; }
        public static string LoggedInUserType { get; set; }

        private void LogIn_Load(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Hide();
            }
        }

        private void LogIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
        }

        private void SignBtn_Click(object sender, EventArgs e)
        {

            SignUp sign = new SignUp();
            sign.Show(this);
        }

        private void LogBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text.Trim();
                string password = txtPass.Text.Trim();

                if (string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Enter Email");
                    return;
                }

                if (string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Enter Password");
                    return;
                }

                string manageUserQuery = $"SELECT * FROM ManageUser WHERE Email='{email}' AND Password='{password}'";
                var manageUserResult = DbHelper.GetQueryData(manageUserQuery);

                if (!manageUserResult.HasError && manageUserResult.Data.Rows.Count == 1)
                {
                    DataRow row = manageUserResult.Data.Rows[0];
                    LoggedInUserId = Convert.ToInt32(row["UserId"]);
                    LoggedInUserType = row["UserType"].ToString().ToLower();

                    if (LoggedInUserType == "admin")
                    {
                        AdminDeshboard admin = new AdminDeshboard();
                        admin.Show(this);
                        return;
                    }
                    else if (LoggedInUserType == "driver")
                    {
                        DriverDashboard driver = new DriverDashboard();
                        driver.Show(this);
                        return;
                    }
                }



                string passengerQuery = $"SELECT * FROM SignUp WHERE Email='{email}' AND Password='{password}'";
                var passengerResult = DbHelper.GetQueryData(passengerQuery);
                if (!passengerResult.HasError && passengerResult.Data.Rows.Count == 1)
                {
                    LoggedInUserId = Convert.ToInt32(passengerResult.Data.Rows[0]["ID"]);
                    LoggedInUserType = "Passenger";

                    PassengerDeshboard passenger = new PassengerDeshboard();
                    passenger.Show(this);
                    return;
                }

                

                MessageBox.Show("Incorrect Email or Password");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        
    }
}
