
namespace Wedding_Management
{
    partial class Coustomer_Registration
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
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_DeleteCoustomer = new System.Windows.Forms.Button();
            this.button_View_All_Coustomer_Details = new System.Windows.Forms.Button();
            this.button_Save_Coustomer_Detail = new System.Windows.Forms.Button();
            this.textBox_NewCoustomerID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_NewCoustomerName = new System.Windows.Forms.TextBox();
            this.dataGridViewViewCoustomerDetail = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_CoustomerAddress = new System.Windows.Forms.TextBox();
            this.textBox_CoustomerNicNumber = new System.Windows.Forms.TextBox();
            this.dateTimePicker_WeddingDate = new System.Windows.Forms.DateTimePicker();
            this.comboBox_Package = new System.Windows.Forms.ComboBox();
            this.button_Clear = new System.Windows.Forms.Button();
            this.panel_DeleteCoustomer = new System.Windows.Forms.Panel();
            this.textBox_CDName = new System.Windows.Forms.TextBox();
            this.textBox_CDId = new System.Windows.Forms.TextBox();
            this.button_deleteApp = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewViewCoustomerDetail)).BeginInit();
            this.panel_DeleteCoustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(33, 463);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(414, 37);
            this.button_Exit.TabIndex = 23;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            // 
            // button_DeleteCoustomer
            // 
            this.button_DeleteCoustomer.Location = new System.Drawing.Point(33, 403);
            this.button_DeleteCoustomer.Name = "button_DeleteCoustomer";
            this.button_DeleteCoustomer.Size = new System.Drawing.Size(414, 37);
            this.button_DeleteCoustomer.TabIndex = 22;
            this.button_DeleteCoustomer.Text = "Delete Coustomer";
            this.button_DeleteCoustomer.UseVisualStyleBackColor = true;
            this.button_DeleteCoustomer.Click += new System.EventHandler(this.button_DeleteCoustomer_Click);
            // 
            // button_View_All_Coustomer_Details
            // 
            this.button_View_All_Coustomer_Details.Location = new System.Drawing.Point(33, 350);
            this.button_View_All_Coustomer_Details.Name = "button_View_All_Coustomer_Details";
            this.button_View_All_Coustomer_Details.Size = new System.Drawing.Size(414, 37);
            this.button_View_All_Coustomer_Details.TabIndex = 21;
            this.button_View_All_Coustomer_Details.Text = "View All Customers Details";
            this.button_View_All_Coustomer_Details.UseVisualStyleBackColor = true;
            this.button_View_All_Coustomer_Details.Click += new System.EventHandler(this.button_View_All_Coustomer_Details_Click);
            // 
            // button_Save_Coustomer_Detail
            // 
            this.button_Save_Coustomer_Detail.Location = new System.Drawing.Point(252, 285);
            this.button_Save_Coustomer_Detail.Name = "button_Save_Coustomer_Detail";
            this.button_Save_Coustomer_Detail.Size = new System.Drawing.Size(195, 37);
            this.button_Save_Coustomer_Detail.TabIndex = 20;
            this.button_Save_Coustomer_Detail.Text = "Save Coustomer Detail";
            this.button_Save_Coustomer_Detail.UseVisualStyleBackColor = true;
            this.button_Save_Coustomer_Detail.Click += new System.EventHandler(this.button_Save_Coustomer_Detail_Click);
            // 
            // textBox_NewCoustomerID
            // 
            this.textBox_NewCoustomerID.Location = new System.Drawing.Point(236, 60);
            this.textBox_NewCoustomerID.Name = "textBox_NewCoustomerID";
            this.textBox_NewCoustomerID.Size = new System.Drawing.Size(211, 22);
            this.textBox_NewCoustomerID.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "New Customer ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "New Customer Name";
            // 
            // textBox_NewCoustomerName
            // 
            this.textBox_NewCoustomerName.Location = new System.Drawing.Point(236, 25);
            this.textBox_NewCoustomerName.Name = "textBox_NewCoustomerName";
            this.textBox_NewCoustomerName.Size = new System.Drawing.Size(211, 22);
            this.textBox_NewCoustomerName.TabIndex = 12;
            // 
            // dataGridViewViewCoustomerDetail
            // 
            this.dataGridViewViewCoustomerDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewViewCoustomerDetail.Location = new System.Drawing.Point(453, 9);
            this.dataGridViewViewCoustomerDetail.Name = "dataGridViewViewCoustomerDetail";
            this.dataGridViewViewCoustomerDetail.RowHeadersWidth = 51;
            this.dataGridViewViewCoustomerDetail.RowTemplate.Height = 24;
            this.dataGridViewViewCoustomerDetail.Size = new System.Drawing.Size(583, 238);
            this.dataGridViewViewCoustomerDetail.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "New Customer Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "New Customer NIC Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "New Customer Wedding Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Package";
            // 
            // textBox_CoustomerAddress
            // 
            this.textBox_CoustomerAddress.Location = new System.Drawing.Point(236, 98);
            this.textBox_CoustomerAddress.Name = "textBox_CoustomerAddress";
            this.textBox_CoustomerAddress.Size = new System.Drawing.Size(211, 22);
            this.textBox_CoustomerAddress.TabIndex = 29;
            // 
            // textBox_CoustomerNicNumber
            // 
            this.textBox_CoustomerNicNumber.Location = new System.Drawing.Point(236, 141);
            this.textBox_CoustomerNicNumber.Name = "textBox_CoustomerNicNumber";
            this.textBox_CoustomerNicNumber.Size = new System.Drawing.Size(211, 22);
            this.textBox_CoustomerNicNumber.TabIndex = 30;
            // 
            // dateTimePicker_WeddingDate
            // 
            this.dateTimePicker_WeddingDate.Location = new System.Drawing.Point(247, 187);
            this.dateTimePicker_WeddingDate.Name = "dateTimePicker_WeddingDate";
            this.dateTimePicker_WeddingDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_WeddingDate.TabIndex = 31;
            // 
            // comboBox_Package
            // 
            this.comboBox_Package.FormattingEnabled = true;
            this.comboBox_Package.Items.AddRange(new object[] {
            "50000",
            "25000",
            "15000"});
            this.comboBox_Package.Location = new System.Drawing.Point(247, 230);
            this.comboBox_Package.Name = "comboBox_Package";
            this.comboBox_Package.Size = new System.Drawing.Size(200, 24);
            this.comboBox_Package.TabIndex = 32;
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(33, 285);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(195, 37);
            this.button_Clear.TabIndex = 33;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // panel_DeleteCoustomer
            // 
            this.panel_DeleteCoustomer.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel_DeleteCoustomer.Controls.Add(this.textBox_CDName);
            this.panel_DeleteCoustomer.Controls.Add(this.textBox_CDId);
            this.panel_DeleteCoustomer.Controls.Add(this.button_deleteApp);
            this.panel_DeleteCoustomer.Controls.Add(this.label7);
            this.panel_DeleteCoustomer.Controls.Add(this.label8);
            this.panel_DeleteCoustomer.Location = new System.Drawing.Point(453, 9);
            this.panel_DeleteCoustomer.Name = "panel_DeleteCoustomer";
            this.panel_DeleteCoustomer.Size = new System.Drawing.Size(600, 270);
            this.panel_DeleteCoustomer.TabIndex = 34;
            // 
            // textBox_CDName
            // 
            this.textBox_CDName.Location = new System.Drawing.Point(299, 130);
            this.textBox_CDName.Name = "textBox_CDName";
            this.textBox_CDName.Size = new System.Drawing.Size(250, 22);
            this.textBox_CDName.TabIndex = 4;
            // 
            // textBox_CDId
            // 
            this.textBox_CDId.Location = new System.Drawing.Point(299, 77);
            this.textBox_CDId.Name = "textBox_CDId";
            this.textBox_CDId.Size = new System.Drawing.Size(250, 22);
            this.textBox_CDId.TabIndex = 3;
            this.textBox_CDId.TextChanged += new System.EventHandler(this.textBox_CDId_TextChanged);
            // 
            // button_deleteApp
            // 
            this.button_deleteApp.Location = new System.Drawing.Point(474, 223);
            this.button_deleteApp.Name = "button_deleteApp";
            this.button_deleteApp.Size = new System.Drawing.Size(75, 23);
            this.button_deleteApp.TabIndex = 2;
            this.button_deleteApp.Text = "Delete";
            this.button_deleteApp.UseVisualStyleBackColor = true;
            this.button_deleteApp.Click += new System.EventHandler(this.button_deleteApp_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(111, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Customer Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(111, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Customer ID";
            // 
            // Coustomer_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 541);
            this.Controls.Add(this.panel_DeleteCoustomer);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.comboBox_Package);
            this.Controls.Add(this.dateTimePicker_WeddingDate);
            this.Controls.Add(this.textBox_CoustomerNicNumber);
            this.Controls.Add(this.textBox_CoustomerAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewViewCoustomerDetail);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_DeleteCoustomer);
            this.Controls.Add(this.button_View_All_Coustomer_Details);
            this.Controls.Add(this.button_Save_Coustomer_Detail);
            this.Controls.Add(this.textBox_NewCoustomerID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_NewCoustomerName);
            this.Name = "Coustomer_Registration";
            this.Text = "Coustomer_Registration";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewViewCoustomerDetail)).EndInit();
            this.panel_DeleteCoustomer.ResumeLayout(false);
            this.panel_DeleteCoustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_DeleteCoustomer;
        private System.Windows.Forms.Button button_View_All_Coustomer_Details;
        private System.Windows.Forms.Button button_Save_Coustomer_Detail;
        private System.Windows.Forms.TextBox textBox_NewCoustomerID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_NewCoustomerName;
        private System.Windows.Forms.DataGridView dataGridViewViewCoustomerDetail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_CoustomerAddress;
        private System.Windows.Forms.TextBox textBox_CoustomerNicNumber;
        private System.Windows.Forms.DateTimePicker dateTimePicker_WeddingDate;
        private System.Windows.Forms.ComboBox comboBox_Package;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Panel panel_DeleteCoustomer;
        private System.Windows.Forms.TextBox textBox_CDName;
        private System.Windows.Forms.TextBox textBox_CDId;
        private System.Windows.Forms.Button button_deleteApp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}