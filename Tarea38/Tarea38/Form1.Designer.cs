namespace Tarea38
{
    partial class FRMCAL
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
            this.TXTNUM1 = new System.Windows.Forms.TextBox();
            this.TXTMED = new System.Windows.Forms.TextBox();
            this.TXTMENOR = new System.Windows.Forms.TextBox();
            this.CMDCAL = new System.Windows.Forms.Button();
            this.CMDOTRO = new System.Windows.Forms.Button();
            this.CMDSALIDA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TXTNUM1
            // 
            this.TXTNUM1.Location = new System.Drawing.Point(12, 34);
            this.TXTNUM1.Multiline = true;
            this.TXTNUM1.Name = "TXTNUM1";
            this.TXTNUM1.Size = new System.Drawing.Size(296, 106);
            this.TXTNUM1.TabIndex = 0;
            // 
            // TXTMED
            // 
            this.TXTMED.Location = new System.Drawing.Point(27, 158);
            this.TXTMED.Name = "TXTMED";
            this.TXTMED.Size = new System.Drawing.Size(197, 20);
            this.TXTMED.TabIndex = 1;
            // 
            // TXTMENOR
            // 
            this.TXTMENOR.Location = new System.Drawing.Point(27, 191);
            this.TXTMENOR.Name = "TXTMENOR";
            this.TXTMENOR.Size = new System.Drawing.Size(197, 20);
            this.TXTMENOR.TabIndex = 2;
            // 
            // CMDCAL
            // 
            this.CMDCAL.Location = new System.Drawing.Point(352, 34);
            this.CMDCAL.Name = "CMDCAL";
            this.CMDCAL.Size = new System.Drawing.Size(113, 41);
            this.CMDCAL.TabIndex = 3;
            this.CMDCAL.Text = "Calificacion";
            this.CMDCAL.UseVisualStyleBackColor = true;
            this.CMDCAL.Click += new System.EventHandler(this.CMDCAL_Click);
            // 
            // CMDOTRO
            // 
            this.CMDOTRO.Location = new System.Drawing.Point(352, 95);
            this.CMDOTRO.Name = "CMDOTRO";
            this.CMDOTRO.Size = new System.Drawing.Size(113, 41);
            this.CMDOTRO.TabIndex = 4;
            this.CMDOTRO.Text = "&Clear";
            this.CMDOTRO.UseVisualStyleBackColor = true;
            this.CMDOTRO.Click += new System.EventHandler(this.CMDOTRO_Click);
            // 
            // CMDSALIDA
            // 
            this.CMDSALIDA.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDSALIDA.Location = new System.Drawing.Point(352, 158);
            this.CMDSALIDA.Name = "CMDSALIDA";
            this.CMDSALIDA.Size = new System.Drawing.Size(113, 41);
            this.CMDSALIDA.TabIndex = 5;
            this.CMDSALIDA.Text = "&Salida";
            this.CMDSALIDA.UseVisualStyleBackColor = true;
            this.CMDSALIDA.Click += new System.EventHandler(this.CMDSALIDA_Click);
            // 
            // FRMCAL
            // 
            this.AcceptButton = this.CMDCAL;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDSALIDA;
            this.ClientSize = new System.Drawing.Size(529, 223);
            this.Controls.Add(this.CMDSALIDA);
            this.Controls.Add(this.CMDOTRO);
            this.Controls.Add(this.CMDCAL);
            this.Controls.Add(this.TXTMENOR);
            this.Controls.Add(this.TXTMED);
            this.Controls.Add(this.TXTNUM1);
            this.Name = "FRMCAL";
            this.Text = "Calificacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TXTNUM1;
        private System.Windows.Forms.TextBox TXTMED;
        private System.Windows.Forms.TextBox TXTMENOR;
        private System.Windows.Forms.Button CMDCAL;
        private System.Windows.Forms.Button CMDOTRO;
        private System.Windows.Forms.Button CMDSALIDA;
    }
}

