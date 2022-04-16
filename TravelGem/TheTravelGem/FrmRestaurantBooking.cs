using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
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

        #region PlaceHolderMethods

        

        private void TbFirstName_Enter(object sender, EventArgs e)
        {
            if(TbFirstName.Text == PlaceHolders[0])
            {
                TbFirstName.ForeColor = Color.White;
                TbFirstName.Text = "";
            }
        }

        private void TbFirstName_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(TbFirstName.Text))
            {
                TbFirstName.Text = PlaceHolders[0];
                TbFirstName.ForeColor = Color.LightBlue;
            }
        }

        private void TbLastName_Enter(object sender, EventArgs e)
        {
            if(TbLastName.Text == PlaceHolders[1])
            {
                TbLastName.ForeColor = Color.White;
                TbLastName.Text = "";
            }
        }

        private void TbLastName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbLastName.Text))
            {
                TbLastName.Text= PlaceHolders[1];
                TbLastName.ForeColor = Color.LightBlue;
            }
        }


        private void TbEmail_Enter(object sender, EventArgs e)
        {
            if(TbEmail.Text == PlaceHolders[2])
            {
                TbEmail.ForeColor = Color.White;
                TbEmail.Text = "";
            }
        }

        private void TbEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbEmail.Text))
            {
                TbEmail.ForeColor= Color.LightBlue;
                TbEmail.Text = PlaceHolders[2];
            }
        }

        private void TbPhone_Enter(object sender, EventArgs e)
        {
            if(TbPhone.Text == PlaceHolders[3])
            {
                TbPhone.ForeColor = Color.White;
                TbPhone.Text = "";
            }
        }

        private void TbPhone_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbPhone.Text))
            {
                TbPhone.ForeColor= Color.LightBlue;
                TbPhone.Text = PlaceHolders[3];
            }
        }

        private void TbNumberOfGuest_Enter(object sender, EventArgs e)
        {
            if(TbNumberOfGuest.Text == PlaceHolders[4])
            {
                TbNumberOfGuest.ForeColor = Color.White;
                TbNumberOfGuest.Text = "";
            }
        }

        private void TbNumberOfGuest_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(TbNumberOfGuest.Text))
            {
                TbNumberOfGuest.ForeColor = Color.LightBlue;
                TbNumberOfGuest.Text = PlaceHolders[4];
            }
        }

        private void TbSpecial_Enter(object sender, EventArgs e)
        {
            if(TbSpecial.Text == PlaceHolders[5])
            {
                TbSpecial.ForeColor = Color.White;
                TbSpecial.Text = "";
            }
        }

        private void TbSpecial_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(TbSpecial.Text))
            {
                TbSpecial.ForeColor= Color.LightBlue;
                TbSpecial.Text= PlaceHolders[5];
            }
        }

        #endregion
        #region TextBox_Validation_Methods
        private void ValidateForm()
        {
            if (!IsValFirstName(TbFirstName.Text))
            {
                ValiFirstName.Text = "Not A Valid First Name";
                ValiFirstName.ForeColor = Color.Red;
            }
            else
                ValiFirstName.Text = "";

            if (!IsValLastName(TbLastName.Text))
            {
                ValiLastName.Text = "Not A Valid Last Name";
                ValiLastName.ForeColor = Color.Red;
            }
            else
                ValiLastName.Text = "";

            if (!IsValEmail(TbEmail.Text))
            {
                ValiEmail.Text = "Not A Valid Email";
                ValiEmail.ForeColor = Color.Red;
            }
            else
                ValiEmail.Text = "";

            if (!IsValPhoneNumber(TbPhone.Text))
            {
                ValiPhoneNumber.Text = "Not A Valid Phone Number \n Eg.0000-000-0000";
                ValiPhoneNumber.ForeColor = Color.Red;
            }
            else
                ValiPhoneNumber.Text = "";

            if (!IsValNumberOfGuest(TbNumberOfGuest.Text))
            {
                ValiNumberOfGuest.Text = "Enter the amount of Guest";
                ValiNumberOfGuest.ForeColor = Color.Red;
            }
            else
                ValiNumberOfGuest.Text = "";

        }
        private bool IsValEmail(String Email)
        {
            try
            {
                MailAddress ValEmailAdd = new MailAddress(Email);
                return true;
            }
            catch
            {
                return false;
            }

        }
        private bool IsValFirstName(String FirstName)
        {
            return FirstName.Length > 3
                && FirstName != PlaceHolders[0];
        }
        private bool IsValLastName(String LastName)
        {
            return LastName.Length > 3
                && LastName != PlaceHolders[1];
        }
        private bool IsValPhoneNumber(String PhoneNumber)
        {
            Regex ValPhoneNumber = new Regex("\\d{4}-\\d{3}-\\d{4}");
            if (ValPhoneNumber.IsMatch(PhoneNumber))
                return true;
            else
                return false;
        }

        private bool IsValNumberOfGuest(String NumberOfGuest)
        {
            try
            {
                int.Parse(NumberOfGuest);
                return true;
            }
            catch { return false; }
        }
        #endregion

        private void BtnReserve_Click(object sender, EventArgs e)
        {
            ValidateForm();
        }
    }
}
