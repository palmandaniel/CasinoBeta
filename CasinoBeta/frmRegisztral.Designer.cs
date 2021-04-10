namespace CasinoBeta
{
    partial class frmRegisztral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegisztral));
            this.lblTeljesnev = new System.Windows.Forms.Label();
            this.lblFelhasznalonev = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTeljesnev = new System.Windows.Forms.TextBox();
            this.tbFelhasznalonev = new System.Windows.Forms.TextBox();
            this.tbJelszo = new System.Windows.Forms.TextBox();
            this.btnRegisztral = new System.Windows.Forms.Button();
            this.btnVissza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTeljesnev
            // 
            this.lblTeljesnev.AutoSize = true;
            this.lblTeljesnev.Location = new System.Drawing.Point(100, 107);
            this.lblTeljesnev.Name = "lblTeljesnev";
            this.lblTeljesnev.Size = new System.Drawing.Size(83, 20);
            this.lblTeljesnev.TabIndex = 0;
            this.lblTeljesnev.Text = "Teljes név:";
            // 
            // lblFelhasznalonev
            // 
            this.lblFelhasznalonev.AutoSize = true;
            this.lblFelhasznalonev.Location = new System.Drawing.Point(100, 139);
            this.lblFelhasznalonev.Name = "lblFelhasznalonev";
            this.lblFelhasznalonev.Size = new System.Drawing.Size(124, 20);
            this.lblFelhasznalonev.TabIndex = 1;
            this.lblFelhasznalonev.Text = "Felhasználónév:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jelszó:";
            // 
            // tbTeljesnev
            // 
            this.tbTeljesnev.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbTeljesnev.Location = new System.Drawing.Point(235, 101);
            this.tbTeljesnev.Name = "tbTeljesnev";
            this.tbTeljesnev.Size = new System.Drawing.Size(250, 23);
            this.tbTeljesnev.TabIndex = 3;
            // 
            // tbFelhasznalonev
            // 
            this.tbFelhasznalonev.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbFelhasznalonev.Location = new System.Drawing.Point(235, 133);
            this.tbFelhasznalonev.Name = "tbFelhasznalonev";
            this.tbFelhasznalonev.Size = new System.Drawing.Size(250, 23);
            this.tbFelhasznalonev.TabIndex = 4;
            // 
            // tbJelszo
            // 
            this.tbJelszo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbJelszo.Location = new System.Drawing.Point(235, 174);
            this.tbJelszo.Name = "tbJelszo";
            this.tbJelszo.Size = new System.Drawing.Size(250, 23);
            this.tbJelszo.TabIndex = 5;
            // 
            // btnRegisztral
            // 
            this.btnRegisztral.Location = new System.Drawing.Point(235, 219);
            this.btnRegisztral.Name = "btnRegisztral";
            this.btnRegisztral.Size = new System.Drawing.Size(261, 34);
            this.btnRegisztral.TabIndex = 6;
            this.btnRegisztral.Text = "Regisztrálok!";
            this.btnRegisztral.UseVisualStyleBackColor = true;
            this.btnRegisztral.Click += new System.EventHandler(this.btnRegisztral_Click);
            // 
            // btnVissza
            // 
            this.btnVissza.Location = new System.Drawing.Point(104, 219);
            this.btnVissza.Name = "btnVissza";
            this.btnVissza.Size = new System.Drawing.Size(120, 34);
            this.btnVissza.TabIndex = 7;
            this.btnVissza.Text = "Vissza";
            this.btnVissza.UseVisualStyleBackColor = true;
            this.btnVissza.Click += new System.EventHandler(this.btnVissza_Click);
            // 
            // frmRegisztral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CasinoBeta.Properties.Resources.alapbackground;
            this.ClientSize = new System.Drawing.Size(621, 286);
            this.Controls.Add(this.btnVissza);
            this.Controls.Add(this.btnRegisztral);
            this.Controls.Add(this.tbJelszo);
            this.Controls.Add(this.tbFelhasznalonev);
            this.Controls.Add(this.tbTeljesnev);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFelhasznalonev);
            this.Controls.Add(this.lblTeljesnev);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmRegisztral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Palma Casino - Regisztráció";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTeljesnev;
        private System.Windows.Forms.Label lblFelhasznalonev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTeljesnev;
        private System.Windows.Forms.TextBox tbFelhasznalonev;
        private System.Windows.Forms.TextBox tbJelszo;
        private System.Windows.Forms.Button btnRegisztral;
        private System.Windows.Forms.Button btnVissza;
    }
}