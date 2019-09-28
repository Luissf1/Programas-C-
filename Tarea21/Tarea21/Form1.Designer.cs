namespace Tarea21
{
    partial class FRMPOSITIVO
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
            this.LBLPOSNEG = new System.Windows.Forms.Label();
            this.CMDNUM = new System.Windows.Forms.Button();
            this.CMDSALIDA = new System.Windows.Forms.Button();
            this.CMDOTRO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLNUM
            // 
            this.LBLNUM.AutoSize = true;
            this.LBLNUM.Location = new System.Drawing.Point(139, 29);
            this.LBLNUM.Name = "LBLNUM";
            this.LBLNUM.Size = new System.Drawing.Size(83, 13);
            this.LBLNUM.TabIndex = 0;
            this.LBLNUM.Text = "Ingrese numero:";
            // 
            // TXTNUM
            // 
            this.TXTNUM.Location = new System.Drawing.Point(131, 58);
            this.TXTNUM.Name = "TXTNUM";
            this.TXTNUM.Size = new System.Drawing.Size(100, 20);
            this.TXTNUM.TabIndex = 1;
            // 
            // LBLPOSNEG
            // 
            this.LBLPOSNEG.AutoSize = true;
            this.LBLPOSNEG.Location = new System.Drawing.Point(139, 105);
            this.LBLPOSNEG.Name = "LBLPOSNEG";
            this.LBLPOSNEG.Size = new System.Drawing.Size(0, 13);
            this.LBLPOSNEG.TabIndex = 2;
            // 
            // CMDNUM
            // 
            this.CMDNUM.Location = new System.Drawing.Point(142, 142);
            this.CMDNUM.Name = "CMDNUM";
            this.CMDNUM.Size = new System.Drawing.Size(75, 23);
            this.CMDNUM.TabIndex = 3;
            this.CMDNUM.Text = "&Numero ";
            this.CMDNUM.UseVisualStyleBackColor = true;
            this.CMDNUM.Click += new System.EventHandler(this.CMDNUM_Click);
            // 
            // CMDSALIDA
            // 
            this.CMDSALIDA.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDSALIDA.Location = new System.Drawing.Point(142, 186);
            this.CMDSALIDA.Name = "CMDSALIDA";
            this.CMDSALIDA.Size = new System.Drawing.Size(75, 23);
            this.CMDSALIDA.TabIndex = 4;
            this.CMDSALIDA.Text = "&Salida";
            this.CMDSALIDA.UseVisualStyleBackColor = true;
            this.CMDSALIDA.Click += new System.EventHandler(this.CMDSALIDA_Click);
            // 
            // CMDOTRO
            // 
            this.CMDOTRO.Location = new System.Drawing.Point(142, 224);
            this.CMDOTRO.Name = "CMDOTRO";
            this.CMDOTRO.Size = new System.Drawing.Size(75, 23);
            this.CMDOTRO.TabIndex = 5;
            this.CMDOTRO.Text = "&Clear";
            this.CMDOTRO.UseVisualStyleBackColor = true;
            this.CMDOTRO.Click += new System.EventHandler(this.CMDOTRO_Click);
            // 
            // FRMPOSITIVO
            // 
            this.AcceptButton = this.CMDNUM;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDSALIDA;
            this.ClientSize = new System.Drawing.Size(418, 288);
            this.Controls.Add(this.CMDOTRO);
            this.Controls.Add(this.CMDSALIDA);
            this.Controls.Add(this.CMDNUM);
            this.Controls.Add(this.LBLPOSNEG);
            this.Controls.Add(this.TXTNUM);
            this.Controls.Add(this.LBLNUM);
            this.Name = "FRMPOSITIVO";
            this.Text = "Numero positivo o negativo ";
            this.Load += new System.EventHandler(this.FRMPOSITIVO_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLNUM;
        private System.Windows.Forms.TextBox TXTNUM;
        private System.Windows.Forms.Label LBLPOSNEG;
        private System.Windows.Forms.Button CMDNUM;
        private System.Windows.Forms.Button CMDSALIDA;
        private System.Windows.Forms.Button CMDOTRO;
    }
}

