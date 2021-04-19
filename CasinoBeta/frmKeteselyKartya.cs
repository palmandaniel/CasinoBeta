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
    public partial class frmKeteselyKartya : Form
    {
        Media audio = new Media();

        DB adatbazis;
        User felhasznalo;
        static List<KeteselyPakli> kartyak = new List<KeteselyPakli>();
        static List<KeteselyPakli> osztott = new List<KeteselyPakli>();
        public int tet = new int();
        public bool helyes = new bool();
        PictureBox[] kepek = new PictureBox[3];
        public string tipp = "";
        public int szeria = 1;
        public int szamlalo = 0;
        public int kockaztatott = 0;

        static void Feltolt()
        {
            foreach (var p in KeteselyPakli.pakli)
            {
                kartyak.Add(new KeteselyPakli(p.Szin, p.Szam, p.Ertek, p.Megnevezes));
            }
        }

        static void Kivalaszt()
        {
            Random veletlenindex = new Random(Guid.NewGuid().GetHashCode());
            int lap = 0;

            for (int j = 0; j < 1; j++)
            {
                lap = veletlenindex.Next(0, kartyak.Count + 1);
                for (int i = 0; i < kartyak.Count; i++)
                {
                    if (lap == i)
                    {
                        osztott.Add(new KeteselyPakli(kartyak[i].Szin, kartyak[i].Szam, kartyak[i].Ertek, kartyak[i].Megnevezes));
                    }
                }
            }
        }

        public frmKeteselyKartya(DB adatbazis, User felhasznalo)
        {
            this.adatbazis = adatbazis;
            this.felhasznalo = felhasznalo;
            InitializeComponent();
            KeteselyPakli.Beolvasas();
            Feltolt();
            lblAktiv.Text = ($"{felhasznalo.Nev}: {felhasznalo.Egyenleg}");
            lblAktiv.TextAlign = ContentAlignment.MiddleRight;
            TetFeltoltes();
            cbTetkivalaszt.SelectedIndex = 0;

            kepek[0] = pbO1;
            kepek[1] = pbO2;
            kepek[2] = pbO3;

            lblTemp.Visible = true;
        }

        private void btnPiros_Click(object sender, EventArgs e)
        {
            audio.klikkhang();
            tipp = "piros";
            lblKockaztatott.Text = $"Kockáztatott összeg: {kockaztatott}";
            Kivalaszt();
            Kepelhelyez(osztott, kepek);
            btnMegallok.Enabled = true;
            szamlalo++;
            lblTemp.Text = $"{szamlalo}";
        }

        private void btnFekete_Click(object sender, EventArgs e)
        {
            audio.klikkhang();
            tipp = "fekete";
            lblKockaztatott.Text = $"Kockáztatott összeg: {kockaztatott}";
            Kivalaszt();
            Kepelhelyez(osztott, kepek);
            btnMegallok.Enabled = true;
            szamlalo++;
            lblTemp.Text = $"{szamlalo}";
        }

        private void btnMegallok_Click(object sender, EventArgs e)
        {
            audio.klikkhang();
            btnPiros.Enabled = false;
            btnFekete.Enabled = false;
            NyertKifizet();
            lbErtekel.Items.Add("Gratulálok! Nyereményed: ");
            lbErtekel.Items.Add($"{kockaztatott} Palma kredit");
            lbErtekel.Items.Add($"{szeria-1} pontos tipped volt");
            btnMegallok.Enabled = false;
            btnVissza.Enabled = true;
            btnUjjatek.Enabled = true;
        }

        private void btnUjjatek_Click(object sender, EventArgs e)
        {
            audio.klikkhang();
            kockaztatott = 0;
            lblKockaztatott.Text = $"Kockáztatott összeg: {kockaztatott}";
            lblKockaztatott.Visible = false;
            osztott.Clear();
            cbTetkivalaszt.Enabled = true;
            for (int i = 0; i < kepek.Length; i++)
            {
                kepek[i].Image = null;
            }
            btnBefizet.Enabled = true;
            lbErtekel.Items.Clear();
            szeria = 1;
        }

        private void btnVissza_Click(object sender, EventArgs e)
        {
            audio.visszahang();
            kockaztatott = 0;
            lblKockaztatott.Visible = false;
            osztott.Clear();
            cbTetkivalaszt.Enabled = true;
            for (int i = 0; i < kepek.Length; i++)
            {
                kepek[i].Image = null;
            }
            btnBefizet.Enabled = true;
            lbErtekel.Items.Clear();
            szeria = 1;


            this.Dispose();
            GC.Collect();
            frmKartyaMenu formKartyaMenu = new frmKartyaMenu(adatbazis, felhasznalo);
            formKartyaMenu.ShowDialog();
        }

        private void lblTemp_TextChanged(object sender, EventArgs e)
        {
            lblKockaztatott.Text = $"Kockáztatott összeg: {kockaztatott}";

            if (tipp == osztott[osztott.Count-1].Color)
            {
                helyes = true;
                szeria++;
                kockaztatott *= szeria;
            }
            else
            {
                lbErtekel.Items.Add("Veszítettél");
                lbErtekel.Items.Add($"{szeria-1} helyes tipped volt");
                helyes = false;
                btnPiros.Enabled = false;
                btnFekete.Enabled = false;
                btnMegallok.Enabled = false;
                btnVissza.Enabled = true;
                btnUjjatek.Enabled = true;
                tipp = "";
            }

            lblKockaztatott.Text = $"Kockáztatott összeg: {kockaztatott}";

        }

        void TetFeltoltes()
        {
            cbTetkivalaszt.Items.Add(10);
            cbTetkivalaszt.Items.Add(50);
            cbTetkivalaszt.Items.Add(100);
            cbTetkivalaszt.Items.Add(250);
            cbTetkivalaszt.Items.Add(500);
            cbTetkivalaszt.Items.Add(1000);
            cbTetkivalaszt.Items.Add(3000);
            cbTetkivalaszt.Items.Add(5000);
            cbTetkivalaszt.Items.Add(10000);
        }

        private void btnBefizet_Click(object sender, EventArgs e)
        {
            audio.befizethang();
            tet = int.Parse(cbTetkivalaszt.SelectedItem.ToString());
            btnBefizet.Enabled = false;
            cbTetkivalaszt.Enabled = false;
            btnVissza.Enabled = false;
            FrissitoSQL();
            lbErtekel.Items.Add($"{tet} Palma kredit megjátszva");
            btnUjjatek.Enabled = false;
            btnPiros.Enabled = true;
            btnFekete.Enabled = true;
            kockaztatott = tet;
            lblKockaztatott.Visible = true;
            lblKockaztatott.Text = $"Kockáztatott összeg: {kockaztatott}";

        }

        private void FrissitoSQL()
        {
            adatbazis.MysqlKapcsolat.Open();
            felhasznalo.Egyenleg -= tet;
            lblAktiv.Text = $"{felhasznalo.Nev}: {felhasznalo.Egyenleg}";
            string frissit = $"UPDATE felhasznalok SET egyenleg = {felhasznalo.Egyenleg} where felhasznalonev = '" + felhasznalo.Nev + "';";
            MySqlCommand frissito = new MySqlCommand(frissit, adatbazis.MysqlKapcsolat);
            frissito.ExecuteNonQuery();
            adatbazis.MysqlKapcsolat.Close();
        }

        private void Kepelhelyez(List<KeteselyPakli> kartyak, PictureBox[] pb)
        {
            audio.kartyahang();

            if (kartyak.Count == 1)
            {

                pb[0].Image = (Image)Properties.Resources.ResourceManager.GetObject(kartyak[0].Megnevezes);
                pb[1].Image = null;
                pb[2].Image = null;


            }
            else if (kartyak.Count == 2)
            {
                for (int i = 0; i < 2; i++)
                {
                    pb[0].Image = (Image)Properties.Resources.ResourceManager.GetObject(kartyak[1].Megnevezes);
                    pb[1].Image = (Image)Properties.Resources.ResourceManager.GetObject(kartyak[0].Megnevezes);
                    pb[2].Image = null;
                }

            }
            else if (kartyak.Count == 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    pb[0].Image = (Image)Properties.Resources.ResourceManager.GetObject(kartyak[2].Megnevezes);
                    pb[1].Image = (Image)Properties.Resources.ResourceManager.GetObject(kartyak[1].Megnevezes);
                    pb[2].Image = (Image)Properties.Resources.ResourceManager.GetObject(kartyak[0].Megnevezes);
 
                }
            }
            else
            {
                for (int i = 0; i < kartyak.Count; i++)
                {
                    pb[0].Image = (Image)Properties.Resources.ResourceManager.GetObject(kartyak[kartyak.Count - 1].Megnevezes);
                    pb[1].Image = (Image)Properties.Resources.ResourceManager.GetObject(kartyak[kartyak.Count - 2].Megnevezes);
                    pb[2].Image = (Image)Properties.Resources.ResourceManager.GetObject(kartyak[kartyak.Count - 3].Megnevezes);
                }
            }
        }

        private void NyertKifizet()
        {
            audio.kifizethang();
            adatbazis.MysqlKapcsolat.Open();
            felhasznalo.Egyenleg += kockaztatott;
            lblAktiv.Text = $"{felhasznalo.Nev}: {felhasznalo.Egyenleg}";
            string frissit = $"UPDATE felhasznalok SET egyenleg = {felhasznalo.Egyenleg} where felhasznalonev = '" + felhasznalo.Nev + "';";
            MySqlCommand frissito = new MySqlCommand(frissit, adatbazis.MysqlKapcsolat);
            frissito.ExecuteNonQuery();
            adatbazis.MysqlKapcsolat.Close();
        }
    }
}
