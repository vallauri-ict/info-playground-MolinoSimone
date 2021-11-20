using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP11___AS_e_IS
{
    public partial class Form1 : Form
    {

        Random casuale = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGeneraMostro_Click(object sender, EventArgs e)
        {
            Mostro guardiano;
            if (casuale.Next(2) == 0)
            {
                guardiano = new Mannaro();
            }
            else
            {
                guardiano = new Zombie();
            }
            MessageBox.Show("Verso come Mostro: " + guardiano.verso());
            if (guardiano is Mannaro)
            {
                MessageBox.Show("Verso come Mannaro: " + (guardiano as Mannaro).verso());
                //Alternativa:
                //MessageBox.Show("Verso come Mannaro: " + ((Mannaro)guardiano).verso());
            }
            else if (guardiano is Zombie)
            {
                MessageBox.Show("Verso come Zombie: " + (guardiano as Zombie).verso());
            }
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (sender is Button) 
                (sender as Button).Text = "Cliccato"; 
            if (sender is Label) 
                (sender as Label).BackColor = Color.Red;
        }
    }
}
