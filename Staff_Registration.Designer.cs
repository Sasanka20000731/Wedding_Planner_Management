
namespace Wedding_Management
{
    partial class Staff_Registration
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
            this.textBox_NewStaffName = new System.Windows.Forms.TextBox();
            this.textBox_NewStaffPassword = new System.Windows.Forms.TextBox();
            this.comboBox_Role = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_NewStaffID = new System.Windows.Forms.TextBox();
            this.button_Creat_New_StaffAcc = new System.Windows.Forms.Button();
            this.button_View_All_Account = new System.Windows.Forms.Button();
            this.button_DeleteAccount = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.dataGridView_AllStaffDetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AllStaffDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_NewStaffName
            // 
            this.textBox_NewStaffName.Location = new System.Drawing.Point(198, 43);
            this.textBox_NewStaffName.Name = "textBox_NewStaffName";
            this.textBox_NewStaffName.Size = new System.Drawing.Size(193, 22);
            this.textBox_NewStaffName.TabIndex = 0;
            // 
            // textBox_NewStaffPassword
            // 
            this.textBox_NewStaffPassword.Location = new System.Drawing.Point(198, 117);
            this.textBox_NewStaffPassword.Name = "textBox_NewStaffPassword";
            this.textBox_NewStaffPassword.Size = new System.Drawing.Size(193, 22);
            this.textBox_NewStaffPassword.TabIndex = 1;
            // 
            // comboBox_Role
            // 
            this.comboBox_Role.FormattingEnabled = true;
            this.comboBox_Role.Items.AddRange(new object[] {
            "Admin",
            "Cashier",
            "Event Cordinaters"});
            this.comboBox_Role.Location = new System.Drawing.Point(198, 152);
            this.comboBox_Role.Name = "comboBox_Role";
            this.comboBox_Role.Size = new System.Drawing.Size(193, 24);
            this.comboBox_Role.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "New Staff Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "New Staff Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "New Staff Record";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "New Staff ID";
            // 
            // textBox_NewStaffID
            // 
            this.textBox_NewStaffID.Location = new System.Drawing.Point(198, 78);
            this.textBox_NewStaffID.Name = "textBox_NewStaffID";
            this.textBox_NewStaffID.Size = new System.Drawing.Size(193, 22);
            this.textBox_NewStaffID.TabIndex = 7;
            // 
            // button_Creat_New_StaffAcc
            // 
            this.button_Creat_New_StaffAcc.Location = new System.Drawing.Point(26, 213);
            this.button_Creat_New_StaffAcc.Name = "button_Creat_New_StaffAcc";
            this.button_Creat_New_StaffAcc.Size = new System.Drawing.Size(365, 37);
            this.button_Creat_New_StaffAcc.TabIndex = 8;
            this.button_Creat_New_StaffAcc.Text = "Create New User Account";
            this.button_Creat_New_StaffAcc.UseVisualStyleBackColor = true;
            this.button_Creat_New_StaffAcc.Click += new System.EventHandler(this.button_Creat_New_StaffAcc_Click);
            // 
            // button_View_All_Account
            // 
            this.button_View_All_Account.Location = new System.Drawing.Point(26, 276);
            this.button_View_All_Account.Name = "button_View_All_Account";
            this.button_View_All_Account.Size = new System.Drawing.Size(365, 37);
            this.button_View_All_Account.TabIndex = 9;
            this.button_View_All_Account.Text = "View All Account";
            this.button_View_All_Account.UseVisualStyleBackColor = true;
            this.button_View_All_Account.Click += new System.EventHandler(this.button_View_All_Account_Click);
            // 
            // button_DeleteAccount
            // 
            this.button_DeleteAccount.Location = new System.Drawing.Point(26, 329);
            this.button_DeleteAccount.Name = "button_DeleteAccount";
            this.button_DeleteAccount.Size = new System.Drawing.Size(365, 37);
            this.button_DeleteAccount.TabIndex = 10;
            this.button_DeleteAccount.Text = "Delete Account";
            this.button_DeleteAccount.UseVisualStyleBackColor = true;
            this.button_DeleteAccount.Click += new System.EventHandler(this.button_DeleteAccount_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(26, 389);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(365, 37);
            this.button_Exit.TabIndex = 11;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // dataGridView_AllStaffDetails
            // 
            this.dataGridView_AllStaffDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AllStaffDetails.Location = new System.Drawing.Point(414, 62);
            this.dataGridView_AllStaffDetails.Name = "dataGridView_AllStaffDetails";
            this.dataGridView_AllStaffDetails.RowHeadersWidth = 51;
            this.dataGridView_AllStaffDetails.RowTemplate.Height = 24;
            this.dataGridView_AllStaffDetails.Size = new System.Drawing.Size(565, 348);
            this.dataGridView_AllStaffDetails.TabIndex = 12;
            // 
            // Staff_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 626);
            this.Controls.Add(this.dataGridView_AllStaffDetails);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_DeleteAccount);
            this.Controls.Add(this.button_View_All_Account);
            this.Controls.Add(this.button_Creat_New_StaffAcc);
            this.Controls.Add(this.textBox_NewStaffID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Role);
            this.Controls.Add(this.textBox_NewStaffPassword);
            this.Controls.Add(this.textBox_NewStaffName);
            this.Name = "Staff_Registration";
            this.Text = "Staff_Registration";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AllStaffDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_NewStaffName;
        private System.Windows.Forms.TextBox textBox_NewStaffPassword;
        private System.Windows.Forms.ComboBox comboBox_Role;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_NewStaffID;
        private System.Windows.Forms.Button button_Creat_New_StaffAcc;
        private System.Windows.Forms.Button button_View_All_Account;
        private System.Windows.Forms.Button button_DeleteAccount;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.DataGridView dataGridView_AllStaffDetails;
    }
}