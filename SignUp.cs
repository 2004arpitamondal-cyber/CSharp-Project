using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OOP2_Project
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void ResetComm()
        {
            
            txtFullName.Text = txtEmail.Text = txtPass.Text = txtNumber.Text= "";
           

        }
        private void SignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Hide();
                this.ResetComm();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {

                string fullName = txtFullName.Text;
                string email = txtEmail.Text;
                string password = txtPass.Text;
                string gender = "";
                if (MaleRdb.Checked)
                {
                    gender = MaleRdb.Text;
                }
                else if (FemaleRdb.Checked)
                {
                    gender = FemaleRdb.Text;
                }

                if (string.IsNullOrWhiteSpace(fullName))
                {
                    MessageBox.Show("Error: Fill Up Fullname");
                    return;
                }
                if (string.IsNullOrWhiteSpace(email))
                {
                    MessageBox.Show("Error: Fill Up Email");
                    return;
                }
                if (!email.EndsWith("@gmail.com"))
                {
                    MessageBox.Show("Error Syntax");
                    return;
                }
                if (string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Error: Fill Up Password");
                    return;
                }
                if (string.IsNullOrWhiteSpace(gender))
                {
                    MessageBox.Show("Error: select Gender");
                    return;
                }

                string mobileNumber = txtNumber.Text;
                if (string.IsNullOrWhiteSpace(mobileNumber))
                {
                    MessageBox.Show("Error: Fill Up Mobile Number");
                    return;
                }
               
                if (!(mobileNumber.StartsWith("01") && mobileNumber.Length == 11 && mobileNumber.All(char.IsDigit)))
                {
                    MessageBox.Show(" Mobile number must start with 01 and be exactly 11 digits");
                    return;
                }



                string query = @"INSERT INTO SignUp (FullName, Email, Password, Gender, MobileNumber)
                         OUTPUT INSERTED.ID
                         VALUES('" + fullName + "', '" + email + "', '" + password + "', '" + gender + "', '" + mobileNumber + "')";

                var result = DbHelper.ExecuteNonResultQuery(query);
                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }
                MessageBox.Show("Sign Up Successful!");

                LogIn log = new LogIn();
                log.Show(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

      

      
    }
}
