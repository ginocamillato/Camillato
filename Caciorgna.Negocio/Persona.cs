using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caciorgna.Datos;
using Caciorgna.Entidades;

namespace Caciorgna.Negocio
{
    public class Persona
    {
        public static List<Entidades.Persona> RecuperarTodos()
        {
            return Datos.Persona.RecuperarTodos();
        }

        public static void Agregar(Entidades.Persona persona)
        {
            Datos.Persona.Agregar(persona);
        }

        public static List<Entidades.Persona> RecuperarPorTipoPersona(int idTipoPersona)
        {
           return Datos.Persona.RecuperarPorTipoPersona(idTipoPersona);
        }
    }
}
