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
    public partial class frmKockaMenu : Form
    {
        DB adatbazis;
        User felhasznalo;

        public frmKockaMenu(DB adatbazis, User felhasznalo)
        {
            this.adatbazis = adatbazis;
            this.felhasznalo = felhasznalo;

            InitializeComponent();

            lblAktiv.Text = ($"{felhasznalo.Nev}: {felhasznalo.Egyenleg}");
            lblAktiv.TextAlign = ContentAlignment.MiddleRight;

            lbNagyobb.Items.Add("Nagyobb... mint kockajáték.");
            lbNagyobb.Items.Add("Beszédes címének köszönhetően");
            lbNagyobb.Items.Add("kitalálhatjuk a játék lényegét.");
            lbNagyobb.Items.Add("Először a játékosok megállapodnak,");
            lbNagyobb.Items.Add("hány darab kockával szeretnének játszani,");
            lbNagyobb.Items.Add("ezután megteszik tétjeiket.");
            lbNagyobb.Items.Add("Akinek nagyobb értékű dobása van, ");
            lbNagyobb.Items.Add("megnyerte az adott kört.");
        }

        private void btnKijelentkez_Click(object sender, EventArgs e)
        {
            frmBelepes formBelepes = new frmBelepes();
            this.Dispose();
            GC.Collect();
            formBelepes.ShowDialog();
        }

        private void btnFomenu_Click(object sender, EventArgs e)
        {
            frmFomenu formFomenu = new frmFomenu(adatbazis, felhasznalo);
            this.Dispose();
            GC.Collect();
            formFomenu.ShowDialog();
        }

        private void btnNagyobb_Click(object sender, EventArgs e)
        {
            frmNagyobbKocka formNagyobbKocka = new frmNagyobbKocka(adatbazis, felhasznalo);
            this.Dispose();
            GC.Collect();
            formNagyobbKocka.ShowDialog();
        }

        private void btnKockapoker_Click(object sender, EventArgs e)
        {
            frmKockaPoker formKockaPoker = new frmKockaPoker(adatbazis, felhasznalo);
            this.Dispose();
            GC.Collect();
            formKockaPoker.ShowDialog();
        }
    }
}
