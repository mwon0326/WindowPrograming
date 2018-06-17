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
            PrivateFontCollection ft = new PrivateFontCollection();
            ft.AddFontFile("./Resources/KAMIKZOM.ttf");

            int rank, rankN;
            int[] array;
            int[] nArray;
            this.ClientSize = new Size(400, 500);
            easyScoreLabel.Left = 50;
            easyScoreLabel.Top = 120;
            normalScoreLabel.Left = 220;
            normalScoreLabel.Top = 120;

            easyLabel.Left = 50;
            easyLabel.Top = 70;
            easyLabel.Font = new Font(ft.Families[0], 24f);
            easyScoreLabel.Font = new Font(ft.Families[0], 24f);
            normalLabel.Left = 220;
            normalLabel.Top = 70;
            normalLabel.Font = new Font(ft.Families[0], 24f);
            normalScoreLabel.Font = new Font(ft.Families[0], 24f);
            ranking = new GameImage(Game.Properties.Resources.ranking, 200, 50);

            backButton.Left = (this.ClientSize.Width - backButton.Width) / 2;
            backButton.Top = 400;

            background = new GameImage(Game.Properties.Resources.multi_back, 200, 500);

            back = new GameImage(Game.Properties.Resources.backB, 200, 50);
            s_back = new GameImage(Game.Properties.Resources.s_backB, 200, 50);

            backButton.BackgroundImage = back.ResizeBitmap;

            System.IO.FileInfo fl = new FileInfo(Application.StartupPath + @"\ranking.txt");
            System.IO.FileInfo nfl = new FileInfo(Application.StartupPath + @"\ranking1.txt");

            if (!fl.Exists)
                easyScoreLabel.Text = "NO DATA";
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
                    easyScoreLabel.Text = "NO DATA";
                else if (lines.Length == 1)
                    easyScoreLabel.Text = "1. " + lines[0];
                else if (lines.Length > 1 && lines.Length < 11)
                {
                    for (int i = 0; i < lines.Length; i++)
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
                    for (int i = 0; i < lines.Length; i++)
                    {
                        rank = i + 1;
                        if (i == 0)
                            easyScoreLabel.Text = rank + ". " + array[i];
                        else
                            easyScoreLabel.Text = easyScoreLabel.Text + "\n" + rank + ". " + array[i];
                    }
                }
                else
                {
                    for (int i = 0; i < lines.Length; i++)
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
                        easyScoreLabel.Text = easyScoreLabel.Text + "\n" + rank + ". " + array[i];
                    }
                }
            }
            if (!nfl.Exists)
                normalScoreLabel.Text = "NO DATA";
            else
            {
                string npath = Application.StartupPath + @"\ranking1.txt";
                string[] linesN = File.ReadAllLines(npath);

                nArray = new int[linesN.Length];

                for (int i = 0; i < linesN.Length; i++)
                {
                    nArray[i] = Convert.ToInt32(linesN[i]);
                }

                int nscore = nArray[0];

                if (linesN.Length == 0)
                    normalScoreLabel.Text = "NO DATA";
                else if (linesN.Length == 1)
                    normalScoreLabel.Text = "1. " + linesN[0];
                else if (linesN.Length > 1 && linesN.Length < 11)
                {
                    for (int i = 0; i < linesN.Length; i++)
                    {
                        nscore = nArray[i];
                        for (int j = i + 1; j < linesN.Length; j++)
                        {
                            if (nscore < nArray[j])
                            {
                                nscore = nArray[j];
                                nArray[j] = nArray[i];
                                nArray[i] = nscore;
                            }
                        }
                    }
                    for (int i = 0; i < linesN.Length; i++)
                    {
                        rankN = i + 1;
                        normalScoreLabel.Text = normalScoreLabel.Text + "\n" + rankN + ". " + nArray[i];
                    }
                }
                else
                {
                    for (int i = 0; i < linesN.Length; i++)
                    {
                        nscore = nArray[i];
                        for (int j = i + 1; j < linesN.Length; j++)
                        {
                            if (nscore < nArray[j])
                            {
                                nscore = nArray[j];
                                nArray[j] = nArray[i];
                                nArray[i] = nscore;
                            }
                        }
                    }
                    for (int i = 0; i < 10; i++)
                    {
                        rankN = i + 1;
                        normalScoreLabel.Text = normalScoreLabel.Text + "\n" + rankN + ". " + nArray[i];
                    }
                }
            }
        }
    }
}
