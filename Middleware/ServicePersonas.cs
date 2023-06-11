﻿using AccessControl.Models;
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
                string queryGrupo = "SELECT * FROM grupopersona";
                MySqlCommand command = new MySqlCommand(queryGrupo, base.connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int idGrupo = (int)reader[0];
                    string Nombre = (string)reader[1];
                    string Descripcion = (string)reader[2];
                    GetPersonasByGroup(idGrupo, out List<Persona> PersonasAsociadas, true);
                    GrupoPersona grupopuerta = new GrupoPersona(idGrupo, Nombre, PersonasAsociadas);
                    gruposDePuertas.Add(grupopuerta);
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
    }
}
