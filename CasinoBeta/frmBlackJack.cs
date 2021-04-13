﻿using System;
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
    public partial class frmBlackJack : Form
    {
        DB adatbazis;
        User felhasznalo;

        static List<BJpakli> jatszmaPakli = new List<BJpakli>();
        static List<BJpakli> jatekosPakli = new List<BJpakli>();
        static List<BJpakli> gepPakli = new List<BJpakli>();
        public int tet = new int();

        PictureBox[] jatekoskepek = new PictureBox[9];
        PictureBox[] gepkepek = new PictureBox[9];

        static void Feltolt()
        {
            foreach (var p in BJpakli.pakli)
            {
                jatszmaPakli.Add(new BJpakli(p.Szin, p.Szam, p.Ertek, p.Megnevezes));
            }
        }

        static void Osztas(int db, List<BJpakli> lista)
        {
            Random veletlenindex = new Random(Guid.NewGuid().GetHashCode());
            int lap = 0;

            for (int j = 0; j < db; j++)
            {
                lap = veletlenindex.Next(0, jatszmaPakli.Count + 1);
                for (int i = 0; i < jatszmaPakli.Count; i++)
                {
                    if (lap == i)
                    {
                        lista.Add(new BJpakli(jatszmaPakli[i].Szin, jatszmaPakli[i].Szam, jatszmaPakli[i].Ertek, jatszmaPakli[i].Megnevezes));
                        jatszmaPakli.RemoveAt(i);
                    }
                }
            }
        }

        static int Ertekel(List<BJpakli> lista)
        {
            int sum = 0;

            if (lista.Count == 2 && lista[0].Szam == "asz" && lista[1].Szam == "asz")
            {
                return 21;
            }

            foreach (var l in lista)
            {
                sum += l.Ertek;
            }
            return sum;

        }

        static string Gyozteskereses(List<BJpakli> lista)
        {
            if (Ertekel(lista) == 21)
            {
                return "BlackJack";
            }
            else if (Ertekel(lista) > 21)
            {
                return "Vesztes leosztás, nagyobb mint 21";
            }
            else
            {
                return "";
            }
        }

        static int KulonbsegKereses(List<BJpakli> lista)
        {
            return 21 - Ertekel(lista);
        }

        static void GepKer()
        {
            if (Ertekel(gepPakli) < 15)
            {
                Osztas(1, gepPakli);
            }
            else if (Ertekel(gepPakli) < 17)
            {
                Random vel = new Random();
                int velszam = vel.Next(0, 101);
                if (velszam % 2 == 0)
                {
                    Osztas(1, gepPakli);
                }
            }
            else if (Ertekel(gepPakli) < 18)
            {
                Random vel = new Random();
                int velszam = vel.Next(0, 101);
                if (velszam % 5 == 0)
                {
                    Osztas(1, gepPakli);
                }
            }
        }


        public frmBlackJack(DB adatbazis, User felhasznalo)
        {
            this.adatbazis = adatbazis;
            this.felhasznalo = felhasznalo;

            InitializeComponent();
            BJpakli.Beolvasas();
            Feltolt();
            TetFeltoltes();

            lblAktiv.Text = ($"{felhasznalo.Nev}: {felhasznalo.Egyenleg}");
            lblAktiv.TextAlign = ContentAlignment.MiddleRight;

            cbTetkivalaszt.SelectedIndex = 0;

            jatekoskepek[0] = pbj1;
            jatekoskepek[1] = pbj2;
            jatekoskepek[2] = pbj3;
            jatekoskepek[3] = pbj4;
            jatekoskepek[4] = pbj5;
            jatekoskepek[5] = pbj6;
            jatekoskepek[6] = pbj7;
            jatekoskepek[7] = pbj8;
            jatekoskepek[8] = pbj9;

            gepkepek[0] = pbg1;
            gepkepek[1] = pbg2;
            gepkepek[2] = pbg3;
            gepkepek[3] = pbg4;
            gepkepek[4] = pbg5;
            gepkepek[5] = pbg6;
            gepkepek[6] = pbg7;
            gepkepek[7] = pbg8;
            gepkepek[8] = pbg9;

            btnLapot.Enabled = false;
            btnMegallok.Enabled = false;
            btnVissza.Enabled = true;

            lblJatekosPont.Visible = false;
            lblGepPontok.Visible = false;           
        }

        static void Kepelhelyez(List<BJpakli> jatekos, PictureBox[] pb)
        {
            if (jatekos.Count < 10)
            {
                for (int i = 0; i < jatekos.Count; i++)
                {
                    pb[i].Image = (Image)Properties.Resources.ResourceManager.GetObject(jatekos[i].Megnevezes);
                }
            }
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

        private void NyertKifizet()
        {
            adatbazis.MysqlKapcsolat.Open();
            felhasznalo.Egyenleg += (tet * 2);
            lblAktiv.Text = $"{felhasznalo.Nev}: {felhasznalo.Egyenleg}";
            string frissit = $"UPDATE felhasznalok SET egyenleg = {felhasznalo.Egyenleg} where felhasznalonev = '" + felhasznalo.Nev + "';";
            MySqlCommand frissito = new MySqlCommand(frissit, adatbazis.MysqlKapcsolat);
            frissito.ExecuteNonQuery();
            adatbazis.MysqlKapcsolat.Close();
        }

        private void DontetlenKifizet()
        {
            adatbazis.MysqlKapcsolat.Open();
            felhasznalo.Egyenleg += tet;
            lblAktiv.Text = $"{felhasznalo.Nev}: {felhasznalo.Egyenleg}";
            string frissit = $"UPDATE felhasznalok SET egyenleg = {felhasznalo.Egyenleg} where felhasznalonev = '" + felhasznalo.Nev + "';";
            MySqlCommand frissito = new MySqlCommand(frissit, adatbazis.MysqlKapcsolat);
            frissito.ExecuteNonQuery();
            adatbazis.MysqlKapcsolat.Close();
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
            tet = int.Parse(cbTetkivalaszt.SelectedItem.ToString());
            btnBefizet.Enabled = false;
            cbTetkivalaszt.Enabled = false;
            btnVissza.Enabled = false;
            FrissitoSQL();
            lbErtekel.Items.Add($"{tet} Palma kredit megjátszva");
            btnUjjatek.Enabled = false;
            btnLapot.Enabled = true;
            btnMegallok.Enabled = true;

            Osztas(2, jatekosPakli);
            Kepelhelyez(jatekosPakli, jatekoskepek);
            lblJatekosPont.Text = $"{Ertekel(jatekosPakli)}";

            pbg1.Image = CasinoBeta.Properties.Resources.hatlap;
            pbg2.Image = CasinoBeta.Properties.Resources.hatlap;

            lblJatekosPont.Visible = true;

            if (Ertekel(jatekosPakli) == 21)
            {
                btnLapot.Enabled = false;
                btnMegallok.Enabled = false;

                Osztas(2, gepPakli);
                GepKer();
                Kepelhelyez(gepPakli, gepkepek);
                lblGepPontok.Visible = true;
                lblGepPontok.Text = $"{Ertekel(gepPakli)}";

                if (Ertekel(gepPakli) == 21)
                {
                    //döntetlen
                }

                btnUjjatek.Enabled = true;
            }

        }

        private void btnLapot_Click(object sender, EventArgs e)
        {
            Osztas(1, jatekosPakli);
            Kepelhelyez(jatekosPakli, jatekoskepek);
            lblJatekosPont.Text = $"{Ertekel(jatekosPakli)}";
        }

        private void btnUjjatek_Click(object sender, EventArgs e)
        {

            gepPakli.Clear();
            jatekosPakli.Clear();
            jatszmaPakli.Clear();
            Feltolt();
            btnBefizet.Enabled = true;

            lblJatekosPont.Visible = false;
            lblGepPontok.Visible = false;

            for (int i = 0; i < jatekoskepek.Length; i++)
            {
                jatekoskepek[i].Image = null;
                gepkepek[i].Image = null;
            }
            cbTetkivalaszt.Enabled = true;
        }

        private void btnVissza_Click(object sender, EventArgs e)
        {
            gepPakli.Clear();
            jatekosPakli.Clear();
            jatszmaPakli.Clear();
            Feltolt();
            for (int i = 0; i < jatekoskepek.Length; i++)
            {
                jatekoskepek[i].Image = null;
                gepkepek[i].Image = null;
            }


            this.Dispose();
            GC.Collect();
            frmKartyaMenu formKartyaMenu = new frmKartyaMenu(adatbazis, felhasznalo);
            formKartyaMenu.ShowDialog();
        }

        private void btnMegallok_Click(object sender, EventArgs e)
        {
            btnMegallok.Enabled = false;
            btnLapot.Enabled = false;
            OsztoAI();

            if (Ertekel(jatekosPakli) < 21 && Ertekel(gepPakli)<21)
            {
                if (KulonbsegKereses(jatekosPakli)<KulonbsegKereses(gepPakli))
                {
                    NyertKifizet();
                    lbErtekel.Items.Add($"{Ertekel(jatekosPakli)}");
                    lbErtekel.Items.Add($"{Ertekel(gepPakli)}");
                    lbErtekel.Items.Add($"Nyertél!");
                }
                else if (KulonbsegKereses(jatekosPakli) > KulonbsegKereses(gepPakli))
                {
                    lbErtekel.Items.Add($"{Ertekel(jatekosPakli)}");
                    lbErtekel.Items.Add($"{Ertekel(gepPakli)}");
                    lbErtekel.Items.Add("Osztó nyert!");
                }
                else
                {
                    DontetlenKifizet();
                    lbErtekel.Items.Add($"{Ertekel(jatekosPakli)}");
                    lbErtekel.Items.Add($"{Ertekel(gepPakli)}");
                    lbErtekel.Items.Add("Döntetlen!");
                }
            }

            btnVissza.Enabled = true;
            btnUjjatek.Enabled = true;
        }

        private void lblJatekosPont_TextChanged(object sender, EventArgs e)
        {
            if (Ertekel(jatekosPakli)>21)
            {
                btnLapot.Enabled = false;
                btnMegallok.Enabled = false;
                OsztoAI();
                if (Ertekel(gepPakli)>21)
                {
                    DontetlenKifizet();
                    lbErtekel.Items.Add($"{Ertekel(jatekosPakli)}");
                    lbErtekel.Items.Add($"{Ertekel(gepPakli)}");
                    lbErtekel.Items.Add("Döntetlen!");
                }
                else if (Ertekel(gepPakli) < 22)
                {
                    lbErtekel.Items.Add($"{Ertekel(jatekosPakli)}");
                    lbErtekel.Items.Add($"{Ertekel(gepPakli)}");
                    lbErtekel.Items.Add("Osztó nyert!");
                }
            }
            else if (Ertekel(jatekosPakli) == 21)
            {
                btnLapot.Enabled = false;
                btnMegallok.Enabled = false;
                OsztoAI();
                if (Ertekel(gepPakli)==21)
                {
                    DontetlenKifizet();
                    lbErtekel.Items.Add($"{Ertekel(jatekosPakli)}");
                    lbErtekel.Items.Add($"{Ertekel(gepPakli)}");
                    lbErtekel.Items.Add("Döntetlen!");
                }
                else
                {
                    NyertKifizet();
                    lbErtekel.Items.Add($"{Ertekel(jatekosPakli)}");
                    lbErtekel.Items.Add($"{Ertekel(gepPakli)}");
                    lbErtekel.Items.Add($"Nyertél!");
                }
            }
        }

        private void OsztoAI()
        {
            Osztas(2, gepPakli);
            GepKer();
            Kepelhelyez(gepPakli, gepkepek);
            lblGepPontok.Visible = true;
            lblGepPontok.Text = $"{Ertekel(gepPakli)}";
        }
    }
}
