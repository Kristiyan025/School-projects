namespace Binary_Game
{
    using System;
    using System.Windows.Forms;

    public partial class HowToPlay : Form
    {
        private bool isEN;

        public HowToPlay(bool isEN)
        {
            this.isEN = isEN;
            InitializeComponent();
        }

        private void HowToPlay_Load(object sender, EventArgs e)
        {
            if (isEN)
            {
                lblTittle.Text = "How To Play";
                btnGotIt.Text = "Ok, got it!";
                lblInfo.Text = "   -At the first type of level you are to construct the given number in decimal number base into binary or into higher number base.\n" +
                     "   -At the second type of level you are to add up two numbers in the same number base.";
            }
            else
            {
                lblTittle.Text = "Как се играе";
                btnGotIt.Text = "Ок, разбрах!";
                lblInfo.Text = "   -Първото ниво на трудност е да превърнете числото от десетична в двоична или по-висока бройна система.\n" +
                    "   -Второто ниво на трудност е да съберете две числа в еднаква бройна система.";
            }
        }
    }
}
