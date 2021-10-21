using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Molino_Simone
{
    public partial class ModaleInizio : Form
    {
        private string tempo;
        private string colore;
        public ModaleInizio(string tempoSelezionato, string coloreSelezionato)
        {
            InitializeComponent();
            this.tempo = tempoSelezionato;
            this.colore = coloreSelezionato;
        }

        private void ModaleInizio_Load(object sender, EventArgs e)
        {
            label1.Text = "La partita " + tempo + " con il " + colore + " sta per iniziare";
        }
    }
}
