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
    public partial class frmRegisztral : Form
    {
        DB adatbazis;
        static int egyenleg = 5000;
        Media audio = new Media();


        public frmRegisztral(DB adatbazis)
        {
            this.adatbazis = adatbazis;
            InitializeComponent();
        }

        private void btnRegisztral_Click(object sender, EventArgs e)
        {
            audio.klikkhang();
            string teljesnev = tbTeljesnev.Text;
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
                            string teljesNev = sorok["teljesnev"].ToString();
                            string felhasznaloJelszo = sorok["jelszo"].ToString();
                            string jogkor_id = sorok["jogkor_id"].ToString();
                        }

                        MessageBox.Show("Felhasználónév foglalt!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //this.Hide();
                        adatbazis.MysqlKapcsolat.Close();
                        //frmFo formFo = new frmFo(adatbazis, felhasznalo);
                        //formFo.ShowDialog();
                    }
                    else
                    {
                        adatbazis.MysqlKapcsolat.Close();
                        adatbazis.MysqlKapcsolat.Open();
                        string beilleszt = $"INSERT INTO felhasznalok (id, felhasznalonev, teljesnev, jelszo, egyenleg, jogkor_id) VALUES (NULL,'" + felhasznalonev + "', '" + teljesnev + "',  '" + jelszo + "', '" + egyenleg + "', '2')";

                        MySqlCommand beszur = new MySqlCommand(beilleszt, adatbazis.MysqlKapcsolat);
                        beszur.ExecuteNonQuery();

                        MessageBox.Show("Sikeres regisztráció!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        adatbazis.MysqlKapcsolat.Close();
                        this.Hide();
                        this.Dispose();
                        GC.Collect();
                        frmBelepes formbelepes = new frmBelepes();
                        formbelepes.ShowDialog();
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

        private void btnVissza_Click(object sender, EventArgs e)
        {
            audio.visszahang();
            this.Dispose();
            GC.Collect();
            frmBelepes formbelepes = new frmBelepes();
            formbelepes.ShowDialog();
        }

    }
}
