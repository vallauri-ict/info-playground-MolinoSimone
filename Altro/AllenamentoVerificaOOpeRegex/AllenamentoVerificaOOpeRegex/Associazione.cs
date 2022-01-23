using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllenamentoVerificaOOpeRegex
{
    class Associazione
    {
            string nome;
            string indirizzo;
            List<Socio> soci = new List<Socio>();
            Socio socio = new Socio();
            private Associazione()
            { // costruttore privato
              // eventuali inizializzazioni di istanza
            }
            private static Associazione _instance = null;
            public static Associazione GetInstance()
            {
                if (_instance == null) _instance = new Associazione();
                return _instance;
        }
        public void aggiungiSocio(string nome, string cognome, string matricola)
        {
            this.nome = nome;
            socio.nome = nome;
            socio.cognome = cognome;
            socio.matricola = matricola;
            soci.Add(socio);
        }
    }
}
