namespace Ejemplo9B
{
    partial class FRMEJEMPLO9B
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
            this.LBLCAL1 = new System.Windows.Forms.Label();
            this.CMDSALIDA = new System.Windows.Forms.Button();
            this.CMDOTRO = new System.Windows.Forms.Button();
            this.CMDCAl = new System.Windows.Forms.Button();
            this.TXTCAL = new System.Windows.Forms.TextBox();
            this.LBLCAL = new System.Windows.Forms.Label();
            this.LBLERROR = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBLCAL1
            // 
            this.LBLCAL1.AutoSize = true;
            this.LBLCAL1.Location = new System.Drawing.Point(289, 220);
            this.LBLCAL1.Name = "LBLCAL1";
            this.LBLCAL1.Size = new System.Drawing.Size(0, 13);
            this.LBLCAL1.TabIndex = 5;
            this.LBLCAL1.Tag = "";
            this.LBLCAL1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CMDSALIDA
            // 
            this.CMDSALIDA.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDSALIDA.Location = new System.Drawing.Point(525, 271);
            this.CMDSALIDA.Name = "CMDSALIDA";
            this.CMDSALIDA.Size = new System.Drawing.Size(75, 28);
            this.CMDSALIDA.TabIndex = 4;
            this.CMDSALIDA.Text = "&Salida";
            this.CMDSALIDA.UseVisualStyleBackColor = true;
            this.CMDSALIDA.Click += new System.EventHandler(this.CMDSALIDA_Click);
            // 
            // CMDOTRO
            // 
            this.CMDOTRO.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDOTRO.Location = new System.Drawing.Point(525, 214);
            this.CMDOTRO.Name = "CMDOTRO";
            this.CMDOTRO.Size = new System.Drawing.Size(75, 28);
            this.CMDOTRO.TabIndex = 3;
            this.CMDOTRO.Text = "&Limpiar";
            this.CMDOTRO.UseVisualStyleBackColor = true;
            this.CMDOTRO.Click += new System.EventHandler(this.CMDOTRO_Click);
            // 
            // CMDCAl
            // 
            this.CMDCAl.Location = new System.Drawing.Point(525, 151);
            this.CMDCAl.Name = "CMDCAl";
            this.CMDCAl.Size = new System.Drawing.Size(75, 34);
            this.CMDCAl.TabIndex = 2;
            this.CMDCAl.Text = "&Calificacion";
            this.CMDCAl.UseVisualStyleBackColor = true;
            this.CMDCAl.Click += new System.EventHandler(this.CMDCAl_Click);
            // 
            // TXTCAL
            // 
            this.TXTCAL.Location = new System.Drawing.Point(348, 154);
            this.TXTCAL.MaxLength = 10;
            this.TXTCAL.Name = "TXTCAL";
            this.TXTCAL.Size = new System.Drawing.Size(100, 20);
            this.TXTCAL.TabIndex = 1;
            // 
            // LBLCAL
            // 
            this.LBLCAL.AutoSize = true;
            this.LBLCAL.Location = new System.Drawing.Point(201, 157);
            this.LBLCAL.Name = "LBLCAL";
            this.LBLCAL.Size = new System.Drawing.Size(91, 13);
            this.LBLCAL.TabIndex = 0;
            this.LBLCAL.Text = "Calificacion  literal";
            // 
            // LBLERROR
            // 
            this.LBLERROR.AutoSize = true;
            this.LBLERROR.Location = new System.Drawing.Point(289, 245);
            this.LBLERROR.Name = "LBLERROR";
            this.LBLERROR.Size = new System.Drawing.Size(0, 13);
            this.LBLERROR.TabIndex = 6;
            this.LBLERROR.Tag = "";
            this.LBLERROR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FRMEJEMPLO9B
            // 
            this.AcceptButton = this.CMDCAl;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDSALIDA;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LBLERROR);
            this.Controls.Add(this.LBLCAL1);
            this.Controls.Add(this.CMDSALIDA);
            this.Controls.Add(this.CMDOTRO);
            this.Controls.Add(this.CMDCAl);
            this.Controls.Add(this.TXTCAL);
            this.Controls.Add(this.LBLCAL);
            this.Name = "FRMEJEMPLO9B";
            this.Text = "Ejemplo 9B";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLCAL1;
        private System.Windows.Forms.Button CMDSALIDA;
        private System.Windows.Forms.Button CMDOTRO;
        private System.Windows.Forms.Button CMDCAl;
        private System.Windows.Forms.TextBox TXTCAL;
        private System.Windows.Forms.Label LBLCAL;
        private System.Windows.Forms.Label LBLERROR;
    }
}

