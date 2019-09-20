using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionTIC
{
    public class GestorSolicitantes
    {
        private VistaSolicitante vistaSolicitantes;
        private VistaPrincipal vistaPrincipal;

        private RepositorioSolicitante repositorioSolicitante;

        private const int CANTIDAD_ATRIBUTOS = 9;

        public GestorSolicitantes(VistaSolicitante vistaSolicitante, VistaPrincipal vistaPrincipal)
        {
            this.vistaSolicitantes = vistaSolicitante;
            this.vistaPrincipal = vistaPrincipal;

            this.repositorioSolicitante = new RepositorioSolicitante();
        }

        public void AgregarNuevoSolicitante()
        {
            String codigoString = vistaSolicitantes.GetCodigoTextBox().Text;
            String nombre = vistaSolicitantes.GetNombreTextBox().Text;
            String apellido = vistaSolicitantes.GetApellidoTextBox().Text;
            String dni = vistaSolicitantes.GetDniTextBox().Text;
            String cargo = vistaSolicitantes.GetCargoTextBox().Text;
            String telefono = vistaSolicitantes.GetTelefonoTextBox().Text;
            String mail = vistaSolicitantes.GetMailTextBox().Text;
            String universidad = vistaSolicitantes.GetUniversidadComboBox();

            if (CamposValidos(codigoString, nombre, apellido, dni, cargo, telefono, mail, universidad))
            {
                int codigo = int.Parse(codigoString);

                if (!CodigoExiste(codigo))
                {
                    Solicitante solicitante = new Solicitante(codigo, nombre, apellido, dni, cargo, telefono, mail, universidad);

                    this.repositorioSolicitante.agregarSolicitante(solicitante);

                    this.vistaPrincipal.RepositorioSolicitantePropiedad = this.repositorioSolicitante;

                    vistaSolicitantes.MostrarRegistro(solicitante.Atributos);

                    vistaSolicitantes.MostrarMensaje("EL SOLICITANTE FUÉ GUARDADO CORRECTAMENTE");
                }
                else
                {
                    vistaSolicitantes.MostrarMensaje("EL CÓDIGO INGRESADO YA EXISTE, POR FAVOR INGRESE OTRO CÓDIGO");
                }
            }



        }

        public void EliminarSolicitante()
        {
            String codigoString = vistaSolicitantes.GetCodigoTextBox().Text;

            if (CodigoValido(codigoString))
            {
                int codigo = int.Parse(codigoString);
                try
                {
                    repositorioSolicitante.EliminarSolicitante(codigo);

                    this.vistaPrincipal.RepositorioSolicitantePropiedad = this.repositorioSolicitante;

                    vistaSolicitantes.EliminarRegistro(codigoString);
                }
                catch (Exception)
                {
                    throw new Exception("ERROR AL ELIMINAR RECURSO");
                }
            }
        }

        public void GuardarCambiosSolicitante()
        {
            String codigoString = vistaSolicitantes.GetCodigoTextBox().Text;
            String nombre = vistaSolicitantes.GetNombreTextBox().Text;
            String apellido = vistaSolicitantes.GetApellidoTextBox().Text;
            String dni = vistaSolicitantes.GetDniTextBox().Text;
            String cargo = vistaSolicitantes.GetCargoTextBox().Text;
            String telefono = vistaSolicitantes.GetTelefonoTextBox().Text;
            String mail = vistaSolicitantes.GetMailTextBox().Text;
            String universidad = vistaSolicitantes.GetUniversidadComboBox();

            if (CamposValidos(codigoString, nombre, apellido, dni, cargo, telefono, mail, universidad))
            {
                int codigo = int.Parse(codigoString);

                if (CodigoExiste(codigo))
                {
                    Solicitante solicitante = new Solicitante(codigo, nombre, apellido, dni, cargo, telefono, mail, universidad);

                    this.repositorioSolicitante.EditarSolicitante(solicitante);

                    this.vistaPrincipal.RepositorioSolicitantePropiedad = this.repositorioSolicitante;

                    vistaSolicitantes.EditarRegistro(solicitante.Atributos);

                    vistaSolicitantes.MostrarMensaje("LOS CAMBIOS FUERON GUARDADOS CORECTAMENTE");
                }
                else
                {
                    vistaSolicitantes.MostrarMensaje("EL CÓDIGO INGRESADO NO EXISTE, POR FAVOR INGRESE OTRO CÓDIGO");
                }
            }
        }

        /*private String[] ObtenerAtributos(Solicitante solicitante)
        {
            String[] atributos = new String[CANTIDAD_ATRIBUTOS];

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
        }*/

        /*-------------------------------------------------------------
        * 
        * -----------------VALIDACIONES Y CONVERSIONES-----------------
        * 
        *-------------------------------------------------------------*/

        private Boolean CamposValidos(String codigoString, String nombre, String apellido, String dni,
            String cargo, String telefono, String mail, String universidad)
        {
            Boolean camposValidos = true;

            if (!CodigoValido(codigoString)
                || !NombreValido(nombre)
                || !ApeliidoValido(apellido)
                || !DniValido(dni)
                || !CargoValido(cargo)
                || !TelefonoValido(telefono)
                || !MailValido(mail)
                || !UniversidadValida(universidad))
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
                        vistaSolicitantes.MostrarMensaje("EL CODIGO DEBE SER UN NÚMERO POSITIVO");
                    }
                }
                else
                {
                    codigoValido = false;
                    vistaSolicitantes.MostrarMensaje("CAMPO CÓDIGO VACÍO, POR FAVOR INGRESE UN CÓDIGO");
                }
            }
            catch (Exception)
            {
                throw new Exception("EL CÓDIGO INGRESADO ES INVÁLIDO");
            }

            return codigoValido;

        }

        private Boolean CodigoExiste(int codigo)
        {
            Boolean existe = false;

            foreach (Solicitante solicitante in repositorioSolicitante.Solicitantes)
            {
                if (codigo == solicitante.Codigo)
                {
                    existe = true;
                }
            }

            return existe;
        }

        private Boolean NombreValido(String nombre)
        {
            Boolean nombreValido = true;

            if (CampoVacio(nombre))
            {
                nombreValido = false;
                vistaSolicitantes.MostrarMensaje("EL CAMPO NOMBRE ESTA VACIO, POR FAVOR INGRESE UN NOMBRE ");
            }

            return nombreValido;
        }

        private Boolean ApeliidoValido(String apellido)
        {
            Boolean apellidoValido = true;

            if (CampoVacio(apellido))
            {
                apellidoValido = false;
                vistaSolicitantes.MostrarMensaje("EL CAMPO APELLIDO ESTA VACIO, POR FAVOR INGRESE UN APELLIDO ");
            }

            return apellidoValido;
        }

        private Boolean DniValido(String dni)
        {
            Boolean dniValido = true;

            if (CampoVacio(dni))
            {
                dniValido = false;
                vistaSolicitantes.MostrarMensaje("EL CAMPO DNI ESTA VACIO, POR FAVOR INGRESE UN DNI");
            }

            return dniValido;
        }

        private Boolean CargoValido(String cargo)
        {
            Boolean cargoValido = true;

            if (CampoVacio(cargo))
            {
                cargoValido = false;
                vistaSolicitantes.MostrarMensaje("EL CAMPO CARGO ESTA VACIO, POR FAVOR INGRESE UN CARGO ");
            }

            return cargoValido;
        }

        private Boolean TelefonoValido(String telefono)
        {
            Boolean telefonoValido = true;

            if (CampoVacio(telefono))
            {
                telefonoValido = false;
                vistaSolicitantes.MostrarMensaje("EL CAMPO TELEFONO ESTA VACIO, POR FAVOR INGRESE UN TELEFONO ");
            }

            return telefonoValido;
        }

        private Boolean MailValido(String mail)
        {
            Boolean mailValido = true;

            if (CampoVacio(mail))
            {
                mailValido = false;
                vistaSolicitantes.MostrarMensaje("EL CAMPO MAIL ESTA VACIO, POR FAVOR INGRESE UN MAIL ");
            }

            return mailValido;
        }

        private Boolean UniversidadValida(String universidad)
        {
            Boolean universidadValida = true;

            if (CampoVacio(universidad))
            {
                universidadValida = false;
                vistaSolicitantes.MostrarMensaje("SELECCIONE UNA UNIVERSIDAD");
            }

            return universidadValida;
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
