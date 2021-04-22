using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace plochki
{
    public partial class OrderForm : Form
    {
        private MenuForm menuForm;
        private int tile = 1;
        private double price;
        private double tileSize = 0.25; //plochkite sa tochen kvadrat
        private Random r = new Random();

        public OrderForm(MenuForm mf)
        {
            InitializeComponent();
            menuForm = mf;
            price = double.Parse(rbtnTile1.Tag.ToString());
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            menuForm.Show();
            this.Close();
        }

        private void rbtnTile1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnTile1.Checked == true)
            {
                pbTile.Image = Properties.Resources._01;
                tile = 1;
                lblTilePrice.Text = rbtnTile1.Tag.ToString() + "lv.";
                price = double.Parse(rbtnTile1.Tag.ToString());
            }
        }
        private void rbtnTile2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnTile2.Checked == true)
            {
                pbTile.Image = Properties.Resources._02;
                tile = 2;
                lblTilePrice.Text = rbtnTile2.Tag.ToString() + "lv.";
                price = double.Parse(rbtnTile2.Tag.ToString());
            }
        }
        private void rbtnTile3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnTile3.Checked == true)
            {
                pbTile.Image = Properties.Resources._03;
                tile = 3;
                lblTilePrice.Text = rbtnTile3.Tag.ToString() + "lv.";
                price = double.Parse(rbtnTile3.Tag.ToString());
            }
        }
        private void rbtnTile4_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnTile4.Checked == true)
            {
                pbTile.Image = Properties.Resources._04;
                tile = 4;
                lblTilePrice.Text = rbtnTile4.Tag.ToString() + "lv.";
                price = double.Parse(rbtnTile4.Tag.ToString());
            }
        }
        private void rbtnTile5_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnTile5.Checked == true)
            {
                pbTile.Image = Properties.Resources._05;
                tile = 5;
                lblTilePrice.Text = rbtnTile5.Tag.ToString() + "lv.";
                price = double.Parse(rbtnTile5.Tag.ToString());
            }
        }
        private void rbtnTile6_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnTile6.Checked == true)
            {
                pbTile.Image = Properties.Resources._06;
                tile = 6;
                lblTilePrice.Text = rbtnTile6.Tag.ToString() + "lv.";
                price = double.Parse(rbtnTile6.Tag.ToString());
            }
        }
        private void rbtnTile7_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnTile7.Checked == true)
            {
                pbTile.Image = Properties.Resources._07;
                tile = 7;
                lblTilePrice.Text = rbtnTile7.Tag.ToString() + "lv.";
                price = double.Parse(rbtnTile7.Tag.ToString());
            }
        }
        private void rbtnTile8_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnTile8.Checked == true)
            {
                pbTile.Image = Properties.Resources._08;
                tile = 8;
                lblTilePrice.Text = rbtnTile8.Tag.ToString() + "lv.";
                price = double.Parse(rbtnTile8.Tag.ToString());
            }
        }
        private void rbtnTile9_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnTile9.Checked == true)
            {
                pbTile.Image = Properties.Resources._09;
                tile = 9;
                lblTilePrice.Text = rbtnTile9.Tag.ToString() + "lv.";
                price = double.Parse(rbtnTile9.Tag.ToString());
            }
        }
        private void rbtnTile10_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnTile10.Checked == true)
            {
                pbTile.Image = Properties.Resources._10;
                tile = 10;
                lblTilePrice.Text = rbtnTile10.Tag.ToString() + "lv.";
                price = double.Parse(rbtnTile10.Tag.ToString());
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            double width = double.Parse(txtWidth.Text);
            double height = double.Parse(txtHeight.Text);
            double depth = double.Parse(txtDepth.Text);
            int floorAndCeiling = CalcTilesOnWall(width, depth);
            int wall1 = CalcTilesOnWall(width, height);
            int wall2 = CalcTilesOnWall(depth, height);
            int totalTiles = 2 * (floorAndCeiling + wall1 + wall2);
 
            MessageBox.Show($"OrderID: {r.Next(1000000, 10000000)}\n" +
                            $"You, {txtName.Text}, have ordered bathroom tiles for your home, whose address is {txtAddress.Text}!\n" +
                            $"For both the floor and the ceiling you're gonna need 2 x {floorAndCeiling} tiles = {2 * floorAndCeiling} tiles.\n" +
                            $"For the first pair of walls you're gonna need 2 x {wall1} tiles = {2 * wall1} tiles.\n" +
                            $"For the second pair of walls you're gonna need 2 x {wall2} tiles = {2 * wall2} tiles.\n" +
                            $"Total needed: {totalTiles} tiles.\n" +
                            $"The price of type \"Sample No{tile}\", that you have chosen, is {price:F2}lv. per tile.\n" +
                            $"Total price you need to pay: {price * totalTiles} lv.");
        }

        private int CalcTilesOnWall(double w, double h)
        {
            int horizontalCount = (int)Math.Ceiling(w / tileSize);
            int verticalCount = (int)Math.Ceiling(h / tileSize);
            return horizontalCount * verticalCount;
        }
    }
}
