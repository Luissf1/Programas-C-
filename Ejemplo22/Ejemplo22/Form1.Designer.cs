namespace Ejemplo22
{
    partial class TXTEJE
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
            this.LBLNC = new System.Windows.Forms.Label();
            this.TXTNC = new System.Windows.Forms.TextBox();
            this.LBLNOM = new System.Windows.Forms.Label();
            this.TXTNOM = new System.Windows.Forms.TextBox();
            this.LBLCARR = new System.Windows.Forms.Label();
            this.TXTCARR = new System.Windows.Forms.TextBox();
            this.LBLSEME = new System.Windows.Forms.Label();
            this.TXTSEME = new System.Windows.Forms.TextBox();
            this.CMDDES = new System.Windows.Forms.Button();
            this.CMDSALIDA = new System.Windows.Forms.Button();
            this.CMDOTRO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLNC
            // 
            this.LBLNC.AutoSize = true;
            this.LBLNC.Location = new System.Drawing.Point(63, 81);
            this.LBLNC.Name = "LBLNC";
            this.LBLNC.Size = new System.Drawing.Size(97, 13);
            this.LBLNC.TabIndex = 0;
            this.LBLNC.Text = "Numero de control:";
            // 
            // TXTNC
            // 
            this.TXTNC.Location = new System.Drawing.Point(225, 81);
            this.TXTNC.Name = "TXTNC";
            this.TXTNC.ReadOnly = true;
            this.TXTNC.Size = new System.Drawing.Size(187, 20);
            this.TXTNC.TabIndex = 1;
            // 
            // LBLNOM
            // 
            this.LBLNOM.AutoSize = true;
            this.LBLNOM.Location = new System.Drawing.Point(63, 147);
            this.LBLNOM.Name = "LBLNOM";
            this.LBLNOM.Size = new System.Drawing.Size(47, 13);
            this.LBLNOM.TabIndex = 2;
            this.LBLNOM.Text = "Nombre:";
            // 
            // TXTNOM
            // 
            this.TXTNOM.Location = new System.Drawing.Point(225, 140);
            this.TXTNOM.Name = "TXTNOM";
            this.TXTNOM.ReadOnly = true;
            this.TXTNOM.Size = new System.Drawing.Size(187, 20);
            this.TXTNOM.TabIndex = 3;
            // 
            // LBLCARR
            // 
            this.LBLCARR.AutoSize = true;
            this.LBLCARR.Location = new System.Drawing.Point(63, 214);
            this.LBLCARR.Name = "LBLCARR";
            this.LBLCARR.Size = new System.Drawing.Size(44, 13);
            this.LBLCARR.TabIndex = 4;
            this.LBLCARR.Text = "Carrera:";
            // 
            // TXTCARR
            // 
            this.TXTCARR.Location = new System.Drawing.Point(225, 211);
            this.TXTCARR.Name = "TXTCARR";
            this.TXTCARR.ReadOnly = true;
            this.TXTCARR.Size = new System.Drawing.Size(187, 20);
            this.TXTCARR.TabIndex = 5;
            // 
            // LBLSEME
            // 
            this.LBLSEME.AutoSize = true;
            this.LBLSEME.Location = new System.Drawing.Point(63, 283);
            this.LBLSEME.Name = "LBLSEME";
            this.LBLSEME.Size = new System.Drawing.Size(54, 13);
            this.LBLSEME.TabIndex = 6;
            this.LBLSEME.Text = "Semestre:";
            // 
            // TXTSEME
            // 
            this.TXTSEME.Location = new System.Drawing.Point(225, 276);
            this.TXTSEME.Name = "TXTSEME";
            this.TXTSEME.ReadOnly = true;
            this.TXTSEME.Size = new System.Drawing.Size(187, 20);
            this.TXTSEME.TabIndex = 7;
            // 
            // CMDDES
            // 
            this.CMDDES.Location = new System.Drawing.Point(75, 334);
            this.CMDDES.Name = "CMDDES";
            this.CMDDES.Size = new System.Drawing.Size(108, 23);
            this.CMDDES.TabIndex = 8;
            this.CMDDES.Text = "&Despliegue";
            this.CMDDES.UseVisualStyleBackColor = true;
            this.CMDDES.Click += new System.EventHandler(this.CMDDES_Click);
            // 
            // CMDSALIDA
            // 
            this.CMDSALIDA.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDSALIDA.Location = new System.Drawing.Point(225, 334);
            this.CMDSALIDA.Name = "CMDSALIDA";
            this.CMDSALIDA.Size = new System.Drawing.Size(116, 23);
            this.CMDSALIDA.TabIndex = 9;
            this.CMDSALIDA.Text = "&Salida";
            this.CMDSALIDA.UseVisualStyleBackColor = true;
            this.CMDSALIDA.Click += new System.EventHandler(this.CMDSALIDA_Click);
            // 
            // CMDOTRO
            // 
            this.CMDOTRO.Location = new System.Drawing.Point(380, 334);
            this.CMDOTRO.Name = "CMDOTRO";
            this.CMDOTRO.Size = new System.Drawing.Size(116, 23);
            this.CMDOTRO.TabIndex = 10;
            this.CMDOTRO.Text = "&Clear";
            this.CMDOTRO.UseVisualStyleBackColor = true;
            this.CMDOTRO.Click += new System.EventHandler(this.CMDOTRO_Click);
            // 
            // TXTEJE
            // 
            this.AcceptButton = this.CMDDES;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDSALIDA;
            this.ClientSize = new System.Drawing.Size(552, 386);
            this.Controls.Add(this.CMDOTRO);
            this.Controls.Add(this.CMDSALIDA);
            this.Controls.Add(this.CMDDES);
            this.Controls.Add(this.TXTSEME);
            this.Controls.Add(this.LBLSEME);
            this.Controls.Add(this.TXTCARR);
            this.Controls.Add(this.LBLCARR);
            this.Controls.Add(this.TXTNOM);
            this.Controls.Add(this.LBLNOM);
            this.Controls.Add(this.TXTNC);
            this.Controls.Add(this.LBLNC);
            this.Name = "TXTEJE";
            this.Text = "Ejemplo 22";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLNC;
        private System.Windows.Forms.TextBox TXTNC;
        private System.Windows.Forms.Label LBLNOM;
        private System.Windows.Forms.TextBox TXTNOM;
        private System.Windows.Forms.Label LBLCARR;
        private System.Windows.Forms.TextBox TXTCARR;
        private System.Windows.Forms.Label LBLSEME;
        private System.Windows.Forms.TextBox TXTSEME;
        private System.Windows.Forms.Button CMDDES;
        private System.Windows.Forms.Button CMDSALIDA;
        private System.Windows.Forms.Button CMDOTRO;
    }
}

