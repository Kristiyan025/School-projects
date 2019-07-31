using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BS_game
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        Random r = new Random();
        static int score = 0;
        static int played = 0;

        private void btn7_Click_1(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string text = "";
            switch(btn.Text)
            {
                case "0":
                    text = "1";
                    break;
                case "1":
                    text = "0";
                    break;
            }
            btn.Text = text;
        }

        private void Game_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            lblNumber.Text = r.Next(0, 256).ToString();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = timer1.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int guessNum = 0;
            if(btn1.Text == "1")
            {
                guessNum += 1;
            }
            if (btn2.Text == "1")
            {
                guessNum += 2;
            }
            if (btn3.Text == "1")
            {
                guessNum += 4;
            }
            if (btn4.Text == "1")
            {
                guessNum += 8;
            }
            if (btn5.Text == "1")
            {
                guessNum += 16;
            }
            if (btn6.Text == "1")
            {
                guessNum += 32;
            }
            if (btn7.Text == "1")
            {
                guessNum += 64;
            }
            if (btn8.Text == "1")
            {
                guessNum += 128;
            }

            if(guessNum.ToString() == lblNumber.Text)
            {
                score++;
                played++;
                lblPoints.Text = score.ToString();
                lblError.ForeColor = Color.FromArgb(r.Next(150, 255), r.Next(150, 255), r.Next(150, 255));
                lblError.Text = "You guess the number!";
                lblNumber.Text = r.Next(0, 256).ToString();
                for (int i = 1; i <= 8; i++)
                {
                    this.Controls[$"btn{i}"].Text = "0";
                }
                if(score == 3)
                {
                    lblError.ForeColor = Color.FromArgb(r.Next(150, 255), r.Next(150, 255), r.Next(150, 255));
                    lblError.Text = "You must win 3 from " + played.ToString() + " games! You can't playmore games!";
                    btn1.Enabled = false;
                    btn2.Enabled = false;
                    btn3.Enabled = false;
                    btn4.Enabled = false;
                    btn5.Enabled = false;
                    btn6.Enabled = false;
                    btn7.Enabled = false;
                    btn8.Enabled = false;
                    button1.Enabled = false;
                }

            }
            else
            {
                played++;
                lblError.ForeColor = Color.FromArgb(r.Next(150, 255), r.Next(150, 255), r.Next(150, 255));
                lblError.Text = "You didn't success to guess the number!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
