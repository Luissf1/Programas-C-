namespace Tarea25
{
    partial class FRMCON
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
            this.LBLC = new System.Windows.Forms.Label();
            this.TXTC = new System.Windows.Forms.TextBox();
            this.LBLD = new System.Windows.Forms.Label();
            this.TXTD = new System.Windows.Forms.TextBox();
            this.TXTC2 = new System.Windows.Forms.TextBox();
            this.CMDCON = new System.Windows.Forms.Button();
            this.CMDOTRO = new System.Windows.Forms.Button();
            this.LBLCON2 = new System.Windows.Forms.Label();
            this.LBLF = new System.Windows.Forms.Label();
            this.LBLY = new System.Windows.Forms.Label();
            this.LBLCM = new System.Windows.Forms.Label();
            this.LBLSALIDA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBLC
            // 
            this.LBLC.AutoSize = true;
            this.LBLC.Location = new System.Drawing.Point(12, 25);
            this.LBLC.Name = "LBLC";
            this.LBLC.Size = new System.Drawing.Size(60, 13);
            this.LBLC.TabIndex = 0;
            this.LBLC.Text = "Conversion";
            // 
            // TXTC
            // 
            this.TXTC.Location = new System.Drawing.Point(165, 30);
            this.TXTC.Name = "TXTC";
            this.TXTC.Size = new System.Drawing.Size(100, 20);
            this.TXTC.TabIndex = 1;
            // 
            // LBLD
            // 
            this.LBLD.AutoSize = true;
            this.LBLD.Location = new System.Drawing.Point(12, 69);
            this.LBLD.Name = "LBLD";
            this.LBLD.Size = new System.Drawing.Size(147, 13);
            this.LBLD.TabIndex = 2;
            this.LBLD.Text = "Ingrese el numero a convertir:";
            // 
            // TXTD
            // 
            this.TXTD.Location = new System.Drawing.Point(165, 62);
            this.TXTD.Name = "TXTD";
            this.TXTD.Size = new System.Drawing.Size(100, 20);
            this.TXTD.TabIndex = 3;
            // 
            // TXTC2
            // 
            this.TXTC2.Location = new System.Drawing.Point(32, 126);
            this.TXTC2.Name = "TXTC2";
            this.TXTC2.ReadOnly = true;
            this.TXTC2.Size = new System.Drawing.Size(115, 20);
            this.TXTC2.TabIndex = 4;
            // 
            // CMDCON
            // 
            this.CMDCON.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDCON.Location = new System.Drawing.Point(303, 25);
            this.CMDCON.Name = "CMDCON";
            this.CMDCON.Size = new System.Drawing.Size(95, 29);
            this.CMDCON.TabIndex = 5;
            this.CMDCON.Text = "&Conversion";
            this.CMDCON.UseVisualStyleBackColor = true;
            this.CMDCON.Click += new System.EventHandler(this.CMDCON_Click);
            // 
            // CMDOTRO
            // 
            this.CMDOTRO.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDOTRO.Location = new System.Drawing.Point(303, 69);
            this.CMDOTRO.Name = "CMDOTRO";
            this.CMDOTRO.Size = new System.Drawing.Size(95, 29);
            this.CMDOTRO.TabIndex = 6;
            this.CMDOTRO.Text = "&Clear";
            this.CMDOTRO.UseVisualStyleBackColor = true;
            this.CMDOTRO.Click += new System.EventHandler(this.CMDOTRO_Click);
            // 
            // LBLCON2
            // 
            this.LBLCON2.AutoSize = true;
            this.LBLCON2.Location = new System.Drawing.Point(300, 126);
            this.LBLCON2.Name = "LBLCON2";
            this.LBLCON2.Size = new System.Drawing.Size(0, 13);
            this.LBLCON2.TabIndex = 7;
            // 
            // LBLF
            // 
            this.LBLF.AutoSize = true;
            this.LBLF.Location = new System.Drawing.Point(300, 158);
            this.LBLF.Name = "LBLF";
            this.LBLF.Size = new System.Drawing.Size(0, 13);
            this.LBLF.TabIndex = 8;
            // 
            // LBLY
            // 
            this.LBLY.AutoSize = true;
            this.LBLY.Location = new System.Drawing.Point(300, 193);
            this.LBLY.Name = "LBLY";
            this.LBLY.Size = new System.Drawing.Size(0, 13);
            this.LBLY.TabIndex = 9;
            // 
            // LBLCM
            // 
            this.LBLCM.AutoSize = true;
            this.LBLCM.Location = new System.Drawing.Point(300, 222);
            this.LBLCM.Name = "LBLCM";
            this.LBLCM.Size = new System.Drawing.Size(0, 13);
            this.LBLCM.TabIndex = 10;
            // 
            // LBLSALIDA
            // 
            this.LBLSALIDA.AutoSize = true;
            this.LBLSALIDA.Location = new System.Drawing.Point(300, 249);
            this.LBLSALIDA.Name = "LBLSALIDA";
            this.LBLSALIDA.Size = new System.Drawing.Size(0, 13);
            this.LBLSALIDA.TabIndex = 11;
            // 
            // FRMCON
            // 
            this.AcceptButton = this.CMDCON;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 276);
            this.Controls.Add(this.LBLSALIDA);
            this.Controls.Add(this.LBLCM);
            this.Controls.Add(this.LBLY);
            this.Controls.Add(this.LBLF);
            this.Controls.Add(this.LBLCON2);
            this.Controls.Add(this.CMDOTRO);
            this.Controls.Add(this.CMDCON);
            this.Controls.Add(this.TXTC2);
            this.Controls.Add(this.TXTD);
            this.Controls.Add(this.LBLD);
            this.Controls.Add(this.TXTC);
            this.Controls.Add(this.LBLC);
            this.Name = "FRMCON";
            this.Text = "Conversion";
            this.Load += new System.EventHandler(this.FRMCON_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLC;
        private System.Windows.Forms.TextBox TXTC;
        private System.Windows.Forms.Label LBLD;
        private System.Windows.Forms.TextBox TXTD;
        private System.Windows.Forms.TextBox TXTC2;
        private System.Windows.Forms.Button CMDCON;
        private System.Windows.Forms.Button CMDOTRO;
        private System.Windows.Forms.Label LBLCON2;
        private System.Windows.Forms.Label LBLF;
        private System.Windows.Forms.Label LBLY;
        private System.Windows.Forms.Label LBLCM;
        private System.Windows.Forms.Label LBLSALIDA;
    }
}

