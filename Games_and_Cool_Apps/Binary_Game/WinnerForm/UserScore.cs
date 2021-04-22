namespace Binary_Game
{
    public class UserScore
    {
        public UserScore(string nickname, int score, int mistakes, string time, int reachedLevel)
        {
            this.Nickname = nickname;
            this.Score = score;
            this.Mistakes = mistakes;
            this.Time = time;
            this.ReachedLevel = reachedLevel;
        }

        public string Nickname { get; set; }

        public int Score { get; set; }

        public int Mistakes { get; set; }

        public string Time { get; set; }

        public int ReachedLevel { get; set; }
    }
}
