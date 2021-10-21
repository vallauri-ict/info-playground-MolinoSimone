using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm03___Esercitazione_Verifica
{
    public partial class Figlia1 : Form
    {
        public string ckb1b="";
        public string ckb2b="";
        public string combob="";
        public bool f1Aperto=false;
        public Figlia1()
        {
            InitializeComponent();
        }

        private void Figlia1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnInvia_Click(object sender, EventArgs e)
        {
            
            if (ckbPelle.Checked==true)
            {
                ckb1b = "Pelle";
            }
            if (ckbStoffa.Checked==true)
            {
                ckb2b = "Stoffa";
            }
            combob = cmbMarca.Text;
            string risultato = "";
            if (ckb1b != "" && ckb2b != "")
            {
                risultato = "Interni selezionati: " + ckb1b + " e " + ckb2b;
            }
            else if (ckb1b != "")
            {
                risultato = "Interni selezionati: " + ckb1b;
            }
            else
            {
                risultato = "Interni selezionati: " + ckb2b;
            }
            risultato += " Marca: " + combob;
            


        }

        private void Figlia1_FormClosed(object sender, FormClosedEventArgs e)
        {
            f1Aperto = false;
        }

        private void Figlia1_FormClosing(object sender, FormClosingEventArgs e)
        {
            f1Aperto = false;
        }
    }
}
