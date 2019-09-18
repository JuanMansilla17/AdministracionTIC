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
        private GestorSolicitantes gestorSolicitantes;

        const int COLUMNAS_GRILLA = 9;


        public VistaSolicitante()
        {
            InitializeComponent();

            this.gestorSolicitantes = new GestorSolicitantes(this); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*agregar nuevo*/
            try
            {
                this.gestorSolicitantes.agregarNuevoSolicitante();

                //MessageBox.Show("EL SOLICITANTE FUÉ GUARDADO CORRECTAMENTE");

                LimpiarDataSets();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if(codigoTextBox.Text != "")
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
            catch(Exception ex)
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

        private void EditarButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0 && dataGridView.CurrentRow.Cells["codigoTexTBox1"].Value != null)
            {
                codigoTextBox.Text = dataGridView.CurrentRow.Cells["codigoTextBox1"].Value.ToString();
                nombreTextBox.Text = dataGridView.CurrentRow.Cells["nombreTextBox2"].Value.ToString();
                apellidoTextBox.Text = dataGridView.CurrentRow.Cells["apellidoTextBox3"].Value.ToString();
                dniTextBox.Text = dataGridView.CurrentRow.Cells["dniTextBox4"].Value.ToString();
                cargoTextBox.Text = dataGridView.CurrentRow.Cells["cargoTextBox5"].Value.ToString();
                telefonoTextBox.Text = dataGridView.CurrentRow.Cells["telefonoTexTBox6"].Value.ToString();
                mailTextBox.Text = dataGridView.CurrentRow.Cells["mailTextBox7"].Value.ToString();
                universidadTextBox.Text = dataGridView.CurrentRow.Cells["universidadTextBox8"].Value.ToString();
                estadoTextBox.Text = dataGridView.CurrentRow.Cells["estadoTextBox9"].Value.ToString();
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
            universidadTextBox.Text = "";
            estadoTextBox.Text = "";
        }

        public void MostrarMensaje(String mensaje)
        {
            MessageBox.Show(mensaje);
        }

        public void MostrarRegistro(String[] atributosSolicitante)
        {
            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dataGridView);

            for (int indice = 0; indice < COLUMNAS_GRILLA; indice++)
            {
                fila.Cells[indice].Value = atributosSolicitante[indice];
            }

            dataGridView.Rows.Add(fila);
        }

        public void EliminarRegistro(String codigoString)
        {
            DataGridViewRow filaEliminada = null;

            foreach (DataGridViewRow fila in dataGridView.Rows)
            {
                if (codigoString.Equals(fila.Cells["codigo"].Value))
                {
                    filaEliminada = fila;
                }
            }

            dataGridView.Rows.Remove(filaEliminada);
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

        public  TextBox GetCargoTextBox()
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
        
        public TextBox GetUniversidadTextBox()
        {
            return universidadTextBox;
        }

        public TextBox GetEstadoTextBox()
        {
            return estadoTextBox;
        }

        private void cerrarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
