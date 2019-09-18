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
    public partial class VistaRecursos : Form
    {
        private VistaPrincipal vistaPrincipal;

        private GestorRecursos gestorRecursos;
        const int COLUMNAS_GRILLA = 8;

        public VistaRecursos(VistaPrincipal vistaPrincipal)
        {
            InitializeComponent();

            this.vistaPrincipal = vistaPrincipal;
            this.gestorRecursos = new GestorRecursos(this, this.vistaPrincipal);
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AgregarNuevoButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.gestorRecursos.AgregarNuevoRecurso();

                LimpiarDataSets();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (codigoTextBox.Text != "")
                {
                    gestorRecursos.EliminarRecurso();

                    MessageBox.Show("EL RECURSO FUÉ ELIMINADO CORRECTAMENTE");

                    LimpiarDataSets();
                }
                else
                    MessageBox.Show("SELECCIONE UN RECURSO POR FAVOR");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GuardarCambiosButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (codigoTextBox.Text != "")
                {
                    gestorRecursos.GuardarCambiosRecurso();

                    LimpiarDataSets();
                } 
                else
                    MessageBox.Show("SELECCIONE UN RECURSO POR FAVOR");
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }
        }

        private void EditarButton_Click(object sender, EventArgs e)
        {
            if (recursosDataGridView.SelectedRows.Count > 0 && recursosDataGridView.CurrentRow.Cells["codigo"].Value != null)
            {
                codigoTextBox.Text = recursosDataGridView.CurrentRow.Cells["codigo"].Value.ToString();
                descripcionTextBox.Text = recursosDataGridView.CurrentRow.Cells["descripcion"].Value.ToString();
                marcaTextBox.Text = recursosDataGridView.CurrentRow.Cells["marca"].Value.ToString();
                modeloTextBox.Text = recursosDataGridView.CurrentRow.Cells["modelo"].Value.ToString();
                String esAulaString = recursosDataGridView.CurrentRow.Cells["esAula"].Value.ToString();

                if (esAulaString.Equals("Aula"))
                    aulaCheckBox.Checked = true;
                else
                    aulaCheckBox.Checked = false;

                DateTime fechaGetted = DateTime.Parse(recursosDataGridView.CurrentRow.Cells["fecha"].Value.ToString());

                dateTimePicker.Value = fechaGetted;

            }
            else
                MessageBox.Show("SELECCIONE UNA FILA POR FAVOR");

        }

        

        private void LimpiarDataSets()
        {
            codigoTextBox.Text = "";
            descripcionTextBox.Text = "";
            marcaTextBox.Text = "";
            modeloTextBox.Text = "";
            aulaCheckBox.Checked = false;
            dateTimePicker.Value = DateTime.Now;
        }

        public void MostrarMensaje(String mensaje)
        {
            MessageBox.Show(mensaje);
        }

        public void MostrarRegistro(String[] atributosRecurso)
        {
            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(recursosDataGridView);

            for (int indice = 0; indice < COLUMNAS_GRILLA; indice++)
            {
                fila.Cells[indice].Value = atributosRecurso[indice];
            }

            recursosDataGridView.Rows.Add(fila);
        }

        public void EliminarRegistro(String codigoString)
        {
            DataGridViewRow filaEliminada = null;

            foreach (DataGridViewRow fila in recursosDataGridView.Rows)
            {
                if (codigoString.Equals(fila.Cells["codigo"].Value))
                {
                    filaEliminada = fila;
                }
            }

            recursosDataGridView.Rows.Remove(filaEliminada);
        }

        public void EditarRegistro (String[] atributosRecurso)
        {
            EliminarRegistro(atributosRecurso[0]);

            MostrarRegistro(atributosRecurso);
        }


        



        public Boolean getAulaCheckBox()
        {
            return aulaCheckBox.Checked;
        }

        public TextBox getCodigoTextBox()
        {
            return codigoTextBox;
        }

        public TextBox getDescripcionTextBox()
        {
            return descripcionTextBox;
        }

        public TextBox getMarcaTextBox()
        {
            return marcaTextBox;
        }

        public TextBox getModeloTextBox()
        {
            return modeloTextBox;
        }

        public DateTime getFechaTextBox()
        {
            return dateTimePicker.Value;
        }

        }
}
