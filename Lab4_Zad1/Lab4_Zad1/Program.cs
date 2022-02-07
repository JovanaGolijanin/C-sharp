using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Automobil Audi = new Automobil(200, 120, 100, StanjeVrata.otvorena);

            Audi.PropertiStanjeVozila = StanjeVozila.ukljuceno;
            Console.WriteLine("Stanje vozila je: " + Audi.PropertiStanjeVozila);

            Audi.PropertiStanjeVozila = StanjeVozila.iskljuceno;
            Console.WriteLine("Stanje vozila je: " + Audi.PropertiStanjeVozila);


             Audi.Stampaj();
             Audi++;
             Audi.Stampaj();
             Audi--;
             Audi.Stampaj();
             Audi.ZatvoriVrata();
             Audi.Stampaj();
             Audi.OtvoriVrata();
             Audi.Stampaj();

             Automobil Audi2 = new Automobil(300, 220, 200, StanjeVrata.zatvorena);
             Audi2.Stampaj();
             Audi = Audi2;
             Audi.Stampaj();
            

        }
    }
}
