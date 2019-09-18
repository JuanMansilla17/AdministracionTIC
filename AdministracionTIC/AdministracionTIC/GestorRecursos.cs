using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionTIC
{
    class GestorRecursos
    {
        private VistaRecursos vistaRecursos;

        private RepositorioRecursos repositorioRecursos;


        public GestorRecursos (VistaRecursos vistaRecursos)
        {
            this.vistaRecursos = vistaRecursos;

            this.repositorioRecursos = new RepositorioRecursos();
        }

        public String[] agregarNuevoRecurso()
        {
            
            String codigoString = vistaRecursos.getCodigoTextBox().Text;
            String descripcion = vistaRecursos.getDescripcionTextBox().Text;
            DateTime fecha = vistaRecursos.getFechaTextBox();

            int codigo = validarCodigo(codigoString);
            codigoInexistente(codigo);
            validarDescripcion(descripcion);
            validarFecha(fecha);

            if (vistaRecursos.getAulaCheckBox())
            { 
                Recurso recurso = new Recurso(codigo, descripcion, fecha);

                this.repositorioRecursos.agregarRecurso(recurso);

                return agregarFila(recurso);
            }
            else
            {
                String marca = vistaRecursos.getMarcaTextBox().Text;
                String modelo = vistaRecursos.getModeloTextBox().Text;

                validarMarca(marca);
                validarModelo(modelo);

                Recurso recurso = new Recurso(codigo, descripcion, marca, modelo, fecha);

                this.repositorioRecursos.agregarRecurso(recurso);

                return agregarFila(recurso);
            }           
            
        }

        public String eliminarRecurso()
        {
            String codigoString = vistaRecursos.getCodigoTextBox().Text;
            int codigo = validarCodigo(codigoString);
            codigoExistente(codigo);

            try
            {
                repositorioRecursos.eliminarRecurso(codigo);

            }
            catch (Exception)
            {

                throw new Exception ("ERROR AL ELIMINAR RECURSO");
            }

            return codigoString;
        }

        public void guardarCambiosRecurso()
        {
            String codigoString = vistaRecursos.getCodigoTextBox().Text;
            String descripcion = vistaRecursos.getDescripcionTextBox().Text;
            DateTime fecha = vistaRecursos.getFechaTextBox();

            int codigo = validarCodigo(codigoString);
            codigoExistente(codigo);
            validarDescripcion(descripcion);
            validarFecha(fecha);

            if (vistaRecursos.getAulaCheckBox())
            {
                Recurso recurso = new Recurso(codigo, descripcion, fecha);

                this.repositorioRecursos.editarRecurso(recurso);
            }
            else
            {
                String marca = vistaRecursos.getMarcaTextBox().Text;
                String modelo = vistaRecursos.getModeloTextBox().Text;

                validarMarca(marca);
                validarModelo(modelo);

                Recurso recurso = new Recurso(codigo, descripcion, marca, modelo, fecha);

                this.repositorioRecursos.editarRecurso(recurso);
            }

            cargarGrilla();
        }

        public void cargarGrilla()
        {
            String[] fila = new String[8];

            foreach (Recurso rec in this.repositorioRecursos.Recursos)
            {
                vistaRecursos.agregarFila(this.agregarFila(rec));
            }
        }

        private String[] agregarFila(Recurso recurso)
        {
            String[] atributos = new String[8];

            atributos[0] = recurso.Codigo.ToString();
            atributos[1] = recurso.Descripcion;
            atributos[2] = recurso.Fecha.ToString("dd/MM/yyyy");

            if (recurso.Estado)
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

        /*-------------------------------------------------------------
         * 
         * -----------------VALIDACIONES Y CONVERSIONES-----------------
         * 
         *-------------------------------------------------------------*/

        private int validarCodigo(String codigoString)
        {
            int codigo;

            if (codigoString.Length == 0)
            {
                throw new Exception("EL CÓDIGO ES VACÍO");
            }

            try
            {
                codigo = int.Parse(codigoString);

                if (codigo < 0)
                {
                    throw new Exception("EL CÓDIGO DEBE SER UN NUMERO POSITIVO");
                }

                
            }
            catch (Exception)
            {
                throw new Exception("EL CÓDIGO INGRESADO ES INVÁLIDO");
            }

            
            return codigo;
        }

        private void codigoInexistente(int codigo)
        {
            if (existeCodigo(codigo)) throw new Exception("EL CÓDIGO YA EXISTE");
        }

        private void codigoExistente(int codigo)
        {
            if (existeCodigo(codigo) == false) throw new Exception("EL CÓDIGO NO EXISTE");
        }

        private Boolean existeCodigo (int codigo)
        {
            Boolean existe = false;

            foreach (Recurso rec in repositorioRecursos.Recursos)
            {
                if (codigo == rec.Codigo)
                {
                    existe = true;
                }
            }

            return existe;
        }

        private void validarDescripcion (String descripcion)
        {
            if (descripcion.Length == 0)
            {
                throw new Exception("LA DESCRIPCIÓN ES VACÍA");
            }
        }

        private void validarMarca(String marca)
        {
            if (marca.Length == 0)
            {
                throw new Exception("LA MARCA ES VACÍA");
            }
        }

        private void validarModelo(String modelo)
        {
            if (modelo.Length == 0)
            {
                throw new Exception("EL MODELO ES VACÍO");
            }
        }

        private void validarFecha (DateTime fecha)
        {
            if (0 < DateTime.Compare(fecha, DateTime.Now))
            {
                throw new Exception("FECHA INVÁLIDA");
            }
        }
    }    
}
