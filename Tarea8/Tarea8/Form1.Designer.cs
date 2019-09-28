namespace Tarea8
{
    partial class FRMCON
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
            this.LBLLIBRAS = new System.Windows.Forms.Label();
            this.LBLKILO = new System.Windows.Forms.Label();
            this.TXTLB = new System.Windows.Forms.TextBox();
            this.TXTKILO = new System.Windows.Forms.TextBox();
            this.CMDKILOGRAM = new System.Windows.Forms.Button();
            this.CMDSALIDA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLLIBRAS
            // 
            this.LBLLIBRAS.AutoSize = true;
            this.LBLLIBRAS.Location = new System.Drawing.Point(170, 62);
            this.LBLLIBRAS.Name = "LBLLIBRAS";
            this.LBLLIBRAS.Size = new System.Drawing.Size(35, 13);
            this.LBLLIBRAS.TabIndex = 0;
            this.LBLLIBRAS.Text = "Libras";
            // 
            // LBLKILO
            // 
            this.LBLKILO.AutoSize = true;
            this.LBLKILO.Location = new System.Drawing.Point(356, 62);
            this.LBLKILO.Name = "LBLKILO";
            this.LBLKILO.Size = new System.Drawing.Size(58, 13);
            this.LBLKILO.TabIndex = 2;
            this.LBLKILO.Text = "Kilogramas";
            // 
            // TXTLB
            // 
            this.TXTLB.Location = new System.Drawing.Point(141, 113);
            this.TXTLB.Name = "TXTLB";
            this.TXTLB.Size = new System.Drawing.Size(100, 20);
            this.TXTLB.TabIndex = 1;
            // 
            // TXTKILO
            // 
            this.TXTKILO.Location = new System.Drawing.Point(330, 113);
            this.TXTKILO.Name = "TXTKILO";
            this.TXTKILO.ReadOnly = true;
            this.TXTKILO.Size = new System.Drawing.Size(100, 20);
            this.TXTKILO.TabIndex = 3;
            // 
            // CMDKILOGRAM
            // 
            this.CMDKILOGRAM.Location = new System.Drawing.Point(157, 247);
            this.CMDKILOGRAM.Name = "CMDKILOGRAM";
            this.CMDKILOGRAM.Size = new System.Drawing.Size(75, 23);
            this.CMDKILOGRAM.TabIndex = 4;
            this.CMDKILOGRAM.Text = "&Conversion";
            this.CMDKILOGRAM.UseVisualStyleBackColor = true;
            this.CMDKILOGRAM.Click += new System.EventHandler(this.CMDKILOGRAM_Click);
            // 
            // CMDSALIDA
            // 
            this.CMDSALIDA.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDSALIDA.Location = new System.Drawing.Point(359, 247);
            this.CMDSALIDA.Name = "CMDSALIDA";
            this.CMDSALIDA.Size = new System.Drawing.Size(75, 23);
            this.CMDSALIDA.TabIndex = 5;
            this.CMDSALIDA.Text = "&Salida";
            this.CMDSALIDA.UseVisualStyleBackColor = true;
            this.CMDSALIDA.Click += new System.EventHandler(this.CMDSALIDA_Click);
            // 
            // FRMCON
            // 
            this.AcceptButton = this.CMDKILOGRAM;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDSALIDA;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CMDSALIDA);
            this.Controls.Add(this.CMDKILOGRAM);
            this.Controls.Add(this.TXTKILO);
            this.Controls.Add(this.TXTLB);
            this.Controls.Add(this.LBLKILO);
            this.Controls.Add(this.LBLLIBRAS);
            this.Name = "FRMCON";
            this.Text = "Libras a kilos";
            this.Load += new System.EventHandler(this.FRMCONVERSION_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLLIBRAS;
        private System.Windows.Forms.Label LBLKILO;
        private System.Windows.Forms.TextBox TXTLB;
        private System.Windows.Forms.TextBox TXTKILO;
        private System.Windows.Forms.Button CMDKILOGRAM;
        private System.Windows.Forms.Button CMDSALIDA;
    }
}

