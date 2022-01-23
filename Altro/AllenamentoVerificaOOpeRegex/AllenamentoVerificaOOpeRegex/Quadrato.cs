using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllenamentoVerificaOOpeRegex
{
    class Quadrato
    {
        private int lato;
       
        private Quadrato(int val) { this.lato = val; }
        public static Quadrato creaQuadrato(int val)
        {
            return new Quadrato(val);
        }
        public int VisualizzaLato()
        {
            return lato;
        }
    }
}
