using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digits
{
    public partial class Form1 : Form
    {
        private Encoding enc = Encoding.GetEncoding("windows-1251");

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            StreamWriter sw = new StreamWriter("number1.txt", false, enc);
            for (int i = 1; i <= 100; i++)
            {
                int num = r.Next(1, 501);
                sw.WriteLine(num);
                rtxtResult.Text += num + "\n";
            }
            sw.Close();

        }

        private void btnRevirse_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("reverse.txt", false, enc);
            StreamReader sr = new StreamReader("number1.txt", enc);
            string s;
            while((s = sr.ReadLine()) != null)
            {
                int number = int.Parse(s);
                sw.WriteLine(Reverse(number));
            }

            sr.Close();
            sw.Close();
        }

        private int Reverse(int number)
        {
            int n = 0;
            while(number > 0)
            {
                int digit = number % 10;
                number /= 10;
                n = n * 10 + digit;
            }
            return n;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader($"{txtName.Text}.txt", enc);
            rtxtResult.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int sum = 0;
            StreamReader sr = new StreamReader("number1.txt", enc);
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                int number = int.Parse(s);
                if(number % 3 == 0 || number % 5 == 0)
                {
                    sum += number;
                }
            }

            sr.Close();
            rtxtResult.Text = sum.ToString();
        }
    }
}
