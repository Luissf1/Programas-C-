namespace Tarea6
{
    partial class FRMPESO
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
            this.LBLPESO = new System.Windows.Forms.Label();
            this.LBLTPC = new System.Windows.Forms.Label();
            this.LBLDOLAR = new System.Windows.Forms.Label();
            this.TXTPESOS = new System.Windows.Forms.TextBox();
            this.TXTTPC = new System.Windows.Forms.TextBox();
            this.TXTDOLAR = new System.Windows.Forms.TextBox();
            this.CMDDOLAR = new System.Windows.Forms.Button();
            this.CMDSALIDA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLPESO
            // 
            this.LBLPESO.AutoSize = true;
            this.LBLPESO.Location = new System.Drawing.Point(83, 94);
            this.LBLPESO.Name = "LBLPESO";
            this.LBLPESO.Size = new System.Drawing.Size(36, 13);
            this.LBLPESO.TabIndex = 0;
            this.LBLPESO.Text = "Pesos";
            // 
            // LBLTPC
            // 
            this.LBLTPC.AutoSize = true;
            this.LBLTPC.Location = new System.Drawing.Point(234, 94);
            this.LBLTPC.Name = "LBLTPC";
            this.LBLTPC.Size = new System.Drawing.Size(80, 13);
            this.LBLTPC.TabIndex = 2;
            this.LBLTPC.Text = "Tipo de cambio";
            // 
            // LBLDOLAR
            // 
            this.LBLDOLAR.AutoSize = true;
            this.LBLDOLAR.Location = new System.Drawing.Point(430, 94);
            this.LBLDOLAR.Name = "LBLDOLAR";
            this.LBLDOLAR.Size = new System.Drawing.Size(32, 13);
            this.LBLDOLAR.TabIndex = 4;
            this.LBLDOLAR.Text = "Dolar";
            // 
            // TXTPESOS
            // 
            this.TXTPESOS.Location = new System.Drawing.Point(62, 171);
            this.TXTPESOS.Name = "TXTPESOS";
            this.TXTPESOS.Size = new System.Drawing.Size(100, 20);
            this.TXTPESOS.TabIndex = 1;
            // 
            // TXTTPC
            // 
            this.TXTTPC.Location = new System.Drawing.Point(225, 171);
            this.TXTTPC.Name = "TXTTPC";
            this.TXTTPC.Size = new System.Drawing.Size(100, 20);
            this.TXTTPC.TabIndex = 3;
            // 
            // TXTDOLAR
            // 
            this.TXTDOLAR.Location = new System.Drawing.Point(405, 171);
            this.TXTDOLAR.Name = "TXTDOLAR";
            this.TXTDOLAR.ReadOnly = true;
            this.TXTDOLAR.Size = new System.Drawing.Size(100, 20);
            this.TXTDOLAR.TabIndex = 5;
            // 
            // CMDDOLAR
            // 
            this.CMDDOLAR.Location = new System.Drawing.Point(189, 292);
            this.CMDDOLAR.Name = "CMDDOLAR";
            this.CMDDOLAR.Size = new System.Drawing.Size(111, 34);
            this.CMDDOLAR.TabIndex = 6;
            this.CMDDOLAR.Text = "&Dolar";
            this.CMDDOLAR.UseVisualStyleBackColor = true;
            this.CMDDOLAR.Click += new System.EventHandler(this.CMDDOLAR_Click);
            // 
            // CMDSALIDA
            // 
            this.CMDSALIDA.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDSALIDA.Location = new System.Drawing.Point(367, 292);
            this.CMDSALIDA.Name = "CMDSALIDA";
            this.CMDSALIDA.Size = new System.Drawing.Size(122, 34);
            this.CMDSALIDA.TabIndex = 7;
            this.CMDSALIDA.Text = "&Salida";
            this.CMDSALIDA.UseVisualStyleBackColor = true;
            this.CMDSALIDA.Click += new System.EventHandler(this.CMDSALIDA_Click);
            // 
            // FRMPESO
            // 
            this.AcceptButton = this.CMDDOLAR;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDSALIDA;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CMDSALIDA);
            this.Controls.Add(this.CMDDOLAR);
            this.Controls.Add(this.TXTDOLAR);
            this.Controls.Add(this.TXTTPC);
            this.Controls.Add(this.TXTPESOS);
            this.Controls.Add(this.LBLDOLAR);
            this.Controls.Add(this.LBLTPC);
            this.Controls.Add(this.LBLPESO);
            this.Name = "FRMPESO";
            this.Text = "Peso a Dolar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLPESO;
        private System.Windows.Forms.Label LBLTPC;
        private System.Windows.Forms.Label LBLDOLAR;
        private System.Windows.Forms.TextBox TXTPESOS;
        private System.Windows.Forms.TextBox TXTTPC;
        private System.Windows.Forms.TextBox TXTDOLAR;
        private System.Windows.Forms.Button CMDDOLAR;
        private System.Windows.Forms.Button CMDSALIDA;
    }
}

