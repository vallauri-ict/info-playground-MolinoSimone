using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PratoFioritoDinamico
{
    public partial class frmCampoMinato : Form
    {
        private const int R= 15;
        private const int C = 10;
        private const int FIORI = 10;
        int[,] a;
        Random rnd=new Random();


        public frmCampoMinato()
        {
            InitializeComponent();
        }

        private void frmCampoMinato_Load(object sender, EventArgs e)
        {
            //Creiamo la griglia di gioco
            Button btn;
            a = new int[R, C];
            btn = new Button();
            btn.Text = "GIOCA";
            btn.Name = "btnGioca";
            btn.Width = 50;
            btn.Height = 20;
            btn.Left = 20;
            btn.Click += new EventHandler(btnGioca_Click);
            this.Controls.Add(btn);
            /*GRIGLIA GIOCO*/
            for (int i = 0; i < R; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    btn = new Button();
                    btn.Name = "btn_" + i + "_" + j;
                    btn.Height = 20;
                    btn.Width = 20;
                    btn.Left = 20 * (j + 1);
                    btn.Top = 20 * (i + 1);
                    btn.Font = new Font(btn.Font, FontStyle.Bold);
                    btn.Font = new Font(btn.Font.FontFamily, 8);
                    btn.Cursor = Cursors.Hand;//mette la mano al cursore
                    btn.Enabled = false;
                    this.Controls.Add(btn);
                }
            }
        }

        private void btnGioca_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Enabled = false;

            foreach (Button bottone in this.Controls)
            {
                if(bottone.Name != "btnGioca")
                {
                    bottone.Enabled = true;
                    bottone.Text = "";
                    bottone.Click += new EventHandler(this.btn_Click);
                }
            }
            //Caricamento Fiori
            caricaFiori();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int i, j;
            // Recupero coordinate pulsante con i e j
            // usare split -> i pulsanti sono nominati: btn_0_0 btn_0_1 ....
        }

        private void caricaFiori()
        {
            // -1 SONO I FIORI
            // IL RESTATNTE SONO LE MINE
            int i, j,cnt=0;

            // Resetto campo di gioco 
            for (i = 0; i < R; i++)
            {
                for (j = 0; j < C; j++)
                    a[i, j] = 0;
            }

            do
            {
                i = rnd.Next(0, R);
                j = rnd.Next(0, C);
                if (a[i,j] != -1)
                {
                    a[i, j] = -1;
                    cnt++;
                }
            } while (cnt <= FIORI);
            //calcolo fiori adiacenti
            for (i = 0; i < R; i++)
            {
                cnt = 0;
                for (j = 0; j < C; j++)
                {
                    if (a[i,j] != -1)
                    {
                        // sopra 
                        if (i != 0)
                            cnt += (a[i - 1, j] == -1 ? 1 : 0);
                        // sotto
                        if (i != R - 1)
                            cnt += (a[i + 1, j] == -1 ? 1 : 0);
                        // sx
                        if (j != 0)
                            cnt += (a[i, j - 1] == -1 ? 1 : 0);
                        // dx
                        if (j != C - 1)
                            cnt += (a[i, j + 1] == -1 ? 1 : 0);
                        // alto sx 
                        if (i != 0 && j != 0)
                            cnt += (a[i - 1, j - 1] == -1 ? 1 : 0);
                        // basso sx
                        if (i != R - 1 && j != 0)
                            cnt += (a[i + 1, j - 1] == -1 ? 1 : 0);
                        // alto dx
                        if (i != 0 && j != C - 1)
                            cnt += (a[i - 1, j + 1] == -1 ? 1 : 0);
                        // basso dx
                        if (i != R - 1 && j != C - 1)
                            cnt += (a[i + 1, j + 1] == -1 ? 1 : 0);
                        a[i, j] = cnt;

                    }
                }
            }
        }
    }
}
