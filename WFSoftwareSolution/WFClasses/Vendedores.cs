using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFClasses
{
    class Vendedores
    {
        public int Id
        {
            get
            {
                return Id;
            }
            set
            {
                /* Validamos que el ID solo contenga numeros.
                 * Estos valores son validados e impresos desde la clase de negocio */
                if (Negocio.ContieneLetras(value.ToString()))
                    throw new Exception("El Id del vendedor solo puede contener numeros");
                else
                    this.Id = value;

            }
        }
        public string Nombre
        {
            get
            {
                return Nombre;
            }
            set
            {
                /* Verificamos que el nombre del vendedor no exceda el máximo de caracteres.
                 * Este valor es validado e impreso desde la clase de negocio */
                if (value.Length > Negocio.MAXNOMBRE)
                    throw new Exception("El nombre del vendedor no puede ser mayor a " + Negocio.MAXNOMBRE + " caracteres");
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
                /* Verificamos que el Apellido del vendedor no exceda el máximo de caracteres.
                 * Este valor es validado e impreso desde la clase de negocio */
                if (value.Length > Negocio.MAXAPELLIDO)
                    throw new Exception("El apellido del vendedor no puede ser mayor a " + Negocio.MAXAPELLIDO + " caracteres");
                else
                    this.Apellido = value;

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
                /* Verificamos que el telefono del vendedor no exceda el máximo de caracteres.
                 * Validamos que el telefono solo contenga numeros.
                 * Estos valores son validados e impresos desde la clase de negocio */
                if (value.Length > Negocio.MAXTELEFONO)
                    throw new Exception("El telefono del vendedor no puede ser mayor a " + Negocio.MAXTELEFONO + " caracteres");
                else if (Negocio.ContieneLetras(value))
                    throw new Exception("El telefono del vendedor solo puede contener numeros");
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
                /* Verificamos que el email del vendedor no exceda el máximo de caracteres.
                 * Estos valores son validados e impresos desde la clase de negocio */
                if (value.Length > Negocio.MAXEMAIL)
                    throw new Exception("El email del vendedor no puede ser mayor a " + Negocio.MAXEMAIL + " caracteres");
                else
                    this.Email = value;
            }
        }

        /// <summary>
        /// Almacena la cantidad de ventas realizadas por un vendedor
        /// </summary>
        public int Ventas
        {
            get
            {
                return Ventas;
            }
            set
            {
                Ventas = value;
            }
        }

        /// <summary>
        /// Almacena el total de las ventas de un vendedor en Pesos
        /// </summary>
        public int TotalVentas
        {
            get
            {
                return TotalVentas;
            }
            set
            {
                TotalVentas = value;
            }

        }

    }
}
