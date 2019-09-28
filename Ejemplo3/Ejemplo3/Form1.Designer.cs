namespace Ejemplo3
{
    partial class FRMSUMA
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
            this.CMDSALIDA = new System.Windows.Forms.Button();
            this.CMDSUMA = new System.Windows.Forms.Button();
            this.TXTSUMA = new System.Windows.Forms.TextBox();
            this.LBLSUMA = new System.Windows.Forms.Label();
            this.LBLNUM1 = new System.Windows.Forms.Label();
            this.LBLNUM2 = new System.Windows.Forms.Label();
            this.TXTNUM1 = new System.Windows.Forms.TextBox();
            this.TXTNUM2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CMDSALIDA
            // 
            this.CMDSALIDA.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDSALIDA.Location = new System.Drawing.Point(416, 162);
            this.CMDSALIDA.Name = "CMDSALIDA";
            this.CMDSALIDA.Size = new System.Drawing.Size(75, 53);
            this.CMDSALIDA.TabIndex = 7;
            this.CMDSALIDA.Text = "&Salida";
            this.CMDSALIDA.UseVisualStyleBackColor = true;
            this.CMDSALIDA.Click += new System.EventHandler(this.CMDSALIDA_Click);
            // 
            // CMDSUMA
            // 
            this.CMDSUMA.Location = new System.Drawing.Point(416, 45);
            this.CMDSUMA.Name = "CMDSUMA";
            this.CMDSUMA.Size = new System.Drawing.Size(75, 53);
            this.CMDSUMA.TabIndex = 6;
            this.CMDSUMA.Text = "S&uma";
            this.CMDSUMA.UseVisualStyleBackColor = true;
            this.CMDSUMA.Click += new System.EventHandler(this.CMDSUMA_Click);
            // 
            // TXTSUMA
            // 
            this.TXTSUMA.Location = new System.Drawing.Point(222, 179);
            this.TXTSUMA.Name = "TXTSUMA";
            this.TXTSUMA.ReadOnly = true;
            this.TXTSUMA.Size = new System.Drawing.Size(125, 20);
            this.TXTSUMA.TabIndex = 5;
            // 
            // LBLSUMA
            // 
            this.LBLSUMA.AutoSize = true;
            this.LBLSUMA.Location = new System.Drawing.Point(53, 182);
            this.LBLSUMA.Name = "LBLSUMA";
            this.LBLSUMA.Size = new System.Drawing.Size(64, 13);
            this.LBLSUMA.TabIndex = 4;
            this.LBLSUMA.Text = "La suma es:";
            // 
            // LBLNUM1
            // 
            this.LBLNUM1.AutoSize = true;
            this.LBLNUM1.Location = new System.Drawing.Point(53, 45);
            this.LBLNUM1.Name = "LBLNUM1";
            this.LBLNUM1.Size = new System.Drawing.Size(56, 13);
            this.LBLNUM1.TabIndex = 0;
            this.LBLNUM1.Text = "Numero 1:";
            // 
            // LBLNUM2
            // 
            this.LBLNUM2.AutoSize = true;
            this.LBLNUM2.Location = new System.Drawing.Point(53, 108);
            this.LBLNUM2.Name = "LBLNUM2";
            this.LBLNUM2.Size = new System.Drawing.Size(56, 13);
            this.LBLNUM2.TabIndex = 2;
            this.LBLNUM2.Text = "Numero 2:";
            // 
            // TXTNUM1
            // 
            this.TXTNUM1.Location = new System.Drawing.Point(222, 45);
            this.TXTNUM1.Name = "TXTNUM1";
            this.TXTNUM1.Size = new System.Drawing.Size(125, 20);
            this.TXTNUM1.TabIndex = 1;
            // 
            // TXTNUM2
            // 
            this.TXTNUM2.Location = new System.Drawing.Point(222, 108);
            this.TXTNUM2.Name = "TXTNUM2";
            this.TXTNUM2.Size = new System.Drawing.Size(125, 20);
            this.TXTNUM2.TabIndex = 3;
            // 
            // FRMSUMA
            // 
            this.AcceptButton = this.CMDSUMA;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDSALIDA;
            this.ClientSize = new System.Drawing.Size(527, 247);
            this.Controls.Add(this.TXTNUM2);
            this.Controls.Add(this.TXTNUM1);
            this.Controls.Add(this.LBLNUM2);
            this.Controls.Add(this.LBLNUM1);
            this.Controls.Add(this.CMDSALIDA);
            this.Controls.Add(this.CMDSUMA);
            this.Controls.Add(this.TXTSUMA);
            this.Controls.Add(this.LBLSUMA);
            this.Name = "FRMSUMA";
            this.Text = "Suma de dos numeros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CMDSALIDA;
        private System.Windows.Forms.Button CMDSUMA;
        private System.Windows.Forms.TextBox TXTSUMA;
        private System.Windows.Forms.Label LBLSUMA;
        private System.Windows.Forms.Label LBLNUM1;
        private System.Windows.Forms.Label LBLNUM2;
        private System.Windows.Forms.TextBox TXTNUM1;
        private System.Windows.Forms.TextBox TXTNUM2;
    }
}

