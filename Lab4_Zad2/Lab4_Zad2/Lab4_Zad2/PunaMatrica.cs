using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Zad2
{
    class PunaMatrica : IKvadratnaMatrica
    {
        private int vrsta, kolona; // broj vrsta i broj kolona
        private int dimenzijaPune;
        private float[,] podaci;

        public PunaMatrica(int vrsta, int kolona, int dimPune)
        {
            // konstruktor koji postavlja broj vrsta i broj kolona
            this.vrsta = vrsta;
            this.kolona = kolona;
            this.dimenzijaPune = dimPune;
            this.podaci = new float[vrsta, kolona];
        }

        public PunaMatrica(PunaMatrica matrica)
        {
            // konstruktor koji radi kopiranje postojeće matrice
            this.vrsta = matrica.vrsta;
            this.kolona = matrica.kolona;
            this.podaci = new float[vrsta, kolona];
            for (int i = 0; i < vrsta; i++)
                for (int j = 0; j < kolona; j++)
                    podaci[i, j] = matrica.podaci[i, j];
        }

        // Indekser sa 2 dimenzije (2 argumenta). 
        public float this[int i, int j]
        {
            get { return podaci[i, j]; }
            set { this.podaci[i, j] = value; }
        }

        public Object PristupElementu
        {
            get { return null; }
            set { }
        }

        public int Determinanta()
        {
            return vrsta;
        }

        void IKvadratnaMatrica.Stampaj()
        {
            for (int i = 0; i < vrsta; i++)
            {
                for (int j = 0; j < kolona; j++)
                {
                    Console.Write(podaci[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

    }

   
}
