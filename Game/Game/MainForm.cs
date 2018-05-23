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
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Bitmap playB = Game.Properties.Resources.play_button;
            GameImage newplay = new GameImage();
            playB = newplay.ResizeBitmap(playB, 290, 45);

            Bitmap highscoreB = Game.Properties.Resources.highscore_button;
            GameImage newHighscoreB = new GameImage();
            highscoreB = newHighscoreB.ResizeBitmap(highscoreB, 290, 45);

            Bitmap quitB = Game.Properties.Resources.quit_button;
            GameImage newQuitB = new GameImage();
            quitB = newQuitB.ResizeBitmap(quitB, 300, 45);

            playButton.Image = playB;
            highscoreButton.Image = highscoreB;
            quitButton.Image = quitB;
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            SelectForm select = new SelectForm();
            select.ShowDialog();
        }
    }
}
