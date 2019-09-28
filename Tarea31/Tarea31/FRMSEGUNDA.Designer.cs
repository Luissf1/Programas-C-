namespace Tarea31
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
            this.LBLEDAD2 = new System.Windows.Forms.Label();
            this.TXTEDAD2 = new System.Windows.Forms.TextBox();
            this.CMDACEPTAR = new System.Windows.Forms.Button();
            this.CMDCANCELAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLEDAD2
            // 
            this.LBLEDAD2.AutoSize = true;
            this.LBLEDAD2.Location = new System.Drawing.Point(45, 44);
            this.LBLEDAD2.Name = "LBLEDAD2";
            this.LBLEDAD2.Size = new System.Drawing.Size(96, 13);
            this.LBLEDAD2.TabIndex = 0;
            this.LBLEDAD2.Text = "Introduce su edad:";
            // 
            // TXTEDAD2
            // 
            this.TXTEDAD2.Location = new System.Drawing.Point(211, 44);
            this.TXTEDAD2.Name = "TXTEDAD2";
            this.TXTEDAD2.Size = new System.Drawing.Size(110, 20);
            this.TXTEDAD2.TabIndex = 1;
            // 
            // CMDACEPTAR
            // 
            this.CMDACEPTAR.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CMDACEPTAR.Location = new System.Drawing.Point(84, 95);
            this.CMDACEPTAR.Name = "CMDACEPTAR";
            this.CMDACEPTAR.Size = new System.Drawing.Size(93, 27);
            this.CMDACEPTAR.TabIndex = 3;
            this.CMDACEPTAR.Text = "&Aceptar";
            this.CMDACEPTAR.UseVisualStyleBackColor = true;
            this.CMDACEPTAR.Click += new System.EventHandler(this.CMDACEPTAR_Click);
            // 
            // CMDCANCELAR
            // 
            this.CMDCANCELAR.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDCANCELAR.Location = new System.Drawing.Point(211, 95);
            this.CMDCANCELAR.Name = "CMDCANCELAR";
            this.CMDCANCELAR.Size = new System.Drawing.Size(93, 27);
            this.CMDCANCELAR.TabIndex = 4;
            this.CMDCANCELAR.Text = "&Cancelar";
            this.CMDCANCELAR.UseVisualStyleBackColor = true;
            this.CMDCANCELAR.Click += new System.EventHandler(this.CMDCANCELAR_Click);
            // 
            // FRMSEGUNDA
            // 
            this.AcceptButton = this.CMDACEPTAR;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDCANCELAR;
            this.ClientSize = new System.Drawing.Size(399, 164);
            this.ControlBox = false;
            this.Controls.Add(this.CMDCANCELAR);
            this.Controls.Add(this.CMDACEPTAR);
            this.Controls.Add(this.TXTEDAD2);
            this.Controls.Add(this.LBLEDAD2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FRMSEGUNDA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Captura de edad";
            this.Load += new System.EventHandler(this.FRMSEGUNDA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLEDAD2;
        public System.Windows.Forms.TextBox TXTEDAD2;
        private System.Windows.Forms.Button CMDACEPTAR;
        private System.Windows.Forms.Button CMDCANCELAR;
    }
}