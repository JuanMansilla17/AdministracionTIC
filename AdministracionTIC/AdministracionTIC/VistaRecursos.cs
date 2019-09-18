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
        private GestorRecursos gestorRecursos;

        public VistaRecursos()
        {
            InitializeComponent();

            this.gestorRecursos = new GestorRecursos(this);
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void agregarNuevoButton_Click(object sender, EventArgs e)
        {
            String[] atributos = new String[8];

            try
            {
                atributos = this.gestorRecursos.agregarNuevoRecurso();

                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dataGridView);

                for (int i = 0; i < 8; i++)
                {
                    fila.Cells[i].Value = atributos[i];
                }

                dataGridView.Rows.Add(fila);

                MessageBox.Show("EL RECURSO FUÉ GUARDADO CORRECTAMENTE");

                limpiarDataSets();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaEliminada = null;

            try
            {
                if (codigoTextBox.Text != "")
                {
                    String codigoString = gestorRecursos.eliminarRecurso();

                    foreach (DataGridViewRow fila in dataGridView.Rows) 
                    {
                        if (codigoString.Equals(fila.Cells["codigo"].Value))
                        {
                            filaEliminada = fila;
                        }
                    }
                    dataGridView.Rows.Remove(filaEliminada);

                    MessageBox.Show("EL RECURSO FUÉ ELIMINADO CORRECTAMENTE");

                    limpiarDataSets();
                }
                else
                    MessageBox.Show("SELECCIONE UN RECURSO POR FAVOR");
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
                    limpiarGrilla();

                    gestorRecursos.guardarCambiosRecurso();

                    MessageBox.Show("EL RECURSO FUÉ EDITADO CORRECTAMENTE");

                    limpiarDataSets();
                } 
                else
                    MessageBox.Show("SELECCIONE UN RECURSO POR FAVOR");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void limpiarDataSets()
        {
            codigoTextBox.Text = "";
            descripcionTextBox.Text = "";
            marcaTextBox.Text = "";
            modeloTextBox.Text = "";
            aulaCheckBox.Checked = false;
            dateTimePicker.Value = DateTime.Now;
        }

        private void limpiarGrilla()
        {
            dataGridView.DataSource = null;
            dataGridView.Rows.Clear();
        }

        private void editarButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0 && dataGridView.CurrentRow.Cells["codigo"].Value != null)
            {
                codigoTextBox.Text = dataGridView.CurrentRow.Cells["codigo"].Value.ToString();
                descripcionTextBox.Text = dataGridView.CurrentRow.Cells["descripcion"].Value.ToString();
                marcaTextBox.Text = dataGridView.CurrentRow.Cells["marca"].Value.ToString();
                modeloTextBox.Text = dataGridView.CurrentRow.Cells["modelo"].Value.ToString();
                String esAulaString = dataGridView.CurrentRow.Cells["esAula"].Value.ToString();

                if (esAulaString.Equals("Aula"))
                    aulaCheckBox.Checked = true;
                else
                    aulaCheckBox.Checked = false;

                DateTime fechaGetted = DateTime.Parse(dataGridView.CurrentRow.Cells["fecha"].Value.ToString());

                dateTimePicker.Value = fechaGetted;

            }
            else
                MessageBox.Show("SELECCIONE UNA FILA POR FAVOR");

        }

        public void agregarFila(String[] atributos)
        {
            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dataGridView);

            for (int i = 0; i < 8; i++)
            {
                fila.Cells[i].Value = atributos[i];
            }

            dataGridView.Rows.Add(fila);
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
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

        private void VistaRecursos_Load(object sender, EventArgs e)
        {

        }
    }
}
