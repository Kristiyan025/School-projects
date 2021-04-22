namespace Binary_Game.Tasks
{
    using System;

    public class AddingTask : ITask
    {
        public AddingTask(string number1, string number2, int answerLength, int numberBase, int points)
        {
            Initialize(answerLength, numberBase, points);
            int[] bits1 = new int[answerLength];
            int[] bits2 = new int[answerLength];
            ulong num1 = ulong.Parse(number1);
            ulong num2 = ulong.Parse(number2);
            int counter = answerLength - 1;
            while(num1 > 0)
            {
                bits1[counter] = (int)(num1 % Convert.ToUInt64(numberBase));
                num1 /= Convert.ToUInt64(numberBase);
                counter--;
            }
            counter = answerLength - 1;
            while (num2 > 0)
            {
                bits2[counter] = (int)(num2 % Convert.ToUInt64(numberBase));
                num2 /= Convert.ToUInt64(numberBase);
                counter--;
            }

            number1 = string.Join("", bits1);
            number2 = string.Join("", bits2);
            this.Message = $"You have to add up the numbers in number {numberBase} base!";
            this.Numbers = number1 + " " + number2;
            int power = 1;
            ulong answer = 0;
            for (int i = number1.Length - 1; i >= 0; i--)
            {
                answer += (ulong)(Convert.ToInt32(number1[i] - '0' + number2[i] - '0') * power);
                power *= numberBase;
            }

            for (int i = answerLength - 1; i >= 0; i--)
            {
                this.Answer[i] = (int)(answer % (ulong)numberBase);
                answer /= (ulong)numberBase;
            }
        }

        public string Operation { get; set; }

        public int[] Answer { get; set; }

        public int AnswerLength { get; set; }

        public int AnswerNumberBase { get; set; }

        public string Message { get; set; }

        public string Numbers { get; set; }

        public int Points { get; set; }

        public bool isAdding { get; set; } = true;

        public void Initialize(int answerLength, int toBase, int points)
        {
            this.Points = points;
            this.AnswerLength = answerLength;
            this.Answer = new int[answerLength];
            this.AnswerNumberBase = toBase;
        }

        public bool Check(int[] bits)
        {
            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i] != this.Answer[i]) return false;
            }

            return true;
        }

        public void ChangeMessage(bool isEN)
        {
            if (isEN) this.Message = $"You have to add up the numbers in number {this.AnswerNumberBase} base!";
            else this.Message = $"Трябва да съберете числата в {this.AnswerNumberBase}-ичната бройна ситема!";
        } 
    }
}
