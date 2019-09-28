namespace Tarea31
{
    partial class FRMEDAD
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
            this.TXTEDAD = new System.Windows.Forms.TextBox();
            this.LBLEDAD = new System.Windows.Forms.Label();
            this.CMDCAPTURA = new System.Windows.Forms.Button();
            this.CMDOTRO = new System.Windows.Forms.Button();
            this.CMDSALIDA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TXTEDAD
            // 
            this.TXTEDAD.Location = new System.Drawing.Point(63, 59);
            this.TXTEDAD.Multiline = true;
            this.TXTEDAD.Name = "TXTEDAD";
            this.TXTEDAD.ReadOnly = true;
            this.TXTEDAD.Size = new System.Drawing.Size(133, 182);
            this.TXTEDAD.TabIndex = 1;
            // 
            // LBLEDAD
            // 
            this.LBLEDAD.AutoSize = true;
            this.LBLEDAD.Location = new System.Drawing.Point(60, 26);
            this.LBLEDAD.Name = "LBLEDAD";
            this.LBLEDAD.Size = new System.Drawing.Size(136, 13);
            this.LBLEDAD.TabIndex = 0;
            this.LBLEDAD.Text = "Edades menores y mayores";
            // 
            // CMDCAPTURA
            // 
            this.CMDCAPTURA.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDCAPTURA.Location = new System.Drawing.Point(271, 46);
            this.CMDCAPTURA.Name = "CMDCAPTURA";
            this.CMDCAPTURA.Size = new System.Drawing.Size(92, 44);
            this.CMDCAPTURA.TabIndex = 2;
            this.CMDCAPTURA.Text = "&Captura";
            this.CMDCAPTURA.UseVisualStyleBackColor = true;
            this.CMDCAPTURA.Click += new System.EventHandler(this.CMDCAPTURA_Click);
            // 
            // CMDOTRO
            // 
            this.CMDOTRO.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDOTRO.Location = new System.Drawing.Point(271, 112);
            this.CMDOTRO.Name = "CMDOTRO";
            this.CMDOTRO.Size = new System.Drawing.Size(92, 44);
            this.CMDOTRO.TabIndex = 3;
            this.CMDOTRO.Text = "&Clear";
            this.CMDOTRO.UseVisualStyleBackColor = true;
            this.CMDOTRO.Click += new System.EventHandler(this.CMDOTRO_Click);
            // 
            // CMDSALIDA
            // 
            this.CMDSALIDA.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDSALIDA.Location = new System.Drawing.Point(271, 176);
            this.CMDSALIDA.Name = "CMDSALIDA";
            this.CMDSALIDA.Size = new System.Drawing.Size(92, 44);
            this.CMDSALIDA.TabIndex = 4;
            this.CMDSALIDA.Text = "&Salida";
            this.CMDSALIDA.UseVisualStyleBackColor = true;
            this.CMDSALIDA.Click += new System.EventHandler(this.CMDSALIDA_Click);
            // 
            // FRMEDAD
            // 
            this.AcceptButton = this.CMDCAPTURA;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDSALIDA;
            this.ClientSize = new System.Drawing.Size(468, 253);
            this.Controls.Add(this.CMDSALIDA);
            this.Controls.Add(this.CMDOTRO);
            this.Controls.Add(this.CMDCAPTURA);
            this.Controls.Add(this.LBLEDAD);
            this.Controls.Add(this.TXTEDAD);
            this.Name = "FRMEDAD";
            this.Text = "Lista de edades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTEDAD;
        private System.Windows.Forms.Label LBLEDAD;
        private System.Windows.Forms.Button CMDCAPTURA;
        private System.Windows.Forms.Button CMDOTRO;
        private System.Windows.Forms.Button CMDSALIDA;
    }
}

