namespace Binary_Game.Tasks
{
    using System;

    public class ChangeNumberBaseTask : ITask
    {
        private string number;
        private int fromBase;

        public ChangeNumberBaseTask(string number, int answerLength, int fromBase, int toBase, int points)
        {
            this.number = number.TrimStart(new char[] { '0' });
            this.fromBase = fromBase;
            this.Message = $"You have to calculate the form of the number {number.TrimStart('0')} (Number {fromBase} base) in number {toBase} base!";
            Initialize(answerLength, toBase, points);
            int power = 1;
            ulong answer = 0;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                answer += (ulong)(Convert.ToInt32(number[i] - '0') * power);
                power *= fromBase;
            }

            for (int i = answerLength - 1; i >= 0; i--)
            {
                this.Answer[i] = (int)(answer % (ulong)toBase);
                answer /= (ulong)toBase;
            }
        }

        public string Operation { get; set; }

        public int[] Answer { get; set; }

        public int AnswerLength { get; set; }

        public int AnswerNumberBase { get; set; }

        public string Message { get; set; }

        public int Points { get; set; }

        public bool isAdding { get; set; } = false;

        public void Initialize(int answerLength, int toBase, int points)
        {
            this.Points = points;
            this.AnswerLength = answerLength;
            this.Answer = new int[answerLength];
            this.AnswerNumberBase = toBase;
        }

        public bool Check(int[] bits)
        {
            for(int i = 0; i < bits.Length; i++)
            {
                if (bits[i] != this.Answer[i]) return false;
            }

            return true;
        }

        public void ChangeMessage(bool isEN)
        {
            if (isEN) this.Message = $"You have to calculate the form of the number {this.number.TrimStart('0')} (Number {this.fromBase} base) in number {this.AnswerNumberBase} base!";
            else this.Message = $"Превърнете числото {this.number.TrimStart('0')} от {this.fromBase}-ична бройна система в {this.AnswerNumberBase}-ична бройна система!";
        }
    }
}
