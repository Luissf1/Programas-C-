namespace Tarea7
{
    partial class FRMCELCIUS
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
            this.LBLF = new System.Windows.Forms.Label();
            this.LBLC = new System.Windows.Forms.Label();
            this.TXTF = new System.Windows.Forms.TextBox();
            this.TXTC = new System.Windows.Forms.TextBox();
            this.CMDCONVERSION = new System.Windows.Forms.Button();
            this.CMDSALIDA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLF
            // 
            this.LBLF.AutoSize = true;
            this.LBLF.Location = new System.Drawing.Point(81, 74);
            this.LBLF.Name = "LBLF";
            this.LBLF.Size = new System.Drawing.Size(51, 13);
            this.LBLF.TabIndex = 0;
            this.LBLF.Text = "Farenheit";
            // 
            // LBLC
            // 
            this.LBLC.AutoSize = true;
            this.LBLC.Location = new System.Drawing.Point(270, 74);
            this.LBLC.Name = "LBLC";
            this.LBLC.Size = new System.Drawing.Size(41, 13);
            this.LBLC.TabIndex = 2;
            this.LBLC.Text = "Celcius";
            // 
            // TXTF
            // 
            this.TXTF.Location = new System.Drawing.Point(73, 144);
            this.TXTF.Name = "TXTF";
            this.TXTF.Size = new System.Drawing.Size(100, 20);
            this.TXTF.TabIndex = 1;
            // 
            // TXTC
            // 
            this.TXTC.Location = new System.Drawing.Point(253, 144);
            this.TXTC.Name = "TXTC";
            this.TXTC.ReadOnly = true;
            this.TXTC.Size = new System.Drawing.Size(100, 20);
            this.TXTC.TabIndex = 3;
            // 
            // CMDCONVERSION
            // 
            this.CMDCONVERSION.Location = new System.Drawing.Point(73, 224);
            this.CMDCONVERSION.Name = "CMDCONVERSION";
            this.CMDCONVERSION.Size = new System.Drawing.Size(100, 45);
            this.CMDCONVERSION.TabIndex = 4;
            this.CMDCONVERSION.Text = "&Conversion";
            this.CMDCONVERSION.UseVisualStyleBackColor = true;
            this.CMDCONVERSION.Click += new System.EventHandler(this.CMDCONVERSION_Click);
            // 
            // CMDSALIDA
            // 
            this.CMDSALIDA.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDSALIDA.Location = new System.Drawing.Point(253, 224);
            this.CMDSALIDA.Name = "CMDSALIDA";
            this.CMDSALIDA.Size = new System.Drawing.Size(95, 45);
            this.CMDSALIDA.TabIndex = 5;
            this.CMDSALIDA.Text = "&SALIDA";
            this.CMDSALIDA.UseVisualStyleBackColor = true;
            this.CMDSALIDA.Click += new System.EventHandler(this.CMDSALIDA_Click);
            // 
            // FRMCELCIUS
            // 
            this.AcceptButton = this.CMDCONVERSION;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDSALIDA;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CMDSALIDA);
            this.Controls.Add(this.CMDCONVERSION);
            this.Controls.Add(this.TXTC);
            this.Controls.Add(this.TXTF);
            this.Controls.Add(this.LBLC);
            this.Controls.Add(this.LBLF);
            this.Name = "FRMCELCIUS";
            this.Text = "Conversion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLF;
        private System.Windows.Forms.Label LBLC;
        private System.Windows.Forms.TextBox TXTF;
        private System.Windows.Forms.TextBox TXTC;
        private System.Windows.Forms.Button CMDCONVERSION;
        private System.Windows.Forms.Button CMDSALIDA;
    }
}

