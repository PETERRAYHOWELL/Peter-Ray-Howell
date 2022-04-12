using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheTravelGem
{
    public partial class FrmInformationPotwah : Form
    {
        public FrmInformationPotwah()
        {
            InitializeComponent();
        }

        int count = 0;
        private void Potwah_Load(object sender, EventArgs e)
        {

        }

        private void timerPotwah_Tick(object sender, EventArgs e)
        {

        }

        private void timerPotwah_Tick_1(object sender, EventArgs e)
        {
            if (count < 3)

            {
                pictureBox1.Image = imageListPotwah.Images[count];

                count++;
            }

            else
            {
                count = 0;
            }
            
        }
    }
}
