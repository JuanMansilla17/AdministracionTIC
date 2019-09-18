using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionTIC
{
    public class RepositorioSolicitante
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

            foreach (Solicitante solicitante in solicitantes)
            {

                if (solicitante.Codigo == codigo)
                {
                    indice = c;
                }
                c++;
            }

            solicitantes.RemoveAt(indice);
        }

        public void EditarSolicitante(Solicitante solicitanteEditado)
        {
            List<Solicitante> solicitantesEdicion = new List<Solicitante>();

            foreach (Solicitante solicitante in solicitantes)
            {
                if (solicitante.Codigo == solicitanteEditado.Codigo)
                    solicitantesEdicion.Add(solicitanteEditado);
                else
                    solicitantesEdicion.Add(solicitante);
            }

            solicitantes = solicitantesEdicion;
        }
    }
}
