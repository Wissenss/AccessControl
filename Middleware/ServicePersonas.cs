using AccessControl.Models;
using Middleware.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Middleware
{
    public class ServicePersonas : Service, IService
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

                if (persona == null)
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

        public Error GetPersonasByGroup(int idGrupo, out List<Persona> personas, bool keepOpen)
        {
            //base.connection.Open();
            personas = new List<Persona>();
            try
            {
                if (base.connection.State != System.Data.ConnectionState.Open)
                {
                    base.connection.Open();
                }
                string columns = "idPersona, Nombres, Apellidos, Celular, Correo";
                string query = $"SELECT {columns} FROM persona JOIN ON Persona_idPersona = idPersona  WHERE GrupoPersona_idGrupoPersona = {idGrupo}";
                MySqlCommand command = new MySqlCommand(query, base.connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = (int)reader[0];
                    string nombres = (string)reader[1];
                    string apellidos = (string)reader[2];
                    string celular = (string)reader[3];
                    string correo = (string)reader[4];
                    Persona Persona = new Persona(id, nombres, apellidos, celular, correo);

                    personas.Add(Persona);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return Error.Desconocido;
            }
            finally
            {
                if (!keepOpen) base.connection.Close();
            }

            return Error.NoError;
        }

        public Error GetGruposDePersonas(out List<GrupoPersona> gruposDePuertas)
        {
            base.connection.Open();
            gruposDePuertas = new List<GrupoPersona>();
            try
            {
                string queryGrupo = "SELECT * FROM grupopersona;";
                MySqlCommand command = new MySqlCommand(queryGrupo, base.connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int idGrupo = (int)reader[0];
                    string Nombre = (string)reader[1];
                    string Descripcion = (string)reader[2];
                    GetPersonasByGroup(idGrupo, out List<Persona> PersonasAsociadas, true);
                    GrupoPersona grupopersona = new GrupoPersona(idGrupo, Nombre, Descripcion, PersonasAsociadas);
                    gruposDePuertas.Add(grupopersona);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally { base.connection.Close(); }
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
                if (newPersona)
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

        //lol, escribi los mismos
        //public Error GetPersonasByGroup(int grupoPersonasId, out List<Persona> personas)
        //{
        //    base.connection.Open();
        //    personas = new List<Persona>();

        //    try
        //    {
        //        MySqlCommand cmd = new MySqlCommand();
        //        cmd.Connection = base.connection;

        //        cmd.CommandText = "SELECT * FROM DetalleGrupoPersona WHERE GrupoPersona_idGrupoPersona = @grupoPersonaId";
        //        cmd.Parameters.AddWithValue("@grupoPersonaId", grupoPersonasId);

        //        MySqlDataReader reader = cmd.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            Persona persona = new Persona(reader);
        //            personas.Add(persona);
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        return Error.Desconocido;
        //    }
        //    finally
        //    {
        //        base.connection.Close();
        //    }

        //    return Error.NoError;
        //}

        //public Error GetGruposDePersonas(out List<GrupoPersona> gruposPersonas)
        //{
        //    base.connection.Open();
        //    gruposPersonas = new List<GrupoPersona>();

        //    try
        //    {
        //        MySqlCommand cmd = new MySqlCommand("GrupoPersona", base.connection);
        //        cmd.CommandType = System.Data.CommandType.TableDirect;

        //        MySqlDataReader reader = cmd.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            GrupoPersona grupo = new GrupoPersona
        //            {
        //                idGrupoPersona = (int)reader[0],
        //                Nombre = (string)reader[1],
        //                Descripcion = (string)reader[2]
        //            };

        //            gruposPersonas.Add(grupo);
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        return Error.Desconocido;
        //    }
        //    finally
        //    {
        //        base.connection.Close();
        //    }

        //    return Error.NoError;
        //}

        public Error GetGrupoDePersonas(int grupoPersonaId, out GrupoPersona grupoPersonas)
        {
            base.connection.Open();
            grupoPersonas = null;

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = base.connection;
                cmd.Parameters.AddWithValue("@grupoPersonaId", grupoPersonaId);

                cmd.CommandText = "SELECT * FROM GrupoPersona WHERE idGrupoPersona = @grupoPersonaId;";

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
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
                reader.Close();

                //llena la lista de personas
                cmd.CommandText = "SELECT b.* FROM DetalleGrupoPersona a INNER JOIN Persona b ON a.GrupoPersona_idGrupoPersona = @grupoPersonaId AND a.Persona_idPersona = b.idPersona";

                reader = cmd.ExecuteReader();

                while (reader.Read())
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
            MySqlConnection conn = base.connection;
            MySqlTransaction transaction = null;

            try
            {
                MySqlCommand cmd = conn.CreateCommand();
                conn.Open();
                transaction = base.connection.BeginTransaction();

                cmd.Parameters.AddWithValue("@Nombre", grupoPersonas.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", grupoPersonas.Descripcion);

                if (EsNuevo)
                {
                    cmd.CommandText = "INSERT INTO GrupoPersona(Nombre, Descripcion) VALUES (@Nombre, @Descripcion);";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "SELECT LAST_INSERT_ID();"; //jala el id generado para el registro anterior.
                    grupoPersonas.idGrupoPersona = Convert.ToInt32(cmd.ExecuteScalar());
                    cmd.Parameters.AddWithValue("@IdGrupoPersona", grupoPersonas.idGrupoPersona);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@IdGrupoPersona", grupoPersonas.idGrupoPersona);
                    cmd.CommandText = "UPDATE GrupoPersona SET Nombre = @Nombre, Descripcion = @Descripcion WHERE idGrupoPersona = @IdGrupoPersona";
                    cmd.ExecuteNonQuery();
                }

                //agrega las personas relacionadas
                cmd.CommandText = "DELETE FROM detallegrupopersona WHERE GrupoPersona_idGrupoPersona = @IdGrupoPersona";
                cmd.ExecuteNonQuery();

                string query = "INSERT INTO detallegrupopersona(Persona_idPersona, GrupoPersona_idGrupoPersona) VALUES ";
                foreach (Persona persona in grupoPersonas.personas)
                {
                    query += string.Format("({0}, {1}), ", persona.Id, grupoPersonas.idGrupoPersona);
                }
                query = query.TrimEnd(new char[] { ' ', ',' }) + ";";

                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                transaction.Commit();
            }
            catch (Exception e)
            {
                transaction.Rollback();
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

                cmd.CommandText = "DELETE FROM DetalleGrupoPersona WHERE GrupoPersona_idGrupoPersona = @idGrupoPersona";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "DELETE FROM GrupoPersona WHERE idGrupoPersona = @idGrupoPersona;";
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
