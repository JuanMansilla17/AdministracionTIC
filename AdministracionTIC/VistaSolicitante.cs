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
    public partial class VistaSolicitante : Form
    {
        private VistaPrincipal vistaPrincipal;

        private GestorSolicitantes gestorSolicitantes;
        const int COLUMNAS_GRILLA = 9;

        public VistaSolicitante(VistaPrincipal vistaPrincipal)
        {
            InitializeComponent();

            this.vistaPrincipal = vistaPrincipal;
            this.gestorSolicitantes = new GestorSolicitantes(this, this.vistaPrincipal);
        }

        private void agregarNuevoButton_Click(object sender, EventArgs e)
        { 
            try
            {
                this.gestorSolicitantes.AgregarNuevoSolicitante();

                LimpiarDataSets();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (codigoTextBox.Text != "")
                {
                    gestorSolicitantes.EliminarSolicitante();

                    MessageBox.Show("EL SOLICITANTE FUÉ ELIMINADO CORRECTAMENTE");

                    LimpiarDataSets();
                }
                else
                {
                    MessageBox.Show("SELECCIONE UN SOLICITANTE POR FAVOR");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guardarCambiosButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (codigoTextBox.Text != "")
                {
                    gestorSolicitantes.GuardarCambiosSolicitante();

                    LimpiarDataSets();
                }
                else
                    MessageBox.Show("SELECCIONE UN SOLICITANTE POR FAVOR");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void editarButton_Click(object sender, EventArgs e)
        {
            if (solicitantesDataGridView.SelectedRows.Count > 0 && solicitantesDataGridView.CurrentRow.Cells["codigo"].Value != null)
            {
                codigoTextBox.Text = solicitantesDataGridView.CurrentRow.Cells["codigo"].Value.ToString();
                nombreTextBox.Text = solicitantesDataGridView.CurrentRow.Cells["nombre"].Value.ToString();
                apellidoTextBox.Text = solicitantesDataGridView.CurrentRow.Cells["apellido"].Value.ToString();
                dniTextBox.Text = solicitantesDataGridView.CurrentRow.Cells["dni"].Value.ToString();
                cargoTextBox.Text = solicitantesDataGridView.CurrentRow.Cells["cargo"].Value.ToString();
                telefonoTextBox.Text = solicitantesDataGridView.CurrentRow.Cells["telefono"].Value.ToString();
                mailTextBox.Text = solicitantesDataGridView.CurrentRow.Cells["mail"].Value.ToString();
                universidadComboBox.Text = solicitantesDataGridView.CurrentRow.Cells["universidad"].Value.ToString();
            }
            else
                MessageBox.Show("SELECCIONE UNA FILA POR FAVOR");
        }



        private void LimpiarDataSets()
        {
            codigoTextBox.Text = "";
            nombreTextBox.Text = "";
            apellidoTextBox.Text = "";
            dniTextBox.Text = "";
            cargoTextBox.Text = "";
            telefonoTextBox.Text = "";
            mailTextBox.Text = "";
            universidadComboBox.SelectedItem = 1;
        }

        public void MostrarMensaje(String mensaje)
        {
            MessageBox.Show(mensaje);
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

        public void EliminarRegistro(String codigoString)
        {
            DataGridViewRow filaEliminada = null;

            foreach (DataGridViewRow fila in solicitantesDataGridView.Rows)
            {
                if (codigoString.Equals(fila.Cells["codigo"].Value))
                {
                    filaEliminada = fila;
                }
            }
            solicitantesDataGridView.Rows.Remove(filaEliminada);
        }

        public void EditarRegistro(String[] atributosSolicitante)
        {
            EliminarRegistro(atributosSolicitante[0]);

            MostrarRegistro(atributosSolicitante);
        }



        public TextBox GetCodigoTextBox()
        {
            return codigoTextBox;
        }

        public TextBox GetNombreTextBox()
        {
            return nombreTextBox;
        }

        public TextBox GetApellidoTextBox()
        {
            return apellidoTextBox;
        }

        public TextBox GetDniTextBox()
        {
            return dniTextBox;
        }

        public TextBox GetCargoTextBox()
        {
            return cargoTextBox;
        }

        public TextBox GetTelefonoTextBox()
        {
            return telefonoTextBox;
        }

        public TextBox GetMailTextBox()
        {
            return mailTextBox;
        }

        public String GetUniversidadComboBox()
        {
            return universidadComboBox.Text;
        }

    }
}
