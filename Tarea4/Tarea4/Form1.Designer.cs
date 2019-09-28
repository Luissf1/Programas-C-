namespace Tarea4
{
    partial class FRMNOM
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
            this.LBLNOM = new System.Windows.Forms.Label();
            this.TXTNOM = new System.Windows.Forms.TextBox();
            this.CMDNOM = new System.Windows.Forms.Button();
            this.CMDSALIDA = new System.Windows.Forms.Button();
            this.TXTNOMBRE = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LBLNOM
            // 
            this.LBLNOM.AutoSize = true;
            this.LBLNOM.Location = new System.Drawing.Point(314, 101);
            this.LBLNOM.Name = "LBLNOM";
            this.LBLNOM.Size = new System.Drawing.Size(47, 13);
            this.LBLNOM.TabIndex = 0;
            this.LBLNOM.Text = "Nombre:";
            // 
            // TXTNOM
            // 
            this.TXTNOM.Location = new System.Drawing.Point(292, 144);
            this.TXTNOM.Name = "TXTNOM";
            this.TXTNOM.Size = new System.Drawing.Size(100, 20);
            this.TXTNOM.TabIndex = 1;
            this.TXTNOM.TextChanged += new System.EventHandler(this.TXTNOM_TextChanged);
            // 
            // CMDNOM
            // 
            this.CMDNOM.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDNOM.Location = new System.Drawing.Point(241, 236);
            this.CMDNOM.Name = "CMDNOM";
            this.CMDNOM.Size = new System.Drawing.Size(75, 23);
            this.CMDNOM.TabIndex = 3;
            this.CMDNOM.Text = "&Nombre";
            this.CMDNOM.UseVisualStyleBackColor = true;
            this.CMDNOM.Click += new System.EventHandler(this.CMDNOM_Click);
            // 
            // CMDSALIDA
            // 
            this.CMDSALIDA.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDSALIDA.Location = new System.Drawing.Point(353, 236);
            this.CMDSALIDA.Name = "CMDSALIDA";
            this.CMDSALIDA.Size = new System.Drawing.Size(75, 23);
            this.CMDSALIDA.TabIndex = 4;
            this.CMDSALIDA.Text = "&Salida";
            this.CMDSALIDA.UseVisualStyleBackColor = true;
            this.CMDSALIDA.Click += new System.EventHandler(this.button2_Click);
            // 
            // TXTNOMBRE
            // 
            this.TXTNOMBRE.Location = new System.Drawing.Point(292, 194);
            this.TXTNOMBRE.Name = "TXTNOMBRE";
            this.TXTNOMBRE.ReadOnly = true;
            this.TXTNOMBRE.Size = new System.Drawing.Size(100, 20);
            this.TXTNOMBRE.TabIndex = 2;
            // 
            // FRMNOM
            // 
            this.AcceptButton = this.CMDNOM;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDSALIDA;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TXTNOMBRE);
            this.Controls.Add(this.CMDSALIDA);
            this.Controls.Add(this.CMDNOM);
            this.Controls.Add(this.TXTNOM);
            this.Controls.Add(this.LBLNOM);
            this.Name = "FRMNOM";
            this.Text = "Nombre de cuidad";
            this.Load += new System.EventHandler(this.FRMNOM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLNOM;
        private System.Windows.Forms.TextBox TXTNOM;
        private System.Windows.Forms.Button CMDNOM;
        private System.Windows.Forms.Button CMDSALIDA;
        private System.Windows.Forms.TextBox TXTNOMBRE;
    }
}

