namespace CasinoBeta
{
    partial class frmKartyaMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKartyaMenu));
            this.btnKijelentkez = new System.Windows.Forms.Button();
            this.btnFomenu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAktiv = new System.Windows.Forms.Label();
            this.lbKetesely = new System.Windows.Forms.ListBox();
            this.lbBlackJack = new System.Windows.Forms.ListBox();
            this.btnKetesely = new System.Windows.Forms.Button();
            this.btnBlackJack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKijelentkez
            // 
            this.btnKijelentkez.Location = new System.Drawing.Point(625, 51);
            this.btnKijelentkez.Name = "btnKijelentkez";
            this.btnKijelentkez.Size = new System.Drawing.Size(248, 75);
            this.btnKijelentkez.TabIndex = 20;
            this.btnKijelentkez.Text = "Kijelentkezés";
            this.btnKijelentkez.UseVisualStyleBackColor = true;
            this.btnKijelentkez.Click += new System.EventHandler(this.btnKijelentkez_Click);
            // 
            // btnFomenu
            // 
            this.btnFomenu.Location = new System.Drawing.Point(625, 134);
            this.btnFomenu.Name = "btnFomenu";
            this.btnFomenu.Size = new System.Drawing.Size(248, 75);
            this.btnFomenu.TabIndex = 19;
            this.btnFomenu.Text = "Vissza a Főmenübe";
            this.btnFomenu.UseVisualStyleBackColor = true;
            this.btnFomenu.Click += new System.EventHandler(this.btnFomenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CasinoBeta.Properties.Resources.KockaHatter;
            this.pictureBox1.Image = global::CasinoBeta.Properties.Resources.palm_tree;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(881, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // lblAktiv
            // 
            this.lblAktiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAktiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblAktiv.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAktiv.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAktiv.Location = new System.Drawing.Point(625, 9);
            this.lblAktiv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAktiv.Name = "lblAktiv";
            this.lblAktiv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAktiv.Size = new System.Drawing.Size(248, 32);
            this.lblAktiv.TabIndex = 17;
            this.lblAktiv.Text = "Aktív felhasználó: aktív kredit";
            this.lblAktiv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbKetesely
            // 
            this.lbKetesely.FormattingEnabled = true;
            this.lbKetesely.ItemHeight = 20;
            this.lbKetesely.Location = new System.Drawing.Point(318, 95);
            this.lbKetesely.Name = "lbKetesely";
            this.lbKetesely.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbKetesely.Size = new System.Drawing.Size(300, 204);
            this.lbKetesely.TabIndex = 24;
            // 
            // lbBlackJack
            // 
            this.lbBlackJack.FormattingEnabled = true;
            this.lbBlackJack.ItemHeight = 20;
            this.lbBlackJack.Location = new System.Drawing.Point(12, 93);
            this.lbBlackJack.MultiColumn = true;
            this.lbBlackJack.Name = "lbBlackJack";
            this.lbBlackJack.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbBlackJack.Size = new System.Drawing.Size(300, 204);
            this.lbBlackJack.TabIndex = 23;
            // 
            // btnKetesely
            // 
            this.btnKetesely.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnKetesely.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnKetesely.Location = new System.Drawing.Point(318, 12);
            this.btnKetesely.Name = "btnKetesely";
            this.btnKetesely.Size = new System.Drawing.Size(300, 75);
            this.btnKetesely.TabIndex = 22;
            this.btnKetesely.Text = "Kétesély";
            this.btnKetesely.UseVisualStyleBackColor = true;
            this.btnKetesely.Click += new System.EventHandler(this.btnKetesely_Click);
            // 
            // btnBlackJack
            // 
            this.btnBlackJack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnBlackJack.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBlackJack.Location = new System.Drawing.Point(12, 12);
            this.btnBlackJack.Name = "btnBlackJack";
            this.btnBlackJack.Size = new System.Drawing.Size(300, 75);
            this.btnBlackJack.TabIndex = 21;
            this.btnBlackJack.Text = "BlackJack";
            this.btnBlackJack.UseVisualStyleBackColor = true;
            this.btnBlackJack.Click += new System.EventHandler(this.btnBlackJack_Click);
            // 
            // frmKartyaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CasinoBeta.Properties.Resources.kartyahatterproba1;
            this.ClientSize = new System.Drawing.Size(923, 317);
            this.Controls.Add(this.lbKetesely);
            this.Controls.Add(this.lbBlackJack);
            this.Controls.Add(this.btnKetesely);
            this.Controls.Add(this.btnBlackJack);
            this.Controls.Add(this.btnKijelentkez);
            this.Controls.Add(this.btnFomenu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAktiv);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmKartyaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Palma Casino - Kártyajátékok";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKijelentkez;
        private System.Windows.Forms.Button btnFomenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAktiv;
        private System.Windows.Forms.ListBox lbKetesely;
        private System.Windows.Forms.ListBox lbBlackJack;
        private System.Windows.Forms.Button btnKetesely;
        private System.Windows.Forms.Button btnBlackJack;
    }
}