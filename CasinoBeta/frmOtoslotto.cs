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
    public partial class frmOtoslotto : Form
    {
        DB adatbazis;
        User felhasznalo;
        Media audio = new Media();


        public static int talalat = new int();
        static List<int> szamok = new List<int>();
        static List<int> sorsoltak = new List<int>();
        static List<int> tippeltek = new List<int>();
        public const int TET = 300;

        static List<int> Sorsol(List<int> sorsoltak)
        {
            Random r = new Random();
            for (int i = 0; i < 5; i++)
            {
                int szam = 0;
                szam = r.Next(1, 91).GetHashCode();
                if (!Tartalmazza(sorsoltak, szam))
                {
                    sorsoltak.Add(szam);
                }
                else
                {
                    i--;
                }
            }

            sorsoltak.Sort();
            return sorsoltak;
        }

        static bool Tartalmazza(List<int> lista, int szam)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] == szam)
                {
                    return true;
                }
            }
            return false;
        }

        static void Torles(List<int> sorsoltak, List<int> tippeltek, int talalat)
        {
            sorsoltak.Clear();
            tippeltek.Clear();
            talalat = 0;
        }

        public frmOtoslotto(DB adatbazis, User felhasznalo)
        {
            this.felhasznalo = felhasznalo;
            this.adatbazis = adatbazis;

            Torles(sorsoltak, tippeltek, talalat);

            InitializeComponent();
            lblAktiv.Text = ($"{felhasznalo.Nev}: {felhasznalo.Egyenleg}");
            lblAktiv.TextAlign = ContentAlignment.MiddleRight;

            btnVissza.Enabled = true;

            cbTetkivalaszt.Items.Add(300);
            cbTetkivalaszt.SelectedIndex = 0;
            cbTetkivalaszt.Enabled = false;

        }

        private void btnBefizet_Click(object sender, EventArgs e)
        {
            audio.befizethang();
            tbt1.Enabled = true;
            tbt2.Enabled = true;
            tbt3.Enabled = true;
            tbt4.Enabled = true;
            tbt5.Enabled = true;
            btnMegjatszom.Enabled = true;
            btnBefizet.Enabled = false;
            cbTetkivalaszt.Enabled = false;
            btnVissza.Enabled = false;


            FrissitoSQL();
        }

        private void FrissitoSQL()
        {
            adatbazis.MysqlKapcsolat.Open();
            felhasznalo.Egyenleg -= TET;
            lblAktiv.Text = $"{felhasznalo.Nev}: {felhasznalo.Egyenleg}";
            string frissit = $"UPDATE felhasznalok SET egyenleg = {felhasznalo.Egyenleg} where felhasznalonev = '" + felhasznalo.Nev + "';";
            MySqlCommand frissito = new MySqlCommand(frissit, adatbazis.MysqlKapcsolat);
            frissito.ExecuteNonQuery();
            adatbazis.MysqlKapcsolat.Close();
        }

        private void btnUjjatek_Click(object sender, EventArgs e)
        {
            audio.klikkhang();
            Torles(sorsoltak, tippeltek, talalat);
            talalat = 0;
            lbErtekel.Items.Clear();
            TippeltTbUrit();
            SorsoltTbUrit();
            btnMegjatszom.Enabled = false;
            btnBefizet.Enabled = true;
            lblAktiv.Text = ($"{felhasznalo.Nev}: {felhasznalo.Egyenleg}");
            btnUjjatek.Enabled = false;
        }

        private void SorsoltTbUrit()
        {
            tbs1.Text = "";
            tbs2.Text = "";
            tbs3.Text = "";
            tbs4.Text = "";
            tbs5.Text = "";
        }

        private void TippeltTbUrit()
        {
            tbt1.Text = "";
            tbt2.Text = "";
            tbt3.Text = "";
            tbt4.Text = "";
            tbt5.Text = "";
        }

        private void btnVissza_Click_1(object sender, EventArgs e)
        {
           audio.visszahang();
            frmLottoMenu formLottoMenu = new frmLottoMenu(adatbazis, felhasznalo);
            GC.Collect();
            this.Dispose();
            formLottoMenu.ShowDialog();
        }

        private void btnMegjatszom_Click(object sender, EventArgs e)
        {
            audio.klikkhang();
            Torles(sorsoltak, tippeltek, talalat);
            talalat = 0;
            lbErtekel.Items.Add("Tippelés");
            try
            {
                bool hiba = false;
                int[] tippek = new int[5];
                tippek[0] = int.Parse((tbt1.Text));
                tippek[1] = int.Parse(tbt2.Text);
                tippek[2] = int.Parse(tbt3.Text);
                tippek[3] = int.Parse(tbt4.Text);
                tippek[4] = int.Parse(tbt5.Text);

                foreach (var t in tippek)
                {
                    if (!Tartalmazza(tippeltek, t) && t > 0 && t < 91)
                    {
                        tippeltek.Add(t);
                    }
                    else
                    {
                        hiba = true;
                        break;
                    }
                }

                if (hiba)
                {
                    MessageBox.Show("Egy számot csak egyszer játszhatsz meg! A tippelt számnak 0 és 91 közé kell esnie!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TippeltTbUrit();
                    tippeltek.Clear();
                    tbt1.Enabled = true;
                    tbt2.Enabled = true;
                    tbt3.Enabled = true;
                    tbt4.Enabled = true;
                    tbt5.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TippeltTbUrit();
                tippeltek.Clear();
                tbt1.Enabled = true;
                tbt2.Enabled = true;
                tbt3.Enabled = true;
                tbt4.Enabled = true;
                tbt5.Enabled = true;
            }


            if (tippeltek.Count == 5)
            {
                btnMegjatszom.Enabled = false;
                tippeltek.Sort();
                for (int i = 1; i < 6; i++)
                {
                    lbErtekel.Items.Add($"{i}. tipp: {tippeltek[i - 1]}");
                }

                lbErtekel.Items.Add("Sorsolás");
                SorsolasFeltoltes();
                for (int i = 1; i < 6; i++)
                {
                    lbErtekel.Items.Add($"{i}.sorsolt: {sorsoltak[i - 1]}");
                }

                Vizsgal();
                lbErtekel.Items.Add($"Találatok száma: {talalat}");

                btnUjjatek.Enabled = true;
                btnVissza.Enabled = true;

                Kifizet();
                lblAktiv.Text = ($"{felhasznalo.Nev}: {felhasznalo.Egyenleg}");

            }
        }

        private static void Vizsgal()
        {
            for (int i = 0; i < sorsoltak.Count; i++)
            {
                for (int j = 0; j < tippeltek.Count; j++)
                {
                    if (sorsoltak[i] == tippeltek[j])
                    {
                        talalat++;
                    }
                }
            }
        }

        private void Kifizet()
        {
            if (talalat > 1)
            {
                audio.kifizethang();
            }

            if (talalat == 2)
            {
                adatbazis.MysqlKapcsolat.Open();
                felhasznalo.Egyenleg += 10500;
                string frissit = $"UPDATE felhasznalok SET egyenleg = {felhasznalo.Egyenleg} where felhasznalonev = '" + felhasznalo.Nev + "';";
                MySqlCommand frissito = new MySqlCommand(frissit, adatbazis.MysqlKapcsolat);
                frissito.ExecuteNonQuery();
                adatbazis.MysqlKapcsolat.Close();
                lblAktiv.Text = ($"{felhasznalo.Nev}: {felhasznalo.Egyenleg}");
                lbErtekel.Items.Add($"Gratulálunk! {10500} Palma kredit");
                lbErtekel.Items.Add($"kerül jóváírásra!");
            }
            else if (talalat == 3)
            {
                adatbazis.MysqlKapcsolat.Open();
                felhasznalo.Egyenleg += 50000;
                string frissit = $"UPDATE felhasznalok SET egyenleg = {felhasznalo.Egyenleg} where felhasznalonev = '" + felhasznalo.Nev + "';";
                MySqlCommand frissito = new MySqlCommand(frissit, adatbazis.MysqlKapcsolat);
                frissito.ExecuteNonQuery();
                adatbazis.MysqlKapcsolat.Close();
                lblAktiv.Text = ($"{felhasznalo.Nev}: {felhasznalo.Egyenleg}");
                lbErtekel.Items.Add($"Gratulálunk! {50000} Palma kredit");
                lbErtekel.Items.Add($"kerül jóváírásra!");
            }
            else if (talalat == 4)
            {
                adatbazis.MysqlKapcsolat.Open();
                felhasznalo.Egyenleg += 400000;
                string frissit = $"UPDATE felhasznalok SET egyenleg = {felhasznalo.Egyenleg} where felhasznalonev = '" + felhasznalo.Nev + "';";
                MySqlCommand frissito = new MySqlCommand(frissit, adatbazis.MysqlKapcsolat);
                frissito.ExecuteNonQuery();
                adatbazis.MysqlKapcsolat.Close();
                lblAktiv.Text = ($"{felhasznalo.Nev}: {felhasznalo.Egyenleg}");
                lbErtekel.Items.Add($"Gratulálunk! {400000} Palma kredit");
                lbErtekel.Items.Add($"kerül jóváírásra!");
            }
            else if (talalat == 5)
            {
                adatbazis.MysqlKapcsolat.Open();
                felhasznalo.Egyenleg += 2000000;
                string frissit = $"UPDATE felhasznalok SET egyenleg = {felhasznalo.Egyenleg} where felhasznalonev = '" + felhasznalo.Nev + "';";
                MySqlCommand frissito = new MySqlCommand(frissit, adatbazis.MysqlKapcsolat);
                frissito.ExecuteNonQuery();
                adatbazis.MysqlKapcsolat.Close();
                lblAktiv.Text = ($"{felhasznalo.Nev}: {felhasznalo.Egyenleg}");
                lbErtekel.Items.Add($"Gratulálunk! {2000000} Palma kredit");
                lbErtekel.Items.Add($"kerül jóváírásra!");
            }
            btnVissza.Enabled = true;
        }

        private void SorsolasFeltoltes()
        {
            Sorsol(sorsoltak);
            tbs1.Text = sorsoltak[0].ToString();
            tbs2.Text = sorsoltak[1].ToString();
            tbs3.Text = sorsoltak[2].ToString();
            tbs4.Text = sorsoltak[3].ToString();
            tbs5.Text = sorsoltak[4].ToString();
        }
    }
}
