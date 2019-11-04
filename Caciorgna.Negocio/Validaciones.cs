using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caciorgna.Negocio
{
    public class Validaciones
    {
        public static Boolean EsFechaNacimientoValida(DateTime fecha_nacimiento)
        {
            if (fecha_nacimiento < DateTime.Now)
            {
                return true;
            }
            else return false;
        }
    }
}
