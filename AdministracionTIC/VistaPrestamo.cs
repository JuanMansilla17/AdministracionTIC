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
    public partial class VistaPrestamo : Form
    {
        private VistaPrincipal vistaPrincipal;

        private GestorPrestamo gestorPrestamo;
        private const int COLUMNAS_GRILLA = 8;

        public VistaPrestamo(VistaPrincipal vistaPrincipal,
            RepositorioRecursos repositorioRecursos, 
            RepositorioSolicitante repositorioSolicitante)
        {
            InitializeComponent();

            this.vistaPrincipal = vistaPrincipal;
            gestorPrestamo = new GestorPrestamo(this, this.vistaPrincipal, repositorioRecursos, repositorioSolicitante);
        }

        public void MostrarMensaje(String mensaje)
        {
            MessageBox.Show(mensaje);
        }

        private void buscarRecursoButton_Click(object sender, EventArgs e)
        {
            try
            {
                VistaRecursoSeleccionado vistaRecursoSeleccionado = new VistaRecursoSeleccionado(this);

                gestorPrestamo.BuscarRecurso(vistaRecursoSeleccionado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void buscarSolicitanteButton_Click(object sender, EventArgs e)
        {
            try
            {
                VistaSeleccionSolicitante vistaSeleccionSolicitante = new VistaSeleccionSolicitante(this);

                gestorPrestamo.BuscarSolicitante(vistaSeleccionSolicitante);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void actualCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (prestamoInmediatoCheckBox.Checked)
            {
                prestamoDateTimePicker.Value = DateTime.Now;
                horaEntregaTextBox.Text = DateTime.Now.ToString("HH");
                minutoEntregaTextBox.Text = DateTime.Now.ToString("mm");
            }
        }

        private void GuardarPrestamoButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.gestorPrestamo.GuardarPrestamo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void verPrestamosPendientesButton_Click(object sender, EventArgs e)
        {
            try
            {
                VistaPrestamosPendientes vistaPrestamosPendientes = new VistaPrestamosPendientes(this, this.gestorPrestamo);
                this.gestorPrestamo.VerPrestamosPendientes(vistaPrestamosPendientes);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void MostrarRegistro(String[] atributosPrestamo)
        {
            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(prestamoDataGridView);

            for (int indice = 0; indice < COLUMNAS_GRILLA; indice++)
            {
                fila.Cells[indice].Value = atributosPrestamo[indice];
            }

            prestamoDataGridView.Rows.Add(fila);
        }

        public void EliminarRegistro(String codigoString)
        {
            DataGridViewRow filaEliminada = null;

            foreach (DataGridViewRow fila in prestamoDataGridView.Rows)
            {
                if (codigoString.Equals(fila.Cells["codigo"].Value))
                {
                    filaEliminada = fila;
                }
            }

            prestamoDataGridView.Rows.Remove(filaEliminada);
        }

        public void EditarRegistro(String[] atributosPrestamo)
        {
            EliminarRegistro(atributosPrestamo[0]);

            MostrarRegistro(atributosPrestamo);
        }

        private void LimpiarDataSets()
        {
            prestamoDateTimePicker.Value = DateTime.Now;
            horaEntregaTextBox.Text = "";
            minutoEntregaTextBox.Text = "";
            horaDevolucionTextBox.Text = "";
            minutoDevolucionTextBox.Text = "";
            observacionTextBox.Text = "";
            recursoTextBox.Text = "";
            solicitanteTextBox.Text = "";
        }



        public Boolean getPrestamoInmediatoCheckBox()
        {
            return prestamoInmediatoCheckBox.Checked;
        }

        public DateTime getPrestamoDateTimePicker()
        {
            return prestamoDateTimePicker.Value;
        }

        public String getHoraEntregaTextBox()
        {
            return horaEntregaTextBox.Text;
        }

        public String getMinutoEntregaTextBox()
        {
            return minutoEntregaTextBox.Text;
        }

        public String getHoraDevolucionTextBox()
        {
            return horaDevolucionTextBox.Text;
        }

        public String getMinutoDevolucionTextBox()
        {
            return minutoDevolucionTextBox.Text;
        }

        public String RecursoTextBox
        {
            get
            {
                return recursoTextBox.Text;
            }
            set
            {
                this.recursoTextBox.Text = value;
            }
        }

        public String SolicitanteTextBox
        {
            get
            {
                return solicitanteTextBox.Text;
            }
            set
            {
                this.solicitanteTextBox.Text = value;
            }
        }

        public String GetObservacionesTextBox()
        {
            return observacionTextBox.Text;
        }

    }
}
