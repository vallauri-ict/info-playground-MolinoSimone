using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterMind
{
    public partial class frmMasterMind : Form
    {
        char[,] colori;//griglia di gioco, memorizzo colori del giocatore
        char[] codice;//Codice Segreto, generato all'avvio
        int pos;//rappresenzta la riga attuale di gioco
        static Random rnd = new Random();

        public frmMasterMind()
        {
            InitializeComponent();
        }

        private void frmMasterMind_Load(object sender, EventArgs e)
        {
            colori = new char[7, 4];
            codice = new char[4];
            pos = 6;//partiamo dall'ultima riga
            //CREIAMO DINAMICAMENTE IL FORM
            creaCampo();
            generaCodice();
        }

        private void generaCodice()
        {
            //blu rosso verde e giallo
            char[] keys = new char[]{//qui ci sono i valori dei colori
                'B',//BLUE
                'G',//GREEN
                'R',//RED
                'Y'//YELLOW
            };
            string s="";//serve per l'otuput
            for (int i = 0; i < 4; i++)
            {
                codice[i] = keys[rnd.Next(0, 4)];
                s += codice[i];
            }
            Console.WriteLine("CODICE SEGRETO: " + s);
        }

        private void creaCampo()
        {
            Button btn;//4 pulsanti in sequenza e 4 picture box
            PictureBox pic;
            int top = -10; //posizionarci per bene, distanza dal margine in alto a sinistra
            int left = 0;
            for (int i = 0; i < 7; i++)
            {
                top += 40;
                for (int j = 0; j < 4; j++)
                {
                    colori[i, j] = 'W';//settaggio colore iniziale W==>White
                    //Costruisco il pulsante, con relative proprietà
                    btn = new Button();
                    btn.Name = "btn_" + i + "_" + j;
                    //btn.Text = i + "_" + j;
                    btn.Height = 40;
                    btn.Width = 40;
                    btn.Left = 41 * (j + 1);
                    btn.Top = top;
                    btn.TabStop = false;//impedisce di fare la tabulazione
                    btn.Cursor = Cursors.Hand;
                    btn.BackColor = Color.White;
                    btn.Click += new EventHandler(this.btn_Click);
                    if (i != 6)//Se non è l'ultima riga di pulsanti li disabilito, uso solo quella del gioco
                    {
                        btn.Enabled = false;
                    }
                    this.Controls.Add(btn);//lo aggiungo al form
                }
                left = 180;//per le picture box
                for (int j = 0; j < 4; j++) //metto in due for separati anche se potevo unirli assieme 
                {
                    pic = new PictureBox();
                    pic.Name = "pic_" + i + "_" + j;
                    pic.Height = 40;
                    pic.Width = 40;
                    pic.Left = left+(40 * (j + 1));
                    pic.Top = top+10;
                    pic.Image = Image.FromFile("empty.png");//prendiamo il file nel bin debug
                    this.Controls.Add(pic);
                }
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int i, j;//MI SERVONO PER LE COORDINATE DELLA MAT
            string[] spl;//per la split, non assegno valore siccome le alloca lui in automatico
            spl = btn.Name.Split('_');
            i = Convert.ToInt32(spl[1]);
            j = Convert.ToInt32(spl[2]);
            switch (colori[i,j])
            {
                case 'W'://PARTO DAL CASO INIZIALE CIOE IL WHITE
                    colori[i, j] = 'B';
                    btn.BackColor = Color.Blue;
                    break;
                case 'B':
                    colori[i, j] = 'G';
                    btn.BackColor = Color.Green;
                    break;
                case 'G':
                    colori[i, j] = 'Y';
                    btn.BackColor = Color.Yellow;
                    break;
                case 'Y':
                    colori[i, j] = 'R';
                    btn.BackColor = Color.Red;
                    break;
                case 'R':
                    colori[i, j] = 'B'; //non si passa al white siccome è neutro
                    btn.BackColor = Color.Blue;
                    break;
            }
        }

        private void btnGioca_Click(object sender, EventArgs e)
        {
            //colori[7,4];
            //codice ==> codice segreto

            PictureBox pic;//ci sono le immagini che cambiano
            Button btn;

            //uso di una bool vittoria
            bool vittoria = true;
            bool trovato = false;
            for (int j = 0; j < 4; j++)
            {
                pic = (PictureBox)this.Controls["pic_" + pos + "_" + j];//FACCIO L'ACCESSO A QUELLA PictureBox
                if(colori[pos,j] == codice[j]) pic.Image = Image.FromFile("ok.png");
                else
                {//ci sono due casi: o è sbagliato oppure è presente altrove
                    vittoria = false;
                    trovato = false;
                    //si puo usare un vettore di boolean oppure
                    // Codice segreto: Y G B G ==> CODICE [G, Y, B, G] ==> [ERR, ERR, OK, OK]
                    //uso un while per controllare 
                    for (int z = 0; z < 4; z++)
                    {
                        if(z != j && colori[pos, j] == codice[z])//vuol dire che sono in ul altro pulsante
                        {
                            //se è cosi vuol dire che è nella pos sbagliata
                            pic.Image = Image.FromFile("errPos.png");
                            trovato = true;
                        }
                    }
                    if(!trovato) pic.Image = Image.FromFile("no.png"); //nel caso in cui non c'è il colore
                }
                btn = (Button)this.Controls["btn_" + pos + "_" + j];//FACCIO L'ACCESSO A QUELLA btn
                btn.Enabled = false;//da chiedere che i pulsanti gia giocati rimangono disabilitati
            }
            if (vittoria)
                MessageBox.Show("HAI VINTO", "BRAVO");
            else
            {
                pos--;
                if (pos >= 0)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        btn = (Button)this.Controls["btn_" + pos + "_" + j];//FACCIO L'ACCESSO A QUELLA btn
                        btn.Enabled = true;//da chiedere che i pulsanti gia giocati rimangono abilitati
                    }
                }
                else MessageBox.Show("HAI PERSO", "FINE PARTITA");
            }
        }

        private void btnInizia_Click(object sender, EventArgs e)
        {
            //deve resettare tutto quanto
            Button btn;
            PictureBox pic;
            pos = 6;
            generaCodice();
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    colori[i, j] = 'W';//azzeriamo la MAT
                    btn = (Button)this.Controls["btn_" + i + "_" + j];
                    btn.BackColor = Color.White;
                    if (i == 6) btn.Enabled = true;
                    else btn.Enabled = false;
                    pic= (PictureBox)this.Controls["pic_" + i + "_" + j];
                    pic.Image = Image.FromFile("empty.png");
                }
            }
        }
    }
}
