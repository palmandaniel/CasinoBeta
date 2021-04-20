namespace CasinoBeta
{
    partial class frmKeteselyKartya
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKeteselyKartya));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAktiv = new System.Windows.Forms.Label();
            this.lbErtekel = new System.Windows.Forms.ListBox();
            this.btnBefizet = new System.Windows.Forms.Button();
            this.cbTetkivalaszt = new System.Windows.Forms.ComboBox();
            this.lblTetkivalaszt = new System.Windows.Forms.Label();
            this.btnVissza = new System.Windows.Forms.Button();
            this.btnUjjatek = new System.Windows.Forms.Button();
            this.btnFekete = new System.Windows.Forms.Button();
            this.btnPiros = new System.Windows.Forms.Button();
            this.btnMegallok = new System.Windows.Forms.Button();
            this.pbPakli = new System.Windows.Forms.PictureBox();
            this.pbO1 = new System.Windows.Forms.PictureBox();
            this.pbO2 = new System.Windows.Forms.PictureBox();
            this.pbO3 = new System.Windows.Forms.PictureBox();
            this.lblTemp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblKockaztatott = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPakli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbO1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbO2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbO3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CasinoBeta.Properties.Resources.alapbackground;
            this.pictureBox1.Image = global::CasinoBeta.Properties.Resources.palm_tree;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(660, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // lblAktiv
            // 
            this.lblAktiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAktiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblAktiv.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAktiv.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAktiv.Location = new System.Drawing.Point(406, 9);
            this.lblAktiv.Name = "lblAktiv";
            this.lblAktiv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAktiv.Size = new System.Drawing.Size(248, 32);
            this.lblAktiv.TabIndex = 41;
            this.lblAktiv.Text = "Aktív felhasználó: aktív kredit";
            this.lblAktiv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbErtekel
            // 
            this.lbErtekel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbErtekel.FormattingEnabled = true;
            this.lbErtekel.ItemHeight = 16;
            this.lbErtekel.Location = new System.Drawing.Point(490, 67);
            this.lbErtekel.Name = "lbErtekel";
            this.lbErtekel.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbErtekel.Size = new System.Drawing.Size(199, 148);
            this.lbErtekel.TabIndex = 144;
            // 
            // btnBefizet
            // 
            this.btnBefizet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btnBefizet.Location = new System.Drawing.Point(162, 39);
            this.btnBefizet.Name = "btnBefizet";
            this.btnBefizet.Size = new System.Drawing.Size(121, 37);
            this.btnBefizet.TabIndex = 143;
            this.btnBefizet.Text = "Befizet";
            this.btnBefizet.UseVisualStyleBackColor = true;
            this.btnBefizet.Click += new System.EventHandler(this.btnBefizet_Click);
            // 
            // cbTetkivalaszt
            // 
            this.cbTetkivalaszt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTetkivalaszt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbTetkivalaszt.FormattingEnabled = true;
            this.cbTetkivalaszt.Location = new System.Drawing.Point(162, 9);
            this.cbTetkivalaszt.Name = "cbTetkivalaszt";
            this.cbTetkivalaszt.Size = new System.Drawing.Size(121, 24);
            this.cbTetkivalaszt.TabIndex = 142;
            // 
            // lblTetkivalaszt
            // 
            this.lblTetkivalaszt.AutoSize = true;
            this.lblTetkivalaszt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTetkivalaszt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblTetkivalaszt.Location = new System.Drawing.Point(12, 9);
            this.lblTetkivalaszt.Name = "lblTetkivalaszt";
            this.lblTetkivalaszt.Size = new System.Drawing.Size(146, 26);
            this.lblTetkivalaszt.TabIndex = 141;
            this.lblTetkivalaszt.Text = "Tét kiválasztása:";
            // 
            // btnVissza
            // 
            this.btnVissza.Enabled = false;
            this.btnVissza.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btnVissza.Location = new System.Drawing.Point(570, 332);
            this.btnVissza.Name = "btnVissza";
            this.btnVissza.Size = new System.Drawing.Size(100, 37);
            this.btnVissza.TabIndex = 146;
            this.btnVissza.Text = "Vissza";
            this.btnVissza.UseVisualStyleBackColor = true;
            this.btnVissza.Click += new System.EventHandler(this.btnVissza_Click);
            // 
            // btnUjjatek
            // 
            this.btnUjjatek.Enabled = false;
            this.btnUjjatek.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btnUjjatek.Location = new System.Drawing.Point(464, 332);
            this.btnUjjatek.Name = "btnUjjatek";
            this.btnUjjatek.Size = new System.Drawing.Size(100, 37);
            this.btnUjjatek.TabIndex = 145;
            this.btnUjjatek.Text = "Új játék";
            this.btnUjjatek.UseVisualStyleBackColor = true;
            this.btnUjjatek.Click += new System.EventHandler(this.btnUjjatek_Click);
            // 
            // btnFekete
            // 
            this.btnFekete.Enabled = false;
            this.btnFekete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btnFekete.Location = new System.Drawing.Point(146, 332);
            this.btnFekete.Name = "btnFekete";
            this.btnFekete.Size = new System.Drawing.Size(100, 37);
            this.btnFekete.TabIndex = 148;
            this.btnFekete.Text = "Fekete";
            this.btnFekete.UseVisualStyleBackColor = true;
            this.btnFekete.Click += new System.EventHandler(this.btnFekete_Click);
            // 
            // btnPiros
            // 
            this.btnPiros.Enabled = false;
            this.btnPiros.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btnPiros.Location = new System.Drawing.Point(40, 332);
            this.btnPiros.Name = "btnPiros";
            this.btnPiros.Size = new System.Drawing.Size(100, 37);
            this.btnPiros.TabIndex = 147;
            this.btnPiros.Text = "Piros";
            this.btnPiros.UseVisualStyleBackColor = true;
            this.btnPiros.Click += new System.EventHandler(this.btnPiros_Click);
            // 
            // btnMegallok
            // 
            this.btnMegallok.Enabled = false;
            this.btnMegallok.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btnMegallok.Location = new System.Drawing.Point(293, 317);
            this.btnMegallok.Name = "btnMegallok";
            this.btnMegallok.Size = new System.Drawing.Size(123, 52);
            this.btnMegallok.TabIndex = 149;
            this.btnMegallok.Text = "Megállok";
            this.btnMegallok.UseVisualStyleBackColor = true;
            this.btnMegallok.Click += new System.EventHandler(this.btnMegallok_Click);
            // 
            // pbPakli
            // 
            this.pbPakli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))), ((int)(((byte)(7)))));
            this.pbPakli.Image = global::CasinoBeta.Properties.Resources.hatlap;
            this.pbPakli.Location = new System.Drawing.Point(40, 151);
            this.pbPakli.Name = "pbPakli";
            this.pbPakli.Size = new System.Drawing.Size(64, 64);
            this.pbPakli.TabIndex = 150;
            this.pbPakli.TabStop = false;
            // 
            // pbO1
            // 
            this.pbO1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))), ((int)(((byte)(7)))));
            this.pbO1.Image = global::CasinoBeta.Properties.Resources.hatlap;
            this.pbO1.Location = new System.Drawing.Point(162, 151);
            this.pbO1.Name = "pbO1";
            this.pbO1.Size = new System.Drawing.Size(64, 64);
            this.pbO1.TabIndex = 152;
            this.pbO1.TabStop = false;
            // 
            // pbO2
            // 
            this.pbO2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))), ((int)(((byte)(7)))));
            this.pbO2.Image = global::CasinoBeta.Properties.Resources.hatlap;
            this.pbO2.Location = new System.Drawing.Point(242, 151);
            this.pbO2.Name = "pbO2";
            this.pbO2.Size = new System.Drawing.Size(64, 64);
            this.pbO2.TabIndex = 153;
            this.pbO2.TabStop = false;
            // 
            // pbO3
            // 
            this.pbO3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))), ((int)(((byte)(7)))));
            this.pbO3.Image = global::CasinoBeta.Properties.Resources.hatlap;
            this.pbO3.Location = new System.Drawing.Point(312, 151);
            this.pbO3.Name = "pbO3";
            this.pbO3.Size = new System.Drawing.Size(64, 64);
            this.pbO3.TabIndex = 154;
            this.pbO3.TabStop = false;
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(0, 377);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(30, 13);
            this.lblTemp.TabIndex = 155;
            this.lblTemp.Text = "temp";
            this.lblTemp.Visible = false;
            this.lblTemp.TextChanged += new System.EventHandler(this.lblTemp_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(162, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 26);
            this.label1.TabIndex = 156;
            this.label1.Text = "Legutóbb húzott lap(ok):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(43, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 26);
            this.label2.TabIndex = 157;
            this.label2.Text = "Kövektező lap színe:";
            // 
            // lblKockaztatott
            // 
            this.lblKockaztatott.AutoSize = true;
            this.lblKockaztatott.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKockaztatott.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblKockaztatott.Location = new System.Drawing.Point(162, 227);
            this.lblKockaztatott.Name = "lblKockaztatott";
            this.lblKockaztatott.Size = new System.Drawing.Size(185, 26);
            this.lblKockaztatott.TabIndex = 158;
            this.lblKockaztatott.Text = "Kockáztatott összeg: ";
            // 
            // frmKeteselyKartya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CasinoBeta.Properties.Resources.kartyahatterproba1;
            this.ClientSize = new System.Drawing.Size(705, 389);
            this.Controls.Add(this.lblKockaztatott);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.pbO3);
            this.Controls.Add(this.pbO2);
            this.Controls.Add(this.pbO1);
            this.Controls.Add(this.pbPakli);
            this.Controls.Add(this.btnMegallok);
            this.Controls.Add(this.btnFekete);
            this.Controls.Add(this.btnPiros);
            this.Controls.Add(this.btnVissza);
            this.Controls.Add(this.btnUjjatek);
            this.Controls.Add(this.lbErtekel);
            this.Controls.Add(this.btnBefizet);
            this.Controls.Add(this.cbTetkivalaszt);
            this.Controls.Add(this.lblTetkivalaszt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAktiv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmKeteselyKartya";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Palma Casino - Kétesély kártyajáték";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPakli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbO1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbO2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbO3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAktiv;
        private System.Windows.Forms.ListBox lbErtekel;
        private System.Windows.Forms.Button btnBefizet;
        private System.Windows.Forms.ComboBox cbTetkivalaszt;
        private System.Windows.Forms.Label lblTetkivalaszt;
        private System.Windows.Forms.Button btnVissza;
        private System.Windows.Forms.Button btnUjjatek;
        private System.Windows.Forms.Button btnFekete;
        private System.Windows.Forms.Button btnPiros;
        private System.Windows.Forms.Button btnMegallok;
        private System.Windows.Forms.PictureBox pbPakli;
        private System.Windows.Forms.PictureBox pbO1;
        private System.Windows.Forms.PictureBox pbO2;
        private System.Windows.Forms.PictureBox pbO3;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKockaztatott;
    }
}