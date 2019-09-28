namespace Tarea15
{
    partial class FRMAREA
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
            this.LBLBASE = new System.Windows.Forms.Label();
            this.TXTBASE = new System.Windows.Forms.TextBox();
            this.LBLALTURA = new System.Windows.Forms.Label();
            this.TXTALTURA = new System.Windows.Forms.TextBox();
            this.LBLAREA = new System.Windows.Forms.Label();
            this.TXTAREA = new System.Windows.Forms.TextBox();
            this.CMDAREA = new System.Windows.Forms.Button();
            this.CMDSALIDA = new System.Windows.Forms.Button();
            this.CMDOTRO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLBASE
            // 
            this.LBLBASE.AutoSize = true;
            this.LBLBASE.Location = new System.Drawing.Point(77, 69);
            this.LBLBASE.Name = "LBLBASE";
            this.LBLBASE.Size = new System.Drawing.Size(65, 13);
            this.LBLBASE.TabIndex = 0;
            this.LBLBASE.Text = "La base es :";
            // 
            // TXTBASE
            // 
            this.TXTBASE.Location = new System.Drawing.Point(230, 62);
            this.TXTBASE.Name = "TXTBASE";
            this.TXTBASE.Size = new System.Drawing.Size(100, 20);
            this.TXTBASE.TabIndex = 1;
            // 
            // LBLALTURA
            // 
            this.LBLALTURA.AutoSize = true;
            this.LBLALTURA.Location = new System.Drawing.Point(77, 132);
            this.LBLALTURA.Name = "LBLALTURA";
            this.LBLALTURA.Size = new System.Drawing.Size(68, 13);
            this.LBLALTURA.TabIndex = 2;
            this.LBLALTURA.Text = "La altura es :";
            // 
            // TXTALTURA
            // 
            this.TXTALTURA.Location = new System.Drawing.Point(230, 129);
            this.TXTALTURA.Name = "TXTALTURA";
            this.TXTALTURA.Size = new System.Drawing.Size(100, 20);
            this.TXTALTURA.TabIndex = 3;
            // 
            // LBLAREA
            // 
            this.LBLAREA.AutoSize = true;
            this.LBLAREA.Location = new System.Drawing.Point(77, 201);
            this.LBLAREA.Name = "LBLAREA";
            this.LBLAREA.Size = new System.Drawing.Size(123, 13);
            this.LBLAREA.TabIndex = 4;
            this.LBLAREA.Text = "La area del triangulo es :";
            // 
            // TXTAREA
            // 
            this.TXTAREA.Location = new System.Drawing.Point(230, 198);
            this.TXTAREA.Name = "TXTAREA";
            this.TXTAREA.ReadOnly = true;
            this.TXTAREA.Size = new System.Drawing.Size(100, 20);
            this.TXTAREA.TabIndex = 5;
            // 
            // CMDAREA
            // 
            this.CMDAREA.Location = new System.Drawing.Point(99, 279);
            this.CMDAREA.Name = "CMDAREA";
            this.CMDAREA.Size = new System.Drawing.Size(90, 47);
            this.CMDAREA.TabIndex = 6;
            this.CMDAREA.Text = "&Area";
            this.CMDAREA.UseVisualStyleBackColor = true;
            this.CMDAREA.Click += new System.EventHandler(this.CMDAREA_Click);
            // 
            // CMDSALIDA
            // 
            this.CMDSALIDA.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDSALIDA.Location = new System.Drawing.Point(230, 279);
            this.CMDSALIDA.Name = "CMDSALIDA";
            this.CMDSALIDA.Size = new System.Drawing.Size(90, 47);
            this.CMDSALIDA.TabIndex = 7;
            this.CMDSALIDA.Text = "&Salida";
            this.CMDSALIDA.UseVisualStyleBackColor = true;
            this.CMDSALIDA.Click += new System.EventHandler(this.CMDSALIDA_Click);
            // 
            // CMDOTRO
            // 
            this.CMDOTRO.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CMDOTRO.Location = new System.Drawing.Point(156, 352);
            this.CMDOTRO.Name = "CMDOTRO";
            this.CMDOTRO.Size = new System.Drawing.Size(90, 21);
            this.CMDOTRO.TabIndex = 8;
            this.CMDOTRO.Text = "&Clear";
            this.CMDOTRO.UseVisualStyleBackColor = true;
            this.CMDOTRO.Click += new System.EventHandler(this.CMDOTRO_Click);
            // 
            // FRMAREA
            // 
            this.AcceptButton = this.CMDAREA;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CMDSALIDA;
            this.ClientSize = new System.Drawing.Size(413, 450);
            this.Controls.Add(this.CMDOTRO);
            this.Controls.Add(this.CMDSALIDA);
            this.Controls.Add(this.CMDAREA);
            this.Controls.Add(this.TXTAREA);
            this.Controls.Add(this.LBLAREA);
            this.Controls.Add(this.TXTALTURA);
            this.Controls.Add(this.LBLALTURA);
            this.Controls.Add(this.TXTBASE);
            this.Controls.Add(this.LBLBASE);
            this.Name = "FRMAREA";
            this.Text = "El area de triangulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLBASE;
        private System.Windows.Forms.TextBox TXTBASE;
        private System.Windows.Forms.Label LBLALTURA;
        private System.Windows.Forms.TextBox TXTALTURA;
        private System.Windows.Forms.Label LBLAREA;
        private System.Windows.Forms.TextBox TXTAREA;
        private System.Windows.Forms.Button CMDAREA;
        private System.Windows.Forms.Button CMDSALIDA;
        private System.Windows.Forms.Button CMDOTRO;
    }
}

