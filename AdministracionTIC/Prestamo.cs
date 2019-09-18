using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionTIC
{
    public class Prestamo
    {
        private Recurso recurso;
        private Solicitante solicitante;

        private int codigo;
        private DateTime fechaHoraEmision;
        private DateTime fechaHoraEntrega;
        private DateTime fechaHoraDevolucion;
        private String estado;
        private String observaciones;

        public Prestamo (int codigo,
            Recurso recurso, 
            Solicitante solicitante,
            DateTime fechaHoraEmision,
            DateTime fechaHoraEntrega, 
            DateTime fechaHoraDevolucion,
            String estado,
            String observaciones)
        {
            this.codigo = codigo;
            this.recurso = recurso;
            this.solicitante = solicitante;
            this.fechaHoraEmision = DateTime.Now;
            this.fechaHoraEntrega = fechaHoraEntrega;
            this.fechaHoraDevolucion = fechaHoraDevolucion;
            this.estado = estado;
            this.observaciones = observaciones;
        }

        public Prestamo() { }

        public int  Codigo
        {
            set
            {
                this.codigo = value;
            }
            get
            {
                return codigo;
            }
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

        public DateTime FechaHoraEmision
        {
            set
            {
                this.fechaHoraEmision = value;
            }
            get
            {
                return fechaHoraEmision;
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
