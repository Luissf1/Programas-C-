namespace Ejemplo10
{
    partial class FRMEJEMPLO10
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
            this.LBLDIV = new System.Windows.Forms.Label();
            this.LBLVAL = new System.Windows.Forms.Label();
            this.CMDVALIDAR = new System.Windows.Forms.Button();
            this.CMDSALIDA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLDIV
            // 
            this.LBLDIV.AutoSize = true;
            this.LBLDIV.Location = new System.Drawing.Point(50, 33);
            this.LBLDIV.Name = "LBLDIV";
            this.LBLDIV.Size = new System.Drawing.Size(85, 13);
            this.LBLDIV.TabIndex = 0;
            this.LBLDIV.Text = "Division de 10/0";
            // 
            // LBLVAL
            // 
            this.LBLVAL.AutoSize = true;
            this.LBLVAL.Location = new System.Drawing.Point(50, 71);
            this.LBLVAL.Name = "LBLVAL";
            this.LBLVAL.Size = new System.Drawing.Size(0, 13);
            this.LBLVAL.TabIndex = 1;
            this.LBLVAL.Click += new System.EventHandler(this.LBLVAL_Click);
            // 
            // CMDVALIDAR
            // 
            this.CMDVALIDAR.Location = new System.Drawing.Point(262, 33);
            this.CMDVALIDAR.Name = "CMDVALIDAR";
            this.CMDVALIDAR.Size = new System.Drawing.Size(75, 23);
            this.CMDVALIDAR.TabIndex = 2;
            this.CMDVALIDAR.Text = "&Validar";
            this.CMDVALIDAR.UseVisualStyleBackColor = true;
            this.CMDVALIDAR.Click += new System.EventHandler(this.CMDVALIDAR_Click);
            // 
            // CMDSALIDA
            // 
            this.CMDSALIDA.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDSALIDA.Location = new System.Drawing.Point(262, 82);
            this.CMDSALIDA.Name = "CMDSALIDA";
            this.CMDSALIDA.Size = new System.Drawing.Size(75, 23);
            this.CMDSALIDA.TabIndex = 3;
            this.CMDSALIDA.Text = "&Salida";
            this.CMDSALIDA.UseVisualStyleBackColor = true;
            this.CMDSALIDA.Click += new System.EventHandler(this.CMDSALIDA_Click);
            // 
            // FRMEJEMPLO10
            // 
            this.AcceptButton = this.CMDVALIDAR;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDSALIDA;
            this.ClientSize = new System.Drawing.Size(372, 157);
            this.Controls.Add(this.CMDSALIDA);
            this.Controls.Add(this.CMDVALIDAR);
            this.Controls.Add(this.LBLVAL);
            this.Controls.Add(this.LBLDIV);
            this.Name = "FRMEJEMPLO10";
            this.Text = "Ejemplo 10";
            this.Load += new System.EventHandler(this.FRMEJEMPLO10_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLDIV;
        private System.Windows.Forms.Label LBLVAL;
        private System.Windows.Forms.Button CMDVALIDAR;
        private System.Windows.Forms.Button CMDSALIDA;
    }
}

