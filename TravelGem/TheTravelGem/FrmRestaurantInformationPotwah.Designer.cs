
namespace TheTravelGem
{
    partial class FrmRestaurantInformationPotwah
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRestaurantInformationPotwah));
            this.imageListPotwah = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerPotwah = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnBooking = new System.Windows.Forms.Button();
            this.pnlPatwahLogo = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageListPotwah
            // 
            this.imageListPotwah.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListPotwah.ImageStream")));
            this.imageListPotwah.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListPotwah.Images.SetKeyName(0, "drj.jpg");
            this.imageListPotwah.Images.SetKeyName(1, "form.jpg");
            this.imageListPotwah.Images.SetKeyName(2, "french-food-1920x1080.jpg");
            this.imageListPotwah.Images.SetKeyName(3, "Hand-Luggage-Only-5-1.jpg");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(2, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1108, 458);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timerPotwah
            // 
            this.timerPotwah.Enabled = true;
            this.timerPotwah.Interval = 3000;
            this.timerPotwah.Tick += new System.EventHandler(this.timerPotwah_Tick_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 652);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(722, 325);
            this.label2.TabIndex = 2;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(781, 652);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 118);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(937, 652);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(130, 117);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(781, 800);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(130, 118);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(937, 800);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(130, 118);
            this.panel4.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(781, 975);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(288, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "more images";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // BtnBooking
            // 
            this.BtnBooking.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBooking.Location = new System.Drawing.Point(81, 1044);
            this.BtnBooking.Name = "BtnBooking";
            this.BtnBooking.Size = new System.Drawing.Size(310, 40);
            this.BtnBooking.TabIndex = 8;
            this.BtnBooking.Text = "Book Your Stay !";
            this.BtnBooking.UseVisualStyleBackColor = true;
            this.BtnBooking.Click += new System.EventHandler(this.BtnBooking_Click);
            // 
            // pnlPatwahLogo
            // 
            this.pnlPatwahLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlPatwahLogo.BackgroundImage")));
            this.pnlPatwahLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPatwahLogo.Location = new System.Drawing.Point(452, 472);
            this.pnlPatwahLogo.Name = "pnlPatwahLogo";
            this.pnlPatwahLogo.Size = new System.Drawing.Size(237, 152);
            this.pnlPatwahLogo.TabIndex = 9;
            // 
            // FrmRestaurantInformationPotwah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1114, 1191);
            this.Controls.Add(this.pnlPatwahLogo);
            this.Controls.Add(this.BtnBooking);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmRestaurantInformationPotwah";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Potwah";
            this.Load += new System.EventHandler(this.Potwah_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageListPotwah;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerPotwah;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnBooking;
        private System.Windows.Forms.Panel pnlPatwahLogo;
    }
}