using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace Game
{
    public enum Status { CLOSE, OPEN, MATCH };

    public partial class SingleGameForm : Form
    {
        GameImage background;
        Bitmap backGround;
        GameImage back;
        GameImage pan;
        int[] game;
        Status[] status;
        PictureBox[] picture;
        bool pic_click = false;
        int openCount = 0, drawCount = 0;
        int timer = 0;
        int close1, close2;
        int levelTag, panWid= 0, pandHei = 0;
        int score = 0, bgSpeed = 100, bgOffset = 0;
        const int EASY_P = 100;
        const int MINUS = 10;
        const int NORMAL_P = 200;
        AnimationImage kirbyRun;
        AnimationImage kirbyStar;
        DateTime previousTime;
        int kirbyTag = 0;

        public SingleGameForm(int tag)
        {
            InitializeComponent();

            levelTag = tag;
            int level = 0, index = 0;

            if (levelTag == 1)
            {
                index = 26;
                level = 7;
            }
            else if (levelTag == 2)
            {
                index = 52;
                level = 9;
            }

            game = new int[index];
            status = new Status[index];
            picture = new PictureBox[index];

            for (int i = 0; i < game.Length; i++)
            {
                picture[i] = new PictureBox();
                picture[i].Width = 80;
                picture[i].Height = 100;
                picture[i].Left = ((i % level) * 5 + (i % level) * 80) + 10;
                picture[i].Top = ((i / level) * 5 + (i / level) * 100) + 10;
                picture[i].Click += picture_Click;
                picture[i].Name = i.ToString();
                gamePan.Controls.Add(picture[i]);
            }
            gamePan.Left = 15;
            gamePan.Top = 15;
            panWid = gamePan.Width + 10;
            pandHei = gamePan.Height + 10;
        }

        public void SingleEasyGameForm_Load(object sender, EventArgs e)
        {
            background = new GameImage(Game.Properties.Resources.single_background, 400, 700);
            backGround = background.ResizeBitmap;

            pan = new GameImage(Game.Properties.Resources.kurbi_pan, panWid, pandHei);

            this.ClientSize = new Size(1200, 700);
            StartGame();
            scoreLabel.Text = "Score :" + score;
            kirbyRun = new AnimationImage(Game.Properties.Resources.kurbi_run, 8, 20.0f, 600, 150);
            kirbyStar = new AnimationImage(Game.Properties.Resources.kurbi_star, 8, 8.0f, 600, 150);

            if (levelTag == 1)
            {
                kirbyRun.setPosition(600, 470);
                kirbyStar.setPosition(600, 470);
            }
            else if (levelTag == 2)
            {
                kirbyRun.setPosition(950, 470);
                kirbyStar.setPosition(950, 470);
            }

            scoreLabel.Left = 900;
            previousTime = DateTime.Now;
        }

        public void StartGame()
        {
            Random r = new Random();
            bool check = false;

            openCount = 0;
            timer = 0;
            if (gameTimer.Enabled == true)
                gameTimer.Stop();

            for (int i = 0; i < game.Length; i++, check = false)
            {
                int templ = r.Next(0, game.Length); //0부터 배열인덱스만큼의 숫자 랜덤 발생

                for (int j = 0; j < i; j++)
                {
                    if (game[j] == templ)
                    {
                        i--;
                        check = true;
                        break;
                    }
                }

                if (check)
                    continue;

                game[i] = templ;
                status[i] = Status.CLOSE;
                back = new GameImage(Game.Properties.Resources.back, 80, 100);
                picture[i].Image = back.ResizeBitmap;
            }
        }

        private void SingleGameForm_Paint(object sender, PaintEventArgs e)
        {
            for (int x = bgOffset; x < 1200; x += 400)
                e.Graphics.DrawImage(backGround, x, 0, 400, 700);

            e.Graphics.DrawImage(pan.ResizeBitmap, 10, 10);

            if (kirbyTag == 0)
                kirbyRun.draw(e.Graphics);
            else if (kirbyTag == 1)
            {
                kirbyStar.draw(e.Graphics);

                if (drawCount >= 16)
                {
                    kirbyTag = 0;
                    drawCount = 0;
                }
            }
        }

        private void imageTimer_Tick(object sender, EventArgs e)
        {
            /*var now = DateTime.Now;
            var elapsed = now - previousTime;
            previousTime = now;
            var msec = (int)elapsed.TotalMilliseconds;

            bgOffset -= bgSpeed * msec / 1000;
            if (bgOffset < -400)
                bgOffset += 400;

            if (kirbyTag == 0)
                kirbyRun.updateFrame(msec);
            else if (kirbyTag == 1)
                kirbyStar.updateFrame(msec);

            Invalidate();

            if (kirbyTag == 1)
                drawCount++;*/
        }

        public void picture_Click(object sender, EventArgs e)
        {
            if (pic_click)
                return;

            PictureBox picTemp = (PictureBox)sender;
            int num = int.Parse(picTemp.Name);
            int match = -1;

            if (status[num] == Status.CLOSE)
            {
                int value = game[num];
                int realV = value / 2;

                ImageChange(picTemp, realV);

                for (int i = 0; i < status.Length; i++)
                {
                    if (status[i] == Status.OPEN)
                    {
                        match = i;
                        break;
                    }
                }

                if (match != -1)
                {
                    if (game[match] / 2 == realV)
                    {
                        status[match] = Status.MATCH;
                        status[num] = Status.MATCH;
                        if (levelTag == 1)
                            score += EASY_P;
                        else if (levelTag == 2)
                            score += NORMAL_P;
                        kirbyTag = 1;
                    }
                    else
                    {
                        pic_click = true;

                        close1 = match;
                        close2 = num;

                        Thread th = new Thread(new ThreadStart(CloseThreading));
                        th.Start();
                        if (score != 0)
                            score -= MINUS;
                    }

                    openCount++;
                }
                else
                    status[num] = Status.OPEN;
            }

            scoreLabel.Text = "Score :" + score;
            SuccCheck();
        }

        public void SuccCheck()
        {
            foreach (Status statusC in status)
            {
                if (statusC != Status.MATCH)
                    return;
            }
            gameTimer.Stop();
            string path = "";

            if (levelTag == 1)
                path = Application.StartupPath + @"\ranking.txt";
            else if (levelTag == 2)
                path = Application.StartupPath + @"\ranking1.txt";

            System.IO.FileInfo fl = new FileInfo(path);
            if (!fl.Exists)
            {
                File.Create(path);
                StreamWriter sw = new StreamWriter(path);
                sw.WriteLine(score);
                sw.Close();
            }
            else
            {
                StreamWriter sw = new StreamWriter(path, true);
                sw.WriteLine(score);
                sw.Close();
            }
            WinForm win = new WinForm(levelTag, score, 1, 0);
            win.ShowDialog();
            this.Close();
        }

        public void CloseThreading()
        {
            Thread.Sleep(1000);

            ImageChange(picture[close1], -1);
            ImageChange(picture[close2], -1);

            status[close1] = Status.CLOSE;
            status[close2] = Status.CLOSE;

            pic_click = false;
        }

        public void gameTimer_Tick(object sender, EventArgs e)
        {
            timer += 1;
        }

        public void ImageChange(PictureBox pic, int value)
        {
            GameImage bitmap;
            switch((value))
            {
                case 0:
                    bitmap = new GameImage(Game.Properties.Resources.spade_a, 80, 100);
                    pic.Image = bitmap.ResizeBitmap;
                    break;

                case 1:
                    bitmap = new GameImage(Game.Properties.Resources.spade_2, 80, 100);
                    pic.Image = bitmap.ResizeBitmap;
                    break;

                case 2:
                    bitmap = new GameImage(Game.Properties.Resources.spade_3, 80, 100);
                    pic.Image = bitmap.ResizeBitmap;
                    break;

                case 3:
                    bitmap = new GameImage(Game.Properties.Resources.spade_4, 80, 100);
                    pic.Image = bitmap.ResizeBitmap;
                    break;

                case 4:
                    bitmap = new GameImage(Game.Properties.Resources.spade_5, 80, 100);
                    pic.Image = bitmap.ResizeBitmap;
                    break;

                case 5:
                    bitmap = new GameImage(Game.Properties.Resources.spade_6, 80, 100);
                    pic.Image = bitmap.ResizeBitmap;
                    break;

                case 6:
                    bitmap = new GameImage(Game.Properties.Resources.spade_7, 80, 100);
                    pic.Image = bitmap.ResizeBitmap;
                    break;

                case 7:
                    bitmap = new GameImage(Game.Properties.Resources.spade_8, 80, 100);
                    pic.Image = bitmap.ResizeBitmap;
                    break;

                case 8:
                    bitmap = new GameImage(Game.Properties.Resources.spade_9, 80, 100);
                    pic.Image = bitmap.ResizeBitmap;
                    break;

                case 9:
                    bitmap = new GameImage(Game.Properties.Resources.spade_10, 80, 100);
                    pic.Image = bitmap.ResizeBitmap;
                    break;

                case 10:
                    bitmap = new GameImage(Game.Properties.Resources.spade_j, 80, 100);
                    pic.Image = bitmap.ResizeBitmap;
                    break;

                case 11:
                    bitmap = new GameImage(Game.Properties.Resources.spade_q, 80, 100);
                    pic.Image = bitmap.ResizeBitmap;
                    break;

                case 12:
                    bitmap = new GameImage(Game.Properties.Resources.spade_k, 80, 100);
                    pic.Image = bitmap.ResizeBitmap;
                    break;

                case 13:
                    bitmap = new GameImage(Game.Properties.Resources.heart_a, 80, 100);
                    pic.Image = bitmap.ResizeBitmap;
                    break;

                case 14:
                    bitmap = new GameImage(Game.Properties.Resources.heart_2, 80, 100);
                    pic.Image = bitmap.ResizeBitmap;
                    break;

                case 15:
                    bitmap = new GameImage(Game.Properties.Resources.heart_3, 80, 100);
                    pic.Image = bitmap.ResizeBitmap;
                    break;

                case 16:
                    bitmap = new GameImage(Game.Properties.Resources.heart_4, 80, 100);
                    pic.Image = bitmap.ResizeBitmap;
                    break;

                case 17:
                    bitmap = new GameImage(Game.Properties.Resources.heart_5, 80, 100);
                    pic.Image = bitmap.ResizeBitmap;
                    break;

                case 18:
                    bitmap = new GameImage(Game.Properties.Resources.heart_6, 80, 100);
                    pic.Image = bitmap.ResizeBitmap;
                    break;

                case 19:
                    bitmap = new GameImage(Game.Properties.Resources.heart_7, 80, 100);
                    pic.Image = bitmap.ResizeBitmap;
                    break;

                case 20:
                    bitmap = new GameImage(Game.Properties.Resources.heart_8, 80, 100);
                    pic.Image = bitmap.ResizeBitmap;
                    break;

                case 21:
                    bitmap = new GameImage(Game.Properties.Resources.heart_9, 80, 100);
                    pic.Image = bitmap.ResizeBitmap;
                    break;

                case 22:
                    bitmap = new GameImage(Game.Properties.Resources.heart_10, 80, 100);
                    pic.Image = bitmap.ResizeBitmap;
                    break;

                case 23:
                    bitmap = new GameImage(Game.Properties.Resources.heart_j, 80, 100);
                    pic.Image = bitmap.ResizeBitmap;
                    break;

                case 24:
                    bitmap = new GameImage(Game.Properties.Resources.heart_q, 80, 100);
                    pic.Image = bitmap.ResizeBitmap;
                    break;

                case 25:
                    bitmap = new GameImage(Game.Properties.Resources.heart_k, 80, 100);
                    pic.Image = bitmap.ResizeBitmap;
                    break;

                default:
                    //pic.Image = back.ResizeBitmap;
                    Invoke(new Action(delegate { pic.Image = back.ResizeBitmap; }));
                    break;
            }
        }
            
    }
}
