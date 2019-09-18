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
    public partial class VistaPrestamosPendientes : Form
    {
        private VistaPrestamo vistaPrestamo;
        private GestorPrestamo gestorPrestamo;

        private const int COLUMNAS_GRILLA = 8;

        public VistaPrestamosPendientes(VistaPrestamo vistaPrestamo, GestorPrestamo gestorPrestamo)
        {
            InitializeComponent();

            this.vistaPrestamo = vistaPrestamo;
            this.gestorPrestamo = gestorPrestamo;
        }

        private void concretarPrestamoButton_Click(object sender, EventArgs e)
        {
            if (prestamosPendientesDataGridView.SelectedRows.Count > 0 && prestamosPendientesDataGridView.CurrentRow.Cells["codigo"].Value != null)
            {
                String codigo = "";
                String fechaHorarioEntrega = "";
                
                try
                {
                    codigo = prestamosPendientesDataGridView.CurrentRow.Cells["codigo"].Value.ToString();
                    fechaHorarioEntrega = prestamosPendientesDataGridView.CurrentRow.Cells["fechaHorarioEntrega"].Value.ToString();
                    

                    this.gestorPrestamo.ConcretarPréstamo(codigo, fechaHorarioEntrega);
                }
                catch (Exception ex)
                { 
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("SELECCIONE UNA FILA POR FAVOR");
            }
        }

        public void MostrarRegistro(String[] atributosPrestamo)
        {
            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(prestamosPendientesDataGridView);

            for (int indice = 0; indice < COLUMNAS_GRILLA; indice++)
            {
                fila.Cells[indice].Value = atributosPrestamo[indice];
            }

            prestamosPendientesDataGridView.Rows.Add(fila);
        }

        public void EliminarRegistro(String codigoString)
        {
            DataGridViewRow filaEliminada = null;

            foreach (DataGridViewRow fila in prestamosPendientesDataGridView.Rows)
            {
                if (codigoString.Equals(fila.Cells["codigo"].Value))
                {
                    filaEliminada = fila;
                }
            }

            prestamosPendientesDataGridView.Rows.Remove(filaEliminada);
        }

        public void MostrarMensaje(String mensaje)
        {
            MessageBox.Show(mensaje);
        }
    }
}
