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
    public partial class multi_SelectForm : Form
    {
        public multi_SelectForm()
        {
            InitializeComponent();
        }

        private void Selectbutton_Click(object sender, EventArgs e)
        {
            multiEasyGameForm easy = new multiEasyGameForm();
            multiNormalGameForm normal = new multiNormalGameForm();
            multiHardGameForm hard = new multiHardGameForm();

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
