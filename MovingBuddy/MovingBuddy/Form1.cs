using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingBuddy
{
    public partial class Form1 : Form
    {
        private int fullPathLength;
        private int length;
        private int height;
        private int time = 0;
        private int step = 3;

        public Form1()
        {
            InitializeComponent();
            length = this.Width - man.Width;
            fullPathLength = 4 * length;
            height = this.Height - man.Height - 40;
        }

        private void walk_Tick(object sender, EventArgs e)
        {
            int position = time % fullPathLength;
            int part = position / length;
            switch(part)
            {
                case 0:
                    man.Left += step;
                    break;
                case 1:
                    man.Left -= step;
                    man.Location = new Point(man.Location.X, (int)(((double)(length - man.Location.X) / length) * height));
                    break;
                case 2:
                    man.Left += step;
                    break;
                case 3:
                    man.Left -= step;
                    man.Location = new Point(man.Location.X, height - (int)(((double)(length - man.Location.X) / length) * height));
                    break;
            }

            switch(time / 16 % 4)
            {
                case 0:
                    man.Image = MovingBuddy.Properties.Resources.frame1;
                    break;
                case 1:
                    man.Image = MovingBuddy.Properties.Resources.frame2;
                    break;
                case 2:
                    man.Image = MovingBuddy.Properties.Resources.frame3;
                    break;
                case 3:
                    man.Image = MovingBuddy.Properties.Resources.frame4;
                    break;
            }

            time += step;
        }
    }
}
