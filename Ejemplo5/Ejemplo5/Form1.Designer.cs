namespace Ejemplo5
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
            this.LBLEDAD = new System.Windows.Forms.Label();
            this.TXTEDAD = new System.Windows.Forms.TextBox();
            this.LBLMAYMEN = new System.Windows.Forms.Label();
            this.CMDMAYOR = new System.Windows.Forms.Button();
            this.CMDOTRO = new System.Windows.Forms.Button();
            this.CMDSALIDA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLEDAD
            // 
            this.LBLEDAD.AutoSize = true;
            this.LBLEDAD.Location = new System.Drawing.Point(40, 46);
            this.LBLEDAD.Name = "LBLEDAD";
            this.LBLEDAD.Size = new System.Drawing.Size(83, 13);
            this.LBLEDAD.TabIndex = 0;
            this.LBLEDAD.Text = "Introduce &Edad:";
            // 
            // TXTEDAD
            // 
            this.TXTEDAD.Location = new System.Drawing.Point(157, 39);
            this.TXTEDAD.Name = "TXTEDAD";
            this.TXTEDAD.Size = new System.Drawing.Size(31, 20);
            this.TXTEDAD.TabIndex = 1;
            // 
            // LBLMAYMEN
            // 
            this.LBLMAYMEN.AutoSize = true;
            this.LBLMAYMEN.Location = new System.Drawing.Point(84, 100);
            this.LBLMAYMEN.Name = "LBLMAYMEN";
            this.LBLMAYMEN.Size = new System.Drawing.Size(0, 13);
            this.LBLMAYMEN.TabIndex = 2;
            this.LBLMAYMEN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CMDMAYOR
            // 
            this.CMDMAYOR.Location = new System.Drawing.Point(77, 141);
            this.CMDMAYOR.Name = "CMDMAYOR";
            this.CMDMAYOR.Size = new System.Drawing.Size(201, 23);
            this.CMDMAYOR.TabIndex = 3;
            this.CMDMAYOR.Text = "&Mayor";
            this.CMDMAYOR.UseVisualStyleBackColor = true;
            this.CMDMAYOR.Click += new System.EventHandler(this.CMDMAYOR_Click);
            // 
            // CMDOTRO
            // 
            this.CMDOTRO.Location = new System.Drawing.Point(77, 184);
            this.CMDOTRO.Name = "CMDOTRO";
            this.CMDOTRO.Size = new System.Drawing.Size(201, 23);
            this.CMDOTRO.TabIndex = 4;
            this.CMDOTRO.Text = "&Limpia";
            this.CMDOTRO.UseVisualStyleBackColor = true;
            this.CMDOTRO.Click += new System.EventHandler(this.CMDOTRO_Click);
            // 
            // CMDSALIDA
            // 
            this.CMDSALIDA.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDSALIDA.Location = new System.Drawing.Point(77, 232);
            this.CMDSALIDA.Name = "CMDSALIDA";
            this.CMDSALIDA.Size = new System.Drawing.Size(201, 23);
            this.CMDSALIDA.TabIndex = 5;
            this.CMDSALIDA.Text = "&Salida";
            this.CMDSALIDA.UseVisualStyleBackColor = true;
            this.CMDSALIDA.Click += new System.EventHandler(this.CMDSALIDA_Click);
            // 
            // FRMEDAD
            // 
            this.AcceptButton = this.CMDMAYOR;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDSALIDA;
            this.ClientSize = new System.Drawing.Size(381, 267);
            this.Controls.Add(this.CMDSALIDA);
            this.Controls.Add(this.CMDOTRO);
            this.Controls.Add(this.CMDMAYOR);
            this.Controls.Add(this.LBLMAYMEN);
            this.Controls.Add(this.TXTEDAD);
            this.Controls.Add(this.LBLEDAD);
            this.Name = "FRMEDAD";
            this.Text = "Ejemplo 5";
            this.Load += new System.EventHandler(this.FRMEDAD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLEDAD;
        private System.Windows.Forms.TextBox TXTEDAD;
        private System.Windows.Forms.Label LBLMAYMEN;
        private System.Windows.Forms.Button CMDMAYOR;
        private System.Windows.Forms.Button CMDOTRO;
        private System.Windows.Forms.Button CMDSALIDA;
    }
}

