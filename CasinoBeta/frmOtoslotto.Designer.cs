namespace CasinoBeta
{
    partial class frmOtoslotto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOtoslotto));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAktiv = new System.Windows.Forms.Label();
            this.lblTetkivalaszt = new System.Windows.Forms.Label();
            this.cbTetkivalaszt = new System.Windows.Forms.ComboBox();
            this.btnBefizet = new System.Windows.Forms.Button();
            this.btnMegjatszom = new System.Windows.Forms.Button();
            this.tbt1 = new System.Windows.Forms.TextBox();
            this.tbt2 = new System.Windows.Forms.TextBox();
            this.tbt3 = new System.Windows.Forms.TextBox();
            this.tbt4 = new System.Windows.Forms.TextBox();
            this.tbt5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbs5 = new System.Windows.Forms.TextBox();
            this.tbs4 = new System.Windows.Forms.TextBox();
            this.tbs3 = new System.Windows.Forms.TextBox();
            this.tbs2 = new System.Windows.Forms.TextBox();
            this.tbs1 = new System.Windows.Forms.TextBox();
            this.lbErtekel = new System.Windows.Forms.ListBox();
            this.btnUjjatek = new System.Windows.Forms.Button();
            this.btnVissza = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CasinoBeta.Properties.Resources.alapbackground;
            this.pictureBox1.Image = global::CasinoBeta.Properties.Resources.palm_tree;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(650, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // lblAktiv
            // 
            this.lblAktiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAktiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblAktiv.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAktiv.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAktiv.Location = new System.Drawing.Point(396, 21);
            this.lblAktiv.Name = "lblAktiv";
            this.lblAktiv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAktiv.Size = new System.Drawing.Size(248, 32);
            this.lblAktiv.TabIndex = 11;
            this.lblAktiv.Text = "Aktív felhasználó: aktív kredit";
            this.lblAktiv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTetkivalaszt
            // 
            this.lblTetkivalaszt.AutoSize = true;
            this.lblTetkivalaszt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblTetkivalaszt.Location = new System.Drawing.Point(12, 21);
            this.lblTetkivalaszt.Name = "lblTetkivalaszt";
            this.lblTetkivalaszt.Size = new System.Drawing.Size(144, 24);
            this.lblTetkivalaszt.TabIndex = 13;
            this.lblTetkivalaszt.Text = "Tét kiválasztása:";
            // 
            // cbTetkivalaszt
            // 
            this.cbTetkivalaszt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbTetkivalaszt.FormattingEnabled = true;
            this.cbTetkivalaszt.Location = new System.Drawing.Point(162, 21);
            this.cbTetkivalaszt.Name = "cbTetkivalaszt";
            this.cbTetkivalaszt.Size = new System.Drawing.Size(121, 24);
            this.cbTetkivalaszt.TabIndex = 15;
            // 
            // btnBefizet
            // 
            this.btnBefizet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btnBefizet.Location = new System.Drawing.Point(12, 48);
            this.btnBefizet.Name = "btnBefizet";
            this.btnBefizet.Size = new System.Drawing.Size(144, 37);
            this.btnBefizet.TabIndex = 16;
            this.btnBefizet.Text = "Befizet";
            this.btnBefizet.UseVisualStyleBackColor = true;
            this.btnBefizet.Click += new System.EventHandler(this.btnBefizet_Click);
            // 
            // btnMegjatszom
            // 
            this.btnMegjatszom.Enabled = false;
            this.btnMegjatszom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btnMegjatszom.Location = new System.Drawing.Point(234, 222);
            this.btnMegjatszom.Name = "btnMegjatszom";
            this.btnMegjatszom.Size = new System.Drawing.Size(144, 37);
            this.btnMegjatszom.TabIndex = 17;
            this.btnMegjatszom.Text = "Megjátszom";
            this.btnMegjatszom.UseVisualStyleBackColor = true;
            this.btnMegjatszom.Click += new System.EventHandler(this.btnMegjatszom_Click);
            // 
            // tbt1
            // 
            this.tbt1.Enabled = false;
            this.tbt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.tbt1.Location = new System.Drawing.Point(12, 137);
            this.tbt1.MaxLength = 2;
            this.tbt1.Name = "tbt1";
            this.tbt1.Size = new System.Drawing.Size(68, 68);
            this.tbt1.TabIndex = 18;
            // 
            // tbt2
            // 
            this.tbt2.Enabled = false;
            this.tbt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.tbt2.Location = new System.Drawing.Point(88, 137);
            this.tbt2.Name = "tbt2";
            this.tbt2.Size = new System.Drawing.Size(68, 68);
            this.tbt2.TabIndex = 19;
            // 
            // tbt3
            // 
            this.tbt3.Enabled = false;
            this.tbt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.tbt3.Location = new System.Drawing.Point(162, 137);
            this.tbt3.Name = "tbt3";
            this.tbt3.Size = new System.Drawing.Size(68, 68);
            this.tbt3.TabIndex = 20;
            // 
            // tbt4
            // 
            this.tbt4.Enabled = false;
            this.tbt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.tbt4.Location = new System.Drawing.Point(236, 137);
            this.tbt4.Name = "tbt4";
            this.tbt4.Size = new System.Drawing.Size(68, 68);
            this.tbt4.TabIndex = 21;
            // 
            // tbt5
            // 
            this.tbt5.Enabled = false;
            this.tbt5.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.tbt5.Location = new System.Drawing.Point(310, 137);
            this.tbt5.Name = "tbt5";
            this.tbt5.Size = new System.Drawing.Size(68, 68);
            this.tbt5.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(12, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tippjeid:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(15, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Sorsolt számok:";
            // 
            // tbs5
            // 
            this.tbs5.Enabled = false;
            this.tbs5.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.tbs5.Location = new System.Drawing.Point(310, 294);
            this.tbs5.Name = "tbs5";
            this.tbs5.Size = new System.Drawing.Size(68, 68);
            this.tbs5.TabIndex = 29;
            // 
            // tbs4
            // 
            this.tbs4.Enabled = false;
            this.tbs4.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.tbs4.Location = new System.Drawing.Point(236, 294);
            this.tbs4.Name = "tbs4";
            this.tbs4.Size = new System.Drawing.Size(68, 68);
            this.tbs4.TabIndex = 28;
            // 
            // tbs3
            // 
            this.tbs3.Enabled = false;
            this.tbs3.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.tbs3.Location = new System.Drawing.Point(162, 294);
            this.tbs3.Name = "tbs3";
            this.tbs3.Size = new System.Drawing.Size(68, 68);
            this.tbs3.TabIndex = 27;
            // 
            // tbs2
            // 
            this.tbs2.Enabled = false;
            this.tbs2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.tbs2.Location = new System.Drawing.Point(88, 294);
            this.tbs2.Name = "tbs2";
            this.tbs2.Size = new System.Drawing.Size(68, 68);
            this.tbs2.TabIndex = 26;
            // 
            // tbs1
            // 
            this.tbs1.Enabled = false;
            this.tbs1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.tbs1.Location = new System.Drawing.Point(12, 294);
            this.tbs1.Name = "tbs1";
            this.tbs1.Size = new System.Drawing.Size(68, 68);
            this.tbs1.TabIndex = 25;
            // 
            // lbErtekel
            // 
            this.lbErtekel.FormattingEnabled = true;
            this.lbErtekel.Location = new System.Drawing.Point(468, 66);
            this.lbErtekel.Name = "lbErtekel";
            this.lbErtekel.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbErtekel.Size = new System.Drawing.Size(223, 238);
            this.lbErtekel.TabIndex = 30;
            // 
            // btnUjjatek
            // 
            this.btnUjjatek.Enabled = false;
            this.btnUjjatek.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btnUjjatek.Location = new System.Drawing.Point(468, 320);
            this.btnUjjatek.Name = "btnUjjatek";
            this.btnUjjatek.Size = new System.Drawing.Size(100, 37);
            this.btnUjjatek.TabIndex = 31;
            this.btnUjjatek.Text = "Új játék";
            this.btnUjjatek.UseVisualStyleBackColor = true;
            this.btnUjjatek.Click += new System.EventHandler(this.btnUjjatek_Click);
            // 
            // btnVissza
            // 
            this.btnVissza.Enabled = false;
            this.btnVissza.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btnVissza.Location = new System.Drawing.Point(591, 320);
            this.btnVissza.Name = "btnVissza";
            this.btnVissza.Size = new System.Drawing.Size(100, 37);
            this.btnVissza.TabIndex = 32;
            this.btnVissza.Text = "Vissza";
            this.btnVissza.UseVisualStyleBackColor = true;
            this.btnVissza.Click += new System.EventHandler(this.btnVissza_Click_1);
            // 
            // frmOtoslotto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CasinoBeta.Properties.Resources.lottohatterproba1;
            this.ClientSize = new System.Drawing.Size(711, 378);
            this.Controls.Add(this.btnVissza);
            this.Controls.Add(this.btnUjjatek);
            this.Controls.Add(this.lbErtekel);
            this.Controls.Add(this.tbs5);
            this.Controls.Add(this.tbs4);
            this.Controls.Add(this.tbs3);
            this.Controls.Add(this.tbs2);
            this.Controls.Add(this.tbs1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbt5);
            this.Controls.Add(this.tbt4);
            this.Controls.Add(this.tbt3);
            this.Controls.Add(this.tbt2);
            this.Controls.Add(this.tbt1);
            this.Controls.Add(this.btnMegjatszom);
            this.Controls.Add(this.btnBefizet);
            this.Controls.Add(this.cbTetkivalaszt);
            this.Controls.Add(this.lblTetkivalaszt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAktiv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmOtoslotto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Palma Casino - Ötöslottó";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAktiv;
        private System.Windows.Forms.Label lblTetkivalaszt;
        private System.Windows.Forms.ComboBox cbTetkivalaszt;
        private System.Windows.Forms.Button btnBefizet;
        private System.Windows.Forms.Button btnMegjatszom;
        private System.Windows.Forms.TextBox tbt1;
        private System.Windows.Forms.TextBox tbt2;
        private System.Windows.Forms.TextBox tbt3;
        private System.Windows.Forms.TextBox tbt4;
        private System.Windows.Forms.TextBox tbt5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbs5;
        private System.Windows.Forms.TextBox tbs4;
        private System.Windows.Forms.TextBox tbs3;
        private System.Windows.Forms.TextBox tbs2;
        private System.Windows.Forms.TextBox tbs1;
        private System.Windows.Forms.ListBox lbErtekel;
        private System.Windows.Forms.Button btnUjjatek;
        private System.Windows.Forms.Button btnVissza;
    }
}