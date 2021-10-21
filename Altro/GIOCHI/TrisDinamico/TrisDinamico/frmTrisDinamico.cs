using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrisDinamico
{
    public partial class frmTrisDinamico : Form
    {
        int[,] a;
        int turno;
        /*
         * X==>1
         * O==>2
         */
        public frmTrisDinamico()
        {
            InitializeComponent();
        }

        private void frmTrisDinamico_Load(object sender, EventArgs e)
        {
            Button btn;
            a = new int[3, 3];
            turno = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    //CREO INSTANZA NUOVO BOTTONE
                    btn = new Button();
                    btn.Text = (i + "." + j).ToString();
                    btn.Name = (i + "." + j).ToString(); //NAME==>0.0/ 0.1 ecc.
                    btn.Height = 55;
                    btn.Width = 55;
                    btn.Font = new Font(btn.Font, FontStyle.Bold);//testo grassetto
                    btn.Font = new Font(btn.Font.FontFamily, 18);
                    btn.Left = 55 * (i + 1);
                    btn.Top =  50 * (j + 1);
                    btn.Enabled = false;
                    btn.TabStop = false;//togliamo la selezione al primo pulsante, quindi la tabulazione
                    //AGGIUNGO BUTTON AL FRM
                    this.Controls.Add(btn);
                    //ASSOCIO ANCHE UN NUOVO EVENTO CLICK
                    btn.Click += new EventHandler(this.bottone_Click);
                }
            }
            btn = new Button(); //creo un nuovo bottone riusando la variabile di prima quindi perde tutte le proprietà precedenti
            btn.Text = "GIOCA";
            btn.Name = "btnGioca";
            btn.Height = 50;
            btn.Width = 155;
            btn.Left = 55;
            btn.Top = 210;
            //AGGIUNGO BUTTON AL FRM
            this.Controls.Add(btn);
            //ASSOCIO ANCHE UN NUOVO EVENTO CLICK
            btn.Click += new EventHandler(this.btnGioca_Click);
        }

        private void btnGioca_Click(object sender, EventArgs e)
        {
            abilita();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    a[i, j] = 0;
                }
            }
        }

        private void abilita()
        {
            foreach (Button bottone in this.Controls)//collections==>la nostra collezione è il frm
            {
                //foreach sarebbe per ogni bottone
                if (bottone.Name!="btnGioca")
                {
                    bottone.Enabled = true;
                    bottone.Text = "";
                }
            }
        }

        private void disabilita()
        {
            foreach (Button bottone in this.Controls)//collections==>la nostra collezione è il frm
            {
                if (bottone.Name != "btnGioca")
                {
                    bottone.Enabled = false;
                    bottone.Text = "";
                }
            }
        }

        private void bottone_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int i = Convert.ToInt32(btn.Name.Substring(0, 1));
            int j = Convert.ToInt32(btn.Name.Substring(2, 1));
            /*ASSOCIO A MATRICE IL GIOCATORE*/
            a[i, j] = turno;
            if (turno==1)
            {
                btn.Text = "X";
                turno = 2;
            }
            else
            {
                btn.Text = "O";
                turno = 1;
            }
            btn.Enabled = false;
            controlla();
        }

        private void controlla()
        {
            throw new NotImplementedException();
        }
    }
}
