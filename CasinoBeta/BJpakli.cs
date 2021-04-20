using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CasinoBeta
{
    class BJpakli
    {
        public static List<BJpakli> pakli = new List<BJpakli>();

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

        public BJpakli(string szin, string szam, int ertek, string megnevezes)
        {
            this.szin = szin;
            this.szam = szam;
            this.ertek = ertek;
            this.megnevezes = megnevezes;
        }

        public static void Beolvasas()
        {
            string[] file = CasinoBeta.Properties.Resources.pakli.Split('\n');


            for (int i = 1; i < file.Length; i++)
            {
                string[] adatok = file[i].Split(';');
                pakli.Add(new BJpakli(adatok[0], adatok[1], int.Parse(adatok[2]), adatok[3].TrimEnd()));
            }
        }
    }
}
