using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionTIC
{
    public class Solicitante
    {
        private String dni;
        private String nombre;
        private String apellido;
        private String cargo;
        private String telefono;
        private String mail;
        private String universidad;
        private String estado;
        private int codigo;

        public Solicitante(int codigo,
            String nombre,
            String apellido,
            String dni,
            String cargo,
            String telefono,
            String mail,
            String universidad,
            String estado
            )
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.cargo = cargo;
            this.telefono = telefono;
            this.mail = mail;
            this.universidad = universidad;
            this.estado = "habilitado";
           
        }

        /*-------------------------------------------------------------
        * 
        * -----------------PROPIEDADES---------------------------
        * 
        *-------------------------------------------------------------*/
        public int Codigo
        {
            set
            {
                this.codigo = value;
            }
            get
            {
                return this.codigo;
            }
        }

        public String Nombre
        {
            set
            {
                this.nombre = value;
            }
            get
            {
                return this.nombre;
            }
        }

        public String Apellido
        {
            set
            {
                this.apellido = value;
            }
            get
            {
                return this.apellido;
            }
        }

        public String Dni
        {
            set
            {
                this.dni = value;
            }
            get
            {
                return this.dni;
            }
        }

        public String Cargo
        {
            set
            {
                this.cargo = value;
            }
            get
            {
                return this.cargo;
            }
        }

        public String Telefono
        {
            set
            {
                this.telefono = value;
            }
            get
            {
                return this.telefono;
            }
        }

        public String Mail
        {
            set
            {
                this.mail = value;
            }
            get
            {
                return this.mail;
            }
        }

        public String Universidad
        {
            set
            {
                this.universidad = value;
            }
            get
            {
                return this.universidad;
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
                return this.estado;
            }
        }

      


    }
}
