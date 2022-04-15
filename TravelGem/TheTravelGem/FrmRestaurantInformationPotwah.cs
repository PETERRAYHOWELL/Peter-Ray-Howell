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
    public partial class FrmRestaurantInformationPotwah : Form
    {
        public FrmRestaurantInformationPotwah()
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

        private void BtnBooking_Click(object sender, EventArgs e)
        {
            Form Booking = new FrmRestaurantBooking();
            this.Hide();
            Booking.ShowDialog();
            this.Show();
        }
    }
}
