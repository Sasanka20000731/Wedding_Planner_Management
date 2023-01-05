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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_logIn_Click(object sender, EventArgs e)
        {
     


            String conString = "Data Source=DESKTOP-N1AKUG5;Initial Catalog=E2046321;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);
            SqlDataAdapter da;
            SqlCommand cmd;


            con.Open();
            cmd = new SqlCommand("Select * from  Table_Staff_Details where Staff_Name = '" + textBox_LoginName.Text.Trim() + "' and  Staff_Password = '" + textBox_LogingPassword.Text.Trim() + "'", con);
            da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.SelectCommand = cmd;
            da.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (i == 1)
            {


                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr[3].ToString() == "Admin")
                {
                    ClassUL.type = "A";

                }
                else if (dr[3].ToString() == "Cashier")
                {

                    ClassUL.type = "C";
                }
                else if (dr[3].ToString() == "Event Cordinaters")
                {
                    ClassUL.type = "E";
                }




                Dashboard dashboard = new Dashboard();
                this.Hide();
                dashboard.Show();



            }

            else
            {
                MessageBox.Show("Check your Username and Password");
            }

        }
    }
}
