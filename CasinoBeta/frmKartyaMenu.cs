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
    public partial class frmKartyaMenu : Form
    {
        Media audio = new Media();

        DB adatbazis;
        User felhasznalo;

        public frmKartyaMenu(DB adatbazis, User felhasznalo)
        {
            this.adatbazis = adatbazis;
            this.felhasznalo = felhasznalo;

            InitializeComponent();


            lblAktiv.Text = ($"{felhasznalo.Nev}: {felhasznalo.Egyenleg}");
            lblAktiv.TextAlign = ContentAlignment.MiddleRight;
        }

        private void btnBlackJack_Click(object sender, EventArgs e)
        {
            audio.klikkhang();
            frmBlackJack formBlackJack = new frmBlackJack(adatbazis, felhasznalo);
            this.Dispose();
            GC.Collect();
            formBlackJack.ShowDialog();
        }

        private void btnKetesely_Click(object sender, EventArgs e)
        {
            audio.klikkhang();
            frmKeteselyKartya formKeteselyKartya = new frmKeteselyKartya(adatbazis, felhasznalo);
            this.Dispose();
            GC.Collect();
            formKeteselyKartya.ShowDialog();
        }

        private void btnKijelentkez_Click(object sender, EventArgs e)
        {
            frmBelepes formBelepes = new frmBelepes();
            this.Dispose();
            GC.Collect();
            formBelepes.ShowDialog();
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
