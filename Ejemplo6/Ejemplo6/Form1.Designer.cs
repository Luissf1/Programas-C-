namespace Ejemplo6
{
    partial class FRMEJEMPLO6
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
            this.CMDSALIDA = new System.Windows.Forms.Button();
            this.CMDOTRO = new System.Windows.Forms.Button();
            this.CMDMAYOR = new System.Windows.Forms.Button();
            this.LBLMAYMEN = new System.Windows.Forms.Label();
            this.TXTEDAD = new System.Windows.Forms.TextBox();
            this.LBLNUM = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CMDSALIDA
            // 
            this.CMDSALIDA.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDSALIDA.Location = new System.Drawing.Point(156, 231);
            this.CMDSALIDA.Name = "CMDSALIDA";
            this.CMDSALIDA.Size = new System.Drawing.Size(201, 23);
            this.CMDSALIDA.TabIndex = 5;
            this.CMDSALIDA.Text = "&Salida";
            this.CMDSALIDA.UseVisualStyleBackColor = true;
            this.CMDSALIDA.Click += new System.EventHandler(this.CMDSALIDA_Click);
            // 
            // CMDOTRO
            // 
            this.CMDOTRO.Location = new System.Drawing.Point(156, 183);
            this.CMDOTRO.Name = "CMDOTRO";
            this.CMDOTRO.Size = new System.Drawing.Size(201, 23);
            this.CMDOTRO.TabIndex = 4;
            this.CMDOTRO.Text = "&Limpia";
            this.CMDOTRO.UseVisualStyleBackColor = true;
            this.CMDOTRO.Click += new System.EventHandler(this.CMDOTRO_Click);
            // 
            // CMDMAYOR
            // 
            this.CMDMAYOR.Location = new System.Drawing.Point(156, 140);
            this.CMDMAYOR.Name = "CMDMAYOR";
            this.CMDMAYOR.Size = new System.Drawing.Size(201, 23);
            this.CMDMAYOR.TabIndex = 3;
            this.CMDMAYOR.Text = "&Mayor";
            this.CMDMAYOR.UseVisualStyleBackColor = true;
            this.CMDMAYOR.Click += new System.EventHandler(this.CMDMAYOR_Click);
            // 
            // LBLMAYMEN
            // 
            this.LBLMAYMEN.AutoSize = true;
            this.LBLMAYMEN.Location = new System.Drawing.Point(163, 99);
            this.LBLMAYMEN.Name = "LBLMAYMEN";
            this.LBLMAYMEN.Size = new System.Drawing.Size(0, 13);
            this.LBLMAYMEN.TabIndex = 2;
            this.LBLMAYMEN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TXTEDAD
            // 
            this.TXTEDAD.Location = new System.Drawing.Point(236, 38);
            this.TXTEDAD.Name = "TXTEDAD";
            this.TXTEDAD.Size = new System.Drawing.Size(31, 20);
            this.TXTEDAD.TabIndex = 1;
            // 
            // LBLNUM
            // 
            this.LBLNUM.AutoSize = true;
            this.LBLNUM.Location = new System.Drawing.Point(119, 45);
            this.LBLNUM.Name = "LBLNUM";
            this.LBLNUM.Size = new System.Drawing.Size(83, 13);
            this.LBLNUM.TabIndex = 0;
            this.LBLNUM.Text = "Introduce &Edad:";
            // 
            // FRMEJEMPLO6
            // 
            this.AcceptButton = this.CMDMAYOR;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDSALIDA;
            this.ClientSize = new System.Drawing.Size(476, 293);
            this.Controls.Add(this.CMDSALIDA);
            this.Controls.Add(this.CMDOTRO);
            this.Controls.Add(this.CMDMAYOR);
            this.Controls.Add(this.LBLMAYMEN);
            this.Controls.Add(this.TXTEDAD);
            this.Controls.Add(this.LBLNUM);
            this.Name = "FRMEJEMPLO6";
            this.Text = "Ejemplo 6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CMDSALIDA;
        private System.Windows.Forms.Button CMDOTRO;
        private System.Windows.Forms.Button CMDMAYOR;
        private System.Windows.Forms.Label LBLMAYMEN;
        private System.Windows.Forms.TextBox TXTEDAD;
        private System.Windows.Forms.Label LBLNUM;
    }
}

