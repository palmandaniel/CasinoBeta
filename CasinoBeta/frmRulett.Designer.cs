namespace CasinoBeta
{
    partial class frmRulett
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRulett));
            this.lblTajekoztat = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAktiv = new System.Windows.Forms.Label();
            this.btnFomenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTajekoztat
            // 
            this.lblTajekoztat.AutoSize = true;
            this.lblTajekoztat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTajekoztat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTajekoztat.Location = new System.Drawing.Point(123, 196);
            this.lblTajekoztat.Name = "lblTajekoztat";
            this.lblTajekoztat.Size = new System.Drawing.Size(630, 33);
            this.lblTajekoztat.TabIndex = 0;
            this.lblTajekoztat.Text = "A játék fejlesztés alatt, hamarosan feltöltésre kerül!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CasinoBeta.Properties.Resources.alapbackground;
            this.pictureBox1.Image = global::CasinoBeta.Properties.Resources.palm_tree;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(840, 9);
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
            this.lblAktiv.Location = new System.Drawing.Point(586, 9);
            this.lblAktiv.Name = "lblAktiv";
            this.lblAktiv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAktiv.Size = new System.Drawing.Size(248, 32);
            this.lblAktiv.TabIndex = 11;
            this.lblAktiv.Text = "Aktív felhasználó: aktív kredit";
            this.lblAktiv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnFomenu
            // 
            this.btnFomenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnFomenu.Location = new System.Drawing.Point(314, 338);
            this.btnFomenu.Name = "btnFomenu";
            this.btnFomenu.Size = new System.Drawing.Size(248, 75);
            this.btnFomenu.TabIndex = 20;
            this.btnFomenu.Text = "Vissza a Főmenübe";
            this.btnFomenu.UseVisualStyleBackColor = true;
            this.btnFomenu.Click += new System.EventHandler(this.btnFomenu_Click);
            // 
            // frmRulett
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CasinoBeta.Properties.Resources.rulettbackground;
            this.ClientSize = new System.Drawing.Size(877, 425);
            this.Controls.Add(this.btnFomenu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAktiv);
            this.Controls.Add(this.lblTajekoztat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRulett";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Palma Casino - Rulett";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTajekoztat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAktiv;
        private System.Windows.Forms.Button btnFomenu;
    }
}