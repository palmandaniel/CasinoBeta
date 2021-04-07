using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoBeta
{
    public class User
    {
        private string nev;
        public string Nev
        {
            get { return nev; }
            set { nev = value; }
        }



        private string jelszo;
        public string Jelszo
        {
            get { return jelszo; }
            set { jelszo = value; }
        }



        private string jogkor;
        public string Jogkor
        {
            get { return jogkor; }
            set { jogkor = value; }
        }



        private string teljesNev;
        public string TeljesNev
        {
            get { return teljesNev; }
            set { teljesNev = value; }
        }

        private int egyenleg;

        public int Egyenleg
        {
            get { return egyenleg; }
            set { egyenleg = value; }
        }


        public User(string nev, string jelszo, string jogkor, string teljesNev, int egyenleg)
        {
            this.nev = nev;
            this.jelszo = jelszo;
            this.jogkor = jogkor;
            this.teljesNev = teljesNev;
            this.egyenleg = egyenleg;
        }
    }
}
