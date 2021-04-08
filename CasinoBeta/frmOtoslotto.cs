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
    public partial class frmOtoslotto : Form
    {
        DB adatbazis;
        User felhasznalo;

        public static int talalat = new int();
        static List<int> szamok = new List<int>();
        static List<int> sorsoltak = new List<int>();
        static List<int> tippeltek = new List<int>();
        public static int tet = new int();

        static void Feltolt()
        {
            for (int i = 1; i < 91; i++)
            {
                szamok.Add(i);
            }
        }

        static List<int> Sorsol(List<int> sorsoltak)
        {
            Random r = new Random();
            for (int i = 0; i < 5; i++)
            {
                int szam = 0;
                szam = r.Next(1, 91).GetHashCode();
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

        static void Torles(List<int> sorsoltak, List<int> tippeltek, int talalat)
        {
            sorsoltak.Clear();
            tippeltek.Clear();
            talalat = 0;
        }

        public frmOtoslotto(DB adatbazis, User felhasznalo)
        {
            this.felhasznalo = felhasznalo;
            this.adatbazis = adatbazis;



            InitializeComponent();
            lblAktiv.Text = ($"{felhasznalo.Nev}: {felhasznalo.Egyenleg}");
            lblAktiv.TextAlign = ContentAlignment.MiddleRight;

            talalat = 0;
            btnVissza.Enabled = true;

            cbTetkivalaszt.Items.Add(100);
            cbTetkivalaszt.Items.Add(300);
            cbTetkivalaszt.Items.Add(500);
            cbTetkivalaszt.Items.Add(1000);
        }

        private void btnBefizet_Click(object sender, EventArgs e)
        {
            tbt1.Enabled = true;
            tbt2.Enabled = true;
            tbt3.Enabled = true;
            tbt4.Enabled = true;
            tbt5.Enabled = true;
            btnMegjatszom.Enabled = true;
            btnBefizet.Enabled = false;
            cbTetkivalaszt.Enabled = false;
        }

        private void btnMegjatszom_Click(object sender, EventArgs e)
        {
            btnVissza.Enabled = false;
            lbErtekel.Items.Add("Tippelés");
            bool valid = true;
            while (valid)
            {
                try
                {
                    int.Parse((tbt1.Text));
                    if (!Tartalmazza(tippeltek, int.Parse(tbt1.Text)) && int.Parse(tbt1.Text) > 0 && int.Parse(tbt1.Text) < 91)
                    {
                        tippeltek.Add(int.Parse(tbt1.Text));
                        tbt1.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Egy számot csak egyszer játszhatsz meg! A tippelt számnak 0 és 91 közé kell esnie!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbt1.Text = "";
                        tbt2.Text = "";
                        tbt3.Text = "";
                        tbt4.Text = "";
                        tbt5.Text = "";
                        tippeltek.Clear();
                        tbt1.Enabled = true;
                        tbt2.Enabled = true;
                        tbt3.Enabled = true;
                        tbt4.Enabled = true;
                        tbt5.Enabled = true;
                        valid = false;
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbt1.Text = "";
                    tbt2.Text = "";
                    tbt3.Text = "";
                    tbt4.Text = "";
                    tbt5.Text = "";
                    tippeltek.Clear();
                    tbt1.Enabled = true;
                    tbt2.Enabled = true;
                    tbt3.Enabled = true;
                    tbt4.Enabled = true;
                    tbt5.Enabled = true;
                    valid = false;
                }
                try
                {
                    int.Parse((tbt2.Text));
                    if (!Tartalmazza(tippeltek, int.Parse(tbt2.Text)) && int.Parse(tbt2.Text) > 0 && int.Parse(tbt2.Text) < 91)
                    {
                        tippeltek.Add(int.Parse(tbt2.Text));
                        tbt2.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Egy számot csak egyszer játszhatsz meg! A tippelt számnak 0 és 91 közé kell esnie!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbt1.Text = "";
                        tbt2.Text = "";
                        tbt3.Text = "";
                        tbt4.Text = "";
                        tbt5.Text = "";
                        tippeltek.Clear();
                        tbt1.Enabled = true;
                        tbt2.Enabled = true;
                        tbt3.Enabled = true;
                        tbt4.Enabled = true;
                        tbt5.Enabled = true;
                        valid = false;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbt1.Text = "";
                    tbt2.Text = "";
                    tbt3.Text = "";
                    tbt4.Text = "";
                    tbt5.Text = "";
                    tippeltek.Clear();
                    tbt1.Enabled = true;
                    tbt2.Enabled = true;
                    tbt3.Enabled = true;
                    tbt4.Enabled = true;
                    tbt5.Enabled = true;
                    valid = false;
                }
                try
                {
                    int.Parse((tbt3.Text));
                    if (!Tartalmazza(tippeltek, int.Parse(tbt3.Text)) && int.Parse(tbt3.Text) > 0 && int.Parse(tbt3.Text) < 91)
                    {
                        tippeltek.Add(int.Parse(tbt3.Text));
                        tbt3.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Egy számot csak egyszer játszhatsz meg! A tippelt számnak 0 és 91 közé kell esnie!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbt1.Text = "";
                        tbt2.Text = "";
                        tbt3.Text = "";
                        tbt4.Text = "";
                        tbt5.Text = "";
                        tippeltek.Clear();
                        tbt1.Enabled = true;
                        tbt2.Enabled = true;
                        tbt3.Enabled = true;
                        tbt4.Enabled = true;
                        tbt5.Enabled = true;
                        valid = false;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbt1.Text = "";
                    tbt2.Text = "";
                    tbt3.Text = "";
                    tbt4.Text = "";
                    tbt5.Text = "";
                    tippeltek.Clear();
                    tbt1.Enabled = true;
                    tbt2.Enabled = true;
                    tbt3.Enabled = true;
                    tbt4.Enabled = true;
                    tbt5.Enabled = true;
                    valid = false;
                }
                try
                {
                    int.Parse((tbt4.Text));
                    if (!Tartalmazza(tippeltek, int.Parse(tbt4.Text)) && int.Parse(tbt4.Text) > 0 && int.Parse(tbt4.Text) < 91)
                    {
                        tippeltek.Add(int.Parse(tbt4.Text));
                        tbt4.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Egy számot csak egyszer játszhatsz meg! A tippelt számnak 0 és 91 közé kell esnie!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbt1.Text = "";
                        tbt2.Text = "";
                        tbt3.Text = "";
                        tbt4.Text = "";
                        tbt5.Text = "";
                        tippeltek.Clear();
                        tbt1.Enabled = true;
                        tbt2.Enabled = true;
                        tbt3.Enabled = true;
                        tbt4.Enabled = true;
                        tbt5.Enabled = true;
                        valid = false;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbt1.Text = "";
                    tbt2.Text = "";
                    tbt3.Text = "";
                    tbt4.Text = "";
                    tbt5.Text = "";
                    tippeltek.Clear();
                    tbt1.Enabled = true;
                    tbt2.Enabled = true;
                    tbt3.Enabled = true;
                    tbt4.Enabled = true;
                    tbt5.Enabled = true;
                    valid = false;
                }
                try
                {
                    int.Parse((tbt5.Text));
                    if (!Tartalmazza(tippeltek, int.Parse(tbt5.Text)) && int.Parse(tbt5.Text) > 0 && int.Parse(tbt5.Text) < 91)
                    {
                        tippeltek.Add(int.Parse(tbt5.Text));
                        tbt5.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Egy számot csak egyszer játszhatsz meg! A tippelt számnak 0 és 91 közé kell esnie!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbt1.Text = "";
                        tbt2.Text = "";
                        tbt3.Text = "";
                        tbt4.Text = "";
                        tbt5.Text = "";
                        tippeltek.Clear();
                        tbt1.Enabled = true;
                        tbt2.Enabled = true;
                        tbt3.Enabled = true;
                        tbt4.Enabled = true;
                        tbt5.Enabled = true;
                        valid = false;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbt1.Text = "";
                    tbt2.Text = "";
                    tbt3.Text = "";
                    tbt4.Text = "";
                    tbt5.Text = "";
                    tippeltek.Clear();
                    tbt1.Enabled = true;
                    tbt2.Enabled = true;
                    tbt3.Enabled = true;
                    tbt4.Enabled = true;
                    tbt5.Enabled = true;
                    valid = false;
                } 
            }

            
            if (tippeltek.Count == 5)
            {
                btnMegjatszom.Enabled = false;
                tippeltek.Sort();
                for (int i = 1; i < 6; i++)
                {
                    lbErtekel.Items.Add($"{i}. tipp: {tippeltek[i - 1]}");
                }

                lbErtekel.Items.Add("Sorsolás");
                Sorsol(sorsoltak);
                tbs1.Text = sorsoltak[0].ToString();
                tbs2.Text = sorsoltak[1].ToString();
                tbs3.Text = sorsoltak[2].ToString();
                tbs4.Text = sorsoltak[3].ToString();
                tbs5.Text = sorsoltak[4].ToString();
                for (int i = 1; i < 6; i++)
                {
                    lbErtekel.Items.Add($"{i}.sorsolt: {sorsoltak[i - 1]}");
                }
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
                lbErtekel.Items.Add($"Találatok száma: {talalat}");

                btnUjjatek.Enabled = true;
                btnVissza.Enabled = true;
            }

            
        }

        private void btnUjjatek_Click(object sender, EventArgs e)
        {
            sorsoltak.Clear();
            tippeltek.Clear();
            talalat = 0;
            lbErtekel.Items.Clear();
            tet = 0;
            tbt1.Text = "";
            tbt2.Text = "";
            tbt3.Text = "";
            tbt4.Text = "";
            tbt5.Text = "";
            tbs1.Text = "";
            tbs2.Text = "";
            tbs3.Text = "";
            tbs4.Text = "";
            tbs5.Text = "";
            btnMegjatszom.Enabled = false;
            btnBefizet.Enabled = true;
            cbTetkivalaszt.Enabled = true;
        }

        private void btnVissza_Click_1(object sender, EventArgs e)
        {
            frmLottoMenu formLottoMenu = new frmLottoMenu(adatbazis, felhasznalo);
            GC.Collect();
            this.Dispose();
            formLottoMenu.ShowDialog();
        }
    }
}
