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
        Bitmap playB, highscoreB, quitB;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            playB = Game.Properties.Resources.play;
            GameImage newplay = new GameImage();
            playB = newplay.ResizeBitmap(playB, 200, 50);

            highscoreB = Game.Properties.Resources.highscore;
            GameImage newHighscoreB = new GameImage();
            highscoreB = newHighscoreB.ResizeBitmap(highscoreB, 200, 50);

            quitB = Game.Properties.Resources.quit;
            GameImage newQuitB = new GameImage();
            quitB = newQuitB.ResizeBitmap(quitB, 200, 50);

            playButton.BackgroundImage = playB;
            highscoreButton.BackgroundImage = highscoreB;
            quitButton.BackgroundImage = quitB;
        }

        private void playButton_MouseEnter(object sender, EventArgs e)
        {
            Bitmap focusPlay = Game.Properties.Resources.s_play;
            GameImage newfocusPlay = new GameImage();
            focusPlay = newfocusPlay.ResizeBitmap(focusPlay, 200, 50);

            playButton.BackgroundImage = focusPlay;
        }

        private void highscoreButton_MouseEnter(object sender, EventArgs e)
        {
            Bitmap focusHigh = Game.Properties.Resources.s_highscore;
            GameImage newfocusHigh = new GameImage();
            focusHigh = newfocusHigh.ResizeBitmap(focusHigh, 200, 50);

            highscoreButton.BackgroundImage = focusHigh;
        }

        private void highscoreButton_MouseLeave(object sender, EventArgs e)
        {
            highscoreButton.BackgroundImage = highscoreB;
        }

        private void quitButton_MouseEnter(object sender, EventArgs e)
        {
            Bitmap focusQuit = Game.Properties.Resources.s_quit;
            GameImage newfocusQuit = new GameImage();
            focusQuit = newfocusQuit.ResizeBitmap(focusQuit, 200, 50);

            quitButton.BackgroundImage = focusQuit;
        }

        private void quitButton_MouseLeave(object sender, EventArgs e)
        {
            quitButton.BackgroundImage = quitB;
        }

        private void playButton_MouseLeave(object sender, EventArgs e)
        {
            playButton.BackgroundImage = playB;
        }

        private void playButton_MouseClick(object sender, MouseEventArgs e)
        {
            SelectForm form = new SelectForm();
            form.ShowDialog();
        }
    }
}
