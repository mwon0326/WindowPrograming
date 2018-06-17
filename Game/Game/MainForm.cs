using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class MainForm : Form
    {
        GameImage playB, highscoreB, quitB, titleL;
        GameImage background;
        Bitmap backGround;
        AnimationImage kurbi;
        int bgSpeed = 100;
        int bgOffset = 0;
        DateTime previousTime;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            playB = new GameImage(Game.Properties.Resources.start, 200, 50);
            highscoreB = new GameImage(Game.Properties.Resources.high, 200, 50);
            quitB = new GameImage(Game.Properties.Resources.quit, 200, 50);
            titleL = new GameImage(Game.Properties.Resources.title, 400, 200);

            playButton.BackgroundImage = playB.ResizeBitmap;
            highscoreButton.BackgroundImage = highscoreB.ResizeBitmap;
            quitButton.BackgroundImage = quitB.ResizeBitmap;
            title.BackgroundImage = titleL.ResizeBitmap;

            this.ClientSize = new Size(900, 700);
            playButton.Left = (this.ClientSize.Width - playButton.Width) / 2;
            highscoreButton.Left = (this.ClientSize.Width - highscoreButton.Width) / 2;
            quitButton.Left = (this.ClientSize.Width - quitButton.Width) / 2;
            title.Left = (this.ClientSize.Width - title.Width) / 2;

            background = new GameImage(Game.Properties.Resources.background, 400, 700);
            backGround = background.ResizeBitmap;

            kurbi = new AnimationImage(Game.Properties.Resources.kurbi_run, 8, 20.0f, 600, 150);
            kurbi.setPosition(400, 450);

            previousTime = DateTime.Now;
        }

        private void playButton_MouseEnter(object sender, EventArgs e)
        {
            GameImage focusPlay = new GameImage(Game.Properties.Resources.start_s, 200, 50);
            playButton.BackgroundImage = focusPlay.ResizeBitmap;
        }

        private void playButton_MouseLeave(object sender, EventArgs e)
        {
            playButton.BackgroundImage = playB.ResizeBitmap;
        }

        private void highscoreButton_MouseEnter(object sender, EventArgs e)
        {
            GameImage focusHigh = new GameImage(Game.Properties.Resources.high_s, 200, 50);
            highscoreButton.BackgroundImage = focusHigh.ResizeBitmap;
        }

        private void highscoreButton_MouseLeave(object sender, EventArgs e)
        {
            highscoreButton.BackgroundImage = highscoreB.ResizeBitmap;
        }

        private void quitButton_MouseEnter(object sender, EventArgs e)
        {
            GameImage focusQuit = new GameImage(Game.Properties.Resources.quit_s, 200, 50);
            quitButton.BackgroundImage = focusQuit.ResizeBitmap;        
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            var now = DateTime.Now;
            var elapsed = now - previousTime;
            previousTime = now;
            var msec = (int)elapsed.TotalMilliseconds;

            bgOffset -= bgSpeed * msec / 1000;
            if (bgOffset < -400)
                bgOffset += 400;

            kurbi.updateFrame(msec);
            Invalidate();
        }

        private void highscoreButton_Click(object sender, EventArgs e)
        {
            RankingForm rank = new RankingForm();
            rank.ShowDialog();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            for (int x = bgOffset; x < 900; x += 400)
                e.Graphics.DrawImage(backGround, x, 0, 400, 700);

            kurbi.draw(e.Graphics);
        }

        private void quitButton_MouseLeave(object sender, EventArgs e)
        {
            quitButton.BackgroundImage = quitB.ResizeBitmap;
        }

        private void playButton_MouseClick(object sender, EventArgs e)
        {
            SelectForm s = new SelectForm();
            Program.ac.MainForm = s;
            s.Show();

            this.Close();
        }
    }
}
