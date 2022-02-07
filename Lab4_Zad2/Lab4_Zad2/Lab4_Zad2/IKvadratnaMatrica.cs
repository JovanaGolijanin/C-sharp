using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Zad2
{
    internal interface IKvadratnaMatrica
    {
        // metoda za nalaženje determinante kvadratne matrice
        int Determinanta();

        // metoda za štampanje elemenata matrice na standardni izlaz
        void Stampaj();

        //indekser sa get i set delom za pristup elementima matrice
        Object PristupElementu
        { 
            get;
            set;
        }
      
    }
}
