namespace Binary_Game
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;
    using System.Drawing;

    public partial class Winner : Form
    {
        private List<UserScore> db = new List<UserScore>();
        private UserScore currentScore;
        private bool isEN;
        private const string path = "database.txt";

        public Winner(string nickname, int score, int mistakes, string time, int reachedLevel, bool isEN)
        {
            this.currentScore = new UserScore(nickname, score, mistakes, time, reachedLevel);
            this.isEN = isEN;
            InitializeComponent();
        }

        private void Winner_Load(object sender, EventArgs e)
        {
            if (isEN) btnTryAggain.Text = "Try Again";
            else btnTryAggain.Text = "Опитай пак";
            Record.pt = new Point((this.Width - Record.width) / 2, 75);
            string[] lines = File.ReadAllLines(path);
            foreach(string line in lines)
            {
                var parts = line.Split(';').ToArray();
                string nickname = parts[0];
                int score = int.Parse(parts[1]);
                int mistakes = int.Parse(parts[2]);
                string time = parts[3];
                int reachedLevel = int.Parse(parts[4]);
                UserScore userScore = new UserScore(nickname, score, mistakes, time, reachedLevel);

                this.db.Add(userScore);
            }

            this.db.Add(this.currentScore);
            this.db = this.db
                .OrderByDescending(x => x.Score)
                .ThenBy(x => x.Mistakes)
                .ThenByDescending(x => x.Time)
                .ThenBy(x => x.Nickname)
                .ToList();
            int id = this.db.IndexOf(this.currentScore);
            lblMessage.Location = new Point(this.Width / 2 - lblMessage.Width / 2, lblMessage.Location.Y);
            lblMessage.Text = isEN ? $"Congratulations, {currentScore.Nickname}! You've just classified on {id + 1}. place!" :
                                     $"Поздравления, {currentScore.Nickname}! Класирахте се на {id + 1}. място!";
            string headRowText = isEN ? @"Place|      NickName      |Score|Errors|Time |Level" : //Nickname could be at most 20
                                        @"Място|       Прякор       |Точки|Грешки|Време|Ниво ";
            Record headRow = new Record(headRowText, 0, false);
            this.Controls.Add(headRow);
            headRow = new Record("", Record.height);
            this.Controls.Add(headRow);
            int count = 0;
            for(int i = 0; i < Math.Min(3, this.db.Count); i++)
            {
                DrawRecord(i, id, ++count);
            }

            if (id - 1 > 3)
            {
                this.Controls.Add(new Record(". . .", ++count, false));
            }

            bool isEnd = false;
            for(int i = Math.Max(id - 1, 3); i < Math.Min(id + 2,this.db.Count); i++)
            {
                DrawRecord(i, id, ++count);
                if (i == this.db.Count - 1) isEnd = true;
            }

            if(!isEnd) this.Controls.Add(new Record(". . .", ++count, false));
        }

        private void DrawRecord(int i, int id, int row)
        {
            int place = i + 1;
            int len = this.db[i].Nickname.Length;
            int off = 20 - len;
            int fore = (int)Math.Floor(off * 0.5);
            int back = (int)Math.Ceiling(off * 0.5);
            string text = $"{$"{place}.",-5}|{new string(' ', fore)}{this.db[i].Nickname}{new string(' ', back)}|{this.db[i].Score,5}|{this.db[i].Mistakes,6}|{this.db[i].Time}|{this.db[i].ReachedLevel,5}";
            this.Controls.Add(new Record(text, row, i == id));
        }

        private void btnTryAggain_Click(object sender, EventArgs e)
        {
            using(StreamWriter sw = new StreamWriter(path, false))
            {
                foreach(UserScore us in this.db)
                {
                    sw.WriteLine($"{us.Nickname};{us.Score};{us.Mistakes};{us.Time};{us.ReachedLevel}");
                }
            }
        }
    }
}
