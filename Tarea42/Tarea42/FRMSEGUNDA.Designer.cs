namespace Tarea42
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
            this.label1 = new System.Windows.Forms.Label();
            this.TXTNO = new System.Windows.Forms.TextBox();
            this.TXTNC = new System.Windows.Forms.TextBox();
            this.LBLNC = new System.Windows.Forms.Label();
            this.CMDACEPTAR = new System.Windows.Forms.Button();
            this.CMDCANCELAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese su Nombre";
            // 
            // TXTNO
            // 
            this.TXTNO.Location = new System.Drawing.Point(245, 43);
            this.TXTNO.Name = "TXTNO";
            this.TXTNO.Size = new System.Drawing.Size(100, 20);
            this.TXTNO.TabIndex = 1;
            // 
            // TXTNC
            // 
            this.TXTNC.Location = new System.Drawing.Point(245, 109);
            this.TXTNC.Name = "TXTNC";
            this.TXTNC.Size = new System.Drawing.Size(100, 20);
            this.TXTNC.TabIndex = 3;
            // 
            // LBLNC
            // 
            this.LBLNC.AutoSize = true;
            this.LBLNC.Location = new System.Drawing.Point(37, 109);
            this.LBLNC.Name = "LBLNC";
            this.LBLNC.Size = new System.Drawing.Size(146, 13);
            this.LBLNC.TabIndex = 2;
            this.LBLNC.Text = "Ingrese su Numero de control";
            // 
            // CMDACEPTAR
            // 
            this.CMDACEPTAR.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CMDACEPTAR.Location = new System.Drawing.Point(108, 162);
            this.CMDACEPTAR.Name = "CMDACEPTAR";
            this.CMDACEPTAR.Size = new System.Drawing.Size(123, 35);
            this.CMDACEPTAR.TabIndex = 4;
            this.CMDACEPTAR.Text = "&Aceptar";
            this.CMDACEPTAR.UseVisualStyleBackColor = true;
            // 
            // CMDCANCELAR
            // 
            this.CMDCANCELAR.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDCANCELAR.Location = new System.Drawing.Point(282, 162);
            this.CMDCANCELAR.Name = "CMDCANCELAR";
            this.CMDCANCELAR.Size = new System.Drawing.Size(123, 35);
            this.CMDCANCELAR.TabIndex = 5;
            this.CMDCANCELAR.Text = "&Cancelar";
            this.CMDCANCELAR.UseVisualStyleBackColor = true;
            // 
            // FRMSEGUNDA
            // 
            this.AcceptButton = this.CMDACEPTAR;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDCANCELAR;
            this.ClientSize = new System.Drawing.Size(546, 245);
            this.ControlBox = false;
            this.Controls.Add(this.CMDCANCELAR);
            this.Controls.Add(this.CMDACEPTAR);
            this.Controls.Add(this.TXTNC);
            this.Controls.Add(this.LBLNC);
            this.Controls.Add(this.TXTNO);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FRMSEGUNDA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Captura datos de estudiante";
            this.Load += new System.EventHandler(this.FRMSEGUNDA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TXTNO;
        public System.Windows.Forms.TextBox TXTNC;
        private System.Windows.Forms.Label LBLNC;
        private System.Windows.Forms.Button CMDACEPTAR;
        private System.Windows.Forms.Button CMDCANCELAR;
    }
}