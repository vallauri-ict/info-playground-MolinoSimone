using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_7___Dictionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public struct libro 
        { 
            public string titolo; 
            public string autore; 
        }
        public int pos = 0;
        Dictionary<int, libro> dizionarioLibri = new Dictionary<int, libro>();
        private void btnDizionario_Click(object sender, EventArgs e)
        {
            libro l; 
            l.titolo = txtTitolo.Text; 
            l.autore = txtAutore.Text;
            dizionarioLibri.Add(pos, l); 
            pos++;
            txtAutore.Text = "";
            txtTitolo.Text = "";

        }
        private void btnVisDizionario_Click(object sender, EventArgs e)
        {
            foreach (int key in dizionarioLibri.Keys) 
                MessageBox.Show("Key: "+ Convert.ToString(key));
            foreach (libro l in dizionarioLibri.Values) 
                MessageBox.Show("Libro: " + l.titolo + "\nAutore: " + l.autore);
        }

        private void btnVisLibro_Click(object sender, EventArgs e)
        {
            libro lf = dizionarioLibri[Convert.ToInt32(numericUpDownIndiceLibro.Value)];
            MessageBox.Show("Libro: " + lf.titolo + "\nAutore: " + lf.autore);
        }



        Queue<libro> codaLibri = new Queue<libro>();
        Stack<libro> stackLibri = new Stack<libro>();
        private void btnCoda_Click(object sender, EventArgs e)
        {
            libro l; 
            l.titolo = txtTitolo.Text;
            l.autore = txtAutore.Text;
            codaLibri.Enqueue(l);
        }

        private void btnPila_Click(object sender, EventArgs e)
        {
            libro l;
            l.titolo = txtTitolo.Text;
            l.autore = txtAutore.Text;
            stackLibri.Push(l);
        }

        private void btnEstraiCoda_Click(object sender, EventArgs e)
        {
            libro l = codaLibri.Dequeue();
            MessageBox.Show("Libro: " + l.titolo + "\nAutore: " + l.autore);
            
        }

        private void BtnEstraiPila_Click(object sender, EventArgs e)
        {
            libro l = stackLibri.Pop();
            MessageBox.Show("Libro: " + l.titolo + "\nAutore: " + l.autore);
        }
    }
}
