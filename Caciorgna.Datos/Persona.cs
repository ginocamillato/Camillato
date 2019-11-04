using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caciorgna.Entidades;
using System.Data.SqlClient;
using System.Data;

namespace Caciorgna.Datos
{
    public class Persona : Base
    {
        public static List<Entidades.Persona> RecuperarTodos() 
        {
            List<Entidades.Persona> personas = new List<Entidades.Persona>();

            try
            { 
            OpenConnection();

            SqlCommand cmd = new SqlCommand("select * from personas", Conn);
            SqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {
                Entidades.Persona per = new Entidades.Persona();

                per.Apellido = (string) dr["apellido"];
                per.Nombre = (string) dr["nombre"];
                per.Email = (string) dr["email"];
                per.FechaNacimiento = (DateTime) dr["fecha_nacimiento"];
                per.Tipo_Persona = (int) dr["tipo_persona"];

                personas.Add(per);
            }

            }
            catch(Exception Ex)
            {
                Exception ex = new Exception("No se pudieron recuperar las personas", Ex);
                throw ex;
            }

            finally 
            {
                
                CloseConnection();

            }

            return personas;



        }


        public static void  Agregar(Entidades.Persona per)
        {
            try
            {
                OpenConnection();

                SqlCommand cmd = new SqlCommand("insert into personas (apellido, nombre, email, fecha_nacimiento , tipo_persona) values (@apellido, @nombre, @email, @fecha_nacimiento, @tipo_persona)", Conn);
                cmd.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = per.Apellido;
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = per.Nombre;
                cmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = per.Email;
                cmd.Parameters.Add("@fecha_nacimiento", SqlDbType.DateTime, 50).Value = per.FechaNacimiento;
                cmd.Parameters.Add("@tipo_persona", SqlDbType.Int, 50).Value = per.Tipo_Persona;

                cmd.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                Exception exception = new Exception("Error al agregar persona", ex);
                throw exception;
            }
            finally
            {
                CloseConnection();
            }
            
        }

        public static List<Entidades.Persona> RecuperarPorTipoPersona(int idTipoPersona) 
        {
            List<Entidades.Persona> personas = new List<Entidades.Persona>();

            try
            {
                OpenConnection();

                SqlCommand cmd = new SqlCommand("select * from personas where tipo_persona = @id",Conn);
                cmd.Parameters.Add("@id", SqlDbType.Int, 50).Value = idTipoPersona;
                SqlDataReader dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    Entidades.Persona per = new Entidades.Persona();

                    per.Apellido = (string) dr["apellido"];
                    per.Nombre = (string) dr["nombre"];
                    per.Email = (string) dr["email"];
                    per.FechaNacimiento = (DateTime) dr["fecha_nacimiento"];
                    per.Tipo_Persona = (int) dr["tipo_persona"];

                    personas.Add(per);
                }

            }
            catch (Exception Ex)
            {
                Exception ex = new Exception("No se pudieron recuperar las personas", Ex);
                throw ex;
            }

            finally
            {

                CloseConnection();

            }

            return personas;

        }

    }
}
