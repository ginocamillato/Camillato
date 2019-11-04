using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caciorgna.Datos;

namespace Caciorgna.Negocio
{
    public class TipoPersona
    {
        public static List<Entidades.TipoPersona> RecuperarTodos()
        {
            return Datos.TipoPersona.RecuperarTodos();
        }

    }
}
