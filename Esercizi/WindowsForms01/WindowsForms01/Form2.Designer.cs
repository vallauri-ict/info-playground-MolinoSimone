﻿
namespace WindowsForms01
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnF2Leggi = new System.Windows.Forms.Button();
            this.txtF2 = new System.Windows.Forms.TextBox();
            this.btnInviaAForm1 = new System.Windows.Forms.Button();
            this.btnF2ApriFiglia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "SONO LA FORM 2";
            // 
            // btnF2Leggi
            // 
            this.btnF2Leggi.Location = new System.Drawing.Point(15, 68);
            this.btnF2Leggi.Name = "btnF2Leggi";
            this.btnF2Leggi.Size = new System.Drawing.Size(263, 23);
            this.btnF2Leggi.TabIndex = 1;
            this.btnF2Leggi.Text = "Leggi valore TXT";
            this.btnF2Leggi.UseVisualStyleBackColor = true;
            this.btnF2Leggi.Click += new System.EventHandler(this.btnF2Leggi_Click);
            // 
            // txtF2
            // 
            this.txtF2.Location = new System.Drawing.Point(15, 108);
            this.txtF2.Name = "txtF2";
            this.txtF2.Size = new System.Drawing.Size(139, 22);
            this.txtF2.TabIndex = 2;
            // 
            // btnInviaAForm1
            // 
            this.btnInviaAForm1.Location = new System.Drawing.Point(160, 108);
            this.btnInviaAForm1.Name = "btnInviaAForm1";
            this.btnInviaAForm1.Size = new System.Drawing.Size(118, 23);
            this.btnInviaAForm1.TabIndex = 3;
            this.btnInviaAForm1.Text = "Invia a Form1";
            this.btnInviaAForm1.UseVisualStyleBackColor = true;
            this.btnInviaAForm1.Click += new System.EventHandler(this.btnInviaAForm1_Click);
            // 
            // btnF2ApriFiglia
            // 
            this.btnF2ApriFiglia.Location = new System.Drawing.Point(15, 161);
            this.btnF2ApriFiglia.Name = "btnF2ApriFiglia";
            this.btnF2ApriFiglia.Size = new System.Drawing.Size(155, 28);
            this.btnF2ApriFiglia.TabIndex = 4;
            this.btnF2ApriFiglia.Text = "Apri From figlia";
            this.btnF2ApriFiglia.UseVisualStyleBackColor = true;
            this.btnF2ApriFiglia.Click += new System.EventHandler(this.btnF2ApriFiglia_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnF2ApriFiglia);
            this.Controls.Add(this.btnInviaAForm1);
            this.Controls.Add(this.txtF2);
            this.Controls.Add(this.btnF2Leggi);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnF2Leggi;
        private System.Windows.Forms.TextBox txtF2;
        private System.Windows.Forms.Button btnInviaAForm1;
        private System.Windows.Forms.Button btnF2ApriFiglia;
    }
}