namespace Tarea36
{
    partial class FRMMULTI
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
            this.TXTNUM = new System.Windows.Forms.TextBox();
            this.TXTMULTI = new System.Windows.Forms.TextBox();
            this.CMDMULT = new System.Windows.Forms.Button();
            this.CMDOTRO = new System.Windows.Forms.Button();
            this.CMDSALIDA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLNUM
            // 
            this.LBLNUM.AutoSize = true;
            this.LBLNUM.Location = new System.Drawing.Point(35, 27);
            this.LBLNUM.Name = "LBLNUM";
            this.LBLNUM.Size = new System.Drawing.Size(83, 13);
            this.LBLNUM.TabIndex = 0;
            this.LBLNUM.Text = "Ingrese numero:";
            // 
            // TXTNUM
            // 
            this.TXTNUM.Location = new System.Drawing.Point(163, 24);
            this.TXTNUM.Name = "TXTNUM";
            this.TXTNUM.Size = new System.Drawing.Size(100, 20);
            this.TXTNUM.TabIndex = 1;
            // 
            // TXTMULTI
            // 
            this.TXTMULTI.Location = new System.Drawing.Point(38, 82);
            this.TXTMULTI.Multiline = true;
            this.TXTMULTI.Name = "TXTMULTI";
            this.TXTMULTI.Size = new System.Drawing.Size(176, 148);
            this.TXTMULTI.TabIndex = 2;
            // 
            // CMDMULT
            // 
            this.CMDMULT.Location = new System.Drawing.Point(341, 46);
            this.CMDMULT.Name = "CMDMULT";
            this.CMDMULT.Size = new System.Drawing.Size(86, 35);
            this.CMDMULT.TabIndex = 3;
            this.CMDMULT.Text = "&Multiplicacion";
            this.CMDMULT.UseVisualStyleBackColor = true;
            this.CMDMULT.Click += new System.EventHandler(this.CMDMULT_Click);
            // 
            // CMDOTRO
            // 
            this.CMDOTRO.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDOTRO.Location = new System.Drawing.Point(341, 105);
            this.CMDOTRO.Name = "CMDOTRO";
            this.CMDOTRO.Size = new System.Drawing.Size(86, 35);
            this.CMDOTRO.TabIndex = 4;
            this.CMDOTRO.Text = "&Clear";
            this.CMDOTRO.UseVisualStyleBackColor = true;
            this.CMDOTRO.Click += new System.EventHandler(this.CMDOTRO_Click);
            // 
            // CMDSALIDA
            // 
            this.CMDSALIDA.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDSALIDA.Location = new System.Drawing.Point(341, 166);
            this.CMDSALIDA.Name = "CMDSALIDA";
            this.CMDSALIDA.Size = new System.Drawing.Size(86, 35);
            this.CMDSALIDA.TabIndex = 5;
            this.CMDSALIDA.Text = "&Salida";
            this.CMDSALIDA.UseVisualStyleBackColor = true;
            this.CMDSALIDA.Click += new System.EventHandler(this.CMDSALIDA_Click);
            // 
            // FRMMULTI
            // 
            this.AcceptButton = this.CMDMULT;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDSALIDA;
            this.ClientSize = new System.Drawing.Size(468, 242);
            this.Controls.Add(this.CMDSALIDA);
            this.Controls.Add(this.CMDOTRO);
            this.Controls.Add(this.CMDMULT);
            this.Controls.Add(this.TXTMULTI);
            this.Controls.Add(this.TXTNUM);
            this.Controls.Add(this.LBLNUM);
            this.Name = "FRMMULTI";
            this.Text = "Tabla de multiplicacion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLNUM;
        private System.Windows.Forms.TextBox TXTNUM;
        private System.Windows.Forms.TextBox TXTMULTI;
        private System.Windows.Forms.Button CMDMULT;
        private System.Windows.Forms.Button CMDOTRO;
        private System.Windows.Forms.Button CMDSALIDA;
    }
}

