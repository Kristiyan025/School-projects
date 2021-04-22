using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    public partial class fMain : Form
    {
        private Car[] cars =
        {
            new Car("Citroen C4",
                "Citroen C4 под наем 1,6 бензин, 106к.с. Разход на гориво на 100км: градско 8 л; извънградско 6 л. 5-степенна ръчна скоростна кутия, 4+1 места, двузонов климатроник, CD, радио, парктроник отпред и отзад, ксенонови фарове завиващи по завоя, автопилот и др. Най-луксозния салон - Exclusive.",
                Properties.Resources._01),
            new Car("Opel Astra H Wagon",
                "Opel Astra Wagon под наем 1,4 бензин, 90к.с. Разход на гориво на 100км: градско 7 л; извънградско 5 л. 5-степенна ръчна скоростна кутия, 4+1 места, климатик, CD, радио.",
                Properties.Resources._02),
            new Car("Mazda 6 Wagon",
                "Mazda 6 Wagon под наем 1,8 бензин, 120к.с. Разход на гориво на 100км: градско 8 л; извънградско 6 л. 5-степенна ръчна скоростна кутия, 4+1 места, климатроник, CD, радио, автопилот.",
                Properties.Resources._03),
            new Car("Ford Focus Sedan",
                "Ford Focus Sedan под наем 1,6 дизел, 109к.с. Разход на гориво на 100км: градско 6 л; извънградско 4 л. 5 степенна ръчна скоростна кутия, 4+1 места, климатик, CD, радио, автопилот.",
                Properties.Resources._04),
            new Car("Ford C-Max",
                "Ford C-Max под наем 1,8 бензин, 123к.с. Разход на гориво на 100км: градско 8 л; извънградско 6 л. 5-степенна ръчна скоростна кутия, 4+1 места, двузонов климатроник, CD, радио, подгряване на седалките.",
                Properties.Resources._05),
            new Car("Peugeot 407 Sedan",
                "Peugeot 407 Sedan под наем 2,0 дизел, 136к.с. Разход на гориво на 100км: градско 7 л; извънградско 5 л. 6-степенна ръчна скоростна кутия, 4+1 места, двузонов климатроник, CD, радио.",
                Properties.Resources._06),
        };
        private int defaultPeriod = 10;
        private int[] monthIndices = { 3, 3, 3, 2, 2, 1, 0, 0, 1, 3, 3, 2 };
        private double[] f2to4 = { 26.0, 23.0, 21.0, 17.0 };
        private double[] f5to9 = { 25.0, 21.0, 19.0, 15.0 };
        private double[] f10to19 = { 24.0, 19.0, 17.0, 13.0 };
        private double[] f20 = { 23.0, 17.0, 15.0, 13.0 };
        private Random r = new Random();

        public fMain()
        {
            InitializeComponent();

            for(int i = 0; i < cars.Length; i++)
            {
                cmbModel.Items.Add(cars[i].Model);
            }

            cmbModel.SelectedIndex = 0;
            pbCarImage.Image = cars[cmbModel.SelectedIndex].Image;
            lblInfo.Text = cars[cmbModel.SelectedIndex].Info;
            dtpRentDate.Value = DateTime.Today;
            dtpReturnDate.Value = DateTime.Today.AddDays(defaultPeriod);
            UpdatePrice();
        }

        private void cmbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            pbCarImage.Image = cars[cmbModel.SelectedIndex].Image;
            lblInfo.Text = cars[cmbModel.SelectedIndex].Info;
        }

        private void dtpRentDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpRentDate.Value >= dtpReturnDate.Value)
            {
                dtpRentDate.Value = dtpReturnDate.Value.AddDays(-defaultPeriod);
            }

            UpdatePrice();
        }

        private void dtpReturnDate_ValueChanged(object sender, EventArgs e)
        {
            if(dtpReturnDate.Value <= dtpRentDate.Value)
            {
                dtpReturnDate.Value = dtpRentDate.Value.AddDays(defaultPeriod);
            }

            UpdatePrice();
        }

        private void UpdatePrice()
        {
            double price = 100.0; //deposit
            int duration = dtpReturnDate.Value.Subtract(dtpRentDate.Value).Days;
            if(duration == 1)
            {
                price += 36.0;
            }
            else if(2 <= duration && duration <= 4)
            {
                price += f2to4[monthIndices[dtpRentDate.Value.Month - 1]] * duration;
            }
            else if (5 <= duration && duration <= 9)
            {
                price += f5to9[monthIndices[dtpRentDate.Value.Month - 1]] * duration;
            }
            else if (10 <= duration && duration <= 19)
            {
                price += f10to19[monthIndices[dtpRentDate.Value.Month - 1]] * duration;
            }
            else
            {
                price += f20[monthIndices[dtpRentDate.Value.Month - 1]] * duration;
            }

            if (cbChair.Checked) price += 10;
            if (cbChains.Checked) price += 8;
            if (cbTrunk.Checked) price += 15;

            lblPrice.Text = $"{price:F2} лв.";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAdress.Text = "";
            txtPhone.Text = "";

            cbChair.Checked = false;
            cbChains.Checked = false;
            cbTrunk.Checked = false;

            rbtnCreditCard.Checked = true;

            cmbModel.SelectedIndex = 0;
            pbCarImage.Image = cars[cmbModel.SelectedIndex].Image;
            lblInfo.Text = cars[cmbModel.SelectedIndex].Info;
            dtpRentDate.Value = DateTime.Today.AddDays(1);
            dtpReturnDate.Value = DateTime.Today.AddDays(defaultPeriod);
            UpdatePrice();
        }

        private void cb_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            string paymentMethod = "";
            if (rbtnCreditCard.Checked) paymentMethod = "С кредитна карта";
            else if (rbtnBankTransfer.Checked) paymentMethod = "По банков път";
            else paymentMethod = "В брой";
            MessageBox.Show($"Фактура №{r.Next(10000000, 100000000)}\n" +
                $"Вие, {txtFirstName.Text} {txtLastName.Text}, " +
                $"с текущ адрес {txtAdress.Text}, и тел. номер {txtPhone.Text}, " +
                $"наехте колата {cars[cmbModel.SelectedIndex].Model} " +
                $"от {dtpRentDate.Value:dd/MMM/yyyy} до {dtpReturnDate.Value:dd/MMM/yyyy}.\n" +
                $"Информация за колата: {cars[cmbModel.SelectedIndex].Info}\n" +
                $"Начин на плащане: {paymentMethod}!\n" +
                $"Дължима сума: {lblPrice.Text}");
            btnClear_Click(null, null);
        }
    }
}
