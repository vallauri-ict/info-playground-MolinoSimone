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

namespace AllenamentoVerificaOOpeRegex
{
    public partial class Form1 : Form
    {
        Regex nome, matricola;
        bool ok;
        Dictionary<string, string> dic = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            
            nome = new Regex(@"^[a-zA-Z]{3,}$");
            matricola = new Regex(@"^[a-zA-Z]{4}((\w)|(\d|[!-+])){6,}$");
            if(nome.IsMatch(txtCognome.Text) && nome.IsMatch(txtNome.Text) && matricola.IsMatch(txtMatricola.Text))
            {
                Associazione assoc = Associazione.GetInstance();
                ok = true;
                foreach (string key in dic.Keys)
                {
                    if(ok)
                    {
                        if (key == txtMatricola.Text)
                            ok = false;
                    }
                }
                if (ok)
                {
                    dic.Add(txtMatricola.Text, txtCognome.Text + " " + txtNome.Text);
                    assoc.aggiungiSocio(txtNome.Text, txtCognome.Text, txtMatricola.Text);
                    MessageBox.Show("Socio inserito nella classe soci");
                }     
                else
                    MessageBox.Show("Matricola già esistente");
            }
            else
            {
                MessageBox.Show("Formati dei campi non valido");
            }

        }
    }
}
