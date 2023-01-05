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
    public partial class Form_DashBoard_Reports : Form
    {
        public Form_DashBoard_Reports()
        {
            InitializeComponent();
        }

        private void button_Most_Demmanding_Package_Click(object sender, EventArgs e)
        {
            Most_Demmanding_Package most_Demmanding_Package = new Most_Demmanding_Package();
            most_Demmanding_Package.Show();
        }

        private void button_Least_Demmanding_Package_Click(object sender, EventArgs e)
        {
            Least_Demmanding_Package least_Demmanding_Package = new Least_Demmanding_Package();
            least_Demmanding_Package.Show();
        }
    }
}
