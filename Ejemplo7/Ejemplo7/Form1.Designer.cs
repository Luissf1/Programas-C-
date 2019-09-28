namespace Ejemplo7
{
    partial class FRMEJEMPLO7
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
            this.LBLNUMC = new System.Windows.Forms.Label();
            this.TXTNUMC = new System.Windows.Forms.TextBox();
            this.LBLNOM = new System.Windows.Forms.Label();
            this.TXTNOM = new System.Windows.Forms.TextBox();
            this.LBLCARR = new System.Windows.Forms.Label();
            this.TXTCARR = new System.Windows.Forms.TextBox();
            this.LBLSEM = new System.Windows.Forms.Label();
            this.TXTSEM = new System.Windows.Forms.TextBox();
            this.LBLPROM = new System.Windows.Forms.Label();
            this.TXTPROM = new System.Windows.Forms.TextBox();
            this.CMDELECCION = new System.Windows.Forms.Button();
            this.CMDOTRO = new System.Windows.Forms.Button();
            this.CMDSALIDA = new System.Windows.Forms.Button();
            this.LBLDESPLIEGUE = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBLNUMC
            // 
            this.LBLNUMC.AutoSize = true;
            this.LBLNUMC.Location = new System.Drawing.Point(12, 19);
            this.LBLNUMC.Name = "LBLNUMC";
            this.LBLNUMC.Size = new System.Drawing.Size(74, 13);
            this.LBLNUMC.TabIndex = 0;
            this.LBLNUMC.Text = "&No. de control";
            // 
            // TXTNUMC
            // 
            this.TXTNUMC.Location = new System.Drawing.Point(139, 12);
            this.TXTNUMC.Name = "TXTNUMC";
            this.TXTNUMC.Size = new System.Drawing.Size(100, 20);
            this.TXTNUMC.TabIndex = 1;
            // 
            // LBLNOM
            // 
            this.LBLNOM.AutoSize = true;
            this.LBLNOM.Location = new System.Drawing.Point(12, 58);
            this.LBLNOM.Name = "LBLNOM";
            this.LBLNOM.Size = new System.Drawing.Size(44, 13);
            this.LBLNOM.TabIndex = 2;
            this.LBLNOM.Text = "Nombre";
            // 
            // TXTNOM
            // 
            this.TXTNOM.Location = new System.Drawing.Point(139, 55);
            this.TXTNOM.Name = "TXTNOM";
            this.TXTNOM.Size = new System.Drawing.Size(100, 20);
            this.TXTNOM.TabIndex = 3;
            // 
            // LBLCARR
            // 
            this.LBLCARR.AutoSize = true;
            this.LBLCARR.Location = new System.Drawing.Point(12, 107);
            this.LBLCARR.Name = "LBLCARR";
            this.LBLCARR.Size = new System.Drawing.Size(41, 13);
            this.LBLCARR.TabIndex = 4;
            this.LBLCARR.Text = "&Carrera";
            // 
            // TXTCARR
            // 
            this.TXTCARR.Location = new System.Drawing.Point(139, 104);
            this.TXTCARR.Name = "TXTCARR";
            this.TXTCARR.Size = new System.Drawing.Size(100, 20);
            this.TXTCARR.TabIndex = 5;
            // 
            // LBLSEM
            // 
            this.LBLSEM.AutoSize = true;
            this.LBLSEM.Location = new System.Drawing.Point(12, 154);
            this.LBLSEM.Name = "LBLSEM";
            this.LBLSEM.Size = new System.Drawing.Size(51, 13);
            this.LBLSEM.TabIndex = 6;
            this.LBLSEM.Text = "S&emestre";
            // 
            // TXTSEM
            // 
            this.TXTSEM.Location = new System.Drawing.Point(139, 151);
            this.TXTSEM.Name = "TXTSEM";
            this.TXTSEM.Size = new System.Drawing.Size(100, 20);
            this.TXTSEM.TabIndex = 7;
            // 
            // LBLPROM
            // 
            this.LBLPROM.AutoSize = true;
            this.LBLPROM.Location = new System.Drawing.Point(12, 204);
            this.LBLPROM.Name = "LBLPROM";
            this.LBLPROM.Size = new System.Drawing.Size(51, 13);
            this.LBLPROM.TabIndex = 8;
            this.LBLPROM.Text = "&Promedio";
            // 
            // TXTPROM
            // 
            this.TXTPROM.Location = new System.Drawing.Point(139, 197);
            this.TXTPROM.Name = "TXTPROM";
            this.TXTPROM.Size = new System.Drawing.Size(100, 20);
            this.TXTPROM.TabIndex = 9;
            // 
            // CMDELECCION
            // 
            this.CMDELECCION.Location = new System.Drawing.Point(396, 19);
            this.CMDELECCION.Name = "CMDELECCION";
            this.CMDELECCION.Size = new System.Drawing.Size(140, 34);
            this.CMDELECCION.TabIndex = 10;
            this.CMDELECCION.Text = "E&leccion";
            this.CMDELECCION.UseVisualStyleBackColor = true;
            this.CMDELECCION.Click += new System.EventHandler(this.CMDELECCION_Click);
            // 
            // CMDOTRO
            // 
            this.CMDOTRO.Location = new System.Drawing.Point(396, 86);
            this.CMDOTRO.Name = "CMDOTRO";
            this.CMDOTRO.Size = new System.Drawing.Size(140, 34);
            this.CMDOTRO.TabIndex = 11;
            this.CMDOTRO.Text = "&Limpiar";
            this.CMDOTRO.UseVisualStyleBackColor = true;
            this.CMDOTRO.Click += new System.EventHandler(this.CMDOTRO_Click);
            // 
            // CMDSALIDA
            // 
            this.CMDSALIDA.Location = new System.Drawing.Point(396, 154);
            this.CMDSALIDA.Name = "CMDSALIDA";
            this.CMDSALIDA.Size = new System.Drawing.Size(140, 34);
            this.CMDSALIDA.TabIndex = 12;
            this.CMDSALIDA.Text = "&Salida";
            this.CMDSALIDA.UseVisualStyleBackColor = true;
            this.CMDSALIDA.Click += new System.EventHandler(this.CMDSALIDA_Click);
            // 
            // LBLDESPLIEGUE
            // 
            this.LBLDESPLIEGUE.AutoSize = true;
            this.LBLDESPLIEGUE.Location = new System.Drawing.Point(393, 214);
            this.LBLDESPLIEGUE.Name = "LBLDESPLIEGUE";
            this.LBLDESPLIEGUE.Size = new System.Drawing.Size(0, 13);
            this.LBLDESPLIEGUE.TabIndex = 13;
            // 
            // FRMEJEMPLO7
            // 
            this.AcceptButton = this.CMDELECCION;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDSALIDA;
            this.ClientSize = new System.Drawing.Size(592, 311);
            this.Controls.Add(this.LBLDESPLIEGUE);
            this.Controls.Add(this.CMDSALIDA);
            this.Controls.Add(this.CMDOTRO);
            this.Controls.Add(this.CMDELECCION);
            this.Controls.Add(this.TXTPROM);
            this.Controls.Add(this.LBLPROM);
            this.Controls.Add(this.TXTSEM);
            this.Controls.Add(this.LBLSEM);
            this.Controls.Add(this.TXTCARR);
            this.Controls.Add(this.LBLCARR);
            this.Controls.Add(this.TXTNOM);
            this.Controls.Add(this.LBLNOM);
            this.Controls.Add(this.TXTNUMC);
            this.Controls.Add(this.LBLNUMC);
            this.Name = "FRMEJEMPLO7";
            this.Text = "Ejemplo 7";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLNUMC;
        private System.Windows.Forms.TextBox TXTNUMC;
        private System.Windows.Forms.Label LBLNOM;
        private System.Windows.Forms.TextBox TXTNOM;
        private System.Windows.Forms.Label LBLCARR;
        private System.Windows.Forms.TextBox TXTCARR;
        private System.Windows.Forms.Label LBLSEM;
        private System.Windows.Forms.TextBox TXTSEM;
        private System.Windows.Forms.Label LBLPROM;
        private System.Windows.Forms.TextBox TXTPROM;
        private System.Windows.Forms.Button CMDELECCION;
        private System.Windows.Forms.Button CMDOTRO;
        private System.Windows.Forms.Button CMDSALIDA;
        private System.Windows.Forms.Label LBLDESPLIEGUE;
    }
}

