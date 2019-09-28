namespace Tarea9
{
    partial class FRMPESOS
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
            this.CMDSALIDA = new System.Windows.Forms.Button();
            this.CMDDOLAR = new System.Windows.Forms.Button();
            this.TXTDOLAR = new System.Windows.Forms.TextBox();
            this.TXTTPC = new System.Windows.Forms.TextBox();
            this.TXTPESOS = new System.Windows.Forms.TextBox();
            this.LBLDOLAR = new System.Windows.Forms.Label();
            this.LBLTPC = new System.Windows.Forms.Label();
            this.LBLPESO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CMDSALIDA
            // 
            this.CMDSALIDA.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDSALIDA.Location = new System.Drawing.Point(484, 307);
            this.CMDSALIDA.Name = "CMDSALIDA";
            this.CMDSALIDA.Size = new System.Drawing.Size(122, 34);
            this.CMDSALIDA.TabIndex = 7;
            this.CMDSALIDA.Text = "&Salida";
            this.CMDSALIDA.UseVisualStyleBackColor = true;
            this.CMDSALIDA.Click += new System.EventHandler(this.CMDSALIDA_Click);
            // 
            // CMDDOLAR
            // 
            this.CMDDOLAR.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDDOLAR.Location = new System.Drawing.Point(306, 307);
            this.CMDDOLAR.Name = "CMDDOLAR";
            this.CMDDOLAR.Size = new System.Drawing.Size(111, 34);
            this.CMDDOLAR.TabIndex = 6;
            this.CMDDOLAR.Text = "&Pesos";
            this.CMDDOLAR.UseVisualStyleBackColor = true;
            this.CMDDOLAR.Click += new System.EventHandler(this.CMDDOLAR_Click);
            // 
            // TXTDOLAR
            // 
            this.TXTDOLAR.Location = new System.Drawing.Point(164, 186);
            this.TXTDOLAR.Name = "TXTDOLAR";
            this.TXTDOLAR.Size = new System.Drawing.Size(100, 20);
            this.TXTDOLAR.TabIndex = 1;
            // 
            // TXTTPC
            // 
            this.TXTTPC.Location = new System.Drawing.Point(342, 186);
            this.TXTTPC.Name = "TXTTPC";
            this.TXTTPC.Size = new System.Drawing.Size(100, 20);
            this.TXTTPC.TabIndex = 3;
            // 
            // TXTPESOS
            // 
            this.TXTPESOS.Location = new System.Drawing.Point(506, 186);
            this.TXTPESOS.Name = "TXTPESOS";
            this.TXTPESOS.ReadOnly = true;
            this.TXTPESOS.Size = new System.Drawing.Size(100, 20);
            this.TXTPESOS.TabIndex = 5;
            // 
            // LBLDOLAR
            // 
            this.LBLDOLAR.AutoSize = true;
            this.LBLDOLAR.Location = new System.Drawing.Point(195, 109);
            this.LBLDOLAR.Name = "LBLDOLAR";
            this.LBLDOLAR.Size = new System.Drawing.Size(32, 13);
            this.LBLDOLAR.TabIndex = 0;
            this.LBLDOLAR.Text = "Dolar";
            // 
            // LBLTPC
            // 
            this.LBLTPC.AutoSize = true;
            this.LBLTPC.Location = new System.Drawing.Point(351, 109);
            this.LBLTPC.Name = "LBLTPC";
            this.LBLTPC.Size = new System.Drawing.Size(80, 13);
            this.LBLTPC.TabIndex = 2;
            this.LBLTPC.Text = "Tipo de cambio";
            // 
            // LBLPESO
            // 
            this.LBLPESO.AutoSize = true;
            this.LBLPESO.Location = new System.Drawing.Point(545, 109);
            this.LBLPESO.Name = "LBLPESO";
            this.LBLPESO.Size = new System.Drawing.Size(36, 13);
            this.LBLPESO.TabIndex = 4;
            this.LBLPESO.Text = "Pesos";
            // 
            // FRMPESOS
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
            this.Name = "FRMPESOS";
            this.Text = "Dolar a Peso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CMDSALIDA;
        private System.Windows.Forms.Button CMDDOLAR;
        private System.Windows.Forms.TextBox TXTDOLAR;
        private System.Windows.Forms.TextBox TXTTPC;
        private System.Windows.Forms.TextBox TXTPESOS;
        private System.Windows.Forms.Label LBLDOLAR;
        private System.Windows.Forms.Label LBLTPC;
        private System.Windows.Forms.Label LBLPESO;
    }
}

