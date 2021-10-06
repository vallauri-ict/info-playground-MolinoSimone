
namespace WindowsForm03___Esercitazione_Verifica
{
    partial class Figlia1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ckbPelle = new System.Windows.Forms.CheckBox();
            this.ckbStoffa = new System.Windows.Forms.CheckBox();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.btnInvia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ckbPelle
            // 
            this.ckbPelle.AutoSize = true;
            this.ckbPelle.Location = new System.Drawing.Point(72, 28);
            this.ckbPelle.Name = "ckbPelle";
            this.ckbPelle.Size = new System.Drawing.Size(118, 21);
            this.ckbPelle.TabIndex = 0;
            this.ckbPelle.Text = "Interni in pelle";
            this.ckbPelle.UseVisualStyleBackColor = true;
            // 
            // ckbStoffa
            // 
            this.ckbStoffa.AutoSize = true;
            this.ckbStoffa.Location = new System.Drawing.Point(72, 64);
            this.ckbStoffa.Name = "ckbStoffa";
            this.ckbStoffa.Size = new System.Drawing.Size(123, 21);
            this.ckbStoffa.TabIndex = 1;
            this.ckbStoffa.Text = "Interni in stoffa";
            this.ckbStoffa.UseVisualStyleBackColor = true;
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Items.AddRange(new object[] {
            "BMW",
            "FIAT",
            "SEAT",
            "OPEL"});
            this.cmbMarca.Location = new System.Drawing.Point(72, 110);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(121, 24);
            this.cmbMarca.TabIndex = 2;
            // 
            // btnInvia
            // 
            this.btnInvia.Location = new System.Drawing.Point(207, 145);
            this.btnInvia.Name = "btnInvia";
            this.btnInvia.Size = new System.Drawing.Size(94, 34);
            this.btnInvia.TabIndex = 3;
            this.btnInvia.Text = "Invia Dati";
            this.btnInvia.UseVisualStyleBackColor = true;
            this.btnInvia.Click += new System.EventHandler(this.btnInvia_Click);
            // 
            // Figlia1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 273);
            this.Controls.Add(this.btnInvia);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.ckbStoffa);
            this.Controls.Add(this.ckbPelle);
            this.Name = "Figlia1";
            this.Text = "Figlia1";
            this.Load += new System.EventHandler(this.Figlia1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckbPelle;
        private System.Windows.Forms.CheckBox ckbStoffa;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Button btnInvia;
    }
}