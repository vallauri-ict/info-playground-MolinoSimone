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
    public partial class Figlia2 : Form
    {
        private Figlia1 f;
        private string ckb1, ckb2, combo;
        public Figlia2(string ckb1b, string ckb2b, string combob)
        {
            InitializeComponent();
            this.ckb1 = ckb1b;
            this.ckb2 = ckb2b;
            this.combo = combob;
        }

        private void Figlia2_Load(object sender, EventArgs e)
        {
            
            if(ckb1 != "" && ckb2 != "")
            {
                lblScelta.Text = "Interni selezionati: " + ckb1 + " e " + ckb2;
            }
            else if(ckb1 != "")
            {
                lblScelta.Text = "Interni selezionati: " + ckb1;
            }
            else
            {
                lblScelta.Text = "Interni selezionati: " + ckb2;
            }
            lblScelta.Text += " Marca: " + combo;
        }
    }
}
