namespace Ejemplo11
{
    partial class FRMEJEMPLO11
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
            this.LBLCEN = new System.Windows.Forms.Label();
            this.LBLCON = new System.Windows.Forms.Label();
            this.TXTCON = new System.Windows.Forms.TextBox();
            this.CMDSALIDA = new System.Windows.Forms.Button();
            this.CMDPROCESAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLCEN
            // 
            this.LBLCEN.AutoSize = true;
            this.LBLCEN.Location = new System.Drawing.Point(85, 18);
            this.LBLCEN.Name = "LBLCEN";
            this.LBLCEN.Size = new System.Drawing.Size(118, 13);
            this.LBLCEN.TabIndex = 0;
            this.LBLCEN.Text = "Pulgadas a Centimetros";
            // 
            // LBLCON
            // 
            this.LBLCON.AutoSize = true;
            this.LBLCON.Location = new System.Drawing.Point(46, 65);
            this.LBLCON.Name = "LBLCON";
            this.LBLCON.Size = new System.Drawing.Size(87, 13);
            this.LBLCON.TabIndex = 1;
            this.LBLCON.Text = "&Valor a convertir:";
            // 
            // TXTCON
            // 
            this.TXTCON.Location = new System.Drawing.Point(190, 62);
            this.TXTCON.Name = "TXTCON";
            this.TXTCON.Size = new System.Drawing.Size(100, 20);
            this.TXTCON.TabIndex = 2;
            // 
            // CMDSALIDA
            // 
            this.CMDSALIDA.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDSALIDA.Location = new System.Drawing.Point(60, 103);
            this.CMDSALIDA.Name = "CMDSALIDA";
            this.CMDSALIDA.Size = new System.Drawing.Size(75, 23);
            this.CMDSALIDA.TabIndex = 3;
            this.CMDSALIDA.Text = "&Salida";
            this.CMDSALIDA.UseVisualStyleBackColor = true;
            this.CMDSALIDA.Click += new System.EventHandler(this.CMDSALIDA_Click);
            // 
            // CMDPROCESAR
            // 
            this.CMDPROCESAR.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDPROCESAR.Location = new System.Drawing.Point(175, 103);
            this.CMDPROCESAR.Name = "CMDPROCESAR";
            this.CMDPROCESAR.Size = new System.Drawing.Size(75, 23);
            this.CMDPROCESAR.TabIndex = 4;
            this.CMDPROCESAR.Text = "&Procesar";
            this.CMDPROCESAR.UseVisualStyleBackColor = true;
            this.CMDPROCESAR.Click += new System.EventHandler(this.CMDPROCESAR_Click);
            // 
            // FRMEJEMPLO11
            // 
            this.AcceptButton = this.CMDPROCESAR;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDSALIDA;
            this.ClientSize = new System.Drawing.Size(334, 147);
            this.Controls.Add(this.CMDPROCESAR);
            this.Controls.Add(this.CMDSALIDA);
            this.Controls.Add(this.TXTCON);
            this.Controls.Add(this.LBLCON);
            this.Controls.Add(this.LBLCEN);
            this.Name = "FRMEJEMPLO11";
            this.Text = "Ejemplo 11";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLCEN;
        private System.Windows.Forms.Label LBLCON;
        private System.Windows.Forms.TextBox TXTCON;
        private System.Windows.Forms.Button CMDSALIDA;
        private System.Windows.Forms.Button CMDPROCESAR;
    }
}

