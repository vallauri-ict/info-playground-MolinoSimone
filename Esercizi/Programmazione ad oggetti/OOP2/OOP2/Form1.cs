using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2
{
    public partial class Form1 : Form
    {
        Persona abele = new Persona();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVal_Click(object sender, EventArgs e)
        {
            abele.eta = 17;
            MessageBox.Show("Età prima del richiamo a compleanno: " + abele.eta);
            compleanno(abele);
            MessageBox.Show("Età DOPO del richiamo a compleanno: " + abele.eta);

        }
        private void btnRef_Click(object sender, EventArgs e)
        {
            abele.eta = 54;
            MessageBox.Show("Età prima del richiamo a supplenza: " + abele.eta);
            supplenza(ref abele);
            MessageBox.Show("Età DOPO del richiamo a supplenza: " + abele.eta);
        }

        private void compleanno(Persona p)
        {
            p.eta++;
        }
        private void supplenza(ref Persona p)
        {
            p = new Persona();
            p.eta = 27;
        }
    }
}
