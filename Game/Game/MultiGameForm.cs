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
    public partial class MultiGameForm : Form, GamePlay
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
                picture[i].Click += picture_Click;
                picture[i].Name = i.ToString();
                gamePan.Controls.Add(picture[i]);
            }
        }

        private void MultiGameForm_Load(object sender, EventArgs e)
        {

        }

        public void StartGame() { }
        public void picture_Click(object sender, EventArgs e) { }
        public void SuccCheck() { }
        public void CloseThreading() { }
        public void gameTimer_Tick(object sender, EventArgs e)
        {
            timer += 1;
        }
        public void ImageChange(PictureBox pic, int value) { }
    }
}
