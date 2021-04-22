namespace Binary_Game.Tasks
{
    public interface ITask
    {
        public string Operation { get; set; }

        public int[] Answer { get; set; }

        public int AnswerLength { get; set; }

        public int AnswerNumberBase { get; set; }

        public string Message { get; set; }

        public int Points { get; set; }

        public bool isAdding { get; set; }

        public bool Check(int[] bits);

        public void ChangeMessage(bool isEN);
    }
}
