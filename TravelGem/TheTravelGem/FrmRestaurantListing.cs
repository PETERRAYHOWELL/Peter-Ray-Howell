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
    public partial class FrmRestaurantListing : Form
    {
        public FrmRestaurantListing()
        {
            InitializeComponent();
        }

        private void BtnPotwah_Click(object sender, EventArgs e)
        {
            Form Potwah = new FrmRestaurantInformationPotwah();
            this.Hide();
            Potwah.ShowDialog();
            this.Show();
        }

        private void BtnIslandVillage_Click(object sender, EventArgs e)
        {
            Form Island = new FrmRestaurantInformationMagaritaville();
            this.Hide();
            Island.ShowDialog();
            this.Show();
        }

        private void BtnChillin_Click(object sender, EventArgs e)
        {
            Form Chillin = new FrmRestaurantInformationChillin();
            this.Hide();
            Chillin.ShowDialog();
            this.Show();
        }
    }
}
