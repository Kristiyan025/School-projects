using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cleaning_Company
{
    public partial class TitleForm : Form
    {
        public TitleForm()
        {
            InitializeComponent();
            InitializeImages();
        }

        private void InitializeImages()
        {
            this.BackgroundImage = Properties.Resources.main_background;
            pbLogo.Image = Properties.Resources.download;
            btnNew.BackgroundImage = Properties.Resources.pink_to_yellow;
            btnClose.BackgroundImage = Properties.Resources.pink_to_yellow;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm(this);
            mf.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
