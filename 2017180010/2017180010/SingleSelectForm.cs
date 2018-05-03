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
    public partial class SingleSelectForm : Form
    {
        public SingleSelectForm()
        {
            InitializeComponent();
        }

        private void Selectbutton_Click(object sender, EventArgs e)
        {
            SingleEasyGameForm easy = new SingleEasyGameForm();
            SingleNormalGameForm normal = new SingleNormalGameForm();
            SingleHardGameForm hard = new SingleHardGameForm();

            if (easyButton.Checked)
                easy.Show();
            else if (normalButton.Checked)
                normal.Show();
            else if (hardButton.Checked)
                hard.Show();

            this.Close();
        }

        private void hardButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void normalButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void easyButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
