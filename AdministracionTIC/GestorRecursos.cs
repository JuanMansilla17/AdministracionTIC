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
        private VistaPrincipal vistaPrincipal;

        private RepositorioRecursos repositorioRecursos;

        private const int CANTIDAD_ATRIBUTOS = 8;

        public GestorRecursos (VistaRecursos vistaRecursos, VistaPrincipal vistaPrincipal)
        {
            this.vistaRecursos = vistaRecursos;
            this.vistaPrincipal = vistaPrincipal;

            this.repositorioRecursos = new RepositorioRecursos();
        }

        public void AgregarNuevoRecurso()
        {
            String codigoString = vistaRecursos.getCodigoTextBox().Text;
            String descripcion = vistaRecursos.getDescripcionTextBox().Text;
            DateTime fecha = vistaRecursos.getFechaTextBox();

            if (vistaRecursos.getAulaCheckBox())
            {
                if (CamposValidos(codigoString, descripcion, fecha))
                {
                    int codigo = int.Parse(codigoString);

                    if (!CodigoExiste(codigo))
                    {
                        Recurso recurso = new Recurso(codigo, descripcion, fecha);

                        this.repositorioRecursos.AgregarRecurso(recurso);

                        this.vistaPrincipal.RepositorioRecursoPropiedad = this.repositorioRecursos;

                        vistaRecursos.MostrarRegistro(ObtenerAtributos(recurso));

                        vistaRecursos.MostrarMensaje("EL RECURSO FUÉ GUARDADO CORRECTAMENTE");
                    }
                    else
                    {
                        vistaRecursos.MostrarMensaje("EL CÓDIGO INGRESADO YA EXISTE, POR FAVOR INGRESE OTRO CÓDIGO");
                    }
                }
            }
            else
            {
                String marca = vistaRecursos.getMarcaTextBox().Text;
                String modelo = vistaRecursos.getModeloTextBox().Text;

                if (CamposValidos(codigoString, descripcion, marca, modelo, fecha))
                {
                    int codigo = int.Parse(codigoString);

                    if (!CodigoExiste(codigo))
                    {
                        Recurso recurso = new Recurso(codigo, descripcion, marca, modelo, fecha);

                        this.repositorioRecursos.AgregarRecurso(recurso);

                        this.vistaPrincipal.RepositorioRecursoPropiedad = this.repositorioRecursos;

                        vistaRecursos.MostrarRegistro(ObtenerAtributos(recurso));

                        vistaRecursos.MostrarMensaje("EL RECURSO FUÉ GUARDADO CORRECTAMENTE");
                    }
                    else
                    {
                        vistaRecursos.MostrarMensaje("EL CÓDIGO INGRESADO YA EXISTE, POR FAVOR INGRESE OTRO CÓDIGO");
                    }
                    
                }
            }
        }

        public void EliminarRecurso()
        {
            String codigoString = vistaRecursos.getCodigoTextBox().Text;

            if (CodigoValido(codigoString))
            {
                int codigo = int.Parse(codigoString);

                try
                {
                    repositorioRecursos.EliminarRecurso(codigo);

                    this.vistaPrincipal.RepositorioRecursoPropiedad = this.repositorioRecursos;

                    vistaRecursos.EliminarRegistro(codigoString);
                }
                catch (Exception)
                {
                    throw new Exception("ERROR AL ELIMINAR RECURSO");
                }
            }
        }

        public void GuardarCambiosRecurso()
        {
            String codigoString = vistaRecursos.getCodigoTextBox().Text;
            String descripcion = vistaRecursos.getDescripcionTextBox().Text;
            DateTime fecha = vistaRecursos.getFechaTextBox();

            if (vistaRecursos.getAulaCheckBox())
            {
                if (CamposValidos(codigoString, descripcion, fecha))
                {
                    int codigo = int.Parse(codigoString);

                    if (CodigoExiste(codigo))
                    {
                        Recurso recurso = new Recurso(codigo, descripcion, fecha);

                        this.repositorioRecursos.EditarRecurso(recurso);

                        this.vistaPrincipal.RepositorioRecursoPropiedad = this.repositorioRecursos;

                        vistaRecursos.EditarRegistro(ObtenerAtributos(recurso));

                        vistaRecursos.MostrarMensaje("LOS CAMBIOS FUERON GUARDADOS CORECTAMENTE");
                    }
                    else
                    {
                        vistaRecursos.MostrarMensaje("EL CÓDIGO INGRESADO NO EXISTE, POR FAVOR INGRESE OTRO CÓDIGO");
                    }
                }
            }
            else
            {
                String marca = vistaRecursos.getMarcaTextBox().Text;
                String modelo = vistaRecursos.getModeloTextBox().Text;

                if (CamposValidos(codigoString, descripcion, marca, modelo, fecha))
                {
                    int codigo = int.Parse(codigoString);

                    if (CodigoExiste(codigo))
                    {
                        Recurso recurso = new Recurso(codigo, descripcion, marca, modelo, fecha);

                        this.repositorioRecursos.EditarRecurso(recurso);

                        this.vistaPrincipal.RepositorioRecursoPropiedad = this.repositorioRecursos;

                        vistaRecursos.EditarRegistro(ObtenerAtributos(recurso));

                        vistaRecursos.MostrarMensaje("LOS CAMBIOS FUERON GUARDADOS CORECTAMENTE");
                    }
                    else
                    {
                        vistaRecursos.MostrarMensaje("EL CÓDIGO INGRESADO NO EXISTE, POR FAVOR INGRESE OTRO CÓDIGO");
                    }
                }
            }
        }

        public String[] ObtenerAtributos(Recurso recurso)
        {
            String[] atributos = new String[CANTIDAD_ATRIBUTOS];

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

        /*-------------------------------------------------------------
         * 
         * -----------------VALIDACIONES Y CONVERSIONES-----------------
         * 
         *-------------------------------------------------------------*/
        
        private Boolean CamposValidos(String codigoString, String descripcion, DateTime fecha)
        {
            Boolean camposValidos = true;

            if (!CodigoValido(codigoString)
                || !DescripcionValida(descripcion)
                || !FechaValida(fecha))
            {
                camposValidos = false;
            }

            return camposValidos;
        }

        private Boolean CamposValidos(String codigoString, String descripcion, String marca, String modelo, DateTime fecha)
        {
            Boolean camposValidos = true;

            if (!CodigoValido(codigoString)
                || !DescripcionValida(descripcion)
                || !MarcaValida(marca)
                || !ModeloValido(modelo)
                || !FechaValida(fecha))
            {
                camposValidos = false;
            }

            return camposValidos;
        }

        private Boolean CodigoValido(String codigoString)
        {
            Boolean codigoValido = true;
            int codigo;

            try
            {
                if (!CampoVacio(codigoString))
                {
                    codigo = int.Parse(codigoString);

                    if (codigo < 0)
                    {
                        codigoValido = false;
                        vistaRecursos.MostrarMensaje("EL CÓDIGO DEBE SER UN NÚMERO POSITIVO");
                    }
                }
                else
                {
                    codigoValido = false;
                    vistaRecursos.MostrarMensaje("CAMPO CÓDIGO VACÍO, POR FAVOR INGRESE UN CÓDIGO");
                }
            }
            catch (Exception)
            {
                throw new Exception("EL CÓDIGO INGRESADO ES INVÁLIDO");
            }

            return codigoValido;
        }

        private Boolean CodigoExiste (int codigo)
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

        private Boolean DescripcionValida (String descripcion)
        {
            Boolean descripcionValida = true;

            if (CampoVacio(descripcion))
            {
                descripcionValida = false;
                vistaRecursos.MostrarMensaje("EL CAMPO DESCRIPCIÓN ESTÁ VACÍO, POR FAVOR INGRESE UNA DESCRIPCIÓN");
            }

            return descripcionValida;
        }

        private Boolean MarcaValida(String marca)
        {
            Boolean marcaValida = true;

            if (CampoVacio(marca))
            {
                marcaValida = false;
                vistaRecursos.MostrarMensaje("EL CAMPO MARCA ESTÁ VACÍO, POR FAVOR INGRESE UNA MARCA");
            }

            return marcaValida;
        }

        private Boolean ModeloValido(String modelo)
        {
            Boolean modeloValido = true;

            if (CampoVacio(modelo))
            {
                modeloValido = false;
                vistaRecursos.MostrarMensaje("EL CAMPO MODELO ESTÁ VACÍO, POR FAVOR INGRESE UN MODELO");
            }

            return modeloValido;
        }

        private Boolean FechaValida (DateTime fecha)
        {
            Boolean fechaValida = true;

            if (0 < DateTime.Compare(fecha, DateTime.Now))
            {
                fechaValida = false;
                vistaRecursos.MostrarMensaje("LA FECHA DE ADQUISICIÓN NO PUEDE SER POSTERIOR A LA FECHA ACTUAL");
            }

            return fechaValida;
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
    }    
}
