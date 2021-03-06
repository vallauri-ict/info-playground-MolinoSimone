using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP8___Esercizio_Dizionario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public struct articolo
        {
            public string nomeArticolo;
        }
        Dictionary<int, articolo> dizionarioArticoli = new Dictionary<int, articolo>();

        private void btnSalvaArticolo_Click(object sender, EventArgs e)
        {
            articolo l;
            l.nomeArticolo = txtNomeArticolo.Text;
            dizionarioArticoli.Add(Convert.ToInt32(txtKey.Text), l);
            txtNomeArticolo.Text = "";
            txtKey.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblNArticoli.Text = dizionarioArticoli.Values.Count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                articolo a = dizionarioArticoli[Convert.ToInt32(txtInput.Text)];
                lblArticolo.Text = "Articolo: " + a.nomeArticolo + "\nChiave: " + txtInput.Text;
            }
            catch (KeyNotFoundException)
            {
                MessageBox.Show("Errore: Chiave non trovata!");
                throw;
            }
            
            //MessageBox.Show("Articolo: " + a.nomeArticolo + "\nChiave: " + txtInput.Text);


        }
    }
}
