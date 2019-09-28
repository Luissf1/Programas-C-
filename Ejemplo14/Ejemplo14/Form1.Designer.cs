namespace Ejemplo14
{
    partial class FRMEJEMPLO
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
            this.LBLNUM = new System.Windows.Forms.Label();
            this.TXTNOMBRES = new System.Windows.Forms.TextBox();
            this.CMDCAPTURA = new System.Windows.Forms.Button();
            this.CMDOTRO = new System.Windows.Forms.Button();
            this.CMDSALIDA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLNUM
            // 
            this.LBLNUM.AutoSize = true;
            this.LBLNUM.Location = new System.Drawing.Point(34, 24);
            this.LBLNUM.Name = "LBLNUM";
            this.LBLNUM.Size = new System.Drawing.Size(105, 13);
            this.LBLNUM.TabIndex = 0;
            this.LBLNUM.Text = "Nombres capturados";
            // 
            // TXTNOMBRES
            // 
            this.TXTNOMBRES.Location = new System.Drawing.Point(39, 71);
            this.TXTNOMBRES.Multiline = true;
            this.TXTNOMBRES.Name = "TXTNOMBRES";
            this.TXTNOMBRES.ReadOnly = true;
            this.TXTNOMBRES.Size = new System.Drawing.Size(100, 124);
            this.TXTNOMBRES.TabIndex = 1;
            this.TXTNOMBRES.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CMDCAPTURA
            // 
            this.CMDCAPTURA.Location = new System.Drawing.Point(223, 44);
            this.CMDCAPTURA.Name = "CMDCAPTURA";
            this.CMDCAPTURA.Size = new System.Drawing.Size(75, 37);
            this.CMDCAPTURA.TabIndex = 2;
            this.CMDCAPTURA.Text = "&Inicio Captura";
            this.CMDCAPTURA.UseVisualStyleBackColor = true;
            this.CMDCAPTURA.Click += new System.EventHandler(this.CMDCAPTURA_Click);
            // 
            // CMDOTRO
            // 
            this.CMDOTRO.Location = new System.Drawing.Point(223, 105);
            this.CMDOTRO.Name = "CMDOTRO";
            this.CMDOTRO.Size = new System.Drawing.Size(75, 37);
            this.CMDOTRO.TabIndex = 3;
            this.CMDOTRO.Text = "&Clear";
            this.CMDOTRO.UseVisualStyleBackColor = true;
            this.CMDOTRO.Click += new System.EventHandler(this.CMDOTRO_Click);
            // 
            // CMDSALIDA
            // 
            this.CMDSALIDA.Location = new System.Drawing.Point(223, 158);
            this.CMDSALIDA.Name = "CMDSALIDA";
            this.CMDSALIDA.Size = new System.Drawing.Size(75, 37);
            this.CMDSALIDA.TabIndex = 4;
            this.CMDSALIDA.Text = "&Salida";
            this.CMDSALIDA.UseVisualStyleBackColor = true;
            this.CMDSALIDA.Click += new System.EventHandler(this.CMDSALIDA_Click);
            // 
            // FRMEJEMPLO
            // 
            this.AcceptButton = this.CMDCAPTURA;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 237);
            this.Controls.Add(this.CMDSALIDA);
            this.Controls.Add(this.CMDOTRO);
            this.Controls.Add(this.CMDCAPTURA);
            this.Controls.Add(this.TXTNOMBRES);
            this.Controls.Add(this.LBLNUM);
            this.Name = "FRMEJEMPLO";
            this.Text = "Ejemplo 14";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLNUM;
        private System.Windows.Forms.TextBox TXTNOMBRES;
        private System.Windows.Forms.Button CMDCAPTURA;
        private System.Windows.Forms.Button CMDOTRO;
        private System.Windows.Forms.Button CMDSALIDA;
    }
}

