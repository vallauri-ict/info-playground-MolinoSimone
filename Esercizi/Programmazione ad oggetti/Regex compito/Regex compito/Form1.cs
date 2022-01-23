using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Regex_compito
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfermaEInviaDati_Click(object sender, EventArgs e)
        {
            //Controllo nome
            bool ok = true;
            
            if (!Regex.IsMatch(txtNome.Text, @"^\D[a-zA-Z]{2,}$"))
            {
                MessageBox.Show("Nome non Valido");
                ok = false;
            }

            //Controllo Cognome
            if (!Regex.IsMatch(txtCognome.Text, @"^\D[a-zA-Z]{2,}$"))
            {
                MessageBox.Show("Cognome non Valido");
                ok = false;
            }

            //età
            if (!Regex.IsMatch(txtEta.Text, "^[0-9]+$"))
            {
                MessageBox.Show("Età deve essere un numero");
                ok = false;
                if (Convert.ToInt32(txtEta.Text) < 1 || Convert.ToInt32(txtEta.Text) > 120)
                {
                    MessageBox.Show("Età non Valida (da 0 a 120)");
                    ok = false;
                }
            }
            //cap
            if (!Regex.IsMatch(txtCAP.Text, "^[0-9]{5}$"))
            {
                MessageBox.Show("Cap non valido");
                ok = false;
            }
            //città
            if (!Regex.IsMatch(txtCitta.Text, @"^\D[a-zA-Z]{3,}\s[(][A-Z]{2}[)]$"))
            {
                MessageBox.Show("Città non valida");
                ok = false;
            }
            //mail
            string str = txtMail.Text; 
            if (!Regex.IsMatch(str, @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"))
            {
                MessageBox.Show("Email non valida");
                ok = false;
            }

            //CF
            if (!Regex.IsMatch(txtCF.Text, @"^[a-zA-Z]{6}[0-9]{2}[abcdehlmprstABCDEHLMPRST]{1}[0-9]{2}([a-zA-Z]{1}[0-9]{3})[a-zA-Z]{1}$"))
            {
                MessageBox.Show("Codice Fiscale non valido");
                ok = false;
            }
            //Username
            if (!Regex.IsMatch(txtUsername.Text, @"^([a-zA-Z]){1}([a-zA-Z0-9]{4,})$"))
            {
                MessageBox.Show("Username non valido");
                ok = false;
            }
            //Password
            if (!Regex.IsMatch(txtPassword.Text, @"([a-zA-Z0-9!-+]){8,15}")) //([a-zA-Z0-9!](!+)){8,15}
            {
                MessageBox.Show("Password non valida");
                ok = false;
            }
            if (ok==true)
            {
                MessageBox.Show("Iscrizione completata con successo!");
            }
        }
    }
}
