namespace Tarea3
{
    partial class FRMTIEMPO
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
            this.LBLTIEMPO = new System.Windows.Forms.Label();
            this.TXTTIEMPO = new System.Windows.Forms.TextBox();
            this.CMDTIEMPO = new System.Windows.Forms.Button();
            this.CMDSALIDA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLTIEMPO
            // 
            this.LBLTIEMPO.AutoSize = true;
            this.LBLTIEMPO.Location = new System.Drawing.Point(290, 78);
            this.LBLTIEMPO.Name = "LBLTIEMPO";
            this.LBLTIEMPO.Size = new System.Drawing.Size(42, 13);
            this.LBLTIEMPO.TabIndex = 0;
            this.LBLTIEMPO.Text = "Tiempo";
            // 
            // TXTTIEMPO
            // 
            this.TXTTIEMPO.Location = new System.Drawing.Point(269, 266);
            this.TXTTIEMPO.Name = "TXTTIEMPO";
            this.TXTTIEMPO.ReadOnly = true;
            this.TXTTIEMPO.Size = new System.Drawing.Size(100, 20);
            this.TXTTIEMPO.TabIndex = 3;
            // 
            // CMDTIEMPO
            // 
            this.CMDTIEMPO.Location = new System.Drawing.Point(207, 166);
            this.CMDTIEMPO.Name = "CMDTIEMPO";
            this.CMDTIEMPO.Size = new System.Drawing.Size(88, 70);
            this.CMDTIEMPO.TabIndex = 1;
            this.CMDTIEMPO.Text = "&Tiempo";
            this.CMDTIEMPO.UseVisualStyleBackColor = true;
            this.CMDTIEMPO.Click += new System.EventHandler(this.CMDTIEMPO_Click);
            // 
            // CMDSALIDA
            // 
            this.CMDSALIDA.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDSALIDA.Location = new System.Drawing.Point(339, 166);
            this.CMDSALIDA.Name = "CMDSALIDA";
            this.CMDSALIDA.Size = new System.Drawing.Size(90, 70);
            this.CMDSALIDA.TabIndex = 2;
            this.CMDSALIDA.Text = "&Salida";
            this.CMDSALIDA.UseVisualStyleBackColor = true;
            this.CMDSALIDA.Click += new System.EventHandler(this.CMDSALIDA_Click);
            // 
            // FRMTIEMPO
            // 
            this.AcceptButton = this.CMDTIEMPO;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDSALIDA;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CMDSALIDA);
            this.Controls.Add(this.CMDTIEMPO);
            this.Controls.Add(this.TXTTIEMPO);
            this.Controls.Add(this.LBLTIEMPO);
            this.Name = "FRMTIEMPO";
            this.Text = "Calcular el Tiempo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLTIEMPO;
        private System.Windows.Forms.TextBox TXTTIEMPO;
        private System.Windows.Forms.Button CMDTIEMPO;
        private System.Windows.Forms.Button CMDSALIDA;
    }
}

