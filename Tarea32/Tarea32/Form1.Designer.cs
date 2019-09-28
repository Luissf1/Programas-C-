namespace Tarea32
{
    partial class FRMMAYMEN
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
            this.TXTNUM = new System.Windows.Forms.TextBox();
            this.LBLADV = new System.Windows.Forms.Label();
            this.CMDCAPTURA = new System.Windows.Forms.Button();
            this.CMDOTRO = new System.Windows.Forms.Button();
            this.CMDSALIDA = new System.Windows.Forms.Button();
            this.TXTMAYMEN = new System.Windows.Forms.TextBox();
            this.LBLA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TXTNUM
            // 
            this.TXTNUM.Location = new System.Drawing.Point(21, 71);
            this.TXTNUM.Multiline = true;
            this.TXTNUM.Name = "TXTNUM";
            this.TXTNUM.ReadOnly = true;
            this.TXTNUM.Size = new System.Drawing.Size(137, 68);
            this.TXTNUM.TabIndex = 1;
            // 
            // LBLADV
            // 
            this.LBLADV.AutoSize = true;
            this.LBLADV.Location = new System.Drawing.Point(73, 32);
            this.LBLADV.Name = "LBLADV";
            this.LBLADV.Size = new System.Drawing.Size(42, 13);
            this.LBLADV.TabIndex = 0;
            this.LBLADV.Text = "Adivina";
            // 
            // CMDCAPTURA
            // 
            this.CMDCAPTURA.Location = new System.Drawing.Point(328, 27);
            this.CMDCAPTURA.Name = "CMDCAPTURA";
            this.CMDCAPTURA.Size = new System.Drawing.Size(75, 23);
            this.CMDCAPTURA.TabIndex = 3;
            this.CMDCAPTURA.Text = "&Captura";
            this.CMDCAPTURA.UseVisualStyleBackColor = true;
            this.CMDCAPTURA.Click += new System.EventHandler(this.Captura_Click);
            // 
            // CMDOTRO
            // 
            this.CMDOTRO.Location = new System.Drawing.Point(328, 69);
            this.CMDOTRO.Name = "CMDOTRO";
            this.CMDOTRO.Size = new System.Drawing.Size(75, 23);
            this.CMDOTRO.TabIndex = 4;
            this.CMDOTRO.Text = "&Clear";
            this.CMDOTRO.UseVisualStyleBackColor = true;
            this.CMDOTRO.Click += new System.EventHandler(this.CMDOTRO_Click);
            // 
            // CMDSALIDA
            // 
            this.CMDSALIDA.Location = new System.Drawing.Point(328, 116);
            this.CMDSALIDA.Name = "CMDSALIDA";
            this.CMDSALIDA.Size = new System.Drawing.Size(75, 23);
            this.CMDSALIDA.TabIndex = 5;
            this.CMDSALIDA.Text = "&Salida";
            this.CMDSALIDA.UseVisualStyleBackColor = true;
            this.CMDSALIDA.Click += new System.EventHandler(this.Salida_Click);
            // 
            // TXTMAYMEN
            // 
            this.TXTMAYMEN.Location = new System.Drawing.Point(164, 69);
            this.TXTMAYMEN.Multiline = true;
            this.TXTMAYMEN.Name = "TXTMAYMEN";
            this.TXTMAYMEN.Size = new System.Drawing.Size(137, 68);
            this.TXTMAYMEN.TabIndex = 2;
            // 
            // LBLA
            // 
            this.LBLA.AutoSize = true;
            this.LBLA.Location = new System.Drawing.Point(215, 53);
            this.LBLA.Name = "LBLA";
            this.LBLA.Size = new System.Drawing.Size(0, 13);
            this.LBLA.TabIndex = 6;
            // 
            // FRMMAYMEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 164);
            this.Controls.Add(this.LBLA);
            this.Controls.Add(this.TXTMAYMEN);
            this.Controls.Add(this.CMDSALIDA);
            this.Controls.Add(this.CMDOTRO);
            this.Controls.Add(this.CMDCAPTURA);
            this.Controls.Add(this.LBLADV);
            this.Controls.Add(this.TXTNUM);
            this.Name = "FRMMAYMEN";
            this.Text = "Adivina Numero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTNUM;
        private System.Windows.Forms.Label LBLADV;
        private System.Windows.Forms.Button CMDCAPTURA;
        private System.Windows.Forms.Button CMDOTRO;
        private System.Windows.Forms.Button CMDSALIDA;
        private System.Windows.Forms.TextBox TXTMAYMEN;
        private System.Windows.Forms.Label LBLA;
    }
}

