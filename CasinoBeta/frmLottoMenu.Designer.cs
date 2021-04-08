namespace CasinoBeta
{
    partial class frmLottoMenu
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
            this.btnOtoslotto = new System.Windows.Forms.Button();
            this.lbOtos = new System.Windows.Forms.ListBox();
            this.lbHatos = new System.Windows.Forms.ListBox();
            this.btnHatoslotto = new System.Windows.Forms.Button();
            this.lbHetes = new System.Windows.Forms.ListBox();
            this.btnHeteslotto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAktiv = new System.Windows.Forms.Label();
            this.btnFomenu = new System.Windows.Forms.Button();
            this.btnKijelentkez = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOtoslotto
            // 
            this.btnOtoslotto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnOtoslotto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOtoslotto.Location = new System.Drawing.Point(12, 92);
            this.btnOtoslotto.Name = "btnOtoslotto";
            this.btnOtoslotto.Size = new System.Drawing.Size(300, 75);
            this.btnOtoslotto.TabIndex = 2;
            this.btnOtoslotto.Text = "Ötöslottó";
            this.btnOtoslotto.UseVisualStyleBackColor = true;
            this.btnOtoslotto.Click += new System.EventHandler(this.btnOtoslotto_Click);
            // 
            // lbOtos
            // 
            this.lbOtos.Enabled = false;
            this.lbOtos.FormattingEnabled = true;
            this.lbOtos.ItemHeight = 20;
            this.lbOtos.Location = new System.Drawing.Point(12, 185);
            this.lbOtos.Name = "lbOtos";
            this.lbOtos.Size = new System.Drawing.Size(300, 204);
            this.lbOtos.TabIndex = 3;
            // 
            // lbHatos
            // 
            this.lbHatos.Enabled = false;
            this.lbHatos.FormattingEnabled = true;
            this.lbHatos.ItemHeight = 20;
            this.lbHatos.Location = new System.Drawing.Point(318, 185);
            this.lbHatos.Name = "lbHatos";
            this.lbHatos.Size = new System.Drawing.Size(300, 204);
            this.lbHatos.TabIndex = 5;
            // 
            // btnHatoslotto
            // 
            this.btnHatoslotto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnHatoslotto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnHatoslotto.Location = new System.Drawing.Point(318, 92);
            this.btnHatoslotto.Name = "btnHatoslotto";
            this.btnHatoslotto.Size = new System.Drawing.Size(300, 75);
            this.btnHatoslotto.TabIndex = 4;
            this.btnHatoslotto.Text = "Hatoslottó";
            this.btnHatoslotto.UseVisualStyleBackColor = true;
            this.btnHatoslotto.Click += new System.EventHandler(this.btnHatoslotto_Click);
            // 
            // lbHetes
            // 
            this.lbHetes.Enabled = false;
            this.lbHetes.FormattingEnabled = true;
            this.lbHetes.ItemHeight = 20;
            this.lbHetes.Location = new System.Drawing.Point(624, 185);
            this.lbHetes.Name = "lbHetes";
            this.lbHetes.Size = new System.Drawing.Size(300, 204);
            this.lbHetes.TabIndex = 7;
            // 
            // btnHeteslotto
            // 
            this.btnHeteslotto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnHeteslotto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnHeteslotto.Location = new System.Drawing.Point(624, 92);
            this.btnHeteslotto.Name = "btnHeteslotto";
            this.btnHeteslotto.Size = new System.Drawing.Size(300, 75);
            this.btnHeteslotto.TabIndex = 6;
            this.btnHeteslotto.Text = "Heteslottó";
            this.btnHeteslotto.UseVisualStyleBackColor = true;
            this.btnHeteslotto.Click += new System.EventHandler(this.btnHeteslotto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CasinoBeta.Properties.Resources.alapbackground;
            this.pictureBox1.Image = global::CasinoBeta.Properties.Resources.palm_tree;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(878, 18);
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
            this.lblAktiv.Location = new System.Drawing.Point(624, 16);
            this.lblAktiv.Name = "lblAktiv";
            this.lblAktiv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAktiv.Size = new System.Drawing.Size(248, 32);
            this.lblAktiv.TabIndex = 11;
            this.lblAktiv.Text = "Aktív felhasználó: aktív kredit";
            this.lblAktiv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnFomenu
            // 
            this.btnFomenu.Location = new System.Drawing.Point(12, 18);
            this.btnFomenu.Name = "btnFomenu";
            this.btnFomenu.Size = new System.Drawing.Size(300, 31);
            this.btnFomenu.TabIndex = 13;
            this.btnFomenu.Text = "Vissza a Főmenübe";
            this.btnFomenu.UseVisualStyleBackColor = true;
            this.btnFomenu.Click += new System.EventHandler(this.btnFomenu_Click);
            // 
            // btnKijelentkez
            // 
            this.btnKijelentkez.Location = new System.Drawing.Point(318, 18);
            this.btnKijelentkez.Name = "btnKijelentkez";
            this.btnKijelentkez.Size = new System.Drawing.Size(300, 31);
            this.btnKijelentkez.TabIndex = 14;
            this.btnKijelentkez.Text = "Kijelentkezés";
            this.btnKijelentkez.UseVisualStyleBackColor = true;
            this.btnKijelentkez.Click += new System.EventHandler(this.btnKijelentkez_Click);
            // 
            // frmLottoMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CasinoBeta.Properties.Resources.alapbackground;
            this.ClientSize = new System.Drawing.Size(938, 401);
            this.Controls.Add(this.btnKijelentkez);
            this.Controls.Add(this.btnFomenu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAktiv);
            this.Controls.Add(this.lbHetes);
            this.Controls.Add(this.btnHeteslotto);
            this.Controls.Add(this.lbHatos);
            this.Controls.Add(this.btnHatoslotto);
            this.Controls.Add(this.lbOtos);
            this.Controls.Add(this.btnOtoslotto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmLottoMenu";
            this.Text = "frmLottoMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOtoslotto;
        private System.Windows.Forms.ListBox lbOtos;
        private System.Windows.Forms.ListBox lbHatos;
        private System.Windows.Forms.Button btnHatoslotto;
        private System.Windows.Forms.ListBox lbHetes;
        private System.Windows.Forms.Button btnHeteslotto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAktiv;
        private System.Windows.Forms.Button btnFomenu;
        private System.Windows.Forms.Button btnKijelentkez;
    }
}