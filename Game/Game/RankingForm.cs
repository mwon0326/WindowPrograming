using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class RankingForm : Form
    {
        GameImage ranking;
        GameImage back, background;
        GameImage s_back;
        int bgOffset = 0, bgSpeed = 100;
        DateTime previousTime;

        public RankingForm()
        {
            InitializeComponent();
        }

        private void RankingForm_Paint(object sender, PaintEventArgs e)
        {
            int wid = (this.ClientSize.Width - ranking.ResizeBitmap.Width) / 2;

            for (int x = bgOffset; x < 400; x += 200)
                e.Graphics.DrawImage(background.ResizeBitmap, x, 0, 200, 500);

            e.Graphics.DrawImage(ranking.ResizeBitmap, wid, 20);
        }

        private void backButton_MouseEnter(object sender, EventArgs e)
        {
            backButton.BackgroundImage = s_back.ResizeBitmap;
        }

        private void backButton_MouseLeave(object sender, EventArgs e)
        {
            backButton.BackgroundImage = back.ResizeBitmap;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            var now = DateTime.Now;
            var elapsed = now - previousTime;
            previousTime = now;
            var msec = (int)elapsed.TotalMilliseconds;

            bgOffset -= bgSpeed * msec / 1000;
            if (bgOffset < -200)
                bgOffset += 200;

            Invalidate();
        }

        private void RankingForm_Load(object sender, EventArgs e)
        {
            int rank;
            int[] array;
            this.ClientSize = new Size(400, 500);
            scoreLabel.Left = 100;
            scoreLabel.Top = 50;

            ranking = new GameImage(Game.Properties.Resources.ranking, 200, 50);

            backButton.Left = (this.ClientSize.Width - backButton.Width) / 2;
            backButton.Top = 400;

            background = new GameImage(Game.Properties.Resources.multi_back, 200, 500);

            back = new GameImage(Game.Properties.Resources.backB, 200, 50);
            s_back = new GameImage(Game.Properties.Resources.s_backB, 200, 50);

            backButton.BackgroundImage = back.ResizeBitmap;

            System.IO.FileInfo fl = new FileInfo(Application.StartupPath + @"\ranking.txt");
            if (!fl.Exists)
                scoreLabel.Text = "NO DATA";
            else
            {
                string path = Application.StartupPath + @"\ranking.txt";
                string[] lines = File.ReadAllLines(path);
                array = new int[lines.Length];

                for (int i = 0; i < lines.Length; i++)
                {
                    array[i] = Convert.ToInt32(lines[i]);
                }

                int score = array[0];

                if (lines.Length == 0)
                    scoreLabel.Text = "NO DATA";
                else if (lines.Length == 1)
                    scoreLabel.Text = "1. " + lines[0];
                else if (lines.Length > 1 && lines.Length < 11)
                {
                    for(int i = 0; i < lines.Length; i++)
                    {
                        score = array[i];
                        for (int j = i + 1; j < lines.Length; j++)
                        {
                            if (score < array[j])
                            {
                                score = array[j];
                                array[j] = array[i];
                                array[i] = score;
                            }
                        }
                    }
                    for(int i = 0; i < lines.Length; i++)
                    {
                        rank = i + 1;
                        scoreLabel.Text = scoreLabel.Text + "\n" + rank + ". " + array[i];
                    }
                }
                else
                {
                    for(int i = 0; i < lines.Length; i++)
                    {
                        score = array[i];
                        for (int j = i + 1; j < lines.Length; j++)
                        {
                            if (score < array[j])
                            {
                                score = array[j];
                                array[j] = array[i];
                                array[i] = score;
                            }
                        }
                    }
                    for (int i = 0; i < 10; i++)
                    {
                        rank = i + 1;
                        scoreLabel.Text = scoreLabel.Text + "\n" + rank + ". " + array[i];
                    }
                }
            }
        }
    }
}
