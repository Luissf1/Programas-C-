namespace Tarea45
{
    partial class FRMTRABA
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
            this.CMDOTRO = new System.Windows.Forms.Button();
            this.CMDSALIDA = new System.Windows.Forms.Button();
            this.CMDDES = new System.Windows.Forms.Button();
            this.TXTDEP = new System.Windows.Forms.TextBox();
            this.LBLDEP = new System.Windows.Forms.Label();
            this.TXTPUES = new System.Windows.Forms.TextBox();
            this.LBLPUES = new System.Windows.Forms.Label();
            this.TXTNOM = new System.Windows.Forms.TextBox();
            this.LBLNOM = new System.Windows.Forms.Label();
            this.TXTC = new System.Windows.Forms.TextBox();
            this.LBLC = new System.Windows.Forms.Label();
            this.TXTHOR = new System.Windows.Forms.TextBox();
            this.LBLHOR = new System.Windows.Forms.Label();
            this.TXTTAB = new System.Windows.Forms.TextBox();
            this.LBLTAB = new System.Windows.Forms.Label();
            this.TXTNETO = new System.Windows.Forms.TextBox();
            this.LBLNETO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CMDOTRO
            // 
            this.CMDOTRO.Location = new System.Drawing.Point(377, 278);
            this.CMDOTRO.Name = "CMDOTRO";
            this.CMDOTRO.Size = new System.Drawing.Size(116, 23);
            this.CMDOTRO.TabIndex = 17;
            this.CMDOTRO.Text = "&Clear";
            this.CMDOTRO.UseVisualStyleBackColor = true;
            this.CMDOTRO.Click += new System.EventHandler(this.CMDOTRO_Click);
            // 
            // CMDSALIDA
            // 
            this.CMDSALIDA.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDSALIDA.Location = new System.Drawing.Point(222, 278);
            this.CMDSALIDA.Name = "CMDSALIDA";
            this.CMDSALIDA.Size = new System.Drawing.Size(116, 23);
            this.CMDSALIDA.TabIndex = 16;
            this.CMDSALIDA.Text = "&Salida";
            this.CMDSALIDA.UseVisualStyleBackColor = true;
            this.CMDSALIDA.Click += new System.EventHandler(this.CMDSALIDA_Click);
            // 
            // CMDDES
            // 
            this.CMDDES.Location = new System.Drawing.Point(72, 278);
            this.CMDDES.Name = "CMDDES";
            this.CMDDES.Size = new System.Drawing.Size(108, 23);
            this.CMDDES.TabIndex = 15;
            this.CMDDES.Text = "&Despliegue";
            this.CMDDES.UseVisualStyleBackColor = true;
            this.CMDDES.Click += new System.EventHandler(this.CMDDES_Click);
            // 
            // TXTDEP
            // 
            this.TXTDEP.Location = new System.Drawing.Point(222, 148);
            this.TXTDEP.Name = "TXTDEP";
            this.TXTDEP.ReadOnly = true;
            this.TXTDEP.Size = new System.Drawing.Size(187, 20);
            this.TXTDEP.TabIndex = 8;
            // 
            // LBLDEP
            // 
            this.LBLDEP.AutoSize = true;
            this.LBLDEP.Location = new System.Drawing.Point(60, 148);
            this.LBLDEP.Name = "LBLDEP";
            this.LBLDEP.Size = new System.Drawing.Size(77, 13);
            this.LBLDEP.TabIndex = 6;
            this.LBLDEP.Text = "Departamento:";
            // 
            // TXTPUES
            // 
            this.TXTPUES.Location = new System.Drawing.Point(222, 112);
            this.TXTPUES.Name = "TXTPUES";
            this.TXTPUES.ReadOnly = true;
            this.TXTPUES.Size = new System.Drawing.Size(187, 20);
            this.TXTPUES.TabIndex = 5;
            // 
            // LBLPUES
            // 
            this.LBLPUES.AutoSize = true;
            this.LBLPUES.Location = new System.Drawing.Point(60, 112);
            this.LBLPUES.Name = "LBLPUES";
            this.LBLPUES.Size = new System.Drawing.Size(43, 13);
            this.LBLPUES.TabIndex = 4;
            this.LBLPUES.Text = "Puesto:";
            // 
            // TXTNOM
            // 
            this.TXTNOM.Location = new System.Drawing.Point(222, 68);
            this.TXTNOM.Name = "TXTNOM";
            this.TXTNOM.ReadOnly = true;
            this.TXTNOM.Size = new System.Drawing.Size(187, 20);
            this.TXTNOM.TabIndex = 3;
            // 
            // LBLNOM
            // 
            this.LBLNOM.AutoSize = true;
            this.LBLNOM.Location = new System.Drawing.Point(60, 68);
            this.LBLNOM.Name = "LBLNOM";
            this.LBLNOM.Size = new System.Drawing.Size(47, 13);
            this.LBLNOM.TabIndex = 2;
            this.LBLNOM.Text = "Nombre:";
            // 
            // TXTC
            // 
            this.TXTC.Location = new System.Drawing.Point(222, 25);
            this.TXTC.Name = "TXTC";
            this.TXTC.ReadOnly = true;
            this.TXTC.Size = new System.Drawing.Size(187, 20);
            this.TXTC.TabIndex = 1;
            // 
            // LBLC
            // 
            this.LBLC.AutoSize = true;
            this.LBLC.Location = new System.Drawing.Point(60, 25);
            this.LBLC.Name = "LBLC";
            this.LBLC.Size = new System.Drawing.Size(43, 13);
            this.LBLC.TabIndex = 0;
            this.LBLC.Text = "Codigo:";
            // 
            // TXTHOR
            // 
            this.TXTHOR.Location = new System.Drawing.Point(222, 191);
            this.TXTHOR.Name = "TXTHOR";
            this.TXTHOR.ReadOnly = true;
            this.TXTHOR.Size = new System.Drawing.Size(187, 20);
            this.TXTHOR.TabIndex = 10;
            // 
            // LBLHOR
            // 
            this.LBLHOR.AutoSize = true;
            this.LBLHOR.Location = new System.Drawing.Point(60, 191);
            this.LBLHOR.Name = "LBLHOR";
            this.LBLHOR.Size = new System.Drawing.Size(85, 13);
            this.LBLHOR.TabIndex = 9;
            this.LBLHOR.Text = "Sueldo por hora:";
            // 
            // TXTTAB
            // 
            this.TXTTAB.Location = new System.Drawing.Point(222, 230);
            this.TXTTAB.Name = "TXTTAB";
            this.TXTTAB.ReadOnly = true;
            this.TXTTAB.Size = new System.Drawing.Size(187, 20);
            this.TXTTAB.TabIndex = 12;
            // 
            // LBLTAB
            // 
            this.LBLTAB.AutoSize = true;
            this.LBLTAB.Location = new System.Drawing.Point(60, 230);
            this.LBLTAB.Name = "LBLTAB";
            this.LBLTAB.Size = new System.Drawing.Size(88, 13);
            this.LBLTAB.TabIndex = 11;
            this.LBLTAB.Text = "Horas de trabajo:";
            // 
            // TXTNETO
            // 
            this.TXTNETO.Location = new System.Drawing.Point(455, 167);
            this.TXTNETO.Name = "TXTNETO";
            this.TXTNETO.ReadOnly = true;
            this.TXTNETO.Size = new System.Drawing.Size(73, 20);
            this.TXTNETO.TabIndex = 14;
            // 
            // LBLNETO
            // 
            this.LBLNETO.AutoSize = true;
            this.LBLNETO.Location = new System.Drawing.Point(452, 134);
            this.LBLNETO.Name = "LBLNETO";
            this.LBLNETO.Size = new System.Drawing.Size(67, 13);
            this.LBLNETO.TabIndex = 13;
            this.LBLNETO.Text = "Sueldo neto:";
            // 
            // FRMTRABA
            // 
            this.AcceptButton = this.CMDDES;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDSALIDA;
            this.ClientSize = new System.Drawing.Size(552, 327);
            this.Controls.Add(this.TXTNETO);
            this.Controls.Add(this.LBLNETO);
            this.Controls.Add(this.TXTTAB);
            this.Controls.Add(this.LBLTAB);
            this.Controls.Add(this.TXTHOR);
            this.Controls.Add(this.LBLHOR);
            this.Controls.Add(this.CMDOTRO);
            this.Controls.Add(this.CMDSALIDA);
            this.Controls.Add(this.CMDDES);
            this.Controls.Add(this.TXTDEP);
            this.Controls.Add(this.LBLDEP);
            this.Controls.Add(this.TXTPUES);
            this.Controls.Add(this.LBLPUES);
            this.Controls.Add(this.TXTNOM);
            this.Controls.Add(this.LBLNOM);
            this.Controls.Add(this.TXTC);
            this.Controls.Add(this.LBLC);
            this.Name = "FRMTRABA";
            this.Text = "Datos de empleados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CMDOTRO;
        private System.Windows.Forms.Button CMDSALIDA;
        private System.Windows.Forms.Button CMDDES;
        private System.Windows.Forms.TextBox TXTDEP;
        private System.Windows.Forms.Label LBLDEP;
        private System.Windows.Forms.TextBox TXTPUES;
        private System.Windows.Forms.Label LBLPUES;
        private System.Windows.Forms.TextBox TXTNOM;
        private System.Windows.Forms.Label LBLNOM;
        private System.Windows.Forms.TextBox TXTC;
        private System.Windows.Forms.Label LBLC;
        private System.Windows.Forms.TextBox TXTHOR;
        private System.Windows.Forms.Label LBLHOR;
        private System.Windows.Forms.TextBox TXTTAB;
        private System.Windows.Forms.Label LBLTAB;
        private System.Windows.Forms.TextBox TXTNETO;
        private System.Windows.Forms.Label LBLNETO;
    }
}

