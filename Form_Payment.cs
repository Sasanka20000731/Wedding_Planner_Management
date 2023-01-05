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
    public partial class Form_Payment : Form
    {
        public Form_Payment()
        {
            InitializeComponent();
        }

        private void textBox_CID_TextChanged(object sender, EventArgs e)
        {
            String dbString = "Data Source=DESKTOP-N1AKUG5;Initial Catalog=E2046321;Integrated Security=True";
            SqlConnection con = new SqlConnection(dbString);
            con.Open();

            if (textBox_CID.Text != " ")
            {

                SqlCommand cmd = new SqlCommand("Select C_Name, C_Package from Table_Customer_Details where C_ID =@C_ID", con);
                cmd.Parameters.AddWithValue("@C_ID", textBox_CID.Text);
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    textBox_Coustomer_Name.Text = da.GetValue(0).ToString();
                    textBox_Package.Text = da.GetValue(1).ToString();


                }
                con.Close();

            }
        }

        private void button_save_Payment_Click(object sender, EventArgs e)
        {
            try
            {


                String dbString = "Data Source=DESKTOP-N1AKUG5;Initial Catalog=E2046321;Integrated Security=True";
                SqlConnection con = new SqlConnection(dbString);
                con.Open();

                String sqlQary = "insert into Table_Payment values('" + textBox_PaymentID.Text + "', '" + textBox_CID.Text + "','" + textBox_Coustomer_Name.Text + "','" + textBox_Package.Text + "')";
                SqlCommand com = new SqlCommand(sqlQary, con);
                com.ExecuteNonQuery();


            }
            catch (Exception)
            {
                MessageBox.Show("Error!!");
            }

            MessageBox.Show("Successfull added Payment!!!");
            textBox_PaymentID.Clear();
            textBox_CID.Clear();
            textBox_Coustomer_Name.Clear();
            textBox_Package.Clear();
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_PaymentID.Clear();
            textBox_CID.Clear();
            textBox_Coustomer_Name.Clear();
            textBox_Package.Clear();
        }

        private void button_ViewPayment_Click(object sender, EventArgs e)
        {
            panel_Delete_Payment.Visible = false;
            
            String dbString = "Data Source=DESKTOP-N1AKUG5;Initial Catalog=E2046321;Integrated Security=True";
            SqlConnection con = new SqlConnection(dbString);
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from [dbo].[Table_Payment]";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridView_Payment.DataSource = DS.Tables[0];
        }

        private void textBox_DPID_TextChanged(object sender, EventArgs e)
        {
            String dbString = "Data Source=DESKTOP-N1AKUG5;Initial Catalog=E2046321;Integrated Security=True";
            SqlConnection con = new SqlConnection(dbString);
            con.Open();

            if (textBox_DPID.Text != " ")
            {

                SqlCommand cmd = new SqlCommand("Select C_Name2 from Table_Payment where P_ID =@P_ID", con);
                cmd.Parameters.AddWithValue("@P_ID", textBox_DPID.Text);
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    textBox_DCName.Text = da.GetValue(0).ToString();
                  

                }
                con.Close();

            }
        }

        private void button_Delet_Click(object sender, EventArgs e)
        {
            String dbString = "Data Source=DESKTOP-N1AKUG5;Initial Catalog=E2046321;Integrated Security=True";
            SqlConnection con = new SqlConnection(dbString);
            con.Open();

            if (MessageBox.Show("Are you shure to delete this data???", "Delete Records", MessageBoxButtons.YesNo) == DialogResult.Yes)

            {
                SqlCommand cmd = new SqlCommand("Delete Table_Payment where P_ID=@P_ID", con);
                cmd.Parameters.AddWithValue("@P_ID", int.Parse(textBox_DPID.Text));
                cmd.ExecuteNonQuery();

                MessageBox.Show("Succesfully dleted");


                textBox_DPID.Clear();
                textBox_DCName.Clear();

            }
        }

        private void button_DeletePayment_Click(object sender, EventArgs e)
        {
            panel_Delete_Payment.Visible = true;
        }
    }
}
