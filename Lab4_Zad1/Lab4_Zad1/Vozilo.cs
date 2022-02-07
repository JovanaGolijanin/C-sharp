using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Lab4_Zad1
{
    abstract class Vozilo
    {
        StanjeVozila stanjeVozila;
        protected int max_Brzina;
        protected int brzina;
        protected int potrosnja;


        //property
        public StanjeVozila PropertiStanjeVozila
        {
            get 
            { 
                return this.stanjeVozila; 
            }
            set 
            { 
                this.stanjeVozila = value;
            }
        }


        // Moguće je zadati property bez odgovarajućeg atributa tzv. automatski property. 
        // U ovom slučaju sam kompajler automatski generiše odgovarajući atribut koji 
        // je nama nevidljiv. 
        // Na ovaj način imamo kraći zapis i delimično ograničene mogućnosti korišćenja
        // jer nemamo kontrolu nad tim atributom.
        //ovde to radim jer hocu da ga implementiram u nasledjenoj klasi
        public abstract StanjeVrata this[int i]
        {
            get;
            set;
        }
        
   
          
    }
}
