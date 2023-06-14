using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessControl.Models;
using Middleware.Models;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Crmf;

namespace Middleware
{
    public class ServiceSemanasTipo : Service, IService
    {
        List<GrupoPuerta> gruposPuerta;
        List<GrupoPersona> gruposPersona;
        private static string[] diasEstaticos = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sábado", "Domingo" };
        public ServiceSemanasTipo(MySqlConnection connection) : base(connection) { }
        //Lista de SemanasTipo, con sus Días y Derechos 
        /*
            ToDo
            GetSemanasTipo(out List<SemanaTipo> semanas); DONE
            GetSemanaTipo(int semanaTipoId, out SemanaTipo semana);
            SetSemanaTipo(SemanaTipo semana); DONE
            DeleteSemanaTipo(int semanaTipoId); 

            AgendarSemanaTipo(SemanaTipo semana, DateTime fechaIncial, DateTime, fechaFinal); DONE

            GetAccesos(DateTime fechaIncial, DateTime, fechaFinal, out List<>); DONE (pero por semana)
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
                DiaTipo dia = new DiaTipo(diasEstaticos[i]);
                foreach (string[] hora in diaActual)
                {
                    int horaInt = Int32.Parse(hora[1]);
                    GrupoPuerta grupoLlave = gruposPuerta.Find((grupo) => grupo.IdGrupoPuerta == Int32.Parse(hora[2]));
                    GrupoPersona gruposAcceso = gruposPersona.Find((grupo) => grupo.idGrupoPersona == Int32.Parse(hora[3]));
                    if (!dia.horariosAcceso[horaInt].ContainsKey(grupoLlave))
                    {
                        dia.horariosAcceso[horaInt].Add(grupoLlave, new List<GrupoPersona>());
                    }
                    dia.horariosAcceso[horaInt][grupoLlave].Add(gruposAcceso);
                }
                acceso.Add(dia);
            }

            return Error.NoError;
        }

        public Error GetSemanasTipo(out List<SemanaTipo> semanas)
        {
            ServiceProvider.Instance.ServicePuertas.GetGruposDePuertas(out gruposPuerta);
            ServiceProvider.Instance.ServicePersonas.GetGruposDePersonas(out gruposPersona);
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
                    SemanaTipo semana = new SemanaTipo(idSemana, Descripcion);
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

        public Error SetSemanaTipo(SemanaTipo semanaRegistrar, bool NuevoRegistro)
        {
            base.connection.Open();
            MySqlTransaction transaction = base.connection.BeginTransaction();
            try
            {
                MySqlCommand cmd = base.connection.CreateCommand();
                cmd.Parameters.Add("?Descripcion", MySqlDbType.VarChar).Value = semanaRegistrar.Descripcion;
                if (NuevoRegistro)
                {
                    cmd.CommandText = "INSERT INTO semanatipo (Descripcion) VALUES (?Descripcion)";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "SELECT LAST_INSERT_ID()";
                    semanaRegistrar.IdSemanaTipo = Convert.ToInt32(cmd.ExecuteScalar());
                    cmd.Parameters.Add("?idSemana", MySqlDbType.Int32).Value = semanaRegistrar.IdSemanaTipo;
                }
                else
                {
                    cmd.Parameters.Add("?idSemana", MySqlDbType.Int32).Value = semanaRegistrar.IdSemanaTipo;
                    cmd.CommandText = "UPDATE semanatipo SET Descripcion = ?Descripcion WHERE idSemanaTipo = ?idSemana";
                    cmd.ExecuteNonQuery();
                }

                //Excesivo borrar todos(?, no sé si es más barato borrar todos, o traer todo desde DB para ver
                //qué ha cambiado 
                cmd.CommandText = "DELETE FROM accesossemana WHERE SemanaTipo_idSemanaTipo = ?idSemana";
                cmd.ExecuteNonQuery();

                string queryDerechos = "INSERT INTO accesossemana " +
                    "(DiaSemana, HoraInciol, GrupoPuerta_idGrupoPuerta, " +
                    "GrupoPersona_idGrupoPersona, SemanaTipo_idSemanaTipo) " +
                    "VALUES ";
                foreach (DiaTipo dia in semanaRegistrar.semana)
                {
                    foreach(KeyValuePair<int, Dictionary<GrupoPuerta, List<GrupoPersona>>> acceso in dia.horariosAcceso)
                    {
                        foreach(KeyValuePair<GrupoPuerta, List<GrupoPersona>> derecho in acceso.Value)
                        {
                            foreach(GrupoPersona persona in derecho.Value)
                            {
                                queryDerechos += $"('{dia.name}', {Convert.ToInt32(acceso.Key)}, " +
                                $"{Convert.ToInt32(derecho.Key.IdGrupoPuerta)}, " +
                                $"{Convert.ToInt32(persona.idGrupoPersona)}, " +
                                $"{semanaRegistrar.IdSemanaTipo}), ";
                            }
                        }
                    }
                }
                queryDerechos.TrimEnd();
                StringBuilder sb = new StringBuilder(queryDerechos);
                sb[queryDerechos.LastIndexOf(',')] = ';';
                queryDerechos = sb.ToString();

                cmd.CommandText = queryDerechos; 
                cmd.ExecuteNonQuery();

                transaction.Commit();
            }
            catch (Exception)
            {
                return Error.Desconocido;
            }
            finally
            {
                base.connection.Close();
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

                if (!reader.HasRows) //checa que la semana exista
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
