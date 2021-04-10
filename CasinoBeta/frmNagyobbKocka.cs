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
        DB adatbazis;
        User felhasznalo;
        public int kockaszam = new int();
        public int tet = new int();

        NagyobbMintKockajatek jatekos = new NagyobbMintKockajatek();
        NagyobbMintKockajatek gep = new NagyobbMintKockajatek();

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
        }

        private void btnBefizet_Click(object sender, EventArgs e)
        {
            tet = int.Parse(cbTetkivalaszt.SelectedItem.ToString());
            btnBefizet.Enabled = false;
            btnKockaszam.Enabled = true;
            cbTetkivalaszt.Enabled = false;
            cbKockaSzam.Enabled = true;
            btnVissza.Enabled = false;
        }

        private void btnKockaszam_Click(object sender, EventArgs e)
        {
            kockaszam = int.Parse(cbKockaSzam.SelectedItem.ToString());
            btnKockaszam.Enabled = false;
            btnDobas.Enabled = true;
            cbKockaSzam.Enabled = false;
        }

        private void btnDobas_Click(object sender, EventArgs e)
        {

            if (kockaszam == 1)
            {
                jatekos.Dobas(kockaszam);
                KepElhelyezJatekos(jatekos, pbJ3);
            }
            else if (kockaszam == 2)
            {

            }
            else if (kockaszam == 3)
            {

            }
            else if (kockaszam == 4)
            {

            }
            else if (kockaszam == 5)
            {

            }

            btnUjjatek.Enabled = true;
        }

        private void btnUjjatek_Click(object sender, EventArgs e)
        {
            btnVissza.Enabled = true;
            btnBefizet.Enabled = true;
            lbErtekel.Items.Clear();
        }

        private void btnVissza_Click(object sender, EventArgs e)
        {
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

        static void KepElhelyezJatekos(NagyobbMintKockajatek jatekos, PictureBox pb)
        {
            for (int i = 0; i < jatekos.dobas.Count; i++)
            {
                switch (jatekos.dobas[i])
                {
                    case 1:
                        pb.Image = CasinoBeta.Properties.Resources.KockaPirosEgy;
                        break;
                    case 2:
                        pb.Image = CasinoBeta.Properties.Resources.KockaPirosKetto;
                        break;
                    case 3:
                        pb.Image = CasinoBeta.Properties.Resources.KockaPirosHarom;
                        break;
                    case 4:
                        pb.Image = CasinoBeta.Properties.Resources.KockaPirosNegy;
                        break;
                    case 5:
                        pb.Image = CasinoBeta.Properties.Resources.KockaPirosOt;
                        break;
                    case 6:
                        pb.Image = CasinoBeta.Properties.Resources.KockaPirosHat;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
