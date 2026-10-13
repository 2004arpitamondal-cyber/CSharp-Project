namespace OOP2_Project
{
    partial class VehicleManage
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbCompanyName = new System.Windows.Forms.ComboBox();
            this.txtTicketPrice = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.DOB = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtStartingPoint = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbVehicleType = new System.Windows.Forms.ComboBox();
            this.cmbFitnessInfo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvVehicleManage = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDriverId = new System.Windows.Forms.TextBox();
            this.dgvVehicleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDriverid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvVehicleType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFitnessInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTicketPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleManage)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 600F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1805, 698);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PowderBlue;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtDriverId);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.cmbCompanyName);
            this.panel4.Controls.Add(this.txtTicketPrice);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.DOB);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Controls.Add(this.txtDestination);
            this.panel4.Controls.Add(this.label20);
            this.panel4.Controls.Add(this.txtStartingPoint);
            this.panel4.Controls.Add(this.label21);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.cmbVehicleType);
            this.panel4.Controls.Add(this.cmbFitnessInfo);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.txtCapacity);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.txtId);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(1208, 53);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(594, 642);
            this.panel4.TabIndex = 3;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // cmbCompanyName
            // 
            this.cmbCompanyName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCompanyName.FormattingEnabled = true;
            this.cmbCompanyName.Location = new System.Drawing.Point(218, 90);
            this.cmbCompanyName.Name = "cmbCompanyName";
            this.cmbCompanyName.Size = new System.Drawing.Size(368, 34);
            this.cmbCompanyName.TabIndex = 78;
            // 
            // txtTicketPrice
            // 
            this.txtTicketPrice.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicketPrice.Location = new System.Drawing.Point(221, 589);
            this.txtTicketPrice.Multiline = true;
            this.txtTicketPrice.Name = "txtTicketPrice";
            this.txtTicketPrice.Size = new System.Drawing.Size(360, 47);
            this.txtTicketPrice.TabIndex = 77;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(55, 589);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(165, 32);
            this.label18.TabIndex = 76;
            this.label18.Text = "Ticket Price:";
            // 
            // DOB
            // 
            this.DOB.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOB.Location = new System.Drawing.Point(221, 527);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(360, 34);
            this.DOB.TabIndex = 75;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(134, 529);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(78, 32);
            this.label19.TabIndex = 74;
            this.label19.Text = "Date:";
            // 
            // txtDestination
            // 
            this.txtDestination.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestination.Location = new System.Drawing.Point(218, 449);
            this.txtDestination.Multiline = true;
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(360, 46);
            this.txtDestination.TabIndex = 73;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(160, 449);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(52, 32);
            this.label20.TabIndex = 72;
            this.label20.Text = "To:";
            // 
            // txtStartingPoint
            // 
            this.txtStartingPoint.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartingPoint.Location = new System.Drawing.Point(221, 377);
            this.txtStartingPoint.Multiline = true;
            this.txtStartingPoint.Name = "txtStartingPoint";
            this.txtStartingPoint.Size = new System.Drawing.Size(360, 46);
            this.txtStartingPoint.TabIndex = 71;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(124, 391);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(88, 32);
            this.label21.TabIndex = 70;
            this.label21.Text = "From:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-4, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 32);
            this.label1.TabIndex = 66;
            this.label1.Text = " Company Name:";
            // 
            // cmbVehicleType
            // 
            this.cmbVehicleType.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVehicleType.FormattingEnabled = true;
            this.cmbVehicleType.Items.AddRange(new object[] {
            "AC",
            "NOO-AC",
            "Local"});
            this.cmbVehicleType.Location = new System.Drawing.Point(218, 192);
            this.cmbVehicleType.Name = "cmbVehicleType";
            this.cmbVehicleType.Size = new System.Drawing.Size(360, 34);
            this.cmbVehicleType.TabIndex = 65;
            // 
            // cmbFitnessInfo
            // 
            this.cmbFitnessInfo.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFitnessInfo.FormattingEnabled = true;
            this.cmbFitnessInfo.Items.AddRange(new object[] {
            "Fit",
            "Unfit",
            "Expired",
            "Pending"});
            this.cmbFitnessInfo.Location = new System.Drawing.Point(221, 316);
            this.cmbFitnessInfo.Name = "cmbFitnessInfo";
            this.cmbFitnessInfo.Size = new System.Drawing.Size(360, 34);
            this.cmbFitnessInfo.TabIndex = 64;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(48, 318);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 32);
            this.label9.TabIndex = 63;
            this.label9.Text = "Fitness Info:";
            // 
            // txtCapacity
            // 
            this.txtCapacity.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapacity.Location = new System.Drawing.Point(219, 243);
            this.txtCapacity.Multiline = true;
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(360, 49);
            this.txtCapacity.TabIndex = 62;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(82, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 32);
            this.label8.TabIndex = 61;
            this.label8.Text = "Capacity:";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(218, 35);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(360, 49);
            this.txtId.TabIndex = 60;
            this.txtId.Text = "Auto Generated";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(55, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 32);
            this.label7.TabIndex = 59;
            this.label7.Text = " Vehicles ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 32);
            this.label2.TabIndex = 58;
            this.label2.Text = "Vehicles Type:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dgvVehicleManage);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1199, 642);
            this.panel3.TabIndex = 2;
            // 
            // dgvVehicleManage
            // 
            this.dgvVehicleManage.AllowUserToAddRows = false;
            this.dgvVehicleManage.AllowUserToDeleteRows = false;
            this.dgvVehicleManage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicleManage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvVehicleId,
            this.dgvDriverid,
            this.dgvVehicleType,
            this.dgvCapacity,
            this.dgvFitnessInfo,
            this.dgvFrom,
            this.dgvTo,
            this.dgvDate,
            this.dgvTicketPrice});
            this.dgvVehicleManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVehicleManage.Location = new System.Drawing.Point(0, 0);
            this.dgvVehicleManage.Name = "dgvVehicleManage";
            this.dgvVehicleManage.ReadOnly = true;
            this.dgvVehicleManage.RowHeadersWidth = 51;
            this.dgvVehicleManage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehicleManage.Size = new System.Drawing.Size(1197, 640);
            this.dgvVehicleManage.TabIndex = 0;
            this.dgvVehicleManage.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehicleManage_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1199, 44);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnSearch, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnR, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtSearch, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1197, 42);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(109, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 36);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnR
            // 
            this.btnR.BackColor = System.Drawing.Color.Peru;
            this.btnR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnR.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnR.Location = new System.Drawing.Point(3, 3);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(100, 36);
            this.btnR.TabIndex = 0;
            this.btnR.Text = "Refresh";
            this.btnR.UseVisualStyleBackColor = false;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(203, 3);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(991, 36);
            this.txtSearch.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1208, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(594, 44);
            this.panel2.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Location = new System.Drawing.Point(449, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 41);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SpringGreen;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(260, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 41);
            this.button2.TabIndex = 33;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.BlueViolet;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(54, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 41);
            this.button1.TabIndex = 31;
            this.button1.Text = "New";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 32);
            this.label3.TabIndex = 79;
            this.label3.Text = "Driver ID:";
            // 
            // txtDriverId
            // 
            this.txtDriverId.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDriverId.Location = new System.Drawing.Point(218, 140);
            this.txtDriverId.Multiline = true;
            this.txtDriverId.Name = "txtDriverId";
            this.txtDriverId.Size = new System.Drawing.Size(360, 42);
            this.txtDriverId.TabIndex = 80;
            // 
            // dgvVehicleId
            // 
            this.dgvVehicleId.DataPropertyName = "VehicleID";
            this.dgvVehicleId.HeaderText = "Vehicle ID";
            this.dgvVehicleId.MinimumWidth = 6;
            this.dgvVehicleId.Name = "dgvVehicleId";
            this.dgvVehicleId.ReadOnly = true;
            this.dgvVehicleId.Width = 125;
            // 
            // dgvDriverid
            // 
            this.dgvDriverid.DataPropertyName = "driverId";
            this.dgvDriverid.HeaderText = "Driver ID";
            this.dgvDriverid.MinimumWidth = 6;
            this.dgvDriverid.Name = "dgvDriverid";
            this.dgvDriverid.ReadOnly = true;
            this.dgvDriverid.Width = 125;
            // 
            // dgvVehicleType
            // 
            this.dgvVehicleType.DataPropertyName = "VehicleType";
            this.dgvVehicleType.HeaderText = "Bus Type";
            this.dgvVehicleType.MinimumWidth = 6;
            this.dgvVehicleType.Name = "dgvVehicleType";
            this.dgvVehicleType.ReadOnly = true;
            this.dgvVehicleType.Width = 125;
            // 
            // dgvCapacity
            // 
            this.dgvCapacity.DataPropertyName = "Capacity";
            this.dgvCapacity.HeaderText = "Bus Capacity";
            this.dgvCapacity.MinimumWidth = 6;
            this.dgvCapacity.Name = "dgvCapacity";
            this.dgvCapacity.ReadOnly = true;
            this.dgvCapacity.Width = 125;
            // 
            // dgvFitnessInfo
            // 
            this.dgvFitnessInfo.DataPropertyName = "FitnessInfo";
            this.dgvFitnessInfo.HeaderText = "Fitness";
            this.dgvFitnessInfo.MinimumWidth = 6;
            this.dgvFitnessInfo.Name = "dgvFitnessInfo";
            this.dgvFitnessInfo.ReadOnly = true;
            this.dgvFitnessInfo.Width = 125;
            // 
            // dgvFrom
            // 
            this.dgvFrom.DataPropertyName = "StartingPoint";
            this.dgvFrom.HeaderText = "From";
            this.dgvFrom.MinimumWidth = 6;
            this.dgvFrom.Name = "dgvFrom";
            this.dgvFrom.ReadOnly = true;
            this.dgvFrom.Width = 125;
            // 
            // dgvTo
            // 
            this.dgvTo.DataPropertyName = "Destination";
            this.dgvTo.HeaderText = "To";
            this.dgvTo.MinimumWidth = 6;
            this.dgvTo.Name = "dgvTo";
            this.dgvTo.ReadOnly = true;
            this.dgvTo.Width = 125;
            // 
            // dgvDate
            // 
            this.dgvDate.DataPropertyName = "Date";
            this.dgvDate.HeaderText = "Date";
            this.dgvDate.MinimumWidth = 6;
            this.dgvDate.Name = "dgvDate";
            this.dgvDate.ReadOnly = true;
            this.dgvDate.Width = 125;
            // 
            // dgvTicketPrice
            // 
            this.dgvTicketPrice.DataPropertyName = "TicketPrice";
            this.dgvTicketPrice.HeaderText = "Ticket Price";
            this.dgvTicketPrice.MinimumWidth = 6;
            this.dgvTicketPrice.Name = "dgvTicketPrice";
            this.dgvTicketPrice.ReadOnly = true;
            this.dgvTicketPrice.Width = 125;
            // 
            // VehicleManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1805, 698);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "VehicleManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VehicleManage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VehicleManage_FormClosed_1);
            this.Load += new System.EventHandler(this.VehicleManage_Load_1);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleManage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtTicketPrice;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker DOB;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtStartingPoint;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbVehicleType;
        private System.Windows.Forms.ComboBox cmbFitnessInfo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvVehicleManage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbCompanyName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDriverId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvVehicleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDriverid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvVehicleType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFitnessInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTicketPrice;
    }
}