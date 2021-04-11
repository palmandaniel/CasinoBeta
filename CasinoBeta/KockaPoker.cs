using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoBeta
{
    class KockaPoker
    {
        int[] kockak = new int[5];

        public int[] Kockak
        {
            get { return kockak; }
        }

        private string eredmeny;
        public string Eredmeny
        {
            get
            {
                return eredmeny = Erteke(); 
            }
        }

        private int pont;
        public int Pont { get { return pont; } }

        public void Dobas()
        {

            Random vel = new Random(Guid.NewGuid().GetHashCode());
            for (int i = 0; i < kockak.Length; i++)
            {
                kockak[i] = vel.Next(1, 7);
            }

        }

        private string Erteke()
        {
            Dictionary<int, int> eredemeny = new Dictionary<int, int>();

            #region DictFeltolteseEgytolHatig
            for (int i = 1; i <= 6; i++)
            {
                eredemeny.Add(i, 0);
            }
            #endregion

            //DobasErtekeinekMegszamolasa
            foreach (var k in kockak)
            {
                eredemeny[k]++;
            }

            //ErtekekListavaAlakitasa
            var result = (from e in eredemeny
                          orderby e.Value descending
                          where e.Value > 1
                          select new { Szam = e.Key, Db = e.Value }).ToList();

            #region ListaKiertekeleseSzavakkalEsPontozas

            int darab = result.Count;
            if (darab == 1)
            {
                string[] egyes = new string[] { "", "", "Pár", "Drill", "Póker", "Nagypóker" };

                int[] pontok = new int[] { 0, 0, 10, 300, 600, 900 };
                pont = pontok[result[0].Db] + result[0].Szam;

                return $"{result[0].Szam} {egyes[result[0].Db]}";
            }
            else if (darab == 2)
            {
                if (result[0].Db == 3 && result[1].Db == 2)
                {
                    pont = 500 + (result[0].Szam * 10 + result[1].Szam);
                    return $"{result[0].Szam}-{result[1].Szam} Full";
                }
                else
                {
                    pont = 100 + (result[0].Szam * 10 + result[1].Szam);
                    return $"{result[1].Szam}-{result[0].Szam} Pár";
                }
            }
            else
            {
                if (eredemeny[6] == 0)
                {
                    pont = 700;
                    return "Kissor";
                }
                else if (eredemeny[1] == 0)
                {
                    pont = 800;
                    return "Nagysor";
                }

            }

            pont = 1;
            return "Szemét";
            #endregion
        }
    }
}
