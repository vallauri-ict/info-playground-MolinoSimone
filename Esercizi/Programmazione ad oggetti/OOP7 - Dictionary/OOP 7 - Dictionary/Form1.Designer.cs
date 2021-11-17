
namespace OOP_7___Dictionary
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
            this.txtTitolo = new System.Windows.Forms.TextBox();
            this.txtAutore = new System.Windows.Forms.TextBox();
            this.btnDizionario = new System.Windows.Forms.Button();
            this.btnVisDizionario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownIndiceLibro = new System.Windows.Forms.NumericUpDown();
            this.btnVisLibro = new System.Windows.Forms.Button();
            this.btnCoda = new System.Windows.Forms.Button();
            this.btnPila = new System.Windows.Forms.Button();
            this.btnEstraiCoda = new System.Windows.Forms.Button();
            this.BtnEstraiPila = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIndiceLibro)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitolo
            // 
            this.txtTitolo.Location = new System.Drawing.Point(121, 47);
            this.txtTitolo.Name = "txtTitolo";
            this.txtTitolo.Size = new System.Drawing.Size(100, 22);
            this.txtTitolo.TabIndex = 1;
            // 
            // txtAutore
            // 
            this.txtAutore.Location = new System.Drawing.Point(121, 121);
            this.txtAutore.Name = "txtAutore";
            this.txtAutore.Size = new System.Drawing.Size(100, 22);
            this.txtAutore.TabIndex = 2;
            // 
            // btnDizionario
            // 
            this.btnDizionario.Location = new System.Drawing.Point(309, 12);
            this.btnDizionario.Name = "btnDizionario";
            this.btnDizionario.Size = new System.Drawing.Size(142, 57);
            this.btnDizionario.TabIndex = 3;
            this.btnDizionario.Text = "Aggiungi Al Dizionario";
            this.btnDizionario.UseVisualStyleBackColor = true;
            this.btnDizionario.Click += new System.EventHandler(this.btnDizionario_Click);
            // 
            // btnVisDizionario
            // 
            this.btnVisDizionario.Location = new System.Drawing.Point(309, 75);
            this.btnVisDizionario.Name = "btnVisDizionario";
            this.btnVisDizionario.Size = new System.Drawing.Size(142, 51);
            this.btnVisDizionario.TabIndex = 4;
            this.btnVisDizionario.Text = "Visualizza Dizionario";
            this.btnVisDizionario.UseVisualStyleBackColor = true;
            this.btnVisDizionario.Click += new System.EventHandler(this.btnVisDizionario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Titolo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Autore:";
            // 
            // numericUpDownIndiceLibro
            // 
            this.numericUpDownIndiceLibro.Location = new System.Drawing.Point(53, 183);
            this.numericUpDownIndiceLibro.Name = "numericUpDownIndiceLibro";
            this.numericUpDownIndiceLibro.Size = new System.Drawing.Size(51, 22);
            this.numericUpDownIndiceLibro.TabIndex = 7;
            // 
            // btnVisLibro
            // 
            this.btnVisLibro.Location = new System.Drawing.Point(135, 181);
            this.btnVisLibro.Name = "btnVisLibro";
            this.btnVisLibro.Size = new System.Drawing.Size(75, 23);
            this.btnVisLibro.TabIndex = 8;
            this.btnVisLibro.Text = "VisLibro";
            this.btnVisLibro.UseVisualStyleBackColor = true;
            this.btnVisLibro.Click += new System.EventHandler(this.btnVisLibro_Click);
            // 
            // btnCoda
            // 
            this.btnCoda.Location = new System.Drawing.Point(309, 142);
            this.btnCoda.Name = "btnCoda";
            this.btnCoda.Size = new System.Drawing.Size(142, 51);
            this.btnCoda.TabIndex = 9;
            this.btnCoda.Text = "Aggiungi in Coda";
            this.btnCoda.UseVisualStyleBackColor = true;
            this.btnCoda.Click += new System.EventHandler(this.btnCoda_Click);
            // 
            // btnPila
            // 
            this.btnPila.Location = new System.Drawing.Point(456, 142);
            this.btnPila.Name = "btnPila";
            this.btnPila.Size = new System.Drawing.Size(142, 51);
            this.btnPila.TabIndex = 10;
            this.btnPila.Text = "Aggiungi in Pila";
            this.btnPila.UseVisualStyleBackColor = true;
            this.btnPila.Click += new System.EventHandler(this.btnPila_Click);
            // 
            // btnEstraiCoda
            // 
            this.btnEstraiCoda.Location = new System.Drawing.Point(309, 215);
            this.btnEstraiCoda.Name = "btnEstraiCoda";
            this.btnEstraiCoda.Size = new System.Drawing.Size(142, 51);
            this.btnEstraiCoda.TabIndex = 11;
            this.btnEstraiCoda.Text = "Estrai Coda";
            this.btnEstraiCoda.UseVisualStyleBackColor = true;
            this.btnEstraiCoda.Click += new System.EventHandler(this.btnEstraiCoda_Click);
            // 
            // BtnEstraiPila
            // 
            this.BtnEstraiPila.Location = new System.Drawing.Point(456, 215);
            this.BtnEstraiPila.Name = "BtnEstraiPila";
            this.BtnEstraiPila.Size = new System.Drawing.Size(142, 51);
            this.BtnEstraiPila.TabIndex = 12;
            this.BtnEstraiPila.Text = "Estrai Pila";
            this.BtnEstraiPila.UseVisualStyleBackColor = true;
            this.BtnEstraiPila.Click += new System.EventHandler(this.BtnEstraiPila_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 313);
            this.Controls.Add(this.BtnEstraiPila);
            this.Controls.Add(this.btnEstraiCoda);
            this.Controls.Add(this.btnPila);
            this.Controls.Add(this.btnCoda);
            this.Controls.Add(this.btnVisLibro);
            this.Controls.Add(this.numericUpDownIndiceLibro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVisDizionario);
            this.Controls.Add(this.btnDizionario);
            this.Controls.Add(this.txtAutore);
            this.Controls.Add(this.txtTitolo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIndiceLibro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTitolo;
        private System.Windows.Forms.TextBox txtAutore;
        private System.Windows.Forms.Button btnDizionario;
        private System.Windows.Forms.Button btnVisDizionario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownIndiceLibro;
        private System.Windows.Forms.Button btnVisLibro;
        private System.Windows.Forms.Button btnCoda;
        private System.Windows.Forms.Button btnPila;
        private System.Windows.Forms.Button btnEstraiCoda;
        private System.Windows.Forms.Button BtnEstraiPila;
    }
}

