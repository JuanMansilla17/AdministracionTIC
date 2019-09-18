using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionTIC
{
    public class RepositorioPrestamo
    {
        private List<Prestamo> prestamos;

        public RepositorioPrestamo()
        {
            prestamos = new List<Prestamo>();
        }

        public void agregarPrestamo(Prestamo prestamo)
        {
            prestamos.Add(prestamo);
        }

        public List<Prestamo> Prestamos
        {
            set { }
            get
            {
                return this.prestamos;
            }
        }

        public void eliminarPrestamo(int codigo)
        {
            int indice = -1, c = 0;

            foreach (Prestamo prestamo in prestamos)
            {

                if (prestamo.Codigo == codigo)
                {
                    indice = c;
                }
                c++;
            }

            prestamos.RemoveAt(indice);
        }

        public void editarPrestamo(Prestamo prestamo)
        {
            List<Prestamo> prestamosEdicion = new List<Prestamo>();

            foreach (Prestamo objPrestamo in prestamos)
            {
                if (objPrestamo.Codigo == prestamo.Codigo)
                    prestamosEdicion.Add(prestamo);
                else
                    prestamosEdicion.Add(objPrestamo);
            }

            prestamos = prestamosEdicion;
        }
    }
}
