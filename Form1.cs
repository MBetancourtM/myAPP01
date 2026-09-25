using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace myApp01
{

    public partial class Form1 : Form
    {
        List<Persona> registros = new List<Persona>();
        string rutaArchivo = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (ofdCSV.ShowDialog() == DialogResult.OK)
            {
                rutaArchivo = ofdCSV.FileName;
                using (var reader = new StreamReader(ofdCSV.FileName))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                    registros = csv.GetRecords<Persona>().ToList();
                foreach (var registro in registros)
                {
                    dgvRegistros.Rows.Add(registro.id, registro.name, registro.email);
                }
            }
        }

        private void dgvRegistros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Form2 editar = new Form2(
                dgvRegistros.Rows[e.RowIndex].Cells[1].Value.ToString(),
                dgvRegistros.Rows[e.RowIndex].Cells[2].Value.ToString()
                );

            if (editar.ShowDialog() == DialogResult.OK)
            {
                string nombre = editar.actualizaNombre;
                string correo = editar.actualizaCorreo;
                dgvRegistros.Rows[e.RowIndex].Cells[1].Value = nombre;
                dgvRegistros.Rows[e.RowIndex].Cells[2].Value = correo;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
            {
            if (string.IsNullOrEmpty(rutaArchivo))
            {
                MessageBox.Show("Primero debes cargar un archivo CSV.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                List<Persona> listaActualizada = new List<Persona>();

                foreach (DataGridViewRow fila in dgvRegistros.Rows)
                {
                    if (!fila.IsNewRow && fila.Cells[0].Value != null)
                    {
                        listaActualizada.Add(new Persona
                        {
                            id = Convert.ToInt32(fila.Cells[0].Value),
                            name = fila.Cells[1].Value?.ToString(),
                            email = fila.Cells[2].Value?.ToString()
                        });
                    }
                }

                using (var writer = new StreamWriter(rutaArchivo))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(listaActualizada);
                }

                MessageBox.Show("¡Archivo CSV guardado y actualizado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
