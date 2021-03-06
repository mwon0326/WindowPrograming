﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchingGame
{
    public partial class SelectForm : Form
    {
        GameImage single, multi, back, backS;
        GameImage easy, normal;
        GameImage selectE, selectN;
        GameImage background;
        Bitmap backGround;
        int bgSpeed = 100;
        int bgOffset = 0;
        DateTime previousTime;
        AnimationImage kurbi;

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

        private void singleEasyButton_MouseEnter(object sender, EventArgs e)
        {
            singleEasyButton.BackgroundImage = selectE.ResizeBitmap;
        }

        private void singleEasyButton_MouseLeave(object sender, EventArgs e)
        {
            singleEasyButton.BackgroundImage = easy.ResizeBitmap;
        }

        private void singleNormalButton_MouseEnter(object sender, EventArgs e)
        {
            singleNormalButton.BackgroundImage = selectN.ResizeBitmap;
        }

        private void singleNormalButton_MouseLeave(object sender, EventArgs e)
        {
            singleNormalButton.BackgroundImage = normal.ResizeBitmap;
        }

        private void multiEasyButton_MouseEnter(object sender, EventArgs e)
        {
            multiEasyButton.BackgroundImage = selectE.ResizeBitmap;
        }

        private void multiEasyButton_MouseLeave(object sender, EventArgs e)
        {
            multiEasyButton.BackgroundImage = easy.ResizeBitmap;
        }

        private void multiNormalButton_MouseEnter(object sender, EventArgs e)
        {
            multiNormalButton.BackgroundImage = selectN.ResizeBitmap;
        }

        private void multiNormalButton_MouseLeave(object sender, EventArgs e)
        {
            multiNormalButton.BackgroundImage = normal.ResizeBitmap;
        }

        private void singleEasyButton_Click(object sender, EventArgs e)
        {
            SingleGameForm sform = new SingleGameForm(1);
            sform.Show();
            Program.ac.MainForm = sform;
            this.Close();
        }

        private void singleNormalButton_Click(object sender, EventArgs e)
        {
            SingleGameForm sform = new SingleGameForm(2);
            sform.Show();
            Program.ac.MainForm = sform;
            this.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            Program.ac.MainForm = main;
            this.Close();
        }

        private void backButton_MouseEnter(object sender, EventArgs e)
        {
            backButton.BackgroundImage = backS.ResizeBitmap;
        }

        private void backButton_MouseLeave(object sender, EventArgs e)
        {
            backButton.BackgroundImage = back.ResizeBitmap;
        }

        private void multiEasyButton_Click(object sender, EventArgs e)
        {
            MultiGameForm mform = new MultiGameForm(1);
            mform.Show();
            Program.ac.MainForm = mform;
            this.Close();
        }

        private void multiNormalButton_Click(object sender, EventArgs e)
        {
            MultiGameForm mform = new MultiGameForm(2);
            mform.Show();
            Program.ac.MainForm = mform;
            this.Close();
        }

        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectForm_Paint(object sender, PaintEventArgs e)
        {
            for (int x = bgOffset; x < 900; x += 400)
                e.Graphics.DrawImage(backGround, x, 0, 400, 700);

            kurbi.draw(e.Graphics);
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            this.ClientSize = new Size(900, 700);
            single = new GameImage(Properties.Resources.single, 150, 100);
            multi = new GameImage(Properties.Resources.multi, 150, 100);

            easy = new GameImage(Properties.Resources.easy, 200, 50);
            normal = new GameImage(Properties.Resources.normal, 200, 50);

            selectE = new GameImage(Properties.Resources.easy_s, 200, 50);
            selectN = new GameImage(Properties.Resources.normal_s, 200, 50);

            back = new GameImage(Properties.Resources.backB, 200, 50);
            backS = new GameImage(Properties.Resources.s_backB, 200, 50);

            backButton.BackgroundImage = back.ResizeBitmap;
            singleEasyButton.BackgroundImage = easy.ResizeBitmap;
            singleNormalButton.BackgroundImage = normal.ResizeBitmap;
            multiEasyButton.BackgroundImage = easy.ResizeBitmap;
            multiNormalButton.BackgroundImage = normal.ResizeBitmap;

            background = new GameImage(Properties.Resources.background, 400, 700);
            backGround = background.ResizeBitmap;

            singleEasyButton.Left = 200;
            singleEasyButton.Top = 250;
            singleNormalButton.Left = 200;
            singleNormalButton.Top = singleEasyButton.Bottom + 20;

            multiEasyButton.Left = singleEasyButton.Right;
            multiEasyButton.Top = singleEasyButton.Top;
            multiNormalButton.Left = singleNormalButton.Right;
            multiNormalButton.Top = singleNormalButton.Top;

            singlePanel.BackgroundImage = single.ResizeBitmap;
            multiPanel.BackgroundImage = multi.ResizeBitmap;
            singlePanel.Left = 250;
            singlePanel.Top = singleEasyButton.Top - 120;
            multiPanel.Left = singlePanel.Right + 90;
            multiPanel.Top = singlePanel.Top;

            backButton.Left = (this.ClientSize.Width - backButton.Width) / 2;
            backButton.Top = (multiNormalButton.Bottom + 20);

            kurbi = new AnimationImage(Properties.Resources.kurbi_role, 9, 8.0f, 600, 150);
            kurbi.setPosition(400, 450);

            previousTime = DateTime.Now;
        }
    }
}
