using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFClasses
{
    class Comunas
    {
        public int Id
        {
            get
            {
                return Id;
            }
            set
            {
                /* Validamos que el ID de la comuna solo contenga numeros.
                 * Estos valores son validados e impresos desde la clase de negocio */
                if (Negocio.ContieneLetras(value.ToString()))
                    throw new Exception("El Id de la comuna solo puede contener numeros");
                else
                    this.Id = value;

            }
        }
        public string Descripcion
        {
            get
            {
                return Descripcion;
            }
            set
            {
                /* Verificamos que la descripcion de la comuna no exceda el máximo de caracteres.
                 * Este valor es validado e impreso desde la clase de negocio */
                if (value.Length > Negocio.MAXDESCRIPCION)
                    throw new Exception("La descripción de la comuna no puede ser mayor a " + Negocio.MAXDESCRIPCION + " caracteres.");
                else
                    this.Descripcion = value;
            }
        }

        /// <summary>
        /// Creamos una instancia de la clase
        /// <seealso cref="InitClass"/>
        /// </summary>
        public Comunas()
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
            this.Descripcion = String.Empty;
        }
    }
}
