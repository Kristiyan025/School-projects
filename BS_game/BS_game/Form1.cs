using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BS_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblNew_Click(object sender, EventArgs e)
        {
            Game g = new Game();
            g.Show();
            this.Hide();
        }

        private void lblNew_MouseHover(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            lbl.Font = new Font("Viner Hand ITC", 18);
        }

        private void lblNew_MouseLeave(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            lbl.Font = new Font("MV Boli", 16);
        }
    }
}
