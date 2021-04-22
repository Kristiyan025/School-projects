namespace Binary_Game
{
    using System.Windows.Forms;
    using System.Drawing;

    public class Record : Label
    {
        public const int width = 600;
        public const int height = 32;
        private static Size s = new Size(width, height);
        public static Point pt;
        private static Font f = new Font(FontFamily.GenericMonospace, 13F, FontStyle.Bold, GraphicsUnit.Point);

        private Record(string text, bool isCurrentPlayer = false)
        {
            this.Size = s;
            this.Text = text;
            this.ForeColor = isCurrentPlayer ? Color.Lime : Color.White;
            this.BackColor = Color.Transparent;
            this.Font = f;
            this.TabIndex = 1;
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.Visible = true;
        }

        public Record(string text, int row, bool isCurrentPlayer = false)
            :this(text,isCurrentPlayer)
        {
            this.Location = new Point(pt.X, pt.Y + row * height);
        }

        public Record(string text, int offset)
            :this(text)
        {
            this.Location = new Point(pt.X, pt.Y + offset);
            this.Size = new Size(width, 2);
            this.BackColor = Color.White;
            this.TabIndex = 2;
        }
    }
}
