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
    public partial class ManageUser : Form
    {
        public ManageUser()
        {
            InitializeComponent();
        }
        
        private void ResetComm()
        {
            txtId.Text = "Auto Generated";
            txtName.Text = txtEmail.Text = txtPass.Text = "";
            rbtAdmin.Checked = rbtDriver.Checked = false;


        }
        private void loadUserInfoComm(string searchValue = "")
        {
            try
            {
                string query = @"SELECT 
                                 UserId,
                                 Name,
                                 Email,
                                 Password,
                                 UserType
                                 FROM ManageUser";

                if (!string.IsNullOrEmpty(searchValue))
                {
                    int id;
                    if (int.TryParse(searchValue, out id))
                    {
                        query += " WHERE UserId=" + id + " OR Name LIKE '%" + searchValue + "%'";
                    }
                    else
                    {
                        query += " WHERE Name LIKE '%" + searchValue + "%'";
                    }
                }

                var result = DbHelper.GetQueryData(query);
                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }

                dgvManageUser.DataSource = result.Data;
                dgvManageUser.Refresh();
                dgvManageUser.ClearSelection();

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void ManageUser_Load(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Hide();
            }
        }
        private void ManageUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            this.loadUserInfoComm();
        }
       

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text.Trim();
                string email = txtEmail.Text.Trim();
                string pass = txtPass.Text.Trim();
                string userType = rbtAdmin.Checked ? rbtAdmin.Text :
                                  rbtDriver.Checked ? rbtDriver.Text : "";

                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Enter Name");
                    return;
                }

                if (string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Enter Email");
                    return;
                }

                if (string.IsNullOrEmpty(pass))
                {
                    MessageBox.Show("Enter Password");
                    return;
                }

                if (string.IsNullOrEmpty(userType))
                {
                    MessageBox.Show("Select User Type");
                    return;
                }

                string query;

                
                if (txtId.Text == "Auto Generated")
                {
                    query = "INSERT INTO ManageUser (Name, Email, Password, UserType) " +
                            "VALUES ('" + name + "', '" + email + "', '" + pass + "', '" + userType + "')";
                    var result = DbHelper.ExecuteNonResultQuery(query);
                    if (result.HasError)
                    {
                        MessageBox.Show(result.Message);
                        return;
                    }
                    MessageBox.Show("User Saved Successfully!");
                    this.loadUserInfoComm();
                    this.ResetComm();
                }
                
                else
                {
                    query = "UPDATE ManageUser SET " +
                            "Name='" + name + "', " +
                            "Email='" + email + "', " +
                            "Password='" + pass + "', " +
                            "UserType='" + userType + "' " +
                            "WHERE UserId=" + txtId.Text;
                    var result = DbHelper.ExecuteNonResultQuery(query);
                    if (result.HasError)
                    {
                        MessageBox.Show(result.Message);
                        return;
                    }
                    MessageBox.Show("User Updated Successfully!");
                }

                
                this.loadUserInfoComm();
                this.ResetComm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.loadUserInfoComm(txtSearch.Text);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.ResetComm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text == "Auto Generated")
                {
                    MessageBox.Show("Select a row first");
                    return;
                }

                string query = "DELETE FROM ManageUser WHERE UserId=" + txtId.Text;
                var result = DbHelper.ExecuteNonResultQuery(query);
                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }

                MessageBox.Show("Deleted Successfully");

               
                this.loadUserInfoComm();
                this.ResetComm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void dgvManageUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                {
                    dgvManageUser.ClearSelection();
                    return;
                }

                
                txtId.Text = dgvManageUser.Rows[e.RowIndex].Cells["dgUserId"].Value.ToString();
                txtName.Text = dgvManageUser.Rows[e.RowIndex].Cells["dgName"].Value.ToString();
                txtEmail.Text = dgvManageUser.Rows[e.RowIndex].Cells["dgEmail"].Value.ToString();
                txtPass.Text = dgvManageUser.Rows[e.RowIndex].Cells["dgPass"].Value.ToString();

                string userType = dgvManageUser.Rows[e.RowIndex].Cells["dgUserType"].Value.ToString();
                rbtAdmin.Checked = userType == rbtAdmin.Text;
                rbtDriver.Checked = userType == rbtDriver.Text;

                dgvManageUser.CurrentRow.Selected = true; 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
    }
