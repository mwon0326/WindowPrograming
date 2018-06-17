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

namespace Game
{
    public partial class WinForm : Form
    {
        int score_, tag, mood, winnerT;
        string level;
        GameImage quit;
        GameImage quitS, back;

        public WinForm(int levelTag, int score, int moodTag, int winner)
        {
            tag = levelTag;
            mood = moodTag;
            winnerT = winner;

            if (levelTag == 1)
                level = "EASY";
            else if (levelTag == 2)
                level = "NORMAL";

            score_ = score;
            InitializeComponent();
        }

        private void WinForm_Load(object sender, EventArgs e)
        {
            this.ClientSize = new Size(400, 500);
            scoreLabel.Left = (this.ClientSize.Width - scoreLabel.Width) / 2;
            quitButton.Left = (this.ClientSize.Width - quitButton.Width) / 2;
            quitButton.Top = 300;
            scoreLabel.Top = 150;

            if (mood == 1)
                scoreLabel.Text = level + " CLEAR\n" + "SCORE : " + score_;
            else if (mood == 2)
            {
                if (winnerT == 1)
                    scoreLabel.Text = level + " WINNER PLAYER1\n" + "SCORE : " + score_;
                else if (winnerT == 2)
                    scoreLabel.Text = level + " WINNER PLAYER1\n" + "SCORE : " + score_;
                else if (winnerT == 3)
                    scoreLabel.Text = level + " DRAW\n" + "SCORE : " + score_;
            }
            quit = new GameImage(Game.Properties.Resources.quit, 200, 50);
            quitS = new GameImage(Game.Properties.Resources.quit_s, 200, 50);
            back = new GameImage(Game.Properties.Resources.background, 400, 500);

            quitButton.BackgroundImage = quit.ResizeBitmap;
        }

        private void quitButton_MouseEnter(object sender, EventArgs e)
        {
            quitButton.BackgroundImage = quitS.ResizeBitmap;
        }

        private void WinForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(back.ResizeBitmap, 0, 0);
        }

        private void quitButton_MouseLeave(object sender, EventArgs e)
        {
            quitButton.BackgroundImage = quit.ResizeBitmap;
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            Program.ac.MainForm = main;
            main.Show();
            this.Close();
        }
    }
}
