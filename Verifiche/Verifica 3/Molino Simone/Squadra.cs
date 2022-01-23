using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Molino_Simone
{
    class Squadra
    {
        string nome = "Milan";
        string citta = "Milano";
        int puteggio = 36;
        List<Giocatore> giocatori = new List<Giocatore>();
        private Squadra()
        { // costruttore privato
          // eventuali inizializzazioni di istanza
        }
        private static Squadra _instance = null;
        public static Squadra GetInstance()
        {
            if (_instance == null) _instance = new Squadra();
            return _instance;
        }
        public void aggiungiGiocatore(string nome, string cognome, string matricola)
        {
            Giocatore giocatore = new Giocatore();
            giocatore.nome = nome;
            giocatore.cognome = cognome;
            giocatore.matricola = matricola;
            giocatori.Add(giocatore);
        }

        internal string stampaSquadra()
        {
            string stampa = "Nome: " + nome + "   Città: " + citta + "   Punteggio: " + puteggio; 
            return stampa;
        }

        public void stampaGiocatore()
        {
            string output = "";
            if (giocatori.Count == 0)
            {
                MessageBox.Show("Non è presente nessun giocatore");
            }
            else
            {
                foreach (Giocatore g in giocatori)
                {
                    output += "Giocatore: " + g.nome + " " + g.cognome + " " + g.matricola + "\n";
                }
                MessageBox.Show(output);
            }
        }
    }
}
