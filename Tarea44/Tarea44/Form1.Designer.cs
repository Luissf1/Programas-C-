namespace Tarea44
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
            this.LBLPUNTOS = new System.Windows.Forms.Label();
            this.CMDCAP = new System.Windows.Forms.Button();
            this.CMDSALIDA = new System.Windows.Forms.Button();
            this.CMDOTRO = new System.Windows.Forms.Button();
            this.TXTNUM = new System.Windows.Forms.TextBox();
            this.LBLPROM = new System.Windows.Forms.Label();
            this.LBLC2 = new System.Windows.Forms.Label();
            this.LBLC1 = new System.Windows.Forms.Label();
            this.LBLNOM = new System.Windows.Forms.Label();
            this.LBLNC = new System.Windows.Forms.Label();
            this.LBLCAL3 = new System.Windows.Forms.Label();
            this.TXTPROM = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LBLPUNTOS
            // 
            this.LBLPUNTOS.AutoSize = true;
            this.LBLPUNTOS.Location = new System.Drawing.Point(68, 230);
            this.LBLPUNTOS.Name = "LBLPUNTOS";
            this.LBLPUNTOS.Size = new System.Drawing.Size(0, 13);
            this.LBLPUNTOS.TabIndex = 56;
            // 
            // CMDCAP
            // 
            this.CMDCAP.Location = new System.Drawing.Point(25, 274);
            this.CMDCAP.Name = "CMDCAP";
            this.CMDCAP.Size = new System.Drawing.Size(96, 23);
            this.CMDCAP.TabIndex = 55;
            this.CMDCAP.Text = "&Captura";
            this.CMDCAP.UseVisualStyleBackColor = true;
            this.CMDCAP.Click += new System.EventHandler(this.CMDCAP_Click);
            // 
            // CMDSALIDA
            // 
            this.CMDSALIDA.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDSALIDA.Location = new System.Drawing.Point(273, 274);
            this.CMDSALIDA.Name = "CMDSALIDA";
            this.CMDSALIDA.Size = new System.Drawing.Size(96, 23);
            this.CMDSALIDA.TabIndex = 54;
            this.CMDSALIDA.Text = "&Salida";
            this.CMDSALIDA.UseVisualStyleBackColor = true;
            this.CMDSALIDA.Click += new System.EventHandler(this.CMDSALIDA_Click);
            // 
            // CMDOTRO
            // 
            this.CMDOTRO.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDOTRO.Location = new System.Drawing.Point(147, 274);
            this.CMDOTRO.Name = "CMDOTRO";
            this.CMDOTRO.Size = new System.Drawing.Size(96, 23);
            this.CMDOTRO.TabIndex = 53;
            this.CMDOTRO.Text = "&Limpiar";
            this.CMDOTRO.UseVisualStyleBackColor = true;
            this.CMDOTRO.Click += new System.EventHandler(this.CMDOTRO_Click);
            // 
            // TXTNUM
            // 
            this.TXTNUM.Location = new System.Drawing.Point(15, 80);
            this.TXTNUM.Multiline = true;
            this.TXTNUM.Name = "TXTNUM";
            this.TXTNUM.ReadOnly = true;
            this.TXTNUM.Size = new System.Drawing.Size(259, 163);
            this.TXTNUM.TabIndex = 52;
            // 
            // LBLPROM
            // 
            this.LBLPROM.AutoSize = true;
            this.LBLPROM.Location = new System.Drawing.Point(319, 40);
            this.LBLPROM.Name = "LBLPROM";
            this.LBLPROM.Size = new System.Drawing.Size(51, 13);
            this.LBLPROM.TabIndex = 51;
            this.LBLPROM.Text = "Promedio";
            // 
            // LBLC2
            // 
            this.LBLC2.AutoSize = true;
            this.LBLC2.Location = new System.Drawing.Point(187, 54);
            this.LBLC2.Name = "LBLC2";
            this.LBLC2.Size = new System.Drawing.Size(20, 13);
            this.LBLC2.TabIndex = 50;
            this.LBLC2.Text = "C2";
            // 
            // LBLC1
            // 
            this.LBLC1.AutoSize = true;
            this.LBLC1.Location = new System.Drawing.Point(144, 54);
            this.LBLC1.Name = "LBLC1";
            this.LBLC1.Size = new System.Drawing.Size(20, 13);
            this.LBLC1.TabIndex = 49;
            this.LBLC1.Text = "C1";
            // 
            // LBLNOM
            // 
            this.LBLNOM.AutoSize = true;
            this.LBLNOM.Location = new System.Drawing.Point(59, 54);
            this.LBLNOM.Name = "LBLNOM";
            this.LBLNOM.Size = new System.Drawing.Size(44, 13);
            this.LBLNOM.TabIndex = 48;
            this.LBLNOM.Text = "Nombre";
            // 
            // LBLNC
            // 
            this.LBLNC.AutoSize = true;
            this.LBLNC.Location = new System.Drawing.Point(12, 54);
            this.LBLNC.Name = "LBLNC";
            this.LBLNC.Size = new System.Drawing.Size(22, 13);
            this.LBLNC.TabIndex = 47;
            this.LBLNC.Text = "NC";
            // 
            // LBLCAL3
            // 
            this.LBLCAL3.AutoSize = true;
            this.LBLCAL3.Location = new System.Drawing.Point(243, 54);
            this.LBLCAL3.Name = "LBLCAL3";
            this.LBLCAL3.Size = new System.Drawing.Size(20, 13);
            this.LBLCAL3.TabIndex = 58;
            this.LBLCAL3.Text = "C3";
            // 
            // TXTPROM
            // 
            this.TXTPROM.Location = new System.Drawing.Point(322, 80);
            this.TXTPROM.Multiline = true;
            this.TXTPROM.Name = "TXTPROM";
            this.TXTPROM.ReadOnly = true;
            this.TXTPROM.Size = new System.Drawing.Size(34, 163);
            this.TXTPROM.TabIndex = 59;
            // 
            // FRMCAL
            // 
            this.AcceptButton = this.CMDCAP;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDSALIDA;
            this.ClientSize = new System.Drawing.Size(399, 332);
            this.Controls.Add(this.TXTPROM);
            this.Controls.Add(this.LBLCAL3);
            this.Controls.Add(this.LBLPUNTOS);
            this.Controls.Add(this.CMDCAP);
            this.Controls.Add(this.CMDSALIDA);
            this.Controls.Add(this.CMDOTRO);
            this.Controls.Add(this.TXTNUM);
            this.Controls.Add(this.LBLPROM);
            this.Controls.Add(this.LBLC2);
            this.Controls.Add(this.LBLC1);
            this.Controls.Add(this.LBLNOM);
            this.Controls.Add(this.LBLNC);
            this.Name = "FRMCAL";
            this.Text = "Calificaciones y datos de alumnos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LBLPUNTOS;
        private System.Windows.Forms.Button CMDCAP;
        private System.Windows.Forms.Button CMDSALIDA;
        private System.Windows.Forms.Button CMDOTRO;
        private System.Windows.Forms.TextBox TXTNUM;
        private System.Windows.Forms.Label LBLPROM;
        private System.Windows.Forms.Label LBLC2;
        private System.Windows.Forms.Label LBLC1;
        private System.Windows.Forms.Label LBLNOM;
        private System.Windows.Forms.Label LBLNC;
        private System.Windows.Forms.Label LBLCAL3;
        private System.Windows.Forms.TextBox TXTPROM;
    }
}

