using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Birds_Santa_Edd
{
    public partial class GameForm : Form
    {
        Random r = new Random();
        int speed = 8; 
        int height; 
        int distance = 0;
        int minHoleHeight;
        int maxHoleHeight;
        int minPipeHeight;
        int maxPipeHeight;
        int reindeerSpeed = 0;
        int reindeerAcceleration = 1;
        public Form1 goBack;


        public GameForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            height = Height - pbGround.Height;
            minHoleHeight = pbReindeer.Height + 5;
            maxHoleHeight = 2 * height / 5;
            minPipeHeight = 30;
            maxPipeHeight = height - (minPipeHeight + maxHoleHeight);

            NewHole(pbBlueUp, pbBlueDown);
            NewHole(pbRedUp, pbRedDown);

            lblGameOver.BackColor = Color.FromArgb(128, 0, 0, 0);
            lblEndDistance.BackColor = Color.FromArgb(128, 0, 0, 0);
            lblEndDistance.Location = new Point((Width - lblEndDistance.Width) / 2, lblEndDistance.Location.Y);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            IncreaseDistance();
            MoveGround();
            MovePipes();
            MoveReindeer();
            if (!NeSeEUdaril()) 
            {
                timer1.Enabled = false; //stop ticking
                lblEndDistance.Text = "You successfully passed " + distance / 20 + " meters!";
                lblGameOver.Visible = true;
                lblEndDistance.Visible = true;
            }
        }

        void IncreaseDistance()
        {
            distance += speed;
            lblDistance.Text = "Distance: " + distance / 20;
        }

        void MoveGround()
        {
            pbGround.Left -= speed;
            if (pbGround.Left < -Width) 
            {
                pbGround.Left = 0;
            }
        }

        void MovePipes()
        {
            //Blue Up & Down
            pbBlueDown.Left -= speed;
            pbBlueUp.Left -= speed;
            if (pbBlueDown.Right < 0)
            {
                pbBlueDown.Left = Width;
                pbBlueUp.Left = Width;

                NewHole(pbBlueUp, pbBlueDown);
            }

            //Red Up & Down
            pbRedDown.Left -= speed;
            pbRedUp.Left -= speed;
            if (pbRedDown.Right < 0)
            {
                pbRedDown.Left = Width;
                pbRedUp.Left = Width;

                NewHole(pbRedUp, pbRedDown);
            }
        }

        int CalculateNewHoleHeight()
        {
            if (distance < 600)
            {
                return maxHoleHeight;
            }
            else if (distance < 1200)
            {
                return maxHoleHeight - (maxHoleHeight - minHoleHeight) / 5;//
            }
            else if (distance < 1800)
            {
                return maxHoleHeight - 2 * (maxHoleHeight - minHoleHeight) / 5;
            }
            else if (distance < 2400)
            {
                return maxHoleHeight - 3 * (maxHoleHeight - minHoleHeight) / 5;
            }
            else if (distance < 3000)
            {
                return maxHoleHeight - 4 * (maxHoleHeight - minHoleHeight) / 5;
            }
            else
            {
                return minHoleHeight;
            }
        }

        void NewHole(PictureBox p1, PictureBox p2)
        { 
            p1.Height = r.Next(minPipeHeight, maxPipeHeight);
            int holeHeight = CalculateNewHoleHeight();
            p2.Top = p1.Height + holeHeight;
            p2.Height = height - p2.Top;
        }

        bool NeSeEUdaril()
        {
            if (pbReindeer.Bottom >= pbGround.Top)
            {
                return false; 
            }

            if ((pbReindeer.Right < pbBlueUp.Left &&
                pbReindeer.Right < pbRedUp.Left) || 
               (pbReindeer.Left > pbBlueUp.Right &&
               pbReindeer.Right < pbRedUp.Right) || 
               (pbReindeer.Left > pbRedUp.Right &&
               pbReindeer.Right < pbBlueUp.Right) || 
               (pbReindeer.Left > pbBlueUp.Right &&
               pbReindeer.Left > pbRedUp.Right)) 
            {
                return true;
            }
            if (Math.Abs(pbReindeer.Left - pbBlueUp.Left) <
                    Math.Abs(pbReindeer.Left - pbRedUp.Left) &&
                    pbReindeer.Top > pbBlueUp.Bottom &&
                    pbReindeer.Bottom < pbBlueDown.Top)
            {
                return true;
            }
            else if (Math.Abs(pbReindeer.Left - pbRedUp.Left) <
                    Math.Abs(pbReindeer.Left - pbBlueUp.Left) &&
                    pbReindeer.Top > pbRedUp.Bottom &&
                    pbReindeer.Bottom < pbRedDown.Top)
            {
                return true;
            }

            return false;
        }

        void MoveReindeer()
        { 
            pbReindeer.Top += reindeerSpeed; 
            reindeerSpeed += reindeerAcceleration; 
        }
        
        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            reindeerSpeed -= 15; 
        }

        private void btnClose_MouseClick(object sender, MouseEventArgs e)
        {
            goBack.Show();
            Close();
        }
    }
}