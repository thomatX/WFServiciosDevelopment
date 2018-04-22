using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFClasses
{
    class Proveedores
    {
        public int Id { get; set; }
        public string Nombre {
            get
            {
                return Nombre;
            }
            set
            {
                /* Verificamos que el nombre del producto no exceda el máximo de caracteres.
                 * Este valor es validado e impreso desde la clase de negocio */
                if (value.Length > Negocio.MAXNOMBRE)
                    throw new Exception("El nombre del producto no puede ser mayor a " + Negocio.MAXNOMBRE + " caracteres");
                else
                    this.Nombre = value;

            }
        }
        public string Telefono
        {
            get
            {
                return Telefono;
            }
            set
            {
                /* Verificamos que el telefono del producto no exceda el máximo de caracteres.
                 * Validamos que el telefono solo contenga numeros.
                 * Estos valores son validados e impresos desde la clase de negocio */
                if (value.Length > Negocio.MAXTELEFONO)
                    throw new Exception("El telefono del proveedor no puede ser mayor a " + Negocio.MAXTELEFONO + " caracteres");
                else if (Negocio.ContieneLetras(value))
                    throw new Exception("El telefono solo puede contener numeros");
                else
                    this.Nombre = value;

            }
        }
        public string PaginaWeb {
            get
            {
                return PaginaWeb;
            }
            set
            {
                /* Verificamos que la pagina del producto no exceda el máximo de caracteres.
                 * Estos valores son validados e impresos desde la clase de negocio */
                if (value.Length > Negocio.MAXPAGINAWEB)
                    throw new Exception("La página web del proveedor no puede contener más de " + Negocio.MAXPAGINAWEB + " caracteres");
                else
                    this.Nombre = value;

            }
        }
        public string Direccion {
            get
            {
                return Direccion;
            }
            set
            {
                /* Verificamos que la direccion del producto no exceda el máximo de caracteres.
                 * Estos valores son validados e impresos desde la clase de negocio */
                if (value.Length > Negocio.MAXDESCRIPCION)
                    throw new Exception("La dirección del proveedor no puede ser mayor a " + Negocio.MAXDESCRIPCION + " caracteres");
                else
                    this.Nombre = value;

            }
        }
        public string Direccion2
        {
            get
            {
                return Direccion;
            }
            set
            {
                /* Verificamos que la direccion del producto no exceda el máximo de caracteres.
                 * Estos valores son validados e impresos desde la clase de negocio */
                if (value.Length > Negocio.MAXDESCRIPCION)
                    throw new Exception("La dirección 2 del proveedor no puede ser mayor a " + Negocio.MAXDESCRIPCION + " caracteres");
                else
                    this.Nombre = value;

            }
        }
        public int IdComuna { get; set; }

        /// <summary>
        /// Creamos una instancia de la clase
        /// <seealso cref="InitClass"/>
        /// </summary>
        public Proveedores()
        {
            InitClass();
        }

        /// <summary>
        /// Inicializa los atributos de la clase por defecto.
        /// </summary>
        private void InitClass()
        {
            /* Inicializamos los atributos a 0 por defecto.
             * Esto para evitar que se almacenen valores nulos. */
            this.Id = 0;
            this.Nombre = String.Empty;
            this.Telefono = String.Empty;
            this.PaginaWeb = String.Empty;
            this.Direccion = String.Empty;
            this.Direccion2 = String.Empty;
            this.IdComuna = 0;
        }
    }
}
