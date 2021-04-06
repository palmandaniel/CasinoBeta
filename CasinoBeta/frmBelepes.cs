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
    public partial class frmBelepes : Form
    {
        DB adatbazis;
        User felhasznalo;

        public frmBelepes()
        {
            InitializeComponent();
            adatbazis = new DB("localhost", "casinobeta", "root");
        }

        private void btnBelepes_Click(object sender, EventArgs e)
        {
            string felhasznalonev = tbFelhasznalonev.Text;
            string jelszo = tbJelszo.Text;

            if (felhasznalonev != "" && jelszo != "")
            {
                try
                {
                    adatbazis.MysqlKapcsolat.Open();

                    string lekerdezes = "SELECT felhasznalonev, jelszo, jogkor_id, teljesnev FROM felhasznalok " +
                    "WHERE felhasznalonev = '" + felhasznalonev + "' and jelszo = '" + jelszo + "';";

                    MySqlDataReader sorok;
                    MySqlCommand parancs = new MySqlCommand(lekerdezes, adatbazis.MysqlKapcsolat);
                    sorok = parancs.ExecuteReader();

                    if (sorok.HasRows)
                    {
                        while (sorok.Read())
                        {
                            string felhasznaloNev = sorok["felhasznalonev"].ToString();
                            string felhasznaloJelszo = sorok["jelszo"].ToString();
                            string jogkor_id = sorok["jogkor_id"].ToString();
                            string teljesnev = sorok["teljesnev"].ToString();

                            felhasznalo = new User(felhasznaloNev, felhasznaloJelszo, jogkor_id, teljesnev);
                        }

                        MessageBox.Show("Köszöntelek: " + felhasznalo.TeljesNev);
                        adatbazis.MysqlKapcsolat.Close();
                        frmFomenu formFomenu = new frmFomenu(adatbazis, felhasznalo);
                        formFomenu.ShowDialog();
                        this.Dispose();
                        GC.Collect();
                    }
                    else
                    {
                        MessageBox.Show("Felhasználónév vagy jelszó nem jó!", "Hiba",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        adatbazis.MysqlKapcsolat.Close();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Number + ":" + ex.Message, "Hiba",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    adatbazis.MysqlKapcsolat.Close();
                }
            }
            else
            {
                MessageBox.Show("Felhasználónév vagy jelszó nem lehet üres!", "Hiba",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegisztral_Click(object sender, EventArgs e)
        {
            frmRegisztral formregisztral = new frmRegisztral(adatbazis);
            formregisztral.ShowDialog();
            this.Dispose();
            GC.Collect();
        }
    }
}
