namespace Ejemplo1
{
    partial class FRMEJEMPLO1
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
            this.LBLBASE = new System.Windows.Forms.Label();
            this.TXT_BASE = new System.Windows.Forms.TextBox();
            this.LBLALTURA = new System.Windows.Forms.Label();
            this.TXT_ALTURA = new System.Windows.Forms.TextBox();
            this.LBLAREA = new System.Windows.Forms.Label();
            this.TXT_AREA = new System.Windows.Forms.TextBox();
            this.CMDAREA = new System.Windows.Forms.Button();
            this.CMDSALIDA = new System.Windows.Forms.Button();
            this.CMDOTRO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLBASE
            // 
            this.LBLBASE.AutoSize = true;
            this.LBLBASE.Location = new System.Drawing.Point(87, 57);
            this.LBLBASE.Name = "LBLBASE";
            this.LBLBASE.Size = new System.Drawing.Size(81, 13);
            this.LBLBASE.TabIndex = 0;
            this.LBLBASE.Text = "Introduce &base:";
            // 
            // TXT_BASE
            // 
            this.TXT_BASE.Location = new System.Drawing.Point(204, 50);
            this.TXT_BASE.Name = "TXT_BASE";
            this.TXT_BASE.Size = new System.Drawing.Size(100, 20);
            this.TXT_BASE.TabIndex = 1;
            // 
            // LBLALTURA
            // 
            this.LBLALTURA.AutoSize = true;
            this.LBLALTURA.Location = new System.Drawing.Point(87, 102);
            this.LBLALTURA.Name = "LBLALTURA";
            this.LBLALTURA.Size = new System.Drawing.Size(84, 13);
            this.LBLALTURA.TabIndex = 2;
            this.LBLALTURA.Text = "Introduce a&ltura:";
            // 
            // TXT_ALTURA
            // 
            this.TXT_ALTURA.Location = new System.Drawing.Point(204, 99);
            this.TXT_ALTURA.Name = "TXT_ALTURA";
            this.TXT_ALTURA.Size = new System.Drawing.Size(100, 20);
            this.TXT_ALTURA.TabIndex = 3;
            // 
            // LBLAREA
            // 
            this.LBLAREA.AutoSize = true;
            this.LBLAREA.Location = new System.Drawing.Point(87, 155);
            this.LBLAREA.Name = "LBLAREA";
            this.LBLAREA.Size = new System.Drawing.Size(111, 13);
            this.LBLAREA.TabIndex = 4;
            this.LBLAREA.Text = "El área del tringulo es:";
            // 
            // TXT_AREA
            // 
            this.TXT_AREA.Location = new System.Drawing.Point(204, 148);
            this.TXT_AREA.Name = "TXT_AREA";
            this.TXT_AREA.ReadOnly = true;
            this.TXT_AREA.Size = new System.Drawing.Size(100, 20);
            this.TXT_AREA.TabIndex = 5;
            // 
            // CMDAREA
            // 
            this.CMDAREA.Location = new System.Drawing.Point(96, 197);
            this.CMDAREA.Name = "CMDAREA";
            this.CMDAREA.Size = new System.Drawing.Size(75, 56);
            this.CMDAREA.TabIndex = 6;
            this.CMDAREA.Text = "&AREA";
            this.CMDAREA.UseVisualStyleBackColor = true;
            this.CMDAREA.Click += new System.EventHandler(this.CMDAREA_Click);
            // 
            // CMDSALIDA
            // 
            this.CMDSALIDA.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDSALIDA.Location = new System.Drawing.Point(204, 197);
            this.CMDSALIDA.Name = "CMDSALIDA";
            this.CMDSALIDA.Size = new System.Drawing.Size(75, 56);
            this.CMDSALIDA.TabIndex = 7;
            this.CMDSALIDA.Text = "&SALIDA";
            this.CMDSALIDA.UseVisualStyleBackColor = true;
            this.CMDSALIDA.Click += new System.EventHandler(this.CMDSALIDA_Click);
            // 
            // CMDOTRO
            // 
            this.CMDOTRO.Location = new System.Drawing.Point(152, 259);
            this.CMDOTRO.Name = "CMDOTRO";
            this.CMDOTRO.Size = new System.Drawing.Size(75, 23);
            this.CMDOTRO.TabIndex = 8;
            this.CMDOTRO.Text = "&Clear";
            this.CMDOTRO.UseVisualStyleBackColor = true;
            this.CMDOTRO.Click += new System.EventHandler(this.CMDOTRO_Click);
            // 
            // FRMEJEMPLO1
            // 
            this.AcceptButton = this.CMDAREA;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDSALIDA;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CMDOTRO);
            this.Controls.Add(this.CMDSALIDA);
            this.Controls.Add(this.CMDAREA);
            this.Controls.Add(this.TXT_AREA);
            this.Controls.Add(this.LBLAREA);
            this.Controls.Add(this.TXT_ALTURA);
            this.Controls.Add(this.LBLALTURA);
            this.Controls.Add(this.TXT_BASE);
            this.Controls.Add(this.LBLBASE);
            this.Name = "FRMEJEMPLO1";
            this.Text = "Area de un triangulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLBASE;
        private System.Windows.Forms.TextBox TXT_BASE;
        private System.Windows.Forms.Label LBLALTURA;
        private System.Windows.Forms.TextBox TXT_ALTURA;
        private System.Windows.Forms.Label LBLAREA;
        private System.Windows.Forms.TextBox TXT_AREA;
        private System.Windows.Forms.Button CMDAREA;
        private System.Windows.Forms.Button CMDSALIDA;
        private System.Windows.Forms.Button CMDOTRO;
    }
}

