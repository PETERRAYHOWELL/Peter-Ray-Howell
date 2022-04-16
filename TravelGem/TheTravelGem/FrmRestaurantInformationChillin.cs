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
    public partial class FrmRestaurantInformationChillin : Form
    {
        public FrmRestaurantInformationChillin()
        {
            InitializeComponent();
        }
        int count = 0;
        private void timerChillin_Tick(object sender, EventArgs e)
        {
            if (count < 4)

            {
                picBoxChillin.Image = imageListChillin.Images[count];

                count++;
            }

            else
            {
                count = 0;
            }
        }

        private void picBoxChillin_Click(object sender, EventArgs e)
        {

        }
    }
}
