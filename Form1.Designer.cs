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
            this.mnuPrinicipal = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rctTexto = new System.Windows.Forms.RichTextBox();
            this.ofpAbrir = new System.Windows.Forms.OpenFileDialog();
            this.sfdGuardar = new System.Windows.Forms.SaveFileDialog();
            this.tmrAutoguardado = new System.Windows.Forms.Timer(this.components);
            this.lblAutoguardado = new System.Windows.Forms.Label();
            this.mnuPrinicipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrinicipal
            // 
            this.mnuPrinicipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuPrinicipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.mnuPrinicipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrinicipal.Name = "mnuPrinicipal";
            this.mnuPrinicipal.Size = new System.Drawing.Size(800, 30);
            this.mnuPrinicipal.TabIndex = 0;
            this.mnuPrinicipal.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem1,
            this.abrirToolStripMenuItem1,
            this.guardarToolStripMenuItem1,
            this.guardarComoToolStripMenuItem1,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem1
            // 
            this.nuevoToolStripMenuItem1.Name = "nuevoToolStripMenuItem1";
            this.nuevoToolStripMenuItem1.Size = new System.Drawing.Size(187, 26);
            this.nuevoToolStripMenuItem1.Text = "Nuevo";
            this.nuevoToolStripMenuItem1.Click += new System.EventHandler(this.nuevoToolStripMenuItem1_Click);
            // 
            // abrirToolStripMenuItem1
            // 
            this.abrirToolStripMenuItem1.Name = "abrirToolStripMenuItem1";
            this.abrirToolStripMenuItem1.Size = new System.Drawing.Size(187, 26);
            this.abrirToolStripMenuItem1.Text = "Abrir";
            this.abrirToolStripMenuItem1.Click += new System.EventHandler(this.abrirToolStripMenuItem1_Click);
            // 
            // guardarToolStripMenuItem1
            // 
            this.guardarToolStripMenuItem1.Name = "guardarToolStripMenuItem1";
            this.guardarToolStripMenuItem1.Size = new System.Drawing.Size(187, 26);
            this.guardarToolStripMenuItem1.Text = "Guardar";
            this.guardarToolStripMenuItem1.Click += new System.EventHandler(this.guardarToolStripMenuItem1_Click);
            // 
            // guardarComoToolStripMenuItem1
            // 
            this.guardarComoToolStripMenuItem1.Name = "guardarComoToolStripMenuItem1";
            this.guardarComoToolStripMenuItem1.Size = new System.Drawing.Size(187, 26);
            this.guardarComoToolStripMenuItem1.Text = "Guardar como";
            this.guardarComoToolStripMenuItem1.Click += new System.EventHandler(this.guardarComoToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(184, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // rctTexto
            // 
            this.rctTexto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rctTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.rctTexto.Location = new System.Drawing.Point(0, 30);
            this.rctTexto.Name = "rctTexto";
            this.rctTexto.Size = new System.Drawing.Size(800, 430);
            this.rctTexto.TabIndex = 1;
            this.rctTexto.Text = "";
            this.rctTexto.TextChanged += new System.EventHandler(this.rctTexto_TextChanged);
            // 
            // ofpAbrir
            // 
            this.ofpAbrir.FileName = "openFileDialog1";
            this.ofpAbrir.Filter = "Archivo de texto |*.txt";
            // 
            // sfdGuardar
            // 
            this.sfdGuardar.Filter = "Archivo de texto |*.txt";
            // 
            // tmrAutoguardado
            // 
            this.tmrAutoguardado.Interval = 1000;
            this.tmrAutoguardado.Tick += new System.EventHandler(this.tmrAutoguardado_Tick);
            // 
            // lblAutoguardado
            // 
            this.lblAutoguardado.AutoSize = true;
            this.lblAutoguardado.Location = new System.Drawing.Point(12, 435);
            this.lblAutoguardado.Name = "lblAutoguardado";
            this.lblAutoguardado.Size = new System.Drawing.Size(0, 16);
            this.lblAutoguardado.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.lblAutoguardado);
            this.Controls.Add(this.rctTexto);
            this.Controls.Add(this.mnuPrinicipal);
            this.MainMenuStrip = this.mnuPrinicipal;
            this.Name = "Form1";
            this.Text = "Bloc de notas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mnuPrinicipal.ResumeLayout(false);
            this.mnuPrinicipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPrinicipal;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.RichTextBox rctTexto;
        private System.Windows.Forms.OpenFileDialog ofpAbrir;
        private System.Windows.Forms.SaveFileDialog sfdGuardar;
        private System.Windows.Forms.Timer tmrAutoguardado;
        private System.Windows.Forms.Label lblAutoguardado;
    }
}

