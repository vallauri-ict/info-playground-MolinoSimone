
namespace WindowsForm02
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
            this.btnApriFiglia1 = new System.Windows.Forms.Button();
            this.btnApriFiglia2 = new System.Windows.Forms.Button();
            this.btnFinestreAperte = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menùToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apri1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apri2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnApriFiglia1
            // 
            this.btnApriFiglia1.Location = new System.Drawing.Point(27, 74);
            this.btnApriFiglia1.Name = "btnApriFiglia1";
            this.btnApriFiglia1.Size = new System.Drawing.Size(147, 59);
            this.btnApriFiglia1.TabIndex = 1;
            this.btnApriFiglia1.Text = "Apri Figlia1";
            this.btnApriFiglia1.UseVisualStyleBackColor = true;
            this.btnApriFiglia1.Click += new System.EventHandler(this.btnApriFiglia1_Click);
            // 
            // btnApriFiglia2
            // 
            this.btnApriFiglia2.Location = new System.Drawing.Point(180, 74);
            this.btnApriFiglia2.Name = "btnApriFiglia2";
            this.btnApriFiglia2.Size = new System.Drawing.Size(147, 59);
            this.btnApriFiglia2.TabIndex = 2;
            this.btnApriFiglia2.Text = "Apri Figlia2";
            this.btnApriFiglia2.UseVisualStyleBackColor = true;
            this.btnApriFiglia2.Click += new System.EventHandler(this.btnApriFiglia2_Click_1);
            // 
            // btnFinestreAperte
            // 
            this.btnFinestreAperte.Location = new System.Drawing.Point(333, 74);
            this.btnFinestreAperte.Name = "btnFinestreAperte";
            this.btnFinestreAperte.Size = new System.Drawing.Size(147, 59);
            this.btnFinestreAperte.TabIndex = 3;
            this.btnFinestreAperte.Text = "Finestre Aperte";
            this.btnFinestreAperte.UseVisualStyleBackColor = true;
            this.btnFinestreAperte.Click += new System.EventHandler(this.btnFinestreAperte_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menùToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menùToolStripMenuItem
            // 
            this.menùToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apri1ToolStripMenuItem,
            this.apri2ToolStripMenuItem,
            this.esciToolStripMenuItem});
            this.menùToolStripMenuItem.Name = "menùToolStripMenuItem";
            this.menùToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menùToolStripMenuItem.Text = "&Menù";
            // 
            // apri1ToolStripMenuItem
            // 
            this.apri1ToolStripMenuItem.Name = "apri1ToolStripMenuItem";
            this.apri1ToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.apri1ToolStripMenuItem.Text = "Apri &1";
            this.apri1ToolStripMenuItem.Click += new System.EventHandler(this.apri1ToolStripMenuItem_Click);
            // 
            // apri2ToolStripMenuItem
            // 
            this.apri2ToolStripMenuItem.Name = "apri2ToolStripMenuItem";
            this.apri2ToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.apri2ToolStripMenuItem.Text = "Apri &2";
            this.apri2ToolStripMenuItem.Click += new System.EventHandler(this.apri2ToolStripMenuItem_Click);
            // 
            // esciToolStripMenuItem
            // 
            this.esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            this.esciToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.esciToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.esciToolStripMenuItem.Text = "&Esci";
            this.esciToolStripMenuItem.Click += new System.EventHandler(this.esciToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.infoToolStripMenuItem.Text = "In&fo";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem2.Text = "?";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 26);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(83, 20);
            this.toolStripStatusLabel1.Text = "Benvenuto!";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnFinestreAperte);
            this.Controls.Add(this.btnApriFiglia2);
            this.Controls.Add(this.btnApriFiglia1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApriFiglia1;
        private System.Windows.Forms.Button btnApriFiglia2;
        private System.Windows.Forms.Button btnFinestreAperte;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menùToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apri1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apri2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

