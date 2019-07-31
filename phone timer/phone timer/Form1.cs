using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phone_timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int m = 0, s = 0, st = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            st++;
            if (st == 100)
            {
                st = 0;
                s++;
            }
            if (s == 60)
            {
                s = 0;
                m++;
            }
            lblSt.Text = st.ToString("00");
            lblS.Text = $"{s:D2}";
            lblM.Text = m.ToString("00");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnNull.Enabled = true;
            if (btnStart.Text == "Start")
            {
                timer1.Enabled = true;
                btnStart.Text = "Stop";
            }
            else
            {
                timer1.Enabled = false;
                btnStart.Text = "Start";
            }
        }

        private void btnNull_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            btnNull.Enabled = false;
            btnStart.Text = "Start";
            st = 0;
            s = 0;
            m = 0;
            lblSt.Text = st.ToString("00");
            lblS.Text = $"{s:D2}";
            lblM.Text = m.ToString("00");

        }
    }
}
