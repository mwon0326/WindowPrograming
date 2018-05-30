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
    public partial class SelectForm : Form
    {
        Bitmap single, multi;
        Bitmap easy, normal;
        Bitmap selectEasy, selectNormal;

        private void singleEasyButton_MouseEnter(object sender, EventArgs e)
        {
            singleEasyButton.BackgroundImage = selectEasy;
        }

        private void singleEasyButton_MouseLeave(object sender, EventArgs e)
        {
            singleEasyButton.BackgroundImage = easy;
        }

        private void singleNormalButton_MouseEnter(object sender, EventArgs e)
        {
            singleNormalButton.BackgroundImage = selectNormal;
        }

        private void singleNormalButton_MouseLeave(object sender, EventArgs e)
        {
            singleNormalButton.BackgroundImage = normal;
        }

        private void multiEasyButton_MouseEnter(object sender, EventArgs e)
        {
            multiEasyButton.BackgroundImage = selectEasy;
        }

        private void multiEasyButton_MouseLeave(object sender, EventArgs e)
        {
            multiEasyButton.BackgroundImage = easy;
        }

        private void multiNormalButton_MouseEnter(object sender, EventArgs e)
        {
            multiNormalButton.BackgroundImage = selectNormal;
        }

        private void multiNormalButton_MouseLeave(object sender, EventArgs e)
        {
            multiNormalButton.BackgroundImage = normal;
        }

        private void singleEasyButton_Click(object sender, EventArgs e)
        {
            SingleGameForm single = new SingleGameForm(1);
            single.ShowDialog();
        }

        private void singleNormalButton_Click(object sender, EventArgs e)
        {
            SingleGameForm single = new SingleGameForm(2);
            single.ShowDialog();
        }

        private void multiEasyButton_Click(object sender, EventArgs e)
        {
            MultiGameForm multi = new MultiGameForm(1);
            multi.ShowDialog();
        }

        private void multiNormalButton_Click(object sender, EventArgs e)
        {
            MultiGameForm multi = new MultiGameForm(2);
            multi.ShowDialog();
        }

        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(single, 25, 50);
            e.Graphics.DrawImage(multi, 225, 50);
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            GameImage newSingle = new GameImage();
            single = Game.Properties.Resources.single;
            single = newSingle.ResizeBitmap(single, 200, 50);

            GameImage newMulti = new GameImage();
            multi = Game.Properties.Resources.multi;
            multi = newMulti.ResizeBitmap(multi, 200, 50);

            easy = Game.Properties.Resources.easy;
            normal = Game.Properties.Resources.normal;

            GameImage newEasy = new GameImage();
            easy = newEasy.ResizeBitmap(easy, 130, 50);
            GameImage newNormal = new GameImage();
            normal = newNormal.ResizeBitmap(normal, 130, 50);

            GameImage newSelectE = new GameImage();
            selectEasy = Game.Properties.Resources.s_easy;
            selectEasy = newSelectE.ResizeBitmap(selectEasy, 130, 50);

            GameImage newSelectN = new GameImage();
            selectNormal = Game.Properties.Resources.s_normal;
            selectNormal = newSelectN.ResizeBitmap(selectNormal, 130, 50);

            singleEasyButton.BackgroundImage = easy;
            singleNormalButton.BackgroundImage = normal;
            multiEasyButton.BackgroundImage = easy;
            multiNormalButton.BackgroundImage = normal;
        }
    }
}
