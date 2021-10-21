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
    public partial class Figlia2 : Form
    {
        private string tempoPrecedente;
        private ToolStripStatusLabel statusStrip1;
        public Figlia2(string tempoSelezionato, ToolStripStatusLabel statusStrip1)
        {
            InitializeComponent();
            this.tempoPrecedente = tempoSelezionato;
            this.statusStrip1 = statusStrip1;
        }

        private void btnInizia_Click(object sender, EventArgs e)
        {
            string sceltaColore = "";
            if (radioButton1.Checked==true)
            {
                sceltaColore = "Bianco";
            }
            else if (radioButton2.Checked == true)
            {
                sceltaColore = "Nero";
            }
            else if (radioButton3.Checked == true)
            {
                Random rnd = new Random();
                int n;
                n = rnd.Next(0, 2);
                if (n==0)
                {
                    sceltaColore = "Bianco";
                }
                else
                    sceltaColore = "Nero";

            }
            if (sceltaColore=="")
            {
                MessageBox.Show("Scegli prima un colore");
            }
            else
            {
                statusStrip1.Text += " " + sceltaColore;
                ModaleInizio ModaleInizio = new ModaleInizio(tempoPrecedente, sceltaColore);

                if (ModaleInizio.ShowDialog() == DialogResult.OK)
                {
                    ModaleInizio.Close();
                }
            }
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
