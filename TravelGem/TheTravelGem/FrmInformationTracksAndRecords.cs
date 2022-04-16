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
    public partial class FrmInformationTracksAndRecords : Form
    {
        public FrmInformationTracksAndRecords()
        {
            InitializeComponent();
        }
        int count = 0;
        private void timerTracksAndRecords_Tick(object sender, EventArgs e)
        {
            if (count < 5)

            {
                picBoxTracksAndRecords.Image = imageListTracksAndRecords.Images[count];

                count++;
            }

            else
            {
                count = 0;
            }
        }
    }
}
