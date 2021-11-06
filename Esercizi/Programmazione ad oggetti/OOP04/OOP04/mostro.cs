using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04
{
    class mostro
    {
        public string nome; 
        public double punti;

        public mostro()
        {

        }
        public mostro(string n)
        {
            nome = n;
            punti = 100;
        }

        public double Valore()
        { // punti del Mostro
            return punti; }
        }
}
