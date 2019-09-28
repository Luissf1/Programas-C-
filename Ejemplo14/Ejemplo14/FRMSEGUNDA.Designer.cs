namespace Ejemplo14
{
    partial class FRMSEGUNDA
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
            this.LBLNOMBRE = new System.Windows.Forms.Label();
            this.TXTNOM = new System.Windows.Forms.TextBox();
            this.CMDACEPTAR = new System.Windows.Forms.Button();
            this.CMDCANCELAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLNOMBRE
            // 
            this.LBLNOMBRE.AutoSize = true;
            this.LBLNOMBRE.Location = new System.Drawing.Point(28, 45);
            this.LBLNOMBRE.Name = "LBLNOMBRE";
            this.LBLNOMBRE.Size = new System.Drawing.Size(95, 13);
            this.LBLNOMBRE.TabIndex = 0;
            this.LBLNOMBRE.Text = "Introduce Nombre:";
            // 
            // TXTNOM
            // 
            this.TXTNOM.Location = new System.Drawing.Point(228, 38);
            this.TXTNOM.Name = "TXTNOM";
            this.TXTNOM.Size = new System.Drawing.Size(100, 20);
            this.TXTNOM.TabIndex = 1;
            this.TXTNOM.TextChanged += new System.EventHandler(this.TXTNOM_TextChanged);
            // 
            // CMDACEPTAR
            // 
            this.CMDACEPTAR.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CMDACEPTAR.Location = new System.Drawing.Point(48, 97);
            this.CMDACEPTAR.Name = "CMDACEPTAR";
            this.CMDACEPTAR.Size = new System.Drawing.Size(102, 34);
            this.CMDACEPTAR.TabIndex = 2;
            this.CMDACEPTAR.Text = "&Aceptar";
            this.CMDACEPTAR.UseVisualStyleBackColor = true;
            this.CMDACEPTAR.Click += new System.EventHandler(this.CMDACEPTAR_Click);
            // 
            // CMDCANCELAR
            // 
            this.CMDCANCELAR.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDCANCELAR.Location = new System.Drawing.Point(209, 97);
            this.CMDCANCELAR.Name = "CMDCANCELAR";
            this.CMDCANCELAR.Size = new System.Drawing.Size(102, 34);
            this.CMDCANCELAR.TabIndex = 3;
            this.CMDCANCELAR.Text = "&Cancelar";
            this.CMDCANCELAR.UseVisualStyleBackColor = true;
            // 
            // FRMSEGUNDA
            // 
            this.AcceptButton = this.CMDACEPTAR;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDCANCELAR;
            this.ClientSize = new System.Drawing.Size(421, 172);
            this.ControlBox = false;
            this.Controls.Add(this.CMDCANCELAR);
            this.Controls.Add(this.CMDACEPTAR);
            this.Controls.Add(this.TXTNOM);
            this.Controls.Add(this.LBLNOMBRE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FRMSEGUNDA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Captura de Nombre";
            this.Load += new System.EventHandler(this.FRMSEGUNDA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLNOMBRE;
        public System.Windows.Forms.TextBox TXTNOM;
        private System.Windows.Forms.Button CMDACEPTAR;
        private System.Windows.Forms.Button CMDCANCELAR;
    }
}