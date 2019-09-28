namespace Tarea30
{
    partial class FRMEX
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
            this.LBLCON = new System.Windows.Forms.Label();
            this.TXTNUM = new System.Windows.Forms.TextBox();
            this.TXTPON = new System.Windows.Forms.TextBox();
            this.LBLPON = new System.Windows.Forms.Label();
            this.TXTPOT = new System.Windows.Forms.TextBox();
            this.CMDPON = new System.Windows.Forms.Button();
            this.CMDOTRO = new System.Windows.Forms.Button();
            this.CMDSALIDA = new System.Windows.Forms.Button();
            this.TXTPOT1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LBLCON
            // 
            this.LBLCON.AutoSize = true;
            this.LBLCON.Location = new System.Drawing.Point(40, 49);
            this.LBLCON.Name = "LBLCON";
            this.LBLCON.Size = new System.Drawing.Size(83, 13);
            this.LBLCON.TabIndex = 0;
            this.LBLCON.Text = "Ingrese numero:";
            // 
            // TXTNUM
            // 
            this.TXTNUM.Location = new System.Drawing.Point(163, 46);
            this.TXTNUM.Name = "TXTNUM";
            this.TXTNUM.Size = new System.Drawing.Size(100, 20);
            this.TXTNUM.TabIndex = 1;
            // 
            // TXTPON
            // 
            this.TXTPON.Location = new System.Drawing.Point(163, 96);
            this.TXTPON.Name = "TXTPON";
            this.TXTPON.Size = new System.Drawing.Size(100, 20);
            this.TXTPON.TabIndex = 3;
            // 
            // LBLPON
            // 
            this.LBLPON.AutoSize = true;
            this.LBLPON.Location = new System.Drawing.Point(40, 99);
            this.LBLPON.Name = "LBLPON";
            this.LBLPON.Size = new System.Drawing.Size(89, 13);
            this.LBLPON.TabIndex = 2;
            this.LBLPON.Text = "Ingrese potencia:";
            // 
            // TXTPOT
            // 
            this.TXTPOT.Location = new System.Drawing.Point(43, 200);
            this.TXTPOT.Multiline = true;
            this.TXTPOT.Name = "TXTPOT";
            this.TXTPOT.ReadOnly = true;
            this.TXTPOT.Size = new System.Drawing.Size(141, 24);
            this.TXTPOT.TabIndex = 5;
            this.TXTPOT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CMDPON
            // 
            this.CMDPON.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDPON.Location = new System.Drawing.Point(321, 40);
            this.CMDPON.Name = "CMDPON";
            this.CMDPON.Size = new System.Drawing.Size(83, 31);
            this.CMDPON.TabIndex = 6;
            this.CMDPON.Text = "&Potencia";
            this.CMDPON.UseVisualStyleBackColor = true;
            this.CMDPON.Click += new System.EventHandler(this.CMDPON_Click);
            // 
            // CMDOTRO
            // 
            this.CMDOTRO.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDOTRO.Location = new System.Drawing.Point(321, 109);
            this.CMDOTRO.Name = "CMDOTRO";
            this.CMDOTRO.Size = new System.Drawing.Size(83, 31);
            this.CMDOTRO.TabIndex = 7;
            this.CMDOTRO.Text = "&Clear";
            this.CMDOTRO.UseVisualStyleBackColor = true;
            this.CMDOTRO.Click += new System.EventHandler(this.CMDOTRO_Click);
            // 
            // CMDSALIDA
            // 
            this.CMDSALIDA.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDSALIDA.Location = new System.Drawing.Point(321, 179);
            this.CMDSALIDA.Name = "CMDSALIDA";
            this.CMDSALIDA.Size = new System.Drawing.Size(83, 31);
            this.CMDSALIDA.TabIndex = 8;
            this.CMDSALIDA.Text = "&Salida";
            this.CMDSALIDA.UseVisualStyleBackColor = true;
            this.CMDSALIDA.Click += new System.EventHandler(this.CMDSALIDA_Click);
            // 
            // TXTPOT1
            // 
            this.TXTPOT1.Location = new System.Drawing.Point(43, 137);
            this.TXTPOT1.Multiline = true;
            this.TXTPOT1.Name = "TXTPOT1";
            this.TXTPOT1.ReadOnly = true;
            this.TXTPOT1.Size = new System.Drawing.Size(158, 49);
            this.TXTPOT1.TabIndex = 4;
            // 
            // FRMEX
            // 
            this.AcceptButton = this.CMDPON;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDSALIDA;
            this.ClientSize = new System.Drawing.Size(484, 248);
            this.Controls.Add(this.TXTPOT1);
            this.Controls.Add(this.CMDSALIDA);
            this.Controls.Add(this.CMDOTRO);
            this.Controls.Add(this.CMDPON);
            this.Controls.Add(this.TXTPOT);
            this.Controls.Add(this.TXTPON);
            this.Controls.Add(this.LBLPON);
            this.Controls.Add(this.TXTNUM);
            this.Controls.Add(this.LBLCON);
            this.Name = "FRMEX";
            this.Text = "Potencias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLCON;
        private System.Windows.Forms.TextBox TXTNUM;
        private System.Windows.Forms.TextBox TXTPON;
        private System.Windows.Forms.Label LBLPON;
        private System.Windows.Forms.TextBox TXTPOT;
        private System.Windows.Forms.Button CMDPON;
        private System.Windows.Forms.Button CMDOTRO;
        private System.Windows.Forms.Button CMDSALIDA;
        private System.Windows.Forms.TextBox TXTPOT1;
    }
}

