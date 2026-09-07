namespace myApp01
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmrReloj = new System.Windows.Forms.Timer(this.components);
            this.lblReloj = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblEjecucion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tmrReloj
            // 
            this.tmrReloj.Enabled = true;
            this.tmrReloj.Interval = 1000;
            this.tmrReloj.Tick += new System.EventHandler(this.tmrReloj_Tick);
            // 
            // lblReloj
            // 
            this.lblReloj.AutoSize = true;
            this.lblReloj.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.lblReloj.Location = new System.Drawing.Point(12, 9);
            this.lblReloj.Name = "lblReloj";
            this.lblReloj.Size = new System.Drawing.Size(63, 69);
            this.lblReloj.TabIndex = 0;
            this.lblReloj.Text = "0";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.lblFecha.Location = new System.Drawing.Point(12, 78);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(63, 69);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "0";
            // 
            // lblEjecucion
            // 
            this.lblEjecucion.AutoSize = true;
            this.lblEjecucion.Location = new System.Drawing.Point(13, 151);
            this.lblEjecucion.Name = "lblEjecucion";
            this.lblEjecucion.Size = new System.Drawing.Size(133, 16);
            this.lblEjecucion.TabIndex = 2;
            this.lblEjecucion.Text = "Tiempo en ejecución";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 207);
            this.Controls.Add(this.lblEjecucion);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblReloj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrReloj;
        private System.Windows.Forms.Label lblReloj;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblEjecucion;
    }
}

