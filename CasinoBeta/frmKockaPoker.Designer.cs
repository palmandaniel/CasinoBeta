namespace CasinoBeta
{
    partial class frmKockaPoker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKockaPoker));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAktiv = new System.Windows.Forms.Label();
            this.btnBefizet = new System.Windows.Forms.Button();
            this.cbTetkivalaszt = new System.Windows.Forms.ComboBox();
            this.lblTetkivalaszt = new System.Windows.Forms.Label();
            this.lbErtekel = new System.Windows.Forms.ListBox();
            this.pbJ5 = new System.Windows.Forms.PictureBox();
            this.pbJ4 = new System.Windows.Forms.PictureBox();
            this.pbJ3 = new System.Windows.Forms.PictureBox();
            this.pbJ2 = new System.Windows.Forms.PictureBox();
            this.pbJ1 = new System.Windows.Forms.PictureBox();
            this.lblJatekos = new System.Windows.Forms.Label();
            this.pbG5 = new System.Windows.Forms.PictureBox();
            this.pbG4 = new System.Windows.Forms.PictureBox();
            this.pbG3 = new System.Windows.Forms.PictureBox();
            this.pbG2 = new System.Windows.Forms.PictureBox();
            this.pbG1 = new System.Windows.Forms.PictureBox();
            this.lblGep = new System.Windows.Forms.Label();
            this.lblRelacio = new System.Windows.Forms.Label();
            this.btnVissza = new System.Windows.Forms.Button();
            this.btnUjjatek = new System.Windows.Forms.Button();
            this.btnDobas = new System.Windows.Forms.Button();
            this.lblJatekosErteke = new System.Windows.Forms.Label();
            this.lblGepErteke = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJ5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJ4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJ3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJ2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJ1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbG5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbG4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbG3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbG2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbG1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CasinoBeta.Properties.Resources.alapbackground;
            this.pictureBox1.Image = global::CasinoBeta.Properties.Resources.palm_tree;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(769, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // lblAktiv
            // 
            this.lblAktiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAktiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblAktiv.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAktiv.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAktiv.Location = new System.Drawing.Point(515, 9);
            this.lblAktiv.Name = "lblAktiv";
            this.lblAktiv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAktiv.Size = new System.Drawing.Size(248, 32);
            this.lblAktiv.TabIndex = 39;
            this.lblAktiv.Text = "Aktív felhasználó: aktív kredit";
            this.lblAktiv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnBefizet
            // 
            this.btnBefizet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btnBefizet.Location = new System.Drawing.Point(162, 39);
            this.btnBefizet.Name = "btnBefizet";
            this.btnBefizet.Size = new System.Drawing.Size(121, 37);
            this.btnBefizet.TabIndex = 1;
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
            this.cbTetkivalaszt.TabIndex = 0;
            // 
            // lblTetkivalaszt
            // 
            this.lblTetkivalaszt.AutoSize = true;
            this.lblTetkivalaszt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTetkivalaszt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblTetkivalaszt.Location = new System.Drawing.Point(12, 9);
            this.lblTetkivalaszt.Name = "lblTetkivalaszt";
            this.lblTetkivalaszt.Size = new System.Drawing.Size(146, 26);
            this.lblTetkivalaszt.TabIndex = 63;
            this.lblTetkivalaszt.Text = "Tét kiválasztása:";
            // 
            // lbErtekel
            // 
            this.lbErtekel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbErtekel.FormattingEnabled = true;
            this.lbErtekel.ItemHeight = 16;
            this.lbErtekel.Location = new System.Drawing.Point(306, 39);
            this.lbErtekel.Name = "lbErtekel";
            this.lbErtekel.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbErtekel.Size = new System.Drawing.Size(199, 148);
            this.lbErtekel.TabIndex = 83;
            // 
            // pbJ5
            // 
            this.pbJ5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))), ((int)(((byte)(7)))));
            this.pbJ5.Location = new System.Drawing.Point(213, 321);
            this.pbJ5.Name = "pbJ5";
            this.pbJ5.Size = new System.Drawing.Size(64, 64);
            this.pbJ5.TabIndex = 89;
            this.pbJ5.TabStop = false;
            // 
            // pbJ4
            // 
            this.pbJ4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))), ((int)(((byte)(7)))));
            this.pbJ4.Location = new System.Drawing.Point(43, 321);
            this.pbJ4.Name = "pbJ4";
            this.pbJ4.Size = new System.Drawing.Size(64, 64);
            this.pbJ4.TabIndex = 88;
            this.pbJ4.TabStop = false;
            // 
            // pbJ3
            // 
            this.pbJ3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))), ((int)(((byte)(7)))));
            this.pbJ3.Image = global::CasinoBeta.Properties.Resources.defaultKocka;
            this.pbJ3.Location = new System.Drawing.Point(132, 251);
            this.pbJ3.Name = "pbJ3";
            this.pbJ3.Size = new System.Drawing.Size(64, 64);
            this.pbJ3.TabIndex = 87;
            this.pbJ3.TabStop = false;
            // 
            // pbJ2
            // 
            this.pbJ2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))), ((int)(((byte)(7)))));
            this.pbJ2.Location = new System.Drawing.Point(213, 193);
            this.pbJ2.Name = "pbJ2";
            this.pbJ2.Size = new System.Drawing.Size(64, 64);
            this.pbJ2.TabIndex = 86;
            this.pbJ2.TabStop = false;
            // 
            // pbJ1
            // 
            this.pbJ1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))), ((int)(((byte)(7)))));
            this.pbJ1.Location = new System.Drawing.Point(43, 193);
            this.pbJ1.Name = "pbJ1";
            this.pbJ1.Size = new System.Drawing.Size(64, 64);
            this.pbJ1.TabIndex = 85;
            this.pbJ1.TabStop = false;
            // 
            // lblJatekos
            // 
            this.lblJatekos.AutoSize = true;
            this.lblJatekos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblJatekos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblJatekos.Location = new System.Drawing.Point(123, 155);
            this.lblJatekos.Name = "lblJatekos";
            this.lblJatekos.Size = new System.Drawing.Size(75, 26);
            this.lblJatekos.TabIndex = 84;
            this.lblJatekos.Text = "Játékos";
            this.lblJatekos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbG5
            // 
            this.pbG5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))), ((int)(((byte)(7)))));
            this.pbG5.Location = new System.Drawing.Point(709, 321);
            this.pbG5.Name = "pbG5";
            this.pbG5.Size = new System.Drawing.Size(64, 64);
            this.pbG5.TabIndex = 95;
            this.pbG5.TabStop = false;
            // 
            // pbG4
            // 
            this.pbG4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))), ((int)(((byte)(7)))));
            this.pbG4.Location = new System.Drawing.Point(539, 321);
            this.pbG4.Name = "pbG4";
            this.pbG4.Size = new System.Drawing.Size(64, 64);
            this.pbG4.TabIndex = 94;
            this.pbG4.TabStop = false;
            // 
            // pbG3
            // 
            this.pbG3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))), ((int)(((byte)(7)))));
            this.pbG3.Image = global::CasinoBeta.Properties.Resources.defaultKocka;
            this.pbG3.Location = new System.Drawing.Point(628, 251);
            this.pbG3.Name = "pbG3";
            this.pbG3.Size = new System.Drawing.Size(64, 64);
            this.pbG3.TabIndex = 93;
            this.pbG3.TabStop = false;
            // 
            // pbG2
            // 
            this.pbG2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))), ((int)(((byte)(7)))));
            this.pbG2.Location = new System.Drawing.Point(709, 193);
            this.pbG2.Name = "pbG2";
            this.pbG2.Size = new System.Drawing.Size(64, 64);
            this.pbG2.TabIndex = 92;
            this.pbG2.TabStop = false;
            // 
            // pbG1
            // 
            this.pbG1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))), ((int)(((byte)(7)))));
            this.pbG1.Location = new System.Drawing.Point(539, 193);
            this.pbG1.Name = "pbG1";
            this.pbG1.Size = new System.Drawing.Size(64, 64);
            this.pbG1.TabIndex = 91;
            this.pbG1.TabStop = false;
            // 
            // lblGep
            // 
            this.lblGep.AutoSize = true;
            this.lblGep.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblGep.Location = new System.Drawing.Point(637, 164);
            this.lblGep.Name = "lblGep";
            this.lblGep.Size = new System.Drawing.Size(48, 26);
            this.lblGep.TabIndex = 90;
            this.lblGep.Text = "Gép";
            // 
            // lblRelacio
            // 
            this.lblRelacio.AutoSize = true;
            this.lblRelacio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))), ((int)(((byte)(7)))));
            this.lblRelacio.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.lblRelacio.Location = new System.Drawing.Point(376, 251);
            this.lblRelacio.Name = "lblRelacio";
            this.lblRelacio.Size = new System.Drawing.Size(59, 63);
            this.lblRelacio.TabIndex = 96;
            this.lblRelacio.Text = "=";
            // 
            // btnVissza
            // 
            this.btnVissza.Enabled = false;
            this.btnVissza.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btnVissza.Location = new System.Drawing.Point(698, 441);
            this.btnVissza.Name = "btnVissza";
            this.btnVissza.Size = new System.Drawing.Size(100, 37);
            this.btnVissza.TabIndex = 4;
            this.btnVissza.Text = "Vissza";
            this.btnVissza.UseVisualStyleBackColor = true;
            this.btnVissza.Click += new System.EventHandler(this.btnVissza_Click);
            // 
            // btnUjjatek
            // 
            this.btnUjjatek.Enabled = false;
            this.btnUjjatek.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btnUjjatek.Location = new System.Drawing.Point(592, 441);
            this.btnUjjatek.Name = "btnUjjatek";
            this.btnUjjatek.Size = new System.Drawing.Size(100, 37);
            this.btnUjjatek.TabIndex = 3;
            this.btnUjjatek.Text = "Új játék";
            this.btnUjjatek.UseVisualStyleBackColor = true;
            this.btnUjjatek.Click += new System.EventHandler(this.btnUjjatek_Click);
            // 
            // btnDobas
            // 
            this.btnDobas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btnDobas.Location = new System.Drawing.Point(14, 441);
            this.btnDobas.Name = "btnDobas";
            this.btnDobas.Size = new System.Drawing.Size(144, 37);
            this.btnDobas.TabIndex = 2;
            this.btnDobas.Text = "Dobás";
            this.btnDobas.UseVisualStyleBackColor = true;
            this.btnDobas.Click += new System.EventHandler(this.btnDobas_Click);
            // 
            // lblJatekosErteke
            // 
            this.lblJatekosErteke.AutoSize = true;
            this.lblJatekosErteke.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblJatekosErteke.Location = new System.Drawing.Point(123, 404);
            this.lblJatekosErteke.Name = "lblJatekosErteke";
            this.lblJatekosErteke.Size = new System.Drawing.Size(116, 22);
            this.lblJatekosErteke.TabIndex = 100;
            this.lblJatekosErteke.Text = "Játékos értéke";
            // 
            // lblGepErteke
            // 
            this.lblGepErteke.AutoSize = true;
            this.lblGepErteke.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGepErteke.Location = new System.Drawing.Point(628, 404);
            this.lblGepErteke.Name = "lblGepErteke";
            this.lblGepErteke.Size = new System.Drawing.Size(93, 22);
            this.lblGepErteke.TabIndex = 101;
            this.lblGepErteke.Text = "Gép Értéke";
            // 
            // frmKockaPoker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CasinoBeta.Properties.Resources.KockaHatter;
            this.ClientSize = new System.Drawing.Size(811, 490);
            this.Controls.Add(this.lblGepErteke);
            this.Controls.Add(this.lblJatekosErteke);
            this.Controls.Add(this.btnVissza);
            this.Controls.Add(this.btnUjjatek);
            this.Controls.Add(this.btnDobas);
            this.Controls.Add(this.lblRelacio);
            this.Controls.Add(this.pbG5);
            this.Controls.Add(this.pbG4);
            this.Controls.Add(this.pbG3);
            this.Controls.Add(this.pbG2);
            this.Controls.Add(this.pbG1);
            this.Controls.Add(this.lblGep);
            this.Controls.Add(this.pbJ5);
            this.Controls.Add(this.pbJ4);
            this.Controls.Add(this.pbJ3);
            this.Controls.Add(this.pbJ2);
            this.Controls.Add(this.pbJ1);
            this.Controls.Add(this.lblJatekos);
            this.Controls.Add(this.lbErtekel);
            this.Controls.Add(this.btnBefizet);
            this.Controls.Add(this.cbTetkivalaszt);
            this.Controls.Add(this.lblTetkivalaszt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAktiv);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmKockaPoker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Palma Casino - Kockapóker";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJ5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJ4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJ3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJ2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJ1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbG5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbG4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbG3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbG2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbG1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAktiv;
        private System.Windows.Forms.Button btnBefizet;
        private System.Windows.Forms.ComboBox cbTetkivalaszt;
        private System.Windows.Forms.Label lblTetkivalaszt;
        private System.Windows.Forms.ListBox lbErtekel;
        private System.Windows.Forms.PictureBox pbJ5;
        private System.Windows.Forms.PictureBox pbJ4;
        private System.Windows.Forms.PictureBox pbJ3;
        private System.Windows.Forms.PictureBox pbJ2;
        private System.Windows.Forms.PictureBox pbJ1;
        private System.Windows.Forms.Label lblJatekos;
        private System.Windows.Forms.PictureBox pbG5;
        private System.Windows.Forms.PictureBox pbG4;
        private System.Windows.Forms.PictureBox pbG3;
        private System.Windows.Forms.PictureBox pbG2;
        private System.Windows.Forms.PictureBox pbG1;
        private System.Windows.Forms.Label lblGep;
        private System.Windows.Forms.Label lblRelacio;
        private System.Windows.Forms.Button btnVissza;
        private System.Windows.Forms.Button btnUjjatek;
        private System.Windows.Forms.Button btnDobas;
        private System.Windows.Forms.Label lblJatekosErteke;
        private System.Windows.Forms.Label lblGepErteke;
    }
}