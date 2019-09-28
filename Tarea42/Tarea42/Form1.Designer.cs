namespace Tarea42
{
    partial class FRMCAL
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
            this.TXTFEM = new System.Windows.Forms.TextBox();
            this.LBLPROM = new System.Windows.Forms.Label();
            this.LBLC2 = new System.Windows.Forms.Label();
            this.LBLC1 = new System.Windows.Forms.Label();
            this.LBLNOM = new System.Windows.Forms.Label();
            this.LBLNC = new System.Windows.Forms.Label();
            this.CMDCAP = new System.Windows.Forms.Button();
            this.CMDSALIDA = new System.Windows.Forms.Button();
            this.CMDOTRO = new System.Windows.Forms.Button();
            this.LBLPROG = new System.Windows.Forms.Label();
            this.TXTPROG = new System.Windows.Forms.TextBox();
            this.TXTPROM = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TXTFEM
            // 
            this.TXTFEM.Location = new System.Drawing.Point(26, 96);
            this.TXTFEM.Multiline = true;
            this.TXTFEM.Name = "TXTFEM";
            this.TXTFEM.ReadOnly = true;
            this.TXTFEM.Size = new System.Drawing.Size(182, 105);
            this.TXTFEM.TabIndex = 5;
            // 
            // LBLPROM
            // 
            this.LBLPROM.AutoSize = true;
            this.LBLPROM.Location = new System.Drawing.Point(224, 58);
            this.LBLPROM.Name = "LBLPROM";
            this.LBLPROM.Size = new System.Drawing.Size(51, 13);
            this.LBLPROM.TabIndex = 4;
            this.LBLPROM.Text = "Promedio";
            // 
            // LBLC2
            // 
            this.LBLC2.AutoSize = true;
            this.LBLC2.Location = new System.Drawing.Point(188, 58);
            this.LBLC2.Name = "LBLC2";
            this.LBLC2.Size = new System.Drawing.Size(20, 13);
            this.LBLC2.TabIndex = 3;
            this.LBLC2.Text = "C2";
            // 
            // LBLC1
            // 
            this.LBLC1.AutoSize = true;
            this.LBLC1.Location = new System.Drawing.Point(162, 58);
            this.LBLC1.Name = "LBLC1";
            this.LBLC1.Size = new System.Drawing.Size(20, 13);
            this.LBLC1.TabIndex = 2;
            this.LBLC1.Text = "C1";
            // 
            // LBLNOM
            // 
            this.LBLNOM.AutoSize = true;
            this.LBLNOM.Location = new System.Drawing.Point(112, 58);
            this.LBLNOM.Name = "LBLNOM";
            this.LBLNOM.Size = new System.Drawing.Size(44, 13);
            this.LBLNOM.TabIndex = 1;
            this.LBLNOM.Text = "Nombre";
            // 
            // LBLNC
            // 
            this.LBLNC.AutoSize = true;
            this.LBLNC.Location = new System.Drawing.Point(12, 58);
            this.LBLNC.Name = "LBLNC";
            this.LBLNC.Size = new System.Drawing.Size(94, 13);
            this.LBLNC.TabIndex = 0;
            this.LBLNC.Text = "Numero de control";
            // 
            // CMDCAP
            // 
            this.CMDCAP.Location = new System.Drawing.Point(279, 106);
            this.CMDCAP.Name = "CMDCAP";
            this.CMDCAP.Size = new System.Drawing.Size(96, 23);
            this.CMDCAP.TabIndex = 8;
            this.CMDCAP.Text = "&Captura";
            this.CMDCAP.UseVisualStyleBackColor = true;
            this.CMDCAP.Click += new System.EventHandler(this.CMDCAP_Click);
            // 
            // CMDSALIDA
            // 
            this.CMDSALIDA.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDSALIDA.Location = new System.Drawing.Point(279, 240);
            this.CMDSALIDA.Name = "CMDSALIDA";
            this.CMDSALIDA.Size = new System.Drawing.Size(96, 23);
            this.CMDSALIDA.TabIndex = 10;
            this.CMDSALIDA.Text = "&Salida";
            this.CMDSALIDA.UseVisualStyleBackColor = true;
            this.CMDSALIDA.Click += new System.EventHandler(this.CMDSALIDA_Click);
            // 
            // CMDOTRO
            // 
            this.CMDOTRO.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDOTRO.Location = new System.Drawing.Point(279, 169);
            this.CMDOTRO.Name = "CMDOTRO";
            this.CMDOTRO.Size = new System.Drawing.Size(96, 23);
            this.CMDOTRO.TabIndex = 9;
            this.CMDOTRO.Text = "&Limpiar";
            this.CMDOTRO.UseVisualStyleBackColor = true;
            this.CMDOTRO.Click += new System.EventHandler(this.CMDOTRO_Click_1);
            // 
            // LBLPROG
            // 
            this.LBLPROG.AutoSize = true;
            this.LBLPROG.Location = new System.Drawing.Point(23, 240);
            this.LBLPROG.Name = "LBLPROG";
            this.LBLPROG.Size = new System.Drawing.Size(89, 13);
            this.LBLPROG.TabIndex = 6;
            this.LBLPROG.Text = "Promedio general";
            // 
            // TXTPROG
            // 
            this.TXTPROG.Location = new System.Drawing.Point(140, 237);
            this.TXTPROG.Name = "TXTPROG";
            this.TXTPROG.ReadOnly = true;
            this.TXTPROG.Size = new System.Drawing.Size(100, 20);
            this.TXTPROG.TabIndex = 7;
            // 
            // TXTPROM
            // 
            this.TXTPROM.Location = new System.Drawing.Point(237, 96);
            this.TXTPROM.Multiline = true;
            this.TXTPROM.Name = "TXTPROM";
            this.TXTPROM.ReadOnly = true;
            this.TXTPROM.Size = new System.Drawing.Size(36, 105);
            this.TXTPROM.TabIndex = 11;
            // 
            // FRMCAL
            // 
            this.AcceptButton = this.CMDCAP;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDSALIDA;
            this.ClientSize = new System.Drawing.Size(378, 291);
            this.Controls.Add(this.TXTPROM);
            this.Controls.Add(this.TXTPROG);
            this.Controls.Add(this.LBLPROG);
            this.Controls.Add(this.CMDCAP);
            this.Controls.Add(this.CMDSALIDA);
            this.Controls.Add(this.CMDOTRO);
            this.Controls.Add(this.TXTFEM);
            this.Controls.Add(this.LBLPROM);
            this.Controls.Add(this.LBLC2);
            this.Controls.Add(this.LBLC1);
            this.Controls.Add(this.LBLNOM);
            this.Controls.Add(this.LBLNC);
            this.Name = "FRMCAL";
            this.Text = "Calificaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTFEM;
        private System.Windows.Forms.Label LBLPROM;
        private System.Windows.Forms.Label LBLC2;
        private System.Windows.Forms.Label LBLC1;
        private System.Windows.Forms.Label LBLNOM;
        private System.Windows.Forms.Label LBLNC;
        private System.Windows.Forms.Button CMDCAP;
        private System.Windows.Forms.Button CMDSALIDA;
        private System.Windows.Forms.Button CMDOTRO;
        private System.Windows.Forms.Label LBLPROG;
        private System.Windows.Forms.TextBox TXTPROG;
        private System.Windows.Forms.TextBox TXTPROM;
    }
}

