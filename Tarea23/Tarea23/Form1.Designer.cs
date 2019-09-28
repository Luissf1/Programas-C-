namespace Tarea23
{
    partial class FRMTIEMPO
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
            this.LBLP1 = new System.Windows.Forms.Label();
            this.TXTP1 = new System.Windows.Forms.TextBox();
            this.LBLP2 = new System.Windows.Forms.Label();
            this.TXTP2 = new System.Windows.Forms.TextBox();
            this.LBLP3 = new System.Windows.Forms.Label();
            this.TXTP3 = new System.Windows.Forms.TextBox();
            this.LBLDESPLIEGUE = new System.Windows.Forms.Label();
            this.CMDTIEMPO = new System.Windows.Forms.Button();
            this.CMDOTRO = new System.Windows.Forms.Button();
            this.CMDSALIDA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLP1
            // 
            this.LBLP1.AutoSize = true;
            this.LBLP1.Location = new System.Drawing.Point(12, 36);
            this.LBLP1.Name = "LBLP1";
            this.LBLP1.Size = new System.Drawing.Size(88, 13);
            this.LBLP1.TabIndex = 0;
            this.LBLP1.Text = "Ingrese tiempo 1:";
            // 
            // TXTP1
            // 
            this.TXTP1.Location = new System.Drawing.Point(174, 29);
            this.TXTP1.Name = "TXTP1";
            this.TXTP1.Size = new System.Drawing.Size(100, 20);
            this.TXTP1.TabIndex = 1;
            // 
            // LBLP2
            // 
            this.LBLP2.AutoSize = true;
            this.LBLP2.Location = new System.Drawing.Point(12, 83);
            this.LBLP2.Name = "LBLP2";
            this.LBLP2.Size = new System.Drawing.Size(88, 13);
            this.LBLP2.TabIndex = 2;
            this.LBLP2.Text = "Ingrese tiempo 2:";
            // 
            // TXTP2
            // 
            this.TXTP2.Location = new System.Drawing.Point(174, 76);
            this.TXTP2.Name = "TXTP2";
            this.TXTP2.Size = new System.Drawing.Size(100, 20);
            this.TXTP2.TabIndex = 3;
            // 
            // LBLP3
            // 
            this.LBLP3.AutoSize = true;
            this.LBLP3.Location = new System.Drawing.Point(12, 136);
            this.LBLP3.Name = "LBLP3";
            this.LBLP3.Size = new System.Drawing.Size(88, 13);
            this.LBLP3.TabIndex = 4;
            this.LBLP3.Text = "Ingrese tiempo 3:";
            // 
            // TXTP3
            // 
            this.TXTP3.Location = new System.Drawing.Point(174, 136);
            this.TXTP3.Name = "TXTP3";
            this.TXTP3.Size = new System.Drawing.Size(100, 20);
            this.TXTP3.TabIndex = 5;
            // 
            // LBLDESPLIEGUE
            // 
            this.LBLDESPLIEGUE.AutoSize = true;
            this.LBLDESPLIEGUE.Location = new System.Drawing.Point(106, 202);
            this.LBLDESPLIEGUE.Name = "LBLDESPLIEGUE";
            this.LBLDESPLIEGUE.Size = new System.Drawing.Size(0, 13);
            this.LBLDESPLIEGUE.TabIndex = 6;
            // 
            // CMDTIEMPO
            // 
            this.CMDTIEMPO.Location = new System.Drawing.Point(353, 45);
            this.CMDTIEMPO.Name = "CMDTIEMPO";
            this.CMDTIEMPO.Size = new System.Drawing.Size(96, 31);
            this.CMDTIEMPO.TabIndex = 7;
            this.CMDTIEMPO.Text = "&Tiempo";
            this.CMDTIEMPO.UseVisualStyleBackColor = true;
            this.CMDTIEMPO.Click += new System.EventHandler(this.CMDTIEMPO_Click);
            // 
            // CMDOTRO
            // 
            this.CMDOTRO.Location = new System.Drawing.Point(353, 127);
            this.CMDOTRO.Name = "CMDOTRO";
            this.CMDOTRO.Size = new System.Drawing.Size(96, 31);
            this.CMDOTRO.TabIndex = 8;
            this.CMDOTRO.Text = "&Clear";
            this.CMDOTRO.UseVisualStyleBackColor = true;
            this.CMDOTRO.Click += new System.EventHandler(this.CMDOTRO_Click);
            // 
            // CMDSALIDA
            // 
            this.CMDSALIDA.Location = new System.Drawing.Point(353, 202);
            this.CMDSALIDA.Name = "CMDSALIDA";
            this.CMDSALIDA.Size = new System.Drawing.Size(96, 31);
            this.CMDSALIDA.TabIndex = 9;
            this.CMDSALIDA.Text = "&Salida";
            this.CMDSALIDA.UseVisualStyleBackColor = true;
            this.CMDSALIDA.Click += new System.EventHandler(this.CMDSALIDA_Click);
            // 
            // FRMTIEMPO
            // 
            this.AcceptButton = this.CMDTIEMPO;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDSALIDA;
            this.ClientSize = new System.Drawing.Size(497, 298);
            this.Controls.Add(this.CMDSALIDA);
            this.Controls.Add(this.CMDOTRO);
            this.Controls.Add(this.CMDTIEMPO);
            this.Controls.Add(this.LBLDESPLIEGUE);
            this.Controls.Add(this.TXTP3);
            this.Controls.Add(this.LBLP3);
            this.Controls.Add(this.TXTP2);
            this.Controls.Add(this.LBLP2);
            this.Controls.Add(this.TXTP1);
            this.Controls.Add(this.LBLP1);
            this.Name = "FRMTIEMPO";
            this.Text = "Determinacion de seleccion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLP1;
        private System.Windows.Forms.TextBox TXTP1;
        private System.Windows.Forms.Label LBLP2;
        private System.Windows.Forms.TextBox TXTP2;
        private System.Windows.Forms.Label LBLP3;
        private System.Windows.Forms.TextBox TXTP3;
        private System.Windows.Forms.Label LBLDESPLIEGUE;
        private System.Windows.Forms.Button CMDTIEMPO;
        private System.Windows.Forms.Button CMDOTRO;
        private System.Windows.Forms.Button CMDSALIDA;
    }
}

