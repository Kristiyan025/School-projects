namespace Binary_Game
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using Tasks;

    public partial class Game : Form
    {
        private const int count = 10;
        
        //Button variables
        private Button[] bits;
        private int sideOffset;
        private int betweenOffset = 20;
        private int startLocation;
        private Size btnSize = new Size(50, 60);
        private Font btnFont = new Font("Hobo Std", 24F, FontStyle.Regular, GraphicsUnit.Point);
        
        //Label variables
        private Label[] powers;
        private Font lblFont = new Font("Hobo Std", 12F, FontStyle.Regular, GraphicsUnit.Point);
        private Size lblSize = new Size(50, 20);
        private int verticalOffset = 10;

        //Timer
        private int seconds = 0;
        private int minutes = 0;

        //Base Changer
        private Dictionary<int, char> symbols = new Dictionary<int, char>();
        private Dictionary<char, int> numbers = new Dictionary<char, int>();

        //Level stuff
        private int level = 0;
        private int points = 0;
        private int maxPoints = 0;
        private int mistakes = 0;

        private string nickname;
        private bool isEN;

        public Game(string nickname, bool isEN)
        {
            this.nickname = nickname;
            this.isEN = isEN;
            InitializeComponent();
            for(int i = 0; i < 10; i++)
            {
                char c = (char)(i + '0');
                symbols[i] = c;
                numbers[c] = i;
            }
            for (int i = 10; i <= 10 + 'Z' - 'A'; i++)
            {
                char c = (char)(i - (int)('A'));
                symbols[i] = c;
                numbers[c] = i;
            }

            lblMessage.Location = new Point(this.Width / 2 - lblMessage.Width / 2, lblMessage.Location.Y);
            Tasks.Tasks.tasks[level].ChangeMessage(isEN);
            lblMessage.Text = Tasks.Tasks.tasks[level].Message;

            sideOffset = (this.Width - count * btnSize.Width - (count - 1) * betweenOffset) / 2;
            startLocation = this.Width - sideOffset - btnSize.Width;
            gBoxBar.BackColor = Color.FromArgb(30, 30, 30);
            bits = new Button[count];
            powers = new Label[count];
            int power = 1;
            for(int i = 0; i < count; i++)
            {
                //Button
                bits[i] = new Button();
                bits[i].BackColor = Color.FromArgb(30, 30, 30);
                bits[i].Font = btnFont;
                bits[i].ForeColor = Color.WhiteSmoke;
                bits[i].Location = new Point(startLocation - i * (btnSize.Width + betweenOffset), 273);
                bits[i].Name = $"btnPos{i}";
                bits[i].Size = btnSize;
                bits[i].Text = "0";
                bits[i].TabIndex = i;
                bits[i].UseVisualStyleBackColor = false;
                bits[i].Click += new EventHandler(this.Bits_Click);
                this.Controls.Add(bits[i]);

                //Label
                powers[i] = new Label();
                powers[i].BackColor = Color.FromArgb(0, 0, 0, 0);
                powers[i].ForeColor = SystemColors.ControlLight;
                powers[i].Font = lblFont;
                powers[i].TabIndex = power;
                powers[i].Text = power.ToString();
                powers[i].TextAlign = ContentAlignment.MiddleCenter;
                powers[i].Size = lblSize;
                powers[i].Padding = new Padding(0);
                powers[i].Location = new Point(bits[i].Location.X + bits[i].Width / 2 - lblSize.Width / 2,
                                               bits[i].Location.Y - lblSize.Height - verticalOffset);
                this.Controls.Add(powers[i]);

                power *= Tasks.Tasks.tasks[level].AnswerNumberBase;
            }

            timer.Start();
        }

        private void Rename()
        {
            if (!this.isEN)
            {
                lblTimeLabel.Text = "Време:";
                lblScoreLabel.Text = "Резултат:";
                lblLevelLabel.Text = "Ниво:";
                lblMistakesLabel.Text = "Грешки:";
                lblNumsLabel.Text = "Числа:";
                lblClose.Text = "Затвори";
                btnCheck.Text = "Провери";
            }
            else
            {
                lblTimeLabel.Text = "Time:";
                lblScoreLabel.Text = "Score:";
                lblLevelLabel.Text = "Level:";
                lblMistakesLabel.Text = "Mistakes:";
                lblNumsLabel.Text = "Numbers:";
                lblClose.Text = "Close";
                btnCheck.Text = "Check";
            }
        }

        private void Game_Load(object sender, EventArgs e)
        {
            lblNumsLabel.Visible = Tasks.Tasks.tasks[level].isAdding;
            lblNums.Visible = Tasks.Tasks.tasks[level].isAdding;
            if (lblNums.Visible) lblNums.Text = ((AddingTask)Tasks.Tasks.tasks[level]).Numbers;
            this.Rename();
        }

        private void Clean()
        {
            for(int i = 0; i < count; i++)
            {
                bits[i].Text = "0";
                bits[i].BackColor = Color.FromArgb(30, 30, 30);
            }
        }

        private void Bits_Click(object sender, EventArgs e)
        {
            Button bit = sender as Button;
            bit.Text = $"{symbols[(numbers[bit.Text[0]] + 1) % Tasks.Tasks.tasks[level].AnswerNumberBase]}";
            bit.BackColor = Color.FromArgb(Tasks.Tasks.r.Next(0, 1 << 8), Tasks.Tasks.r.Next(0, 1 << 8), Tasks.Tasks.r.Next(0, 1 << 8));
        }
        
        private void ScaleOnMouseHover(object sender, EventArgs e)
        {
            
            if (sender is Label) lblClose.Font = new Font(lblClose.Font.FontFamily, 20F, lblClose.Font.Style | FontStyle.Bold);
            else btnCheck.Font = new Font(lblClose.Font.FontFamily, 20F, lblClose.Font.Style | FontStyle.Bold);
        }

        private void ShrinkOnMouseLeave(object sender, EventArgs e)
        {
            if (sender is Label) lblClose.Font = new Font(lblClose.Font.FontFamily, 18F, lblClose.Font.Style | FontStyle.Regular);
            else btnCheck.Font = new Font(lblClose.Font.FontFamily, 18F, lblClose.Font.Style | FontStyle.Regular);
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Dispose();
            this.Dispose();
            Winner winner = new Winner(this.nickname, this.points, this.mistakes, $"{minutes:00}:{seconds:00}", level, this.isEN);
            DialogResult dr = winner.ShowDialog();
            if (dr == DialogResult.OK)
            {
                winner.Dispose();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if(this.seconds++ >= 60)
            {
                this.seconds = 0;
                this.minutes++;
            }

            lblTime.Text = $"{minutes:00}:{seconds:00}";
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if(Tasks.Tasks.tasks[level].Check(this.bits.Reverse().Select(x => numbers[x.Text[0]]).ToArray()))
            {
                this.points += Tasks.Tasks.tasks[level].Points;
            }
            else
            {
                this.mistakes++;
                lblMistakes.Text = this.mistakes.ToString();
            }

            this.maxPoints += Tasks.Tasks.tasks[level].Points;
            lblScore.Text = $"{this.points}/{this.maxPoints}";
            level++;
            if(level == Tasks.Tasks.tasks.Length)
            {
                lblClose_Click(lblClose, new EventArgs());
            }
            lblLevel.Text = (level + 1).ToString();
            Clean();
            lblMessage.Text = Tasks.Tasks.tasks[level].Message;
            lblNumsLabel.Visible = Tasks.Tasks.tasks[level].isAdding;
            lblNums.Visible = Tasks.Tasks.tasks[level].isAdding;
            if(lblNums.Visible) lblNums.Text = ((AddingTask)Tasks.Tasks.tasks[level]).Numbers;
        }
    }
}
