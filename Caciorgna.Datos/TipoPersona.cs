using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caciorgna.Entidades;

namespace Caciorgna.Datos
{
    public class TipoPersona
    {

        public static List<Entidades.TipoPersona> RecuperarTodos()
        {
            List<Entidades.TipoPersona> tipoPersonas = new List<Entidades.TipoPersona>();

            Entidades.TipoPersona tipo1 = new Entidades.TipoPersona();
            Entidades.TipoPersona tipo2 = new Entidades.TipoPersona();

            tipo1.Id = 1;
            tipo1.Descripcion = "Alumno";

            tipo2.Id = 2;
            tipo2.Descripcion = "Profesor";
            
            tipoPersonas.Add(tipo1);
            tipoPersonas.Add(tipo2);

            return tipoPersonas;
            

        }



    }
}
