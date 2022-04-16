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
    public partial class FrmRestaurantInformatrionPastasInHeaven : Form
    {
        public FrmRestaurantInformatrionPastasInHeaven()
        {
            InitializeComponent();
        }
        int count = 0;
        private void timerPastasInHeaven_Tick(object sender, EventArgs e)
        {
            if (count < 4)

            {
                picBoxPastasInHeaven.Image = imageListPastasInHeaven.Images[count];

                count++;
            }

            else
            {
                count = 0;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
