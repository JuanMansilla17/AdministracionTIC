using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionTIC
{
    class Prestamo
    {
        private Recurso recurso;
        private Solicitante solicitante;

        private DateTime fechaHoraActual;
        private DateTime fechaHoraEntrega;
        private DateTime fechaHoraDevolucion;
        private String estado;
        private String observaciones;

        public Prestamo (Recurso recurso, 
            Solicitante solicitante, 
            DateTime fechaHoraEntrega, 
            DateTime fechaHoraDevolucion,
            String estado)
        {
            this.recurso = recurso;
            this.solicitante = solicitante;
            this.fechaHoraActual = DateTime.Now;
            this.fechaHoraEntrega = fechaHoraEntrega;
            this.fechaHoraDevolucion = fechaHoraDevolucion;
            this.estado = estado;
            this.observaciones = null;
        }
        public Recurso Recurso
        {
            set
            {
                this.recurso = value;
            }
            get
            {
                return recurso; 
            }
        }
        public Solicitante Solicitante
        {
            set
            {
                this.solicitante = value;
            }
            get
            {
                return solicitante;
            }
        }
        public DateTime FechaHoraActual
        {
            set
            {
                this.fechaHoraActual = value;
            }
            get
            {
                return fechaHoraActual;
            }
        }

        public DateTime FechaHoraEntrega
        {
            set
            {
                this.fechaHoraEntrega= value;
            }
            get
            {
                return fechaHoraEntrega;
            }
        }

        public DateTime FechaHoraDevolucion
        {
            set
            {
                this.fechaHoraDevolucion = value;
            }
            get
            {
                return fechaHoraDevolucion;
            }
        }

        public String Estado
        {
            set
            {
                this.estado = value;
            }
            get
            {
                return estado;
            }
        }

        public String Observaciones
        {
            set
            {
                this.observaciones = value;
            }
            get
            {
                return observaciones;
            }
        }
    } 
}
