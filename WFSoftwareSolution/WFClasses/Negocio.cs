using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFClasses
{
    class Negocio
    {
        public static int MAXDESCUENTO = 20;
        public static int MAXNOMBRE = 20;
        public static int MAXAPELLIDO = 20;
        public static int MAXDESCRIPCION = 30;
        public static int MAXDIRECCION = 30;
        public static int MAXEMAIL = 20;
        public static int MAXTELEFONO = 20;
        public static int MAXOBSERVACIONES = 50;
        public static int MAXPAGINAWEB = 30;
        public static int MAXUSERNAME = 20;
        public static int MAXPASSWORD = 20;
        public static int MINPRECIO = 0;


        public static bool ContieneLetras(string s)
        {
            foreach (char c in s)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }

    }



}
