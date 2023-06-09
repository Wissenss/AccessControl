using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessControl.Models;
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
    }
}
