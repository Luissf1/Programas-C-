using System;

namespace Ejemplo9
{
    partial class FRMEJEMPLO9
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
            this.LBLCAL = new System.Windows.Forms.Label();
            this.TXTCAL = new System.Windows.Forms.TextBox();
            this.CMDCAl = new System.Windows.Forms.Button();
            this.CMDOTRO = new System.Windows.Forms.Button();
            this.CMDSALIDA = new System.Windows.Forms.Button();
            this.LBLCAL1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBLCAL
            // 
            this.LBLCAL.AutoSize = true;
            this.LBLCAL.Location = new System.Drawing.Point(12, 55);
            this.LBLCAL.Name = "LBLCAL";
            this.LBLCAL.Size = new System.Drawing.Size(103, 13);
            this.LBLCAL.TabIndex = 0;
            this.LBLCAL.Text = "Calificacion en literal";
            // 
            // TXTCAL
            // 
            this.TXTCAL.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTCAL.Location = new System.Drawing.Point(159, 52);
            this.TXTCAL.MaxLength = 1;
            this.TXTCAL.Name = "TXTCAL";
            this.TXTCAL.Size = new System.Drawing.Size(100, 20);
            this.TXTCAL.TabIndex = 1;
            // 
            // CMDCAl
            // 
            this.CMDCAl.Location = new System.Drawing.Point(336, 49);
            this.CMDCAl.Name = "CMDCAl";
            this.CMDCAl.Size = new System.Drawing.Size(75, 34);
            this.CMDCAl.TabIndex = 2;
            this.CMDCAl.Text = "&Calificacion";
            this.CMDCAl.UseVisualStyleBackColor = true;
            this.CMDCAl.Click += new System.EventHandler(this.CMDCAl_Click);
            // 
            // CMDOTRO
            // 
            this.CMDOTRO.Location = new System.Drawing.Point(336, 112);
            this.CMDOTRO.Name = "CMDOTRO";
            this.CMDOTRO.Size = new System.Drawing.Size(75, 28);
            this.CMDOTRO.TabIndex = 3;
            this.CMDOTRO.Text = "&Limpiar";
            this.CMDOTRO.UseVisualStyleBackColor = true;
            this.CMDOTRO.Click += new System.EventHandler(this.CMDOTRO_Click);
            // 
            // CMDSALIDA
            // 
            this.CMDSALIDA.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDSALIDA.Location = new System.Drawing.Point(336, 169);
            this.CMDSALIDA.Name = "CMDSALIDA";
            this.CMDSALIDA.Size = new System.Drawing.Size(75, 28);
            this.CMDSALIDA.TabIndex = 4;
            this.CMDSALIDA.Text = "&Salida";
            this.CMDSALIDA.UseVisualStyleBackColor = true;
            this.CMDSALIDA.Click += new System.EventHandler(this.CMDSALIDA_Click);
            // 
            // LBLCAL1
            // 
            this.LBLCAL1.AutoSize = true;
            this.LBLCAL1.Location = new System.Drawing.Point(72, 109);
            this.LBLCAL1.Name = "LBLCAL1";
            this.LBLCAL1.Size = new System.Drawing.Size(0, 13);
            this.LBLCAL1.TabIndex = 5;
            // 
            // FRMEJEMPLO9
            // 
            this.AcceptButton = this.CMDCAl;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDSALIDA;
            this.ClientSize = new System.Drawing.Size(478, 317);
            this.Controls.Add(this.LBLCAL1);
            this.Controls.Add(this.CMDSALIDA);
            this.Controls.Add(this.CMDOTRO);
            this.Controls.Add(this.CMDCAl);
            this.Controls.Add(this.TXTCAL);
            this.Controls.Add(this.LBLCAL);
            this.Name = "FRMEJEMPLO9";
            this.Text = "Ejemplo 9";
            this.Load += new System.EventHandler(this.FRMEJEMPLO9_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLCAL;
        private System.Windows.Forms.TextBox TXTCAL;
        private System.Windows.Forms.Button CMDCAl;
        private System.Windows.Forms.Button CMDOTRO;
        private System.Windows.Forms.Button CMDSALIDA;
        private System.Windows.Forms.Label LBLCAL1;
        private EventHandler label1_Click;
    }
}

