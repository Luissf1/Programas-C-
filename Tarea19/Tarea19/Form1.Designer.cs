namespace Tarea19
{
    partial class FRMNUMPAR
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
            this.LBLNUM = new System.Windows.Forms.Label();
            this.TXTNUM = new System.Windows.Forms.TextBox();
            this.LBLPAROIMPAR = new System.Windows.Forms.Label();
            this.CMDPAR = new System.Windows.Forms.Button();
            this.CMDSALIDA = new System.Windows.Forms.Button();
            this.CMDOTRO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLNUM
            // 
            this.LBLNUM.AutoSize = true;
            this.LBLNUM.Location = new System.Drawing.Point(60, 67);
            this.LBLNUM.Name = "LBLNUM";
            this.LBLNUM.Size = new System.Drawing.Size(86, 13);
            this.LBLNUM.TabIndex = 0;
            this.LBLNUM.Text = "Ingrese numero :";
            // 
            // TXTNUM
            // 
            this.TXTNUM.Location = new System.Drawing.Point(187, 64);
            this.TXTNUM.Name = "TXTNUM";
            this.TXTNUM.Size = new System.Drawing.Size(100, 20);
            this.TXTNUM.TabIndex = 1;
            // 
            // LBLPAROIMPAR
            // 
            this.LBLPAROIMPAR.AutoSize = true;
            this.LBLPAROIMPAR.Location = new System.Drawing.Point(154, 128);
            this.LBLPAROIMPAR.Name = "LBLPAROIMPAR";
            this.LBLPAROIMPAR.Size = new System.Drawing.Size(0, 13);
            this.LBLPAROIMPAR.TabIndex = 2;
            // 
            // CMDPAR
            // 
            this.CMDPAR.Location = new System.Drawing.Point(43, 172);
            this.CMDPAR.Name = "CMDPAR";
            this.CMDPAR.Size = new System.Drawing.Size(103, 41);
            this.CMDPAR.TabIndex = 3;
            this.CMDPAR.Text = "&Par o Impar";
            this.CMDPAR.UseVisualStyleBackColor = true;
            this.CMDPAR.Click += new System.EventHandler(this.CMDPAR_Click);
            // 
            // CMDSALIDA
            // 
            this.CMDSALIDA.Location = new System.Drawing.Point(157, 172);
            this.CMDSALIDA.Name = "CMDSALIDA";
            this.CMDSALIDA.Size = new System.Drawing.Size(103, 41);
            this.CMDSALIDA.TabIndex = 4;
            this.CMDSALIDA.Text = "&Salida";
            this.CMDSALIDA.UseVisualStyleBackColor = true;
            this.CMDSALIDA.Click += new System.EventHandler(this.CMDSALIDA_Click);
            // 
            // CMDOTRO
            // 
            this.CMDOTRO.Location = new System.Drawing.Point(276, 172);
            this.CMDOTRO.Name = "CMDOTRO";
            this.CMDOTRO.Size = new System.Drawing.Size(103, 41);
            this.CMDOTRO.TabIndex = 5;
            this.CMDOTRO.Text = "&Clear";
            this.CMDOTRO.UseVisualStyleBackColor = true;
            this.CMDOTRO.Click += new System.EventHandler(this.CMDOTRO_Click);
            // 
            // FRMNUMPAR
            // 
            this.AcceptButton = this.CMDPAR;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDSALIDA;
            this.ClientSize = new System.Drawing.Size(388, 232);
            this.Controls.Add(this.CMDOTRO);
            this.Controls.Add(this.CMDSALIDA);
            this.Controls.Add(this.CMDPAR);
            this.Controls.Add(this.LBLPAROIMPAR);
            this.Controls.Add(this.TXTNUM);
            this.Controls.Add(this.LBLNUM);
            this.Name = "FRMNUMPAR";
            this.Text = "Par o impar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLNUM;
        private System.Windows.Forms.TextBox TXTNUM;
        private System.Windows.Forms.Label LBLPAROIMPAR;
        private System.Windows.Forms.Button CMDPAR;
        private System.Windows.Forms.Button CMDSALIDA;
        private System.Windows.Forms.Button CMDOTRO;
    }
}

