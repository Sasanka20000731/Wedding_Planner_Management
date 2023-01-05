using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Wedding_Management
{
    public partial class Appointment : Form
    {
        public Appointment()
        {
            InitializeComponent();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            try
            {


                String dbString = "Data Source=DESKTOP-N1AKUG5;Initial Catalog=E2046321;Integrated Security=True";
                SqlConnection con = new SqlConnection(dbString);
                con.Open();

                String sqlQary = "insert into Table_Appointment values('" + textBox_AppointmentID.Text + "', '" + textBox_CoustomerID.Text + "','" + comboBox_StaffName.Text + "','" + dateTimePicker_AppoinmentDate.Text + "')";
                SqlCommand com = new SqlCommand(sqlQary, con);
                com.ExecuteNonQuery();

               
            }
            catch (Exception)
            {
                MessageBox.Show("Error!!");
            }

            MessageBox.Show("Successfull added an appointment!!!");
            textBox_AppointmentID.Clear();
            textBox_CoustomerID.Clear();
            comboBox_StaffName.Text = string.Empty;
            dateTimePicker_AppoinmentDate.Text = string.Empty;


        }

        private void button_View_AllAppointment_Click(object sender, EventArgs e)
        {
            String dbString = "Data Source=DESKTOP-N1AKUG5;Initial Catalog=E2046321;Integrated Security=True";
            SqlConnection con = new SqlConnection(dbString);
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from [dbo].[Table_Appointment]";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridView_Appointment.DataSource = DS.Tables[0];

        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_AppointmentID.Clear();
            textBox_CoustomerID.Clear();
            comboBox_StaffName.Text = string.Empty;
            dateTimePicker_AppoinmentDate.Text = string.Empty;

        }

        private void textBox_AppoId_TextChanged(object sender, EventArgs e)
        {
            String dbString = "Data Source=DESKTOP-N1AKUG5;Initial Catalog=E2046321;Integrated Security=True";
            SqlConnection con = new SqlConnection(dbString);
            con.Open();

            if (textBox_AppoId.Text != " ")
            {

                SqlCommand cmd = new SqlCommand("Select Customer_ID from Table_Appointment where Appointment_ID =@Appointment_ID", con);
                cmd.Parameters.AddWithValue("@Appointment_ID", textBox_AppoId.Text);
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    textBox_CosID.Text = da.GetValue(0).ToString();


                }
                con.Close();

            }
        }

        private void button_Make_Appointment_Click(object sender, EventArgs e)
        {
            panel_DeleteAppointment.Visible = false;
        }

        private void button_DeleteAppointment_Click(object sender, EventArgs e)
        {
            panel_DeleteAppointment.Visible = true;
        }

        private void button_deleteApp_Click(object sender, EventArgs e)
        {
            String dbString = "Data Source=DESKTOP-N1AKUG5;Initial Catalog=E2046321;Integrated Security=True";
            SqlConnection con = new SqlConnection(dbString);
            con.Open();

            if (MessageBox.Show("Are you shure to delete this data???", "Delete Records", MessageBoxButtons.YesNo) == DialogResult.Yes)

            {
                SqlCommand cmd = new SqlCommand("Delete Table_Appointment where Appointment_ID=@Appointment_ID", con);
                cmd.Parameters.AddWithValue("@Appointment_ID", int.Parse(textBox_AppoId.Text));
                cmd.ExecuteNonQuery();

                MessageBox.Show("Succesfully dleted");


                textBox_AppoId.Clear();
                textBox_CosID.Clear();

            }
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
