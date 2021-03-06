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
    public partial class Form1 : Form
    {
        private Figlia1 f;
        private Figlia2 f2;
        private bool f1Aperto = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void apri1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f1Aperto == false)
            {
                f1Aperto = true;
                f = new Figlia1(toolStripStatusLabel1, f1Aperto);
                f.MdiParent = this;
                f.Text = "Figlia 1";
                f.Size = new Size(250, 200);
                f.StartPosition = FormStartPosition.Manual;
                f.Location = new Point(10, 10);
                f.Show();
            }
        }

        private void apri2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f.f2Aperto==false)
            {
                
                f2 = new Figlia2(f.tempoSelezioneto, toolStripStatusLabel1);
                f2.MdiParent = this;
                f2.Text = "Figlia 2";
                f2.Size = new Size(250, 200);
                f2.StartPosition = FormStartPosition.Manual;
                f2.Location = new Point(300, 10);
                f.f2Aperto = true;
                f2.Show();
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
            f.Text = "Uscire?";
            if (f.ShowDialog() == DialogResult.OK)
            {
                f.Close();
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }
    }
}
