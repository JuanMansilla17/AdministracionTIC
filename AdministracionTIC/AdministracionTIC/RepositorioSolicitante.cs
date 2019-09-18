using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionTIC
{
    class RepositorioSolicitante
    {
        private List<Solicitante> solicitantes;

        public RepositorioSolicitante()
        {
            solicitantes = new List<Solicitante>();
        }

        public void agregarSolicitante(Solicitante solicitante)
        {
            solicitantes.Add(solicitante);
        }

        public List<Solicitante> Solicitantes
        {
            set { }
            get
            {
                return this.solicitantes;
            }
        }

         public void EliminarSolicitante(int codigo)
        {
            int indice = -1, c = 0;

            foreach (Solicitante soli in solicitantes)
            {

                if (soli.Codigo == codigo)
                {
                    indice = c;
                }
                c++;
            }

            solicitantes.RemoveAt(indice);
        }
        public void EditarSolicitante(Solicitante solicitante)
        {
            List<Solicitante> solicitantesEdicion = new List<Solicitante>();

            foreach (Solicitante sol in solicitantes)
            {
                if (sol.Codigo == solicitante.Codigo)
                    solicitantesEdicion.Add(solicitante);
                else
                    solicitantesEdicion.Add(sol);
            }

            solicitantes = solicitantesEdicion;
        }
    }
    
}
