namespace Tarea39
{
    partial class FRMMAY
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
            this.LBL = new System.Windows.Forms.Label();
            this.TXTNUM = new System.Windows.Forms.TextBox();
            this.TXTMAY = new System.Windows.Forms.TextBox();
            this.CMDCAPTURA = new System.Windows.Forms.Button();
            this.CMDOTRO = new System.Windows.Forms.Button();
            this.CMDSALIDA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL
            // 
            this.LBL.AutoSize = true;
            this.LBL.Location = new System.Drawing.Point(87, 38);
            this.LBL.Name = "LBL";
            this.LBL.Size = new System.Drawing.Size(108, 13);
            this.LBL.TabIndex = 0;
            this.LBL.Text = "Numeros capturados ";
            // 
            // TXTNUM
            // 
            this.TXTNUM.Location = new System.Drawing.Point(90, 92);
            this.TXTNUM.Multiline = true;
            this.TXTNUM.Name = "TXTNUM";
            this.TXTNUM.Size = new System.Drawing.Size(105, 127);
            this.TXTNUM.TabIndex = 1;
            // 
            // TXTMAY
            // 
            this.TXTMAY.Location = new System.Drawing.Point(54, 254);
            this.TXTMAY.Name = "TXTMAY";
            this.TXTMAY.Size = new System.Drawing.Size(173, 20);
            this.TXTMAY.TabIndex = 2;
            // 
            // CMDCAPTURA
            // 
            this.CMDCAPTURA.Location = new System.Drawing.Point(301, 90);
            this.CMDCAPTURA.Name = "CMDCAPTURA";
            this.CMDCAPTURA.Size = new System.Drawing.Size(89, 42);
            this.CMDCAPTURA.TabIndex = 3;
            this.CMDCAPTURA.Text = "&Captura";
            this.CMDCAPTURA.UseVisualStyleBackColor = true;
            this.CMDCAPTURA.Click += new System.EventHandler(this.CMDCAPTURA_Click);
            // 
            // CMDOTRO
            // 
            this.CMDOTRO.Location = new System.Drawing.Point(301, 162);
            this.CMDOTRO.Name = "CMDOTRO";
            this.CMDOTRO.Size = new System.Drawing.Size(89, 42);
            this.CMDOTRO.TabIndex = 4;
            this.CMDOTRO.Text = "&Clear";
            this.CMDOTRO.UseVisualStyleBackColor = true;
            this.CMDOTRO.Click += new System.EventHandler(this.CMDOTRO_Click);
            // 
            // CMDSALIDA
            // 
            this.CMDSALIDA.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDSALIDA.Location = new System.Drawing.Point(301, 242);
            this.CMDSALIDA.Name = "CMDSALIDA";
            this.CMDSALIDA.Size = new System.Drawing.Size(89, 42);
            this.CMDSALIDA.TabIndex = 5;
            this.CMDSALIDA.Text = "&Salida";
            this.CMDSALIDA.UseVisualStyleBackColor = true;
            // 
            // FRMMAY
            // 
            this.AcceptButton = this.CMDCAPTURA;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDSALIDA;
            this.ClientSize = new System.Drawing.Size(472, 313);
            this.Controls.Add(this.CMDSALIDA);
            this.Controls.Add(this.CMDOTRO);
            this.Controls.Add(this.CMDCAPTURA);
            this.Controls.Add(this.TXTMAY);
            this.Controls.Add(this.TXTNUM);
            this.Controls.Add(this.LBL);
            this.Name = "FRMMAY";
            this.Text = "Mayor de 15 numeros";
            this.Load += new System.EventHandler(this.FRMMAY_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL;
        private System.Windows.Forms.TextBox TXTNUM;
        private System.Windows.Forms.TextBox TXTMAY;
        private System.Windows.Forms.Button CMDCAPTURA;
        private System.Windows.Forms.Button CMDOTRO;
        private System.Windows.Forms.Button CMDSALIDA;
    }
}

