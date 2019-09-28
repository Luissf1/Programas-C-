namespace Tarea26
{
    partial class FRMDIA
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
            this.LBLDIA2 = new System.Windows.Forms.Label();
            this.CMDDIA = new System.Windows.Forms.Button();
            this.CMDCLEAR = new System.Windows.Forms.Button();
            this.CMDSALIDA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLDIA
            // 
            this.LBLDIA.AutoSize = true;
            this.LBLDIA.Location = new System.Drawing.Point(40, 36);
            this.LBLDIA.Name = "LBLDIA";
            this.LBLDIA.Size = new System.Drawing.Size(97, 13);
            this.LBLDIA.TabIndex = 0;
            this.LBLDIA.Text = "Ingrese el numero :";
            // 
            // TXTDIA
            // 
            this.TXTDIA.Location = new System.Drawing.Point(156, 33);
            this.TXTDIA.Name = "TXTDIA";
            this.TXTDIA.Size = new System.Drawing.Size(100, 20);
            this.TXTDIA.TabIndex = 1;
            // 
            // LBLDIA2
            // 
            this.LBLDIA2.AutoSize = true;
            this.LBLDIA2.Location = new System.Drawing.Point(121, 128);
            this.LBLDIA2.Name = "LBLDIA2";
            this.LBLDIA2.Size = new System.Drawing.Size(0, 13);
            this.LBLDIA2.TabIndex = 2;
            // 
            // CMDDIA
            // 
            this.CMDDIA.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDDIA.Location = new System.Drawing.Point(287, 36);
            this.CMDDIA.Name = "CMDDIA";
            this.CMDDIA.Size = new System.Drawing.Size(118, 38);
            this.CMDDIA.TabIndex = 3;
            this.CMDDIA.Text = "&Dia";
            this.CMDDIA.UseVisualStyleBackColor = true;
            this.CMDDIA.Click += new System.EventHandler(this.CMDDIA_Click);
            // 
            // CMDCLEAR
            // 
            this.CMDCLEAR.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDCLEAR.Location = new System.Drawing.Point(287, 93);
            this.CMDCLEAR.Name = "CMDCLEAR";
            this.CMDCLEAR.Size = new System.Drawing.Size(118, 38);
            this.CMDCLEAR.TabIndex = 4;
            this.CMDCLEAR.Text = "&Clear";
            this.CMDCLEAR.UseVisualStyleBackColor = true;
            this.CMDCLEAR.Click += new System.EventHandler(this.CMDCLEAR_Click);
            // 
            // CMDSALIDA
            // 
            this.CMDSALIDA.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDSALIDA.Location = new System.Drawing.Point(287, 152);
            this.CMDSALIDA.Name = "CMDSALIDA";
            this.CMDSALIDA.Size = new System.Drawing.Size(118, 38);
            this.CMDSALIDA.TabIndex = 5;
            this.CMDSALIDA.Text = "&Salida";
            this.CMDSALIDA.UseVisualStyleBackColor = true;
            this.CMDSALIDA.Click += new System.EventHandler(this.CMDSALIDA_Click);
            // 
            // FRMDIA
            // 
            this.AcceptButton = this.CMDDIA;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDSALIDA;
            this.ClientSize = new System.Drawing.Size(430, 225);
            this.Controls.Add(this.CMDSALIDA);
            this.Controls.Add(this.CMDCLEAR);
            this.Controls.Add(this.CMDDIA);
            this.Controls.Add(this.LBLDIA2);
            this.Controls.Add(this.TXTDIA);
            this.Controls.Add(this.LBLDIA);
            this.Name = "FRMDIA";
            this.Text = "Dias de la semana";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLDIA;
        private System.Windows.Forms.TextBox TXTDIA;
        private System.Windows.Forms.Label LBLDIA2;
        private System.Windows.Forms.Button CMDDIA;
        private System.Windows.Forms.Button CMDCLEAR;
        private System.Windows.Forms.Button CMDSALIDA;
    }
}

