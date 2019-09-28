namespace Tarea40
{
    partial class FRMMED
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
            this.TXTMED = new System.Windows.Forms.TextBox();
            this.CMDMED = new System.Windows.Forms.Button();
            this.CMDOTRO = new System.Windows.Forms.Button();
            this.CMDSALIDA = new System.Windows.Forms.Button();
            this.TXTN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TXTMED
            // 
            this.TXTMED.Location = new System.Drawing.Point(37, 190);
            this.TXTMED.Name = "TXTMED";
            this.TXTMED.ReadOnly = true;
            this.TXTMED.Size = new System.Drawing.Size(180, 20);
            this.TXTMED.TabIndex = 1;
            // 
            // CMDMED
            // 
            this.CMDMED.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDMED.Location = new System.Drawing.Point(319, 37);
            this.CMDMED.Name = "CMDMED";
            this.CMDMED.Size = new System.Drawing.Size(111, 39);
            this.CMDMED.TabIndex = 2;
            this.CMDMED.Text = "&Captura";
            this.CMDMED.UseVisualStyleBackColor = true;
            this.CMDMED.Click += new System.EventHandler(this.CMDMED_Click);
            // 
            // CMDOTRO
            // 
            this.CMDOTRO.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDOTRO.Location = new System.Drawing.Point(319, 105);
            this.CMDOTRO.Name = "CMDOTRO";
            this.CMDOTRO.Size = new System.Drawing.Size(111, 39);
            this.CMDOTRO.TabIndex = 3;
            this.CMDOTRO.Text = "&Clear";
            this.CMDOTRO.UseVisualStyleBackColor = true;
            this.CMDOTRO.Click += new System.EventHandler(this.CMDOTRO_Click);
            // 
            // CMDSALIDA
            // 
            this.CMDSALIDA.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDSALIDA.Location = new System.Drawing.Point(319, 171);
            this.CMDSALIDA.Name = "CMDSALIDA";
            this.CMDSALIDA.Size = new System.Drawing.Size(111, 39);
            this.CMDSALIDA.TabIndex = 4;
            this.CMDSALIDA.Text = "&Salida";
            this.CMDSALIDA.UseVisualStyleBackColor = true;
            this.CMDSALIDA.Click += new System.EventHandler(this.CMDSALIDA_Click);
            // 
            // TXTN
            // 
            this.TXTN.Location = new System.Drawing.Point(28, 37);
            this.TXTN.Multiline = true;
            this.TXTN.Name = "TXTN";
            this.TXTN.ReadOnly = true;
            this.TXTN.Size = new System.Drawing.Size(246, 131);
            this.TXTN.TabIndex = 0;
            // 
            // FRMMED
            // 
            this.AcceptButton = this.CMDMED;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDSALIDA;
            this.ClientSize = new System.Drawing.Size(463, 251);
            this.Controls.Add(this.TXTN);
            this.Controls.Add(this.CMDSALIDA);
            this.Controls.Add(this.CMDOTRO);
            this.Controls.Add(this.CMDMED);
            this.Controls.Add(this.TXTMED);
            this.Name = "FRMMED";
            this.Text = "La mediana de 20 numeros";
            this.Load += new System.EventHandler(this.FRMMED_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TXTMED;
        private System.Windows.Forms.Button CMDMED;
        private System.Windows.Forms.Button CMDOTRO;
        private System.Windows.Forms.Button CMDSALIDA;
        private System.Windows.Forms.TextBox TXTN;
    }
}

