
namespace MasterMind
{
    partial class frmMasterMind
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnInizia = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGioca = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInizia,
            this.btnGioca});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(755, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnInizia
            // 
            this.btnInizia.Name = "btnInizia";
            this.btnInizia.Size = new System.Drawing.Size(46, 20);
            this.btnInizia.Text = "Inizia";
            this.btnInizia.Click += new System.EventHandler(this.btnInizia_Click);
            // 
            // btnGioca
            // 
            this.btnGioca.Name = "btnGioca";
            this.btnGioca.Size = new System.Drawing.Size(49, 20);
            this.btnGioca.Text = "Gioca";
            this.btnGioca.Click += new System.EventHandler(this.btnGioca_Click);
            // 
            // frmMasterMind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 483);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMasterMind";
            this.Text = "MasterMind";
            this.Load += new System.EventHandler(this.frmMasterMind_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnInizia;
        private System.Windows.Forms.ToolStripMenuItem btnGioca;
    }
}

