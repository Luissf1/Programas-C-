namespace Tarea44
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
            this.TXTNC = new System.Windows.Forms.TextBox();
            this.LBLNC = new System.Windows.Forms.Label();
            this.TXTNOM = new System.Windows.Forms.TextBox();
            this.LBLNOM = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CMDCANCELAR
            // 
            this.CMDCANCELAR.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDCANCELAR.Location = new System.Drawing.Point(287, 161);
            this.CMDCANCELAR.Name = "CMDCANCELAR";
            this.CMDCANCELAR.Size = new System.Drawing.Size(102, 34);
            this.CMDCANCELAR.TabIndex = 5;
            this.CMDCANCELAR.Text = "&Cancelar";
            this.CMDCANCELAR.UseVisualStyleBackColor = true;
            // 
            // CMDACEPTAR
            // 
            this.CMDACEPTAR.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CMDACEPTAR.Location = new System.Drawing.Point(49, 161);
            this.CMDACEPTAR.Name = "CMDACEPTAR";
            this.CMDACEPTAR.Size = new System.Drawing.Size(102, 34);
            this.CMDACEPTAR.TabIndex = 4;
            this.CMDACEPTAR.Text = "&Aceptar";
            this.CMDACEPTAR.UseVisualStyleBackColor = true;
            // 
            // TXTNC
            // 
            this.TXTNC.Location = new System.Drawing.Point(269, 49);
            this.TXTNC.Name = "TXTNC";
            this.TXTNC.Size = new System.Drawing.Size(100, 20);
            this.TXTNC.TabIndex = 1;
            // 
            // LBLNC
            // 
            this.LBLNC.AutoSize = true;
            this.LBLNC.Location = new System.Drawing.Point(30, 49);
            this.LBLNC.Name = "LBLNC";
            this.LBLNC.Size = new System.Drawing.Size(157, 13);
            this.LBLNC.TabIndex = 0;
            this.LBLNC.Text = "Introduce su numero de control:";
            // 
            // TXTNOM
            // 
            this.TXTNOM.Location = new System.Drawing.Point(269, 99);
            this.TXTNOM.Name = "TXTNOM";
            this.TXTNOM.Size = new System.Drawing.Size(100, 20);
            this.TXTNOM.TabIndex = 3;
            // 
            // LBLNOM
            // 
            this.LBLNOM.AutoSize = true;
            this.LBLNOM.Location = new System.Drawing.Point(30, 99);
            this.LBLNOM.Name = "LBLNOM";
            this.LBLNOM.Size = new System.Drawing.Size(109, 13);
            this.LBLNOM.TabIndex = 2;
            this.LBLNOM.Text = "Introduce su Nombre:";
            // 
            // FRMSEGUNDA
            // 
            this.AcceptButton = this.CMDACEPTAR;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDCANCELAR;
            this.ClientSize = new System.Drawing.Size(463, 243);
            this.ControlBox = false;
            this.Controls.Add(this.TXTNOM);
            this.Controls.Add(this.LBLNOM);
            this.Controls.Add(this.CMDCANCELAR);
            this.Controls.Add(this.CMDACEPTAR);
            this.Controls.Add(this.TXTNC);
            this.Controls.Add(this.LBLNC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FRMSEGUNDA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Captura de datos ";
            this.Load += new System.EventHandler(this.FRMSEGUNDA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CMDCANCELAR;
        private System.Windows.Forms.Button CMDACEPTAR;
        public System.Windows.Forms.TextBox TXTNC;
        private System.Windows.Forms.Label LBLNC;
        public System.Windows.Forms.TextBox TXTNOM;
        private System.Windows.Forms.Label LBLNOM;
    }
}