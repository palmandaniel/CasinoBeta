using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoBeta
{
    class NagyobbMintKockajatek
    {
        public List<int> dobas = new List<int>();

        public void Dobas(int DobasSzam)
        {
            dobas.Clear();
            for (int i = 1; i <= DobasSzam; i++)
            {
                Random vel = new Random(Guid.NewGuid().GetHashCode());
                dobas.Add(vel.Next(1, 7));
            }
        }

        public int Kiertekel()
        {
            int ertek = 0;

            foreach (var d in dobas)
            {
                ertek += d;
            }

            return ertek;
        }

        public void Kiir()
        {
            foreach (var d in dobas)
            {
                Console.Write($" {d} ");
            }
        }
    }
}
