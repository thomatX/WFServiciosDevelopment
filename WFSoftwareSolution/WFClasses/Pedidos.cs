using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFClasses
{
    class Pedidos
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
                    throw new Exception("El Id del pedido solo puede contener numeros");
                else
                    this.Id = value;
            }
        }

        public DateTime FechaRegistro
        {
            get { return FechaRegistro; }
            set { FechaRegistro = value; }
        }
        public DateTime FechaDespacho
        {
            get { return FechaDespacho; }
            set { FechaDespacho = value; }
        }
        public int Total
        { get { return Total; }
          set { Total = value; }
        }

        public bool Despachado { get; set; }
        public string Observaciones
        {
            get
            {
                return Observaciones;
            }
            set
            {
                /* Verificamos que el nombre del producto no exceda el máximo de caracteres.
                 * Este valor es validado e impreso desde la clase de negocio */
                if (value.Length > Negocio.MAXOBSERVACIONES)
                    throw new Exception("Las observaciones del producto no puede ser mayor a " + Negocio.MAXOBSERVACIONES + " caracteres");
                else
                    this.Observaciones = value;

            }
        }

        public int IdVendedor { get; set; }
        public int IdCliente { get; set; }




        public DateTime GenerarFechaDespacho() {
            DateTime FechaDespacho;

            FechaDespacho = FechaRegistro.AddDays(+7);

            return FechaDespacho;

        }


    }
}
