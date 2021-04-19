using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CasinoBeta
{
    public partial class frmRulett : Form
    {
        DB adatbazis;
        User felhasznalo;
        Media audio = new Media();

        public frmRulett(DB adatbazis, User felhasznalo)
        {
            this.adatbazis = adatbazis;
            this.felhasznalo = felhasznalo;
            InitializeComponent();

            lblAktiv.Text = ($"{felhasznalo.Nev}: {felhasznalo.Egyenleg}");
            lblAktiv.TextAlign = ContentAlignment.MiddleRight;
        }

        private void btnFomenu_Click(object sender, EventArgs e)
        {
            audio.visszahang();
            frmFomenu formFomenu = new frmFomenu(adatbazis, felhasznalo);
            this.Dispose();
            GC.Collect();
            formFomenu.ShowDialog();
        }
    }
}
