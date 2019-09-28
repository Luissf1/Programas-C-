namespace Tarea28
{
    partial class FRMPAR
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
            this.TXTPAR = new System.Windows.Forms.TextBox();
            this.CMDLISTA = new System.Windows.Forms.Button();
            this.CMDOTRO = new System.Windows.Forms.Button();
            this.CMDSALIDA = new System.Windows.Forms.Button();
            this.TXTSUMA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TXTPAR
            // 
            this.TXTPAR.Location = new System.Drawing.Point(30, 3);
            this.TXTPAR.Multiline = true;
            this.TXTPAR.Name = "TXTPAR";
            this.TXTPAR.ReadOnly = true;
            this.TXTPAR.Size = new System.Drawing.Size(125, 228);
            this.TXTPAR.TabIndex = 0;
            this.TXTPAR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CMDLISTA
            // 
            this.CMDLISTA.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDLISTA.Location = new System.Drawing.Point(285, 33);
            this.CMDLISTA.Name = "CMDLISTA";
            this.CMDLISTA.Size = new System.Drawing.Size(75, 23);
            this.CMDLISTA.TabIndex = 1;
            this.CMDLISTA.Text = "&Lista";
            this.CMDLISTA.UseVisualStyleBackColor = true;
            this.CMDLISTA.Click += new System.EventHandler(this.CMDLISTA_Click);
            // 
            // CMDOTRO
            // 
            this.CMDOTRO.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDOTRO.Location = new System.Drawing.Point(285, 88);
            this.CMDOTRO.Name = "CMDOTRO";
            this.CMDOTRO.Size = new System.Drawing.Size(75, 23);
            this.CMDOTRO.TabIndex = 2;
            this.CMDOTRO.Text = "&Clear";
            this.CMDOTRO.UseVisualStyleBackColor = true;
            this.CMDOTRO.Click += new System.EventHandler(this.CMDOTRO_Click);
            // 
            // CMDSALIDA
            // 
            this.CMDSALIDA.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDSALIDA.Location = new System.Drawing.Point(285, 153);
            this.CMDSALIDA.Name = "CMDSALIDA";
            this.CMDSALIDA.Size = new System.Drawing.Size(75, 23);
            this.CMDSALIDA.TabIndex = 3;
            this.CMDSALIDA.Text = "&Salida";
            this.CMDSALIDA.UseVisualStyleBackColor = true;
            this.CMDSALIDA.Click += new System.EventHandler(this.CMDSALIDA_Click);
            // 
            // TXTSUMA
            // 
            this.TXTSUMA.Location = new System.Drawing.Point(161, 211);
            this.TXTSUMA.Name = "TXTSUMA";
            this.TXTSUMA.ReadOnly = true;
            this.TXTSUMA.Size = new System.Drawing.Size(99, 20);
            this.TXTSUMA.TabIndex = 4;
            this.TXTSUMA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FRMPAR
            // 
            this.AcceptButton = this.CMDLISTA;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDSALIDA;
            this.ClientSize = new System.Drawing.Size(419, 243);
            this.Controls.Add(this.TXTSUMA);
            this.Controls.Add(this.CMDSALIDA);
            this.Controls.Add(this.CMDOTRO);
            this.Controls.Add(this.CMDLISTA);
            this.Controls.Add(this.TXTPAR);
            this.Name = "FRMPAR";
            this.Text = "Numeros par entre 200 y 300";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTPAR;
        private System.Windows.Forms.Button CMDLISTA;
        private System.Windows.Forms.Button CMDOTRO;
        private System.Windows.Forms.Button CMDSALIDA;
        private System.Windows.Forms.TextBox TXTSUMA;
    }
}

