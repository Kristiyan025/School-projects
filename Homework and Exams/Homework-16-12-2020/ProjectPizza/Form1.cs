using System;
using System.Windows.Forms;

namespace ProjectPizza
{
    public partial class Form1 : Form
    {
        private double total = 0.0;
        private int pizzaId = 0;
        bool isSmallPizza = true;
        private string[] pizzaInfo = new string[]
        {
            "(доматен сос, кашкавал, риган)\nМалка: 5,59 лв. (370 гр.)\nГоляма: 6,59 лв. (570 гр.)",
            "(доматен сос, кашкавал, шунка, бекон, пилешко филе, луканка, кисели краставички, гъби, царевица, риган)\nМалка: 8,39 лв. (460 гр.)\nГоляма: 9,39 лв. (670 гр.) ",
            "(доматен сос, кашкавал, пилешко филе, чушки, царевица, топено сирене, риган)\nМалка: 7,79 лв. (450 гр.)\nГоляма: 8,79 лв. (660 гр.) ",
            "(доматен сос, кашкавал, гъби, шунка, риган)\nМалка: 7,69 лв. (430 гр.)\nГоляма: 8,69 лв. (640 гр.) ",
            "(гъби, кисели краставички, царевица, лук, маслини, чушки, кашкавал)\nМалка: 7,29 лв. (440 гр.)\nГоляма: 8,29 лв. (650 гр.) "
        };
        private double[] smallPizzas = new double[] { 5.59, 8.39, 7.79, 7.69, 7.29 };
        private double[] bigPizzas = new double[] { 6.59, 9.39, 8.79, 8.69, 8.29 };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pbPizza.Image = Properties.Resources.margerita;
            lblInfo.Text = pizzaInfo[pizzaId];
            UpdatePizza(true);
        }

        private void UpdateTotal()
        {
            lblTotal.Text = $"{this.total:F2}лв.";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdatePizza(bool add)
        {
            int factor = 1;
            if (!add)
            {
                factor = -1;
            }

            if (isSmallPizza)
            {
                this.total += factor * smallPizzas[pizzaId];
            }
            else
            {
                this.total += factor * bigPizzas[pizzaId];
            }

            UpdateTotal();
        }

        private void UpdateSaucesAndSideDishes(bool add, double amount)
        {
            int factor = 1;
            if (!add)
            {
                factor = -1;
            }

            this.total += factor * amount;
            UpdateTotal();
        }

        private void UpdateSize()
        {
            int factor = 1;
            if (isSmallPizza)
            {
                factor = -1;
            }

            this.total += factor * Math.Abs(smallPizzas[pizzaId] - bigPizzas[pizzaId]);

            UpdateTotal();
        }

        private void rdnKind_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdn = (RadioButton)sender;
            pizzaId = int.Parse((string)rdn.Tag);
            switch(pizzaId)
            {
                case 0:
                    pbPizza.Image = Properties.Resources.margerita;
                    break;
                case 1:
                    pbPizza.Image = Properties.Resources.kuatro_stadjioni;
                    break;
                case 2:
                    pbPizza.Image = Properties.Resources.palermo;
                    break;
                case 3:
                    pbPizza.Image = Properties.Resources.kapcihosa;
                    break;
                case 4:
                    pbPizza.Image = Properties.Resources.vegetariana_pizza;
                    break;
            }

            lblInfo.Text = pizzaInfo[pizzaId];
            UpdatePizza(rdn.Checked);
        }

        private void rdnBig_CheckedChanged(object sender, EventArgs e)
        {
            if (rdnSmall.Checked) isSmallPizza = true;
            else isSmallPizza = false;
            RadioButton rdn = (RadioButton)sender;
            UpdateSize();
        }

        private void cbVegetables_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            double price = double.Parse((string)cb.Tag);
            UpdateSaucesAndSideDishes(cb.Checked, price);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Вие дължите: {this.total:F2}лв.");
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            rdnMargarita.Checked = true;
            rdnSmall.Checked = true;
            foreach(CheckBox cb in gbSideDish.Controls)
            {
                cb.Checked = false;
            }
            foreach (CheckBox cb in gbSauces.Controls)
            {
                cb.Checked = false;
            }
            pizzaId = 0;
            this.total = smallPizzas[pizzaId];
            pbPizza.Image = Properties.Resources.margerita;
            lblInfo.Text = pizzaInfo[pizzaId];
            UpdateTotal();
        }
    }
}
