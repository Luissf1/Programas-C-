namespace Tarea24
{
    partial class FRMEDAD
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
            this.LBLEDAD = new System.Windows.Forms.Label();
            this.TXTEDAD = new System.Windows.Forms.TextBox();
            this.LBLDESPLIEGUE = new System.Windows.Forms.Label();
            this.CMDEDAD = new System.Windows.Forms.Button();
            this.CMDOTRO = new System.Windows.Forms.Button();
            this.CMDSALIDA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLEDAD
            // 
            this.LBLEDAD.AutoSize = true;
            this.LBLEDAD.Location = new System.Drawing.Point(12, 15);
            this.LBLEDAD.Name = "LBLEDAD";
            this.LBLEDAD.Size = new System.Drawing.Size(86, 13);
            this.LBLEDAD.TabIndex = 0;
            this.LBLEDAD.Text = "Ingrese su edad:";
            // 
            // TXTEDAD
            // 
            this.TXTEDAD.Location = new System.Drawing.Point(118, 12);
            this.TXTEDAD.Name = "TXTEDAD";
            this.TXTEDAD.Size = new System.Drawing.Size(100, 20);
            this.TXTEDAD.TabIndex = 1;
            // 
            // LBLDESPLIEGUE
            // 
            this.LBLDESPLIEGUE.AutoSize = true;
            this.LBLDESPLIEGUE.Location = new System.Drawing.Point(69, 85);
            this.LBLDESPLIEGUE.Name = "LBLDESPLIEGUE";
            this.LBLDESPLIEGUE.Size = new System.Drawing.Size(0, 13);
            this.LBLDESPLIEGUE.TabIndex = 2;
            // 
            // CMDEDAD
            // 
            this.CMDEDAD.Location = new System.Drawing.Point(296, 24);
            this.CMDEDAD.Name = "CMDEDAD";
            this.CMDEDAD.Size = new System.Drawing.Size(96, 34);
            this.CMDEDAD.TabIndex = 3;
            this.CMDEDAD.Text = "&Edad";
            this.CMDEDAD.UseVisualStyleBackColor = true;
            this.CMDEDAD.Click += new System.EventHandler(this.CMDEDAD_Click);
            // 
            // CMDOTRO
            // 
            this.CMDOTRO.Location = new System.Drawing.Point(296, 85);
            this.CMDOTRO.Name = "CMDOTRO";
            this.CMDOTRO.Size = new System.Drawing.Size(96, 34);
            this.CMDOTRO.TabIndex = 4;
            this.CMDOTRO.Text = "&Clear";
            this.CMDOTRO.UseVisualStyleBackColor = true;
            this.CMDOTRO.Click += new System.EventHandler(this.CMDOTRO_Click);
            // 
            // CMDSALIDA
            // 
            this.CMDSALIDA.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDSALIDA.Location = new System.Drawing.Point(296, 150);
            this.CMDSALIDA.Name = "CMDSALIDA";
            this.CMDSALIDA.Size = new System.Drawing.Size(96, 34);
            this.CMDSALIDA.TabIndex = 5;
            this.CMDSALIDA.Text = "&Salida";
            this.CMDSALIDA.UseVisualStyleBackColor = true;
            this.CMDSALIDA.Click += new System.EventHandler(this.CMDSALIDA_Click);
            // 
            // FRMEDAD
            // 
            this.AcceptButton = this.CMDEDAD;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDSALIDA;
            this.ClientSize = new System.Drawing.Size(432, 216);
            this.Controls.Add(this.CMDSALIDA);
            this.Controls.Add(this.CMDOTRO);
            this.Controls.Add(this.CMDEDAD);
            this.Controls.Add(this.LBLDESPLIEGUE);
            this.Controls.Add(this.TXTEDAD);
            this.Controls.Add(this.LBLEDAD);
            this.Name = "FRMEDAD";
            this.Text = "Clasificacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLEDAD;
        private System.Windows.Forms.TextBox TXTEDAD;
        private System.Windows.Forms.Label LBLDESPLIEGUE;
        private System.Windows.Forms.Button CMDEDAD;
        private System.Windows.Forms.Button CMDOTRO;
        private System.Windows.Forms.Button CMDSALIDA;
    }
}

