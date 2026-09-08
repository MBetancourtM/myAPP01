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
    public partial class FormConfigurar : Form
    {
        public DateTime hora {  get; set; }
        public FormConfigurar()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            hora = dtpConfigura.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
