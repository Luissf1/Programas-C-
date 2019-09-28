namespace Tarea22
{
    partial class FRMSEMANA
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
            this.LBLDIA = new System.Windows.Forms.Label();
            this.TXTDIA = new System.Windows.Forms.TextBox();
            this.CMDDIA = new System.Windows.Forms.Button();
            this.CMDSALIDA = new System.Windows.Forms.Button();
            this.CMDCLEAR = new System.Windows.Forms.Button();
            this.LBLDIA1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBLDIA
            // 
            this.LBLDIA.AutoSize = true;
            this.LBLDIA.Location = new System.Drawing.Point(43, 67);
            this.LBLDIA.Name = "LBLDIA";
            this.LBLDIA.Size = new System.Drawing.Size(62, 13);
            this.LBLDIA.TabIndex = 0;
            this.LBLDIA.Text = "Ingrese dia:";
            // 
            // TXTDIA
            // 
            this.TXTDIA.Location = new System.Drawing.Point(189, 64);
            this.TXTDIA.Name = "TXTDIA";
            this.TXTDIA.Size = new System.Drawing.Size(100, 20);
            this.TXTDIA.TabIndex = 1;
            // 
            // CMDDIA
            // 
            this.CMDDIA.Location = new System.Drawing.Point(365, 67);
            this.CMDDIA.Name = "CMDDIA";
            this.CMDDIA.Size = new System.Drawing.Size(75, 23);
            this.CMDDIA.TabIndex = 2;
            this.CMDDIA.Text = "&Dia";
            this.CMDDIA.UseVisualStyleBackColor = true;
            this.CMDDIA.Click += new System.EventHandler(this.CMDDIA_Click);
            // 
            // CMDSALIDA
            // 
            this.CMDSALIDA.Location = new System.Drawing.Point(365, 135);
            this.CMDSALIDA.Name = "CMDSALIDA";
            this.CMDSALIDA.Size = new System.Drawing.Size(75, 23);
            this.CMDSALIDA.TabIndex = 3;
            this.CMDSALIDA.Text = "&Salida";
            this.CMDSALIDA.UseVisualStyleBackColor = true;
            this.CMDSALIDA.Click += new System.EventHandler(this.CMDSALIDA_Click);
            // 
            // CMDCLEAR
            // 
            this.CMDCLEAR.Location = new System.Drawing.Point(365, 194);
            this.CMDCLEAR.Name = "CMDCLEAR";
            this.CMDCLEAR.Size = new System.Drawing.Size(75, 23);
            this.CMDCLEAR.TabIndex = 4;
            this.CMDCLEAR.Text = "&Clear";
            this.CMDCLEAR.UseVisualStyleBackColor = true;
            this.CMDCLEAR.Click += new System.EventHandler(this.CMDCLEAR_Click);
            // 
            // LBLDIA1
            // 
            this.LBLDIA1.AutoSize = true;
            this.LBLDIA1.Location = new System.Drawing.Point(97, 125);
            this.LBLDIA1.Name = "LBLDIA1";
            this.LBLDIA1.Size = new System.Drawing.Size(0, 13);
            this.LBLDIA1.TabIndex = 5;
            // 
            // FRMSEMANA
            // 
            this.AcceptButton = this.CMDDIA;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDSALIDA;
            this.ClientSize = new System.Drawing.Size(573, 332);
            this.Controls.Add(this.LBLDIA1);
            this.Controls.Add(this.CMDCLEAR);
            this.Controls.Add(this.CMDSALIDA);
            this.Controls.Add(this.CMDDIA);
            this.Controls.Add(this.TXTDIA);
            this.Controls.Add(this.LBLDIA);
            this.Name = "FRMSEMANA";
            this.Text = "Dias de las semanas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLDIA;
        private System.Windows.Forms.TextBox TXTDIA;
        private System.Windows.Forms.Button CMDDIA;
        private System.Windows.Forms.Button CMDSALIDA;
        private System.Windows.Forms.Button CMDCLEAR;
        private System.Windows.Forms.Label LBLDIA1;
    }
}

