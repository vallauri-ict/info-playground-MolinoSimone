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

    public partial class Form1 : Form

    {
        private Figlia1 f = new Figlia1();
        private Figlia2 f2;
        
        public Form1()
        {
            InitializeComponent();

        }

        private void apr1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (f.f1Aperto==false)
            {
                f = new Figlia1();
                f.MdiParent = this;
                f.Text = "Figlia 1";
                f.Size = new Size(250, 200);
                f.StartPosition = FormStartPosition.Manual;
                f.Location = new Point(10, 10);
                f.f1Aperto = true;
                f.Show();
            }
            
        }

        private void apri2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f = new Figlia1();
            if (f.f1Aperto == true)
            {
                if ((f.ckb1b == "" || f.ckb2b == "") && f.combob == "")
                {
                    ModaleNonSelezione fNoSelezione = new ModaleNonSelezione();
                    fNoSelezione.Text = "Mancato inserimento valori";

                    if (fNoSelezione.ShowDialog() == DialogResult.OK)
                    {
                        fNoSelezione.Close();
                    }

                }
                else
                {
                    toolStripStatusLabel1.Text = "Marca dell'auto: " + f.combob;
                    f2 = new Figlia2(f.ckb1b, f.ckb2b, f.combob);
                    f2.MdiParent = this;
                    f2.Text = "Figlia 2";
                    f2.Size = new Size(250, 200);
                    f2.StartPosition = FormStartPosition.Manual;
                    f2.Location = new Point(270, 10);
                    f2.Show();
                }
            }
            else
            {
                ModaleNonSelezione fNoSelezione = new ModaleNonSelezione();
                fNoSelezione.Text = "Mancato inserimento valori";

                if (fNoSelezione.ShowDialog() == DialogResult.OK)
                {
                    fNoSelezione.Close();
                }
            }
            
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModaleEsci f = new ModaleEsci();
            f.Text = "Uscire?";
            if (f.ShowDialog() == DialogResult.OK)
            {
                Close();
            }
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInfo f = new FormInfo();
            f.Text = "Informaioni Sul Programma?";

            if (f.ShowDialog() == DialogResult.OK)
            {
                f.Close();
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
