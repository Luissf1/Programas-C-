namespace Tarea12
{
    partial class FRMFACTURA
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
            this.LBLDES = new System.Windows.Forms.Label();
            this.TXTDES = new System.Windows.Forms.TextBox();
            this.LBLPRECIO = new System.Windows.Forms.Label();
            this.TXTPRE = new System.Windows.Forms.TextBox();
            this.LBLDESC = new System.Windows.Forms.Label();
            this.TXTDESC = new System.Windows.Forms.TextBox();
            this.LBLSUB = new System.Windows.Forms.Label();
            this.TXTSUB = new System.Windows.Forms.TextBox();
            this.LBLIVA = new System.Windows.Forms.Label();
            this.TXTIVA = new System.Windows.Forms.TextBox();
            this.TBLTOTAL = new System.Windows.Forms.Label();
            this.TXTTOTAL = new System.Windows.Forms.TextBox();
            this.CMDFACUTRA = new System.Windows.Forms.Button();
            this.CMDSALIDA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLDES
            // 
            this.LBLDES.AutoSize = true;
            this.LBLDES.Location = new System.Drawing.Point(67, 54);
            this.LBLDES.Name = "LBLDES";
            this.LBLDES.Size = new System.Drawing.Size(113, 13);
            this.LBLDES.TabIndex = 0;
            this.LBLDES.Text = "Ingrese descripciones:";
            // 
            // TXTDES
            // 
            this.TXTDES.Location = new System.Drawing.Point(206, 54);
            this.TXTDES.Name = "TXTDES";
            this.TXTDES.Size = new System.Drawing.Size(100, 20);
            this.TXTDES.TabIndex = 1;
            // 
            // LBLPRECIO
            // 
            this.LBLPRECIO.AutoSize = true;
            this.LBLPRECIO.Location = new System.Drawing.Point(37, 126);
            this.LBLPRECIO.Name = "LBLPRECIO";
            this.LBLPRECIO.Size = new System.Drawing.Size(147, 13);
            this.LBLPRECIO.TabIndex = 2;
            this.LBLPRECIO.Text = "Introducir el precio de fabrica:";
            // 
            // TXTPRE
            // 
            this.TXTPRE.Location = new System.Drawing.Point(206, 123);
            this.TXTPRE.Name = "TXTPRE";
            this.TXTPRE.Size = new System.Drawing.Size(100, 20);
            this.TXTPRE.TabIndex = 3;
            // 
            // LBLDESC
            // 
            this.LBLDESC.AutoSize = true;
            this.LBLDESC.Location = new System.Drawing.Point(67, 199);
            this.LBLDESC.Name = "LBLDESC";
            this.LBLDESC.Size = new System.Drawing.Size(115, 13);
            this.LBLDESC.TabIndex = 4;
            this.LBLDESC.Text = "Las descripciones son:";
            // 
            // TXTDESC
            // 
            this.TXTDESC.Location = new System.Drawing.Point(206, 192);
            this.TXTDESC.Name = "TXTDESC";
            this.TXTDESC.ReadOnly = true;
            this.TXTDESC.Size = new System.Drawing.Size(100, 20);
            this.TXTDESC.TabIndex = 5;
            // 
            // LBLSUB
            // 
            this.LBLSUB.AutoSize = true;
            this.LBLSUB.Location = new System.Drawing.Point(67, 265);
            this.LBLSUB.Name = "LBLSUB";
            this.LBLSUB.Size = new System.Drawing.Size(73, 13);
            this.LBLSUB.TabIndex = 6;
            this.LBLSUB.Text = "El subtotal es:";
            // 
            // TXTSUB
            // 
            this.TXTSUB.Location = new System.Drawing.Point(206, 265);
            this.TXTSUB.Name = "TXTSUB";
            this.TXTSUB.ReadOnly = true;
            this.TXTSUB.Size = new System.Drawing.Size(100, 20);
            this.TXTSUB.TabIndex = 7;
            // 
            // LBLIVA
            // 
            this.LBLIVA.AutoSize = true;
            this.LBLIVA.Location = new System.Drawing.Point(67, 330);
            this.LBLIVA.Name = "LBLIVA";
            this.LBLIVA.Size = new System.Drawing.Size(50, 13);
            this.LBLIVA.TabIndex = 8;
            this.LBLIVA.Text = "El iva es:";
            // 
            // TXTIVA
            // 
            this.TXTIVA.Location = new System.Drawing.Point(206, 323);
            this.TXTIVA.Name = "TXTIVA";
            this.TXTIVA.ReadOnly = true;
            this.TXTIVA.Size = new System.Drawing.Size(100, 20);
            this.TXTIVA.TabIndex = 9;
            // 
            // TBLTOTAL
            // 
            this.TBLTOTAL.AutoSize = true;
            this.TBLTOTAL.Location = new System.Drawing.Point(67, 399);
            this.TBLTOTAL.Name = "TBLTOTAL";
            this.TBLTOTAL.Size = new System.Drawing.Size(59, 13);
            this.TBLTOTAL.TabIndex = 10;
            this.TBLTOTAL.Text = "El total es :";
            // 
            // TXTTOTAL
            // 
            this.TXTTOTAL.Location = new System.Drawing.Point(206, 396);
            this.TXTTOTAL.Name = "TXTTOTAL";
            this.TXTTOTAL.ReadOnly = true;
            this.TXTTOTAL.Size = new System.Drawing.Size(100, 20);
            this.TXTTOTAL.TabIndex = 11;
            // 
            // CMDFACUTRA
            // 
            this.CMDFACUTRA.Location = new System.Drawing.Point(495, 123);
            this.CMDFACUTRA.Name = "CMDFACUTRA";
            this.CMDFACUTRA.Size = new System.Drawing.Size(115, 85);
            this.CMDFACUTRA.TabIndex = 12;
            this.CMDFACUTRA.Text = "&Factura";
            this.CMDFACUTRA.UseVisualStyleBackColor = true;
            this.CMDFACUTRA.Click += new System.EventHandler(this.CMDFACUTRA_Click);
            // 
            // CMDSALIDA
            // 
            this.CMDSALIDA.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDSALIDA.Location = new System.Drawing.Point(495, 265);
            this.CMDSALIDA.Name = "CMDSALIDA";
            this.CMDSALIDA.Size = new System.Drawing.Size(115, 78);
            this.CMDSALIDA.TabIndex = 13;
            this.CMDSALIDA.Text = "&Salida";
            this.CMDSALIDA.UseVisualStyleBackColor = true;
            this.CMDSALIDA.Click += new System.EventHandler(this.CMDSALIDA_Click);
            // 
            // FRMFACTURA
            // 
            this.AcceptButton = this.CMDFACUTRA;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDSALIDA;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CMDSALIDA);
            this.Controls.Add(this.CMDFACUTRA);
            this.Controls.Add(this.TXTTOTAL);
            this.Controls.Add(this.TBLTOTAL);
            this.Controls.Add(this.TXTIVA);
            this.Controls.Add(this.LBLIVA);
            this.Controls.Add(this.TXTSUB);
            this.Controls.Add(this.LBLSUB);
            this.Controls.Add(this.TXTDESC);
            this.Controls.Add(this.LBLDESC);
            this.Controls.Add(this.TXTPRE);
            this.Controls.Add(this.LBLPRECIO);
            this.Controls.Add(this.TXTDES);
            this.Controls.Add(this.LBLDES);
            this.Name = "FRMFACTURA";
            this.Text = "Factura de automovil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLDES;
        private System.Windows.Forms.TextBox TXTDES;
        private System.Windows.Forms.Label LBLPRECIO;
        private System.Windows.Forms.TextBox TXTPRE;
        private System.Windows.Forms.Label LBLDESC;
        private System.Windows.Forms.TextBox TXTDESC;
        private System.Windows.Forms.Label LBLSUB;
        private System.Windows.Forms.TextBox TXTSUB;
        private System.Windows.Forms.Label LBLIVA;
        private System.Windows.Forms.TextBox TXTIVA;
        private System.Windows.Forms.Label TBLTOTAL;
        private System.Windows.Forms.TextBox TXTTOTAL;
        private System.Windows.Forms.Button CMDFACUTRA;
        private System.Windows.Forms.Button CMDSALIDA;
    }
}

