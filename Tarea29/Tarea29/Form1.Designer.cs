namespace Tarea29
{
    partial class FRMFAC
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
            this.LBLNUM = new System.Windows.Forms.Label();
            this.TXTFAC = new System.Windows.Forms.TextBox();
            this.TXTFAC2 = new System.Windows.Forms.TextBox();
            this.CMDFAC = new System.Windows.Forms.Button();
            this.CMDOTRO = new System.Windows.Forms.Button();
            this.CMDSALIDA = new System.Windows.Forms.Button();
            this.LBLSUMA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBLNUM
            // 
            this.LBLNUM.AutoSize = true;
            this.LBLNUM.Location = new System.Drawing.Point(33, 18);
            this.LBLNUM.Name = "LBLNUM";
            this.LBLNUM.Size = new System.Drawing.Size(83, 13);
            this.LBLNUM.TabIndex = 0;
            this.LBLNUM.Text = "Ingrese numero:";
            // 
            // TXTFAC
            // 
            this.TXTFAC.Location = new System.Drawing.Point(135, 18);
            this.TXTFAC.Name = "TXTFAC";
            this.TXTFAC.Size = new System.Drawing.Size(100, 20);
            this.TXTFAC.TabIndex = 1;
            // 
            // TXTFAC2
            // 
            this.TXTFAC2.Location = new System.Drawing.Point(36, 52);
            this.TXTFAC2.Multiline = true;
            this.TXTFAC2.Name = "TXTFAC2";
            this.TXTFAC2.ReadOnly = true;
            this.TXTFAC2.Size = new System.Drawing.Size(90, 57);
            this.TXTFAC2.TabIndex = 2;
            // 
            // CMDFAC
            // 
            this.CMDFAC.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDFAC.Location = new System.Drawing.Point(250, 52);
            this.CMDFAC.Name = "CMDFAC";
            this.CMDFAC.Size = new System.Drawing.Size(75, 23);
            this.CMDFAC.TabIndex = 3;
            this.CMDFAC.Text = "&Factorial";
            this.CMDFAC.UseVisualStyleBackColor = true;
            this.CMDFAC.Click += new System.EventHandler(this.CMDFAC_Click);
            // 
            // CMDOTRO
            // 
            this.CMDOTRO.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDOTRO.Location = new System.Drawing.Point(250, 86);
            this.CMDOTRO.Name = "CMDOTRO";
            this.CMDOTRO.Size = new System.Drawing.Size(75, 23);
            this.CMDOTRO.TabIndex = 4;
            this.CMDOTRO.Text = "&Clear";
            this.CMDOTRO.UseVisualStyleBackColor = true;
            this.CMDOTRO.Click += new System.EventHandler(this.CMDOTRO_Click);
            // 
            // CMDSALIDA
            // 
            this.CMDSALIDA.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDSALIDA.Location = new System.Drawing.Point(250, 131);
            this.CMDSALIDA.Name = "CMDSALIDA";
            this.CMDSALIDA.Size = new System.Drawing.Size(75, 23);
            this.CMDSALIDA.TabIndex = 5;
            this.CMDSALIDA.Text = "&Salida";
            this.CMDSALIDA.UseVisualStyleBackColor = true;
            this.CMDSALIDA.Click += new System.EventHandler(this.CMDSALIDA_Click);
            // 
            // LBLSUMA
            // 
            this.LBLSUMA.AutoSize = true;
            this.LBLSUMA.Location = new System.Drawing.Point(132, 86);
            this.LBLSUMA.Name = "LBLSUMA";
            this.LBLSUMA.Size = new System.Drawing.Size(0, 13);
            this.LBLSUMA.TabIndex = 3;
            // 
            // FRMFAC
            // 
            this.AcceptButton = this.CMDFAC;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDSALIDA;
            this.ClientSize = new System.Drawing.Size(352, 169);
            this.Controls.Add(this.LBLSUMA);
            this.Controls.Add(this.CMDSALIDA);
            this.Controls.Add(this.CMDOTRO);
            this.Controls.Add(this.CMDFAC);
            this.Controls.Add(this.TXTFAC2);
            this.Controls.Add(this.TXTFAC);
            this.Controls.Add(this.LBLNUM);
            this.Name = "FRMFAC";
            this.Text = "Factorial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLNUM;
        private System.Windows.Forms.TextBox TXTFAC;
        private System.Windows.Forms.TextBox TXTFAC2;
        private System.Windows.Forms.Button CMDFAC;
        private System.Windows.Forms.Button CMDOTRO;
        private System.Windows.Forms.Button CMDSALIDA;
        private System.Windows.Forms.Label LBLSUMA;
    }
}

