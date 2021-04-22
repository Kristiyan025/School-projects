using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Binary_Game
{
    public partial class CloseForm : Form
    {
        private bool isEN;

        public CloseForm(bool isEN)
        {
            this.isEN = isEN;
            InitializeComponent();
        }

        private void CloseForm_Load(object sender, EventArgs e)
        {
            lblMsg.Location = new Point(this.Width / 2 - lblMsg.Width / 2, lblMsg.Location.Y);
            if (isEN)
            {
                btnYes.Text = "Yes";
                btnNo.Text = "No";
                lblMsg.Text = "Are you sure you want to quit?";
            }
            else
            {
                btnYes.Text = "Да";
                btnNo.Text = "Не";
                lblMsg.Text = "Сигурни ли сте, че искате да напуснете играта?";
            }
        }
    }
}
