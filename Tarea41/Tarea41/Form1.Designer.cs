namespace Tarea41
{
    partial class FRMNUM
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
            this.CMDOTRO = new System.Windows.Forms.Button();
            this.CMDCAPTURA = new System.Windows.Forms.Button();
            this.TXTORD = new System.Windows.Forms.TextBox();
            this.TXNUM = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CMDSALIDA
            // 
            this.CMDSALIDA.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDSALIDA.Location = new System.Drawing.Point(361, 182);
            this.CMDSALIDA.Name = "CMDSALIDA";
            this.CMDSALIDA.Size = new System.Drawing.Size(111, 39);
            this.CMDSALIDA.TabIndex = 4;
            this.CMDSALIDA.Text = "&Salida";
            this.CMDSALIDA.UseVisualStyleBackColor = true;
            this.CMDSALIDA.Click += new System.EventHandler(this.CMDSALIDA_Click);
            // 
            // CMDOTRO
            // 
            this.CMDOTRO.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDOTRO.Location = new System.Drawing.Point(361, 116);
            this.CMDOTRO.Name = "CMDOTRO";
            this.CMDOTRO.Size = new System.Drawing.Size(111, 39);
            this.CMDOTRO.TabIndex = 3;
            this.CMDOTRO.Text = "&Clear";
            this.CMDOTRO.UseVisualStyleBackColor = true;
            this.CMDOTRO.Click += new System.EventHandler(this.CMDOTRO_Click);
            // 
            // CMDCAPTURA
            // 
            this.CMDCAPTURA.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDCAPTURA.Location = new System.Drawing.Point(361, 48);
            this.CMDCAPTURA.Name = "CMDCAPTURA";
            this.CMDCAPTURA.Size = new System.Drawing.Size(111, 39);
            this.CMDCAPTURA.TabIndex = 2;
            this.CMDCAPTURA.Text = "&Captura";
            this.CMDCAPTURA.UseVisualStyleBackColor = true;
            this.CMDCAPTURA.Click += new System.EventHandler(this.CMDCAPTURA_Click);
            // 
            // TXTORD
            // 
            this.TXTORD.Location = new System.Drawing.Point(79, 156);
            this.TXTORD.Multiline = true;
            this.TXTORD.Name = "TXTORD";
            this.TXTORD.ReadOnly = true;
            this.TXTORD.Size = new System.Drawing.Size(218, 65);
            this.TXTORD.TabIndex = 1;
            // 
            // TXNUM
            // 
            this.TXNUM.Location = new System.Drawing.Point(79, 48);
            this.TXNUM.Multiline = true;
            this.TXNUM.Name = "TXNUM";
            this.TXNUM.ReadOnly = true;
            this.TXNUM.Size = new System.Drawing.Size(218, 63);
            this.TXNUM.TabIndex = 0;
            // 
            // FRMNUM
            // 
            this.AcceptButton = this.CMDCAPTURA;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDSALIDA;
            this.ClientSize = new System.Drawing.Size(550, 268);
            this.Controls.Add(this.CMDSALIDA);
            this.Controls.Add(this.CMDOTRO);
            this.Controls.Add(this.CMDCAPTURA);
            this.Controls.Add(this.TXTORD);
            this.Controls.Add(this.TXNUM);
            this.Name = "FRMNUM";
            this.Text = "Inversion de numeros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CMDSALIDA;
        private System.Windows.Forms.Button CMDOTRO;
        private System.Windows.Forms.Button CMDCAPTURA;
        private System.Windows.Forms.TextBox TXTORD;
        private System.Windows.Forms.TextBox TXNUM;
    }
}

