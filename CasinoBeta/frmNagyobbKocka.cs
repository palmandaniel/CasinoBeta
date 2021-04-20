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
    public partial class frmNagyobbKocka : Form
    {
        Media audio = new Media();

        DB adatbazis;
        User felhasznalo;
        public int kockaszam = new int();
        public int tet = new int();

        NagyobbMintKockajatek jatekos = new NagyobbMintKockajatek();
        NagyobbMintKockajatek gep = new NagyobbMintKockajatek();

        PictureBox[] jatekoskepek = new PictureBox[5];
        PictureBox[] gepkepek = new PictureBox[5];

        int bonus = new int();

        public frmNagyobbKocka(DB adatbazis, User felhasznalo)
        {
            this.adatbazis = adatbazis;
            this.felhasznalo = felhasznalo;

            InitializeComponent();
            lblJatekos.Text = $"{felhasznalo.Nev}";
            TetFeltoltes();
            KockaSzamFeltoltes();
            btnKockaszam.Enabled = false;
            btnUjjatek.Enabled = false;
            cbKockaSzam.Enabled = false;
            lblAktiv.Text = ($"{felhasznalo.Nev}: {felhasznalo.Egyenleg}");
            lblAktiv.TextAlign = ContentAlignment.MiddleRight;
            btnVissza.Enabled = true;
            cbTetkivalaszt.SelectedIndex = 0;
            cbKockaSzam.SelectedIndex = 4;

            jatekoskepek[0] = pbJ1;
            jatekoskepek[1] = pbJ2;
            jatekoskepek[2] = pbJ3;
            jatekoskepek[3] = pbJ4;
            jatekoskepek[4] = pbJ5;

            gepkepek[0] = pbG1;
            gepkepek[1] = pbG2;
            gepkepek[2] = pbG3;
            gepkepek[3] = pbG4;
            gepkepek[4] = pbG5;

            pbG1.Visible = false;
            pbG2.Visible = false;
            pbG3.Visible = true;
            pbG4.Visible = false;
            pbG5.Visible = false;

            pbJ1.Visible = false;
            pbJ2.Visible = false;
            pbJ3.Visible = true;
            pbJ4.Visible = false;
            pbJ5.Visible = false;

            lblRelacio.Visible = false;
            bonus = jatekos.Kiertekel();

        }

        private void btnBefizet_Click(object sender, EventArgs e)
        {
            audio.befizethang();
            tet = int.Parse(cbTetkivalaszt.SelectedItem.ToString());
            btnBefizet.Enabled = false;
            btnKockaszam.Enabled = true;
            cbTetkivalaszt.Enabled = false;
            cbKockaSzam.Enabled = true;
            btnVissza.Enabled = false;
            FrissitoSQL();
            lbErtekel.Items.Add($"{tet} Palma kredit megjátszva");
            btnUjjatek.Enabled = false;
        }

        private void btnKockaszam_Click(object sender, EventArgs e)
        {
            audio.klikkhang();
            kockaszam = int.Parse(cbKockaSzam.SelectedItem.ToString());
            btnKockaszam.Enabled = false;
            btnDobas.Enabled = true;
            cbKockaSzam.Enabled = false;
            lbErtekel.Items.Add($"{kockaszam} kockával zajlik a kör");
        }

        private void btnDobas_Click(object sender, EventArgs e)
        {
            audio.kockahang();

            if (kockaszam == 1)
            {
                jatekos.Dobas(kockaszam);
                KepElhelyezJatekos(jatekos, jatekoskepek, kockaszam);
                gep.Dobas(kockaszam);
                KepElhelyezGep(gep, gepkepek, kockaszam);
                lblRelacio.Visible = true;

            }
            else if (kockaszam == 2)
            {
                jatekos.Dobas(kockaszam);
                KepElhelyezJatekos(jatekos, jatekoskepek, kockaszam);
                gep.Dobas(kockaszam);
                KepElhelyezGep(gep, gepkepek, kockaszam);
                lblRelacio.Visible = true;
            }
            else if (kockaszam == 3)
            {
                jatekos.Dobas(kockaszam);
                KepElhelyezJatekos(jatekos, jatekoskepek, kockaszam);
                gep.Dobas(kockaszam);
                KepElhelyezGep(gep, gepkepek, kockaszam);
                lblRelacio.Visible = true;

            }
            else if (kockaszam == 4)
            {
                jatekos.Dobas(kockaszam);
                KepElhelyezJatekos(jatekos, jatekoskepek, kockaszam);
                gep.Dobas(kockaszam);
                KepElhelyezGep(gep, gepkepek, kockaszam);
                lblRelacio.Visible = true;
            }
            else if (kockaszam == 5)
            {
                jatekos.Dobas(kockaszam);
                KepElhelyezJatekos(jatekos, jatekoskepek, kockaszam);
                gep.Dobas(kockaszam);
                KepElhelyezGep(gep, gepkepek, kockaszam);
                lblRelacio.Visible = true;
            }

            if (jatekos.Kiertekel() > gep.Kiertekel())
            {
                bonus = jatekos.Kiertekel();
                lbErtekel.Items.Add($"Játékos pontjai: {jatekos.Kiertekel()}");
                lbErtekel.Items.Add($"Gép pontjai: {gep.Kiertekel()}");
                lbErtekel.Items.Add($"Játékos nyert!");
                lbErtekel.Items.Add($"Nyeremény: {tet * 2} Palma Kredit + ");
                lbErtekel.Items.Add($"{bonus} győzelmi bónusz");
                lblRelacio.Text = ">";
                NyertKifizet(bonus);
            }
            else if (jatekos.Kiertekel() < gep.Kiertekel())
            {
                lbErtekel.Items.Add($"Játékos pontjai: {jatekos.Kiertekel()}");
                lbErtekel.Items.Add($"Gép pontjai: {gep.Kiertekel()}");
                lbErtekel.Items.Add($"Gép nyert!");
                lblRelacio.Text = "<";
            }
            else if (jatekos.Kiertekel() == gep.Kiertekel())
            {
                lbErtekel.Items.Add($"Játékos pontjai: {jatekos.Kiertekel()}");
                lbErtekel.Items.Add($"Gép pontjai: {gep.Kiertekel()}");
                lbErtekel.Items.Add($"Döntetlen!");
                lbErtekel.Items.Add($"Tét jóváírása");
                DontetlenKifizet();
                lblRelacio.Text = "=";
            }

            btnUjjatek.Enabled = true;
            btnVissza.Enabled = true;
            btnDobas.Enabled = false;
        }

        private void btnUjjatek_Click(object sender, EventArgs e)
        {
            audio.klikkhang();
            btnVissza.Enabled = true;
            cbTetkivalaszt.Enabled = true;
            btnBefizet.Enabled = true;
            lbErtekel.Items.Clear();


            pbG1.Visible = false;
            pbG2.Visible = false;
            pbG3.Visible = true;
            pbG3.Image = CasinoBeta.Properties.Resources.defaultKocka;
            pbG4.Visible = false;
            pbG5.Visible = false;

            pbJ1.Visible = false;
            pbJ2.Visible = false;
            pbJ3.Visible = true;
            pbJ3.Image = CasinoBeta.Properties.Resources.defaultKocka;
            pbJ4.Visible = false;
            pbJ5.Visible = false;

            lblRelacio.Visible = false;

            TetFeltoltes();
            cbTetkivalaszt.SelectedIndex = 0;

            if (felhasznalo.Egyenleg<10)
            {
                HusegBonusz();
            }
        }

        private void btnVissza_Click(object sender, EventArgs e)
        {
            audio.visszahang();
            this.Dispose();
            GC.Collect();
            frmKockaMenu formkockamenu = new frmKockaMenu(adatbazis, felhasznalo);
            formkockamenu.ShowDialog();
        }

        void TetFeltoltes()
        {
            cbTetkivalaszt.Items.Clear();

            List<int> tetek = new List<int>();

            tetek.Add(1);
            tetek.Add(5);
            tetek.Add(10);
            tetek.Add(50);
            tetek.Add(75);
            tetek.Add(100);
            tetek.Add(250);
            tetek.Add(500);
            tetek.Add(750);
            tetek.Add(1000);
            tetek.Add(3000);
            tetek.Add(5000);
            tetek.Add(10000);
            tetek.Add(25000);
            tetek.Add(50000);
            tetek.Add(75000);
            tetek.Add(100000);
            tetek.Add(250000);
            tetek.Add(500000);
            tetek.Add(750000);
            tetek.Add(1000000);
            tetek.Add(3000000);
            tetek.Add(5000000);
            tetek.Add(10000000);

            for (int i = 0; i < tetek.Count; i++)
            {
                if (tetek[i] < felhasznalo.Egyenleg)
                {
                    cbTetkivalaszt.Items.Add(tetek[i]);
                }
            }

        }

        void KockaSzamFeltoltes()
        {
            for (int i = 1; i < 6; i++)
            {
                cbKockaSzam.Items.Add(i);
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

        private void NyertKifizet(int bonus)
        {
            audio.kifizethang();
            adatbazis.MysqlKapcsolat.Open();
            felhasznalo.Egyenleg += (tet * 2) + bonus;
            lblAktiv.Text = $"{felhasznalo.Nev}: {felhasznalo.Egyenleg}";
            string frissit = $"UPDATE felhasznalok SET egyenleg = {felhasznalo.Egyenleg} where felhasznalonev = '" + felhasznalo.Nev + "';";
            MySqlCommand frissito = new MySqlCommand(frissit, adatbazis.MysqlKapcsolat);
            frissito.ExecuteNonQuery();
            adatbazis.MysqlKapcsolat.Close();
        }

        private void DontetlenKifizet()
        {
            audio.kifizethang();
            adatbazis.MysqlKapcsolat.Open();
            felhasznalo.Egyenleg += tet;
            lblAktiv.Text = $"{felhasznalo.Nev}: {felhasznalo.Egyenleg}";
            string frissit = $"UPDATE felhasznalok SET egyenleg = {felhasznalo.Egyenleg} where felhasznalonev = '" + felhasznalo.Nev + "';";
            MySqlCommand frissito = new MySqlCommand(frissit, adatbazis.MysqlKapcsolat);
            frissito.ExecuteNonQuery();
            adatbazis.MysqlKapcsolat.Close();
        }

        static void KepElhelyezJatekos(NagyobbMintKockajatek jatekos, PictureBox[] kepek, int dobasszam)
        {

            if (dobasszam == 1)
            {
                kepek[0].Visible = false;
                kepek[1].Visible = false;
                kepek[2].Visible = true;
                kepek[3].Visible = false;
                kepek[4].Visible = false;

                switch (jatekos.dobas[0])
                {
                    case 1:
                        kepek[2].Image = CasinoBeta.Properties.Resources.KockaPirosEgy;
                        break;
                    case 2:
                        kepek[2].Image = CasinoBeta.Properties.Resources.KockaPirosKetto;
                        break;
                    case 3:
                        kepek[2].Image = CasinoBeta.Properties.Resources.KockaPirosHarom;
                        break;
                    case 4:
                        kepek[2].Image = CasinoBeta.Properties.Resources.KockaPirosNegy;
                        break;
                    case 5:
                        kepek[2].Image = CasinoBeta.Properties.Resources.KockaPirosOt;
                        break;
                    case 6:
                        kepek[2].Image = CasinoBeta.Properties.Resources.KockaPirosHat;
                        break;
                    default:
                        break;
                }
            }
            else if (dobasszam == 2)
            {

                kepek[0].Visible = true;
                kepek[1].Visible = false;
                kepek[2].Visible = false;
                kepek[3].Visible = false;
                kepek[4].Visible = true;

                switch (jatekos.dobas[0])
                {
                    case 1:
                        kepek[0].Image = CasinoBeta.Properties.Resources.KockaPirosEgy;
                        break;
                    case 2:
                        kepek[0].Image = CasinoBeta.Properties.Resources.KockaPirosKetto;
                        break;
                    case 3:
                        kepek[0].Image = CasinoBeta.Properties.Resources.KockaPirosHarom;
                        break;
                    case 4:
                        kepek[0].Image = CasinoBeta.Properties.Resources.KockaPirosNegy;
                        break;
                    case 5:
                        kepek[0].Image = CasinoBeta.Properties.Resources.KockaPirosOt;
                        break;
                    case 6:
                        kepek[0].Image = CasinoBeta.Properties.Resources.KockaPirosHat;
                        break;
                    default:
                        break;
                }

                switch (jatekos.dobas[1])
                {
                    case 1:
                        kepek[4].Image = CasinoBeta.Properties.Resources.KockaPirosEgy;
                        break;
                    case 2:
                        kepek[4].Image = CasinoBeta.Properties.Resources.KockaPirosKetto;
                        break;
                    case 3:
                        kepek[4].Image = CasinoBeta.Properties.Resources.KockaPirosHarom;
                        break;
                    case 4:
                        kepek[4].Image = CasinoBeta.Properties.Resources.KockaPirosNegy;
                        break;
                    case 5:
                        kepek[4].Image = CasinoBeta.Properties.Resources.KockaPirosOt;
                        break;
                    case 6:
                        kepek[4].Image = CasinoBeta.Properties.Resources.KockaPirosHat;
                        break;
                    default:
                        break;
                }
            }

            else if (dobasszam == 3)
            {
                kepek[0].Visible = true;
                kepek[1].Visible = false;
                kepek[2].Visible = true;
                kepek[3].Visible = false;
                kepek[4].Visible = true;

                switch (jatekos.dobas[0])
                {
                    case 1:
                        kepek[0].Image = CasinoBeta.Properties.Resources.KockaPirosEgy;
                        break;
                    case 2:
                        kepek[0].Image = CasinoBeta.Properties.Resources.KockaPirosKetto;
                        break;
                    case 3:
                        kepek[0].Image = CasinoBeta.Properties.Resources.KockaPirosHarom;
                        break;
                    case 4:
                        kepek[0].Image = CasinoBeta.Properties.Resources.KockaPirosNegy;
                        break;
                    case 5:
                        kepek[0].Image = CasinoBeta.Properties.Resources.KockaPirosOt;
                        break;
                    case 6:
                        kepek[0].Image = CasinoBeta.Properties.Resources.KockaPirosHat;
                        break;
                    default:
                        break;
                }

                switch (jatekos.dobas[1])
                {
                    case 1:
                        kepek[2].Image = CasinoBeta.Properties.Resources.KockaPirosEgy;
                        break;
                    case 2:
                        kepek[2].Image = CasinoBeta.Properties.Resources.KockaPirosKetto;
                        break;
                    case 3:
                        kepek[2].Image = CasinoBeta.Properties.Resources.KockaPirosHarom;
                        break;
                    case 4:
                        kepek[2].Image = CasinoBeta.Properties.Resources.KockaPirosNegy;
                        break;
                    case 5:
                        kepek[2].Image = CasinoBeta.Properties.Resources.KockaPirosOt;
                        break;
                    case 6:
                        kepek[2].Image = CasinoBeta.Properties.Resources.KockaPirosHat;
                        break;
                    default:
                        break;
                }

                switch (jatekos.dobas[2])
                {
                    case 1:
                        kepek[4].Image = CasinoBeta.Properties.Resources.KockaPirosEgy;
                        break;
                    case 2:
                        kepek[4].Image = CasinoBeta.Properties.Resources.KockaPirosKetto;
                        break;
                    case 3:
                        kepek[4].Image = CasinoBeta.Properties.Resources.KockaPirosHarom;
                        break;
                    case 4:
                        kepek[4].Image = CasinoBeta.Properties.Resources.KockaPirosNegy;
                        break;
                    case 5:
                        kepek[4].Image = CasinoBeta.Properties.Resources.KockaPirosOt;
                        break;
                    case 6:
                        kepek[4].Image = CasinoBeta.Properties.Resources.KockaPirosHat;
                        break;
                    default:
                        break;
                }
            }

            else if (dobasszam == 4)
            {
                kepek[0].Visible = true;
                kepek[1].Visible = true;
                kepek[2].Visible = false;
                kepek[3].Visible = true;
                kepek[4].Visible = true;

                switch (jatekos.dobas[0])
                {
                    case 1:
                        kepek[0].Image = CasinoBeta.Properties.Resources.KockaPirosEgy;
                        break;
                    case 2:
                        kepek[0].Image = CasinoBeta.Properties.Resources.KockaPirosKetto;
                        break;
                    case 3:
                        kepek[0].Image = CasinoBeta.Properties.Resources.KockaPirosHarom;
                        break;
                    case 4:
                        kepek[0].Image = CasinoBeta.Properties.Resources.KockaPirosNegy;
                        break;
                    case 5:
                        kepek[0].Image = CasinoBeta.Properties.Resources.KockaPirosOt;
                        break;
                    case 6:
                        kepek[0].Image = CasinoBeta.Properties.Resources.KockaPirosHat;
                        break;
                    default:
                        break;
                }
                switch (jatekos.dobas[1])
                {
                    case 1:
                        kepek[1].Image = CasinoBeta.Properties.Resources.KockaPirosEgy;
                        break;
                    case 2:
                        kepek[1].Image = CasinoBeta.Properties.Resources.KockaPirosKetto;
                        break;
                    case 3:
                        kepek[1].Image = CasinoBeta.Properties.Resources.KockaPirosHarom;
                        break;
                    case 4:
                        kepek[1].Image = CasinoBeta.Properties.Resources.KockaPirosNegy;
                        break;
                    case 5:
                        kepek[1].Image = CasinoBeta.Properties.Resources.KockaPirosOt;
                        break;
                    case 6:
                        kepek[1].Image = CasinoBeta.Properties.Resources.KockaPirosHat;
                        break;
                    default:
                        break;
                }
                switch (jatekos.dobas[2])
                {
                    case 1:
                        kepek[3].Image = CasinoBeta.Properties.Resources.KockaPirosEgy;
                        break;
                    case 2:
                        kepek[3].Image = CasinoBeta.Properties.Resources.KockaPirosKetto;
                        break;
                    case 3:
                        kepek[3].Image = CasinoBeta.Properties.Resources.KockaPirosHarom;
                        break;
                    case 4:
                        kepek[3].Image = CasinoBeta.Properties.Resources.KockaPirosNegy;
                        break;
                    case 5:
                        kepek[3].Image = CasinoBeta.Properties.Resources.KockaPirosOt;
                        break;
                    case 6:
                        kepek[3].Image = CasinoBeta.Properties.Resources.KockaPirosHat;
                        break;
                    default:
                        break;
                }
                switch (jatekos.dobas[3])
                {
                    case 1:
                        kepek[4].Image = CasinoBeta.Properties.Resources.KockaPirosEgy;
                        break;
                    case 2:
                        kepek[4].Image = CasinoBeta.Properties.Resources.KockaPirosKetto;
                        break;
                    case 3:
                        kepek[4].Image = CasinoBeta.Properties.Resources.KockaPirosHarom;
                        break;
                    case 4:
                        kepek[4].Image = CasinoBeta.Properties.Resources.KockaPirosNegy;
                        break;
                    case 5:
                        kepek[4].Image = CasinoBeta.Properties.Resources.KockaPirosOt;
                        break;
                    case 6:
                        kepek[4].Image = CasinoBeta.Properties.Resources.KockaPirosHat;
                        break;
                    default:
                        break;
                }
            }

            else if (dobasszam == 5)
            {
                for (int i = 0; i < 5; i++)
                {
                    kepek[i].Visible = true;
                }

                for (int i = 0; i < kepek.Length; i++)
                {
                    switch (jatekos.dobas[i])
                    {
                        case 1:
                            kepek[i].Image = CasinoBeta.Properties.Resources.KockaPirosEgy;
                            break;
                        case 2:
                            kepek[i].Image = CasinoBeta.Properties.Resources.KockaPirosKetto;
                            break;
                        case 3:
                            kepek[i].Image = CasinoBeta.Properties.Resources.KockaPirosHarom;
                            break;
                        case 4:
                            kepek[i].Image = CasinoBeta.Properties.Resources.KockaPirosNegy;
                            break;
                        case 5:
                            kepek[i].Image = CasinoBeta.Properties.Resources.KockaPirosOt;
                            break;
                        case 6:
                            kepek[i].Image = CasinoBeta.Properties.Resources.KockaPirosHat;
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        static void KepElhelyezGep(NagyobbMintKockajatek jatekos, PictureBox[] kepek, int dobasszam)
        {
            if (dobasszam == 1)
            {
                kepek[0].Visible = false;
                kepek[1].Visible = false;
                kepek[2].Visible = true;
                kepek[3].Visible = false;
                kepek[4].Visible = false;

                switch (jatekos.dobas[0])
                {
                    case 1:
                        kepek[2].Image = CasinoBeta.Properties.Resources.KockaFeketeEgy;
                        break;
                    case 2:
                        kepek[2].Image = CasinoBeta.Properties.Resources.KockaFeketeKetto;
                        break;
                    case 3:
                        kepek[2].Image = CasinoBeta.Properties.Resources.KockaFeketeHarom;
                        break;
                    case 4:
                        kepek[2].Image = CasinoBeta.Properties.Resources.KockaFeketeNegy;
                        break;
                    case 5:
                        kepek[2].Image = CasinoBeta.Properties.Resources.KockaFeketeOt;
                        break;
                    case 6:
                        kepek[2].Image = CasinoBeta.Properties.Resources.KockaFeketeHat;
                        break;
                    default:
                        break;
                }
            }
            else if (dobasszam == 2)
            {

                kepek[0].Visible = true;
                kepek[1].Visible = false;
                kepek[2].Visible = false;
                kepek[3].Visible = false;
                kepek[4].Visible = true;

                switch (jatekos.dobas[0])
                {
                    case 1:
                        kepek[0].Image = CasinoBeta.Properties.Resources.KockaFeketeEgy;
                        break;
                    case 2:
                        kepek[0].Image = CasinoBeta.Properties.Resources.KockaFeketeKetto;
                        break;
                    case 3:
                        kepek[0].Image = CasinoBeta.Properties.Resources.KockaFeketeHarom;
                        break;
                    case 4:
                        kepek[0].Image = CasinoBeta.Properties.Resources.KockaFeketeNegy;
                        break;
                    case 5:
                        kepek[0].Image = CasinoBeta.Properties.Resources.KockaFeketeOt;
                        break;
                    case 6:
                        kepek[0].Image = CasinoBeta.Properties.Resources.KockaFeketeHat;
                        break;
                    default:
                        break;
                }

                switch (jatekos.dobas[1])
                {
                    case 1:
                        kepek[4].Image = CasinoBeta.Properties.Resources.KockaFeketeEgy;
                        break;
                    case 2:
                        kepek[4].Image = CasinoBeta.Properties.Resources.KockaFeketeKetto;
                        break;
                    case 3:
                        kepek[4].Image = CasinoBeta.Properties.Resources.KockaFeketeHarom;
                        break;
                    case 4:
                        kepek[4].Image = CasinoBeta.Properties.Resources.KockaFeketeNegy;
                        break;
                    case 5:
                        kepek[4].Image = CasinoBeta.Properties.Resources.KockaFeketeOt;
                        break;
                    case 6:
                        kepek[4].Image = CasinoBeta.Properties.Resources.KockaFeketeHat;
                        break;
                    default:
                        break;
                }
            }

            else if (dobasszam == 3)
            {
                kepek[0].Visible = true;
                kepek[1].Visible = false;
                kepek[2].Visible = true;
                kepek[3].Visible = false;
                kepek[4].Visible = true;

                switch (jatekos.dobas[0])
                {
                    case 1:
                        kepek[0].Image = CasinoBeta.Properties.Resources.KockaFeketeEgy;
                        break;
                    case 2:
                        kepek[0].Image = CasinoBeta.Properties.Resources.KockaFeketeKetto;
                        break;
                    case 3:
                        kepek[0].Image = CasinoBeta.Properties.Resources.KockaFeketeHarom;
                        break;
                    case 4:
                        kepek[0].Image = CasinoBeta.Properties.Resources.KockaFeketeNegy;
                        break;
                    case 5:
                        kepek[0].Image = CasinoBeta.Properties.Resources.KockaFeketeOt;
                        break;
                    case 6:
                        kepek[0].Image = CasinoBeta.Properties.Resources.KockaFeketeHat;
                        break;
                    default:
                        break;
                }

                switch (jatekos.dobas[1])
                {
                    case 1:
                        kepek[2].Image = CasinoBeta.Properties.Resources.KockaFeketeEgy;
                        break;
                    case 2:
                        kepek[2].Image = CasinoBeta.Properties.Resources.KockaFeketeKetto;
                        break;
                    case 3:
                        kepek[2].Image = CasinoBeta.Properties.Resources.KockaFeketeHarom;
                        break;
                    case 4:
                        kepek[2].Image = CasinoBeta.Properties.Resources.KockaFeketeNegy;
                        break;
                    case 5:
                        kepek[2].Image = CasinoBeta.Properties.Resources.KockaFeketeOt;
                        break;
                    case 6:
                        kepek[2].Image = CasinoBeta.Properties.Resources.KockaFeketeHat;
                        break;
                    default:
                        break;
                }

                switch (jatekos.dobas[2])
                {
                    case 1:
                        kepek[4].Image = CasinoBeta.Properties.Resources.KockaFeketeEgy;
                        break;
                    case 2:
                        kepek[4].Image = CasinoBeta.Properties.Resources.KockaFeketeKetto;
                        break;
                    case 3:
                        kepek[4].Image = CasinoBeta.Properties.Resources.KockaFeketeHarom;
                        break;
                    case 4:
                        kepek[4].Image = CasinoBeta.Properties.Resources.KockaFeketeNegy;
                        break;
                    case 5:
                        kepek[4].Image = CasinoBeta.Properties.Resources.KockaFeketeOt;
                        break;
                    case 6:
                        kepek[4].Image = CasinoBeta.Properties.Resources.KockaFeketeHat;
                        break;
                    default:
                        break;
                }
            }

            else if (dobasszam == 4)
            {
                kepek[0].Visible = true;
                kepek[1].Visible = true;
                kepek[2].Visible = false;
                kepek[3].Visible = true;
                kepek[4].Visible = true;

                switch (jatekos.dobas[0])
                {
                    case 1:
                        kepek[0].Image = CasinoBeta.Properties.Resources.KockaFeketeEgy;
                        break;
                    case 2:
                        kepek[0].Image = CasinoBeta.Properties.Resources.KockaFeketeKetto;
                        break;
                    case 3:
                        kepek[0].Image = CasinoBeta.Properties.Resources.KockaFeketeHarom;
                        break;
                    case 4:
                        kepek[0].Image = CasinoBeta.Properties.Resources.KockaFeketeNegy;
                        break;
                    case 5:
                        kepek[0].Image = CasinoBeta.Properties.Resources.KockaFeketeOt;
                        break;
                    case 6:
                        kepek[0].Image = CasinoBeta.Properties.Resources.KockaFeketeHat;
                        break;
                    default:
                        break;
                }
                switch (jatekos.dobas[1])
                {
                    case 1:
                        kepek[1].Image = CasinoBeta.Properties.Resources.KockaFeketeEgy;
                        break;
                    case 2:
                        kepek[1].Image = CasinoBeta.Properties.Resources.KockaFeketeKetto;
                        break;
                    case 3:
                        kepek[1].Image = CasinoBeta.Properties.Resources.KockaFeketeHarom;
                        break;
                    case 4:
                        kepek[1].Image = CasinoBeta.Properties.Resources.KockaFeketeNegy;
                        break;
                    case 5:
                        kepek[1].Image = CasinoBeta.Properties.Resources.KockaFeketeOt;
                        break;
                    case 6:
                        kepek[1].Image = CasinoBeta.Properties.Resources.KockaFeketeHat;
                        break;
                    default:
                        break;
                }
                switch (jatekos.dobas[2])
                {
                    case 1:
                        kepek[3].Image = CasinoBeta.Properties.Resources.KockaFeketeEgy;
                        break;
                    case 2:
                        kepek[3].Image = CasinoBeta.Properties.Resources.KockaFeketeKetto;
                        break;
                    case 3:
                        kepek[3].Image = CasinoBeta.Properties.Resources.KockaFeketeHarom;
                        break;
                    case 4:
                        kepek[3].Image = CasinoBeta.Properties.Resources.KockaFeketeNegy;
                        break;
                    case 5:
                        kepek[3].Image = CasinoBeta.Properties.Resources.KockaFeketeOt;
                        break;
                    case 6:
                        kepek[3].Image = CasinoBeta.Properties.Resources.KockaFeketeHat;
                        break;
                    default:
                        break;
                }
                switch (jatekos.dobas[3])
                {
                    case 1:
                        kepek[4].Image = CasinoBeta.Properties.Resources.KockaFeketeEgy;
                        break;
                    case 2:
                        kepek[4].Image = CasinoBeta.Properties.Resources.KockaFeketeKetto;
                        break;
                    case 3:
                        kepek[4].Image = CasinoBeta.Properties.Resources.KockaFeketeHarom;
                        break;
                    case 4:
                        kepek[4].Image = CasinoBeta.Properties.Resources.KockaFeketeNegy;
                        break;
                    case 5:
                        kepek[4].Image = CasinoBeta.Properties.Resources.KockaFeketeOt;
                        break;
                    case 6:
                        kepek[4].Image = CasinoBeta.Properties.Resources.KockaFeketeHat;
                        break;
                    default:
                        break;
                }
            }

            else if (dobasszam == 5)
            {
                for (int i = 0; i < 5; i++)
                {
                    kepek[i].Visible = true;
                }

                for (int i = 0; i < kepek.Length; i++)
                {
                    switch (jatekos.dobas[i])
                    {
                        case 1:
                            kepek[i].Image = CasinoBeta.Properties.Resources.KockaFeketeEgy;
                            break;
                        case 2:
                            kepek[i].Image = CasinoBeta.Properties.Resources.KockaFeketeKetto;
                            break;
                        case 3:
                            kepek[i].Image = CasinoBeta.Properties.Resources.KockaFeketeHarom;
                            break;
                        case 4:
                            kepek[i].Image = CasinoBeta.Properties.Resources.KockaFeketeNegy;
                            break;
                        case 5:
                            kepek[i].Image = CasinoBeta.Properties.Resources.KockaFeketeOt;
                            break;
                        case 6:
                            kepek[i].Image = CasinoBeta.Properties.Resources.KockaFeketeHat;
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private void HusegBonusz()
        {
            adatbazis.MysqlKapcsolat.Open();
            felhasznalo.Egyenleg += 1000;
            lblAktiv.Text = $"{felhasznalo.Nev}: {felhasznalo.Egyenleg}";
            string frissit = $"UPDATE felhasznalok SET egyenleg = {felhasznalo.Egyenleg} where felhasznalonev = '" + felhasznalo.Nev + "';";
            MySqlCommand frissito = new MySqlCommand(frissit, adatbazis.MysqlKapcsolat);
            frissito.ExecuteNonQuery();
            adatbazis.MysqlKapcsolat.Close();
            MessageBox.Show("1000 Palma kredit hűségbónusz üti a markod!", "Gratulálunk!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            TetFeltoltes();
        }
    }
}