namespace Ejemplo19
{
    partial class FRMEJE
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
            this.CMDNUM = new System.Windows.Forms.Button();
            this.LBL1 = new System.Windows.Forms.Label();
            this.TXTNUM1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTNum2 = new System.Windows.Forms.TextBox();
            this.CMDOTRO = new System.Windows.Forms.Button();
            this.CMDSALIDA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CMDNUM
            // 
            this.CMDNUM.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.CMDNUM.Location = new System.Drawing.Point(42, 24);
            this.CMDNUM.Name = "CMDNUM";
            this.CMDNUM.Size = new System.Drawing.Size(216, 23);
            this.CMDNUM.TabIndex = 0;
            this.CMDNUM.Text = "&Ordenamiento de numeros";
            this.CMDNUM.UseVisualStyleBackColor = true;
            this.CMDNUM.Click += new System.EventHandler(this.CMDNUM_Click);
            // 
            // LBL1
            // 
            this.LBL1.AutoSize = true;
            this.LBL1.Location = new System.Drawing.Point(39, 68);
            this.LBL1.Name = "LBL1";
            this.LBL1.Size = new System.Drawing.Size(42, 13);
            this.LBL1.TabIndex = 1;
            this.LBL1.Text = "Original";
            // 
            // TXTNUM1
            // 
            this.TXTNUM1.Location = new System.Drawing.Point(42, 92);
            this.TXTNUM1.Multiline = true;
            this.TXTNUM1.Name = "TXTNUM1";
            this.TXTNUM1.Size = new System.Drawing.Size(39, 177);
            this.TXTNUM1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ordenado";
            // 
            // TXTNum2
            // 
            this.TXTNum2.Location = new System.Drawing.Point(154, 92);
            this.TXTNum2.Multiline = true;
            this.TXTNum2.Name = "TXTNum2";
            this.TXTNum2.Size = new System.Drawing.Size(39, 177);
            this.TXTNum2.TabIndex = 4;
            // 
            // CMDOTRO
            // 
            this.CMDOTRO.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.CMDOTRO.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDOTRO.Location = new System.Drawing.Point(231, 92);
            this.CMDOTRO.Name = "CMDOTRO";
            this.CMDOTRO.Size = new System.Drawing.Size(81, 23);
            this.CMDOTRO.TabIndex = 5;
            this.CMDOTRO.Text = "&Clear";
            this.CMDOTRO.UseVisualStyleBackColor = true;
            this.CMDOTRO.Click += new System.EventHandler(this.CMDOTRO_Click);
            // 
            // CMDSALIDA
            // 
            this.CMDSALIDA.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.CMDSALIDA.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDSALIDA.Location = new System.Drawing.Point(231, 151);
            this.CMDSALIDA.Name = "CMDSALIDA";
            this.CMDSALIDA.Size = new System.Drawing.Size(81, 23);
            this.CMDSALIDA.TabIndex = 6;
            this.CMDSALIDA.Text = "&Salida";
            this.CMDSALIDA.UseVisualStyleBackColor = true;
            this.CMDSALIDA.Click += new System.EventHandler(this.CMDSALIDA_Click);
            // 
            // FRMEJE
            // 
            this.AcceptButton = this.CMDNUM;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDSALIDA;
            this.ClientSize = new System.Drawing.Size(324, 300);
            this.Controls.Add(this.CMDSALIDA);
            this.Controls.Add(this.CMDOTRO);
            this.Controls.Add(this.TXTNum2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTNUM1);
            this.Controls.Add(this.LBL1);
            this.Controls.Add(this.CMDNUM);
            this.Name = "FRMEJE";
            this.Text = "Ejemplo19";
            this.Load += new System.EventHandler(this.FRMEJE_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CMDNUM;
        private System.Windows.Forms.Label LBL1;
        private System.Windows.Forms.TextBox TXTNUM1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTNum2;
        private System.Windows.Forms.Button CMDOTRO;
        private System.Windows.Forms.Button CMDSALIDA;
    }
}

