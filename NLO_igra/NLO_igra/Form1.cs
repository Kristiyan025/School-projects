using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace NLO_igra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int nloX = 5 , BoltY = -15;
        int numHits = 0;
        int missed = 0;
        bool laserIsAway = false;

        SoundPlayer shootSound = new SoundPlayer(Properties.Resources.LaserHit);
        SoundPlayer hitSound = new SoundPlayer(Properties.Resources.LaserHit);

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (laserIsAway) return;

            if(e.KeyCode == Keys.Space)
            {
                //iztrel
                laserIsAway = true;
                laser.Left = 216; laser.Top = 340;
                laser.Visible = true;

                shootSound.Play();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            nlo.Left += nloX;
            if (nlo.Left > ClientSize.Width) nlo.Left = -nlo.Width;
            if(laserIsAway)
            {
                laser.Top += BoltY;
                bool miss = ((laser.Left > nlo.Right) || (laser.Right < nlo.Left) ||
                    (laser.Top > nlo.Bottom) || (laser.Bottom < nlo.Top));
                if(!miss)
                {
                    hitSound.Play();
                    numHits++;
                    lblHits.Text = numHits.ToString();
                    nlo.Left = -nlo.Width;
                    laser.Visible = false;
                    laserIsAway = false;

                }
                else if (laser.Bottom < 0)
                {
                    laserIsAway = false;
                    missed++;
                    lblMissed.Text = missed.ToString();
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
