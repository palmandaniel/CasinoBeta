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
using System.Media;

namespace CasinoBeta
{
    public partial class frmKartyaMenu : Form
    {
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
            klikkhang();
            frmBlackJack formBlackJack = new frmBlackJack(adatbazis, felhasznalo);
            this.Dispose();
            GC.Collect();
            formBlackJack.ShowDialog();
        }

        private void btnKetesely_Click(object sender, EventArgs e)
        {
            klikkhang();
            frmKeteselyKartya formKeteselyKartya = new frmKeteselyKartya(adatbazis, felhasznalo);
            this.Dispose();
            GC.Collect();
            formKeteselyKartya.ShowDialog();
        }

        private void btnKijelentkez_Click(object sender, EventArgs e)
        {
            viszlathang();
            frmBelepes formBelepes = new frmBelepes();
            this.Dispose();
            GC.Collect();
            formBelepes.ShowDialog();
        }

        private void btnFomenu_Click(object sender, EventArgs e)
        {
            visszahang();
            frmFomenu formFomenu = new frmFomenu(adatbazis, felhasznalo);
            this.Dispose();
            GC.Collect();
            formFomenu.ShowDialog();
        }

        private void klikkhang()
        {
            SoundPlayer klikk = new SoundPlayer(CasinoBeta.Properties.Resources.hangklikk);
            klikk.Play();
        }

        private void visszahang()
        {
            SoundPlayer vissza = new SoundPlayer(CasinoBeta.Properties.Resources.hangvissza);
            vissza.Play();
        }

        private void viszlathang()
        {
            SoundPlayer viszlat = new SoundPlayer(CasinoBeta.Properties.Resources.hangviszlat);
        }
    }
}
