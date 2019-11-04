using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caciorgna.Entidades
{
    public class Persona
    {
        private string _apellido;

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private DateTime _fechaNacimiento;

        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }

        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private int _tipoPersona;

        public int Tipo_Persona
        {
            get { return _tipoPersona; }
            set { _tipoPersona = value; }
        }

        public Persona()
        {

        }

        public Persona(string apellido, string nombre, DateTime fecha_nacimiento, int tipoPersona, string email) 
        {
            Apellido = apellido;
            Nombre = nombre;
            FechaNacimiento = fecha_nacimiento;
            Tipo_Persona = tipoPersona;
            Email = email;
        }





    }
}
