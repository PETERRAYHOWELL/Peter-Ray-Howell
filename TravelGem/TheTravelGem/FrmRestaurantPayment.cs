using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using TheTravelGem.Models;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheTravelGem
{
    public partial class FrmRestaurantPayment : Form
    {
        private String[] PlaceHolders = {"Card Number",
        "Name On Card", "MM/YY", "CVC"};
        private TextBox[] txtBoxes = new TextBox[4];
        public FrmRestaurantPayment()
        {
            InitializeComponent();
            txtBoxes[0] = txtCardNumber;
            txtBoxes[1] = txtNameOnCard;
            txtBoxes[2] = txtMMYY;
            txtBoxes[3] = txtCVC;
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            ValidateForm();
            if(string.IsNullOrWhiteSpace(ValiCardNumber.Text)&&
                string.IsNullOrWhiteSpace(ValiCVC.Text) &&
                string.IsNullOrWhiteSpace(ValiMMYY.Text) &&
                string.IsNullOrWhiteSpace(ValiNameOnCard.Text))
            {
                //To Be Save to a Database
                Payment ComfirmPayment = new Payment
                {
                    Created = DateTime.Now,
                    CardNumber = Int32.Parse(txtCardNumber.Text),
                    CVC = Int32.Parse(txtCVC.Text),
                    ExpirationOfCard = DateTime.Parse(txtMMYY.Text),
                    NameONCard = txtNameOnCard.Text
                };
            }
        }

        private void FrmRestaurantPayment_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < PlaceHolders.Length; i++)
            {
                txtBoxes[i].Text = PlaceHolders[i];
                txtBoxes[i].ForeColor = Color.Gray;
            }
        }
        #region PlaceHolderMethods
        private void txtCardNumber_Enter(object sender, EventArgs e)
        {
            if(txtCardNumber.Text == PlaceHolders[0])
            { 
                txtCardNumber.ForeColor = Color.Black;
                txtCardNumber.Text = "";
            }
        }

        private void txtCardNumber_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtCardNumber.Text))
            {
                txtCardNumber.Text = PlaceHolders[0];
                txtCardNumber.ForeColor= Color.Gray;
            }
        }

        private void txtNameOnCard_Enter(object sender, EventArgs e)
        {
            if(txtNameOnCard.Text == PlaceHolders[1])
            {
                txtNameOnCard.Text = "";
                txtNameOnCard.ForeColor = Color.Black;
            }
        }

        private void txtNameOnCard_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtNameOnCard.Text))
            {
                txtNameOnCard.Text = PlaceHolders[1];
                txtNameOnCard.ForeColor= Color.Gray;
            }
        }

        private void txtMMYY_Enter(object sender, EventArgs e)
        {
            if(txtMMYY.Text == PlaceHolders[2])
            {
                txtMMYY.Text = "";
                txtMMYY.ForeColor = Color.Black;
            }
        }

        private void txtMMYY_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtMMYY.Text))
            {
                txtMMYY.Text= PlaceHolders[2];
                txtMMYY.ForeColor= Color.Gray;
            }
        }

        private void txtCVC_Enter(object sender, EventArgs e)
        {
            if(txtCVC.Text == PlaceHolders[3])
            {
                txtCVC.Text = "";
                txtCVC.ForeColor = Color.Black;
            }
        }

        private void txtCVC_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtCVC.Text))
            {
                txtCVC.Text= PlaceHolders[3];
                txtCVC.ForeColor= Color.Gray;
            }
        }
        #endregion
        #region TextBox_Validation_Methods
        private void ValidateForm()
        {
            if (!IsValCardNumber(txtCardNumber.Text))
            {
                ValiCardNumber.Text = "Not Valid";
                ValiCardNumber.ForeColor = Color.Red;
            }
            else
                ValiCardNumber.Text = "";

            if (!IsValMMYY(txtMMYY.Text))
            {
                ValiMMYY.Text = "MM/YY";
                ValiMMYY.ForeColor = Color.Red;
            }
            else
                ValiMMYY.Text = "";

            if (!IsValCVC(txtCVC.Text))
            {
                ValiCVC.Text = "Not Valid";
                ValiCVC.ForeColor = Color.Red;
            }
            else
                ValiCVC.Text = "";

            if (!IsValNameOnCard(txtNameOnCard.Text))
            {
                ValiNameOnCard.Text = "Not Valid";
                ValiNameOnCard.ForeColor = Color.Red;
            }
            else
                ValiNameOnCard.Text = "";
        }



      

        private bool IsValNameOnCard(String NameOnCard)
        {
            return NameOnCard.Length > 3
                && NameOnCard != PlaceHolders[1];
        }

        private bool IsValCVC(String CVC)
        {
            try
            {
                int.Parse(CVC);
                if (CVC.Length == 3)
                    return true;
                else
                    throw new Exception();
            }
            catch { return false; }
        }


        private bool IsValCardNumber(String CardNumber)
        {
            return Regex.IsMatch(CardNumber,
                @"^\s*(\d{12}|(\d{14})|(\d{16})|(\d{18})|(\d{19}))\s*$");
        }


        private bool IsValMMYY(String MMYY)
        {
            return Regex.IsMatch(MMYY, @"^\s*(\d{2}/\d{2})\s*$");
        }
        #endregion
    }
}
