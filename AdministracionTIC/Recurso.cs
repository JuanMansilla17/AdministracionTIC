using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionTIC
{
    public class Recurso
    {
        private int codigo;
        private String descripcion;
        private String marca;
        private String modelo;
        private DateTime fecha;
        private Boolean esAula;
        private Boolean averiado; //false: disponible; true: averiado
        private String observaciones;

        private const int CANTIDAD_ATRIBUTOS_RECURSO = 8;

        public Recurso(int codigo,
            String descripcion,
            String marca,
            String modelo,
            DateTime fecha
            )
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.marca = marca;
            this.modelo = modelo;
            this.fecha = fecha;
            esAula = false;
            averiado = false;
            observaciones = null;
        }


        public Recurso(int codigo,
            String descripcion,
            DateTime fecha)
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.fecha = fecha;
            esAula = true;
            averiado = false;
            observaciones = null;
        }

        public Recurso() { }

        

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

        public String Descripcion
        {
            set
            {
                this.descripcion = value;
            }
            get
            {
                return this.descripcion;
            }
        }

        public String Marca
        {
            set
            {
                this.marca = value;
            }
            get
            {
                return this.marca;
            }
        }

        public String Modelo
        {
            set
            {
                this.modelo = value;
            }
            get
            {
                return this.modelo;
            }
        }

        public DateTime Fecha
        {
            set
            {
                this.fecha = value;
            }
            get
            {
                return this.fecha;
            }
        }

        public Boolean EsAula
        {
            set
            {
                this.esAula = value;
            }
            get
            {
                return this.esAula;
            }
        }

        public Boolean Averiado
        {
            set
            {
                this.averiado = value;
            }
            get
            {
                return this.averiado;
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
                return this.observaciones;
            }
        }

        
        public override String ToString() 
        {
            return this.codigo.ToString() + "||" + this.descripcion + "||" + this.marca + "||" + this.modelo;
        }

        public String[] Atributos
        {
            set { }
            get
            {
                String[] atributos = new String[CANTIDAD_ATRIBUTOS_RECURSO];

                atributos[0] = this.codigo.ToString();
                atributos[1] = this.descripcion;
                atributos[2] = this.fecha.ToString("dd/MM/yyyy");

                if (this.averiado)
                {
                    atributos[3] = "Averiado";
                    atributos[4] = this.observaciones;
                }
                else
                {
                    atributos[3] = "Disponible";
                    atributos[4] = "";
                }


                if (this.esAula)
                {
                    atributos[5] = "";
                    atributos[6] = "";
                    atributos[7] = "Aula";
                }
                else
                {
                    atributos[5] = this.marca;
                    atributos[6] = this.modelo;
                    atributos[7] = "Movil";
                }

                return atributos;
            }
        }
    }
}
