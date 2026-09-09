using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myApp01
{
    public partial class Form1 : Form
    {
        bool save = false;
        string path;
        int contadorAutoguardado, contadorLabel;

        public Form1()
        {
            InitializeComponent();

            lblAutoguardado.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(ofpAbrir.ShowDialog() == DialogResult.OK)
            {
                path = ofpAbrir.FileName;
                save = true;
                rctTexto.LoadFile(ofpAbrir.FileName, RichTextBoxStreamType.PlainText);
                guardarToolStripMenuItem1.Enabled = false;
            }
        }

        private void guardarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(save == false)
            {
                if(sfdGuardar.ShowDialog() == DialogResult.OK)
                {
                    path = sfdGuardar.FileName;
                    save = true;

                    contadorAutoguardado = 0;

                    tmrAutoguardado.Enabled = true;
                }

            }

            rctTexto.SaveFile(path, RichTextBoxStreamType.PlainText);
            guardarToolStripMenuItem1.Enabled = false;
            tmrAutoguardado.Enabled = true;
        }

        private void rctTexto_TextChanged(object sender, EventArgs e)
        {
            guardarToolStripMenuItem1.Enabled = true;
        }

        private void guardarComoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(sfdGuardar.ShowDialog() == DialogResult.OK)
            {
                path = sfdGuardar.FileName;
                rctTexto.SaveFile(path, RichTextBoxStreamType.PlainText);
                guardarToolStripMenuItem1.Enabled = false;
                save = true;

                contadorAutoguardado = 0;

                tmrAutoguardado.Enabled = true;
            }
        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            rctTexto.Clear();
            rctTexto.Focus();
            path = "";
            save = false;

            tmrAutoguardado.Enabled = false;

            contadorAutoguardado = 0;
            contadorlLabel = 0;

            lblAutoguardado.Visible = false;

        }

        private void tmrAutoguardado_Tick(object sender, EventArgs e)
        {
            contadorAutoguardado++;

            if (contadorAutoguardado == 30)
            {
                rctTexto.SaveFile(path, RichTextBoxStreamType.PlainText);

                lblAutoguardado.Text = "Autoguardando....";
                lblAutoguardado.Visible = true;

                contadorAutoguardado = 0;
            }

            if (lblAutoguardado.Visible == true) {
                
                contadorLabel++;
                
                if (contadorLabel == 3) { 
                    lblAutoguardado.Visible = false; 
                    contadorlLabel = 0; 
                } 
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
