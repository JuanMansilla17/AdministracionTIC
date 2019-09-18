using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionTIC
{
    class RepositorioRecursos
    {
        private List<Recurso> recursos;

        public RepositorioRecursos()
        {
            recursos = new List<Recurso>();
        }

        public void agregarRecurso(Recurso recurso)
        {
            recursos.Add(recurso);
        }

        public List<Recurso> Recursos
        {
            set { }
            get
            {
                return this.recursos;
            }
        }

        public void eliminarRecurso(int codigo)
        {
            int indice=-1, c = 0;

            foreach (Recurso recurso in recursos)
            {

                if (recurso.Codigo == codigo)
                {
                    indice = c;
                }
                c++;
            }

            recursos.RemoveAt(indice);

        }

        public void editarRecurso(Recurso recurso)
        {
            List<Recurso> recursosEdicion = new List<Recurso>();

            foreach (Recurso rec in recursos)
            {
                if (rec.Codigo == recurso.Codigo)
                    recursosEdicion.Add(recurso);
                else
                    recursosEdicion.Add(rec);
            }

            recursos = recursosEdicion;
        }
    }
}
