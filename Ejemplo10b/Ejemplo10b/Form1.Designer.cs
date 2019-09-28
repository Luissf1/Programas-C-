namespace Ejemplo10b
{
    partial class FRMEJEMPLO10B
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
            this.LBLDIVIDIENDO = new System.Windows.Forms.Label();
            this.TXTDIVIDIENDO = new System.Windows.Forms.TextBox();
            this.LBLDIVISOR = new System.Windows.Forms.Label();
            this.TXTDIVISOR = new System.Windows.Forms.TextBox();
            this.CMDVAL = new System.Windows.Forms.Button();
            this.CMDSALIDA = new System.Windows.Forms.Button();
            this.LBLVAL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBLDIVIDIENDO
            // 
            this.LBLDIVIDIENDO.AutoSize = true;
            this.LBLDIVIDIENDO.Location = new System.Drawing.Point(12, 26);
            this.LBLDIVIDIENDO.Name = "LBLDIVIDIENDO";
            this.LBLDIVIDIENDO.Size = new System.Drawing.Size(60, 13);
            this.LBLDIVIDIENDO.TabIndex = 0;
            this.LBLDIVIDIENDO.Text = "Dividiendo:";
            // 
            // TXTDIVIDIENDO
            // 
            this.TXTDIVIDIENDO.Location = new System.Drawing.Point(180, 23);
            this.TXTDIVIDIENDO.Name = "TXTDIVIDIENDO";
            this.TXTDIVIDIENDO.Size = new System.Drawing.Size(100, 20);
            this.TXTDIVIDIENDO.TabIndex = 1;
            // 
            // LBLDIVISOR
            // 
            this.LBLDIVISOR.AutoSize = true;
            this.LBLDIVISOR.Location = new System.Drawing.Point(12, 71);
            this.LBLDIVISOR.Name = "LBLDIVISOR";
            this.LBLDIVISOR.Size = new System.Drawing.Size(42, 13);
            this.LBLDIVISOR.TabIndex = 2;
            this.LBLDIVISOR.Text = "Divisor:";
            // 
            // TXTDIVISOR
            // 
            this.TXTDIVISOR.Location = new System.Drawing.Point(180, 68);
            this.TXTDIVISOR.Name = "TXTDIVISOR";
            this.TXTDIVISOR.Size = new System.Drawing.Size(100, 20);
            this.TXTDIVISOR.TabIndex = 3;
            // 
            // CMDVAL
            // 
            this.CMDVAL.Location = new System.Drawing.Point(357, 23);
            this.CMDVAL.Name = "CMDVAL";
            this.CMDVAL.Size = new System.Drawing.Size(75, 23);
            this.CMDVAL.TabIndex = 4;
            this.CMDVAL.Text = "&Validar";
            this.CMDVAL.UseVisualStyleBackColor = true;
            this.CMDVAL.Click += new System.EventHandler(this.CMDVAL_Click);
            // 
            // CMDSALIDA
            // 
            this.CMDSALIDA.Location = new System.Drawing.Point(357, 66);
            this.CMDSALIDA.Name = "CMDSALIDA";
            this.CMDSALIDA.Size = new System.Drawing.Size(75, 23);
            this.CMDSALIDA.TabIndex = 5;
            this.CMDSALIDA.Text = "&Salida";
            this.CMDSALIDA.UseVisualStyleBackColor = true;
            this.CMDSALIDA.Click += new System.EventHandler(this.CMDSALIDA_Click);
            // 
            // LBLVAL
            // 
            this.LBLVAL.AutoSize = true;
            this.LBLVAL.Location = new System.Drawing.Point(100, 113);
            this.LBLVAL.Name = "LBLVAL";
            this.LBLVAL.Size = new System.Drawing.Size(0, 13);
            this.LBLVAL.TabIndex = 6;
            // 
            // FRMEJEMPLO10B
            // 
            this.AcceptButton = this.CMDVAL;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDSALIDA;
            this.ClientSize = new System.Drawing.Size(581, 174);
            this.Controls.Add(this.LBLVAL);
            this.Controls.Add(this.CMDSALIDA);
            this.Controls.Add(this.CMDVAL);
            this.Controls.Add(this.TXTDIVISOR);
            this.Controls.Add(this.LBLDIVISOR);
            this.Controls.Add(this.TXTDIVIDIENDO);
            this.Controls.Add(this.LBLDIVIDIENDO);
            this.Name = "FRMEJEMPLO10B";
            this.Text = "Ejemplo 10b";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLDIVIDIENDO;
        private System.Windows.Forms.TextBox TXTDIVIDIENDO;
        private System.Windows.Forms.Label LBLDIVISOR;
        private System.Windows.Forms.TextBox TXTDIVISOR;
        private System.Windows.Forms.Button CMDVAL;
        private System.Windows.Forms.Button CMDSALIDA;
        private System.Windows.Forms.Label LBLVAL;
    }
}

