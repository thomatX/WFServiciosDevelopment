using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFClasses
{
    public class Clientes
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
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
