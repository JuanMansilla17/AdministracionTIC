﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionTIC
{
    class Recurso
    {
        private int codigo;
        private String descripcion;
        private String marca;
        private String modelo;
        private DateTime fecha;
        private Boolean esAula;
        private Boolean estado; //false: disponible; true: averiado
        private String observaciones;


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
            estado = false;
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
            estado = false;
            observaciones = null;
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

        public Boolean Estado
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
    }
}
