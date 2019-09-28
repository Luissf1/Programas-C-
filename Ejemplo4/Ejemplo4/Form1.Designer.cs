namespace Ejemplo4
{
    partial class FRMEJEMPLO
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
            this.LBLNUM1 = new System.Windows.Forms.Label();
            this.TXTNUM1 = new System.Windows.Forms.TextBox();
            this.LBLNUM2 = new System.Windows.Forms.Label();
            this.TXTNUM2 = new System.Windows.Forms.TextBox();
            this.LBLSUMA = new System.Windows.Forms.Label();
            this.TXTSUMA = new System.Windows.Forms.TextBox();
            this.CMDSUMA = new System.Windows.Forms.Button();
            this.CMDSALIDA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLNUM1
            // 
            this.LBLNUM1.AutoSize = true;
            this.LBLNUM1.Location = new System.Drawing.Point(66, 95);
            this.LBLNUM1.Name = "LBLNUM1";
            this.LBLNUM1.Size = new System.Drawing.Size(59, 13);
            this.LBLNUM1.TabIndex = 0;
            this.LBLNUM1.Text = "&Numero 1 :";
            // 
            // TXTNUM1
            // 
            this.TXTNUM1.Location = new System.Drawing.Point(239, 88);
            this.TXTNUM1.Name = "TXTNUM1";
            this.TXTNUM1.Size = new System.Drawing.Size(100, 20);
            this.TXTNUM1.TabIndex = 1;
            // 
            // LBLNUM2
            // 
            this.LBLNUM2.AutoSize = true;
            this.LBLNUM2.Location = new System.Drawing.Point(66, 181);
            this.LBLNUM2.Name = "LBLNUM2";
            this.LBLNUM2.Size = new System.Drawing.Size(59, 13);
            this.LBLNUM2.TabIndex = 2;
            this.LBLNUM2.Text = "Nu&mero 2 :";
            // 
            // TXTNUM2
            // 
            this.TXTNUM2.Location = new System.Drawing.Point(239, 181);
            this.TXTNUM2.Name = "TXTNUM2";
            this.TXTNUM2.Size = new System.Drawing.Size(100, 20);
            this.TXTNUM2.TabIndex = 3;
            // 
            // LBLSUMA
            // 
            this.LBLSUMA.AutoSize = true;
            this.LBLSUMA.Location = new System.Drawing.Point(66, 278);
            this.LBLSUMA.Name = "LBLSUMA";
            this.LBLSUMA.Size = new System.Drawing.Size(67, 13);
            this.LBLSUMA.TabIndex = 4;
            this.LBLSUMA.Text = "La suma es :";
            // 
            // TXTSUMA
            // 
            this.TXTSUMA.Location = new System.Drawing.Point(239, 271);
            this.TXTSUMA.Name = "TXTSUMA";
            this.TXTSUMA.ReadOnly = true;
            this.TXTSUMA.Size = new System.Drawing.Size(100, 20);
            this.TXTSUMA.TabIndex = 5;
            // 
            // CMDSUMA
            // 
            this.CMDSUMA.Location = new System.Drawing.Point(445, 121);
            this.CMDSUMA.Name = "CMDSUMA";
            this.CMDSUMA.Size = new System.Drawing.Size(75, 57);
            this.CMDSUMA.TabIndex = 6;
            this.CMDSUMA.Text = "S&uma";
            this.CMDSUMA.UseVisualStyleBackColor = true;
            this.CMDSUMA.Click += new System.EventHandler(this.CMDSUMA_Click);
            // 
            // CMDSALIDA
            // 
            this.CMDSALIDA.Location = new System.Drawing.Point(445, 235);
            this.CMDSALIDA.Name = "CMDSALIDA";
            this.CMDSALIDA.Size = new System.Drawing.Size(85, 56);
            this.CMDSALIDA.TabIndex = 7;
            this.CMDSALIDA.Text = "&Salida";
            this.CMDSALIDA.UseVisualStyleBackColor = true;
            this.CMDSALIDA.Click += new System.EventHandler(this.CMDSALIDA_Click);
            // 
            // FRMEJEMPLO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CMDSALIDA);
            this.Controls.Add(this.CMDSUMA);
            this.Controls.Add(this.TXTSUMA);
            this.Controls.Add(this.LBLSUMA);
            this.Controls.Add(this.TXTNUM2);
            this.Controls.Add(this.LBLNUM2);
            this.Controls.Add(this.TXTNUM1);
            this.Controls.Add(this.LBLNUM1);
            this.Name = "FRMEJEMPLO";
            this.Text = "Suma de dos numeros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLNUM1;
        private System.Windows.Forms.TextBox TXTNUM1;
        private System.Windows.Forms.Label LBLNUM2;
        private System.Windows.Forms.TextBox TXTNUM2;
        private System.Windows.Forms.Label LBLSUMA;
        private System.Windows.Forms.TextBox TXTSUMA;
        private System.Windows.Forms.Button CMDSUMA;
        private System.Windows.Forms.Button CMDSALIDA;
    }
}

