namespace CasinoBeta
{
    partial class frmFomenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFomenu));
            this.label1 = new System.Windows.Forms.Label();
            this.btnLottoMenu = new System.Windows.Forms.Button();
            this.btnKockaMenu = new System.Windows.Forms.Button();
            this.btnKartyaMenu = new System.Windows.Forms.Button();
            this.btnRulett = new System.Windows.Forms.Button();
            this.lbLottok = new System.Windows.Forms.ListBox();
            this.lbKockajatekok = new System.Windows.Forms.ListBox();
            this.lbKartyajatekok = new System.Windows.Forms.ListBox();
            this.lbRulett = new System.Windows.Forms.ListBox();
            this.lblAktiv = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnKijelentkez = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Name = "label1";
            // 
            // btnLottoMenu
            // 
            resources.ApplyResources(this.btnLottoMenu, "btnLottoMenu");
            this.btnLottoMenu.Name = "btnLottoMenu";
            this.btnLottoMenu.UseVisualStyleBackColor = true;
            this.btnLottoMenu.Click += new System.EventHandler(this.btnLottoMenu_Click);
            // 
            // btnKockaMenu
            // 
            resources.ApplyResources(this.btnKockaMenu, "btnKockaMenu");
            this.btnKockaMenu.Name = "btnKockaMenu";
            this.btnKockaMenu.UseVisualStyleBackColor = true;
            this.btnKockaMenu.Click += new System.EventHandler(this.btnKockaMenu_Click);
            // 
            // btnKartyaMenu
            // 
            resources.ApplyResources(this.btnKartyaMenu, "btnKartyaMenu");
            this.btnKartyaMenu.Name = "btnKartyaMenu";
            this.btnKartyaMenu.UseVisualStyleBackColor = true;
            this.btnKartyaMenu.Click += new System.EventHandler(this.btnKartyaMenu_Click);
            // 
            // btnRulett
            // 
            resources.ApplyResources(this.btnRulett, "btnRulett");
            this.btnRulett.Name = "btnRulett";
            this.btnRulett.UseVisualStyleBackColor = true;
            this.btnRulett.Click += new System.EventHandler(this.btnRulett_Click);
            // 
            // lbLottok
            // 
            resources.ApplyResources(this.lbLottok, "lbLottok");
            this.lbLottok.Name = "lbLottok";
            // 
            // lbKockajatekok
            // 
            resources.ApplyResources(this.lbKockajatekok, "lbKockajatekok");
            this.lbKockajatekok.Name = "lbKockajatekok";
            // 
            // lbKartyajatekok
            // 
            resources.ApplyResources(this.lbKartyajatekok, "lbKartyajatekok");
            this.lbKartyajatekok.Name = "lbKartyajatekok";
            // 
            // lbRulett
            // 
            resources.ApplyResources(this.lbRulett, "lbRulett");
            this.lbRulett.Name = "lbRulett";
            // 
            // lblAktiv
            // 
            this.lblAktiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.lblAktiv, "lblAktiv");
            this.lblAktiv.Name = "lblAktiv";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CasinoBeta.Properties.Resources.alapbackground;
            this.pictureBox1.Image = global::CasinoBeta.Properties.Resources.palm_tree;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btnKijelentkez
            // 
            resources.ApplyResources(this.btnKijelentkez, "btnKijelentkez");
            this.btnKijelentkez.Name = "btnKijelentkez";
            this.btnKijelentkez.UseVisualStyleBackColor = true;
            this.btnKijelentkez.Click += new System.EventHandler(this.btnKijelentkez_Click);
            // 
            // frmFomenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CasinoBeta.Properties.Resources.alapbackground;
            this.Controls.Add(this.btnKijelentkez);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAktiv);
            this.Controls.Add(this.lbRulett);
            this.Controls.Add(this.lbKartyajatekok);
            this.Controls.Add(this.lbKockajatekok);
            this.Controls.Add(this.lbLottok);
            this.Controls.Add(this.btnRulett);
            this.Controls.Add(this.btnKartyaMenu);
            this.Controls.Add(this.btnKockaMenu);
            this.Controls.Add(this.btnLottoMenu);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmFomenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLottoMenu;
        private System.Windows.Forms.Button btnKockaMenu;
        private System.Windows.Forms.Button btnKartyaMenu;
        private System.Windows.Forms.Button btnRulett;
        private System.Windows.Forms.ListBox lbLottok;
        private System.Windows.Forms.ListBox lbKockajatekok;
        private System.Windows.Forms.ListBox lbKartyajatekok;
        private System.Windows.Forms.ListBox lbRulett;
        private System.Windows.Forms.Label lblAktiv;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnKijelentkez;
    }
}