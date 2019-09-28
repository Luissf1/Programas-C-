namespace Ejemplo20
{
    partial class FRMEJE
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
            this.LBLMATRIZ = new System.Windows.Forms.Label();
            this.TXTNUM1 = new System.Windows.Forms.TextBox();
            this.LBLNUMCAP = new System.Windows.Forms.Label();
            this.CMDCAPTURA = new System.Windows.Forms.Button();
            this.CMDINI = new System.Windows.Forms.Button();
            this.CMDDES = new System.Windows.Forms.Button();
            this.CMDNUEVCAP = new System.Windows.Forms.Button();
            this.CMDSALIDA = new System.Windows.Forms.Button();
            this.LBLTXT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TXTNUM
            // 
            this.TXTNUM.Location = new System.Drawing.Point(38, 65);
            this.TXTNUM.Name = "TXTNUM";
            this.TXTNUM.Size = new System.Drawing.Size(76, 20);
            this.TXTNUM.TabIndex = 0;
            // 
            // LBLMATRIZ
            // 
            this.LBLMATRIZ.AutoSize = true;
            this.LBLMATRIZ.Location = new System.Drawing.Point(35, 20);
            this.LBLMATRIZ.Name = "LBLMATRIZ";
            this.LBLMATRIZ.Size = new System.Drawing.Size(116, 13);
            this.LBLMATRIZ.TabIndex = 1;
            this.LBLMATRIZ.Text = "Matriz 5\'3 con nombres";
            // 
            // TXTNUM1
            // 
            this.TXTNUM1.Location = new System.Drawing.Point(38, 136);
            this.TXTNUM1.Multiline = true;
            this.TXTNUM1.Name = "TXTNUM1";
            this.TXTNUM1.ReadOnly = true;
            this.TXTNUM1.Size = new System.Drawing.Size(267, 115);
            this.TXTNUM1.TabIndex = 2;
            // 
            // LBLNUMCAP
            // 
            this.LBLNUMCAP.AutoSize = true;
            this.LBLNUMCAP.Location = new System.Drawing.Point(35, 105);
            this.LBLNUMCAP.Name = "LBLNUMCAP";
            this.LBLNUMCAP.Size = new System.Drawing.Size(108, 13);
            this.LBLNUMCAP.TabIndex = 3;
            this.LBLNUMCAP.Text = "Nombres capturados ";
            // 
            // CMDCAPTURA
            // 
            this.CMDCAPTURA.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDCAPTURA.Location = new System.Drawing.Point(360, 48);
            this.CMDCAPTURA.Name = "CMDCAPTURA";
            this.CMDCAPTURA.Size = new System.Drawing.Size(104, 25);
            this.CMDCAPTURA.TabIndex = 4;
            this.CMDCAPTURA.Text = "&Captura";
            this.CMDCAPTURA.UseVisualStyleBackColor = true;
            this.CMDCAPTURA.Click += new System.EventHandler(this.CMDCAPTURA_Click);
            // 
            // CMDINI
            // 
            this.CMDINI.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDINI.Location = new System.Drawing.Point(360, 93);
            this.CMDINI.Name = "CMDINI";
            this.CMDINI.Size = new System.Drawing.Size(104, 25);
            this.CMDINI.TabIndex = 5;
            this.CMDINI.Text = "&Inicializacion";
            this.CMDINI.UseVisualStyleBackColor = true;
            this.CMDINI.Click += new System.EventHandler(this.CMDINI_Click);
            // 
            // CMDDES
            // 
            this.CMDDES.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDDES.Location = new System.Drawing.Point(360, 136);
            this.CMDDES.Name = "CMDDES";
            this.CMDDES.Size = new System.Drawing.Size(104, 25);
            this.CMDDES.TabIndex = 6;
            this.CMDDES.Text = "&Despliegue";
            this.CMDDES.UseVisualStyleBackColor = true;
            this.CMDDES.Click += new System.EventHandler(this.CMDDES_Click);
            // 
            // CMDNUEVCAP
            // 
            this.CMDNUEVCAP.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDNUEVCAP.Location = new System.Drawing.Point(360, 180);
            this.CMDNUEVCAP.Name = "CMDNUEVCAP";
            this.CMDNUEVCAP.Size = new System.Drawing.Size(104, 25);
            this.CMDNUEVCAP.TabIndex = 7;
            this.CMDNUEVCAP.Text = "&Nueva captura";
            this.CMDNUEVCAP.UseVisualStyleBackColor = true;
            this.CMDNUEVCAP.Click += new System.EventHandler(this.CMDNUEVCAP_Click);
            // 
            // CMDSALIDA
            // 
            this.CMDSALIDA.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDSALIDA.Location = new System.Drawing.Point(360, 226);
            this.CMDSALIDA.Name = "CMDSALIDA";
            this.CMDSALIDA.Size = new System.Drawing.Size(104, 25);
            this.CMDSALIDA.TabIndex = 8;
            this.CMDSALIDA.Text = "&Salida";
            this.CMDSALIDA.UseVisualStyleBackColor = true;
            this.CMDSALIDA.Click += new System.EventHandler(this.CMDSALIDA_Click);
            // 
            // LBLTXT
            // 
            this.LBLTXT.AutoSize = true;
            this.LBLTXT.Location = new System.Drawing.Point(167, 105);
            this.LBLTXT.Name = "LBLTXT";
            this.LBLTXT.Size = new System.Drawing.Size(0, 13);
            this.LBLTXT.TabIndex = 10;
            // 
            // FRMEJE
            // 
            this.AcceptButton = this.CMDCAPTURA;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDSALIDA;
            this.ClientSize = new System.Drawing.Size(476, 274);
            this.Controls.Add(this.LBLTXT);
            this.Controls.Add(this.CMDSALIDA);
            this.Controls.Add(this.CMDNUEVCAP);
            this.Controls.Add(this.CMDDES);
            this.Controls.Add(this.CMDINI);
            this.Controls.Add(this.CMDCAPTURA);
            this.Controls.Add(this.LBLNUMCAP);
            this.Controls.Add(this.TXTNUM1);
            this.Controls.Add(this.LBLMATRIZ);
            this.Controls.Add(this.TXTNUM);
            this.Name = "FRMEJE";
            this.Text = "Ejemplo 20";
            this.Load += new System.EventHandler(this.FRMEJE_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTNUM;
        private System.Windows.Forms.Label LBLMATRIZ;
        private System.Windows.Forms.TextBox TXTNUM1;
        private System.Windows.Forms.Label LBLNUMCAP;
        private System.Windows.Forms.Button CMDCAPTURA;
        private System.Windows.Forms.Button CMDINI;
        private System.Windows.Forms.Button CMDDES;
        private System.Windows.Forms.Button CMDNUEVCAP;
        private System.Windows.Forms.Button CMDSALIDA;
        private System.Windows.Forms.Label LBLTXT;
    }
}

