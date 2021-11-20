
namespace OOP9___Esercizio_Pile
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEta = new System.Windows.Forms.TextBox();
            this.txtCodice = new System.Windows.Forms.TextBox();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.btnValoriTemperaturaMaxMin = new System.Windows.Forms.Button();
            this.btnRichiediPaziente = new System.Windows.Forms.Button();
            this.btnInserisciPaziente = new System.Windows.Forms.Button();
            this.lblPazienteOut = new System.Windows.Forms.Label();
            this.lblTemperatureMaxMin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(123, 42);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 22);
            this.txtNome.TabIndex = 0;
            // 
            // txtEta
            // 
            this.txtEta.Location = new System.Drawing.Point(123, 70);
            this.txtEta.Name = "txtEta";
            this.txtEta.Size = new System.Drawing.Size(100, 22);
            this.txtEta.TabIndex = 1;
            // 
            // txtCodice
            // 
            this.txtCodice.Location = new System.Drawing.Point(123, 98);
            this.txtCodice.Name = "txtCodice";
            this.txtCodice.Size = new System.Drawing.Size(100, 22);
            this.txtCodice.TabIndex = 2;
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(123, 126);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(100, 22);
            this.txtTemp.TabIndex = 3;
            // 
            // btnValoriTemperaturaMaxMin
            // 
            this.btnValoriTemperaturaMaxMin.Location = new System.Drawing.Point(274, 305);
            this.btnValoriTemperaturaMaxMin.Name = "btnValoriTemperaturaMaxMin";
            this.btnValoriTemperaturaMaxMin.Size = new System.Drawing.Size(129, 57);
            this.btnValoriTemperaturaMaxMin.TabIndex = 4;
            this.btnValoriTemperaturaMaxMin.Text = "Valori Min Max Temperatura";
            this.btnValoriTemperaturaMaxMin.UseVisualStyleBackColor = true;
            this.btnValoriTemperaturaMaxMin.Click += new System.EventHandler(this.btnValoriTemperaturaMaxMin_Click);
            // 
            // btnRichiediPaziente
            // 
            this.btnRichiediPaziente.Location = new System.Drawing.Point(274, 238);
            this.btnRichiediPaziente.Name = "btnRichiediPaziente";
            this.btnRichiediPaziente.Size = new System.Drawing.Size(129, 51);
            this.btnRichiediPaziente.TabIndex = 5;
            this.btnRichiediPaziente.Text = "Richiesta Paziente";
            this.btnRichiediPaziente.UseVisualStyleBackColor = true;
            this.btnRichiediPaziente.Click += new System.EventHandler(this.btnRichiediPaziente_Click);
            // 
            // btnInserisciPaziente
            // 
            this.btnInserisciPaziente.Location = new System.Drawing.Point(274, 69);
            this.btnInserisciPaziente.Name = "btnInserisciPaziente";
            this.btnInserisciPaziente.Size = new System.Drawing.Size(129, 51);
            this.btnInserisciPaziente.TabIndex = 6;
            this.btnInserisciPaziente.Text = "Inserisci Paziente";
            this.btnInserisciPaziente.UseVisualStyleBackColor = true;
            this.btnInserisciPaziente.Click += new System.EventHandler(this.btnInserisciPaziente_Click);
            // 
            // lblPazienteOut
            // 
            this.lblPazienteOut.AutoSize = true;
            this.lblPazienteOut.Location = new System.Drawing.Point(486, 146);
            this.lblPazienteOut.Name = "lblPazienteOut";
            this.lblPazienteOut.Size = new System.Drawing.Size(0, 17);
            this.lblPazienteOut.TabIndex = 7;
            // 
            // lblTemperatureMaxMin
            // 
            this.lblTemperatureMaxMin.AutoSize = true;
            this.lblTemperatureMaxMin.Location = new System.Drawing.Point(486, 272);
            this.lblTemperatureMaxMin.Name = "lblTemperatureMaxMin";
            this.lblTemperatureMaxMin.Size = new System.Drawing.Size(0, 17);
            this.lblTemperatureMaxMin.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Età:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Codice Colore:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Temperatura:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 466);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTemperatureMaxMin);
            this.Controls.Add(this.lblPazienteOut);
            this.Controls.Add(this.btnInserisciPaziente);
            this.Controls.Add(this.btnRichiediPaziente);
            this.Controls.Add(this.btnValoriTemperaturaMaxMin);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.txtCodice);
            this.Controls.Add(this.txtEta);
            this.Controls.Add(this.txtNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEta;
        private System.Windows.Forms.TextBox txtCodice;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Button btnValoriTemperaturaMaxMin;
        private System.Windows.Forms.Button btnRichiediPaziente;
        private System.Windows.Forms.Button btnInserisciPaziente;
        private System.Windows.Forms.Label lblPazienteOut;
        private System.Windows.Forms.Label lblTemperatureMaxMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

