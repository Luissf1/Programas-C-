namespace Tarea1
{
    partial class FRMVEL
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
            this.TXTVELOCIDAD = new System.Windows.Forms.TextBox();
            this.CMDSALIDA = new System.Windows.Forms.Button();
            this.CMDVELOCIDAD = new System.Windows.Forms.Button();
            this.TXTTIEMPO = new System.Windows.Forms.TextBox();
            this.LBLTIEMPO = new System.Windows.Forms.Label();
            this.TXTDISTANCIA = new System.Windows.Forms.TextBox();
            this.LBLDISTANCIA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TXTVELOCIDAD
            // 
            this.TXTVELOCIDAD.Location = new System.Drawing.Point(340, 327);
            this.TXTVELOCIDAD.Name = "TXTVELOCIDAD";
            this.TXTVELOCIDAD.ReadOnly = true;
            this.TXTVELOCIDAD.Size = new System.Drawing.Size(100, 20);
            this.TXTVELOCIDAD.TabIndex = 6;
            // 
            // CMDSALIDA
            // 
            this.CMDSALIDA.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDSALIDA.Location = new System.Drawing.Point(443, 209);
            this.CMDSALIDA.Name = "CMDSALIDA";
            this.CMDSALIDA.Size = new System.Drawing.Size(100, 57);
            this.CMDSALIDA.TabIndex = 5;
            this.CMDSALIDA.Text = "&Salida";
            this.CMDSALIDA.UseVisualStyleBackColor = true;
            this.CMDSALIDA.Click += new System.EventHandler(this.CMDSALIDA_Click);
            // 
            // CMDVELOCIDAD
            // 
            this.CMDVELOCIDAD.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDVELOCIDAD.Location = new System.Drawing.Point(257, 209);
            this.CMDVELOCIDAD.Name = "CMDVELOCIDAD";
            this.CMDVELOCIDAD.Size = new System.Drawing.Size(100, 57);
            this.CMDVELOCIDAD.TabIndex = 4;
            this.CMDVELOCIDAD.Text = "&Velocidad";
            this.CMDVELOCIDAD.UseVisualStyleBackColor = true;
            this.CMDVELOCIDAD.Click += new System.EventHandler(this.CMDVELOCIDAD_Click);
            // 
            // TXTTIEMPO
            // 
            this.TXTTIEMPO.Location = new System.Drawing.Point(443, 143);
            this.TXTTIEMPO.Name = "TXTTIEMPO";
            this.TXTTIEMPO.Size = new System.Drawing.Size(100, 20);
            this.TXTTIEMPO.TabIndex = 3;
            // 
            // LBLTIEMPO
            // 
            this.LBLTIEMPO.AutoSize = true;
            this.LBLTIEMPO.Location = new System.Drawing.Point(458, 103);
            this.LBLTIEMPO.Name = "LBLTIEMPO";
            this.LBLTIEMPO.Size = new System.Drawing.Size(42, 13);
            this.LBLTIEMPO.TabIndex = 2;
            this.LBLTIEMPO.Text = "Tiempo";
            // 
            // TXTDISTANCIA
            // 
            this.TXTDISTANCIA.Location = new System.Drawing.Point(257, 143);
            this.TXTDISTANCIA.Name = "TXTDISTANCIA";
            this.TXTDISTANCIA.Size = new System.Drawing.Size(100, 20);
            this.TXTDISTANCIA.TabIndex = 1;
            // 
            // LBLDISTANCIA
            // 
            this.LBLDISTANCIA.AutoSize = true;
            this.LBLDISTANCIA.Location = new System.Drawing.Point(277, 103);
            this.LBLDISTANCIA.Name = "LBLDISTANCIA";
            this.LBLDISTANCIA.Size = new System.Drawing.Size(52, 13);
            this.LBLDISTANCIA.TabIndex = 0;
            this.LBLDISTANCIA.Text = "DIstancia";
            // 
            // FRMVEL
            // 
            this.AcceptButton = this.CMDVELOCIDAD;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDSALIDA;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TXTVELOCIDAD);
            this.Controls.Add(this.CMDSALIDA);
            this.Controls.Add(this.CMDVELOCIDAD);
            this.Controls.Add(this.TXTTIEMPO);
            this.Controls.Add(this.LBLTIEMPO);
            this.Controls.Add(this.TXTDISTANCIA);
            this.Controls.Add(this.LBLDISTANCIA);
            this.Name = "FRMVEL";
            this.Text = "Calcula velocidad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTVELOCIDAD;
        private System.Windows.Forms.Button CMDSALIDA;
        private System.Windows.Forms.Button CMDVELOCIDAD;
        private System.Windows.Forms.TextBox TXTTIEMPO;
        private System.Windows.Forms.Label LBLTIEMPO;
        private System.Windows.Forms.TextBox TXTDISTANCIA;
        private System.Windows.Forms.Label LBLDISTANCIA;
    }
}

