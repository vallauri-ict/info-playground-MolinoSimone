using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP9___Esercizio_Pile
{
    public partial class Form1 : Form
    {
        int min, max;
        public struct paziente
        {
            public string nome;
            public int età;
            public string colore;
            public int temperatura;
        }

        Queue<paziente> codaRossa = new Queue<paziente>();
        Queue<paziente> codaGialla = new Queue<paziente>();
        Queue<paziente> codaVerde = new Queue<paziente>();
        Queue<paziente> codaBianca = new Queue<paziente>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            min = 70;
            max = 25;
            lblPazienteOut.Text = "";
        }

        private void btnInserisciPaziente_Click(object sender, EventArgs e)
        {
            paziente p;
            p.nome = txtNome.Text;
            p.età = Convert.ToInt32(txtEta.Text);
            p.colore = txtCodice.Text;
            p.temperatura = Convert.ToInt32(txtTemp.Text);
            if (p.colore == "Rosso")
                codaRossa.Enqueue(p);
            else if (p.colore == "Giallo")
                codaGialla.Enqueue(p);
            else if (p.colore == "Verde")
                codaVerde.Enqueue(p);
            else
                codaBianca.Enqueue(p);
            calcolaMinMax();
        }

        private void btnRichiediPaziente_Click(object sender, EventArgs e)
        {

            lblPazienteOut.Text = "";
            if (codaRossa.Count != 0)
            {
                lblPazienteOut.Text = "Deve essere visitato il paziente: \nNome: " + codaRossa.Peek().nome +
                "\nEtà: " + codaRossa.Peek().età + "\nColore: " + codaRossa.Peek().colore + "\nTemperatura: " + codaRossa.Peek().temperatura;
                codaRossa.Dequeue();
            }
            else if (codaGialla.Count != 0)
            {
                lblPazienteOut.Text = "Deve essere visitato il paziente: \nNome: " + codaGialla.Peek().nome +
                "\nEtà: " + codaGialla.Peek().età + "\nColore: " + codaGialla.Peek().colore + "\nTemperatura: " + codaGialla.Peek().temperatura;
                codaGialla.Dequeue();
            }
            else if (codaVerde.Count != 0)
            {
                lblPazienteOut.Text = "Deve essere visitato il paziente: \nNome: " + codaVerde.Peek().nome +
                "\nEtà: " + codaVerde.Peek().età + "\nColore: " + codaVerde.Peek().colore + "\nTemperatura: " + codaVerde.Peek().temperatura;
                codaVerde.Dequeue();
            }
            else if (codaBianca.Count != 0)
            {
                lblPazienteOut.Text = "Deve essere visitato il paziente: \nNome: " + codaBianca.Peek().nome +
                "\nEtà: " + codaBianca.Peek().età + "\nColore: " + codaBianca.Peek().colore + "\nTemperatura: " + codaBianca.Peek().temperatura;
                codaBianca.Dequeue();
            }
            else
                MessageBox.Show("Nessun paziente da servire");
        }

        private void btnValoriTemperaturaMaxMin_Click(object sender, EventArgs e)
        {
            lblTemperatureMaxMin.Text = "Massima temperatura: " + max.ToString() + "\nMinima temperatura: " + min.ToString();
        }

        

        private void calcolaMinMax()
        {
            foreach (paziente p in codaRossa)
            {
                if (p.temperatura > max)
                    max = p.temperatura;
                if (p.temperatura < min)
                    min = p.temperatura;
            }
            foreach (paziente p in codaGialla)
            {
                if (p.temperatura > max)
                    max = p.temperatura;
                if (p.temperatura < min)
                    min = p.temperatura;
            }
            foreach (paziente p in codaVerde)
            {
                if (p.temperatura > max)
                    max = p.temperatura;
                if (p.temperatura < min)
                    min = p.temperatura;
            }
            foreach (paziente p in codaBianca)
            {
                if (p.temperatura > max)
                    max = p.temperatura;
                if (p.temperatura < min)
                    min = p.temperatura;
            }
        }
    }
}

