﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnApriF2_Click(object sender, EventArgs e)
        {
            Form2 f2;
            f2 = new Form2();
            f2.Text = "Form 2 creta da Designer";
            f2.Show();

            Form2 f2b = new Form2(10);
            f2b.Text = "Form 2 creta da Designer con parametro";
            f2b.Show();
        }

        private void btnF2Controllo_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(txtDaPassare);
            f2.Text = "Form 2 con passaggio di un TextBox ";
            f2.Show();
        }
    }
}