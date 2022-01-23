using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Molino_Simone
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        Dictionary<string, string> dic = new Dictionary<string, string>();
        Squadra sq = Squadra.GetInstance();
        private void btnInserisci_Click(object sender, EventArgs e)
        {
            bool ok = true;
            if (!Regex.IsMatch(txtMatricola.Text, @"^[a-zA-Z]{4}[0-9]{3}[#$&]{1}$"))
            {
                MessageBox.Show("Matricola non valida");
                ok = false;
            }
            if (!Regex.IsMatch(txtUsername.Text, @"^[a-zA-Z0-9]{3,}$"))
            {
                MessageBox.Show("Username non valida");
                ok = false;
            }
            if (!Regex.IsMatch(txtCognome.Text, @"^[a-zA-Z0-9]{3,}$"))
            {
                MessageBox.Show("Cognome non valida");
                ok = false;
            }
            if (txtEta.TextLength > 0)
            {
                if (Convert.ToInt32(txtEta.Text) < 0 || Convert.ToInt32(txtEta.Text) > 100)
                {
                    MessageBox.Show("Età non valida");
                    ok = false;
                }
            }
            else
            {
                MessageBox.Show("Inserisci un età");
                ok = false;
            }
            foreach (string key in dic.Keys)
            {
                if (ok)
                {
                    if (key == txtMatricola.Text)
                    {
                        ok = false;
                        MessageBox.Show("Il socio " + txtCognome.Text + " " + txtUsername.Text + " è già stato inserito");
                    }
                }
            }
            if (ok == true)
            {
                
                dic.Add(txtMatricola.Text, txtCognome.Text + " " + txtUsername.Text);
                sq.aggiungiGiocatore(txtUsername.Text, txtCognome.Text, txtMatricola.Text);
                txtCognome.Text = "";
                txtEta.Text = "";
                txtMatricola.Text = "";
                txtUsername.Text = "";
                MessageBox.Show("Giocatore inserito correttamente");
            }
        }

        private void btnStampa_Click(object sender, EventArgs e)
        {
            string squadra = sq.stampaSquadra();
            MessageBox.Show(squadra);
            //STAMPA DA DIZIONARIO
            string output = "";/*
            if (dic.Count > 0)
            {
                for (int i = 0; i < dic.Count; i++)
                {
                    var item = dic.ElementAt(i);
                    output += "Giocatore " + (i+1) + ":  " + item.Key + " " + item.Value + "\n";
                }
                MessageBox.Show(output);
            }
            else
            {
                MessageBox.Show("Non sono presenti giocatori");
            }*/

            //STAMPA DA LISTA
            sq.stampaGiocatore();
            
        }
    }
}
