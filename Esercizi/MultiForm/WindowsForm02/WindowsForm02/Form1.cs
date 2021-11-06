using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnApriFiglia1_Click(object sender, EventArgs e)
        {
            Figlia1 f = new Figlia1();
            f.MdiParent = this;
            f.Text = "Figlia 1";
            f.Size = new Size(200, 150);
            f.StartPosition = FormStartPosition.Manual;
            f.Location = new Point(0, 100);
            f.Show();

        }
        

        private void btnApriFiglia2_Click_1(object sender, EventArgs e)
        {
            Figlia2 f = new Figlia2();
            f.MdiParent = this;
            f.Text = "Figlia 2";
            f.Size = new Size(200, 150);
            f.StartPosition = FormStartPosition.Manual;
            f.Location = new Point(205, 100);
            f.Show();
        }

        private void btnFinestreAperte_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sono state aperte " + this.MdiChildren.Length + " finestre");
            foreach (Form f in this.MdiChildren)
            {
                MessageBox.Show("Finestra " + f.Text + " aperta");
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void apri1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Premuto apri 1";
            
        }

        private void apri2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Premuto apri 2";
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

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormInfo f = new FormInfo();
            f.Text = "Informaioni Sul Programma?";

            if (f.ShowDialog() == DialogResult.OK)
            {
                f.Close();
            }
        }
    }
}
