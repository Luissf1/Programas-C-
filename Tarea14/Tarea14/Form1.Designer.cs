namespace Tarea14
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
            this.LBLPRECIO = new System.Windows.Forms.Label();
            this.TXTPRECIO = new System.Windows.Forms.TextBox();
            this.LBLTOTAL = new System.Windows.Forms.Label();
            this.TXTTOTAL = new System.Windows.Forms.TextBox();
            this.CMDTOTAL = new System.Windows.Forms.Button();
            this.CMDSALIDA = new System.Windows.Forms.Button();
            this.CMDOTRO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLPRECIO
            // 
            this.LBLPRECIO.AutoSize = true;
            this.LBLPRECIO.Location = new System.Drawing.Point(26, 52);
            this.LBLPRECIO.Name = "LBLPRECIO";
            this.LBLPRECIO.Size = new System.Drawing.Size(93, 13);
            this.LBLPRECIO.TabIndex = 0;
            this.LBLPRECIO.Text = "Precio de fabrica :";
            // 
            // TXTPRECIO
            // 
            this.TXTPRECIO.Location = new System.Drawing.Point(151, 49);
            this.TXTPRECIO.Name = "TXTPRECIO";
            this.TXTPRECIO.Size = new System.Drawing.Size(100, 20);
            this.TXTPRECIO.TabIndex = 1;
            // 
            // LBLTOTAL
            // 
            this.LBLTOTAL.AutoSize = true;
            this.LBLTOTAL.Location = new System.Drawing.Point(26, 104);
            this.LBLTOTAL.Name = "LBLTOTAL";
            this.LBLTOTAL.Size = new System.Drawing.Size(59, 13);
            this.LBLTOTAL.TabIndex = 2;
            this.LBLTOTAL.Text = "El total es :";
            // 
            // TXTTOTAL
            // 
            this.TXTTOTAL.Location = new System.Drawing.Point(151, 101);
            this.TXTTOTAL.Name = "TXTTOTAL";
            this.TXTTOTAL.ReadOnly = true;
            this.TXTTOTAL.Size = new System.Drawing.Size(100, 20);
            this.TXTTOTAL.TabIndex = 3;
            // 
            // CMDTOTAL
            // 
            this.CMDTOTAL.Location = new System.Drawing.Point(313, 42);
            this.CMDTOTAL.Name = "CMDTOTAL";
            this.CMDTOTAL.Size = new System.Drawing.Size(76, 42);
            this.CMDTOTAL.TabIndex = 4;
            this.CMDTOTAL.Text = "&Total";
            this.CMDTOTAL.UseVisualStyleBackColor = true;
            this.CMDTOTAL.Click += new System.EventHandler(this.CMDTOTAL_Click);
            // 
            // CMDSALIDA
            // 
            this.CMDSALIDA.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDSALIDA.Location = new System.Drawing.Point(313, 104);
            this.CMDSALIDA.Name = "CMDSALIDA";
            this.CMDSALIDA.Size = new System.Drawing.Size(76, 42);
            this.CMDSALIDA.TabIndex = 5;
            this.CMDSALIDA.Text = "&Salida";
            this.CMDSALIDA.UseVisualStyleBackColor = true;
            this.CMDSALIDA.Click += new System.EventHandler(this.CMDSALIDA_Click);
            // 
            // CMDOTRO
            // 
            this.CMDOTRO.Location = new System.Drawing.Point(160, 163);
            this.CMDOTRO.Name = "CMDOTRO";
            this.CMDOTRO.Size = new System.Drawing.Size(75, 23);
            this.CMDOTRO.TabIndex = 6;
            this.CMDOTRO.Text = "&Clear";
            this.CMDOTRO.UseVisualStyleBackColor = true;
            this.CMDOTRO.Click += new System.EventHandler(this.CMDOTRO_Click);
            // 
            // FRMFACTURA
            // 
            this.AcceptButton = this.CMDTOTAL;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDSALIDA;
            this.ClientSize = new System.Drawing.Size(463, 198);
            this.Controls.Add(this.CMDOTRO);
            this.Controls.Add(this.CMDSALIDA);
            this.Controls.Add(this.CMDTOTAL);
            this.Controls.Add(this.TXTTOTAL);
            this.Controls.Add(this.LBLTOTAL);
            this.Controls.Add(this.TXTPRECIO);
            this.Controls.Add(this.LBLPRECIO);
            this.Name = "FRMFACTURA";
            this.Text = "Factura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLPRECIO;
        private System.Windows.Forms.TextBox TXTPRECIO;
        private System.Windows.Forms.Label LBLTOTAL;
        private System.Windows.Forms.TextBox TXTTOTAL;
        private System.Windows.Forms.Button CMDTOTAL;
        private System.Windows.Forms.Button CMDSALIDA;
        private System.Windows.Forms.Button CMDOTRO;
    }
}

