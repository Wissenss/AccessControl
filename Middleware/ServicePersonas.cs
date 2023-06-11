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

        public Error GetPersona(int personaId, out Persona persona)
        {
            base.connection.Open();
            persona = null;

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

                if(persona == null)
                    return Error.RegistroNoEncontrado;
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
                        "Correo=@Correo " +
                        "WHERE idPersona = @Id;";
                }

                cmd.CommandText = query;

                cmd.Parameters.AddWithValue("@Id", persona.Id);
                cmd.Parameters.AddWithValue("@Nombres", persona.Nombres);
                cmd.Parameters.AddWithValue("@Apellidos", persona.Apellidos);
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


        public Error GetPersonasByGroup(int grupoPersonasId, out List<Persona> personas)
        {
            base.connection.Open();
            personas = new List<Persona>();

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = base.connection;

                cmd.CommandText = "SELECT * FROM DetalleGrupoPersona WHERE GrupoPersona_idGrupoPersona = @grupoPersonaId";
                cmd.Parameters.AddWithValue("@grupoPersonaId", grupoPersonasId);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Persona persona = new Persona(reader);
                    personas.Add(persona);
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

        public Error GetGruposDePersonas(out List<GrupoPersona> gruposPersonas)
        {
            base.connection.Open();
            gruposPersonas = new List<GrupoPersona>();

            try
            {
                MySqlCommand cmd = new MySqlCommand("GrupoPersona", base.connection);
                cmd.CommandType = System.Data.CommandType.TableDirect;

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    GrupoPersona grupo = new GrupoPersona
                    {
                        idGrupoPersona = (int)reader[0],
                        Nombre = (string)reader[1],
                        Descripcion = (string)reader[2]
                    };

                    gruposPersonas.Add(grupo);
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

        public Error GetGrupoDePersonas(int grupoPersonaId, out GrupoPersona grupoPersonas)
        {
            base.connection.Open();
            grupoPersonas = null;

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = base.connection;

                cmd.CommandText = "SELECT * FROM GrupoPersona WHERE idGrupoPersona = @grupoPersonaId;";
                cmd.Parameters.AddWithValue("@grupoPersonaId", grupoPersonaId);

                MySqlDataReader reader = cmd.ExecuteReader();
                //if(!reader.HasRows)
                //{
                //    return Error.NoError;
                //}
                if(reader.Read())
                {
                    grupoPersonas = new GrupoPersona
                    {
                        idGrupoPersona = (int)reader[0],
                        Nombre = (string)reader[1],
                        Descripcion = (string)reader[2]
                    };
                }
                else
                {
                    return Error.RegistroNoEncontrado;
                }

                //llena la lista de personas
                cmd.CommandText = "SELECT * FROM DetalleGrupoPersona WHERE GrupoPersona_idGrupoPersona = @grupoPersonaId";
                cmd.Parameters.AddWithValue("@grupoPersonaId", grupoPersonaId); //creo que no ocupas volver a agreagar este param, pues arriba se hizo, not sure...

                reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    Persona persona = new Persona(reader);
                    grupoPersonas.AñadirPersona(persona);
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

        public Error SetGrupoDePersonas(GrupoPersona grupoPersonas, bool EsNuevo)
        {
            base.connection.Open();

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = base.connection;

                string query;
                if(EsNuevo)
                {
                    query = "INSERT INTO GrupoPersona(Nombre, Descripcion) VALUES (@Nombre, @Descripcion);";
                }
                else
                {
                    query = "UPDATE GrupoPersona SET Nombre = @Nombre, Descripcion = @Descripcion WHERE idGrupoPersona = @idGrupoPersona";
                }
                cmd.CommandText = query;

                cmd.Parameters.AddWithValue("@idGrupoPersona", grupoPersonas.idGrupoPersona);
                cmd.Parameters.AddWithValue("@Nombre", grupoPersonas.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", grupoPersonas.Descripcion);

                //agrega las personas relacionadas
                cmd.CommandText = "DELETE FROM DetalleGrupoPersona WHERE GrupoPersona_idGrupoPersona = @idGrupoPersona";
                cmd.ExecuteNonQuery();

                query = "INSERT INTO DetalleGrupoPersona(Persona_idPersona, GrupoPersona_idGrupoPersona) VALUES ";
                foreach(Persona persona in grupoPersonas.personas)
                {
                    query += string.Format("({0}, {1}), ", persona.Id, grupoPersonas.idGrupoPersona);
                }
                query.TrimEnd(',');
                query += ";";

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
    
        public Error DeleteGrupoDePersonas(int grupoPersonaId)
        {
            base.connection.Open();

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = base.connection;

                cmd.Parameters.AddWithValue("@idGrupoPersona", grupoPersonaId);

                cmd.CommandText = "DELETE FROM GrupoPersona WHERE idGrupoPersona = @idGrupoPersona;"
                cmd.ExecuteNonQuery();

                cmd.CommandText = "DELETE FROM DetalleGrupoPersona WHERE GrupoPersona_idGrupoPersona = @idGrupoPersona";
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
