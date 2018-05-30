using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    interface GamePlay
    {
        void StartGame();
        void SuccCheck();
        void CloseThreading();
        void ImageChange(PictureBox pic, int value);
        event EventHandler Click;
    }
}
