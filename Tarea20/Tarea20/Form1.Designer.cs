namespace Tarea20
{
    partial class FRMMAYOROMENOR
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
            this.LBLNUM2 = new System.Windows.Forms.Label();
            this.TXTNUM2 = new System.Windows.Forms.TextBox();
            this.LBLMAYOR = new System.Windows.Forms.Label();
            this.CMDMAYOR = new System.Windows.Forms.Button();
            this.CMDSALIDA = new System.Windows.Forms.Button();
            this.CMDOTRO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLNUM
            // 
            this.LBLNUM.AutoSize = true;
            this.LBLNUM.Location = new System.Drawing.Point(60, 45);
            this.LBLNUM.Name = "LBLNUM";
            this.LBLNUM.Size = new System.Drawing.Size(128, 13);
            this.LBLNUM.TabIndex = 0;
            this.LBLNUM.Text = "Ingrese el primer numero: ";
            // 
            // TXTNUM
            // 
            this.TXTNUM.Location = new System.Drawing.Point(235, 45);
            this.TXTNUM.Name = "TXTNUM";
            this.TXTNUM.Size = new System.Drawing.Size(100, 20);
            this.TXTNUM.TabIndex = 1;
            // 
            // LBLNUM2
            // 
            this.LBLNUM2.AutoSize = true;
            this.LBLNUM2.Location = new System.Drawing.Point(60, 100);
            this.LBLNUM2.Name = "LBLNUM2";
            this.LBLNUM2.Size = new System.Drawing.Size(138, 13);
            this.LBLNUM2.TabIndex = 2;
            this.LBLNUM2.Text = "Ingrese el segundo numero:";
            // 
            // TXTNUM2
            // 
            this.TXTNUM2.Location = new System.Drawing.Point(235, 93);
            this.TXTNUM2.Name = "TXTNUM2";
            this.TXTNUM2.Size = new System.Drawing.Size(100, 20);
            this.TXTNUM2.TabIndex = 3;
            // 
            // LBLMAYOR
            // 
            this.LBLMAYOR.AutoSize = true;
            this.LBLMAYOR.Location = new System.Drawing.Point(188, 152);
            this.LBLMAYOR.Name = "LBLMAYOR";
            this.LBLMAYOR.Size = new System.Drawing.Size(0, 13);
            this.LBLMAYOR.TabIndex = 4;
            // 
            // CMDMAYOR
            // 
            this.CMDMAYOR.Location = new System.Drawing.Point(79, 195);
            this.CMDMAYOR.Name = "CMDMAYOR";
            this.CMDMAYOR.Size = new System.Drawing.Size(81, 40);
            this.CMDMAYOR.TabIndex = 5;
            this.CMDMAYOR.Text = "&Mayor";
            this.CMDMAYOR.UseVisualStyleBackColor = true;
            this.CMDMAYOR.Click += new System.EventHandler(this.CMDMAYOR_Click);
            // 
            // CMDSALIDA
            // 
            this.CMDSALIDA.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDSALIDA.Location = new System.Drawing.Point(235, 195);
            this.CMDSALIDA.Name = "CMDSALIDA";
            this.CMDSALIDA.Size = new System.Drawing.Size(81, 40);
            this.CMDSALIDA.TabIndex = 6;
            this.CMDSALIDA.Text = "&Salida";
            this.CMDSALIDA.UseVisualStyleBackColor = true;
            this.CMDSALIDA.Click += new System.EventHandler(this.CMDSALIDA_Click);
            // 
            // CMDOTRO
            // 
            this.CMDOTRO.Location = new System.Drawing.Point(385, 195);
            this.CMDOTRO.Name = "CMDOTRO";
            this.CMDOTRO.Size = new System.Drawing.Size(81, 40);
            this.CMDOTRO.TabIndex = 7;
            this.CMDOTRO.Text = "&Clear";
            this.CMDOTRO.UseVisualStyleBackColor = true;
            this.CMDOTRO.Click += new System.EventHandler(this.CMDOTRO_Click);
            // 
            // FRMMAYOROMENOR
            // 
            this.AcceptButton = this.CMDMAYOR;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDSALIDA;
            this.ClientSize = new System.Drawing.Size(554, 283);
            this.Controls.Add(this.CMDOTRO);
            this.Controls.Add(this.CMDSALIDA);
            this.Controls.Add(this.CMDMAYOR);
            this.Controls.Add(this.LBLMAYOR);
            this.Controls.Add(this.TXTNUM2);
            this.Controls.Add(this.LBLNUM2);
            this.Controls.Add(this.TXTNUM);
            this.Controls.Add(this.LBLNUM);
            this.Name = "FRMMAYOROMENOR";
            this.Text = "Numero Mayor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLNUM;
        private System.Windows.Forms.TextBox TXTNUM;
        private System.Windows.Forms.Label LBLNUM2;
        private System.Windows.Forms.TextBox TXTNUM2;
        private System.Windows.Forms.Label LBLMAYOR;
        private System.Windows.Forms.Button CMDMAYOR;
        private System.Windows.Forms.Button CMDSALIDA;
        private System.Windows.Forms.Button CMDOTRO;
    }
}

