
namespace Wedding_Management
{
    partial class Appointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appointment));
            this.button_Make_Appointment = new System.Windows.Forms.Button();
            this.button_DeleteAppointment = new System.Windows.Forms.Button();
            this.panel_Make_Appointment = new System.Windows.Forms.Panel();
            this.comboBox_StaffName = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_AppoinmentDate = new System.Windows.Forms.DateTimePicker();
            this.textBox_CoustomerID = new System.Windows.Forms.TextBox();
            this.textBox_AppointmentID = new System.Windows.Forms.TextBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_DeleteAppointment = new System.Windows.Forms.Panel();
            this.textBox_CosID = new System.Windows.Forms.TextBox();
            this.textBox_AppoId = new System.Windows.Forms.TextBox();
            this.button_deleteApp = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView_Appointment = new System.Windows.Forms.DataGridView();
            this.button_View_AllAppointment = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_Close = new System.Windows.Forms.Button();
            this.panel_Make_Appointment.SuspendLayout();
            this.panel_DeleteAppointment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Appointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Make_Appointment
            // 
            this.button_Make_Appointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Make_Appointment.Location = new System.Drawing.Point(12, 217);
            this.button_Make_Appointment.Name = "button_Make_Appointment";
            this.button_Make_Appointment.Size = new System.Drawing.Size(251, 55);
            this.button_Make_Appointment.TabIndex = 0;
            this.button_Make_Appointment.Text = "Make Appointment";
            this.button_Make_Appointment.UseVisualStyleBackColor = true;
            this.button_Make_Appointment.Click += new System.EventHandler(this.button_Make_Appointment_Click);
            // 
            // button_DeleteAppointment
            // 
            this.button_DeleteAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DeleteAppointment.Location = new System.Drawing.Point(12, 300);
            this.button_DeleteAppointment.Name = "button_DeleteAppointment";
            this.button_DeleteAppointment.Size = new System.Drawing.Size(251, 55);
            this.button_DeleteAppointment.TabIndex = 2;
            this.button_DeleteAppointment.Text = "Delete Appointment";
            this.button_DeleteAppointment.UseVisualStyleBackColor = true;
            this.button_DeleteAppointment.Click += new System.EventHandler(this.button_DeleteAppointment_Click);
            // 
            // panel_Make_Appointment
            // 
            this.panel_Make_Appointment.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_Make_Appointment.Controls.Add(this.comboBox_StaffName);
            this.panel_Make_Appointment.Controls.Add(this.dateTimePicker_AppoinmentDate);
            this.panel_Make_Appointment.Controls.Add(this.textBox_CoustomerID);
            this.panel_Make_Appointment.Controls.Add(this.textBox_AppointmentID);
            this.panel_Make_Appointment.Controls.Add(this.button_Save);
            this.panel_Make_Appointment.Controls.Add(this.button_Clear);
            this.panel_Make_Appointment.Controls.Add(this.label4);
            this.panel_Make_Appointment.Controls.Add(this.label3);
            this.panel_Make_Appointment.Controls.Add(this.label2);
            this.panel_Make_Appointment.Controls.Add(this.label1);
            this.panel_Make_Appointment.Location = new System.Drawing.Point(283, 12);
            this.panel_Make_Appointment.Name = "panel_Make_Appointment";
            this.panel_Make_Appointment.Size = new System.Drawing.Size(713, 331);
            this.panel_Make_Appointment.TabIndex = 3;
            // 
            // comboBox_StaffName
            // 
            this.comboBox_StaffName.FormattingEnabled = true;
            this.comboBox_StaffName.Items.AddRange(new object[] {
            "Sandali",
            "Sasanka",
            "Ruwani",
            "Kasun",
            "Chamodi"});
            this.comboBox_StaffName.Location = new System.Drawing.Point(287, 141);
            this.comboBox_StaffName.Name = "comboBox_StaffName";
            this.comboBox_StaffName.Size = new System.Drawing.Size(377, 24);
            this.comboBox_StaffName.TabIndex = 10;
            // 
            // dateTimePicker_AppoinmentDate
            // 
            this.dateTimePicker_AppoinmentDate.Location = new System.Drawing.Point(464, 197);
            this.dateTimePicker_AppoinmentDate.Name = "dateTimePicker_AppoinmentDate";
            this.dateTimePicker_AppoinmentDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_AppoinmentDate.TabIndex = 9;
            // 
            // textBox_CoustomerID
            // 
            this.textBox_CoustomerID.Location = new System.Drawing.Point(287, 85);
            this.textBox_CoustomerID.Name = "textBox_CoustomerID";
            this.textBox_CoustomerID.Size = new System.Drawing.Size(377, 22);
            this.textBox_CoustomerID.TabIndex = 7;
            // 
            // textBox_AppointmentID
            // 
            this.textBox_AppointmentID.Location = new System.Drawing.Point(287, 29);
            this.textBox_AppointmentID.Name = "textBox_AppointmentID";
            this.textBox_AppointmentID.Size = new System.Drawing.Size(377, 22);
            this.textBox_AppointmentID.TabIndex = 6;
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(433, 272);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(189, 38);
            this.button_Save.TabIndex = 5;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(132, 272);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(189, 38);
            this.button_Clear.TabIndex = 4;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Appointment Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Staff Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Coustommer ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Appointment ID";
            // 
            // panel_DeleteAppointment
            // 
            this.panel_DeleteAppointment.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel_DeleteAppointment.Controls.Add(this.textBox_CosID);
            this.panel_DeleteAppointment.Controls.Add(this.textBox_AppoId);
            this.panel_DeleteAppointment.Controls.Add(this.button_deleteApp);
            this.panel_DeleteAppointment.Controls.Add(this.label6);
            this.panel_DeleteAppointment.Controls.Add(this.label5);
            this.panel_DeleteAppointment.Location = new System.Drawing.Point(283, 10);
            this.panel_DeleteAppointment.Name = "panel_DeleteAppointment";
            this.panel_DeleteAppointment.Size = new System.Drawing.Size(723, 330);
            this.panel_DeleteAppointment.TabIndex = 6;
            // 
            // textBox_CosID
            // 
            this.textBox_CosID.Location = new System.Drawing.Point(372, 136);
            this.textBox_CosID.Name = "textBox_CosID";
            this.textBox_CosID.Size = new System.Drawing.Size(250, 22);
            this.textBox_CosID.TabIndex = 4;
            // 
            // textBox_AppoId
            // 
            this.textBox_AppoId.Location = new System.Drawing.Point(372, 76);
            this.textBox_AppoId.Name = "textBox_AppoId";
            this.textBox_AppoId.Size = new System.Drawing.Size(250, 22);
            this.textBox_AppoId.TabIndex = 3;
            this.textBox_AppoId.TextChanged += new System.EventHandler(this.textBox_AppoId_TextChanged);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Coustomer ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Appointment ID";
            // 
            // dataGridView_Appointment
            // 
            this.dataGridView_Appointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Appointment.Location = new System.Drawing.Point(283, 368);
            this.dataGridView_Appointment.Name = "dataGridView_Appointment";
            this.dataGridView_Appointment.RowHeadersWidth = 51;
            this.dataGridView_Appointment.RowTemplate.Height = 24;
            this.dataGridView_Appointment.Size = new System.Drawing.Size(713, 256);
            this.dataGridView_Appointment.TabIndex = 4;
            // 
            // button_View_AllAppointment
            // 
            this.button_View_AllAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_View_AllAppointment.Location = new System.Drawing.Point(12, 384);
            this.button_View_AllAppointment.Name = "button_View_AllAppointment";
            this.button_View_AllAppointment.Size = new System.Drawing.Size(251, 52);
            this.button_View_AllAppointment.TabIndex = 5;
            this.button_View_AllAppointment.Text = "View Appointment";
            this.button_View_AllAppointment.UseVisualStyleBackColor = true;
            this.button_View_AllAppointment.Click += new System.EventHandler(this.button_View_AllAppointment_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button_Close
            // 
            this.button_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Close.Location = new System.Drawing.Point(12, 470);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(251, 52);
            this.button_Close.TabIndex = 8;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 675);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel_DeleteAppointment);
            this.Controls.Add(this.button_View_AllAppointment);
            this.Controls.Add(this.dataGridView_Appointment);
            this.Controls.Add(this.panel_Make_Appointment);
            this.Controls.Add(this.button_DeleteAppointment);
            this.Controls.Add(this.button_Make_Appointment);
            this.Name = "Appointment";
            this.Text = "Appointment";
            this.panel_Make_Appointment.ResumeLayout(false);
            this.panel_Make_Appointment.PerformLayout();
            this.panel_DeleteAppointment.ResumeLayout(false);
            this.panel_DeleteAppointment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Appointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Make_Appointment;
        private System.Windows.Forms.Button button_DeleteAppointment;
        private System.Windows.Forms.Panel panel_Make_Appointment;
        private System.Windows.Forms.DateTimePicker dateTimePicker_AppoinmentDate;
        private System.Windows.Forms.TextBox textBox_CoustomerID;
        private System.Windows.Forms.TextBox textBox_AppointmentID;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_StaffName;
        private System.Windows.Forms.DataGridView dataGridView_Appointment;
        private System.Windows.Forms.Button button_View_AllAppointment;
        private System.Windows.Forms.Panel panel_DeleteAppointment;
        private System.Windows.Forms.TextBox textBox_CosID;
        private System.Windows.Forms.TextBox textBox_AppoId;
        private System.Windows.Forms.Button button_deleteApp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_Close;
    }
}