using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Cleaning_Company
{
    public partial class MainForm : Form
    {
        private TitleForm previous;

        private double price = 0.00;
        private double townPrice = 0.00;
        private double areaPrice = 0.00;
        private double roomPrice = 0.00;
        private Dictionary<string, double> cleaningKinds = new Dictionary<string, double>();

        private Image[] cardTypes = new Image[]
        {
            Properties.Resources.mastercard,
            Properties.Resources.visa_card,
            Properties.Resources.maestro_card,
            Properties.Resources.vpay_card,
            Properties.Resources.bcard,
        };

        private char[] cardNumber = new char[16];
        private int CardNumberCurrentLength = 0;
        private List<char> expireDate = new List<char>();

        private Random r = new Random();

        public MainForm(TitleForm titleForm)
        {
            this.previous = titleForm;
            InitializeComponent();
            InitializeDateTimeComponents();
            InitializeImages();
            InitializeDefaultValues();
        }
        
        private void InitializeDateTimeComponents()
        {
            //dtDate
            dtDate.MinDate = DateTime.Now.AddDays(1);
            dtDate.MaxDate = DateTime.Now.AddDays(100);
            dtDate.Value = dtDate.MinDate;

            //dtTime
            dtTime.MinDate = new DateTime(2002, 2, 3, 8, 0, 0); // locks the time from 8:00
            dtTime.MaxDate = new DateTime(2002, 2, 3, 18, 0, 0); //to 18:00
            dtTime.Value = new DateTime(2002, 2, 3, 13, 0, 0);
        }

        private string GetDate()
        {
            return $"{dtDate.Value.ToShortDateString()}, {dtTime.Value.ToShortTimeString()}";
        }

        private void InitializeImages()
        {
            this.BackgroundImage = Properties.Resources.background;
            btnOrder.BackgroundImage = Properties.Resources.pink_to_yellow;
            btnBack.BackgroundImage = Properties.Resources.pink_to_yellow;
            pbCard.Image = cardTypes[0];
            pbCVVHelp.Image = Properties.Resources.cvv_help;
            pbCVVHelp.Size = pbCVVHelp.Image.Size;
        }

        private double DoubleParse(object tag) => double.Parse((string)tag);

        private void InitializeDefaultValues()
        {
            cmbTown.Text = "Благоевград";
            UpdateTownPrice();
            nudArea.Value = 50;
            UpdateAreaPrice();
            nudRoomCount.Value = 2;
            UpdateRoomPrice();

            //Dictionary cleaningKinds
            cleaningKinds[nameof(cbMob)] =
            cleaningKinds[nameof(cbVacuumCleaner)] =
            cleaningKinds[nameof(cbSteamCleaner)] =
            cleaningKinds[nameof(cbDust)] =
            cleaningKinds[nameof(cbWindows)] =
            cleaningKinds[nameof(cbDishes)] = 0.00;

            cardNumber.Initialize();
            CardNumberCurrentLength = 0;
        }

        private void UpdateTownPrice()
        {
            townPrice = 2.00;
            if(cmbTown.Text != "Благоевград")
            {
                townPrice = 10.00;
            }    
        }

        private void UpdateAreaPrice()
        {
            areaPrice = 0.00;
            double area = (double)nudArea.Value;
            if(area > 100)
            {
                areaPrice = (area - 100) * 0.10;
            }
        }

        private void UpdateRoomPrice()
        {
            roomPrice = 0.00;
            double roomCount = (double)nudRoomCount.Value;
            if(roomCount > 5)
            {
                roomPrice = (roomCount - 5) * 3.00;
            }
        }

        private void UpdateMobPrice()
        {
            cleaningKinds[nameof(cbMob)] = cbMob.Checked ?
            (double)nudArea.Value * DoubleParse(cbMob.Tag) : 0;
        }

        private void UpdateVacuumCleanerPrice()
        {
            cleaningKinds[nameof(cbVacuumCleaner)] = cbVacuumCleaner.Checked ?
            (double)nudArea.Value * DoubleParse(cbVacuumCleaner.Tag) : 0;
        }

        private void UpdateSteamCleanerPrice()
        {
            cleaningKinds[nameof(cbSteamCleaner)] = cbSteamCleaner.Checked ?
            (double)nudArea.Value * DoubleParse(cbSteamCleaner.Tag) : 0;
        }

        private void UpdateDustPrice()
        {
            cleaningKinds[nameof(cbDust)] = cbDust.Checked ?
            (double)nudArea.Value * DoubleParse(cbDust.Tag) : 0;
        }

        private void UpdateWindowsPrice()
        {
            cleaningKinds[nameof(cbWindows)] = cbWindows.Checked ?
            (double)nudWindows.Value * DoubleParse(cbWindows.Tag) : 0;
        }

        private void UpdateDishesPrice()
        {
            cleaningKinds[nameof(cbDishes)] = cbDishes.Checked ?
            (double)nudDishes.Value * DoubleParse(cbDishes.Tag) : 0;
        }

        private void UpdatePrice()
        {
            price = 0.00;
            price += townPrice;
            price += areaPrice;
            price += roomPrice;
            foreach (string name in cleaningKinds.Keys)
            {
                price += cleaningKinds[name];
            }

            lblPrice.Text = $"{this.price:F2}лв.";
        }

        private void UpdateAllPrices()
        {
            UpdateTownPrice();
            UpdateAreaPrice();
            UpdateRoomPrice();
            UpdateMobPrice();
            UpdateVacuumCleanerPrice();
            UpdateSteamCleanerPrice();
            UpdateDustPrice();
            UpdateWindowsPrice();
            UpdateDishesPrice();
            UpdatePrice();
        }

        private void cmbTown_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTownPrice();
            UpdatePrice();
        }

        private void nudArea_ValueChanged(object sender, EventArgs e)
        {
            UpdateAllPrices();
        }

        private void nudRoomCount_ValueChanged(object sender, EventArgs e)
        {
            UpdateRoomPrice();
            UpdatePrice();
        }

        private void cbMob_CheckedChanged(object sender, EventArgs e)
        {
            UpdateMobPrice();
            UpdatePrice();
        }

        private void cbVacuumCleaner_CheckedChanged(object sender, EventArgs e)
        {
            UpdateVacuumCleanerPrice();
            UpdatePrice();
        }

        private void cbSteamCleaner_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSteamCleanerPrice();
            UpdatePrice();
        }

        private void cbDust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDustPrice();
            UpdatePrice();
        }

        private void cbWindows_CheckedChanged(object sender, EventArgs e)
        {
            lblWindowsCount.Visible = nudWindows.Visible = cbWindows.Checked;
            if(cbWindows.Checked)
            {
                nudWindows.Value = 3;
            }

            UpdateWindowsPrice();
            UpdatePrice();
        }

        private void nudWindows_ValueChanged(object sender, EventArgs e)
        {
            UpdateWindowsPrice();
            UpdatePrice();
        }

        private void cbDishes_CheckedChanged(object sender, EventArgs e)
        {
            lblDishesCount.Visible = nudDishes.Visible = gbDishes.Visible = cbDishes.Checked;
            if (cbDishes.Checked)
            {
                rbtnSink.Checked = true;
                nudDishes.Value = 1;
            }

            UpdateDishesPrice();
            UpdatePrice();
        }

        private void rbtnSink_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnSink.Checked)
            {
                cbDishes.Tag = rbtnSink.Tag;
            }
            
            UpdateDishesPrice();
            UpdatePrice();
        }

        private void rbtnDishwasher_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnDishwasher.Checked)
            {
                cbDishes.Tag = rbtnDishwasher.Tag;
            }

            UpdateDishesPrice();
            UpdatePrice();
        }

        private void nudDishes_ValueChanged(object sender, EventArgs e)
        {
            UpdateDishesPrice();
            UpdatePrice();
        }

        private void rbtnCreditCard_CheckedChanged(object sender, EventArgs e)
        {
            gbCreditCard.Visible = rbtnCreditCard.Checked;
        }

        private void rbtnCardType_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbtn = (RadioButton)sender;
            if(rbtn.Checked)
            {
                pbCard.Image = cardTypes[int.Parse(rbtn.Tag.ToString())];
            }
        }

        private string GetCardNumberAsText()
        {
            return $"{cardNumber[0]}{cardNumber[1]}{cardNumber[2]}{cardNumber[3]} {cardNumber[4]}{cardNumber[5]}{cardNumber[6]}{cardNumber[7]} {cardNumber[8]}{cardNumber[9]}{cardNumber[10]}{cardNumber[11]} {cardNumber[12]}{cardNumber[13]}{cardNumber[14]}{cardNumber[15]}";
        }

        [DllImport("user32.dll")]
        static extern bool HideCaret(System.IntPtr hWnd);

        private void HideCaretOf(TextBox txt)
        {
            HideCaret(txt.Handle);
        }

        private void txtCardNumber_Click(object sender, EventArgs e)
        {
            HideCaretOf(txtCardNumber);
        }

        private void txtCardNumber_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
            if(e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 && CardNumberCurrentLength < 16) //key is a digit from the top of the keyboard
            {
                cardNumber[CardNumberCurrentLength++] = (char)(e.KeyCode - Keys.D0 + '0');
            }
            else if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9 && CardNumberCurrentLength < 16) //key is a digit from the numpad
            {
                cardNumber[CardNumberCurrentLength++] = (char)(e.KeyCode - Keys.NumPad0 + '0');
            }
            else if(e.KeyCode == Keys.Back && CardNumberCurrentLength > 0)
            {
                cardNumber[--CardNumberCurrentLength] = '\0';
            }
            else if(e.KeyCode == Keys.Enter)
            {
                this.Focus();
            }

            txtCardNumber.Text = GetCardNumberAsText();
        }

        private void txtExpireDate_Click(object sender, EventArgs e)
        {
            HideCaretOf(txtExpireDate);
        }

        private string GetExpireDateAsText()
        {
            string text = "";
            if (expireDate.Count > 0) text += expireDate[0].ToString();
            if (expireDate.Count > 1) text += expireDate[1].ToString();
            if (expireDate.Count > 2) text += "/" + expireDate[2].ToString();
            if (expireDate.Count > 3) text += expireDate[3].ToString();
            return text;
        }

        private void txtExpireDate_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 && expireDate.Count < 4) //key is a digit from the top of the keyboard
            {
                expireDate.Add((char)(e.KeyCode - Keys.D0 + '0'));
            }
            else if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9 && expireDate.Count < 4) //key is a digit from the numpad
            {
                expireDate.Add((char)(e.KeyCode - Keys.NumPad0 + '0'));
            }
            else if (e.KeyCode == Keys.Back && expireDate.Count > 0)
            {
                expireDate.RemoveAt(expireDate.Count - 1);
            }
            else if (e.KeyCode == Keys.Enter)
            {
                this.Focus();
            }

            txtExpireDate.Text = GetExpireDateAsText();
        }

        private void lblCVV_MouseEnter(object sender, EventArgs e)
        {
            pbCVVHelp.Visible = true;
        }

        private void lblCVV_MouseLeave(object sender, EventArgs e)
        {
            pbCVVHelp.Visible = false;
        }

        private string GetCleaningMethods()
        {
            CheckBox[] cbs = new CheckBox[]
            {
                cbMob,
                cbVacuumCleaner,
                cbSteamCleaner,
                cbDust,
                cbWindows,
                cbDishes
            };

            return string.Join(", ", cbs
                .Where(x => x.Checked)
                .Select(x => string.Join(" ", x.Text
                        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                        .Take(2))));
        }

        private string GetPaymentMethod()
        {
            if(rbtnCreditCard.Checked)
            {
                return $"с кредитна/дебитна карта с номер **** **** **** {cardNumber[12]}{cardNumber[13]}{cardNumber[14]}{cardNumber[15]}, притежавана от {txtCardName.Text}, изтичаща на {GetExpireDateAsText()}";
            }
            else if(rbtnCash.Checked)
            {
                return "в брой на място";
            }

            return "";
        }

        private string GetMessage()
        {
            return $"Транзакция №{r.Next(100001, 1000000)}\n" +
                   $"Вие, {txtFullName.Text}, поръчахте услугите на професионалната фирма за почистване „Клийнмакс“.\n" +
                   $"На {GetDate()} служители на фирмата ще дойдат във Вашия град, гр. {cmbTown.Text}, на адреса Ви: {txtAddress.Text}, за да почисти {nudRoomCount.Value}-стайния Ви дом с площ {nudArea.Value} кв.м!\n" +
                   $"Почистването ще включва: {GetCleaningMethods()}.\n" +
                   $"Начин на плащане: {GetPaymentMethod()}\n\n" +
                   $"Благодарим Ви за поръчката!...";
        }

        private void brnPay_Click(object sender, EventArgs e)
        {
            PayForm pf = new PayForm(price);
            if (pf.ShowDialog() == DialogResult.OK)
            {
                string message = GetMessage();
                previous.Show();
                this.Close();
                MessageBox.Show(message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            previous.Show();// отваряне на заглавната форма
            this.Close();//затваряне на текущата форма 
        }
    }
}
