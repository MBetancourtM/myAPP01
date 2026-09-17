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
        List<Persona> personas = new List<Persona>();
        
        public Form1()
        {
            InitializeComponent();
            personas.Add(new Persona(1, "Francisco Hurtado", "8711668582"));
            personas.Add(new Persona(2, "Yael Álvarez", "8711121314"));
            personas.Add(new Persona(3, "Angel Betancourt", "8712121413"));
            personas.Add(new Persona(4, "Jesús Valenzuela", "8712321452"));
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dgvInformacion.Rows.Add();
            dgvInformacion[0, dgvInformacion.Rows.Count - 1].Value = dgvInformacion.Rows.Count;
            dgvInformacion[1, dgvInformacion.Rows.Count - 1].Value = txtNombre.Text;
            dgvInformacion[2, dgvInformacion.Rows.Count - 1].Value = mtbTelefono.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(var Persona in personas)
            {
                dgvInformacion.Rows.Add(Persona.Id, Persona.nombre, Persona.telefono);
            }
        }
    }
}
