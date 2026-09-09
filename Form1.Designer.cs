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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblReloj = new System.Windows.Forms.Label();
            this.tmrReloj = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arcvhioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurarAlarmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wmpAlarma = new AxWMPLib.AxWindowsMediaPlayer();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpAlarma)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReloj
            // 
            this.lblReloj.AutoSize = true;
            this.lblReloj.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F);
            this.lblReloj.Location = new System.Drawing.Point(12, 38);
            this.lblReloj.Name = "lblReloj";
            this.lblReloj.Size = new System.Drawing.Size(60, 65);
            this.lblReloj.TabIndex = 0;
            this.lblReloj.Text = "0";
            // 
            // tmrReloj
            // 
            this.tmrReloj.Enabled = true;
            this.tmrReloj.Tick += new System.EventHandler(this.tmrReloj_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arcvhioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arcvhioToolStripMenuItem
            // 
            this.arcvhioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurarAlarmaToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.arcvhioToolStripMenuItem.Name = "arcvhioToolStripMenuItem";
            this.arcvhioToolStripMenuItem.Size = new System.Drawing.Size(73, 26);
            this.arcvhioToolStripMenuItem.Text = "Archivo";
            // 
            // configurarAlarmaToolStripMenuItem
            // 
            this.configurarAlarmaToolStripMenuItem.Name = "configurarAlarmaToolStripMenuItem";
            this.configurarAlarmaToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.configurarAlarmaToolStripMenuItem.Text = "Configurar alarma";
            this.configurarAlarmaToolStripMenuItem.Click += new System.EventHandler(this.configurarAlarmaToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(209, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // wmpAlarma
            // 
            this.wmpAlarma.Enabled = true;
            this.wmpAlarma.Location = new System.Drawing.Point(539, 120);
            this.wmpAlarma.Name = "wmpAlarma";
            this.wmpAlarma.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpAlarma.OcxState")));
            this.wmpAlarma.Size = new System.Drawing.Size(249, 58);
            this.wmpAlarma.TabIndex = 2;
            this.wmpAlarma.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 180);
            this.Controls.Add(this.wmpAlarma);
            this.Controls.Add(this.lblReloj);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpAlarma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReloj;
        private System.Windows.Forms.Timer tmrReloj;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arcvhioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurarAlarmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private AxWMPLib.AxWindowsMediaPlayer wmpAlarma;
    }
}

