using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CasinoBeta
{
    public class KeteselyPakli
    {
        public static List<KeteselyPakli> pakli = new List<KeteselyPakli>();

        private string szin;

        public string Szin
        {
            get { return szin; }
            set { szin = value; }
        }

        private string szam;

        public string Szam
        {
            get { return szam; }
            set { szam = value; }
        }

        private int ertek;

        public int Ertek
        {
            get { return ertek; }
            set { ertek = value; }
        }

        private string megnevezes;

        public string Megnevezes
        {
            get { return megnevezes; }
            set { megnevezes = value; }
        }

        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }


        public KeteselyPakli(string szin, string szam, int ertek, string megnevezes)
        {
            this.szin = szin;
            this.szam = szam;
            this.ertek = ertek;
            this.megnevezes = megnevezes;
            if (szin =="treff" || szin =="pikk")
            {
                color = "fekete";
            }
            else
            {
                color = "piros";
            }
        }

        public static void Beolvasas()
        {
            StreamReader file = new StreamReader("pakli.txt");
            file.ReadLine();

            while (!file.EndOfStream)
            {
                string[] adatok = file.ReadLine().Split(';');
                pakli.Add(new KeteselyPakli(adatok[0], adatok[1], int.Parse(adatok[2]), adatok[3]));
            }

            file.Close();
        }
    }
}
