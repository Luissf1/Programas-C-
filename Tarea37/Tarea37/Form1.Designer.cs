namespace Tarea37
{
    partial class FRMPAR
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
            this.TXTPAR = new System.Windows.Forms.TextBox();
            this.TXTSUMA = new System.Windows.Forms.TextBox();
            this.TXTMED = new System.Windows.Forms.TextBox();
            this.CMDCAPTURA = new System.Windows.Forms.Button();
            this.CMOTRO = new System.Windows.Forms.Button();
            this.CMDSALIDA = new System.Windows.Forms.Button();
            this.LBLCAP = new System.Windows.Forms.Label();
            this.LBLSUM = new System.Windows.Forms.Label();
            this.LBLMED = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTPAR1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TXTPAR
            // 
            this.TXTPAR.Location = new System.Drawing.Point(40, 61);
            this.TXTPAR.Multiline = true;
            this.TXTPAR.Name = "TXTPAR";
            this.TXTPAR.ReadOnly = true;
            this.TXTPAR.Size = new System.Drawing.Size(182, 113);
            this.TXTPAR.TabIndex = 1;
            this.TXTPAR.TextChanged += new System.EventHandler(this.TXTPAR1_TextChanged);
            // 
            // TXTSUMA
            // 
            this.TXTSUMA.Location = new System.Drawing.Point(128, 180);
            this.TXTSUMA.Name = "TXTSUMA";
            this.TXTSUMA.ReadOnly = true;
            this.TXTSUMA.Size = new System.Drawing.Size(139, 20);
            this.TXTSUMA.TabIndex = 3;
            // 
            // TXTMED
            // 
            this.TXTMED.Location = new System.Drawing.Point(128, 245);
            this.TXTMED.Name = "TXTMED";
            this.TXTMED.ReadOnly = true;
            this.TXTMED.Size = new System.Drawing.Size(139, 20);
            this.TXTMED.TabIndex = 7;
            // 
            // CMDCAPTURA
            // 
            this.CMDCAPTURA.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDCAPTURA.Location = new System.Drawing.Point(355, 47);
            this.CMDCAPTURA.Name = "CMDCAPTURA";
            this.CMDCAPTURA.Size = new System.Drawing.Size(97, 46);
            this.CMDCAPTURA.TabIndex = 8;
            this.CMDCAPTURA.Text = "&Captura";
            this.CMDCAPTURA.UseVisualStyleBackColor = true;
            this.CMDCAPTURA.Click += new System.EventHandler(this.CMDPAR_Click);
            // 
            // CMOTRO
            // 
            this.CMOTRO.Location = new System.Drawing.Point(355, 122);
            this.CMOTRO.Name = "CMOTRO";
            this.CMOTRO.Size = new System.Drawing.Size(97, 46);
            this.CMOTRO.TabIndex = 9;
            this.CMOTRO.Text = "&Clear";
            this.CMOTRO.UseVisualStyleBackColor = true;
            this.CMOTRO.Click += new System.EventHandler(this.CMOTRO_Click);
            // 
            // CMDSALIDA
            // 
            this.CMDSALIDA.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDSALIDA.Location = new System.Drawing.Point(355, 201);
            this.CMDSALIDA.Name = "CMDSALIDA";
            this.CMDSALIDA.Size = new System.Drawing.Size(97, 46);
            this.CMDSALIDA.TabIndex = 10;
            this.CMDSALIDA.Text = "&Salida";
            this.CMDSALIDA.UseVisualStyleBackColor = true;
            this.CMDSALIDA.Click += new System.EventHandler(this.CMDSALIDA_Click);
            // 
            // LBLCAP
            // 
            this.LBLCAP.AutoSize = true;
            this.LBLCAP.Location = new System.Drawing.Point(74, 30);
            this.LBLCAP.Name = "LBLCAP";
            this.LBLCAP.Size = new System.Drawing.Size(78, 13);
            this.LBLCAP.TabIndex = 0;
            this.LBLCAP.Text = "Numeros pares";
            // 
            // LBLSUM
            // 
            this.LBLSUM.AutoSize = true;
            this.LBLSUM.Location = new System.Drawing.Point(17, 187);
            this.LBLSUM.Name = "LBLSUM";
            this.LBLSUM.Size = new System.Drawing.Size(65, 13);
            this.LBLSUM.TabIndex = 2;
            this.LBLSUM.Text = "Su suma es:";
            // 
            // LBLMED
            // 
            this.LBLMED.AutoSize = true;
            this.LBLMED.Location = new System.Drawing.Point(17, 252);
            this.LBLMED.Name = "LBLMED";
            this.LBLMED.Size = new System.Drawing.Size(68, 13);
            this.LBLMED.TabIndex = 6;
            this.LBLMED.Text = "Su media es:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Numeros pares:";
            // 
            // TXTPAR1
            // 
            this.TXTPAR1.Location = new System.Drawing.Point(128, 215);
            this.TXTPAR1.Name = "TXTPAR1";
            this.TXTPAR1.ReadOnly = true;
            this.TXTPAR1.Size = new System.Drawing.Size(139, 20);
            this.TXTPAR1.TabIndex = 5;
            // 
            // FRMPAR
            // 
            this.AcceptButton = this.CMDCAPTURA;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDSALIDA;
            this.ClientSize = new System.Drawing.Size(531, 277);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTPAR1);
            this.Controls.Add(this.LBLMED);
            this.Controls.Add(this.LBLSUM);
            this.Controls.Add(this.LBLCAP);
            this.Controls.Add(this.CMDSALIDA);
            this.Controls.Add(this.CMOTRO);
            this.Controls.Add(this.CMDCAPTURA);
            this.Controls.Add(this.TXTMED);
            this.Controls.Add(this.TXTSUMA);
            this.Controls.Add(this.TXTPAR);
            this.Name = "FRMPAR";
            this.Text = "Numeros pares";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TXTPAR;
        private System.Windows.Forms.TextBox TXTSUMA;
        private System.Windows.Forms.TextBox TXTMED;
        private System.Windows.Forms.Button CMDCAPTURA;
        private System.Windows.Forms.Button CMOTRO;
        private System.Windows.Forms.Button CMDSALIDA;
        private System.Windows.Forms.Label LBLCAP;
        private System.Windows.Forms.Label LBLSUM;
        private System.Windows.Forms.Label LBLMED;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTPAR1;
    }
}

