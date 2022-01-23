using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllenamentoVerificaOOpeRegex
{
    class Singleton
    {
        private int n;
        private Singleton(int numero)
        { // costruttore privato
          // eventuali inizializzazioni di istanza
            n = numero;

        }
        private static Singleton _instance = null;
        public static Singleton GetInstance(int n)
        {
            if (_instance == null) _instance = new Singleton(n);
            return _instance;
        }
        public int visualizza()
        {
            return n;
        }

    }
}
