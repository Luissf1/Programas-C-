namespace Tarea2
{
    partial class FRMHIP
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
            this.LBLHA = new System.Windows.Forms.Label();
            this.LBLHB = new System.Windows.Forms.Label();
            this.TXTHA = new System.Windows.Forms.TextBox();
            this.TXTHB = new System.Windows.Forms.TextBox();
            this.CMDHIPOTENUSA = new System.Windows.Forms.Button();
            this.CMDSALIDA = new System.Windows.Forms.Button();
            this.TXTH = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LBLHA
            // 
            this.LBLHA.AutoSize = true;
            this.LBLHA.Location = new System.Drawing.Point(149, 94);
            this.LBLHA.Name = "LBLHA";
            this.LBLHA.Size = new System.Drawing.Size(71, 13);
            this.LBLHA.TabIndex = 0;
            this.LBLHA.Text = "Hipotenusa A";
            // 
            // LBLHB
            // 
            this.LBLHB.AutoSize = true;
            this.LBLHB.Location = new System.Drawing.Point(333, 94);
            this.LBLHB.Name = "LBLHB";
            this.LBLHB.Size = new System.Drawing.Size(71, 13);
            this.LBLHB.TabIndex = 2;
            this.LBLHB.Text = "Hipotenusa B";
            // 
            // TXTHA
            // 
            this.TXTHA.Location = new System.Drawing.Point(133, 158);
            this.TXTHA.Name = "TXTHA";
            this.TXTHA.Size = new System.Drawing.Size(100, 20);
            this.TXTHA.TabIndex = 1;
            this.TXTHA.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TXTHB
            // 
            this.TXTHB.Location = new System.Drawing.Point(312, 158);
            this.TXTHB.Name = "TXTHB";
            this.TXTHB.Size = new System.Drawing.Size(100, 20);
            this.TXTHB.TabIndex = 3;
            // 
            // CMDHIPOTENUSA
            // 
            this.CMDHIPOTENUSA.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDHIPOTENUSA.Location = new System.Drawing.Point(133, 234);
            this.CMDHIPOTENUSA.Name = "CMDHIPOTENUSA";
            this.CMDHIPOTENUSA.Size = new System.Drawing.Size(100, 52);
            this.CMDHIPOTENUSA.TabIndex = 4;
            this.CMDHIPOTENUSA.Text = "&Hipotenusa";
            this.CMDHIPOTENUSA.UseVisualStyleBackColor = true;
            this.CMDHIPOTENUSA.Click += new System.EventHandler(this.CMDHIPOTENUSA_Click);
            // 
            // CMDSALIDA
            // 
            this.CMDSALIDA.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDSALIDA.Location = new System.Drawing.Point(312, 234);
            this.CMDSALIDA.Name = "CMDSALIDA";
            this.CMDSALIDA.Size = new System.Drawing.Size(100, 52);
            this.CMDSALIDA.TabIndex = 5;
            this.CMDSALIDA.Text = "&Salida";
            this.CMDSALIDA.UseVisualStyleBackColor = true;
            this.CMDSALIDA.Click += new System.EventHandler(this.CMDSALIDA_Click);
            // 
            // TXTH
            // 
            this.TXTH.Location = new System.Drawing.Point(509, 266);
            this.TXTH.Name = "TXTH";
            this.TXTH.ReadOnly = true;
            this.TXTH.Size = new System.Drawing.Size(100, 20);
            this.TXTH.TabIndex = 6;
            // 
            // FRMHIP
            // 
            this.AcceptButton = this.CMDHIPOTENUSA;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDSALIDA;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TXTH);
            this.Controls.Add(this.CMDSALIDA);
            this.Controls.Add(this.CMDHIPOTENUSA);
            this.Controls.Add(this.TXTHB);
            this.Controls.Add(this.TXTHA);
            this.Controls.Add(this.LBLHB);
            this.Controls.Add(this.LBLHA);
            this.Name = "FRMHIP";
            this.Text = "Calcular la hipotenusa";
            this.Load += new System.EventHandler(this.FRMHIP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLHA;
        private System.Windows.Forms.Label LBLHB;
        private System.Windows.Forms.TextBox TXTHA;
        private System.Windows.Forms.TextBox TXTHB;
        private System.Windows.Forms.Button CMDHIPOTENUSA;
        private System.Windows.Forms.Button CMDSALIDA;
        private System.Windows.Forms.TextBox TXTH;
    }
}

