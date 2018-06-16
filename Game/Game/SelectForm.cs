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
        GameImage single, multi;
        GameImage easy, normal;
        GameImage selectE, selectN;
        GameImage background;
        Bitmap backGround;
        int bgSpeed = 100;
        int bgOffset = 0;
        DateTime previousTime;

        private void timer_Tick(object sender, EventArgs e)
        {
            var now = DateTime.Now;
            var elapsed = now - previousTime;
            previousTime = now;
            var msec = (int)elapsed.TotalMilliseconds;

            bgOffset -= bgSpeed * msec / 1000;
            if (bgOffset < -400)
                bgOffset += 400;
            Invalidate();
        }

        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectForm_Paint(object sender, PaintEventArgs e)
        {
            for (int x = bgOffset; x < 900; x += 400)
                e.Graphics.DrawImage(backGround, x, 0, 400, 700);

            e.Graphics.DrawImage(single.ResizeBitmap, 25, 50);
            e.Graphics.DrawImage(multi.ResizeBitmap, 225, 50);
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            this.ClientSize = new Size(900, 700);
            single = new GameImage(Game.Properties.Resources.single, 200, 50);
            multi = new GameImage(Game.Properties.Resources.multi, 200, 50);

            easy = new GameImage(Game.Properties.Resources.easy, 200, 50);
            normal = new GameImage(Game.Properties.Resources.normal, 200, 50);

            selectE = new GameImage(Game.Properties.Resources.easy_s, 200, 50);
            selectN = new GameImage(Game.Properties.Resources.normal_s, 200, 50);

            singleEasyButton.BackgroundImage = easy.ResizeBitmap;
            singleNormalButton.BackgroundImage = normal.ResizeBitmap;
            multiEasyButton.BackgroundImage = easy.ResizeBitmap;
            multiNormalButton.BackgroundImage = normal.ResizeBitmap;

            background = new GameImage(Game.Properties.Resources.background,400,700);
            backGround = background.ResizeBitmap;
        }
    }
}
