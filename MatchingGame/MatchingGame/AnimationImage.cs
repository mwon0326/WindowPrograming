using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace MatchingGame
{
    class AnimationImage : GameImage
    {
        private int frameCount;
        private int frameIndex;
        private float framesPerSecond;
        private int millisecondsElapsed;
        private RectangleF srcRect;

        public int index
        {
            get { return frameIndex; }
            set
            {
                frameIndex = value % frameCount;
                srcRect.X = frameIndex * srcRect.Width;
            }
        }

        public AnimationImage(Bitmap bitmap, int frameCount, float framesPerSecond, int nWidth, int nHeight)
            : base(bitmap, nWidth, nHeight)
        {
            this.frameCount = frameCount;
            this.rect.Width = this.rect.Width / frameCount;
            this.srcRect = rect;
            this.frameIndex = 0;
            this.framesPerSecond = framesPerSecond;
            this.millisecondsElapsed = 0;
        }

        public void updateFrame(int msec)
        {
            millisecondsElapsed += msec;
            var msecPerFrame = 1000 / framesPerSecond;
            index = (int)(millisecondsElapsed / msecPerFrame);
        }

        public void draw(Graphics g)
        {
            g.DrawImage(bitmap, rect, srcRect, GraphicsUnit.Pixel);
        }
    }
}
