
namespace Wedding_Management
{
    partial class Form_Payment
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_PaymentID = new System.Windows.Forms.TextBox();
            this.textBox_CID = new System.Windows.Forms.TextBox();
            this.textBox_Coustomer_Name = new System.Windows.Forms.TextBox();
            this.textBox_Package = new System.Windows.Forms.TextBox();
            this.button_save_Payment = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.dataGridView_Payment = new System.Windows.Forms.DataGridView();
            this.button_ViewPayment = new System.Windows.Forms.Button();
            this.panel_Delete_Payment = new System.Windows.Forms.Panel();
            this.button_DeletePayment = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_DPID = new System.Windows.Forms.TextBox();
            this.textBox_DCName = new System.Windows.Forms.TextBox();
            this.button_Delet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Payment)).BeginInit();
            this.panel_Delete_Payment.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Coustomer ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Coustomer Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Package";
            // 
            // textBox_PaymentID
            // 
            this.textBox_PaymentID.Location = new System.Drawing.Point(137, 34);
            this.textBox_PaymentID.Name = "textBox_PaymentID";
            this.textBox_PaymentID.Size = new System.Drawing.Size(301, 22);
            this.textBox_PaymentID.TabIndex = 4;
            // 
            // textBox_CID
            // 
            this.textBox_CID.Location = new System.Drawing.Point(137, 82);
            this.textBox_CID.Name = "textBox_CID";
            this.textBox_CID.Size = new System.Drawing.Size(301, 22);
            this.textBox_CID.TabIndex = 5;
            this.textBox_CID.TextChanged += new System.EventHandler(this.textBox_CID_TextChanged);
            // 
            // textBox_Coustomer_Name
            // 
            this.textBox_Coustomer_Name.Location = new System.Drawing.Point(137, 127);
            this.textBox_Coustomer_Name.Name = "textBox_Coustomer_Name";
            this.textBox_Coustomer_Name.Size = new System.Drawing.Size(301, 22);
            this.textBox_Coustomer_Name.TabIndex = 6;
            // 
            // textBox_Package
            // 
            this.textBox_Package.Location = new System.Drawing.Point(137, 170);
            this.textBox_Package.Name = "textBox_Package";
            this.textBox_Package.Size = new System.Drawing.Size(301, 22);
            this.textBox_Package.TabIndex = 7;
            // 
            // button_save_Payment
            // 
            this.button_save_Payment.Location = new System.Drawing.Point(293, 223);
            this.button_save_Payment.Name = "button_save_Payment";
            this.button_save_Payment.Size = new System.Drawing.Size(145, 32);
            this.button_save_Payment.TabIndex = 8;
            this.button_save_Payment.Text = "Save Payment";
            this.button_save_Payment.UseVisualStyleBackColor = true;
            this.button_save_Payment.Click += new System.EventHandler(this.button_save_Payment_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(137, 223);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(123, 27);
            this.button_Clear.TabIndex = 9;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // dataGridView_Payment
            // 
            this.dataGridView_Payment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Payment.Location = new System.Drawing.Point(463, 51);
            this.dataGridView_Payment.Name = "dataGridView_Payment";
            this.dataGridView_Payment.RowHeadersWidth = 51;
            this.dataGridView_Payment.RowTemplate.Height = 24;
            this.dataGridView_Payment.Size = new System.Drawing.Size(448, 468);
            this.dataGridView_Payment.TabIndex = 10;
            // 
            // button_ViewPayment
            // 
            this.button_ViewPayment.Location = new System.Drawing.Point(137, 280);
            this.button_ViewPayment.Name = "button_ViewPayment";
            this.button_ViewPayment.Size = new System.Drawing.Size(145, 32);
            this.button_ViewPayment.TabIndex = 11;
            this.button_ViewPayment.Text = "View All Payment";
            this.button_ViewPayment.UseVisualStyleBackColor = true;
            this.button_ViewPayment.Click += new System.EventHandler(this.button_ViewPayment_Click);
            // 
            // panel_Delete_Payment
            // 
            this.panel_Delete_Payment.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_Delete_Payment.Controls.Add(this.button_Delet);
            this.panel_Delete_Payment.Controls.Add(this.textBox_DCName);
            this.panel_Delete_Payment.Controls.Add(this.textBox_DPID);
            this.panel_Delete_Payment.Controls.Add(this.label6);
            this.panel_Delete_Payment.Controls.Add(this.label5);
            this.panel_Delete_Payment.Location = new System.Drawing.Point(444, 34);
            this.panel_Delete_Payment.Name = "panel_Delete_Payment";
            this.panel_Delete_Payment.Size = new System.Drawing.Size(483, 495);
            this.panel_Delete_Payment.TabIndex = 12;
            // 
            // button_DeletePayment
            // 
            this.button_DeletePayment.Location = new System.Drawing.Point(293, 280);
            this.button_DeletePayment.Name = "button_DeletePayment";
            this.button_DeletePayment.Size = new System.Drawing.Size(145, 32);
            this.button_DeletePayment.TabIndex = 13;
            this.button_DeletePayment.Text = "Delet Payemnt";
            this.button_DeletePayment.UseVisualStyleBackColor = true;
            this.button_DeletePayment.Click += new System.EventHandler(this.button_DeletePayment_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Payment ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Coustomer Name";
            // 
            // textBox_DPID
            // 
            this.textBox_DPID.Location = new System.Drawing.Point(210, 53);
            this.textBox_DPID.Name = "textBox_DPID";
            this.textBox_DPID.Size = new System.Drawing.Size(222, 22);
            this.textBox_DPID.TabIndex = 2;
            this.textBox_DPID.TextChanged += new System.EventHandler(this.textBox_DPID_TextChanged);
            // 
            // textBox_DCName
            // 
            this.textBox_DCName.Location = new System.Drawing.Point(210, 98);
            this.textBox_DCName.Name = "textBox_DCName";
            this.textBox_DCName.Size = new System.Drawing.Size(222, 22);
            this.textBox_DCName.TabIndex = 3;
            // 
            // button_Delet
            // 
            this.button_Delet.Location = new System.Drawing.Point(290, 171);
            this.button_Delet.Name = "button_Delet";
            this.button_Delet.Size = new System.Drawing.Size(142, 23);
            this.button_Delet.TabIndex = 4;
            this.button_Delet.Text = "Delete";
            this.button_Delet.UseVisualStyleBackColor = true;
            this.button_Delet.Click += new System.EventHandler(this.button_Delet_Click);
            // 
            // Form_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 576);
            this.Controls.Add(this.button_DeletePayment);
            this.Controls.Add(this.panel_Delete_Payment);
            this.Controls.Add(this.button_ViewPayment);
            this.Controls.Add(this.dataGridView_Payment);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_save_Payment);
            this.Controls.Add(this.textBox_Package);
            this.Controls.Add(this.textBox_Coustomer_Name);
            this.Controls.Add(this.textBox_CID);
            this.Controls.Add(this.textBox_PaymentID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Payment";
            this.Text = "l";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Payment)).EndInit();
            this.panel_Delete_Payment.ResumeLayout(false);
            this.panel_Delete_Payment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_PaymentID;
        private System.Windows.Forms.TextBox textBox_CID;
        private System.Windows.Forms.TextBox textBox_Coustomer_Name;
        private System.Windows.Forms.TextBox textBox_Package;
        private System.Windows.Forms.Button button_save_Payment;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.DataGridView dataGridView_Payment;
        private System.Windows.Forms.Button button_ViewPayment;
        private System.Windows.Forms.Panel panel_Delete_Payment;
        private System.Windows.Forms.Button button_Delet;
        private System.Windows.Forms.TextBox textBox_DCName;
        private System.Windows.Forms.TextBox textBox_DPID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_DeletePayment;
    }
}