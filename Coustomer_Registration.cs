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
    public partial class Coustomer_Registration : Form
    {
        public Coustomer_Registration()
        {
            InitializeComponent();
        }

        private void button_Save_Coustomer_Detail_Click(object sender, EventArgs e)
        {
            
         
        
            
           try{


                String dbString = "Data Source=DESKTOP-N1AKUG5;Initial Catalog=E2046321;Integrated Security=True";
                SqlConnection con = new SqlConnection(dbString);
                con.Open();

                String sqlQary = "insert into Table_Customer_Details values('" + textBox_NewCoustomerName.Text + "', '" +textBox_NewCoustomerID.Text + "','" + textBox_CoustomerAddress.Text + "','" + textBox_CoustomerNicNumber.Text + "','" + dateTimePicker_WeddingDate.Text + "','" + comboBox_Package.Text + "')";
                SqlCommand com = new SqlCommand(sqlQary, con);
                com.ExecuteNonQuery();


            }
            catch (Exception)
            {
                MessageBox.Show("Error!!");
            }

            MessageBox.Show("Successfull added new Coustomer!!!");
           textBox_NewCoustomerName.Clear();
            textBox_NewCoustomerID.Clear();
            textBox_CoustomerAddress.Clear();
            textBox_CoustomerNicNumber.Clear();

            comboBox_Package.Text = string.Empty;
            dateTimePicker_WeddingDate.Text = string.Empty;





        }

        private void button_View_All_Coustomer_Details_Click(object sender, EventArgs e)
        {
            panel_DeleteCoustomer.Visible = false;
            
            
            String dbString = "Data Source=DESKTOP-N1AKUG5;Initial Catalog=E2046321;Integrated Security=True";
            SqlConnection con = new SqlConnection(dbString);
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from [dbo].[Table_Customer_Details]";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridViewViewCoustomerDetail.DataSource = DS.Tables[0];
        }

        private void textBox_CDId_TextChanged(object sender, EventArgs e)
        {
            String dbString = "Data Source=DESKTOP-N1AKUG5;Initial Catalog=E2046321;Integrated Security=True";
            SqlConnection con = new SqlConnection(dbString);
            con.Open();

            if (textBox_CDId.Text != " ")
            {

                SqlCommand cmd = new SqlCommand("Select C_Name from Table_Customer_Details where C_ID =@C_ID", con);
                cmd.Parameters.AddWithValue("@C_ID", textBox_CDId.Text);
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                   textBox_CDName.Text = da.GetValue(0).ToString();


                }
                con.Close();

            }
        }

        private void button_deleteApp_Click(object sender, EventArgs e)
        {
            String dbString = "Data Source=DESKTOP-N1AKUG5;Initial Catalog=E2046321;Integrated Security=True";
            SqlConnection con = new SqlConnection(dbString);
            con.Open();

            if (MessageBox.Show("Are you shure to delete this data???", "Delete Records", MessageBoxButtons.YesNo) == DialogResult.Yes)

            {
                SqlCommand cmd = new SqlCommand("Delete Table_Customer_Details where C_ID=@C_ID", con);
                cmd.Parameters.AddWithValue("@C_ID", int.Parse(textBox_CDId.Text));
                cmd.ExecuteNonQuery();

                MessageBox.Show("Succesfully dleted");


                textBox_CDId.Clear();
                textBox_CDName.Clear();

            }
        }

        private void button_DeleteCoustomer_Click(object sender, EventArgs e)
        {
            panel_DeleteCoustomer.Visible = true;
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_NewCoustomerName.Clear();
            textBox_NewCoustomerID.Clear();
            textBox_CoustomerAddress.Clear();
            textBox_CoustomerNicNumber.Clear();

            comboBox_Package.Text = string.Empty;
            dateTimePicker_WeddingDate.Text = string.Empty;
        }
    }
}
