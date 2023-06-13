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
            acceso = new List<DiaTipo>();
            base.connection.Open();
            try
            {
                string query = $"SELECT * FROM accesossemana WHERE SemanaTipo_idSemanaTipo = {idSemana}";
                MySqlCommand command = new MySqlCommand(query, base.connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    //crear el objeto acceso
                }

            }
            catch (Exception) { return Error.Desconocido; }
            finally { base.connection.Close(); }
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
                    //crear el objeto semana tipo
                }

            }
            catch (Exception) { return Error.Desconocido; }
            finally { base.connection.Close(); }
            //Enviamos el id de la SEMANA
            GetDerechosPorSemana(1, out List<DiaTipo> acceso);
            //semanatal.setDetallesAcceso = acceso
            return Error.NoError;
        }
    }
}
