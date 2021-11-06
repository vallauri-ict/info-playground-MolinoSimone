using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms01
{
    public partial class FormModale : Form
    {
        public string nome = "";
        public string età = "";
        public FormModale()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            età = txtEtà.Text;
            nome = txtNome.Text;
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            età = "";
            nome = "";
        }
    }
}
