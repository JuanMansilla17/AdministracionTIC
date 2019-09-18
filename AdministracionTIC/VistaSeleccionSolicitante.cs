using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministracionTIC
{
    public partial class VistaSeleccionSolicitante : Form
    {
        private VistaPrestamo vistaPrestamo;
        const int COLUMNAS_GRILLA = 9;

        public VistaSeleccionSolicitante(VistaPrestamo vistaPrestamo)
        {
            InitializeComponent();

            this.vistaPrestamo = vistaPrestamo;
        }

        private void seleccionarSolicitanteButton_Click(object sender, EventArgs e)
        {
            if (solicitantesDataGridView.SelectedRows.Count > 0 && solicitantesDataGridView.CurrentRow.Cells["codigo"].Value != null)
            {
                String codigo = solicitantesDataGridView.CurrentRow.Cells["codigo"].Value.ToString();
                String nombre = solicitantesDataGridView.CurrentRow.Cells["nombre"].Value.ToString();
                String apellido = solicitantesDataGridView.CurrentRow.Cells["apellido"].Value.ToString();
                String dni = solicitantesDataGridView.CurrentRow.Cells["dni"].Value.ToString();

                String solicitanteString = codigo + "||" + nombre + " " + apellido + "||" + dni;

                vistaPrestamo.SolicitanteTextBox = solicitanteString;

                Close();
            }
            else
            {
                MessageBox.Show("SELECCIONE UNA FILA POR FAVOR");
            }
        }

        public void MostrarRegistro(String[] atributosSolicitante)
        {
            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(solicitantesDataGridView);

            for (int indice = 0; indice < COLUMNAS_GRILLA; indice++)
            {
                fila.Cells[indice].Value = atributosSolicitante[indice];
            }

            solicitantesDataGridView.Rows.Add(fila);
        }
    }
}
