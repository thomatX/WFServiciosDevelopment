using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFClasses
{
    class Productos
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

        public string Descripcion
        {
            get
            {
                return Descripcion;
            }
            set
            {
                /* Verificamos que la descripcion del producto no exceda el máximo de caracteres.
                 * Este valor es validado e impreso desde la clase de negocio */
                if (value.Length > Negocio.MAXDESCRIPCION)
                    throw new Exception("La descripción del producto no puede ser mayor a " + Negocio.MAXDESCRIPCION + " caracteres.");
                else
                    this.Descripcion = value;
            }
        }
        public int Precio {
            get { return Precio; }
            set
            {
                /* Verificamos que el precio del producto sea mayor al minimo requerido.
                 * Este valor es validado e impreso desde la clase de negocio */
                if (value <= Negocio.MINPRECIO)
                    throw new Exception("El precio debe ser mayor a " + Negocio.MINPRECIO + "");
                else
                    this.Precio = value;
            }
        }
        public bool Stock { get; set; }
        public bool Descuento { get; set; }
        public int PorcentajeDescuento {
            get { return PorcentajeDescuento; }
            set
            {
                if (value > Negocio.MAXDESCUENTO)
                    throw new Exception("El porcentaje de descuento no puede exceder el " + Negocio.MAXDESCUENTO + "%");
                else
                    this.PorcentajeDescuento = value;
            }
        }
        public int IdProveedor { get; set; }

        /// <summary>
        /// Creamos una instancia de la clase
        /// <seealso cref="InitClass"/>
        /// </summary>
        public Productos()
        {
            InitClass();
        }

        /// <summary>
        /// Inicializa los atributos de la clase por defecto.
        /// </summary>
        private void InitClass()
        {
            this.Id = 0;
            this.Nombre = String.Empty;
            this.Descripcion = String.Empty;
            this.Precio = 0;
            this.Stock = false;
            this.Descuento = false;
            this.PorcentajeDescuento = 0;
        }
    }
}
