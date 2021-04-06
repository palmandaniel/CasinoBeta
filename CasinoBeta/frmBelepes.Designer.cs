namespace CasinoBeta
{
    partial class frmBelepes
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
            this.lblFelhasznalonev = new System.Windows.Forms.Label();
            this.lblJelszo = new System.Windows.Forms.Label();
            this.btnBelepes = new System.Windows.Forms.Button();
            this.btnRegisztral = new System.Windows.Forms.Button();
            this.tbFelhasznalonev = new System.Windows.Forms.TextBox();
            this.tbJelszo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblFelhasznalonev
            // 
            this.lblFelhasznalonev.AutoSize = true;
            this.lblFelhasznalonev.BackColor = System.Drawing.SystemColors.Control;
            this.lblFelhasznalonev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFelhasznalonev.Location = new System.Drawing.Point(52, 64);
            this.lblFelhasznalonev.Name = "lblFelhasznalonev";
            this.lblFelhasznalonev.Size = new System.Drawing.Size(126, 22);
            this.lblFelhasznalonev.TabIndex = 0;
            this.lblFelhasznalonev.Text = "Felhasználónév:";
            // 
            // lblJelszo
            // 
            this.lblJelszo.AutoSize = true;
            this.lblJelszo.BackColor = System.Drawing.SystemColors.Control;
            this.lblJelszo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblJelszo.Location = new System.Drawing.Point(52, 111);
            this.lblJelszo.Name = "lblJelszo";
            this.lblJelszo.Size = new System.Drawing.Size(60, 22);
            this.lblJelszo.TabIndex = 1;
            this.lblJelszo.Text = "Jelszó:";
            // 
            // btnBelepes
            // 
            this.btnBelepes.Location = new System.Drawing.Point(232, 167);
            this.btnBelepes.Name = "btnBelepes";
            this.btnBelepes.Size = new System.Drawing.Size(130, 30);
            this.btnBelepes.TabIndex = 2;
            this.btnBelepes.Text = "Belépés";
            this.btnBelepes.UseVisualStyleBackColor = true;
            this.btnBelepes.Click += new System.EventHandler(this.btnBelepes_Click);
            // 
            // btnRegisztral
            // 
            this.btnRegisztral.Location = new System.Drawing.Point(56, 167);
            this.btnRegisztral.Name = "btnRegisztral";
            this.btnRegisztral.Size = new System.Drawing.Size(130, 30);
            this.btnRegisztral.TabIndex = 3;
            this.btnRegisztral.Text = "Regisztráció";
            this.btnRegisztral.UseVisualStyleBackColor = true;
            this.btnRegisztral.Click += new System.EventHandler(this.btnRegisztral_Click);
            // 
            // tbFelhasznalonev
            // 
            this.tbFelhasznalonev.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbFelhasznalonev.Location = new System.Drawing.Point(182, 64);
            this.tbFelhasznalonev.Name = "tbFelhasznalonev";
            this.tbFelhasznalonev.Size = new System.Drawing.Size(180, 23);
            this.tbFelhasznalonev.TabIndex = 4;
            // 
            // tbJelszo
            // 
            this.tbJelszo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbJelszo.Location = new System.Drawing.Point(182, 111);
            this.tbJelszo.Name = "tbJelszo";
            this.tbJelszo.Size = new System.Drawing.Size(180, 23);
            this.tbJelszo.TabIndex = 5;
            // 
            // frmBelepes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CasinoBeta.Properties.Resources.alapbackground;
            this.ClientSize = new System.Drawing.Size(430, 257);
            this.Controls.Add(this.tbJelszo);
            this.Controls.Add(this.tbFelhasznalonev);
            this.Controls.Add(this.btnRegisztral);
            this.Controls.Add(this.btnBelepes);
            this.Controls.Add(this.lblJelszo);
            this.Controls.Add(this.lblFelhasznalonev);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBelepes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Palma Casino - Belépés";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFelhasznalonev;
        private System.Windows.Forms.Label lblJelszo;
        private System.Windows.Forms.Button btnBelepes;
        private System.Windows.Forms.Button btnRegisztral;
        private System.Windows.Forms.TextBox tbFelhasznalonev;
        private System.Windows.Forms.TextBox tbJelszo;
    }
}

