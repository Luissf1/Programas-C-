namespace Tarea16
{
    partial class FRMVENTAS
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
            this.LBLPRECIO = new System.Windows.Forms.Label();
            this.TXTPRECIO = new System.Windows.Forms.TextBox();
            this.LBLTOTAL = new System.Windows.Forms.Label();
            this.TXTTOTAL = new System.Windows.Forms.TextBox();
            this.LBLTOTALA = new System.Windows.Forms.Label();
            this.TXTTOTALA = new System.Windows.Forms.TextBox();
            this.LBLMENSUALIDAD = new System.Windows.Forms.Label();
            this.TXTMENSUALIDAD = new System.Windows.Forms.TextBox();
            this.CMDTOTAL = new System.Windows.Forms.Button();
            this.CMDSALIDA = new System.Windows.Forms.Button();
            this.CMDOTRO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLPRECIO
            // 
            this.LBLPRECIO.AutoSize = true;
            this.LBLPRECIO.Location = new System.Drawing.Point(35, 50);
            this.LBLPRECIO.Name = "LBLPRECIO";
            this.LBLPRECIO.Size = new System.Drawing.Size(88, 13);
            this.LBLPRECIO.TabIndex = 0;
            this.LBLPRECIO.Text = "Ingrese el precio:";
            // 
            // TXTPRECIO
            // 
            this.TXTPRECIO.Location = new System.Drawing.Point(152, 50);
            this.TXTPRECIO.Name = "TXTPRECIO";
            this.TXTPRECIO.Size = new System.Drawing.Size(100, 20);
            this.TXTPRECIO.TabIndex = 1;
            // 
            // LBLTOTAL
            // 
            this.LBLTOTAL.AutoSize = true;
            this.LBLTOTAL.Location = new System.Drawing.Point(35, 121);
            this.LBLTOTAL.Name = "LBLTOTAL";
            this.LBLTOTAL.Size = new System.Drawing.Size(56, 13);
            this.LBLTOTAL.TabIndex = 2;
            this.LBLTOTAL.Text = "El total es:";
            // 
            // TXTTOTAL
            // 
            this.TXTTOTAL.Location = new System.Drawing.Point(152, 121);
            this.TXTTOTAL.Name = "TXTTOTAL";
            this.TXTTOTAL.ReadOnly = true;
            this.TXTTOTAL.Size = new System.Drawing.Size(100, 20);
            this.TXTTOTAL.TabIndex = 3;
            // 
            // LBLTOTALA
            // 
            this.LBLTOTALA.AutoSize = true;
            this.LBLTOTALA.Location = new System.Drawing.Point(35, 200);
            this.LBLTOTALA.Name = "LBLTOTALA";
            this.LBLTOTALA.Size = new System.Drawing.Size(97, 13);
            this.LBLTOTALA.TabIndex = 4;
            this.LBLTOTALA.Text = "EL total en abono :";
            // 
            // TXTTOTALA
            // 
            this.TXTTOTALA.Location = new System.Drawing.Point(152, 197);
            this.TXTTOTALA.Name = "TXTTOTALA";
            this.TXTTOTALA.ReadOnly = true;
            this.TXTTOTALA.Size = new System.Drawing.Size(100, 20);
            this.TXTTOTALA.TabIndex = 5;
            // 
            // LBLMENSUALIDAD
            // 
            this.LBLMENSUALIDAD.AutoSize = true;
            this.LBLMENSUALIDAD.Location = new System.Drawing.Point(34, 271);
            this.LBLMENSUALIDAD.Name = "LBLMENSUALIDAD";
            this.LBLMENSUALIDAD.Size = new System.Drawing.Size(98, 13);
            this.LBLMENSUALIDAD.TabIndex = 6;
            this.LBLMENSUALIDAD.Text = "La mensualidad es:";
            // 
            // TXTMENSUALIDAD
            // 
            this.TXTMENSUALIDAD.Location = new System.Drawing.Point(152, 268);
            this.TXTMENSUALIDAD.Name = "TXTMENSUALIDAD";
            this.TXTMENSUALIDAD.ReadOnly = true;
            this.TXTMENSUALIDAD.Size = new System.Drawing.Size(100, 20);
            this.TXTMENSUALIDAD.TabIndex = 7;
            // 
            // CMDTOTAL
            // 
            this.CMDTOTAL.Location = new System.Drawing.Point(329, 104);
            this.CMDTOTAL.Name = "CMDTOTAL";
            this.CMDTOTAL.Size = new System.Drawing.Size(80, 70);
            this.CMDTOTAL.TabIndex = 8;
            this.CMDTOTAL.Text = "&Total";
            this.CMDTOTAL.UseVisualStyleBackColor = true;
            this.CMDTOTAL.Click += new System.EventHandler(this.CMDTOTAL_Click);
            // 
            // CMDSALIDA
            // 
            this.CMDSALIDA.Location = new System.Drawing.Point(329, 218);
            this.CMDSALIDA.Name = "CMDSALIDA";
            this.CMDSALIDA.Size = new System.Drawing.Size(80, 70);
            this.CMDSALIDA.TabIndex = 9;
            this.CMDSALIDA.Text = "&Salida";
            this.CMDSALIDA.UseVisualStyleBackColor = true;
            this.CMDSALIDA.Click += new System.EventHandler(this.CMDSALIDA_Click);
            // 
            // CMDOTRO
            // 
            this.CMDOTRO.Location = new System.Drawing.Point(434, 191);
            this.CMDOTRO.Name = "CMDOTRO";
            this.CMDOTRO.Size = new System.Drawing.Size(75, 23);
            this.CMDOTRO.TabIndex = 10;
            this.CMDOTRO.Text = "&Clear";
            this.CMDOTRO.UseVisualStyleBackColor = true;
            this.CMDOTRO.Click += new System.EventHandler(this.CMDOTRO_Click);
            // 
            // FRMVENTAS
            // 
            this.AcceptButton = this.CMDTOTAL;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDSALIDA;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CMDOTRO);
            this.Controls.Add(this.CMDSALIDA);
            this.Controls.Add(this.CMDTOTAL);
            this.Controls.Add(this.TXTMENSUALIDAD);
            this.Controls.Add(this.LBLMENSUALIDAD);
            this.Controls.Add(this.TXTTOTALA);
            this.Controls.Add(this.LBLTOTALA);
            this.Controls.Add(this.TXTTOTAL);
            this.Controls.Add(this.LBLTOTAL);
            this.Controls.Add(this.TXTPRECIO);
            this.Controls.Add(this.LBLPRECIO);
            this.Name = "FRMVENTAS";
            this.Text = "Total de equipo de computo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLPRECIO;
        private System.Windows.Forms.TextBox TXTPRECIO;
        private System.Windows.Forms.Label LBLTOTAL;
        private System.Windows.Forms.TextBox TXTTOTAL;
        private System.Windows.Forms.Label LBLTOTALA;
        private System.Windows.Forms.TextBox TXTTOTALA;
        private System.Windows.Forms.Label LBLMENSUALIDAD;
        private System.Windows.Forms.TextBox TXTMENSUALIDAD;
        private System.Windows.Forms.Button CMDTOTAL;
        private System.Windows.Forms.Button CMDSALIDA;
        private System.Windows.Forms.Button CMDOTRO;
    }
}

