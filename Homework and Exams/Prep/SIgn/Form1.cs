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

namespace SIgn
{
    public partial class Form1 : Form
    {
        private Encoding enc = Encoding.GetEncoding("windows-1251");

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateRandomReal_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            StreamWriter sw = new StreamWriter("f.txt", false, enc);
            for(int i = 0; i < 100; i++)
            {
                sw.WriteLine(r.NextDouble() + r.Next(-500, 500));
            }

            sw.Close();
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            StreamWriter swP = new StreamWriter("plus.txt", false, enc);
            StreamWriter swM = new StreamWriter("minus.txt", false, enc);
            StreamReader sr = new StreamReader("f.txt", enc);
            string s;
            while((s = sr.ReadLine()) != null)
            {
                double number = double.Parse(s);
                if(number > 0)
                {
                    swP.WriteLine(number);
                }
                else
                {
                    swM.WriteLine(number);
                }
            }

            sr.Close();
            swP.Close();
            swM.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader($"{txtName.Text}.txt", enc);
            rtxtResult.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            rtxtResult.Text = "";
        }
    }
}
