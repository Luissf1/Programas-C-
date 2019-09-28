namespace Ejemplo16
{
    partial class FRMEJEMPLO
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
            this.CMDOTRO = new System.Windows.Forms.Button();
            this.CMDSALIDA = new System.Windows.Forms.Button();
            this.CMDDESPLIEGUE = new System.Windows.Forms.Button();
            this.TXTNUM = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CMDOTRO
            // 
            this.CMDOTRO.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDOTRO.Location = new System.Drawing.Point(160, 144);
            this.CMDOTRO.Name = "CMDOTRO";
            this.CMDOTRO.Size = new System.Drawing.Size(118, 32);
            this.CMDOTRO.TabIndex = 3;
            this.CMDOTRO.Text = "&Clear";
            this.CMDOTRO.UseVisualStyleBackColor = true;
            this.CMDOTRO.Click += new System.EventHandler(this.CMDOTRO_Click);
            // 
            // CMDSALIDA
            // 
            this.CMDSALIDA.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDSALIDA.Location = new System.Drawing.Point(160, 87);
            this.CMDSALIDA.Name = "CMDSALIDA";
            this.CMDSALIDA.Size = new System.Drawing.Size(118, 35);
            this.CMDSALIDA.TabIndex = 2;
            this.CMDSALIDA.Text = "&Salida";
            this.CMDSALIDA.UseVisualStyleBackColor = true;
            this.CMDSALIDA.Click += new System.EventHandler(this.CMDSALIDA_Click);
            // 
            // CMDDESPLIEGUE
            // 
            this.CMDDESPLIEGUE.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDDESPLIEGUE.Location = new System.Drawing.Point(160, 32);
            this.CMDDESPLIEGUE.Name = "CMDDESPLIEGUE";
            this.CMDDESPLIEGUE.Size = new System.Drawing.Size(118, 35);
            this.CMDDESPLIEGUE.TabIndex = 1;
            this.CMDDESPLIEGUE.Text = "&1-10 For";
            this.CMDDESPLIEGUE.UseVisualStyleBackColor = true;
            this.CMDDESPLIEGUE.Click += new System.EventHandler(this.CMDDESPLIEGUE_Click);
            // 
            // TXTNUM
            // 
            this.TXTNUM.Location = new System.Drawing.Point(72, 40);
            this.TXTNUM.Multiline = true;
            this.TXTNUM.Name = "TXTNUM";
            this.TXTNUM.Size = new System.Drawing.Size(35, 157);
            this.TXTNUM.TabIndex = 0;
            this.TXTNUM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FRMEJEMPLO
            // 
            this.AcceptButton = this.CMDDESPLIEGUE;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDSALIDA;
            this.ClientSize = new System.Drawing.Size(375, 309);
            this.Controls.Add(this.CMDOTRO);
            this.Controls.Add(this.CMDSALIDA);
            this.Controls.Add(this.CMDDESPLIEGUE);
            this.Controls.Add(this.TXTNUM);
            this.Name = "FRMEJEMPLO";
            this.Text = "Ejemplo 16";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CMDOTRO;
        private System.Windows.Forms.Button CMDSALIDA;
        private System.Windows.Forms.Button CMDDESPLIEGUE;
        private System.Windows.Forms.TextBox TXTNUM;
    }
}

