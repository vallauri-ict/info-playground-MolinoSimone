using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP10___Esercizio_Pile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public struct container
        {
            public string codice;
            public int peso;
            public int tara;
        }

        Stack<container> stackContainer = new Stack<container>();
        private void btnCarica_Click(object sender, EventArgs e)
        {
            container c;
            c.codice = txtCodice.Text;
            c.peso = Convert.ToInt32(txtPeso.Text);
            c.tara = Convert.ToInt32(txtTara.Text);
            stackContainer.Push(c);
        }

        private void btnScarica_Click(object sender, EventArgs e)
        {
            container c = stackContainer.Pop();
            MessageBox.Show("Codice: " + c.codice + "\nPeso: " + c.peso + "\nTara: " + c.tara);
        }
    }
}
