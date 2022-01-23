using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryQuadrato
{

    class Singleton
    {
        private static Singleton instanza = null;
        private static int id = 0;
        public readonly int n;
        private Singleton()
        {
            id++;
            n = id;
        }

        public static Singleton getInstance()
        {
            if (instanza==null)
            {
                instanza = new Singleton();
            }
            return instanza;        
        }
    }
}
