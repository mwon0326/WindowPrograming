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
    public partial class MultiSelectForm : Form
    {
        public MultiSelectForm()
        {
            InitializeComponent();
        }

        private void Selectbutton_Click(object sender, EventArgs e)
        {
            MultiEasyGameForm easy = new MultiEasyGameForm();
            MultiNormalGameForm normal = new MultiNormalGameForm();
            MultiHardGameForm hard = new MultiHardGameForm();

            if (easyButton.Checked)
                easy.Show();
            else if (normalButton.Checked)
                normal.Show();
            else if (hardButton.Checked)
                hard.Show();

            this.Close();
        }
    }
}
