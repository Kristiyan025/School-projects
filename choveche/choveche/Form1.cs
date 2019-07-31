using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace choveche
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int p = 1;
        int velocity = 5;
        bool dali = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += velocity;
            p++;
            if (p == 5) p = 1;
            switch(p)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.empqrf2mdyfa1mfjz5g3;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.epsqrf2mdyfa1egyf88u;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.exxqrf2mdyfa1f38ful2;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.e9vqrf2mdyfa1xz9hy5j;
                    break;
            }
            if(!dali)
            {
                if (pictureBox1.Left > this.Width) pictureBox1.Left = -pictureBox1.Width;
            }
            else
            {
                if (pictureBox1.Left < -pictureBox1.Width ) pictureBox1.Left = this.Width;
            }
            if (velocity == -5)
            {
                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            velocity = -5;
            dali = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            velocity = 5;
            dali = false;
        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
        }
    }
}
