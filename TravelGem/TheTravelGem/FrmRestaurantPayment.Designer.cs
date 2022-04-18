
namespace TheTravelGem
{
    partial class FrmRestaurantPayment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRestaurantPayment));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.txtNameOnCard = new System.Windows.Forms.TextBox();
            this.txtMMYY = new System.Windows.Forms.TextBox();
            this.txtCVC = new System.Windows.Forms.TextBox();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.ValiCardNumber = new System.Windows.Forms.Label();
            this.ValiNameOnCard = new System.Windows.Forms.Label();
            this.ValiMMYY = new System.Windows.Forms.Label();
            this.ValiCVC = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(155, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Confirm Your Payment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(157, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Please enter your payment details";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 614);
            this.panel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SlateGray;
            this.label3.Location = new System.Drawing.Point(25, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 43);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Font = new System.Drawing.Font("Times New Roman", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardNumber.Location = new System.Drawing.Point(160, 103);
            this.txtCardNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(285, 27);
            this.txtCardNumber.TabIndex = 3;
            this.txtCardNumber.Enter += new System.EventHandler(this.txtCardNumber_Enter);
            this.txtCardNumber.Leave += new System.EventHandler(this.txtCardNumber_Leave);
            // 
            // txtNameOnCard
            // 
            this.txtNameOnCard.Font = new System.Drawing.Font("Times New Roman", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameOnCard.Location = new System.Drawing.Point(160, 154);
            this.txtNameOnCard.Margin = new System.Windows.Forms.Padding(2);
            this.txtNameOnCard.Name = "txtNameOnCard";
            this.txtNameOnCard.Size = new System.Drawing.Size(285, 27);
            this.txtNameOnCard.TabIndex = 4;
            this.txtNameOnCard.Enter += new System.EventHandler(this.txtNameOnCard_Enter);
            this.txtNameOnCard.Leave += new System.EventHandler(this.txtNameOnCard_Leave);
            // 
            // txtMMYY
            // 
            this.txtMMYY.Font = new System.Drawing.Font("Times New Roman", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMMYY.Location = new System.Drawing.Point(160, 204);
            this.txtMMYY.Margin = new System.Windows.Forms.Padding(2);
            this.txtMMYY.Name = "txtMMYY";
            this.txtMMYY.Size = new System.Drawing.Size(67, 27);
            this.txtMMYY.TabIndex = 5;
            this.txtMMYY.Enter += new System.EventHandler(this.txtMMYY_Enter);
            this.txtMMYY.Leave += new System.EventHandler(this.txtMMYY_Leave);
            // 
            // txtCVC
            // 
            this.txtCVC.Font = new System.Drawing.Font("Times New Roman", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCVC.Location = new System.Drawing.Point(241, 204);
            this.txtCVC.Margin = new System.Windows.Forms.Padding(2);
            this.txtCVC.Name = "txtCVC";
            this.txtCVC.Size = new System.Drawing.Size(67, 27);
            this.txtCVC.TabIndex = 6;
            this.txtCVC.Enter += new System.EventHandler(this.txtCVC_Enter);
            this.txtCVC.Leave += new System.EventHandler(this.txtCVC_Leave);
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnConfirm.Font = new System.Drawing.Font("Times New Roman", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirm.Location = new System.Drawing.Point(161, 258);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(163, 29);
            this.BtnConfirm.TabIndex = 7;
            this.BtnConfirm.Text = "Confirm";
            this.BtnConfirm.UseVisualStyleBackColor = false;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // ValiCardNumber
            // 
            this.ValiCardNumber.AutoSize = true;
            this.ValiCardNumber.Font = new System.Drawing.Font("Times New Roman", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValiCardNumber.ForeColor = System.Drawing.Color.Red;
            this.ValiCardNumber.Location = new System.Drawing.Point(161, 132);
            this.ValiCardNumber.Name = "ValiCardNumber";
            this.ValiCardNumber.Size = new System.Drawing.Size(0, 19);
            this.ValiCardNumber.TabIndex = 8;
            // 
            // ValiNameOnCard
            // 
            this.ValiNameOnCard.AutoSize = true;
            this.ValiNameOnCard.Font = new System.Drawing.Font("Times New Roman", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValiNameOnCard.ForeColor = System.Drawing.Color.Red;
            this.ValiNameOnCard.Location = new System.Drawing.Point(162, 183);
            this.ValiNameOnCard.Name = "ValiNameOnCard";
            this.ValiNameOnCard.Size = new System.Drawing.Size(0, 19);
            this.ValiNameOnCard.TabIndex = 9;
            // 
            // ValiMMYY
            // 
            this.ValiMMYY.AutoSize = true;
            this.ValiMMYY.Font = new System.Drawing.Font("Times New Roman", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValiMMYY.ForeColor = System.Drawing.Color.Red;
            this.ValiMMYY.Location = new System.Drawing.Point(162, 233);
            this.ValiMMYY.Name = "ValiMMYY";
            this.ValiMMYY.Size = new System.Drawing.Size(0, 19);
            this.ValiMMYY.TabIndex = 10;
            // 
            // ValiCVC
            // 
            this.ValiCVC.AutoSize = true;
            this.ValiCVC.Font = new System.Drawing.Font("Times New Roman", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValiCVC.ForeColor = System.Drawing.Color.Red;
            this.ValiCVC.Location = new System.Drawing.Point(246, 233);
            this.ValiCVC.Name = "ValiCVC";
            this.ValiCVC.Size = new System.Drawing.Size(0, 19);
            this.ValiCVC.TabIndex = 11;
            // 
            // FrmRestaurantPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(873, 615);
            this.Controls.Add(this.ValiCVC);
            this.Controls.Add(this.ValiMMYY);
            this.Controls.Add(this.ValiNameOnCard);
            this.Controls.Add(this.ValiCardNumber);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.txtCVC);
            this.Controls.Add(this.txtMMYY);
            this.Controls.Add(this.txtNameOnCard);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmRestaurantPayment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.FrmRestaurantPayment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.TextBox txtNameOnCard;
        private System.Windows.Forms.TextBox txtMMYY;
        private System.Windows.Forms.TextBox txtCVC;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.Label ValiCardNumber;
        private System.Windows.Forms.Label ValiNameOnCard;
        private System.Windows.Forms.Label ValiMMYY;
        private System.Windows.Forms.Label ValiCVC;
    }
}