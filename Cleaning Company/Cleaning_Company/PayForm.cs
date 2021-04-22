using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cleaning_Company
{
    public partial class PayForm : Form
    {
        private double finalPrice;

        public PayForm (double price)
        {
            this.finalPrice = price;
            InitializeComponent ();
            this.BackgroundImage = Properties.Resources.pay_background;
            btnPay.BackgroundImage = Properties.Resources.pink_to_yellow;
            btnCancel.BackgroundImage = Properties.Resources.pink_to_yellow;
        }

        private void PayForm_Load ( object sender , EventArgs e )
        {
            lblInfo.Text += this.finalPrice.ToString ("0.00") + "лв.";
        }
    }
}
