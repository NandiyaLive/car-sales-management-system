using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_sale_management
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            

            Login loginForm = new Login();


            this.Hide();
            loginForm.Show();

        }
    }
}
