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
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        RichTextBox resultBox;
        TextBox txtFormato;
        TextBox txtNumero;
        TextBox txtRisultato;
        int resultBoxTextSize = 24;

        public struct ButtonStruct
        {
            public char Content;
            public bool IsNumber;
            public bool IsPlus;
            public bool IsHashtag;
            public ButtonStruct(char content, bool isNumber = true, bool isPlus=false,
                bool isHashtag = false)
            {
                this.Content = content;
                this.IsNumber = isNumber;
                this.IsPlus = isPlus;
                this.IsHashtag = isHashtag;
            }
            public override string ToString()
            {
                return Content.ToString();
            }
        }
        private ButtonStruct[,] buttons =
        {
            { new ButtonStruct('7'), new ButtonStruct('8'), new ButtonStruct('9')},
            { new ButtonStruct('4'), new ButtonStruct('5'), new ButtonStruct('6')},
            { new ButtonStruct('1'), new ButtonStruct('2'), new ButtonStruct('3')},
            { new ButtonStruct('+', false, true), new ButtonStruct('0'), new ButtonStruct('#', false,false,true)},


            
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GeneraParti();
        }

        private void GeneraParti()
        {
            
            int buttonWidth = 80;
            int buttonHeight = 40;
            for (int i = 0; i < 6; i++)
            {
                int posX;
                int posY;
                posX = rnd.Next(0, 710);
                posY = rnd.Next(400, 520);
                Button myButton = new Button();
                myButton.Width = buttonWidth;
                myButton.Height = buttonHeight;
                myButton.Name = "btnParte" + i.ToString();
                myButton.Left = posX;
                myButton.Top = posY;
                switch (i)
                {
                    case 0:
                        myButton.Text = "Parte 3";
                        myButton.Click += parte3Click;
                        break;
                    case 1:
                        myButton.Text = "Parte 4";
                        myButton.Click += parte4Click;
                        break;
                    case 2:
                        myButton.Text = "Parte 5";
                        myButton.Click += parte5Click;
                        break;
                    case 3:
                        myButton.Text = "Parte 6";
                        myButton.Click += parte6Click;
                        break;
                    case 4:
                        myButton.Text = "Parte 7";
                        myButton.Click += parte7Click;
                        break;
                    case 5:
                        myButton.Text = "FAC";
                        myButton.Click += parteFacClick;
                        break;
                    
                }
                this.Controls.Add(myButton);
            }
        }

        private void parteFacClick(object sender, EventArgs e)
        {
            //rimuovo telefono
            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    ButtonStruct myButtonStruct = buttons[i, j];
                    this.Controls.RemoveByKey("btn" + myButtonStruct.ToString());
                }
            }

            //rimuovo resultBox
            this.Controls.RemoveByKey("resultBox");

            //bottoni 
            GeneraPartiDistanti();


            this.Controls.RemoveByKey("lbl1");
            this.Controls.RemoveByKey("lbl2");
            this.Controls.RemoveByKey("lbl3");
            this.Controls.RemoveByKey("txtFormato");
            this.Controls.RemoveByKey("txtNumero");
            this.Controls.RemoveByKey("txtRisultato");


        }

        private void parte7Click(object sender, EventArgs e)
        {
            Label lbl = new Label();
            txtFormato = new TextBox();
            lbl.Top = 10;
            lbl.Left = 300;
            lbl.Text = "Formato: ";
            lbl.Name = "lbl1";
            txtFormato.Top = 10;
            txtFormato.Name = "txtFormato";
            txtFormato.Width = 80;
            txtFormato.Left = 400;
            this.Controls.Add(lbl);
            this.Controls.Add(txtFormato);

            lbl = new Label();
            txtNumero = new TextBox();
            lbl.Top = 40;
            lbl.Left = 300;
            lbl.Text = "Numero: ";
            lbl.Name = "lbl2";
            txtNumero.Width = 80;
            txtNumero.Top = 40;
            txtNumero.Name = "txtNumero";
            txtNumero.Left = 400;
            txtNumero.TextChanged += txtTextChanged;
            this.Controls.Add(lbl);
            this.Controls.Add(txtNumero);

            lbl = new Label();
            txtRisultato = new TextBox();
            lbl.Top = 70;
            lbl.Left = 300;
            lbl.Text = "Numero Formattato: ";
            lbl.Name = "lbl3";
            txtRisultato.Width = 80;
            txtRisultato.Top = 70;
            txtRisultato.Name = "txtRisultato";
            txtRisultato.Left = 400;
            txtRisultato.ReadOnly = true;
            this.Controls.Add(lbl);
            this.Controls.Add(txtRisultato);
        }

        private void txtTextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            double num;
            num = Convert.ToDouble(txtNumero.Text);
            txtRisultato.Text = getFormattedNumber(num);
        }

        private string getFormattedNumber(double text)
        {
            string stOut = text.ToString(txtFormato.Text);
            return stOut;
        }

        private void parte6Click(object sender, EventArgs e)
        {
            resultBox = new RichTextBox();
            resultBox.ReadOnly = true;
            resultBox.Font = new Font("Segoe UI", resultBoxTextSize, FontStyle.Regular);
            resultBox.Width = 300;
            resultBox.Name = "ResultBox";
            resultBox.Height = 120;
            resultBox.Text = "";
            resultBox.TabStop = false;
            this.Controls.Add(resultBox);
        }

        private void parte5Click(object sender, EventArgs e)
        {
            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    ButtonStruct myButtonStruct = buttons[i, j];
                    this.Controls.RemoveByKey("btn" + myButtonStruct.ToString());
                } 
            }
        }

        private void parte4Click(object sender, EventArgs e)
        {
            int buttonWidth = 100;
            int buttonHeight = 50;
            int posX = 0;
            int posY = 200;
            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    ButtonStruct myButtonStruct = buttons[i, j];
                    Button myButton = new Button();
                    myButton.Text = myButtonStruct.ToString();
                    myButton.Width = buttonWidth;
                    myButton.Height = buttonHeight;
                    myButton.Left = posX;
                    myButton.Top = posY;
                    myButton.Tag = myButtonStruct;
                    myButton.Name = "btn" + myButtonStruct.ToString();
                    myButton.Click += ButtonGrid_Click;
                    this.Controls.Add(myButton);
                    posX += buttonWidth;
                }
                posX = 0;
                posY += buttonHeight;
            }
        }

        private void ButtonGrid_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            ButtonStruct clickedButtonStructure = (ButtonStruct)clickedButton.Tag;
            if (clickedButtonStructure.IsNumber)
            {
                resultBox.Text = resultBox.Text + clickedButton.Text;
            }
            else if (clickedButtonStructure.IsPlus)
                if (resultBox.Text == "")
                    resultBox.Text = "+";
            else if (clickedButtonStructure.IsHashtag)
            {
                    resultBox.Text = resultBox.Text + clickedButton.Text;
            }
        }

        private void parte3Click(object sender, EventArgs e)
        {
            GeneraPartiDistanti();
        }

        private void GeneraPartiDistanti()
        {
            for (int i = 0; i < 6; i++)
            {
                this.Controls.RemoveByKey("btnParte" + i);
            }

            int buttonWidth = 80;
            int buttonHeight = 40;
            int posX;
            int posY;
            int[] vetPosX = new int[6];

            for (int i = 0; i < 6; i++)
            {
                
                Button myButton = new Button();
                myButton.Width = buttonWidth;
                myButton.Name = "btnParte" + i.ToString();
                myButton.Height = buttonHeight;
                
                switch (i)
                {
                    case 0:
                        myButton.Text = "Parte 3";
                        posX = rnd.Next(0, 200);
                        posY = rnd.Next(400, 470);
                        myButton.Left = posX;
                        myButton.Top = posY;
                        myButton.Click += parte3Click;
                        break;
                    case 1:
                        myButton.Text = "Parte 4";
                        posX = rnd.Next(280, 400);
                        posY = rnd.Next(400, 470);
                        myButton.Left = posX;
                        myButton.Top = posY;
                        myButton.Click += parte4Click;
                        break;
                    case 2:
                        myButton.Text = "Parte 5";
                        posX = rnd.Next(560, 710);
                        posY = rnd.Next(400, 470);
                        myButton.Left = posX;
                        myButton.Top = posY;
                        myButton.Click += parte5Click;
                        break;
                    case 3:
                        myButton.Text = "Parte 6";
                        posX = rnd.Next(0, 200);
                        posY = rnd.Next(510, 530);
                        myButton.Left = posX;
                        myButton.Top = posY;
                        myButton.Click += parte6Click;
                        break;
                    case 4:
                        myButton.Text = "Parte 7";
                        posX = rnd.Next(280, 400);
                        posY = rnd.Next(510, 530);
                        myButton.Left = posX;
                        myButton.Top = posY;
                        myButton.Click += parte7Click;
                        break;
                    case 5:
                        myButton.Text = "FAC";
                        posX = rnd.Next(480, 710);
                        posY = rnd.Next(510, 530);
                        myButton.Left = posX;
                        myButton.Top = posY;
                        myButton.Click += parteFacClick;
                        break;

                }
                this.Controls.Add(myButton);
            }
        }
    }
}
