using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wedding_Management
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button_Appointment_Click(object sender, EventArgs e)
        {
            Appointment appointment = new Appointment();
            appointment.Show();
        }

        private void button_StaffReg_Click(object sender, EventArgs e)
        {
            Staff_Registration staff_Registration = new Staff_Registration();
            staff_Registration.Show();
        }

        private void button_CousmerReg_Click(object sender, EventArgs e)
        {
            Coustomer_Registration coustomer_Registration = new Coustomer_Registration();
            coustomer_Registration.Show();
        }

        private void button_Payment_Click(object sender, EventArgs e)
        {
            Form_Payment form_Payment = new Form_Payment();
            form_Payment.Show();
        }

        private void button_Report_Click(object sender, EventArgs e)
        {
            Form_DashBoard_Reports form_DashBoard_Reports = new Form_DashBoard_Reports();
            form_DashBoard_Reports.Show();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_PackageDetail_Click(object sender, EventArgs e)
        {
            Packages packages = new Packages();
            packages.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            if (ClassUL.type == "A")
            {
                button_Appointment.Visible = true;
                button_Payment.Visible = true;
                button_CousmerReg.Visible = true;
                button_StaffReg.Visible = true;
                button_Report.Visible = true;
                button_Payment.Visible = true;
                button_PackageDetail.Visible = true;
            }
            else if (ClassUL.type == "C")
            {
                button_Appointment.Visible = true;
                button_Payment.Visible = true;
                button_CousmerReg.Visible = true;
                button_StaffReg.Visible = false;
                button_Report.Visible = false;
                button_Payment.Visible = true;
                button_PackageDetail.Visible = true;

            }
            else if (ClassUL.type == "E")
            {
                button_Appointment.Visible = true;
                button_Payment.Visible = true;
                button_CousmerReg.Visible = true;
                button_StaffReg.Visible = false;
                button_Report.Visible = true;
                button_Payment.Visible = true;
                button_PackageDetail.Visible = true;

            }



        }
    }
}
