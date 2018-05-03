using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2017180010
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void singleButton_Click(object sender, EventArgs e)
        {
            SingleSelectForm single = new SingleSelectForm();
            single.ShowDialog();
            this.Hide();
        }

        private void mutiButton_Click(object sender, EventArgs e)
        {
            MultiSelectForm muti = new MultiSelectForm();
            muti.ShowDialog();
            this.Hide();
        }

        private void imageButton_Click(object sender, EventArgs e)
        {
            openImageFile.InitialDirectory = @"C:\";
            openImageFile.Filter = "비트맵 이미지(*.jpg)|*.jpg|모든 파일(*.*)|*.*";
            openImageFile.ShowDialog();
        }

        private void highScoreButton_Click(object sender, EventArgs e)
        {
            HighScoreForm highScore = new HighScoreForm();
            highScore.ShowDialog();
        }
    }
}
