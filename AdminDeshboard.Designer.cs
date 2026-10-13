namespace OOP2_Project
{
    partial class AdminDeshboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDeshboard));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnManageUser = new System.Windows.Forms.Button();
            this.btnPassengerDetails = new System.Windows.Forms.Button();
            this.btnVehicleManage = new System.Windows.Forms.Button();
            this.BtnCompanymanage = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1330, 668);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnManageUser);
            this.panel1.Controls.Add(this.btnPassengerDetails);
            this.panel1.Controls.Add(this.btnVehicleManage);
            this.panel1.Controls.Add(this.BtnCompanymanage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(668, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 662);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 29);
            this.label2.TabIndex = 19;
            this.label2.Text = "Welcome Admin , ";
            // 
            // btnManageUser
            // 
            this.btnManageUser.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnManageUser.Font = new System.Drawing.Font("Times New Roman", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUser.Location = new System.Drawing.Point(206, 102);
            this.btnManageUser.Name = "btnManageUser";
            this.btnManageUser.Size = new System.Drawing.Size(271, 72);
            this.btnManageUser.TabIndex = 18;
            this.btnManageUser.Text = "Manage User";
            this.btnManageUser.UseVisualStyleBackColor = false;
            this.btnManageUser.Click += new System.EventHandler(this.btnManageUser_Click);
            // 
            // btnPassengerDetails
            // 
            this.btnPassengerDetails.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPassengerDetails.Font = new System.Drawing.Font("Times New Roman", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassengerDetails.Location = new System.Drawing.Point(206, 453);
            this.btnPassengerDetails.Name = "btnPassengerDetails";
            this.btnPassengerDetails.Size = new System.Drawing.Size(271, 65);
            this.btnPassengerDetails.TabIndex = 16;
            this.btnPassengerDetails.Text = "Passenger Details";
            this.btnPassengerDetails.UseVisualStyleBackColor = false;
            this.btnPassengerDetails.Click += new System.EventHandler(this.btnPassengerDetails_Click);
            // 
            // btnVehicleManage
            // 
            this.btnVehicleManage.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnVehicleManage.Font = new System.Drawing.Font("Times New Roman", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehicleManage.Location = new System.Drawing.Point(206, 328);
            this.btnVehicleManage.Name = "btnVehicleManage";
            this.btnVehicleManage.Size = new System.Drawing.Size(271, 77);
            this.btnVehicleManage.TabIndex = 15;
            this.btnVehicleManage.Text = "Vehicles Manage";
            this.btnVehicleManage.UseVisualStyleBackColor = false;
            this.btnVehicleManage.Click += new System.EventHandler(this.btnVehicleManage_Click);
            // 
            // BtnCompanymanage
            // 
            this.BtnCompanymanage.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BtnCompanymanage.Font = new System.Drawing.Font("Times New Roman", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCompanymanage.Location = new System.Drawing.Point(206, 215);
            this.BtnCompanymanage.Name = "BtnCompanymanage";
            this.BtnCompanymanage.Size = new System.Drawing.Size(271, 69);
            this.BtnCompanymanage.TabIndex = 14;
            this.BtnCompanymanage.Text = "Company Manage";
            this.BtnCompanymanage.UseVisualStyleBackColor = false;
            this.BtnCompanymanage.Click += new System.EventHandler(this.BtnCompanymanage_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(659, 662);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(206, 559);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 65);
            this.button1.TabIndex = 20;
            this.button1.Text = "Driver Details";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminDeshboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1330, 668);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AdminDeshboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDeshboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminDeshboard_FormClosed);
            this.Load += new System.EventHandler(this.AdminDeshboard_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnManageUser;
        private System.Windows.Forms.Button btnPassengerDetails;
        private System.Windows.Forms.Button btnVehicleManage;
        private System.Windows.Forms.Button BtnCompanymanage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
    }
}