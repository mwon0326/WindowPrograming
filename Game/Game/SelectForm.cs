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

        private void easySButton_Click(object sender, EventArgs e)
        {
            SingleGameForm single = new SingleGameForm(1);
            single.ShowDialog();
        }

        private void normalSButton_Click(object sender, EventArgs e)
        {
            SingleGameForm single = new SingleGameForm(2);
            single.ShowDialog();
        }

        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(single, 50, 50);
            e.Graphics.DrawImage(multi, 250, 50);
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            single = Game.Properties.Resources.single_label;
            multi = Game.Properties.Resources.multi_label;

            easy = Game.Properties.Resources.easy_button;
            normal = Game.Properties.Resources.normal_button;

            GameImage newEasy = new GameImage();
            easy = newEasy.ResizeBitmap(easy, 130, 50);
            GameImage newNormal = new GameImage();
            normal = newNormal.ResizeBitmap(normal, 130, 50);


            easySButton.Image = easy;
            normalSButton.Image = normal;
            easyMButton.Image = easy;
            normalMButton.Image = normal;
        }
    }
}
