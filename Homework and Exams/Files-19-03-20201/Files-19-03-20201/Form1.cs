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

namespace Files_19_03_20201
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("random.txt", false, Encoding.GetEncoding("windos-1251"));
            Random r = new Random();
            for(int i = 0; i < 200; i++)
            {
                sw.WriteLine(r.Next());
            }

            sw.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("random.txt", Encoding.GetEncoding("windos-1251"));
            richTextBox1.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int proizvedenie = 1;
            StreamReader sr = new StreamReader("random.txt", Encoding.GetEncoding("windos-1251"));
            for(int i = 0; i < 200; i++)
            {
                int num = int.Parse(sr.ReadLine());
                if(num % 2 == 0)
                {
                    proizvedenie *= num;
                }
            }

            label1.Text = proizvedenie.ToString();
            sr.Close();
        }
    }
}
