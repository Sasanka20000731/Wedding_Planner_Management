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
    public partial class Staff_Registration : Form
    {
        public Staff_Registration()
        {
            InitializeComponent();
        }

        private void button_Creat_New_StaffAcc_Click(object sender, EventArgs e)
        {

            String dbString = "Data Source=DESKTOP-N1AKUG5;Initial Catalog=E2046321;Integrated Security=True";
            SqlConnection con = new SqlConnection(dbString);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Table_Staff_Details values (@Staff_Name,@Staff_ID,@Staff_Password,@Staff_Role)", con);
            cmd.Parameters.AddWithValue("@Staff_Name", textBox_NewStaffName.Text);
            cmd.Parameters.AddWithValue("@Staff_ID", textBox_NewStaffID.Text);
            cmd.Parameters.AddWithValue("@Staff_Password", textBox_NewStaffPassword.Text);
            cmd.Parameters.AddWithValue("@Staff_Role", comboBox_Role.SelectedItem);
            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Successfully Added New User");

            textBox_NewStaffName.Clear();
            textBox_NewStaffID.Clear();
            textBox_NewStaffPassword.Text = string.Empty;
           comboBox_Role.Text = string.Empty;



        }

        private void button_View_All_Account_Click(object sender, EventArgs e)
        {
            String dbString = "Data Source=DESKTOP-N1AKUG5;Initial Catalog=E2046321;Integrated Security=True";
            SqlConnection con = new SqlConnection(dbString);
            SqlCommand cmd = new SqlCommand("Select * from Table_Staff_Details", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView_AllStaffDetails.DataSource = dt;
        }

        private void button_DeleteAccount_Click(object sender, EventArgs e)
        {
            String dbString = "Data Source=DESKTOP-N1AKUG5;Initial Catalog=E2046321;Integrated Security=True";
            SqlConnection con = new SqlConnection(dbString);
            SqlCommand cmd = new SqlCommand("Delete Table_Staff_Details where Staff_Name=@Staff_Name", con);
            con.Open();

            cmd.Parameters.AddWithValue("@Staff_Name", textBox_NewStaffName.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Deleted");
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
