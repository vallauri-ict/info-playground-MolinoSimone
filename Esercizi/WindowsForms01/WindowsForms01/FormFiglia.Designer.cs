
namespace WindowsForms01
{
    partial class FormFiglia
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
            this.btnDiChiSonoFiglia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDiChiSonoFiglia
            // 
            this.btnDiChiSonoFiglia.Location = new System.Drawing.Point(13, 13);
            this.btnDiChiSonoFiglia.Name = "btnDiChiSonoFiglia";
            this.btnDiChiSonoFiglia.Size = new System.Drawing.Size(210, 68);
            this.btnDiChiSonoFiglia.TabIndex = 0;
            this.btnDiChiSonoFiglia.Text = "Di Chi Sono Figlia?";
            this.btnDiChiSonoFiglia.UseVisualStyleBackColor = true;
            this.btnDiChiSonoFiglia.Click += new System.EventHandler(this.btnDiChiSonoFiglia_Click);
            // 
            // FormFiglia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDiChiSonoFiglia);
            this.Name = "FormFiglia";
            this.Text = "FormFiglia";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDiChiSonoFiglia;
    }
}