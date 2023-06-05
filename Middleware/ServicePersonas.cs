using Middleware.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Middleware
{
    public class ServicePersonas: Service, IService
    {
        public ServicePersonas(MySqlConnection connection) : base(connection) { }

        public Error GetPersonas(out List<Persona> personas)
        {
            base.connection.Open();
            personas = new List<Persona>();

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "Persona";
                cmd.Connection = base.connection;
                cmd.CommandType = System.Data.CommandType.TableDirect;
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Persona persona = new Persona
                    {
                        Id = (int)reader[0],
                        Nombres = (string)reader[1],
                        Apellidos = (string)reader[2],
                        Celular = (string)reader[3],
                        Correo = (string)reader[4],
                    };

                    personas.Add(persona);
                }

            }
            catch(Exception e)
            {
                return Error.Desconocido;
            }
            finally
            {
                base.connection.Close();
            }

            return Error.NoError;
        }
    }
}
