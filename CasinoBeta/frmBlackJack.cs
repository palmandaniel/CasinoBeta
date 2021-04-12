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
    public partial class frmBlackJack : Form
    {
        DB adatbazis;
        User felhasznalo;

        static List<BJpakli> jatszmaPakli = new List<BJpakli>();
        static List<BJpakli> jatekosPakli = new List<BJpakli>();
        static List<BJpakli> gepPakli = new List<BJpakli>();

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
            int aszdb = 0;

            foreach (var l in lista)
            {
                if (l.Szam == "Asz")
                {
                    aszdb++;
                }

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

            jatekoskepek[0] = pbj1;
            jatekoskepek[1] = pbj2;
            jatekoskepek[2] = pbj3;
            jatekoskepek[3] = pbj4;
            jatekoskepek[4] = pbj5;
            jatekoskepek[5] = pbj6;
            jatekoskepek[6] = pbj7;
            jatekoskepek[7] = pbj8;
            jatekoskepek[8] = pbj9;

            Osztas(2, jatekosPakli);
            Kepelhelyez(jatekosPakli, jatekoskepek);
        }

        static void Kepelhelyez(List<BJpakli> jatekos, PictureBox[] pb)
        {
            for (int i = 0; i < jatekos.Count; i++)
            {
                pb[i].Image = (Image)Properties.Resources.ResourceManager.GetObject(jatekos[i].Megnevezes);
            }
        }

    }
}
