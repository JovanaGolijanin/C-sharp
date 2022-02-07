using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Zad1
{
    class Automobil : Vozilo
    {
        //atribute stanjeVrata za svaka od 4 vrata
        //(da li su vrata otvorena ili zatvorena)
        //private int[] stanjeVrata = new int[4];
        private StanjeVrata[] stanjeVrata;


        //konstruktor koji postavlja sve vrednosti
        public Automobil(int max_Brzina, int brzina, int potrosnja, StanjeVrata stanje)
        {
            this.max_Brzina = max_Brzina;
            this.brzina = brzina;
            this.potrosnja = potrosnja;

            this.stanjeVrata = new StanjeVrata[4];
            for (int i = 0; i < stanjeVrata.Length; i++)
                this.stanjeVrata[i] = stanje;
        }


        //konstruktor za kopiranje
        public Automobil(Automobil a)
        {
            this.max_Brzina = a.max_Brzina;
            this.brzina = a.brzina;
            this.potrosnja=a.potrosnja;

            this.stanjeVrata = new StanjeVrata[4];
          
            for (int i = 0; i < stanjeVrata.Length; i++)
                 this.stanjeVrata[i] = a.stanjeVrata[i];

        }

        //defaultni konstruktor
        public Automobil()
        {
        }

        
        public void OtvoriVrata()
        {
            this.stanjeVrata = new StanjeVrata[4];
            for (int i = 0; i < stanjeVrata.Length; i++)
                 this.stanjeVrata[i] = StanjeVrata.otvorena;
        }

        public void ZatvoriVrata()
        {
            this.stanjeVrata = new StanjeVrata[4];
            for (int i = 0; i < stanjeVrata.Length; i++)
                this.stanjeVrata[i] = StanjeVrata.zatvorena;
        }
        


        // implementacija apstraktnog propertija
        // indekser treba da bude

        // Indexer - posebna vrsta property-ja. Koristi se ključna reč this i argument 
        // indexera između uglastih zagrada. U ovom slučaju je jedna dimenzija. Ako 
        // ima više dimenzija argumenti su razdvojeni zarezom. 
        public override StanjeVrata this[int i]
        {
            get
            {
                return stanjeVrata[i];
            }
            set
            {
                stanjeVrata[i] = value;
            }
        }


        //operatorsku funkciju ++ koja povećava brzinu za 10

        public static Automobil operator ++(Automobil a)
        {
            Automobil rezultat = new Automobil();
            rezultat.brzina = a.brzina + 10;
            rezultat.max_Brzina=a.max_Brzina;
            rezultat.potrosnja= a.potrosnja;
            rezultat.stanjeVrata = a.stanjeVrata;

            return rezultat;
        }

        // operatorsku funkciju -- koja smanjuje brzinu na 30. 
        public static Automobil operator --(Automobil a)
        {
            Automobil rezultat = new Automobil();
            a.brzina = 30;
            rezultat.brzina = a.brzina;
            rezultat.max_Brzina = a.max_Brzina;
            rezultat.potrosnja = a.potrosnja;
            rezultat.stanjeVrata = a.stanjeVrata;
            return rezultat;
             
        }

        public void Stampaj()
        {
            Console.Write("Maximalna brzina je: " + max_Brzina + ", brzina je: " + brzina + ", potrosnja je: " + potrosnja);
            Console.WriteLine();
            for (int i = 0; i < stanjeVrata.Length; i++)
            {
                Console.Write(" Stanje " + i + "." + " vrata je: " + this.stanjeVrata[i]);
                Console.WriteLine();
            }
            Console.WriteLine();
        }

    }
}

