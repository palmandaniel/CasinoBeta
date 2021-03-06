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
        Media audio = new Media();

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
            lbNagyobb.Items.Add("Először a játékosok megteszik,");
            lbNagyobb.Items.Add("tétjeiket, majd negállapodnak");
            lbNagyobb.Items.Add("hány darab kockával szeretnének játszani,");
            lbNagyobb.Items.Add("Akinek nagyobb értékű dobása van, ");
            lbNagyobb.Items.Add("megnyerte az adott kört.");

            lbKockapoker.Items.Add("Klasszikus kockapóker játék.");
            lbKockapoker.Items.Add("Mindkét játékos öt kockát dob el,");
            lbKockapoker.Items.Add("majd kiértékelik dobásaikat.");
            lbKockapoker.Items.Add("Akinek nagyobb értékű dobása van,");
            lbKockapoker.Items.Add("megyneri a kört, és bezsebeli a");
            lbKockapoker.Items.Add("győzelmi bónuszt!");

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
            audio.visszahang();
            frmFomenu formFomenu = new frmFomenu(adatbazis, felhasznalo);
            this.Dispose();
            GC.Collect();
            formFomenu.ShowDialog();
        }

        private void btnNagyobb_Click(object sender, EventArgs e)
        {
            audio.klikkhang();
            frmNagyobbKocka formNagyobbKocka = new frmNagyobbKocka(adatbazis, felhasznalo);
            this.Dispose();
            GC.Collect();
            formNagyobbKocka.ShowDialog();
        }

        private void btnKockapoker_Click(object sender, EventArgs e)
        {
            audio.klikkhang();
            frmKockaPoker formKockaPoker = new frmKockaPoker(adatbazis, felhasznalo);
            this.Dispose();
            GC.Collect();
            formKockaPoker.ShowDialog();
        }

    }
}
