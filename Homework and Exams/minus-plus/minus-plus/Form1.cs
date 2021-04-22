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

namespace minus_plus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("f.txt", false, Encoding.GetEncoding("windows-1251"));
            Random r = new Random();
            for(int i = 0; i < 100; i++)
            {
                sw.WriteLine(r.NextDouble());
            }
            sw.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("minus.txt", false, Encoding.GetEncoding("windows-1251"));
            StreamReader sr = new StreamReader("f.txt", Encoding.GetEncoding("windows-1251"));
            for (int i = 0; i < 100; i++)
            {
                int num = int.Parse(sr.ReadLine());
                if(num <= 0)
                {
                    sw.WriteLine(num);
                }
            }
            sw.Close();
            sr.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("plus.txt", false, Encoding.GetEncoding("windows-1251"));
            StreamReader sr = new StreamReader("f.txt", Encoding.GetEncoding("windows-1251"));
            for (int i = 0; i < 100; i++)
            {
                int num = int.Parse(sr.ReadLine());
                if (num > 0)
                {
                    sw.WriteLine(num);
                }
            }
            sw.Close();
            sr.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("f.txt", Encoding.GetEncoding("windows-1251"));
            richTextBox1.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("minus.txt", Encoding.GetEncoding("windows-1251"));
            richTextBox1.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("plus.txt", Encoding.GetEncoding("windows-1251"));
            richTextBox1.Text = sr.ReadToEnd();
            sr.Close();
        }
    }
}
