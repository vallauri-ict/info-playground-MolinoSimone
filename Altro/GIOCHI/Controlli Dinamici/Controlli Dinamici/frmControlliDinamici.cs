using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controlli_Dinamici
{
    public partial class frmControlliDinamici : Form
    {
        public frmControlliDinamici()
        {
            InitializeComponent();
        }

        private void frmControlliDinamici_Load(object sender, EventArgs e)
        {
            //tutto il form è un piano cartesiano coin le coordinate x, y
            //0,0 estremo bordo a sinistra

            Button btn;
            for (int i = 1; i <= 3; i++)
            {
                //creo istanza dell bottone
                btn = new Button();
                //Setto le proprietà
                btn.Text = i.ToString();
                btn.Name = "btn" + i.ToString();
                btn.Width = 50;
                btn.Height = 50;
                btn.Left = 50 * i;//valore superiore a 50
                btn.Top = 15;//tutti i pulsanti partiranno da pos 15
                //per caricarlo bisogna usare la procedura
                this.Controls.Add(btn); //Aggiungo bottone all'insieme dei componenti
                //Associamo un evento click a metodo bottone _Click
                //possiamo guardare gli eventi tramite il tasto "Fulmine"
                //EventHandler crea un nuovo metodo
                btn.Click += new EventHandler(this.buttone_Click);//tra parentesi si passa il nome del metodo 
            }
            //creo instranza di una label
            Label lbl = new Label();
            //Setto proprietà label
            lbl.Text = "Inserisci il numero del bottone da cancellare";
            lbl.Name = "lblText";
            //al posto della proprietà left e top usiamo location (2coordinate)
            lbl.Location = new Point(55, 80);//passiamo (x,y)
            this.Controls.Add(lbl); //Aggiungo lbl all'insieme dei componenti
            //Creo instanza di una TextBox
            TextBox txt = new TextBox();
            txt.Text = "";
            txt.Name = "txtCancella";
            txt.Width = 20;
            txt.Location = new Point(170, 75);
            this.Controls.Add(txt);//Aggiungo txt all'insieme dei componenti
            //Creo instanza di un button
            //Ricordo che sono variabili quindi si possono riutrilizzare basta che ci sia un altra instanza
            //noi ne usiamo una nuova però
            Button btnC = new Button();
            btnC.Text = "Cancella";
            btnC.Name = "btnCancella";
            btnC.Height =50;
            btnC.Width = 60;
            btnC.Location = new Point(250, 55);
            //Aggiungo bottone cancella all'insieme dei componenti
            this.Controls.Add(btnC);
            //Asccocia evento click a metodo cancella_Click
            btnC.Click += new EventHandler(this.cancella_Click);//il puntatore this si riferisce al frm
            //il this funziona come in JS riferito al DOM

        }

        private void cancella_Click(object sender, EventArgs e)
        {
            //non assegnamo il sender al bottone siccome quello che ci serve in questo caso quando scateniamo il metodo è la txtCancella
            TextBox txt = new TextBox();
            //il controls è un vettore indicizzato di elementi grafici quindi passiamo la stringa in base al nome del componente della nostra txtCancella
            //dopo averlo trovato verrà assegnato quell'elemento grafico alla variabile txt
            txt = (TextBox)this.Controls["txtCancella"]; //si accede all'elemento che ha quel name contenuto nel this(puntatore del form)
            /* Controls
             * [0]btn1 =>Button
             * [1]txt1 =>TextBox
             * [2]gb=>GroupBox
             */
            //Rimuovo componente passando identificanto del bottone
            //UGUALE A JS ==> getElementById()
            this.Controls.RemoveByKey("btn" + txt.Text);
            txt.Text = "";
        }

        private void buttone_Click(object sender, EventArgs e)
        {
            //scatenato da un pulsante
            //quindi uniamo al pulsante l'oggetto sender cioè l'oggetto chiamante colui che ha scatenato il metodo
            Button btn = (Button)sender;//si fa il cast dell'oggetto così da far capire a C# quale ogetto è il sender
            btn.BackColor = Color.Red;
            MessageBox.Show("Sono il bottone con il numero " + btn.Text);
        }
    }
}
