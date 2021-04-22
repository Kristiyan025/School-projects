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

namespace Files_and_Streams
{
    public partial class Form1 : Form
    {
        private const string prefix = @"../../";
        private Encoding encoding = Encoding.GetEncoding("windows-1251");
        private HashSet<int> happyNumbers = new HashSet<int> { 1, 7, 10, 13, 19, 23, 28, 31, 32, 44, 49, 68, 70, 79, 82, 86, 91, 94, 97, 100, 103, 109, 129, 130, 133, 139, 167, 176, 188, 190, 192, 193, 203, 208, 219, 226, 230, 236, 239, 262, 263, 280, 291, 293, 301, 302, 310, 313, 319, 320, 326, 329, 331, 338, 356, 362, 365, 367, 368, 376, 379, 383, 386, 391, 392, 397, 404, 409, 440, 446, 464, 469, 478, 487, 490, 496 };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(@prefix + "numbers.txt", false, encoding))
            {
                Random r = new Random();
                for(int i = 0; i < 100; i++)
                {
                    sw.WriteLine(r.Next(1, 501));
                }
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            string filePath = @prefix + txtName.Text; 
            using(StreamReader sr = new StreamReader(@filePath, encoding))
            {
                string line = "";
                while((line = sr.ReadLine()) != null)
                {
                    lblMsg.Text += line + '\n';
                }
            }
        }

        private void btnMake_Click(object sender, EventArgs e)
        {
            using (StreamWriter swh = new StreamWriter(@prefix + "happy.txt", false, encoding))
            {
                using (StreamWriter swp = new StreamWriter(@prefix + "prime.txt", false, encoding))
                {
                    using (StreamReader sr = new StreamReader(@prefix + "numbers.txt", encoding))
                    {
                        string line = "";
                        while ((line = sr.ReadLine()) != null)
                        {
                            int number = int.Parse(line);
                            if(isPrime(number))
                            {
                                swh.WriteLine(number);
                            }

                            if(isHappy(number))
                            {
                                swh.WriteLine(number);
                            }
                        }
                    }
                }
            }
        }

        private bool isPrime(int n)
        {
            if (n < 2) return false;
            for(int i = 2; i * i <= n; i++)
            {
                if (n % i == 0) return false;
            }

            return true;
        }

        private bool isHappy(int n)
        {
            return happyNumbers.Contains(n);
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            string filePath = @prefix + txtName.Text;
            using (StreamReader sr = new StreamReader(@filePath, encoding))
            {
                string line = "";
                int maxi = int.MinValue;
                while ((line = sr.ReadLine()) != null)
                {
                    int number = int.Parse(line);
                    maxi = maxi < number ? number : maxi;
                }

                lblMsg.Text = maxi.ToString();
            }
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            string filePath = @prefix + txtName.Text;
            int min = int.MaxValue, counter = 0;
            using (StreamReader sr = new StreamReader(@filePath, encoding))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    int number = int.Parse(line);
                    min = min > number ? number : min;
                }
            }
            string minimum = min.ToString();
            using (StreamReader sr = new StreamReader(@filePath, encoding))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    counter += line == minimum ? 1 : 0;
                }
            }

            lblMsg.Text = counter.ToString();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            string filePath = @prefix + txtName.Text;
            using (StreamReader sr = new StreamReader(@filePath, encoding))
            {
                string line = "";
                long sum = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    long number = long.Parse(line);
                    sum += number;
                }

                lblMsg.Text = sum.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblMsg.Text = txtName.Text = "";
        }
    }
}
