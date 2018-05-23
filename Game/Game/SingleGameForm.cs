using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Game
{
    public enum Status { CLOSE, OPEN, MATCH }

    public partial class SingleGameForm : Form
    {
        Bitmap back;
        int[] game;
        Status[] status;
        PictureBox[] picture;
        bool pic_click = false;
        int openCount = 0;
        int timer = 0;
        int close1, close2;
        int levelTag;

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
        }

        private void SingleEasyGameForm_Load(object sender, EventArgs e)
        {
            StartGame();
        }

        private void StartGame()
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
                back = Game.Properties.Resources.back;
                GameImage newback = new GameImage();
                back = newback.ResizeBitmap(back, 80, 100);
                picture[i].Image = back;
            }
        }

        private void picture_Click(object sender, EventArgs e)
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
                    }
                    else
                    {
                        pic_click = true;

                        close1 = match;
                        close2 = num;

                        Thread th = new Thread(new ThreadStart(CloseThreading));
                        th.Start();
                    }

                    openCount++;
                }
                else
                    status[num] = Status.OPEN;
            }

            SuccCheck();
        }

        private void SuccCheck()
        {
            foreach (Status statusC in status)
            {
                if (statusC != Status.MATCH)
                    return;
            }
            gameTimer.Stop();
        }

        private void CloseThreading()
        {
            Thread.Sleep(1000);

            ImageChange(picture[close1], -1);
            ImageChange(picture[close2], -1);

            status[close1] = Status.CLOSE;
            status[close2] = Status.CLOSE;

            pic_click = false;
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            timer += 1;
        }

        private void ImageChange(PictureBox pic, int value)
        {
            GameImage newImage = new GameImage();
            Bitmap bitmap;
            switch((value))
            {
                case 0:
                    bitmap = Game.Properties.Resources.spade_a;
                    bitmap = newImage.ResizeBitmap(bitmap, 80, 100);
                    pic.Image = bitmap;
                    break;

                case 1:
                    bitmap = Game.Properties.Resources.spade_2;
                    bitmap = newImage.ResizeBitmap(bitmap, 80, 100);
                    pic.Image = bitmap;
                    break;

                case 2:
                    bitmap = Game.Properties.Resources.spade_3;
                    bitmap = newImage.ResizeBitmap(bitmap, 80, 100);
                    pic.Image = bitmap;
                    break;

                case 3:
                    bitmap = Game.Properties.Resources.spade_4;
                    bitmap = newImage.ResizeBitmap(bitmap, 80, 100);
                    pic.Image = bitmap;
                    break;

                case 4:
                    bitmap = Game.Properties.Resources.spade_5;
                    bitmap = newImage.ResizeBitmap(bitmap, 80, 100);
                    pic.Image = bitmap;
                    break;

                case 5:
                    bitmap = Game.Properties.Resources.spade_6;
                    bitmap = newImage.ResizeBitmap(bitmap, 80, 100);
                    pic.Image = bitmap;
                    break;

                case 6:
                    bitmap = Game.Properties.Resources.spade_7;
                    bitmap = newImage.ResizeBitmap(bitmap, 80, 100);
                    pic.Image = bitmap;
                    break;

                case 7:
                    bitmap = Game.Properties.Resources.spade_8;
                    bitmap = newImage.ResizeBitmap(bitmap, 80, 100);
                    pic.Image = bitmap;
                    break;

                case 8:
                    bitmap = Game.Properties.Resources.spade_9;
                    bitmap = newImage.ResizeBitmap(bitmap, 80, 100);
                    pic.Image = bitmap;
                    break;

                case 9:
                    bitmap = Game.Properties.Resources.spade_10;
                    bitmap = newImage.ResizeBitmap(bitmap, 80, 100);
                    pic.Image = bitmap;
                    break;

                case 10:
                    bitmap = Game.Properties.Resources.spade_j;
                    bitmap = newImage.ResizeBitmap(bitmap, 80, 100);
                    pic.Image = bitmap;
                    break;

                case 11:
                    bitmap = Game.Properties.Resources.spade_q;
                    bitmap = newImage.ResizeBitmap(bitmap, 80, 100);
                    pic.Image = bitmap;
                    break;

                case 12:
                    bitmap = Game.Properties.Resources.spade_k;
                    bitmap = newImage.ResizeBitmap(bitmap, 80, 100);
                    pic.Image = bitmap;
                    break;

                case 13:
                    bitmap = Game.Properties.Resources.heart_a;
                    bitmap = newImage.ResizeBitmap(bitmap, 80, 100);
                    pic.Image = bitmap;
                    break;

                case 14:
                    bitmap = Game.Properties.Resources.heart_2;
                    bitmap = newImage.ResizeBitmap(bitmap, 80, 100);
                    pic.Image = bitmap;
                    break;

                case 15:
                    bitmap = Game.Properties.Resources.heart_3;
                    bitmap = newImage.ResizeBitmap(bitmap, 80, 100);
                    pic.Image = bitmap;
                    break;

                case 16:
                    bitmap = Game.Properties.Resources.heart_4;
                    bitmap = newImage.ResizeBitmap(bitmap, 80, 100);
                    pic.Image = bitmap;
                    break;

                case 17:
                    bitmap = Game.Properties.Resources.heart_5;
                    bitmap = newImage.ResizeBitmap(bitmap, 80, 100);
                    pic.Image = bitmap;
                    break;

                case 18:
                    bitmap = Game.Properties.Resources.heart_6;
                    bitmap = newImage.ResizeBitmap(bitmap, 80, 100);
                    pic.Image = bitmap;
                    break;

                case 19:
                    bitmap = Game.Properties.Resources.heart_7;
                    bitmap = newImage.ResizeBitmap(bitmap, 80, 100);
                    pic.Image = bitmap;
                    break;

                case 20:
                    bitmap = Game.Properties.Resources.heart_8;
                    bitmap = newImage.ResizeBitmap(bitmap, 80, 100);
                    pic.Image = bitmap;
                    break;

                case 21:
                    bitmap = Game.Properties.Resources.heart_9;
                    bitmap = newImage.ResizeBitmap(bitmap, 80, 100);
                    pic.Image = bitmap;
                    break;

                case 22:
                    bitmap = Game.Properties.Resources.heart_10;
                    bitmap = newImage.ResizeBitmap(bitmap, 80, 100);
                    pic.Image = bitmap;
                    break;

                case 23:
                    bitmap = Game.Properties.Resources.heart_j;
                    bitmap = newImage.ResizeBitmap(bitmap, 80, 100);
                    pic.Image = bitmap;
                    break;

                case 24:
                    bitmap = Game.Properties.Resources.heart_q;
                    bitmap = newImage.ResizeBitmap(bitmap, 80, 100);
                    pic.Image = bitmap;
                    break;

                case 25:
                    bitmap = Game.Properties.Resources.heart_k;
                    bitmap = newImage.ResizeBitmap(bitmap, 80, 100);
                    pic.Image = bitmap;
                    break;

                default:
                    pic.Image = back;
                    break;
            }
        }
            
    }
}
