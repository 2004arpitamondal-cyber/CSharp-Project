namespace OOP2_Project
{
    partial class SignUp
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.FemaleRdb = new System.Windows.Forms.RadioButton();
            this.MaleRdb = new System.Windows.Forms.RadioButton();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.MblNumLvl = new System.Windows.Forms.Label();
            this.GenderBtn = new System.Windows.Forms.Label();
            this.passlvl = new System.Windows.Forms.Label();
            this.Emaillvl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FullNameLvl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConfirm.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(577, 550);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(198, 47);
            this.btnConfirm.TabIndex = 32;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // FemaleRdb
            // 
            this.FemaleRdb.AutoSize = true;
            this.FemaleRdb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FemaleRdb.Location = new System.Drawing.Point(644, 440);
            this.FemaleRdb.Name = "FemaleRdb";
            this.FemaleRdb.Size = new System.Drawing.Size(92, 27);
            this.FemaleRdb.TabIndex = 31;
            this.FemaleRdb.TabStop = true;
            this.FemaleRdb.Text = "Female";
            this.FemaleRdb.UseVisualStyleBackColor = true;
            // 
            // MaleRdb
            // 
            this.MaleRdb.AutoSize = true;
            this.MaleRdb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaleRdb.Location = new System.Drawing.Point(543, 440);
            this.MaleRdb.Name = "MaleRdb";
            this.MaleRdb.Size = new System.Drawing.Size(74, 27);
            this.MaleRdb.TabIndex = 30;
            this.MaleRdb.TabStop = true;
            this.MaleRdb.Text = "Male";
            this.MaleRdb.UseVisualStyleBackColor = true;
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Location = new System.Drawing.Point(543, 475);
            this.txtNumber.Multiline = true;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(312, 52);
            this.txtNumber.TabIndex = 29;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(543, 363);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(312, 50);
            this.txtPass.TabIndex = 27;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(543, 295);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(312, 51);
            this.txtEmail.TabIndex = 26;
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(543, 217);
            this.txtFullName.Multiline = true;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(312, 51);
            this.txtFullName.TabIndex = 25;
            // 
            // MblNumLvl
            // 
            this.MblNumLvl.AutoSize = true;
            this.MblNumLvl.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MblNumLvl.Location = new System.Drawing.Point(297, 486);
            this.MblNumLvl.Name = "MblNumLvl";
            this.MblNumLvl.Size = new System.Drawing.Size(212, 32);
            this.MblNumLvl.TabIndex = 24;
            this.MblNumLvl.Text = "Mobile Number:";
            // 
            // GenderBtn
            // 
            this.GenderBtn.AutoSize = true;
            this.GenderBtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderBtn.Location = new System.Drawing.Point(396, 435);
            this.GenderBtn.Name = "GenderBtn";
            this.GenderBtn.Size = new System.Drawing.Size(113, 32);
            this.GenderBtn.TabIndex = 23;
            this.GenderBtn.Text = "Gender:";
            // 
            // passlvl
            // 
            this.passlvl.AutoSize = true;
            this.passlvl.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passlvl.Location = new System.Drawing.Point(371, 363);
            this.passlvl.Name = "passlvl";
            this.passlvl.Size = new System.Drawing.Size(138, 32);
            this.passlvl.TabIndex = 21;
            this.passlvl.Text = "Password:";
            // 
            // Emaillvl
            // 
            this.Emaillvl.AutoSize = true;
            this.Emaillvl.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emaillvl.Location = new System.Drawing.Point(415, 295);
            this.Emaillvl.Name = "Emaillvl";
            this.Emaillvl.Size = new System.Drawing.Size(94, 32);
            this.Emaillvl.TabIndex = 20;
            this.Emaillvl.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(323, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(750, 52);
            this.label3.TabIndex = 19;
            this.label3.Text = "Create your account once and enjoy a seamless journey across all our services. \r\n" +
    "One account for all your travel needs.";
            // 
            // FullNameLvl
            // 
            this.FullNameLvl.AutoSize = true;
            this.FullNameLvl.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNameLvl.Location = new System.Drawing.Point(361, 217);
            this.FullNameLvl.Name = "FullNameLvl";
            this.FullNameLvl.Size = new System.Drawing.Size(148, 32);
            this.FullNameLvl.TabIndex = 18;
            this.FullNameLvl.Text = "Full Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(497, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 45);
            this.label1.TabIndex = 17;
            this.label1.Text = "Create an account";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(543, 145);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(312, 45);
            this.txtId.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(456, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 32);
            this.label2.TabIndex = 33;
            this.label2.Text = "ID:";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1211, 652);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.FemaleRdb);
            this.Controls.Add(this.MaleRdb);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.MblNumLvl);
            this.Controls.Add(this.GenderBtn);
            this.Controls.Add(this.passlvl);
            this.Controls.Add(this.Emaillvl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FullNameLvl);
            this.Controls.Add(this.label1);
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SignUp_FormClosed);
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.RadioButton FemaleRdb;
        private System.Windows.Forms.RadioButton MaleRdb;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label MblNumLvl;
        private System.Windows.Forms.Label GenderBtn;
        private System.Windows.Forms.Label passlvl;
        private System.Windows.Forms.Label Emaillvl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label FullNameLvl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
    }
}