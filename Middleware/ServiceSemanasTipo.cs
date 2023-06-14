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
    public class ServiceSemanasTipo : Service, IService
    {

        private static string[] diasEstaticos = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sábado", "Domingo" };
        public ServiceSemanasTipo(MySqlConnection connection) : base(connection) { }
        //Lista de SemanasTipo, con sus Días y Derechos 
        /*
            ToDo
            GetSemanasTipo(out List<SemanaTipo> semanas);
            GetSemanaTipo(int semanaTipoId, out SemanaTipo semana);
            SetSemanaTipo(SemanaTipo semana);
            DeleteSemanaTipo(int semanaTipoId);

            AgendarSemanaTipo(SemanaTipo semana, DateTime fechaIncial, DateTime, fechaFinal);

            GetAccesos(DateTime fechaIncial, DateTime, fechaFinal, out List<>);
            GetAcceso(int detalleAccesoId, out DetalleAcceso);
            SetAcceso(DetalleAcceso acceso);
            DeleteAcceso(int detalleAccesoId);
        */
        private Error GetDerechosPorSemana(int idSemana, out List<DiaTipo> acceso)
        {
            List<string[]> datosDia = new List<string[]>();
            acceso = new List<DiaTipo>();
            base.connection.Open();
            try
            {
                string query = $"SELECT * FROM accesossemana WHERE SemanaTipo_idSemanaTipo = {idSemana} ORDER BY DiaSemana";
                MySqlCommand command = new MySqlCommand(query, base.connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string DiaSemana = (string)reader[1];
                    string HoraInicio = reader[2].ToString();
                    string idGrupoPuerta = reader[3].ToString();
                    string idGrupoPersona = reader[4].ToString();
                    datosDia.Add(new string[] {
                        DiaSemana,
                        HoraInicio,
                        idGrupoPuerta,
                        idGrupoPersona
                    });
                }
            }
            catch (Exception) { return Error.Desconocido; }
            finally { base.connection.Close(); }

            for (int i = 0; i < diasEstaticos.Length; i++)
            {
                List<string[]> diaActual = datosDia.FindAll((datos) => datos[0] == diasEstaticos[i]);
                foreach (string[] derecho in diaActual)
                {
                    //Va a ser divertido esto de traer los grupos de puerta 
                    //y personas de permiso por permiso...
                    //Goey, jalalos desde el principioooooooo

                }
            }

            return Error.NoError;
        }

        public Error GetSemanasTipo(out List<SemanaTipo> semanas)
        {
            semanas = new List<SemanaTipo>();
            base.connection.Open();
            try
            {
                string query = "SELECT * FROM semanatipo";
                MySqlCommand command = new MySqlCommand(query, base.connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int idSemana = (int)reader[0];
                    string Descripcion = (string)reader[1];
                    DateTime fechaInicio = (DateTime)reader[2];
                    SemanaTipo semana = new SemanaTipo(idSemana, Descripcion, fechaInicio);
                    semanas.Add(semana);
                }

            }
            catch (Exception) { return Error.Desconocido; }
            finally { base.connection.Close(); }

            //luego de obtener todas las semanas, buscamos sus derechos registrados
            for (int i = 0; i < semanas.Count; i++)
            {
                GetDerechosPorSemana(semanas[i].IdSemanaTipo, out List<DiaTipo> diasSemana);
                semanas[i].SetDerechos(diasSemana);
            }
            return Error.NoError;
        }

        public Error AgendarSemana(SemanaTipo semana, DateTime fechaInicio)
        {
            base.connection.Open();

            try
            {
                MySqlDataReader reader;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = base.connection;

                cmd.CommandText = "SemanaTipo";
                cmd.CommandType = System.Data.CommandType.TableDirect;
                reader = cmd.ExecuteReader();

                if(!reader.HasRows) //checa que la semana exista
                {
                    return Error.RegistroNoEncontrado;
                }
                reader.Close();

                cmd.CommandText = "INSERT INTO Agenda(FechaInicio, semanatipo_idSemanaTipo) VALUES (@fechaInicio, @idSemanaTipo);";
                cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio.Date.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@idSemanaTipo", semana.IdSemanaTipo);

                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return Error.NoError;
            }
            finally
            {
                base.connection.Close();
            }

            return Error.NoError;
        }


    }
}
