using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diagramm
{
    public partial class fNotes : Form
    {
        private Label[] bars, lbls, counters;
        private Color[] colors;
        private Encoding enc = Encoding.GetEncoding("windows-1251");
        public fNotes()
        {
            InitializeComponent();
        }

        private void fNotes_Load(object sender, EventArgs e)
        {
            //Center Note Labels
            Label[] noteTitles = new Label[] { lbl22, lbl33, lbl44, lbl55, lbl66 };
            lbls = new Label[] { lbl222, lbl333, lbl444, lbl555, lbl666 };
            colors = new Color[]
            {
                Color.Red,
                Color.Orchid,
                Color.MediumAquamarine,
                Color.Gold,
                Color.YellowGreen
            };
            counters = new Label[] { lbl2, lbl3, lbl4, lbl5, lbl6 };
            int chunk = (lblBg.Width) / (2 * noteTitles.Length);
            for(int i = 0; i < noteTitles.Length; i++)
            {
                noteTitles[i].Left = lblBg.Left + (2 * i + 1) * chunk - noteTitles[i].Width / 2;
                lbls[i].Left = lblBg.Left + (2 * i + 1) * chunk - lbls[i].Width / 2;
            }

            bars = new Label[noteTitles.Length];
            int width = lblBg.Width / bars.Length;
            for(int i = 0; i < bars.Length; i++)
            {
                bars[i] = new Label();
                bars[i].BackColor = colors[i];
                bars[i].Width = width;
                bars[i].Left = lblBg.Left + i * width + 1;
                bars[i].Visible = false;
                bars[i].TabIndex = 1;
                this.Controls.Add(bars[i]);
                bars[i].BringToFront();
            }

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            StreamWriter sw = new StreamWriter(@"..\..\files\notes.txt", false, enc);
            int count = r.Next(18, 64);
            for(int i = 0; i < count; i++)
            {
                sw.WriteLine(r.Next(2, 7));
            }
            sw.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"..\..\files\notes.txt", enc);
            string s;
            int[] notes = new int[colors.Length];
            int counter = 0;
            while((s = sr.ReadLine()) != null)
            {
                int note = int.Parse(s);
                notes[note - 2]++;
                counter++;
            }

            sr.Close();
            double coef = 3.0 * counter / (4 * notes.Max());
            int chunk = (lblBg.Width) / (2 * notes.Length);
            for (int i = 0; i < notes.Length; i++)
            {
                counters[i].Text = lbls[i].Text = notes[i].ToString();
                bars[i].Height = (int)(coef * (lblBg.Height * notes[i] / counter));
                bars[i].Top = lblBg.Bottom - bars[i].Height - 1;
                bars[i].Visible = lbls[i].Visible = true;
                lbls[i].Left = lblBg.Left + (2 * i + 1) * chunk - lbls[i].Width / 2;
                lbls[i].Top = bars[i].Top - lbls[i].Height - 10;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < bars.Length; i++)
            {
                bars[i].Visible = lbls[i].Visible = false;
                counters[i].Text = "-";
            }
        }
    }
}
