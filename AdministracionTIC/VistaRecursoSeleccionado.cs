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
    public partial class VistaRecursoSeleccionado : Form
    {
        private VistaPrestamo vistaPrestamo;
        const int COLUMNAS_GRILLA = 8;

        public VistaRecursoSeleccionado(VistaPrestamo vistaPrestamo)
        {
            InitializeComponent();

            this.vistaPrestamo = vistaPrestamo;
        }

        private void seleccionarRecursoButton_Click(object sender, EventArgs e)
        {
            if (recursosDisponiblesDataGridView.SelectedRows.Count > 0 && recursosDisponiblesDataGridView.CurrentRow.Cells["codigo"].Value != null)
            {
                String codigo = recursosDisponiblesDataGridView.CurrentRow.Cells["codigo"].Value.ToString();
                String descripcion = recursosDisponiblesDataGridView.CurrentRow.Cells["descripcion"].Value.ToString();
                String marca = recursosDisponiblesDataGridView.CurrentRow.Cells["marca"].Value.ToString();
                String modelo = recursosDisponiblesDataGridView.CurrentRow.Cells["modelo"].Value.ToString();

                String recursoString = codigo + "||" + descripcion + "||" + marca + "||" + modelo;

                vistaPrestamo.RecursoTextBox = recursoString;

                Close();
            }
            else
            {
                MessageBox.Show("SELECCIONE UNA FILA POR FAVOR");
            }
        }

        public void MostrarRegistro(String[] atributosRecurso)
        {
            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(recursosDisponiblesDataGridView);

            for (int indice = 0; indice < COLUMNAS_GRILLA; indice++)
            {
                fila.Cells[indice].Value = atributosRecurso[indice];
            }
            recursosDisponiblesDataGridView.Rows.Add(fila);
        }
    }
}
