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
    public partial class frmHeteslotto : Form
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
            for (int i = 0; i < 7; i++)
            {
                int szam = 0;
                szam = r.Next(1, 36).GetHashCode();
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

        public frmHeteslotto(DB adatbazis, User felhasznalo)
        {
            this.adatbazis = adatbazis;
            this.felhasznalo = felhasznalo;

            InitializeComponent();

            cbTetkivalaszt.Items.Add(300);
            cbTetkivalaszt.SelectedIndex = 0;
            cbTetkivalaszt.Enabled = false;

            lblAktiv.Text = ($"{felhasznalo.Nev}: {felhasznalo.Egyenleg}");
            lblAktiv.TextAlign = ContentAlignment.MiddleRight;

            btnVissza.Enabled = true;


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

        private void SorsoltTbUrit()
        {
            tbs1.Text = "";
            tbs2.Text = "";
            tbs3.Text = "";
            tbs4.Text = "";
            tbs5.Text = "";
            tbs6.Text = "";
            tbs7.Text = "";

        }

        private void TippeltTbUrit()
        {
            tbt1.Text = "";
            tbt2.Text = "";
            tbt3.Text = "";
            tbt4.Text = "";
            tbt5.Text = "";
            tbt6.Text = "";
            tbt7.Text = "";

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
            if (talalat > 3)
            {
                audio.kifizethang();
            }

            if (talalat == 4)
            {
                adatbazis.MysqlKapcsolat.Open();
                felhasznalo.Egyenleg += 10000;
                string frissit = $"UPDATE felhasznalok SET egyenleg = {felhasznalo.Egyenleg} where felhasznalonev = '" + felhasznalo.Nev + "';";
                MySqlCommand frissito = new MySqlCommand(frissit, adatbazis.MysqlKapcsolat);
                frissito.ExecuteNonQuery();
                adatbazis.MysqlKapcsolat.Close();
                lblAktiv.Text = ($"{felhasznalo.Nev}: {felhasznalo.Egyenleg}");
                lbErtekel.Items.Add($"Gratulálunk! {10000} Palma kredit");
                lbErtekel.Items.Add($"kerül jóváírásra!");

            }
            else if (talalat == 5)
            {
                adatbazis.MysqlKapcsolat.Open();
                felhasznalo.Egyenleg += 120000;
                string frissit = $"UPDATE felhasznalok SET egyenleg = {felhasznalo.Egyenleg} where felhasznalonev = '" + felhasznalo.Nev + "';";
                MySqlCommand frissito = new MySqlCommand(frissit, adatbazis.MysqlKapcsolat);
                frissito.ExecuteNonQuery();
                adatbazis.MysqlKapcsolat.Close();
                lblAktiv.Text = ($"{felhasznalo.Nev}: {felhasznalo.Egyenleg}");
                lbErtekel.Items.Add($"Gratulálunk! {120000} Palma kredit");
                lbErtekel.Items.Add($"kerül jóváírásra!");

            }
            else if (talalat == 6)
            {
                adatbazis.MysqlKapcsolat.Open();
                felhasznalo.Egyenleg += 750000;
                string frissit = $"UPDATE felhasznalok SET egyenleg = {felhasznalo.Egyenleg} where felhasznalonev = '" + felhasznalo.Nev + "';";
                MySqlCommand frissito = new MySqlCommand(frissit, adatbazis.MysqlKapcsolat);
                frissito.ExecuteNonQuery();
                adatbazis.MysqlKapcsolat.Close();
                lblAktiv.Text = ($"{felhasznalo.Nev}: {felhasznalo.Egyenleg}");
                lbErtekel.Items.Add($"Gratulálunk! {750000} Palma kredit");
                lbErtekel.Items.Add($"kerül jóváírásra!");

            }
            else if (talalat == 7)
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
        }

        private void SorsolasFeltoltes()
        {
            Sorsol(sorsoltak);
            tbs1.Text = sorsoltak[0].ToString();
            tbs2.Text = sorsoltak[1].ToString();
            tbs3.Text = sorsoltak[2].ToString();
            tbs4.Text = sorsoltak[3].ToString();
            tbs5.Text = sorsoltak[4].ToString();
            tbs6.Text = sorsoltak[5].ToString();
            tbs7.Text = sorsoltak[6].ToString();
        }

        static void Torles(List<int> sorsoltak, List<int> tippeltek, int talalat)
        {
            sorsoltak.Clear();
            tippeltek.Clear();
            talalat = 0;
        }

        private void btnBefizet_Click(object sender, EventArgs e)
        {
            audio.befizethang();
            tbt1.Enabled = true;
            tbt2.Enabled = true;
            tbt3.Enabled = true;
            tbt4.Enabled = true;
            tbt5.Enabled = true;
            tbt6.Enabled = true;
            tbt7.Enabled = true;
            btnMegjatszom.Enabled = true;
            btnBefizet.Enabled = false;
            cbTetkivalaszt.Enabled = false;
            btnVissza.Enabled = false;

            FrissitoSQL();
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
                int[] tippek = new int[7];
                tippek[0] = int.Parse((tbt1.Text));
                tippek[1] = int.Parse(tbt2.Text);
                tippek[2] = int.Parse(tbt3.Text);
                tippek[3] = int.Parse(tbt4.Text);
                tippek[4] = int.Parse(tbt5.Text);
                tippek[5] = int.Parse(tbt6.Text);
                tippek[6] = int.Parse(tbt7.Text);

                foreach (var t in tippek)
                {
                    if (!Tartalmazza(tippeltek, t) && t > 0 && t < 36)
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
                    MessageBox.Show("Egy számot csak egyszer játszhatsz meg! 1-35-ig tippelj!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TippeltTbUrit();
                    tippeltek.Clear();
                    lbErtekel.Items.Clear();
                    tbt1.Enabled = true;
                    tbt2.Enabled = true;
                    tbt3.Enabled = true;
                    tbt4.Enabled = true;
                    tbt5.Enabled = true;
                    tbt6.Enabled = true;
                    tbt7.Enabled = true;
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
                tbt6.Enabled = true;
                tbt7.Enabled = true;
            }


            if (tippeltek.Count == 7)
            {
                btnMegjatszom.Enabled = false;
                tippeltek.Sort();
                for (int i = 1; i < 8; i++)
                {
                    lbErtekel.Items.Add($"{i}. tipp: {tippeltek[i - 1]}");
                }

                lbErtekel.Items.Add("Sorsolás");
                SorsolasFeltoltes();
                for (int i = 1; i < 8; i++)
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

        private void btnVissza_Click(object sender, EventArgs e)
        {
            audio.visszahang();
            frmLottoMenu formLottoMenu = new frmLottoMenu(adatbazis, felhasznalo);
            GC.Collect();
            this.Dispose();
            formLottoMenu.ShowDialog();
        }

    }
}