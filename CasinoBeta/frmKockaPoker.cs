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
    public partial class frmKockaPoker : Form
    {
        Media audio = new Media();

        DB adatbazis;
        User felhasznalo;
        public int tet = new int();
        PictureBox[] jatekoskepek = new PictureBox[5];
        PictureBox[] gepkepek = new PictureBox[5];

        KockaPoker jatekos = new KockaPoker();
        KockaPoker gep = new KockaPoker();

        int bonus = new int();

        public frmKockaPoker(DB adatbazis, User felhasznalo)
        {
            this.adatbazis = adatbazis;
            this.felhasznalo = felhasznalo;

            InitializeComponent();

            lblJatekos.Text = $"{felhasznalo.Nev}";
            TetFeltoltes();
            btnUjjatek.Enabled = false;
            lblAktiv.Text = ($"{felhasznalo.Nev}: {felhasznalo.Egyenleg}");
            lblAktiv.TextAlign = ContentAlignment.MiddleRight;
            btnVissza.Enabled = true;
            cbTetkivalaszt.SelectedIndex = 0;

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
            lblJatekosErteke.Visible = false;
            lblGepErteke.Visible = false;

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
            btnDobas.Enabled = true;
        }

        private void btnDobas_Click(object sender, EventArgs e)
        {
            audio.kockahang();
            jatekos.Dobas();
            KepelhelyezJatekos(jatekos, jatekoskepek);
            gep.Dobas();
            KepelhelyezGep(gep, gepkepek);
            lblJatekosErteke.Visible = true;
            lblGepErteke.Visible = true;
            lblJatekosErteke.Text = $"{jatekos.Eredmeny}";
            lblGepErteke.Text = $"{gep.Eredmeny}";
            bonus = jatekos.Pont;
            if (jatekos.Pont > gep.Pont)
            {
                lblRelacio.Visible = true;
                lblRelacio.Text = ">";
                lbErtekel.Items.Add($"Játékos pontjai: {jatekos.Pont}");
                lbErtekel.Items.Add($"Gép pontjai: {gep.Pont}");
                lbErtekel.Items.Add($"Játékos nyert!");
                lbErtekel.Items.Add($"Nyeremény: {tet * 2} Palma Kredit + ");
                lbErtekel.Items.Add($"{bonus} győzelmi bónusz");
                NyertKifizet(bonus);
            }
            else if (jatekos.Pont < gep.Pont)
            {
                lblRelacio.Visible = true;
                lblRelacio.Text = "<";
                lbErtekel.Items.Add($"Játékos pontjai: {jatekos.Pont}");
                lbErtekel.Items.Add($"Gép pontjai: {gep.Pont}");
                lbErtekel.Items.Add($"Gép nyert!");
            }
            else if (jatekos.Pont == gep.Pont)
            {
                lblRelacio.Visible = true;
                lblRelacio.Text = "=";
                lbErtekel.Items.Add($"Játékos pontjai: {jatekos.Pont}");
                lbErtekel.Items.Add($"Gép pontjai: {gep.Pont}");
                lbErtekel.Items.Add($"Döntetlen!");
                lbErtekel.Items.Add($"Tét jóváírása");
                DontetlenKifizet();
            }
            btnDobas.Enabled = false;
            btnUjjatek.Enabled = true;
            btnVissza.Enabled = true;
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
            lblJatekosErteke.Visible = false;
            lblGepErteke.Visible = false;
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

        static void KepelhelyezJatekos(KockaPoker jatekos, PictureBox[] kepek)
        {

            for (int i = 0; i < 5; i++)
            {
                kepek[i].Visible = true;
            }

            for (int i = 0; i < kepek.Length; i++)
            {
                switch (jatekos.Kockak[i])
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

        static void KepelhelyezGep(KockaPoker jatekos, PictureBox[] kepek)
        {
            for (int i = 0; i < 5; i++)
            {
                kepek[i].Visible = true;
            }

            for (int i = 0; i < kepek.Length; i++)
            {
                switch (jatekos.Kockak[i])
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
    }
}
