using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFClasses
{
    public class Clientes
    {
        public int Id
        {
            get
            {
                return Id;
            }
            set
            {
                /* Validamos que el ID del cliente solo contenga numeros.
                 * Estos valores son validados e impresos desde la clase de negocio */
                if (Negocio.ContieneLetras(value.ToString()))
                    throw new Exception("El Id del cliente solo puede contener numeros");
                else
                    this.Id = value;

            }
        }
        public string Nombre {
            get
            {
                return Nombre;
            }
            set
            {
                /* Verificamos que el nombre del cliente no exceda el máximo de caracteres.
                 * Este valor es validado e impreso desde la clase de negocio */
                if (value.Length > Negocio.MAXNOMBRE)
                    throw new Exception("El nombre del cliente no puede ser mayor a " + Negocio.MAXNOMBRE + " caracteres");
                else
                    this.Nombre = value;

            }
        }
        public string Apellido
        {
            get
            {
                return Apellido;
            }
            set
            {
                /* Verificamos que el apellido del cliente no exceda el máximo de caracteres.
                 * Este valor es validado e impreso desde la clase de negocio */
                if (value.Length > Negocio.MAXAPELLIDO)
                    throw new Exception("El apellido del cliente no puede ser mayor a " + Negocio.MAXAPELLIDO + " caracteres");
                else
                    this.Apellido = value;

            }
        }
        public string Direccion
        {
            get
            {
                return Direccion;
            }
            set
            {
                /* Verificamos que la direccion del cliente no exceda el máximo de caracteres.
                 * Estos valores son validados e impresos desde la clase de negocio */
                if (value.Length > Negocio.MAXDESCRIPCION)
                    throw new Exception("La dirección del cliente no puede ser mayor a " + Negocio.MAXDESCRIPCION + " caracteres");
                else
                    this.Nombre = value;

            }
        }
        public string Email
        {
            get
            {
                return Email;
            }
            set
            {
                /* Verificamos que el email del cliente no exceda el máximo de caracteres.
                 * Estos valores son validados e impresos desde la clase de negocio */
                if (value.Length > Negocio.MAXEMAIL)
                    throw new Exception("El email del cliente no puede ser mayor a " + Negocio.MAXEMAIL + " caracteres");
                else
                    this.Email = value;
            }
        }
        public string Telefono {
            get
            {
                return Telefono;
            }
            set
            {
                /* Verificamos que el telefono del cliente no exceda el máximo de caracteres.
                 * Validamos que el telefono solo contenga numeros.
                 * Estos valores son validados e impresos desde la clase de negocio */
                if (value.Length > Negocio.MAXTELEFONO)
                    throw new Exception("El telefono del cliente no puede ser mayor a " + Negocio.MAXTELEFONO + " caracteres");
                else if (Negocio.ContieneLetras(value))
                    throw new Exception("El telefono del cliente solo puede contener numeros");
                else
                    this.Nombre = value;

            }
        }
        public int IdComuna { get; set; }
        public int IdVendedor { get; set; }

        /// <summary>
        /// Genera una instancia de la clase
        /// <seealso cref="InitClass"/>
        /// </summary>
        public Clientes()
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
            this.Apellido = String.Empty;
            this.Direccion = String.Empty;
            this.Email = String.Empty;
            this.IdComuna = 0;
            this.IdVendedor = 0;
        }
    }
}
