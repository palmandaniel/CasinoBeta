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
    public partial class frmLottoMenu : Form
    {
        DB adatbazis;
        User felhasznalo;

        public frmLottoMenu(DB adatbazis, User felhasznalo)
        {
            this.adatbazis = adatbazis;
            this.felhasznalo = felhasznalo;
            InitializeComponent();

            lbOtos.Items.Add("Ötöslottó");
            lbOtos.Items.Add("Szelvény ára: 300");
            lbOtos.Items.Add("90-ből 5-t kell eltalálni a főnyereményhez");
            lbOtos.Items.Add("Legalább 2 találat kell ahhoz, hogy nyerj");
            lbOtos.Items.Add("\t 2 találat: 10500");
            lbOtos.Items.Add("\t 3 találat: 50000");
            lbOtos.Items.Add("\t 4 találat: 400000");
            lbOtos.Items.Add("\t 5 találat: 2000000");
            lbOtos.Items.Add("\t\t Palma kreditet fizet");

            lbHatos.Items.Add("Hatoslottó");
            lbHatos.Items.Add("Szelvény ára: 300");
            lbHatos.Items.Add("45-ből 6-t kell eltalálni a főnyereményhez");
            lbHatos.Items.Add("Legalább 2 találat kell ahhoz, hogy nyerj");
            lbHatos.Items.Add("\t 2 találat: 1000");
            lbHatos.Items.Add("\t 3 találat: 27000");
            lbHatos.Items.Add("\t 4 találat: 80000");
            lbHatos.Items.Add("\t 5 találat: 275000");
            lbHatos.Items.Add("\t 6 találat: 1800000");
            lbHatos.Items.Add("\t\t Palma kreditet fizet");

            lbHetes.Items.Add("Heteslottó");
            lbHetes.Items.Add("Szelvény ára: 300");
            lbHetes.Items.Add("35-ből 7-t kell eltalálni a főnyereményhez");
            lbHetes.Items.Add("Legalább 4 találat kell ahhoz, hogy nyerj");
            lbHetes.Items.Add("\t 4 találat: 10000");
            lbHetes.Items.Add("\t 5 találat: 120000");
            lbHetes.Items.Add("\t 6 találat: 750000");
            lbHetes.Items.Add("\t 7 találat: 2000000");
            lbHetes.Items.Add("\t\t Palma kreditet fizet");

            lblAktiv.Text = ($"{felhasznalo.Nev}: {felhasznalo.Egyenleg}");
            lblAktiv.TextAlign = ContentAlignment.MiddleRight;
        }

        private void btnOtoslotto_Click(object sender, EventArgs e)
        {
            frmOtoslotto formOtoslotto = new frmOtoslotto(adatbazis, felhasznalo);
            this.Dispose();
            GC.Collect();
            formOtoslotto.ShowDialog();
        }

        private void btnHatoslotto_Click(object sender, EventArgs e)
        {
            frmHatoslotto frmHatoslotto = new frmHatoslotto(adatbazis, felhasznalo);
            this.Dispose();
            GC.Collect();
            frmHatoslotto.ShowDialog();

        }

        private void btnHeteslotto_Click(object sender, EventArgs e)
        {
            frmOtoslotto formOtoslotto = new frmOtoslotto(adatbazis, felhasznalo);
            this.Dispose();
            GC.Collect();
            formOtoslotto.ShowDialog();
        }

        private void btnFomenu_Click(object sender, EventArgs e)
        {
            frmFomenu formFomenu = new frmFomenu(adatbazis, felhasznalo);
            this.Dispose();
            GC.Collect();
            formFomenu.ShowDialog();
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
