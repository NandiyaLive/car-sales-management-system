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
    public partial class Cars : Form
    {
        public Cars()
        {
            InitializeComponent();
        }

        private void Cars_Load(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int modelYear = 0;
            int seats;
            int usedYears;
            int distanceTraveled;
            float price;
            String text;
            int discount;

            if (string.IsNullOrWhiteSpace(txtModelYear.Text))
            {
                errorProvider.SetError(txtModelYear, "Model Year connot be blank");
                return;
            }
            else
            {
                modelYear = Int32.Parse(txtModelYear.Text);

                if (modelYear < 1900 || modelYear > 2023)
                {
                    errorProvider.SetError(txtModelYear, "Invalid model year");
                    return;
                }
            }

            if (string.IsNullOrWhiteSpace(txtSeat.Text))
            {
                errorProvider.SetError(txtSeat, "Number of seats connot be blank");
                return;
            }
            else
            {
                seats = Int32.Parse(txtSeat.Text);

                if (seats < 1 || seats > 10)
                {
                    errorProvider.SetError(txtSeat, "Invalid number of seats");
                    return;
                }
            }

            if (string.IsNullOrWhiteSpace(txtUsedYears.Text))
            {
                errorProvider.SetError(txtUsedYears, "Used years connot be blank");
                return;
            }
            else
            {
                usedYears = Int32.Parse(txtUsedYears.Text);

                if (usedYears < 1 || usedYears > 100)
                {
                    errorProvider.SetError(txtUsedYears, "Invalid number of used years");
                    return;
                }
            }

            if (string.IsNullOrWhiteSpace(txtDistTravel.Text))
            {
                errorProvider.SetError(txtDistTravel, "Distance traveled connot be blank");
                return;
            }
            else
            {
                distanceTraveled = Int32.Parse(txtDistTravel.Text);

                if (distanceTraveled < 0)
                {
                    errorProvider.SetError(txtDistTravel, "Invalid distance traveled");
                    return;
                }
            }

            if (string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                errorProvider.SetError(txtPrice, "Price connot be blank");
                return;
            }
            else
            {
                price = float.Parse(txtPrice.Text);

                if (price < 0)
                {
                    errorProvider.SetError(txtPrice, "Invalid price");
                    return;
                }
            }

            if (!string.IsNullOrWhiteSpace(txtDiscount.Text))
            {
                discount = Int32.Parse(txtDiscount.Text);

                if (discount < 0 || discount > 100)
                {
                    errorProvider.SetError(txtDiscount, "Invaid discount! Discound must be between 0 - 100");
                    return;
                }

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
    

