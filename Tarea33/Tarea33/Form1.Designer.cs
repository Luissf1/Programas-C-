namespace Tarea33
{
    partial class FRMNUMERO
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
            this.TXTNUM1 = new System.Windows.Forms.TextBox();
            this.CMDCAPTURA = new System.Windows.Forms.Button();
            this.CMDOTRO = new System.Windows.Forms.Button();
            this.CMDSALIDA = new System.Windows.Forms.Button();
            this.TXTNUM = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TXTNUM1
            // 
            this.TXTNUM1.Location = new System.Drawing.Point(12, 22);
            this.TXTNUM1.Multiline = true;
            this.TXTNUM1.Name = "TXTNUM1";
            this.TXTNUM1.Size = new System.Drawing.Size(194, 83);
            this.TXTNUM1.TabIndex = 0;
            this.TXTNUM1.TextChanged += new System.EventHandler(this.TXTNUM1_TextChanged);
            // 
            // CMDCAPTURA
            // 
            this.CMDCAPTURA.Location = new System.Drawing.Point(347, 40);
            this.CMDCAPTURA.Name = "CMDCAPTURA";
            this.CMDCAPTURA.Size = new System.Drawing.Size(113, 32);
            this.CMDCAPTURA.TabIndex = 2;
            this.CMDCAPTURA.Text = "&Captura";
            this.CMDCAPTURA.UseVisualStyleBackColor = true;
            this.CMDCAPTURA.Click += new System.EventHandler(this.button1_Click);
            // 
            // CMDOTRO
            // 
            this.CMDOTRO.Location = new System.Drawing.Point(347, 92);
            this.CMDOTRO.Name = "CMDOTRO";
            this.CMDOTRO.Size = new System.Drawing.Size(113, 32);
            this.CMDOTRO.TabIndex = 3;
            this.CMDOTRO.Text = "&Clear";
            this.CMDOTRO.UseVisualStyleBackColor = true;
            this.CMDOTRO.Click += new System.EventHandler(this.CMDOTRO_Click);
            // 
            // CMDSALIDA
            // 
            this.CMDSALIDA.Location = new System.Drawing.Point(347, 147);
            this.CMDSALIDA.Name = "CMDSALIDA";
            this.CMDSALIDA.Size = new System.Drawing.Size(113, 32);
            this.CMDSALIDA.TabIndex = 4;
            this.CMDSALIDA.Text = "&Salida";
            this.CMDSALIDA.UseVisualStyleBackColor = true;
            this.CMDSALIDA.Click += new System.EventHandler(this.CMDSALIDA_Click);
            // 
            // TXTNUM
            // 
            this.TXTNUM.Location = new System.Drawing.Point(12, 147);
            this.TXTNUM.Name = "TXTNUM";
            this.TXTNUM.ReadOnly = true;
            this.TXTNUM.Size = new System.Drawing.Size(181, 20);
            this.TXTNUM.TabIndex = 1;
            // 
            // FRMNUMERO
            // 
            this.AcceptButton = this.CMDCAPTURA;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDSALIDA;
            this.ClientSize = new System.Drawing.Size(502, 225);
            this.Controls.Add(this.TXTNUM);
            this.Controls.Add(this.CMDSALIDA);
            this.Controls.Add(this.CMDOTRO);
            this.Controls.Add(this.CMDCAPTURA);
            this.Controls.Add(this.TXTNUM1);
            this.Name = "FRMNUMERO";
            this.Text = "Numero Mayor ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TXTNUM1;
        private System.Windows.Forms.Button CMDCAPTURA;
        private System.Windows.Forms.Button CMDOTRO;
        private System.Windows.Forms.Button CMDSALIDA;
        private System.Windows.Forms.TextBox TXTNUM;
    }
}

