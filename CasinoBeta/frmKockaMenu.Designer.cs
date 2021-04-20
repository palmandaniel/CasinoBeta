namespace CasinoBeta
{
    partial class frmKockaMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKockaMenu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAktiv = new System.Windows.Forms.Label();
            this.btnKijelentkez = new System.Windows.Forms.Button();
            this.btnFomenu = new System.Windows.Forms.Button();
            this.btnNagyobb = new System.Windows.Forms.Button();
            this.btnKockapoker = new System.Windows.Forms.Button();
            this.lbNagyobb = new System.Windows.Forms.ListBox();
            this.lbKockapoker = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.pictureBox1.TabIndex = 14;
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
            this.lblAktiv.TabIndex = 13;
            this.lblAktiv.Text = "Aktív felhasználó: aktív kredit";
            this.lblAktiv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnKijelentkez
            // 
            this.btnKijelentkez.Location = new System.Drawing.Point(625, 51);
            this.btnKijelentkez.Name = "btnKijelentkez";
            this.btnKijelentkez.Size = new System.Drawing.Size(248, 75);
            this.btnKijelentkez.TabIndex = 16;
            this.btnKijelentkez.Text = "Kijelentkezés";
            this.btnKijelentkez.UseVisualStyleBackColor = true;
            this.btnKijelentkez.Click += new System.EventHandler(this.btnKijelentkez_Click);
            // 
            // btnFomenu
            // 
            this.btnFomenu.Location = new System.Drawing.Point(625, 134);
            this.btnFomenu.Name = "btnFomenu";
            this.btnFomenu.Size = new System.Drawing.Size(248, 75);
            this.btnFomenu.TabIndex = 15;
            this.btnFomenu.Text = "Vissza a Főmenübe";
            this.btnFomenu.UseVisualStyleBackColor = true;
            this.btnFomenu.Click += new System.EventHandler(this.btnFomenu_Click);
            // 
            // btnNagyobb
            // 
            this.btnNagyobb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnNagyobb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNagyobb.Location = new System.Drawing.Point(12, 12);
            this.btnNagyobb.Name = "btnNagyobb";
            this.btnNagyobb.Size = new System.Drawing.Size(300, 75);
            this.btnNagyobb.TabIndex = 17;
            this.btnNagyobb.Text = "Nagyobb mint... kockajáték";
            this.btnNagyobb.UseVisualStyleBackColor = true;
            this.btnNagyobb.Click += new System.EventHandler(this.btnNagyobb_Click);
            // 
            // btnKockapoker
            // 
            this.btnKockapoker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnKockapoker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnKockapoker.Location = new System.Drawing.Point(318, 12);
            this.btnKockapoker.Name = "btnKockapoker";
            this.btnKockapoker.Size = new System.Drawing.Size(300, 75);
            this.btnKockapoker.TabIndex = 18;
            this.btnKockapoker.Text = "Kockapóker";
            this.btnKockapoker.UseVisualStyleBackColor = true;
            this.btnKockapoker.Click += new System.EventHandler(this.btnKockapoker_Click);
            // 
            // lbNagyobb
            // 
            this.lbNagyobb.FormattingEnabled = true;
            this.lbNagyobb.ItemHeight = 20;
            this.lbNagyobb.Location = new System.Drawing.Point(12, 93);
            this.lbNagyobb.MultiColumn = true;
            this.lbNagyobb.Name = "lbNagyobb";
            this.lbNagyobb.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbNagyobb.Size = new System.Drawing.Size(300, 204);
            this.lbNagyobb.TabIndex = 19;
            // 
            // lbKockapoker
            // 
            this.lbKockapoker.FormattingEnabled = true;
            this.lbKockapoker.ItemHeight = 20;
            this.lbKockapoker.Location = new System.Drawing.Point(318, 95);
            this.lbKockapoker.Name = "lbKockapoker";
            this.lbKockapoker.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbKockapoker.Size = new System.Drawing.Size(300, 204);
            this.lbKockapoker.TabIndex = 20;
            // 
            // frmKockaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CasinoBeta.Properties.Resources.KockaHatter;
            this.ClientSize = new System.Drawing.Size(922, 312);
            this.Controls.Add(this.lbKockapoker);
            this.Controls.Add(this.lbNagyobb);
            this.Controls.Add(this.btnKockapoker);
            this.Controls.Add(this.btnNagyobb);
            this.Controls.Add(this.btnKijelentkez);
            this.Controls.Add(this.btnFomenu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAktiv);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmKockaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Palma Casino - Kockajátékok";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAktiv;
        private System.Windows.Forms.Button btnKijelentkez;
        private System.Windows.Forms.Button btnFomenu;
        private System.Windows.Forms.Button btnNagyobb;
        private System.Windows.Forms.Button btnKockapoker;
        private System.Windows.Forms.ListBox lbNagyobb;
        private System.Windows.Forms.ListBox lbKockapoker;
    }
}