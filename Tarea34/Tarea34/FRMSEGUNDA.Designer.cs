namespace Tarea34
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
            this.TXTGASTO = new System.Windows.Forms.TextBox();
            this.LBLGASTO = new System.Windows.Forms.Label();
            this.CMDCANCELAR = new System.Windows.Forms.Button();
            this.CMDACEPTAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TXTGASTO
            // 
            this.TXTGASTO.Location = new System.Drawing.Point(200, 57);
            this.TXTGASTO.Name = "TXTGASTO";
            this.TXTGASTO.Size = new System.Drawing.Size(179, 20);
            this.TXTGASTO.TabIndex = 1;
            // 
            // LBLGASTO
            // 
            this.LBLGASTO.AutoSize = true;
            this.LBLGASTO.Location = new System.Drawing.Point(67, 57);
            this.LBLGASTO.Name = "LBLGASTO";
            this.LBLGASTO.Size = new System.Drawing.Size(74, 13);
            this.LBLGASTO.TabIndex = 0;
            this.LBLGASTO.Text = "Ingrese gasto:";
            // 
            // CMDCANCELAR
            // 
            this.CMDCANCELAR.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDCANCELAR.Location = new System.Drawing.Point(293, 135);
            this.CMDCANCELAR.Name = "CMDCANCELAR";
            this.CMDCANCELAR.Size = new System.Drawing.Size(102, 34);
            this.CMDCANCELAR.TabIndex = 3;
            this.CMDCANCELAR.Text = "&Cancelar";
            this.CMDCANCELAR.UseVisualStyleBackColor = true;
            // 
            // CMDACEPTAR
            // 
            this.CMDACEPTAR.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CMDACEPTAR.Location = new System.Drawing.Point(55, 135);
            this.CMDACEPTAR.Name = "CMDACEPTAR";
            this.CMDACEPTAR.Size = new System.Drawing.Size(102, 34);
            this.CMDACEPTAR.TabIndex = 2;
            this.CMDACEPTAR.Text = "&Aceptar";
            this.CMDACEPTAR.UseVisualStyleBackColor = true;
            // 
            // FRMSEGUNDA
            // 
            this.AcceptButton = this.CMDACEPTAR;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDCANCELAR;
            this.ClientSize = new System.Drawing.Size(456, 211);
            this.Controls.Add(this.CMDCANCELAR);
            this.Controls.Add(this.CMDACEPTAR);
            this.Controls.Add(this.TXTGASTO);
            this.Controls.Add(this.LBLGASTO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FRMSEGUNDA";
            this.Text = "Gasto";
            this.Load += new System.EventHandler(this.FRMSEGUNDA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox TXTGASTO;
        private System.Windows.Forms.Label LBLGASTO;
        private System.Windows.Forms.Button CMDCANCELAR;
        private System.Windows.Forms.Button CMDACEPTAR;
    }
}