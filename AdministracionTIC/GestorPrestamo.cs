using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionTIC
{

    public class GestorPrestamo
    {
        private VistaPrestamo vistaPrestamo;
        private VistaPrestamosPendientes vistaPrestamosPendientes;
        private VistaPrincipal vistaPrincipal;

        private RepositorioPrestamo repositorioPrestamo;
        private RepositorioRecursos repositorioRecursos;
        private RepositorioSolicitante repositorioSolicitante;

        private const int CANTIDAD_ATRIBUTOS_RECURSO = 8;
        private const int CANTIDAD_ATRIBUTOS_PRESTAMO = 8;
        private const int CANTIDAD_ATRIBUTOS_SOLICITANTE = 9;

        public GestorPrestamo(VistaPrestamo vistaPrestamo,
            VistaPrincipal vistaPrincipal,
            RepositorioRecursos repositorioRecursos,
            RepositorioSolicitante repositorioSolicitante)
        {
            this.vistaPrestamo = vistaPrestamo;
            this.vistaPrincipal = vistaPrincipal;

            this.repositorioPrestamo = new RepositorioPrestamo();
            this.repositorioRecursos = repositorioRecursos;
            this.repositorioSolicitante = repositorioSolicitante;
        }

        public GestorPrestamo() { }

        public void BuscarRecurso(VistaRecursoSeleccionado vistaRecursoSeleccionado)
        {
            String horaEntrega = vistaPrestamo.getHoraEntregaTextBox();
            String minutoEntrega = vistaPrestamo.getMinutoEntregaTextBox();
            String horaDevolucion = vistaPrestamo.getHoraDevolucionTextBox();
            String minutoDevolucion = vistaPrestamo.getMinutoDevolucionTextBox();
            DateTime fechaPrestamo = vistaPrestamo.getPrestamoDateTimePicker();

            if (HorarioValido(horaEntrega, minutoEntrega, horaDevolucion, minutoDevolucion)
                && FechaValida(fechaPrestamo))
            {
                DateTime fechaHoraEntrega = ConstruirFechaHora(fechaPrestamo, horaEntrega, minutoEntrega);
                DateTime fechaHoraDevolucion = ConstruirFechaHora(fechaPrestamo, horaDevolucion, minutoDevolucion);

                List<Recurso> listaRecursos = this.repositorioRecursos.Recursos;
                List<Recurso> listaRecursosOcupados = ObtenerRecursosOcupados(fechaHoraEntrega, fechaHoraDevolucion);

                Boolean elRecursoEstaDisponible;

                foreach (Recurso recurso in listaRecursos)
                {
                    if (!recurso.Averiado)
                    {
                        elRecursoEstaDisponible = true;
                        foreach (Recurso recursoOcupado in listaRecursosOcupados)
                        {
                            if (recurso.Codigo == recursoOcupado.Codigo)
                            {
                                elRecursoEstaDisponible = false;
                            }
                        }
                        if (elRecursoEstaDisponible)
                        {
                            vistaRecursoSeleccionado.MostrarRegistro(recurso.Atributos);

                            vistaRecursoSeleccionado.Show();
                        }
                    }
                }
            }
        }

        public void BuscarSolicitante(VistaSeleccionSolicitante vistaSeleccionSolicitante)
        {
            List<Solicitante> listaSolicitantes = repositorioSolicitante.Solicitantes;

            foreach (Solicitante solicitante in listaSolicitantes)
            {
                if (solicitante.Habilitado)
                {
                    vistaSeleccionSolicitante.MostrarRegistro(solicitante.Atributos);
                }
            }

            vistaSeleccionSolicitante.Show();
        }

        public void GuardarPrestamo()
        {
            String horaEntregaString = vistaPrestamo.getHoraEntregaTextBox();
            String minutoEntregaString = vistaPrestamo.getMinutoEntregaTextBox();
            String horaDevolucionString = vistaPrestamo.getHoraDevolucionTextBox();
            String minutoDevolucionString = vistaPrestamo.getMinutoDevolucionTextBox();
            DateTime fechaPrestamo = vistaPrestamo.getPrestamoDateTimePicker();
            String recursoString = vistaPrestamo.RecursoTextBox;
            String solicitanteString = vistaPrestamo.SolicitanteTextBox;
            String observaciones = vistaPrestamo.GetObservacionesTextBox();

            if (CamposValidos(horaEntregaString, minutoEntregaString, horaDevolucionString, minutoDevolucionString,
                fechaPrestamo, recursoString, solicitanteString, observaciones))
            {
                DateTime fechaHoraEntrega = ConstruirFechaHora(fechaPrestamo, horaEntregaString, minutoEntregaString);
                DateTime fechaHoraDevolucion = ConstruirFechaHora(fechaPrestamo, horaDevolucionString, minutoDevolucionString);
                Recurso recurso = GetRecurso(GetCodigoRecursoSeleccionado(recursoString));
                Solicitante solicitante = GetSolicitante(GetCodigoSolicitanteSeleccionado(solicitanteString));
                int codigo = GenerarCodigo();

                String estado;
                if (vistaPrestamo.getPrestamoInmediatoCheckBox()) estado = "prestado";
                else estado = "pendiente";

                DateTime fechaHoraEmision = DateTime.Now;

                Prestamo prestamo = new Prestamo(codigo, recurso, solicitante, fechaHoraEmision, fechaHoraEntrega,
                    fechaHoraDevolucion, estado, observaciones);

                this.repositorioPrestamo.agregarPrestamo(prestamo);

                this.vistaPrincipal.RepositorioPrestamoPropiedad = this.repositorioPrestamo;

                vistaPrestamo.MostrarRegistro(prestamo.Atributos);

                vistaPrestamo.MostrarMensaje("EL PRÉSTAMO FUÉ GUARDADO CORRECTAMENTE");
            }

        }

        public void ConcretarPréstamo(String codigoString, String fechaHorarioEntregaString)
        {
            int codigo = int.Parse(codigoString);
            DateTime fechaHorarioEntrega = DateTime.Parse(fechaHorarioEntregaString);

            if (fechaHorarioEntrega <= DateTime.Now)
            {
                Prestamo prestamo = GetPrestamo(codigo);
                prestamo.Estado = "prestado";
                this.repositorioPrestamo.editarPrestamo(prestamo);
                this.vistaPrestamo.EditarRegistro(prestamo.Atributos);
                this.vistaPrestamosPendientes.EliminarRegistro(codigoString);
                this.vistaPrestamosPendientes.MostrarMensaje("SE CONCRETÓ EL PRÉSTAMO CORRECTAMENTE");
            }
            else
            {
                this.vistaPrestamosPendientes.MostrarMensaje("PARA CONCRETAR EL PRÉSTAMO SE DEBE CUMPLIR EL HORARIO DE ENTREGA: " + fechaHorarioEntrega.ToString("hh:mm"));
            }
        }

        public void VerPrestamosPendientes(VistaPrestamosPendientes vistaPrestamosPendientes)
        {
            Boolean hayPrestamosPendientes = false;
            this.vistaPrestamosPendientes = vistaPrestamosPendientes;

            List<Prestamo> listaPrestamos = this.repositorioPrestamo.Prestamos;

            foreach (Prestamo prestamo in listaPrestamos)
            {
                if (prestamo.Estado.Equals("pendiente"))
                {
                    this.vistaPrestamosPendientes.MostrarRegistro(prestamo.Atributos);
                    hayPrestamosPendientes = true;
                }
            }

            if (hayPrestamosPendientes) this.vistaPrestamosPendientes.Show();
            else this.vistaPrestamo.MostrarMensaje("ACTUALMENTE NO HAY PRÉSTAMOS PENDIENTES");
        }




        private Boolean CamposValidos(String horaEntrega,
            String minutoEntrega,
            String horaDevolucion,
            String minutoDevolucion,
            DateTime fechaPrestamo,
            String recursoString,
            String solicitanteString,
            String observaciones)
        {
            Boolean camposValidos = true;

            if (!HorarioValido(horaEntrega, minutoEntrega, horaDevolucion, minutoDevolucion)
                || !FechaValida(fechaPrestamo))
            {
                camposValidos = false;
            }
            else
            {
                DateTime fechaHoraEntrega = ConstruirFechaHora(fechaPrestamo, horaEntrega, minutoEntrega);
                DateTime fechaHoraDevolucion = ConstruirFechaHora(fechaPrestamo, horaDevolucion, minutoDevolucion);
                int codigoRecurso = GetCodigoRecursoSeleccionado(recursoString);

                if (!RecursoDisponible(codigoRecurso, fechaHoraEntrega, fechaHoraDevolucion))
                {
                    camposValidos = false;
                }

            }

            return camposValidos;
        }

        private Recurso GetRecurso(int codigo)
        {
            List<Recurso> recursos = repositorioRecursos.Recursos;
            Recurso recursoReturn = new Recurso();

            foreach (Recurso recurso in recursos)
            {
                if (codigo == recurso.Codigo)
                {
                    recursoReturn = recurso;
                }
            }

            return recursoReturn;
        }

        private Solicitante GetSolicitante(int codigo)
        {
            List<Solicitante> solicitantes = repositorioSolicitante.Solicitantes;
            Solicitante solicitanteReturn = new Solicitante();

            foreach (Solicitante solicitante in solicitantes)
            {
                if (codigo == solicitante.Codigo)
                {
                    solicitanteReturn = solicitante;
                }
            }

            return solicitanteReturn;
        }

        private Prestamo GetPrestamo(int codigo)
        {
            List<Prestamo> prestamos = repositorioPrestamo.Prestamos;
            Prestamo prestamoReturn = new Prestamo();

            foreach (Prestamo prestamo in prestamos)
            {
                if (codigo == prestamo.Codigo)
                {
                    prestamoReturn = prestamo;
                }
            }

            return prestamoReturn;
        }

        private Boolean RecursoDisponible(int codigoRecurso, DateTime fechaHoraEntrega, DateTime fechaHoraDevolucion)
        {
            Boolean recursoDisponible = true;

            List<Recurso> listaRecursosOcupados = ObtenerRecursosOcupados(fechaHoraEntrega, fechaHoraDevolucion);

            foreach (Recurso recursoOcupado in listaRecursosOcupados)
            {
                if (codigoRecurso == recursoOcupado.Codigo)
                {
                    recursoDisponible = false;
                    vistaPrestamo.MostrarMensaje("EL RECURSO SELECCIONADO NO ESTÁ DISPONIBLE");
                }
            }

            return recursoDisponible;
        }

        private int GetCodigoRecursoSeleccionado(String recursoString)
        {
            int cifrasCodigo = 0;

            do
            {
                if (!recursoString.Substring(cifrasCodigo, 1).Equals("|"))
                {
                    cifrasCodigo++;
                }
            } while (!recursoString.Substring(cifrasCodigo, 1).Equals("|"));

            String codigoString = recursoString.Substring(0, cifrasCodigo);

            int codigoRecurso = int.Parse(codigoString);

            return codigoRecurso;
        }

        private int GetCodigoSolicitanteSeleccionado(String solicitanteString)
        {
            int cifrasCodigo = 0;

            do
            {
                if (!solicitanteString.Substring(cifrasCodigo, 1).Equals("|"))
                {
                    cifrasCodigo++;
                }
            } while (!solicitanteString.Substring(cifrasCodigo, 1).Equals("|"));

            String codigoString = solicitanteString.Substring(0, cifrasCodigo);

            int codigoSolicitante = int.Parse(codigoString);

            return codigoSolicitante;

        }

        public DateTime ConstruirFechaHora(DateTime fecha, String hora, String minuto)
        {
            String diaString = fecha.ToString("dd");
            String mesString = fecha.ToString("MM");
            String yearString = fecha.ToString("yy");

            DateTime fechaHora = new DateTime(int.Parse(yearString) + 2000,
                int.Parse(mesString),
                int.Parse(diaString),
                int.Parse(hora),
                int.Parse(minuto),
                0);

            return fechaHora;
        }

        public Boolean CoinsidenHorarios(Prestamo prestamo, DateTime fechaHoraEntrega, DateTime fechaHoraDevolucion)
        {
            Boolean coinsidenHorarios = false;

            if ((fechaHoraEntrega >= prestamo.FechaHoraEntrega
                && fechaHoraEntrega <= prestamo.FechaHoraDevolucion)
                || (fechaHoraDevolucion >= prestamo.FechaHoraEntrega
                && fechaHoraDevolucion <= prestamo.FechaHoraDevolucion))
            {
                coinsidenHorarios = true;
            }

            return coinsidenHorarios;
        }

        public List<Recurso> ObtenerRecursosOcupados(DateTime fechaHoraEntrega, DateTime fechaHoraDevolucion)
        {
            List<Prestamo> listaPrestamos = this.repositorioPrestamo.Prestamos;

            var listaRecursosOcupados = new List<Recurso>();

            foreach (Prestamo prestamo in listaPrestamos)
            {
                if (CoinsidenHorarios(prestamo, fechaHoraEntrega, fechaHoraDevolucion))
                {
                    listaRecursosOcupados.Add(prestamo.Recurso);
                }
            }

            return listaRecursosOcupados;
        }

        public Boolean FechaValida(DateTime fechaPrestamo)
        {
            Boolean fechaValida = true;

            if (fechaPrestamo < DateTime.Today)
            {
                fechaValida = false;
                vistaPrestamo.MostrarMensaje("LA FECHA INGRESADA NO ES VÁLIDA");
            }

            DateTime fechaLimite = DateTime.Now.AddMonths(1);

            if (fechaPrestamo > fechaLimite)
            {
                fechaValida = false;
                vistaPrestamo.MostrarMensaje("LA FECHA DEL PRÉSTAMO NO PUEDE SUPERAR LA FECHA LÍMITE: " + fechaLimite.ToString());
            }

            return fechaValida;
        }

        public Boolean HorarioValido(String horaEntregaString,
            String minutoEntregaString,
            String horaDevolucionString,
            String minutoDevolucionString)
        {
            Boolean horarioValido = true;

            if (CampoVacio(horaEntregaString) ||
                CampoVacio(minutoEntregaString) ||
                CampoVacio(horaDevolucionString) ||
                CampoVacio(minutoDevolucionString))
            {
                horarioValido = false;
                vistaPrestamo.MostrarMensaje("UNO DE LOS CAMPOS DEL HORARIO SE ENCUENTRA VACÍO");
            }
            else
            {
                try
                {
                    int horaEntrega = int.Parse(horaEntregaString);
                    int minutoEntrega = int.Parse(minutoEntregaString);
                    int horaDevolucion = int.Parse(horaDevolucionString);
                    int minutoDevolucion = int.Parse(minutoDevolucionString);

                    if (horaEntrega >= 24 || horaEntrega < 0 ||
                        horaDevolucion >= 24 || horaDevolucion < 0 ||
                        minutoEntrega >= 60 || minutoEntrega < 0 ||
                        minutoDevolucion >= 60 || minutoDevolucion < 0)
                    {
                        horarioValido = false;
                        vistaPrestamo.MostrarMensaje("UNO DE LOS CAMPOS DEL HORARIO ES INCORRECTO");
                    }

                    if (horaEntrega > horaDevolucion)
                    {
                        horarioValido = false;
                        vistaPrestamo.MostrarMensaje("LA HORA DE DEVOLUCIÓN DEBE SER POSTERIOR A LA HORA DE ENTREGA");
                    }
                    else if (horaEntrega == horaDevolucion && minutoEntrega > minutoDevolucion)
                    {
                        horarioValido = false;
                        vistaPrestamo.MostrarMensaje("LA HORA DE DEVOLUCIÓN DEBE SER POSTERIOR A LA HORA DE ENTREGA");
                    }
                }
                catch (Exception)
                {
                    throw new Exception("EL HORARIO INGRESADO ES INVÁLIDO");
                }
            }
            
            return horarioValido;
        }

        private Boolean CampoVacio(String campo)
        {
            Boolean campoVacio = false;

            if (campo.Length == 0)
            {
                campoVacio = true;
            }

            return campoVacio;
        }

        private int GenerarCodigo()
        {
            int codigo;
            Boolean codigoDisponible = true;
            List<Prestamo> prestamos = repositorioPrestamo.Prestamos;

            var random = new Random();

            do
            {
                codigo = random.Next(0, 99999);

                foreach (Prestamo prestamo in prestamos)
                {
                    if (codigo == prestamo.Codigo)
                    {
                        codigoDisponible = false;
                    }
                }
            } while (!codigoDisponible);

            return codigo;
        }


    }
}
