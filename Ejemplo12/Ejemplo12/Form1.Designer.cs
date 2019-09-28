namespace Ejemplo12
{
    partial class FRMEJEMPLO12
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
            this.TXTNUM1 = new System.Windows.Forms.TextBox();
            this.LBLNUM2 = new System.Windows.Forms.Label();
            this.LBLRES = new System.Windows.Forms.Label();
            this.TXTNUM2 = new System.Windows.Forms.TextBox();
            this.TXTRES = new System.Windows.Forms.TextBox();
            this.CMDCAL = new System.Windows.Forms.Button();
            this.CMDSAL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLNUM
            // 
            this.LBLNUM.AutoSize = true;
            this.LBLNUM.Location = new System.Drawing.Point(12, 29);
            this.LBLNUM.Name = "LBLNUM";
            this.LBLNUM.Size = new System.Drawing.Size(59, 13);
            this.LBLNUM.TabIndex = 0;
            this.LBLNUM.Text = "Numero 1 :";
            // 
            // TXTNUM1
            // 
            this.TXTNUM1.Location = new System.Drawing.Point(148, 22);
            this.TXTNUM1.Name = "TXTNUM1";
            this.TXTNUM1.Size = new System.Drawing.Size(100, 20);
            this.TXTNUM1.TabIndex = 1;
            this.TXTNUM1.TextChanged += new System.EventHandler(this.TXTNUM1_TextChanged);
            // 
            // LBLNUM2
            // 
            this.LBLNUM2.AutoSize = true;
            this.LBLNUM2.Location = new System.Drawing.Point(12, 75);
            this.LBLNUM2.Name = "LBLNUM2";
            this.LBLNUM2.Size = new System.Drawing.Size(59, 13);
            this.LBLNUM2.TabIndex = 2;
            this.LBLNUM2.Text = "Numero 2 :";
            // 
            // LBLRES
            // 
            this.LBLRES.AutoSize = true;
            this.LBLRES.Location = new System.Drawing.Point(12, 131);
            this.LBLRES.Name = "LBLRES";
            this.LBLRES.Size = new System.Drawing.Size(61, 13);
            this.LBLRES.TabIndex = 3;
            this.LBLRES.Text = "Resultado :";
            // 
            // TXTNUM2
            // 
            this.TXTNUM2.Location = new System.Drawing.Point(148, 75);
            this.TXTNUM2.Name = "TXTNUM2";
            this.TXTNUM2.Size = new System.Drawing.Size(100, 20);
            this.TXTNUM2.TabIndex = 4;
            this.TXTNUM2.TextChanged += new System.EventHandler(this.TXTNUM2_TextChanged);
            // 
            // TXTRES
            // 
            this.TXTRES.Location = new System.Drawing.Point(148, 124);
            this.TXTRES.Name = "TXTRES";
            this.TXTRES.ReadOnly = true;
            this.TXTRES.Size = new System.Drawing.Size(100, 20);
            this.TXTRES.TabIndex = 5;
            // 
            // CMDCAL
            // 
            this.CMDCAL.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDCAL.Location = new System.Drawing.Point(297, 29);
            this.CMDCAL.Name = "CMDCAL";
            this.CMDCAL.Size = new System.Drawing.Size(102, 23);
            this.CMDCAL.TabIndex = 6;
            this.CMDCAL.Text = "&Calcular";
            this.CMDCAL.UseVisualStyleBackColor = true;
            this.CMDCAL.Click += new System.EventHandler(this.CMDCAL_Click);
            // 
            // CMDSAL
            // 
            this.CMDSAL.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDSAL.Location = new System.Drawing.Point(297, 75);
            this.CMDSAL.Name = "CMDSAL";
            this.CMDSAL.Size = new System.Drawing.Size(102, 23);
            this.CMDSAL.TabIndex = 7;
            this.CMDSAL.Text = "&Salida";
            this.CMDSAL.UseVisualStyleBackColor = true;
            this.CMDSAL.Click += new System.EventHandler(this.CMDSAL_Click);
            // 
            // FRMEJEMPLO12
            // 
            this.AcceptButton = this.CMDCAL;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDCAL;
            this.ClientSize = new System.Drawing.Size(433, 190);
            this.Controls.Add(this.CMDSAL);
            this.Controls.Add(this.CMDCAL);
            this.Controls.Add(this.TXTRES);
            this.Controls.Add(this.TXTNUM2);
            this.Controls.Add(this.LBLRES);
            this.Controls.Add(this.LBLNUM2);
            this.Controls.Add(this.TXTNUM1);
            this.Controls.Add(this.LBLNUM);
            this.Name = "FRMEJEMPLO12";
            this.Text = "Ejemplo 12";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLNUM;
        private System.Windows.Forms.TextBox TXTNUM1;
        private System.Windows.Forms.Label LBLNUM2;
        private System.Windows.Forms.Label LBLRES;
        private System.Windows.Forms.TextBox TXTNUM2;
        private System.Windows.Forms.TextBox TXTRES;
        private System.Windows.Forms.Button CMDCAL;
        private System.Windows.Forms.Button CMDSAL;
    }
}

