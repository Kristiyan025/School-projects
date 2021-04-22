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


namespace Prep
{
    public partial class Form1 : Form
    {
        private Encoding enc = Encoding.GetEncoding("windows-1251");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            using (StreamWriter sw = new StreamWriter(@"..\..\tt.txt", false, enc))
            {
                
            }
            using (StreamReader sr = new StreamReader(@"..\..\tt.txt", enc))
            {
                string s = sr.ReadLine();
                sr.ReadToEnd();
            }
            */
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string path = @"..\..\" + txtName.Text + ".txt";
            using (StreamWriter sw = new StreamWriter(path, false, enc))
            {
                sw.WriteLine(rtxtInput.Text);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string path = @"..\..\" + txtName.Text + ".txt";
            using (StreamReader sr = new StreamReader(path, enc))
            {
                lblResult.Text = sr.ReadToEnd();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            rtxtInput.Text = "";
            lblResult.Text = "";
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            using (StreamWriter sw = new StreamWriter(@"..\..\random.txt", false, enc))
            {
                for (int i = 1; i <= 100; i++)
                {
                    sw.WriteLine(r.Next(1, 501));
                }
            }
        }

        private void btnPrime_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(@"..\..\primes.txt", false, enc))
            {
                using (StreamReader sr = new StreamReader(@"..\..\random.txt", enc))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        int number = int.Parse(s);
                        if (IsPrime(number))
                        {
                            sw.WriteLine(number);
                        }
                    }
                }
            }
        }

        private bool IsPrime(int number)
        {
            if (number == 1) return false;
            double sq = Math.Sqrt(number);
            for (int i = 2; i <= sq; i++)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(@"..\..\random.txt", enc))
            {
                int maxi = int.MinValue;
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    int number = int.Parse(s);
                    if (number > maxi)
                    {
                        maxi = number;
                    }
                }

                lblResult.Text = maxi.ToString();
            }
        }

        private void btnCountMin_Click(object sender, EventArgs e)
        {
            int mini = int.MaxValue;
            int counter = 0;
            using (StreamReader sr = new StreamReader(@"..\..\random.txt", enc))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    int number = int.Parse(s);
                    if(number == mini)
                    {
                        counter++;
                    }
                    else if (number < mini)
                    {
                        mini = number;
                        counter = 1;
                    }
                }
            }

            lblResult.Text = counter.ToString();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int sum = 0;
            using (StreamReader sr = new StreamReader(@"..\..\random.txt", enc))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    int number = int.Parse(s);
                    sum += number;
                }
            }

            lblResult.Text = sum.ToString();
        }


        private void ddd()
        {
            int sum = 0, count = 0;
            using (StreamReader sr = new StreamReader(@"..\..\random.txt", enc))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    int number = int.Parse(s);
                    count++;
                    sum += number;
                }
            }

            double avg = (double)sum / count;
        }
    }
}
