namespace Tarea10
{
    partial class FRMNOMS
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
            this.TXTNOMBRE = new System.Windows.Forms.TextBox();
            this.CMDSALIDA = new System.Windows.Forms.Button();
            this.CMDNOM = new System.Windows.Forms.Button();
            this.LBLNOM = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TXTNOMBRE
            // 
            this.TXTNOMBRE.Location = new System.Drawing.Point(330, 204);
            this.TXTNOMBRE.Name = "TXTNOMBRE";
            this.TXTNOMBRE.ReadOnly = true;
            this.TXTNOMBRE.Size = new System.Drawing.Size(149, 20);
            this.TXTNOMBRE.TabIndex = 1;
            // 
            // CMDSALIDA
            // 
            this.CMDSALIDA.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDSALIDA.Location = new System.Drawing.Point(419, 281);
            this.CMDSALIDA.Name = "CMDSALIDA";
            this.CMDSALIDA.Size = new System.Drawing.Size(75, 23);
            this.CMDSALIDA.TabIndex = 3;
            this.CMDSALIDA.Text = "&Salida";
            this.CMDSALIDA.UseVisualStyleBackColor = true;
            this.CMDSALIDA.Click += new System.EventHandler(this.button2_Click);
            // 
            // CMDNOM
            // 
            this.CMDNOM.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDNOM.Location = new System.Drawing.Point(307, 281);
            this.CMDNOM.Name = "CMDNOM";
            this.CMDNOM.Size = new System.Drawing.Size(75, 23);
            this.CMDNOM.TabIndex = 2;
            this.CMDNOM.Text = "&Nombre";
            this.CMDNOM.UseVisualStyleBackColor = true;
            this.CMDNOM.Click += new System.EventHandler(this.CMDNOM_Click);
            // 
            // LBLNOM
            // 
            this.LBLNOM.AutoSize = true;
            this.LBLNOM.Location = new System.Drawing.Point(380, 146);
            this.LBLNOM.Name = "LBLNOM";
            this.LBLNOM.Size = new System.Drawing.Size(44, 13);
            this.LBLNOM.TabIndex = 0;
            this.LBLNOM.Text = "Nombre";
            // 
            // FRMNOMS
            // 
            this.AcceptButton = this.CMDNOM;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDSALIDA;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TXTNOMBRE);
            this.Controls.Add(this.CMDSALIDA);
            this.Controls.Add(this.CMDNOM);
            this.Controls.Add(this.LBLNOM);
            this.Name = "FRMNOMS";
            this.Text = "Salida de nombre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTNOMBRE;
        private System.Windows.Forms.Button CMDSALIDA;
        private System.Windows.Forms.Button CMDNOM;
        private System.Windows.Forms.Label LBLNOM;
    }
}

