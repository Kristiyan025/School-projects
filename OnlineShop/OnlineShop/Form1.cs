using System;
using System.Drawing;
using System.Windows.Forms;

namespace OnlineShop
{
    public partial class fOnlineShop : Form
    {
        private double price;

        public fOnlineShop()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            DialogResult dr = cdColor.ShowDialog();
            if (dr == DialogResult.OK)
            {
                lblColor.BackColor = cdColor.Color;
                lblColorName.Text = cdColor.Color.Name;
            }
            else if(dr == DialogResult.Cancel)
            {
                lblColor.BackColor = Color.Transparent;
                lblColorName.Text = "Not chosen";
            }
        }

        private void cmbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((string)cmbBrand.SelectedItem)
            {
                case "Burberry":
                    pbBag.Image = Properties.Resources.burberry;
                    break;
                case "Calvin Klein":
                    pbBag.Image = Properties.Resources.calvin_klein;
                    break;
                case "Chanel":
                    pbBag.Image = Properties.Resources.chanel;
                    break;
                case "Fendi":
                    pbBag.Image = Properties.Resources.fendi;
                    break;
                case "Furla":
                    pbBag.Image = Properties.Resources.furla;
                    break;
                case "Gucci":
                    pbBag.Image = Properties.Resources.gucci;
                    break;
                case "Guess":
                    pbBag.Image = Properties.Resources.guess;
                    break;
                case "Luis Vuitton":
                    pbBag.Image = Properties.Resources.luis_vuitton;
                    break;
                case "Michael Kors":
                    pbBag.Image = Properties.Resources.michael_kors;
                    break;
                case "Prada":
                    pbBag.Image = Properties.Resources.prada;
                    break;
            }

            CalculatePrice();
        }

        private void cmbPayMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((string)cmbPayMethod.SelectedItem)
            {
                case "Cash":
                    pbPayMethod.Image = Properties.Resources.cash;
                    break;
                case "Credit card":
                    pbPayMethod.Image = Properties.Resources.credit_card;
                    break;
                case "Debit card":
                    pbPayMethod.Image = Properties.Resources.debit_card;
                    break;
                case "PayPal":
                    pbPayMethod.Image = Properties.Resources.paypal;
                    break;
            }

            CalculatePrice();
        }

        private void cmbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void nudCount_ValueChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void CalculatePrice()
        {
            double price = 0;
            switch ((string)cmbBrand.SelectedItem)
            {
                case "Burberry":
                    price = 410;
                    break;
                case "Calvin Klein":
                    price = 420;
                    break;
                case "Chanel":
                    price = 600;
                    break;
                case "Fendi":
                    price = 280;
                    break;
                case "Furla":
                    price = 250;
                    break;
                case "Gucci":
                    price = 1000;
                    break;
                case "Guess":
                    price = 370;
                    break;
                case "Luis Vuitton":
                    price = 700;
                    break;
                case "Michael Kors":
                    price = 540;
                    break;
                case "Prada":
                    price = 870;
                    break;
                default:
                    price = 0.00;
                    break;
            }
            switch((string)cmbSize.SelectedItem)
            {
                case "XXS":
                    price *= 0.87;
                    break;
                case "XS":
                    price *= 0.94;
                    break;
                case "S":
                    price *= 0.97;
                    break;
                case "M":
                    price *= 1.02;
                    break;
                case "L":
                    price *= 1.05;
                    break;
                case "XL":
                    price *= 1.10;
                    break;
                case "XXL":
                    price *= 1.14;
                    break;
                default:
                    price = 0.00;
                    break;
            }

            price *= (int)nudCount.Value;

            //DDS
            price *= 1.20;
            lblPrice.Text = $"{(this.price = price):F2}$";
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            MessageBox.Show($"Order:\n" +
                $" Id: {r.Next((int)1e6, (int)1e7)}\n" +
                $" Customer:\n" +
                $"  Name: {txtName.Text}\n" +
                $"  Address: {txtAddress.Text}\n" +
                $"  Email: {txtAddress.Text}\n" +
                $" Products:\n" +
                $"  Brand: {(string)cmbBrand.SelectedItem}\n" +
                $"  Size: {(string)cmbSize.SelectedItem}\n" +
                $"  Color: {lblColorName.Text}\n" +
                $"  Individual Price: {this.price / (double)nudCount.Value}$\n" +
                $"  Count: {nudCount.Value}\n" +
                $" Payment method: {(string)cmbPayMethod.SelectedItem}\n\n" +
                $" Final Price: {this.price}$\n\n\n\n" +
                $"Have a nice day! :):):):):)", "Order");

            //Restart the Order Form
            txtName.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            cmbBrand.SelectedItem = null;
            cmbSize.SelectedItem = null;
            nudCount.Value = 1;
            cdColor.Reset();
            lblColor.BackColor = Color.Transparent;
            lblColorName.Text = "Not chosen";
            pbBag.Image = Properties.Resources.online_shop_title;
            cmbPayMethod.SelectedItem = null;
            pbPayMethod.Image = null;
            lblPrice.Text = $"{0:F2}$";
        }
    }
}
