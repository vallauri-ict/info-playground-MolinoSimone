using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04
{
    class mannaro:mostro
    {
        public int punti;

        public mannaro(string n)
        {
            nome = n;
            punti = 500;
        }

        public double Valore_Proprio()
        { // punti Mannaro
            return punti; 
        } 
        public double Valore_Padre() 
        { // punti Mostro
          return base.punti; 
        } 
        public double Valore() 
        { // somma punti
            return punti + base.Valore(); }
        }
}
