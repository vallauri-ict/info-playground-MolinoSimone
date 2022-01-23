using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RegEx01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTesta_Click(object sender, EventArgs e)
        {
            string pattern = @"^[a-zA-Z0-9]\d{2}[a-zA-Z0-9](-\d{3}){2}[A-Za-z0-9]$";
            Regex rxt = new Regex(@"^[a-zA-Z0-9]\d{2}[a-zA-Z0-9](-\d{3}){2}[A-Za-z0-9]$");
            string str = txtStringaDaTestare.Text;
            MessageBox.Show(str + " " + rxt.IsMatch(str));
            MessageBox.Show(str + " " + Regex.IsMatch(str, pattern));

        }

        private void btnMatch_Click(object sender, EventArgs e)
        {
            string str = "One car red car blue car";
            string pat = @"(\w+)\s+(car)";
            int count = 0;

            Regex r = new Regex(pat);

            Match m = r.Match(str);
            while (m.Success)
            {
                MessageBox.Show("Trovato: gruppo " + (++count) + "\nValore:" + m.Value +"\nAlla posizione: " + m.Index);
                m = m.NextMatch();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "123ABCDE456FGHIJKL789MNOPQ012";
            string pat = @"\d+";
            int count = 0;

            Regex r = new Regex(pat);

            string[] result = r.Split(str);
            for (int i = 0; i < result.Length; i++)
            {
                MessageBox.Show("Stringa " + (i+1) + ": \"" + result[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = "This          is      text      with      far       too much     whitespace";
            string pat = "\\s+";
            string replacement = " ";

            Regex r = new Regex(pat);

            string result = r.Replace(str, replacement);
            for (int i = 0; i < result.Length; i++)
            {
                MessageBox.Show("Stringa originale: \"" + str + "\"" + "\n" + "Stringa Risultante: " + result);
            }
        }
    }
}
