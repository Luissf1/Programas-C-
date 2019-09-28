namespace Tarea32
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
            this.CMDCANCELAR = new System.Windows.Forms.Button();
            this.CMDACEPTAR = new System.Windows.Forms.Button();
            this.TXTNUM = new System.Windows.Forms.TextBox();
            this.LBLNC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CMDCANCELAR
            // 
            this.CMDCANCELAR.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDCANCELAR.Location = new System.Drawing.Point(247, 106);
            this.CMDCANCELAR.Name = "CMDCANCELAR";
            this.CMDCANCELAR.Size = new System.Drawing.Size(102, 34);
            this.CMDCANCELAR.TabIndex = 3;
            this.CMDCANCELAR.Text = "&Cancelar";
            this.CMDCANCELAR.UseVisualStyleBackColor = true;
            // 
            // CMDACEPTAR
            // 
            this.CMDACEPTAR.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CMDACEPTAR.Location = new System.Drawing.Point(95, 106);
            this.CMDACEPTAR.Name = "CMDACEPTAR";
            this.CMDACEPTAR.Size = new System.Drawing.Size(102, 34);
            this.CMDACEPTAR.TabIndex = 2;
            this.CMDACEPTAR.Text = "&Aceptar";
            this.CMDACEPTAR.UseVisualStyleBackColor = true;
            // 
            // TXTNUM
            // 
            this.TXTNUM.Location = new System.Drawing.Point(216, 48);
            this.TXTNUM.Name = "TXTNUM";
            this.TXTNUM.Size = new System.Drawing.Size(149, 20);
            this.TXTNUM.TabIndex = 1;
            // 
            // LBLNC
            // 
            this.LBLNC.AutoSize = true;
            this.LBLNC.Location = new System.Drawing.Point(58, 48);
            this.LBLNC.Name = "LBLNC";
            this.LBLNC.Size = new System.Drawing.Size(83, 13);
            this.LBLNC.TabIndex = 0;
            this.LBLNC.Text = "Ingrese numero:";
            // 
            // FRMSEGUNDA
            // 
            this.AcceptButton = this.CMDACEPTAR;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDCANCELAR;
            this.ClientSize = new System.Drawing.Size(475, 183);
            this.Controls.Add(this.CMDCANCELAR);
            this.Controls.Add(this.CMDACEPTAR);
            this.Controls.Add(this.TXTNUM);
            this.Controls.Add(this.LBLNC);
            this.Name = "FRMSEGUNDA";
            this.Text = "Captura de numeros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CMDCANCELAR;
        private System.Windows.Forms.Button CMDACEPTAR;
        public System.Windows.Forms.TextBox TXTNUM;
        private System.Windows.Forms.Label LBLNC;
    }
}