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

    public partial class frmFomenu : Form
    {
        DB adatbazis;
        User felhasznalo;
        Media audio = new Media();


        public frmFomenu(DB adatbazis, User felhasznalo)
        {
            this.adatbazis = adatbazis;
            this.felhasznalo = felhasznalo;

            InitializeComponent();
            lbLottok.Items.Add("Benne:");
            lbLottok.Items.Add("⓹ Ötöslottó");
            lbLottok.Items.Add("❻ Hatoslottó");
            lbLottok.Items.Add("⓻ Heteslottó");
            lbKockajatekok.Items.Add("Benne:");
            lbKockajatekok.Items.Add("⚄⚅ Nagyobb mint ");
            lbKockajatekok.Items.Add("♠⚅ Kockapóker");
            lbKartyajatekok.Items.Add("Benne:");
            lbKartyajatekok.Items.Add("２１ BlackJack");
            lbKartyajatekok.Items.Add("½ Kétesély");
            lbKartyajatekok.Items.Add("(Hamarosan..)");
            lbRulett.Items.Add("Benne: ");
            lbRulett.Items.Add("⊛ Rulett");
            lbRulett.Items.Add("(Hamarosan..)");

            lblAktiv.Text = ($"{felhasznalo.Nev}: {felhasznalo.Egyenleg}");
            lblAktiv.TextAlign = ContentAlignment.MiddleRight;
        }

        private void btnLottoMenu_Click(object sender, EventArgs e)
        {
            audio.klikkhang();
            frmLottoMenu formLottomenu = new frmLottoMenu(adatbazis, felhasznalo);
            this.Dispose();
            GC.Collect();
            formLottomenu.ShowDialog();
        }

        private void btnKockaMenu_Click(object sender, EventArgs e)
        {
            audio.klikkhang();
            frmKockaMenu formKockamenu = new frmKockaMenu(adatbazis, felhasznalo);
            this.Dispose();
            GC.Collect();
            formKockamenu.ShowDialog();
        }

        private void btnKartyaMenu_Click(object sender, EventArgs e)
        {
            audio.klikkhang();
            frmKartyaMenu formKartyamenu = new frmKartyaMenu(adatbazis, felhasznalo);
            this.Dispose();
            GC.Collect();
            formKartyamenu.ShowDialog();
        }

        private void btnRulett_Click(object sender, EventArgs e)
        {
            audio.klikkhang();
            frmRulett formRulett = new frmRulett(adatbazis, felhasznalo);
            this.Dispose();
            GC.Collect();
            formRulett.ShowDialog();
        }

        private void btnKijelentkez_Click(object sender, EventArgs e)
        {
            frmBelepes formBelepes = new frmBelepes();
            this.Dispose();
            GC.Collect();
            formBelepes.ShowDialog();
        }

    }
}
