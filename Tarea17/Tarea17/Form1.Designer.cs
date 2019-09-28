namespace Tarea17
{
    partial class FRMCAL
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LBLCAL = new System.Windows.Forms.Label();
            this.TXTCAL = new System.Windows.Forms.TextBox();
            this.LBLABORE = new System.Windows.Forms.Label();
            this.CMDAPORE = new System.Windows.Forms.Button();
            this.CMDSALIDA = new System.Windows.Forms.Button();
            this.CMDOTRO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLCAL
            // 
            this.LBLCAL.AutoSize = true;
            this.LBLCAL.Location = new System.Drawing.Point(58, 66);
            this.LBLCAL.Name = "LBLCAL";
            this.LBLCAL.Size = new System.Drawing.Size(115, 13);
            this.LBLCAL.TabIndex = 0;
            this.LBLCAL.Text = "Ingrese su calificacion:";
            // 
            // TXTCAL
            // 
            this.TXTCAL.Location = new System.Drawing.Point(206, 59);
            this.TXTCAL.Name = "TXTCAL";
            this.TXTCAL.Size = new System.Drawing.Size(100, 20);
            this.TXTCAL.TabIndex = 1;
            // 
            // LBLABORE
            // 
            this.LBLABORE.AutoSize = true;
            this.LBLABORE.Location = new System.Drawing.Point(138, 128);
            this.LBLABORE.Name = "LBLABORE";
            this.LBLABORE.Size = new System.Drawing.Size(0, 13);
            this.LBLABORE.TabIndex = 2;
            // 
            // CMDAPORE
            // 
            this.CMDAPORE.Location = new System.Drawing.Point(185, 174);
            this.CMDAPORE.Name = "CMDAPORE";
            this.CMDAPORE.Size = new System.Drawing.Size(109, 23);
            this.CMDAPORE.TabIndex = 3;
            this.CMDAPORE.Text = "Resultado";
            this.CMDAPORE.UseVisualStyleBackColor = true;
            this.CMDAPORE.Click += new System.EventHandler(this.CMDAPORE_Click);
            // 
            // CMDSALIDA
            // 
            this.CMDSALIDA.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDSALIDA.Location = new System.Drawing.Point(185, 213);
            this.CMDSALIDA.Name = "CMDSALIDA";
            this.CMDSALIDA.Size = new System.Drawing.Size(109, 23);
            this.CMDSALIDA.TabIndex = 4;
            this.CMDSALIDA.Text = "&Salida";
            this.CMDSALIDA.UseVisualStyleBackColor = true;
            this.CMDSALIDA.Click += new System.EventHandler(this.CMDSALIDA_Click);
            // 
            // CMDOTRO
            // 
            this.CMDOTRO.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDOTRO.Location = new System.Drawing.Point(185, 252);
            this.CMDOTRO.Name = "CMDOTRO";
            this.CMDOTRO.Size = new System.Drawing.Size(109, 23);
            this.CMDOTRO.TabIndex = 5;
            this.CMDOTRO.Text = "&Clear";
            this.CMDOTRO.UseVisualStyleBackColor = true;
            this.CMDOTRO.Click += new System.EventHandler(this.CMDOTRO_Click);
            // 
            // FRMCAL
            // 
            this.AcceptButton = this.CMDAPORE;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDSALIDA;
            this.ClientSize = new System.Drawing.Size(534, 302);
            this.Controls.Add(this.CMDOTRO);
            this.Controls.Add(this.CMDSALIDA);
            this.Controls.Add(this.CMDAPORE);
            this.Controls.Add(this.LBLABORE);
            this.Controls.Add(this.TXTCAL);
            this.Controls.Add(this.LBLCAL);
            this.Name = "FRMCAL";
            this.Text = "Aprobado o Reprobado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLCAL;
        private System.Windows.Forms.TextBox TXTCAL;
        private System.Windows.Forms.Label LBLABORE;
        private System.Windows.Forms.Button CMDAPORE;
        private System.Windows.Forms.Button CMDSALIDA;
        private System.Windows.Forms.Button CMDOTRO;
    }
}

