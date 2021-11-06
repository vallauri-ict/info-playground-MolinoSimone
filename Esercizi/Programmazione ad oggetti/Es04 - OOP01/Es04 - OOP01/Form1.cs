using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es04___OOP01
{
    public partial class Form1 : Form
    {
        Rectangle r;
        Rectangle s = new Rectangle();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCrea_Click(object sender, EventArgs e)
        {
            //r = new Rectangle(5);
            r = new Rectangle(); 
            r.side1 = Convert.ToInt32(txtBase.Text); 
            r.side2 = Convert.ToInt32(txtAltezza.Text); 
           
            //si osservi che t non è stato istanziato!
            MessageBox.Show("Oggetto r -> \nbase: " + r.side1 + "\naltezza: " + r.side2);

            s.side1 = Convert.ToInt32(txtBase.Text);
            s.side2 = Convert.ToInt32(txtAltezza.Text);
            MessageBox.Show("Oggetto s -> \nbase: " + s.side1 + "\naltezza: " + s.side2);

            Rectangle t;
            t = r;
            MessageBox.Show("Oggetto t -> \nbase: " + t.side1 + "\naltezza: " + t.side2);
            // t è un puntatore a una zona di memoria
        }
    }
}
