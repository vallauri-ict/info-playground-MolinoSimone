
namespace RegEx01
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTesta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStringaDaTestare = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMatch = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTesta
            // 
            this.btnTesta.Location = new System.Drawing.Point(42, 52);
            this.btnTesta.Name = "btnTesta";
            this.btnTesta.Size = new System.Drawing.Size(93, 33);
            this.btnTesta.TabIndex = 0;
            this.btnTesta.Text = "Verifica";
            this.btnTesta.UseVisualStyleBackColor = true;
            this.btnTesta.Click += new System.EventHandler(this.btnTesta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inserisci stringa da testare";
            // 
            // txtStringaDaTestare
            // 
            this.txtStringaDaTestare.Location = new System.Drawing.Point(219, 27);
            this.txtStringaDaTestare.Name = "txtStringaDaTestare";
            this.txtStringaDaTestare.Size = new System.Drawing.Size(100, 22);
            this.txtStringaDaTestare.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Uso di match nella stringa: One car red car blue car";
            // 
            // btnMatch
            // 
            this.btnMatch.Location = new System.Drawing.Point(42, 161);
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Size = new System.Drawing.Size(108, 32);
            this.btnMatch.TabIndex = 4;
            this.btnMatch.Text = "Testa stringa";
            this.btnMatch.UseVisualStyleBackColor = true;
            this.btnMatch.Click += new System.EventHandler(this.btnMatch_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Testa stringa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(439, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Uso di match nella stringa: \"123ABCDE456FGHIJKL789MNOPQ012\"";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(42, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 32);
            this.button2.TabIndex = 8;
            this.button2.Text = "Testa stringa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(586, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Uso di replace nella stringa: \"This          is      text      with      far     " +
    "  too much     whitespace\"";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 459);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMatch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStringaDaTestare);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTesta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTesta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStringaDaTestare;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMatch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
    }
}

