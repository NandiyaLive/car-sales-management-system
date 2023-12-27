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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            passwordTextBox.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cars carsForm = new Cars();

            if (usernameTextBox.Text == "" || passwordTextBox.Text == "")
            {
                usernameTextBox.Text = "";
                passwordTextBox.Text = "";
                MessageBox.Show("Enter username and password");
            }
            else if (usernameTextBox.Text == "admin" && passwordTextBox.Text == "1234")
            {
                this.Hide();
                carsForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
                usernameTextBox.Text = "";
                passwordTextBox.Text = "";
            }
        }
    }
}
