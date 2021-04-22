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

namespace WindowsFormsApp1
{
    public partial class Files : Form
    {
        private Encoding enc = Encoding.GetEncoding("windows-1251");

        public Files()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            string filepath = $"../../{txtName.Text}.txt";
            using (StreamWriter sw = new StreamWriter(filepath, false, enc))
            {
                sw.WriteLine(rtxtFiles.Text);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string filepath = $"../../{txtName.Text}.txt";
            using (StreamReader sr = new StreamReader(filepath, enc))
            {
                rtxtFiles.Text = sr.ReadToEnd();
            }
        }

        private void btnShowResult_Click(object sender, EventArgs e)
        {
            string filepath = $"../../{txtName.Text}.txt";
            using (StreamReader sr = new StreamReader(filepath, enc))
            {
                int best = -1;
                StringBuilder sb = new StringBuilder();
                string content = sr.ReadToEnd();
                for(int i = 0; i < content.Length; i++)
                {
                    if(content[i] == '\n' && i != content.Length - 1)
                    {
                        rtxtResult.Text += best.ToString() + "\n";
                        sb.Clear();
                        best = -1;
                    }
                    else
                    {
                        sb.Clear();
                        while (content[i] >= '0' && content[i] <= '9')
                        {
                            sb.Append(content[i++]);
                        }

                        if(sb.ToString().Length > 0)
                        {
                            //rtxtResult.Text += sb.ToString() + "\n";
                            int number = int.Parse(sb.ToString());
                            if(number % 2 == 0 && number > best)
                            {
                                best = number;
                            }
                        }
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = rtxtFiles.Text = rtxtResult.Text = "";
        }
    }
}
