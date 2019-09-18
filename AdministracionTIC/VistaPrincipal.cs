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
    public partial class VistaPrincipal : Form
    {
        private RepositorioPrestamo repositorioPrestamo;
        private RepositorioRecursos repositorioRecurso;
        private RepositorioSolicitante repositorioSolicitante;

        
        private const int CANTIDAD_ATRIBUTOS_RECURSO = 8;
        private const int CANTIDAD_ATRIBUTOS_SOLICITANTE = 9;
        private const int CANTIDAD_ATRIBUTOS_PRESTAMO = 8;

        public VistaPrincipal()
        {
            InitializeComponent();
            this.repositorioRecurso = null;
            this.repositorioPrestamo = null;
            this.repositorioSolicitante = null;
        }

        private void aBMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vistaRecursos = new VistaRecursos(this);

            if (this.repositorioRecurso != null)
            {
                CargarDataGridView(vistaRecursos);
            }

            vistaRecursos.Show();
        }

        private void aBMToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var vistaSolicitante = new VistaSolicitante(this);

            if (this.repositorioSolicitante != null)
            {
                CargarDataGridView(vistaSolicitante);
            }

            vistaSolicitante.Show();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vistaPrestamo = new VistaPrestamo(this,this.repositorioRecurso, this.repositorioSolicitante);

            if (this.repositorioPrestamo != null)
            {
                CargarDataGridView(vistaPrestamo);
            }

            vistaPrestamo.Show();
        }


        private void CargarDataGridView(VistaRecursos vistaRecursos)
        {
            List<Recurso> recursos = this.repositorioRecurso.Recursos;

            foreach(Recurso recurso in recursos)
            {
                vistaRecursos.MostrarRegistro(ObtenerAtributos(recurso));
            }
        }

        private void CargarDataGridView(VistaSolicitante vistaSolicitante)
        {
            List<Solicitante> solicitantes = this.repositorioSolicitante.Solicitantes;

            foreach (Solicitante solicitante in solicitantes)
            {
                vistaSolicitante.MostrarRegistro(ObtenerAtributos(solicitante));
            }
        }

        private void CargarDataGridView(VistaPrestamo vistaPrestamo)
        {
            List<Prestamo> prestamos = this.repositorioPrestamo.Prestamos;

            foreach (Prestamo prestamo in prestamos)
            {
                vistaPrestamo.MostrarRegistro(ObtenerAtributos(prestamo));
            }
        }



        private String[] ObtenerAtributos(Recurso recurso)
        {
            String[] atributos = new String[CANTIDAD_ATRIBUTOS_RECURSO];

            atributos[0] = recurso.Codigo.ToString();
            atributos[1] = recurso.Descripcion;
            atributos[2] = recurso.Fecha.ToString("dd/MM/yyyy");

            if (recurso.Averiado)
            {
                atributos[3] = "Averiado";
                atributos[4] = recurso.Observaciones;
            }
            else
            {
                atributos[3] = "Disponible";
                atributos[4] = "";
            }


            if (recurso.EsAula)
            {
                atributos[5] = "";
                atributos[6] = "";
                atributos[7] = "Aula";
            }
            else
            {
                atributos[5] = recurso.Marca;
                atributos[6] = recurso.Modelo;
                atributos[7] = "Movil";
            }

            return atributos;
        }

        private String[] ObtenerAtributos(Solicitante solicitante)
        {
            String[] atributos = new String[CANTIDAD_ATRIBUTOS_SOLICITANTE];

            atributos[0] = solicitante.Codigo.ToString();
            atributos[1] = solicitante.Nombre;
            atributos[2] = solicitante.Apellido;
            atributos[3] = solicitante.Dni;
            atributos[4] = solicitante.Cargo;
            atributos[5] = solicitante.Telefono;
            atributos[6] = solicitante.Mail;
            atributos[7] = solicitante.Universidad;
            atributos[8] = solicitante.Estado;

            return atributos;
        }

        private String[] ObtenerAtributos(Prestamo prestamo)
        {
            String[] atributos = new String[CANTIDAD_ATRIBUTOS_PRESTAMO];

            atributos[0] = prestamo.Codigo.ToString();
            atributos[1] = prestamo.Recurso.ToString();
            atributos[2] = prestamo.Solicitante.ToString();
            atributos[3] = prestamo.FechaHoraEmision.ToString();
            atributos[4] = prestamo.FechaHoraEntrega.ToString();
            atributos[5] = prestamo.FechaHoraDevolucion.ToString();
            atributos[6] = prestamo.Estado;
            atributos[7] = prestamo.Observaciones;

            return atributos;
        }



        public RepositorioPrestamo RepositorioPrestamoPropiedad
        {
            get
            {
                return this.repositorioPrestamo;
            }
            set
            {
                this.repositorioPrestamo = value;
            }
        }

        public RepositorioRecursos RepositorioRecursoPropiedad
        {
            get
            {
                return this.repositorioRecurso;
            }
            set
            {
                this.repositorioRecurso = value;
            }
        }

        public RepositorioSolicitante RepositorioSolicitantePropiedad
        {
            get
            {
                return this.repositorioSolicitante;
            }
            set
            {
                this.repositorioSolicitante = value;
            }
        }
    }
}
