namespace Binary_Game
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class Menu : Form
    {
        private const int pBoxLangOffset = 50;

        private string nickname = $"Player{Tasks.Tasks.r.Next(100000, 1000000)}";

        private bool isEN = false;

        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            //Allign The TextBox for the nickname to the center
            txtNickname.Location = new Point(this.Width / 2 + lblNickname.Width / 2 - txtNickname.Width / 2, txtNickname.Location.Y);
            lblNickname.Location = new Point(this.Width / 2 - lblNickname.Width / 2 - txtNickname.Width / 2, lblNickname.Location.Y);
            txtNickname.PlaceholderText = this.nickname;
            txtNickname.LostFocus += new EventHandler(AddText);

            //Allign Labels to the Center
            lblStart.Location = new Point(this.Width / 2 - lblStart.Width / 2, lblStart.Location.Y);
            lblHow.Location = new Point(this.Width / 2 - lblHow.Width / 2, lblHow.Location.Y);
            lblClose.Location = new Point(this.Width / 2 - lblClose.Width / 2, lblClose.Location.Y);

            //Allign Picture Boxes to be Equal Distance from the Center
            pBoxBg.Location = new Point(this.Width / 2 - pBoxBg.Width / 2 - pBoxLangOffset, pBoxBg.Location.Y);
            pBoxEn.Location = new Point(this.Width / 2 - pBoxEn.Width / 2 + pBoxLangOffset, pBoxEn.Location.Y);

            txtNickname.TabStop = false;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            CloseForm f = new CloseForm(this.isEN);
            DialogResult dr = f.ShowDialog();
            if(dr == DialogResult.Yes)
            {
                f.Dispose();
                this.Dispose();
            }
            else if(dr == DialogResult.No)
            {
                f.Dispose();
            }
        }

        private void Hover(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            l.ForeColor = Color.YellowGreen;
            l.Font = new Font("Gabriola", 32.75F, FontStyle.Regular, GraphicsUnit.Point);
        }

        private void Out(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            l.ForeColor = SystemColors.Info;
            l.Font = new Font("Gabriola", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
        }

        private void pBoxEn_Click(object sender, EventArgs e)
        {
            this.isEN = true;
            lblStart.Text = "New game";
            lblHow.Text = "How to play";
            lblClose.Text = "Close";
            lblNickname.Text = "Nickname:";
        }

        private void pBoxBg_Click(object sender, EventArgs e)
        {
            this.isEN = false;
            lblStart.Text = "Нова игра";
            lblHow.Text = "Как се играе";
            lblClose.Text = "Затвори";
            lblNickname.Text = "Прякор:";
        }

        private void lblStart_Click(object sender, EventArgs e)
        {
            Game game = new Game(this.nickname, this.isEN);
            game.ShowDialog();
            this.nickname = $"Player{Tasks.Tasks.r.Next(100000, 1000000)}";
            txtNickname.PlaceholderText = this.nickname;
        }

        private void AddText(object sender, EventArgs e)
        {
            if (!(txtNickname.Text.Trim() == "" || txtNickname.Text.Contains(';') || txtNickname.Text.Length > 20))
            {
                txtNickname.PlaceholderText = this.nickname = txtNickname.Text;
            }
            
            txtNickname.Text = "";
        }

        private void txtNicknameLoseFocus(object sender, MouseEventArgs e)
        {
            txtNickname.Enabled = false;
            txtNickname.Enabled = true;
        }

        private void lblHow_Click(object sender, EventArgs e)
        {
            HowToPlay f = new HowToPlay(isEN);
            DialogResult dr = f.ShowDialog();
            if(dr == DialogResult.OK)
            {
                f.Dispose();
            }
        }
    }
}
