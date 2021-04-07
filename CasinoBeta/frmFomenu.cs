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

        private void button1_Click(object sender, EventArgs e)
        {
            frmOtoslotto formOtoslotto = new frmOtoslotto(adatbazis, felhasznalo);
            this.Dispose();
            GC.Collect();
            formOtoslotto.ShowDialog();

        }
    }
}
