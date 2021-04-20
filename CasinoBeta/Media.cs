using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace CasinoBeta
{
    public class Media
    {
        public void udvozleshang()
        {
            SoundPlayer udvozles = new SoundPlayer(CasinoBeta.Properties.Resources.hangudvozles);
            udvozles.Play();
        }

        public  void klikkhang()
        {
            SoundPlayer klikk = new SoundPlayer(CasinoBeta.Properties.Resources.hangklikk);
            klikk.Play();
        }

        public void visszahang()
        {
            SoundPlayer vissza = new SoundPlayer(CasinoBeta.Properties.Resources.hangvissza);
            vissza.Play();
        }

        public void befizethang()
        {
            SoundPlayer befizet = new SoundPlayer(CasinoBeta.Properties.Resources.hangapropenz);
            befizet.Play();
        }

        public void kifizethang()
        {
            SoundPlayer kifizet = new SoundPlayer(CasinoBeta.Properties.Resources.hangkifizet);
            kifizet.Play();
        }

        public void kockahang()
        {
            List<SoundPlayer> hangok = new List<SoundPlayer>();
            SoundPlayer kockaegy = new SoundPlayer(CasinoBeta.Properties.Resources.hangkockadobas1);
            SoundPlayer kockaketto = new SoundPlayer(CasinoBeta.Properties.Resources.hangkockadobas2);
            SoundPlayer kockaharom = new SoundPlayer(CasinoBeta.Properties.Resources.hangkockadobas3);
            SoundPlayer kockanegy = new SoundPlayer(CasinoBeta.Properties.Resources.hangkockadobas4);
            hangok.Add(kockaegy);
            hangok.Add(kockaketto);
            hangok.Add(kockaharom);
            hangok.Add(kockanegy);

            Random vel = new Random(Guid.NewGuid().GetHashCode());
            int hangindex = vel.Next(0, hangok.Count);
            var hang = hangok[hangindex];
            hang.Play();
 
        }

        public void kartyahang()
        {
            List<SoundPlayer> hangok = new List<SoundPlayer>();

            SoundPlayer kartyaegy = new SoundPlayer(CasinoBeta.Properties.Resources.hangkartya1);
            SoundPlayer kartyaketto = new SoundPlayer(CasinoBeta.Properties.Resources.hangkartya2);
            SoundPlayer kartyaharom = new SoundPlayer(CasinoBeta.Properties.Resources.hangkartya3);
            SoundPlayer kartyanegy = new SoundPlayer(CasinoBeta.Properties.Resources.hangkartya4);
            SoundPlayer kartyaot = new SoundPlayer(CasinoBeta.Properties.Resources.hangkartya5);
            SoundPlayer kartyahat = new SoundPlayer(CasinoBeta.Properties.Resources.hangkartya6);
            SoundPlayer kartyahet = new SoundPlayer(CasinoBeta.Properties.Resources.hangkartya7);
            SoundPlayer kartyanyolc = new SoundPlayer(CasinoBeta.Properties.Resources.hangkartya8);
            SoundPlayer kartyakilenc = new SoundPlayer(CasinoBeta.Properties.Resources.hangkartya9);
            SoundPlayer kartyatiz = new SoundPlayer(CasinoBeta.Properties.Resources.hangkartya10);
            SoundPlayer kartyategy = new SoundPlayer(CasinoBeta.Properties.Resources.hangkartya11);
            SoundPlayer kartyatketto = new SoundPlayer(CasinoBeta.Properties.Resources.hangkartya12);
            SoundPlayer kartyatharom = new SoundPlayer(CasinoBeta.Properties.Resources.hangkartya12);

            hangok.Add(kartyaegy);
            hangok.Add(kartyaketto);
            hangok.Add(kartyaharom);
            hangok.Add(kartyanegy);
            hangok.Add(kartyaot);
            hangok.Add(kartyahat);
            hangok.Add(kartyahet);
            hangok.Add(kartyanyolc);
            hangok.Add(kartyakilenc);
            hangok.Add(kartyatiz);
            hangok.Add(kartyategy);
            hangok.Add(kartyatketto);
            hangok.Add(kartyatharom);

            Random vel = new Random(Guid.NewGuid().GetHashCode());
            int hangindex = vel.Next(0, hangok.Count);
            var hang = hangok[hangindex];
            hang.Play();
        }


        public SoundPlayer hatterzene()
        {
            SoundPlayer hatterzene = new SoundPlayer(CasinoBeta.Properties.Resources.hangbackground);
            hatterzene.PlayLooping();
            return hatterzene;
        }
        

    }
}
