using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IKvadratnaMatrica kvadratnaMatrica1;
            IKvadratnaMatrica kvadratnaMatrica2;


            PunaMatrica punaMatrica = new PunaMatrica(3,3,3);
            DijagonalnaMatrica dijagonalnaMatrica = new DijagonalnaMatrica(3,3,3);

            punaMatrica.Determinanta();
            dijagonalnaMatrica.Determinanta();


            kvadratnaMatrica1 = punaMatrica;
            kvadratnaMatrica2 = dijagonalnaMatrica;

            
            kvadratnaMatrica1.Stampaj();
            Console.WriteLine();
            kvadratnaMatrica2.Stampaj();
            Console.WriteLine();
        }
    }
}
