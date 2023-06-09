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
                cmd.Connection = base.connection;
                cmd.CommandText = "Persona";
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

        public Error GetPersona(int personaId)
        {
            base.connection.Open();
            Persona persona = null;

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = base.connection;
                cmd.CommandText = "SELECT * FROM Persona WHERE idPersona=@personaId";

                cmd.Parameters.AddWithValue("@personaId", personaId);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    persona = new Persona
                    {
                        Id = (int)reader[0],
                        Nombres = (string)reader[1],
                        Apellidos = (string)reader[2],
                        Celular = (string)reader[3],
                        Correo = (string)reader[4],
                    };
                }
            }
            catch (Exception e)
            {
                return Error.Desconocido;
            }
            finally
            {
                base.connection.Close();
            }

            return Error.NoError;
        }

        public Error DeletePersona(int personaId)
        {
            base.connection.Open();

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = base.connection;

                cmd.CommandText = "DELETE FROM Persona WHERE idPersona=@personaId";

                cmd.Parameters.AddWithValue("@personaId", personaId);

                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                return Error.Desconocido;
            }
            finally
            {
                base.connection.Close();
            }

            return Error.NoError;
        }

        public Error SetPersona(Persona persona, Boolean newPersona)
        {
            base.connection.Open();

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = base.connection;
                string query;
                if(newPersona)
                {
                    query = "INSERT INTO Persona VALUES (@Id, @Nombres, @Apellidos, @Celular, @Correo);";
                }
                else
                {
                    query = "UPDATE Persona SET " +
                        "idPersona = @Id, " +
                        "Nombres=@Nombres, " +
                        "Apellidos=@Apellidos, " +
                        "Celular=@Celular, " +
                        "Correo=@Correo" +
                        "WHERE idPersona = @Id;";
                }

                cmd.CommandText = query;

                cmd.Parameters.AddWithValue("@Id", persona.Id);
                cmd.Parameters.AddWithValue("@Nombres", persona.Nombres);
                cmd.Parameters.AddWithValue("@Apellidos", persona.Nombres);
                cmd.Parameters.AddWithValue("@Celular", persona.Celular);
                cmd.Parameters.AddWithValue("@Correo", persona.Correo);

                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
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
