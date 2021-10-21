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
    public partial class Figlia1 : Form
    {
        //public bool f1Aperto=false;
        public bool f2Aperto = false;
        public string tempoSelezioneto="";
        private Figlia2 f2;


        
        private ToolStripStatusLabel statusStrip1;
        private bool f1Aperta;

        public Figlia1(ToolStripStatusLabel statusStrip1, bool f1aperto)
        {
            InitializeComponent();
            this.statusStrip1 = statusStrip1;
            this.f1Aperta = f1aperto;
        }

        private void Figlia1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tempoSelezioneto = "Blitz 3+2";
            Button btn = (Button)sender;
            btn.ForeColor = Color.Blue;
            ModaleConfermaScelta modaleScelta = new ModaleConfermaScelta();
            modaleScelta.Text = "Sicuro?";

            if (modaleScelta.ShowDialog() == DialogResult.OK)
            {
                this.Enabled = false;
                f2 = new Figlia2(tempoSelezioneto, statusStrip1);
                f2.MdiParent = this.MdiParent;
                f2.Text = "Figlia 2";
                f2.Size = new Size(250, 200);
                f2.StartPosition = FormStartPosition.Manual;
                f2.Location = new Point(300, 10);
                f2Aperto = true;
                statusStrip1.Text = tempoSelezioneto;
                f2.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tempoSelezioneto = "Blitz 5+0";
            Button btn = (Button)sender;
            btn.ForeColor = Color.Blue;
            ModaleConfermaScelta modaleScelta = new ModaleConfermaScelta();
            modaleScelta.Text = "Sicuro?";

            if (modaleScelta.ShowDialog() == DialogResult.OK)
            {
                this.Enabled = false;
                f2 = new Figlia2(tempoSelezioneto, statusStrip1);
                f2.MdiParent = this.MdiParent;
                f2.Text = "Figlia 2";
                f2.Size = new Size(250, 200);
                f2.StartPosition = FormStartPosition.Manual;
                f2.Location = new Point(300, 10);
                f2Aperto = true;
                statusStrip1.Text = tempoSelezioneto;
                f2.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tempoSelezioneto = "Blitz 5+3";
            Button btn = (Button)sender;
            btn.ForeColor = Color.Blue;
            ModaleConfermaScelta modaleScelta = new ModaleConfermaScelta();
            modaleScelta.Text = "Sicuro?";

            if (modaleScelta.ShowDialog() == DialogResult.OK)
            {
                this.Enabled = false;
                f2 = new Figlia2(tempoSelezioneto, statusStrip1);
                f2.MdiParent = this.MdiParent;
                f2.Text = "Figlia 2";
                f2.Size = new Size(250, 200);
                f2.StartPosition = FormStartPosition.Manual;
                f2.Location = new Point(300, 10);
                f2Aperto = true;
                statusStrip1.Text = tempoSelezioneto;
                f2.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tempoSelezioneto = "Rapid 10+0";
            Button btn = (Button)sender;
            btn.ForeColor = Color.Blue;
            ModaleConfermaScelta modaleScelta = new ModaleConfermaScelta();
            modaleScelta.Text = "Sicuro?";

            if (modaleScelta.ShowDialog() == DialogResult.OK)
            {
                this.Enabled = false;
                f2 = new Figlia2(tempoSelezioneto, statusStrip1);
                f2.MdiParent = this.MdiParent;
                f2.Text = "Figlia 2";
                f2.Size = new Size(250, 200);
                f2.StartPosition = FormStartPosition.Manual;
                f2.Location = new Point(300, 10);
                f2Aperto = true;
                statusStrip1.Text = tempoSelezioneto;
                f2.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tempoSelezioneto = "Rapid 10+5";
            Button btn = (Button)sender;
            btn.ForeColor = Color.Blue;
            ModaleConfermaScelta modaleScelta = new ModaleConfermaScelta();
            modaleScelta.Text = "Sicuro?";

            if (modaleScelta.ShowDialog() == DialogResult.OK)
            {
                this.Enabled = false;
                f2 = new Figlia2(tempoSelezioneto, statusStrip1);
                f2.MdiParent = this.MdiParent;
                f2.Text = "Figlia 2";
                f2.Size = new Size(250, 200);
                f2.StartPosition = FormStartPosition.Manual;
                f2.Location = new Point(300, 10);
                f2Aperto = true;
                statusStrip1.Text = tempoSelezioneto;
                f2.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tempoSelezioneto = "Rapid 15+10";
            Button btn = (Button)sender;
            btn.ForeColor = Color.Blue;
            ModaleConfermaScelta modaleScelta = new ModaleConfermaScelta();
            modaleScelta.Text = "Sicuro?";

            if (modaleScelta.ShowDialog() == DialogResult.OK)
            {
                this.Enabled = false;
                f2 = new Figlia2(tempoSelezioneto, statusStrip1);
                f2.MdiParent = this.MdiParent;
                f2.Text = "Figlia 2";
                f2.Size = new Size(250, 200);
                f2.StartPosition = FormStartPosition.Manual;
                f2.Location = new Point(300, 10);
                f2Aperto = true;
                statusStrip1.Text = tempoSelezioneto;
                f2.Show();

            }
        }

        private void Figlia1_FormClosing(object sender, FormClosingEventArgs e)
        {
            f1Aperta = false;
        }

        private void Figlia1_FormClosed(object sender, FormClosedEventArgs e)
        {
            f1Aperta = false;
        }
    }
}
