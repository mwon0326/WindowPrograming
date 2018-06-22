using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace MatchingGame
{
    class GameImage
    {
        protected Bitmap bitmap;
        protected RectangleF rect;

        public GameImage(Bitmap bitmap, int nWidth, int nHeight)
        {
            this.bitmap = new Bitmap(nWidth, nHeight);
            using (Graphics g = Graphics.FromImage((Image)this.bitmap))
                g.DrawImage(bitmap, 0, 0, nWidth, nHeight);
            Size size = this.bitmap.Size;
            rect = new RectangleF(0, 0, size.Width, size.Height);
        }

        public Bitmap ResizeBitmap
        {
            get { return this.bitmap; }
        }

        public void setPosition(float x, float y)
        {
            rect.X = x;
            rect.Y = y;
        }
    }
}
