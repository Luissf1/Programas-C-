namespace Tarea5
{
    partial class FRMIVA
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
            this.LBLIVA = new System.Windows.Forms.Label();
            this.LBLTOTAL = new System.Windows.Forms.Label();
            this.TXTPRECIO = new System.Windows.Forms.TextBox();
            this.TEXTIVA = new System.Windows.Forms.TextBox();
            this.TEXTTOTAL = new System.Windows.Forms.TextBox();
            this.CMDIVA = new System.Windows.Forms.Button();
            this.CMDTOTAL = new System.Windows.Forms.Button();
            this.CMDSALIDA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLPRECIO
            // 
            this.LBLPRECIO.AutoSize = true;
            this.LBLPRECIO.Location = new System.Drawing.Point(132, 77);
            this.LBLPRECIO.Name = "LBLPRECIO";
            this.LBLPRECIO.Size = new System.Drawing.Size(37, 13);
            this.LBLPRECIO.TabIndex = 0;
            this.LBLPRECIO.Text = "Precio";
            // 
            // LBLIVA
            // 
            this.LBLIVA.AutoSize = true;
            this.LBLIVA.Location = new System.Drawing.Point(321, 77);
            this.LBLIVA.Name = "LBLIVA";
            this.LBLIVA.Size = new System.Drawing.Size(22, 13);
            this.LBLIVA.TabIndex = 2;
            this.LBLIVA.Text = "Iva";
            // 
            // LBLTOTAL
            // 
            this.LBLTOTAL.AutoSize = true;
            this.LBLTOTAL.Location = new System.Drawing.Point(515, 77);
            this.LBLTOTAL.Name = "LBLTOTAL";
            this.LBLTOTAL.Size = new System.Drawing.Size(31, 13);
            this.LBLTOTAL.TabIndex = 4;
            this.LBLTOTAL.Text = "Total";
            // 
            // TXTPRECIO
            // 
            this.TXTPRECIO.Location = new System.Drawing.Point(105, 148);
            this.TXTPRECIO.Name = "TXTPRECIO";
            this.TXTPRECIO.Size = new System.Drawing.Size(100, 20);
            this.TXTPRECIO.TabIndex = 1;
            // 
            // TEXTIVA
            // 
            this.TEXTIVA.Location = new System.Drawing.Point(305, 148);
            this.TEXTIVA.Name = "TEXTIVA";
            this.TEXTIVA.ReadOnly = true;
            this.TEXTIVA.Size = new System.Drawing.Size(100, 20);
            this.TEXTIVA.TabIndex = 3;
            // 
            // TEXTTOTAL
            // 
            this.TEXTTOTAL.Location = new System.Drawing.Point(493, 148);
            this.TEXTTOTAL.Name = "TEXTTOTAL";
            this.TEXTTOTAL.ReadOnly = true;
            this.TEXTTOTAL.Size = new System.Drawing.Size(100, 20);
            this.TEXTTOTAL.TabIndex = 5;
            // 
            // CMDIVA
            // 
            this.CMDIVA.Location = new System.Drawing.Point(105, 266);
            this.CMDIVA.Name = "CMDIVA";
            this.CMDIVA.Size = new System.Drawing.Size(75, 23);
            this.CMDIVA.TabIndex = 6;
            this.CMDIVA.Text = "&Iva";
            this.CMDIVA.UseVisualStyleBackColor = true;
            this.CMDIVA.Click += new System.EventHandler(this.CMDIVA_Click);
            // 
            // CMDTOTAL
            // 
            this.CMDTOTAL.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDTOTAL.Location = new System.Drawing.Point(305, 266);
            this.CMDTOTAL.Name = "CMDTOTAL";
            this.CMDTOTAL.Size = new System.Drawing.Size(75, 23);
            this.CMDTOTAL.TabIndex = 7;
            this.CMDTOTAL.Text = "&Total";
            this.CMDTOTAL.UseVisualStyleBackColor = true;
            this.CMDTOTAL.Click += new System.EventHandler(this.CMDTOTAL_Click);
            // 
            // CMDSALIDA
            // 
            this.CMDSALIDA.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDSALIDA.Location = new System.Drawing.Point(518, 266);
            this.CMDSALIDA.Name = "CMDSALIDA";
            this.CMDSALIDA.Size = new System.Drawing.Size(75, 23);
            this.CMDSALIDA.TabIndex = 8;
            this.CMDSALIDA.Text = "&Salida";
            this.CMDSALIDA.UseVisualStyleBackColor = true;
            this.CMDSALIDA.Click += new System.EventHandler(this.CMDSALIDA_Click);
            // 
            // FRMIVA
            // 
            this.AcceptButton = this.CMDTOTAL;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDSALIDA;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CMDSALIDA);
            this.Controls.Add(this.CMDTOTAL);
            this.Controls.Add(this.CMDIVA);
            this.Controls.Add(this.TEXTTOTAL);
            this.Controls.Add(this.TEXTIVA);
            this.Controls.Add(this.TXTPRECIO);
            this.Controls.Add(this.LBLTOTAL);
            this.Controls.Add(this.LBLIVA);
            this.Controls.Add(this.LBLPRECIO);
            this.Name = "FRMIVA";
            this.Text = "Calcular iva";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLPRECIO;
        private System.Windows.Forms.Label LBLIVA;
        private System.Windows.Forms.Label LBLTOTAL;
        private System.Windows.Forms.TextBox TXTPRECIO;
        private System.Windows.Forms.TextBox TEXTIVA;
        private System.Windows.Forms.TextBox TEXTTOTAL;
        private System.Windows.Forms.Button CMDIVA;
        private System.Windows.Forms.Button CMDTOTAL;
        private System.Windows.Forms.Button CMDSALIDA;
    }
}

