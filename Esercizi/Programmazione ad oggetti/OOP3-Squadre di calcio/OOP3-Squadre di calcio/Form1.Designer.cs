
namespace OOP3_Squadre_di_calcio
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
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.txtCittaA = new System.Windows.Forms.TextBox();
            this.txtCittaB = new System.Windows.Forms.TextBox();
            this.txtCittaC = new System.Windows.Forms.TextBox();
            this.txtPuntiA = new System.Windows.Forms.TextBox();
            this.txtPuntiB = new System.Windows.Forms.TextBox();
            this.txtPuntiC = new System.Windows.Forms.TextBox();
            this.btnCreaA = new System.Windows.Forms.Button();
            this.btnCreaB = new System.Windows.Forms.Button();
            this.btnCreaC = new System.Windows.Forms.Button();
            this.btnAVince = new System.Windows.Forms.Button();
            this.btnBVince = new System.Windows.Forms.Button();
            this.btnCVince = new System.Windows.Forms.Button();
            this.btnAPareggia = new System.Windows.Forms.Button();
            this.btnBPareggia = new System.Windows.Forms.Button();
            this.btnCPareggia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(13, 38);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(70, 17);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "Squadra1";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(13, 73);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(70, 17);
            this.lblB.TabIndex = 1;
            this.lblB.Text = "Squadra2";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(12, 109);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(70, 17);
            this.lblC.TabIndex = 2;
            this.lblC.Text = "Squadra3";
            // 
            // txtCittaA
            // 
            this.txtCittaA.Location = new System.Drawing.Point(113, 35);
            this.txtCittaA.Name = "txtCittaA";
            this.txtCittaA.ReadOnly = true;
            this.txtCittaA.Size = new System.Drawing.Size(100, 22);
            this.txtCittaA.TabIndex = 3;
            // 
            // txtCittaB
            // 
            this.txtCittaB.Location = new System.Drawing.Point(113, 70);
            this.txtCittaB.Name = "txtCittaB";
            this.txtCittaB.ReadOnly = true;
            this.txtCittaB.Size = new System.Drawing.Size(100, 22);
            this.txtCittaB.TabIndex = 4;
            // 
            // txtCittaC
            // 
            this.txtCittaC.Location = new System.Drawing.Point(113, 106);
            this.txtCittaC.Name = "txtCittaC";
            this.txtCittaC.ReadOnly = true;
            this.txtCittaC.Size = new System.Drawing.Size(100, 22);
            this.txtCittaC.TabIndex = 5;
            // 
            // txtPuntiA
            // 
            this.txtPuntiA.Location = new System.Drawing.Point(246, 35);
            this.txtPuntiA.Name = "txtPuntiA";
            this.txtPuntiA.ReadOnly = true;
            this.txtPuntiA.Size = new System.Drawing.Size(100, 22);
            this.txtPuntiA.TabIndex = 6;
            // 
            // txtPuntiB
            // 
            this.txtPuntiB.Location = new System.Drawing.Point(246, 70);
            this.txtPuntiB.Name = "txtPuntiB";
            this.txtPuntiB.ReadOnly = true;
            this.txtPuntiB.Size = new System.Drawing.Size(100, 22);
            this.txtPuntiB.TabIndex = 7;
            // 
            // txtPuntiC
            // 
            this.txtPuntiC.Location = new System.Drawing.Point(246, 106);
            this.txtPuntiC.Name = "txtPuntiC";
            this.txtPuntiC.ReadOnly = true;
            this.txtPuntiC.Size = new System.Drawing.Size(100, 22);
            this.txtPuntiC.TabIndex = 8;
            // 
            // btnCreaA
            // 
            this.btnCreaA.Location = new System.Drawing.Point(7, 167);
            this.btnCreaA.Name = "btnCreaA";
            this.btnCreaA.Size = new System.Drawing.Size(100, 30);
            this.btnCreaA.TabIndex = 9;
            this.btnCreaA.Text = "Crea A";
            this.btnCreaA.UseVisualStyleBackColor = true;
            this.btnCreaA.Click += new System.EventHandler(this.btnCreaA_Click);
            // 
            // btnCreaB
            // 
            this.btnCreaB.Location = new System.Drawing.Point(113, 167);
            this.btnCreaB.Name = "btnCreaB";
            this.btnCreaB.Size = new System.Drawing.Size(100, 30);
            this.btnCreaB.TabIndex = 10;
            this.btnCreaB.Text = "Crea B";
            this.btnCreaB.UseVisualStyleBackColor = true;
            // 
            // btnCreaC
            // 
            this.btnCreaC.Location = new System.Drawing.Point(228, 167);
            this.btnCreaC.Name = "btnCreaC";
            this.btnCreaC.Size = new System.Drawing.Size(100, 30);
            this.btnCreaC.TabIndex = 11;
            this.btnCreaC.Text = "Crea C";
            this.btnCreaC.UseVisualStyleBackColor = true;
            // 
            // btnAVince
            // 
            this.btnAVince.Location = new System.Drawing.Point(7, 196);
            this.btnAVince.Name = "btnAVince";
            this.btnAVince.Size = new System.Drawing.Size(100, 30);
            this.btnAVince.TabIndex = 12;
            this.btnAVince.Text = "A Vince";
            this.btnAVince.UseVisualStyleBackColor = true;
            // 
            // btnBVince
            // 
            this.btnBVince.Location = new System.Drawing.Point(113, 196);
            this.btnBVince.Name = "btnBVince";
            this.btnBVince.Size = new System.Drawing.Size(100, 30);
            this.btnBVince.TabIndex = 13;
            this.btnBVince.Text = "B Vince";
            this.btnBVince.UseVisualStyleBackColor = true;
            // 
            // btnCVince
            // 
            this.btnCVince.Location = new System.Drawing.Point(228, 196);
            this.btnCVince.Name = "btnCVince";
            this.btnCVince.Size = new System.Drawing.Size(100, 30);
            this.btnCVince.TabIndex = 14;
            this.btnCVince.Text = "C Vince";
            this.btnCVince.UseVisualStyleBackColor = true;
            // 
            // btnAPareggia
            // 
            this.btnAPareggia.Location = new System.Drawing.Point(7, 225);
            this.btnAPareggia.Name = "btnAPareggia";
            this.btnAPareggia.Size = new System.Drawing.Size(100, 30);
            this.btnAPareggia.TabIndex = 15;
            this.btnAPareggia.Text = "A Pareggia";
            this.btnAPareggia.UseVisualStyleBackColor = true;
            // 
            // btnBPareggia
            // 
            this.btnBPareggia.Location = new System.Drawing.Point(113, 225);
            this.btnBPareggia.Name = "btnBPareggia";
            this.btnBPareggia.Size = new System.Drawing.Size(100, 30);
            this.btnBPareggia.TabIndex = 16;
            this.btnBPareggia.Text = "B Pareggia";
            this.btnBPareggia.UseVisualStyleBackColor = true;
            // 
            // btnCPareggia
            // 
            this.btnCPareggia.Location = new System.Drawing.Point(228, 225);
            this.btnCPareggia.Name = "btnCPareggia";
            this.btnCPareggia.Size = new System.Drawing.Size(100, 30);
            this.btnCPareggia.TabIndex = 17;
            this.btnCPareggia.Text = "C Pareggia";
            this.btnCPareggia.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCPareggia);
            this.Controls.Add(this.btnBPareggia);
            this.Controls.Add(this.btnAPareggia);
            this.Controls.Add(this.btnCVince);
            this.Controls.Add(this.btnBVince);
            this.Controls.Add(this.btnAVince);
            this.Controls.Add(this.btnCreaC);
            this.Controls.Add(this.btnCreaB);
            this.Controls.Add(this.btnCreaA);
            this.Controls.Add(this.txtPuntiC);
            this.Controls.Add(this.txtPuntiB);
            this.Controls.Add(this.txtPuntiA);
            this.Controls.Add(this.txtCittaC);
            this.Controls.Add(this.txtCittaB);
            this.Controls.Add(this.txtCittaA);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox txtCittaA;
        private System.Windows.Forms.TextBox txtCittaB;
        private System.Windows.Forms.TextBox txtCittaC;
        private System.Windows.Forms.TextBox txtPuntiA;
        private System.Windows.Forms.TextBox txtPuntiB;
        private System.Windows.Forms.TextBox txtPuntiC;
        private System.Windows.Forms.Button btnCreaA;
        private System.Windows.Forms.Button btnCreaB;
        private System.Windows.Forms.Button btnCreaC;
        private System.Windows.Forms.Button btnAVince;
        private System.Windows.Forms.Button btnBVince;
        private System.Windows.Forms.Button btnCVince;
        private System.Windows.Forms.Button btnAPareggia;
        private System.Windows.Forms.Button btnBPareggia;
        private System.Windows.Forms.Button btnCPareggia;
    }
}

