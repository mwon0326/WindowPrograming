using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Game
{
    public partial class MultiGameForm : Form
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
        int levelTag, panWid = 0, pandHei = 0;
        const int EASY_P = 100;
        const int MINUS = 10;
        const int NORMAL_P = 200;
        const int EASY = 25;
        const int NORMAL = 51;
        int player1Score = 0;
        int player2Score = 0;
        int rotation = 0;
        int prevKey, bgSpeed = 100, bgOffset = 0;
        DateTime previousTime;
        AnimationImage kirby1, kirby2, kirbyS1, kirbyS2;
        int kirbyTag = 0;

        private void MultiGameForm_Paint(object sender, PaintEventArgs e)
        {
            for (int x = bgOffset; x < 1200; x += 400)
                e.Graphics.DrawImage(backGround, x, 0, 400, 700);

            e.Graphics.DrawImage(pan.ResizeBitmap, 10, 10);

            if (kirbyTag == 0)
            {
                kirby1.draw(e.Graphics);
                kirby2.draw(e.Graphics);
            }
            else if (kirbyTag == 1)
            {
                kirbyS1.draw(e.Graphics);
                kirbyS2.draw(e.Graphics);

                if (drawCount >= 16)
                {
                    kirbyTag = 0;
                    drawCount = 0;
                }
            }
        }

        private void imageTimer_Tick(object sender, EventArgs e)
        {
            var now = DateTime.Now;
            var elapsed = now - previousTime;
            previousTime = now;
            var msec = (int)elapsed.TotalMilliseconds;

            bgOffset -= bgSpeed * msec / 1000;
            if (bgOffset < -400)
                bgOffset += 400;

            if (kirbyTag == 0)
            {
                kirby1.updateFrame(msec);
                kirby2.updateFrame(msec);
            }
            else if (kirbyTag == 1)
            {
                kirbyS1.updateFrame(msec);
                kirbyS2.updateFrame(msec);
            }

            Invalidate();

            if (kirbyTag == 1)
                drawCount++;
        }

        public MultiGameForm(int tag)
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
                picture[i].Name = i.ToString();
                gamePan.Controls.Add(picture[i]);               
            }
            gamePan.Left = 15;
            gamePan.Top = 15;
            panWid = gamePan.Width + 10;
            pandHei = gamePan.Height + 10;
        }

        private void MultiGameForm_Load(object sender, EventArgs e)
        {
            PrivateFontCollection ft = new PrivateFontCollection();
            ft.AddFontFile("./Resources/KAMIKZOM.ttf");

            this.ClientSize = new Size(1200, 700);
            background = new GameImage(Game.Properties.Resources.mback, 400, 700);
            backGround = background.ResizeBitmap;

            pan = new GameImage(Game.Properties.Resources.kurbi_pan, panWid, pandHei);

            kirby1 = new AnimationImage(Game.Properties.Resources.kirby_run1, 8, 20.0f, 600, 150);
            kirby2 = new AnimationImage(Game.Properties.Resources.kirby_run2, 8, 20.0f, 600, 150);

            kirbyS1 = new AnimationImage(Game.Properties.Resources.kirby1, 8, 8.0f, 600, 150);
            kirbyS2 = new AnimationImage(Game.Properties.Resources.kirby2, 8, 8.0f, 600, 150);

            if (levelTag == 1)
            {
                kirby1.setPosition(600, 420);
                kirbyS1.setPosition(600, 420);
                kirby2.setPosition(600, 530);
                kirbyS2.setPosition(600, 530);
            }
            else if (levelTag == 2)
            {
                kirby1.setPosition(950, 420);
                kirbyS1.setPosition(950, 420);
                kirby2.setPosition(950, 530);
                kirbyS2.setPosition(950, 530);
            }

            StartGame();
            playerScore1.Left = 900;
            playerScore1.Top = 20;
            playerScore2.Left = 900;
            playerScore2.Top = playerScore1.Bottom + 100;

            playerScore1.Text = "1P Score : " + player1Score;
            playerScore2.Text = "2P Score : " + player2Score;
            previousTime = DateTime.Now;

            playerScore1.Font = new Font(ft.Families[0], 24f);
            playerScore2.Font = new Font(ft.Families[0], 24f);
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
                int templ = r.Next(0, game.Length);

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
            picture[0].BorderStyle = BorderStyle.Fixed3D;
            prevKey = 0;
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
                        {
                            if (rotation % 2 == 0)
                                player1Score += EASY_P;
                            else if (rotation % 2 == 1)
                                player2Score += EASY_P;
                        }
                        else if (levelTag == 2)
                        {
                            if (rotation % 2 == 0)
                                player1Score += NORMAL_P;
                            else if (rotation % 2 == 1)
                                player2Score += NORMAL_P;
                        }
                        kirbyTag = 1;
                    }
                    else
                    {
                        pic_click = true;

                        close1 = match;
                        close2 = num;

                        Thread th = new Thread(new ThreadStart(CloseThreading));
                        th.Start();

                        if (rotation % 2 == 0 && player1Score != 0)
                            player1Score -= MINUS;
                        else if (rotation % 2 == 1 && player2Score != 0)
                            player2Score -= MINUS;

                    }

                    openCount++;
                }
                else
                    status[num] = Status.OPEN;
            }
            playerScore1.Text = "1P Score : " + player1Score;
            playerScore2.Text = "2P Score : " + player2Score;
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

            int score = 0;
            int winner = 0;

            if (player1Score > player2Score)
            {
                score = player1Score;
                winner = 1;
            }
            else if (player2Score > player1Score)
            {
                score = player2Score;
                winner = 2;
            }
            else if (player2Score == player1Score)
            {
                score = player1Score;
                winner = 3;
            }

            WinForm win = new WinForm(levelTag, score, 2, winner);
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
            rotation += 1;
        }

        public void gameTimer_Tick(object sender, EventArgs e)
        {
            timer += 1;
        }

        private void MultiGameForm_KeyDown(object sender, KeyEventArgs e)
        {
            int maxIndex = 0;

            if (levelTag == 1)
                maxIndex = EASY;
            else if (levelTag == 2)
                maxIndex = NORMAL;

            if (rotation % 2 == 0)
            {
                if (e.KeyCode == Keys.Left && prevKey != 0)
                {
                    picture[prevKey].BorderStyle = BorderStyle.None;
                    picture[prevKey - 1].BorderStyle = BorderStyle.Fixed3D;
                    prevKey -= 1;
                }
                else if (e.KeyCode == Keys.Right && prevKey != maxIndex)
                {
                    picture[prevKey].BorderStyle = BorderStyle.None;
                    picture[prevKey + 1].BorderStyle = BorderStyle.Fixed3D;
                    prevKey += 1;
                }
                else if (e.KeyCode == Keys.Up && prevKey - 7 >= 0)
                {
                    picture[prevKey].BorderStyle = BorderStyle.None;
                    picture[prevKey - 7].BorderStyle = BorderStyle.Fixed3D;
                    prevKey -= 7;
                }
                else if (e.KeyCode == Keys.Down && prevKey + 7 <= maxIndex)
                {
                    picture[prevKey].BorderStyle = BorderStyle.None;
                    picture[prevKey + 7].BorderStyle = BorderStyle.Fixed3D;
                    prevKey += 7;
                }
                else if (e.KeyCode == Keys.Enter)
                {
                    picture_Click(picture[prevKey], null);
                }
            }
            else if (rotation %2 == 1)
            {
                if (e.KeyCode == Keys.A && prevKey != 0)
                {
                    picture[prevKey].BorderStyle = BorderStyle.None;
                    picture[prevKey - 1].BorderStyle = BorderStyle.Fixed3D;
                    prevKey -= 1;
                }
                else if (e.KeyCode == Keys.D && prevKey != maxIndex)
                {
                    picture[prevKey].BorderStyle = BorderStyle.None;
                    picture[prevKey + 1].BorderStyle = BorderStyle.Fixed3D;
                    prevKey += 1;
                }
                else if (e.KeyCode == Keys.W && prevKey - 7 >= 0)
                {
                    picture[prevKey].BorderStyle = BorderStyle.None;
                    picture[prevKey - 7].BorderStyle = BorderStyle.Fixed3D;
                    prevKey -= 7;
                }
                else if (e.KeyCode == Keys.S && prevKey + 7 <= maxIndex)
                {
                    picture[prevKey].BorderStyle = BorderStyle.None;
                    picture[prevKey + 7].BorderStyle = BorderStyle.Fixed3D;
                    prevKey += 7;
                }
                else if (e.KeyCode == Keys.Enter)
                {
                    picture_Click(picture[prevKey], null);
                }
            }
        }

        public void ImageChange(PictureBox pic, int value)
        {
            GameImage bitmap;
            switch ((value))
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

