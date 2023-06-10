using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessControl.Models;
using Middleware.Models;
using MySql.Data.MySqlClient;

namespace Middleware
{
    public class ServicePuertas : Service, IService
    {
        //lsta de puertas, basando en Service Personas
        public ServicePuertas(MySqlConnection connection) : base(connection) { }

        public Error GetPuertas(out List<Puerta> puertas)
        {
            base.connection.Open();
            puertas = new List<Puerta>();
            try
            {
                string query = "SELECT * FROM puerta";
                MySqlCommand command = new MySqlCommand(query, base.connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int idPuerta = (int)reader[0];
                    string descripcion = (string)reader[1];
                    string ubicacion = (string)reader[2];
                    string observaciones = (string)reader[3];
                    Puerta puerta = new Puerta(idPuerta, descripcion, ubicacion, observaciones);

                    puertas.Add(puerta);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return Error.Desconocido;
            }
            finally
            {
                base.connection.Close();
            }

            return Error.NoError;
        }

        public Error GetPuertasByGroup(int idGrupo, out List<Puerta> puertas)
        {
            //base.connection.Open();
            puertas = new List<Puerta>();
            try
            {
                string query = $"SELECT * FROM puerta WHERE grupoPuerta_idGrupo = {idGrupo}";
                MySqlCommand command = new MySqlCommand(query, base.connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int idPuerta = (int)reader[0];
                    string descripcion = (string)reader[1];
                    string ubicacion = (string)reader[2];
                    string observaciones = (string)reader[3];
                    Puerta puerta = new Puerta(idPuerta, descripcion, ubicacion, observaciones);

                    puertas.Add(puerta);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return Error.Desconocido;
            }
            finally
            {
                //base.connection.Close();
            }

            return Error.NoError;
        }

        public Error GetGruposDePuertas(out List<GrupoPuerta> gruposDePuertas)
        {
            base.connection.Open();
            gruposDePuertas = new List<GrupoPuerta>();
            try
            {
                string queryGrupo = "SELECT * FROM grupopuerta";
                MySqlCommand command = new MySqlCommand(queryGrupo, base.connection);
                MySqlDataReader reader = command.ExecuteReader();
                
                while (reader.Read())
                {
                    int idGrupo = (int)reader[0];
                    string Nombre = (string)reader[1];
                    string Descripcion = (string)reader[2];
                    GetPuertasByGroup(idGrupo, out List<Puerta> puertasAsociadas);
                    GrupoPuerta grupopuerta = new GrupoPuerta(idGrupo, Nombre, Descripcion, puertasAsociadas);
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
    }
}
