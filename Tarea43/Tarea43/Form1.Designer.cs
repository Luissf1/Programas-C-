namespace Tarea43
{
    partial class FRMDIAG
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
            this.TXTPROG = new System.Windows.Forms.TextBox();
            this.LBLPUNTOS = new System.Windows.Forms.Label();
            this.CMDCAP = new System.Windows.Forms.Button();
            this.CMDSALIDA = new System.Windows.Forms.Button();
            this.CMDOTRO = new System.Windows.Forms.Button();
            this.TXTNUM = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TXTPROG
            // 
            this.TXTPROG.Location = new System.Drawing.Point(102, 237);
            this.TXTPROG.Name = "TXTPROG";
            this.TXTPROG.ReadOnly = true;
            this.TXTPROG.Size = new System.Drawing.Size(100, 20);
            this.TXTPROG.TabIndex = 46;
            // 
            // LBLPUNTOS
            // 
            this.LBLPUNTOS.AutoSize = true;
            this.LBLPUNTOS.Location = new System.Drawing.Point(32, 240);
            this.LBLPUNTOS.Name = "LBLPUNTOS";
            this.LBLPUNTOS.Size = new System.Drawing.Size(28, 13);
            this.LBLPUNTOS.TabIndex = 45;
            this.LBLPUNTOS.Text = "(2,3)";
            // 
            // CMDCAP
            // 
            this.CMDCAP.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDCAP.Location = new System.Drawing.Point(255, 68);
            this.CMDCAP.Name = "CMDCAP";
            this.CMDCAP.Size = new System.Drawing.Size(96, 23);
            this.CMDCAP.TabIndex = 44;
            this.CMDCAP.Text = "&Captura";
            this.CMDCAP.UseVisualStyleBackColor = true;
            this.CMDCAP.Click += new System.EventHandler(this.CMDCAP_Click);
            // 
            // CMDSALIDA
            // 
            this.CMDSALIDA.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDSALIDA.Location = new System.Drawing.Point(255, 177);
            this.CMDSALIDA.Name = "CMDSALIDA";
            this.CMDSALIDA.Size = new System.Drawing.Size(96, 23);
            this.CMDSALIDA.TabIndex = 43;
            this.CMDSALIDA.Text = "&Salida";
            this.CMDSALIDA.UseVisualStyleBackColor = true;
            this.CMDSALIDA.Click += new System.EventHandler(this.CMDSALIDA_Click);
            // 
            // CMDOTRO
            // 
            this.CMDOTRO.Location = new System.Drawing.Point(255, 121);
            this.CMDOTRO.Name = "CMDOTRO";
            this.CMDOTRO.Size = new System.Drawing.Size(96, 23);
            this.CMDOTRO.TabIndex = 42;
            this.CMDOTRO.Text = "&Limpiar";
            this.CMDOTRO.UseVisualStyleBackColor = true;
            this.CMDOTRO.Click += new System.EventHandler(this.CMDOTRO_Click);
            // 
            // TXTNUM
            // 
            this.TXTNUM.Location = new System.Drawing.Point(35, 43);
            this.TXTNUM.Multiline = true;
            this.TXTNUM.Name = "TXTNUM";
            this.TXTNUM.ReadOnly = true;
            this.TXTNUM.Size = new System.Drawing.Size(182, 157);
            this.TXTNUM.TabIndex = 41;
            // 
            // FRMDIAG
            // 
            this.AcceptButton = this.CMDCAP;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDSALIDA;
            this.ClientSize = new System.Drawing.Size(367, 281);
            this.Controls.Add(this.TXTPROG);
            this.Controls.Add(this.LBLPUNTOS);
            this.Controls.Add(this.CMDCAP);
            this.Controls.Add(this.CMDSALIDA);
            this.Controls.Add(this.CMDOTRO);
            this.Controls.Add(this.TXTNUM);
            this.Name = "FRMDIAG";
            this.Text = "Diagonal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTPROG;
        private System.Windows.Forms.Label LBLPUNTOS;
        private System.Windows.Forms.Button CMDCAP;
        private System.Windows.Forms.Button CMDSALIDA;
        private System.Windows.Forms.Button CMDOTRO;
        private System.Windows.Forms.TextBox TXTNUM;
    }
}

