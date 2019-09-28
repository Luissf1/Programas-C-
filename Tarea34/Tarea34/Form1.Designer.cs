namespace Tarea34
{
    partial class FRMSALDO
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
            this.TXTSALDO = new System.Windows.Forms.TextBox();
            this.TXTRES = new System.Windows.Forms.TextBox();
            this.CMDGASTO = new System.Windows.Forms.Button();
            this.CMDOTRO = new System.Windows.Forms.Button();
            this.CMDSALIDA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TXTSALDO
            // 
            this.TXTSALDO.Location = new System.Drawing.Point(26, 18);
            this.TXTSALDO.Multiline = true;
            this.TXTSALDO.Name = "TXTSALDO";
            this.TXTSALDO.ReadOnly = true;
            this.TXTSALDO.Size = new System.Drawing.Size(173, 137);
            this.TXTSALDO.TabIndex = 0;
            this.TXTSALDO.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TXTRES
            // 
            this.TXTRES.Location = new System.Drawing.Point(219, 18);
            this.TXTRES.Multiline = true;
            this.TXTRES.Name = "TXTRES";
            this.TXTRES.ReadOnly = true;
            this.TXTRES.Size = new System.Drawing.Size(163, 137);
            this.TXTRES.TabIndex = 1;
            // 
            // CMDGASTO
            // 
            this.CMDGASTO.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDGASTO.Location = new System.Drawing.Point(408, 18);
            this.CMDGASTO.Name = "CMDGASTO";
            this.CMDGASTO.Size = new System.Drawing.Size(106, 36);
            this.CMDGASTO.TabIndex = 3;
            this.CMDGASTO.Text = "&Gastos";
            this.CMDGASTO.UseVisualStyleBackColor = true;
            this.CMDGASTO.Click += new System.EventHandler(this.CMDGASTO_Click);
            // 
            // CMDOTRO
            // 
            this.CMDOTRO.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDOTRO.Location = new System.Drawing.Point(408, 80);
            this.CMDOTRO.Name = "CMDOTRO";
            this.CMDOTRO.Size = new System.Drawing.Size(106, 36);
            this.CMDOTRO.TabIndex = 4;
            this.CMDOTRO.Text = "&Clear";
            this.CMDOTRO.UseVisualStyleBackColor = true;
            this.CMDOTRO.Click += new System.EventHandler(this.CMDOTRO_Click);
            // 
            // CMDSALIDA
            // 
            this.CMDSALIDA.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDSALIDA.Location = new System.Drawing.Point(408, 135);
            this.CMDSALIDA.Name = "CMDSALIDA";
            this.CMDSALIDA.Size = new System.Drawing.Size(106, 36);
            this.CMDSALIDA.TabIndex = 5;
            this.CMDSALIDA.Text = "&Salida";
            this.CMDSALIDA.UseVisualStyleBackColor = true;
            this.CMDSALIDA.Click += new System.EventHandler(this.button3_Click);
            // 
            // FRMSALDO
            // 
            this.AcceptButton = this.CMDGASTO;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDSALIDA;
            this.ClientSize = new System.Drawing.Size(547, 197);
            this.Controls.Add(this.CMDSALIDA);
            this.Controls.Add(this.CMDOTRO);
            this.Controls.Add(this.CMDGASTO);
            this.Controls.Add(this.TXTRES);
            this.Controls.Add(this.TXTSALDO);
            this.Name = "FRMSALDO";
            this.Text = "Compras con 1000";
            this.Load += new System.EventHandler(this.FRMSALDO_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TXTSALDO;
        private System.Windows.Forms.TextBox TXTRES;
        private System.Windows.Forms.Button CMDGASTO;
        private System.Windows.Forms.Button CMDOTRO;
        private System.Windows.Forms.Button CMDSALIDA;
    }
}

