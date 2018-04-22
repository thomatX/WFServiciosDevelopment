using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFClasses
{
    class Comunas
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

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
