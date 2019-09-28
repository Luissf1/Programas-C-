namespace Tarea35
{
    partial class FRMFIB
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
            this.TXTFIB = new System.Windows.Forms.TextBox();
            this.CMDSALIDA = new System.Windows.Forms.Button();
            this.CMDOTRO = new System.Windows.Forms.Button();
            this.CMDFIB = new System.Windows.Forms.Button();
            this.TXTNUM = new System.Windows.Forms.TextBox();
            this.LBLNUM = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TXTFIB
            // 
            this.TXTFIB.Location = new System.Drawing.Point(41, 97);
            this.TXTFIB.Multiline = true;
            this.TXTFIB.Name = "TXTFIB";
            this.TXTFIB.ReadOnly = true;
            this.TXTFIB.Size = new System.Drawing.Size(204, 95);
            this.TXTFIB.TabIndex = 2;
            // 
            // CMDSALIDA
            // 
            this.CMDSALIDA.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDSALIDA.Location = new System.Drawing.Point(395, 180);
            this.CMDSALIDA.Name = "CMDSALIDA";
            this.CMDSALIDA.Size = new System.Drawing.Size(83, 31);
            this.CMDSALIDA.TabIndex = 5;
            this.CMDSALIDA.Text = "&Salida";
            this.CMDSALIDA.UseVisualStyleBackColor = true;
            this.CMDSALIDA.Click += new System.EventHandler(this.CMDSALIDA_Click);
            // 
            // CMDOTRO
            // 
            this.CMDOTRO.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDOTRO.Location = new System.Drawing.Point(395, 110);
            this.CMDOTRO.Name = "CMDOTRO";
            this.CMDOTRO.Size = new System.Drawing.Size(83, 31);
            this.CMDOTRO.TabIndex = 4;
            this.CMDOTRO.Text = "&Clear";
            this.CMDOTRO.UseVisualStyleBackColor = true;
            this.CMDOTRO.Click += new System.EventHandler(this.CMDOTRO_Click);
            // 
            // CMDFIB
            // 
            this.CMDFIB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDFIB.Location = new System.Drawing.Point(395, 41);
            this.CMDFIB.Name = "CMDFIB";
            this.CMDFIB.Size = new System.Drawing.Size(83, 31);
            this.CMDFIB.TabIndex = 3;
            this.CMDFIB.Text = "&Fib";
            this.CMDFIB.UseVisualStyleBackColor = true;
            this.CMDFIB.Click += new System.EventHandler(this.CMDFIB_Click);
            // 
            // TXTNUM
            // 
            this.TXTNUM.Location = new System.Drawing.Point(175, 41);
            this.TXTNUM.Name = "TXTNUM";
            this.TXTNUM.Size = new System.Drawing.Size(100, 20);
            this.TXTNUM.TabIndex = 1;
            // 
            // LBLNUM
            // 
            this.LBLNUM.AutoSize = true;
            this.LBLNUM.Location = new System.Drawing.Point(38, 41);
            this.LBLNUM.Name = "LBLNUM";
            this.LBLNUM.Size = new System.Drawing.Size(83, 13);
            this.LBLNUM.TabIndex = 0;
            this.LBLNUM.Text = "Ingrese numero:";
            // 
            // FRMFIB
            // 
            this.AcceptButton = this.CMDFIB;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDSALIDA;
            this.ClientSize = new System.Drawing.Size(592, 266);
            this.Controls.Add(this.TXTFIB);
            this.Controls.Add(this.CMDSALIDA);
            this.Controls.Add(this.CMDOTRO);
            this.Controls.Add(this.CMDFIB);
            this.Controls.Add(this.TXTNUM);
            this.Controls.Add(this.LBLNUM);
            this.Name = "FRMFIB";
            this.Text = "Fib";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTFIB;
        private System.Windows.Forms.Button CMDSALIDA;
        private System.Windows.Forms.Button CMDOTRO;
        private System.Windows.Forms.Button CMDFIB;
        private System.Windows.Forms.TextBox TXTNUM;
        private System.Windows.Forms.Label LBLNUM;
    }
}

