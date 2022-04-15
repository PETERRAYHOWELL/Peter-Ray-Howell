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
    public partial class FrmRestaurantBooking : Form
    { 


        private String [] PlaceHolders = {"First Name","Last Name",
        "Email", "Phone Number", "Number of Guest", "Special Requirements"};
        private TextBox[] FormTextBoxes = new TextBox[6];
        public FrmRestaurantBooking()
        {
           
            InitializeComponent();
            FormTextBoxes[0] = TbFirstName;
            FormTextBoxes[1] = TbLastName;
            FormTextBoxes[2] = TbEmail;
            FormTextBoxes[3] = TbPhone;
            FormTextBoxes[4] = TbNumberOfGuest;
            FormTextBoxes[5] = TbSpecial;
        }

        private void FrmBooking_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(200, 0, 0, 0);
            PlacePlaceHolders();
            
            
        }

        private void PlacePlaceHolders()
        {
           for(int i = 0; i < FormTextBoxes.Length; i++)
            {
                FormTextBoxes[i].Text = PlaceHolders[i];
                FormTextBoxes[i].ForeColor = Color.LightBlue;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
