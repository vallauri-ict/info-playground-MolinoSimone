
namespace OOP8___Esercizio_Dizionario
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
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtNomeArticolo = new System.Windows.Forms.TextBox();
            this.btnSalvaArticolo = new System.Windows.Forms.Button();
            this.lblNArticoli = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblArticolo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(119, 30);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(100, 22);
            this.txtKey.TabIndex = 0;
            // 
            // txtNomeArticolo
            // 
            this.txtNomeArticolo.Location = new System.Drawing.Point(119, 75);
            this.txtNomeArticolo.Name = "txtNomeArticolo";
            this.txtNomeArticolo.Size = new System.Drawing.Size(100, 22);
            this.txtNomeArticolo.TabIndex = 1;
            // 
            // btnSalvaArticolo
            // 
            this.btnSalvaArticolo.Location = new System.Drawing.Point(225, 30);
            this.btnSalvaArticolo.Name = "btnSalvaArticolo";
            this.btnSalvaArticolo.Size = new System.Drawing.Size(125, 67);
            this.btnSalvaArticolo.TabIndex = 2;
            this.btnSalvaArticolo.Text = "Salva Articolo";
            this.btnSalvaArticolo.UseVisualStyleBackColor = true;
            this.btnSalvaArticolo.Click += new System.EventHandler(this.btnSalvaArticolo_Click);
            // 
            // lblNArticoli
            // 
            this.lblNArticoli.AutoSize = true;
            this.lblNArticoli.Location = new System.Drawing.Point(376, 151);
            this.lblNArticoli.Name = "lblNArticoli";
            this.lblNArticoli.Size = new System.Drawing.Size(0, 17);
            this.lblNArticoli.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 67);
            this.button1.TabIndex = 4;
            this.button1.Text = "Mostra Numero Articoli";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(119, 239);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 22);
            this.txtInput.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(225, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 67);
            this.button2.TabIndex = 6;
            this.button2.Text = "Mostra Articoli Da chiave";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblArticolo
            // 
            this.lblArticolo.AutoSize = true;
            this.lblArticolo.Location = new System.Drawing.Point(379, 244);
            this.lblArticolo.Name = "lblArticolo";
            this.lblArticolo.Size = new System.Drawing.Size(0, 17);
            this.lblArticolo.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Key:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Articolo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Key input:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblArticolo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblNArticoli);
            this.Controls.Add(this.btnSalvaArticolo);
            this.Controls.Add(this.txtNomeArticolo);
            this.Controls.Add(this.txtKey);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtNomeArticolo;
        private System.Windows.Forms.Button btnSalvaArticolo;
        private System.Windows.Forms.Label lblNArticoli;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblArticolo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

