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
                    int idGrupo = (int)reader[4];
                    Puerta puerta = new Puerta(idPuerta, descripcion, ubicacion, observaciones, idGrupo);

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

        //Métodos para gestión de grupos individuales
        public Error CreatePuerta(Puerta puerta)
        {
            base.connection.Open();
            MySqlTransaction transaction = base.connection.BeginTransaction();
            try
            {
                string query = "INSERT INTO puerta VALUES (?idPuerta, ?Descripcion, ?Ubicacion, ?Observaciones, ?idGrupo)";
                MySqlCommand command = base.connection.CreateCommand();
                command.Parameters.Clear();
                command.Parameters.Add("?idPuerta", MySqlDbType.Int32).Value = puerta.IdPuerta;
                command.Parameters.Add("?Ubicacion", MySqlDbType.VarChar).Value = puerta.Ubicacion;
                command.Parameters.Add("?Descripcion", MySqlDbType.VarChar).Value = puerta.Descripcion;
                command.Parameters.Add("?Observaciones", MySqlDbType.VarChar).Value = puerta.Observaciones;
                command.Parameters.Add("?idGrupo", MySqlDbType.Int32).Value = -1;
                command.CommandText = query;
                command.ExecuteNonQuery();

                transaction.Commit();
            }
            catch (Exception)
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
        public Error UpdatePuerta(Puerta puerta)
        {
            base.connection.Open();
            MySqlTransaction transaction = base.connection.BeginTransaction();
            try
            {
                string query = "UPDATE puerta SET Ubicacion = ?Ubicacion, Descripcion = ?Descripcion, Observaciones = ?Observaciones WHERE idPuerta = ?idPuerta";
                MySqlCommand command = base.connection.CreateCommand();
                command.Parameters.Clear();
                command.Parameters.Add("?idPuerta", MySqlDbType.Int32).Value = puerta.IdPuerta;
                command.Parameters.Add("?Ubicacion", MySqlDbType.VarChar).Value = puerta.Ubicacion;
                command.Parameters.Add("?Descripcion", MySqlDbType.VarChar).Value = puerta.Descripcion;
                command.Parameters.Add("?Observaciones", MySqlDbType.VarChar).Value = puerta.Observaciones;
                command.CommandText = query;
                command.ExecuteNonQuery();

                transaction.Commit();
            }
            catch (Exception)
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
        public Error DeletePuerta(int IdPuerta)
        {
            base.connection.Open();
            MySqlTransaction transaction = base.connection.BeginTransaction();
            try
            {
                string query = "DELETE FROM puerta WHERE idPuerta = ?idPuerta";
                MySqlCommand command = base.connection.CreateCommand();
                command.Parameters.Clear();
                command.Parameters.Add("?idPuerta", MySqlDbType.Int32).Value = IdPuerta;
                command.CommandText = query;
                command.ExecuteNonQuery();

                transaction.Commit();
            }
            catch (Exception)
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

        public Error GetPuertasSinAsignar(out List<Puerta> puertas)
        {
            base.connection.Open();
            puertas = new List<Puerta>();
            try
            {
                string query = "SELECT * FROM puerta WHERE GrupoPuerta_idGrupo = -1";
                MySqlCommand command = new MySqlCommand(query, base.connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int idPuerta = (int)reader[0];
                    string descripcion = (string)reader[1];
                    string ubicacion = (string)reader[2];
                    string observaciones = (string)reader[3];
                    int idGrupo = (int)reader[4];
                    Puerta puerta = new Puerta(idPuerta, descripcion, ubicacion, observaciones, idGrupo);

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

        public Error GetPuertasByGroup(int idGrupo, out List<Puerta> puertas, bool keepOpen)
        {
            //base.connection.Open();
            puertas = new List<Puerta>();
            try
            {
                if (base.connection.State != System.Data.ConnectionState.Open)
                {
                    base.connection.Open();
                }
                string query = $"SELECT * FROM puerta WHERE grupoPuerta_idGrupo = {idGrupo}";
                MySqlCommand command = new MySqlCommand(query, base.connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int idPuerta = (int)reader[0];
                    string descripcion = (string)reader[1];
                    string ubicacion = (string)reader[2];
                    string observaciones = (string)reader[3];
                    int idGrupoPuerta = (int)reader[4];
                    Puerta puerta = new Puerta(idPuerta, descripcion, ubicacion, observaciones, idGrupoPuerta);
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
                if (!keepOpen) base.connection.Close();
            }

            return Error.NoError;
        }

        //Métodos para gestión de grupos de puertas
        public Error GetGruposDePuertas(out List<GrupoPuerta> gruposDePuertas)
        {
            base.connection.Open();
            gruposDePuertas = new List<GrupoPuerta>();
            try
            {
                string queryGrupo = "SELECT * FROM grupopuerta WHERE idGrupoPuerta > -1";
                MySqlCommand command = new MySqlCommand(queryGrupo, base.connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int idGrupo = (int)reader[0];
                    string Nombre = (string)reader[1];
                    string Descripcion = (string)reader[2];
                    GrupoPuerta grupopuerta = new GrupoPuerta(idGrupo, Nombre, Descripcion);
                    gruposDePuertas.Add(grupopuerta);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally { base.connection.Close(); }

            for (int i = 0; i < gruposDePuertas.Count; i++)
            {
                GetPuertasByGroup(gruposDePuertas[i].IdGrupoPuerta, out List<Puerta> puertasAsociadas, false);
                gruposDePuertas[i].SetPuertasAsociadas(puertasAsociadas);
            }

            return Error.NoError;
        }

        //Cuando modificamos un grupo, debemos actualizar también las que quedan sin asignar
        public Error UpdatePuertasDisponibles(List<Puerta> disponibles, out bool status)
        {
            status = true;
            base.connection.Open();
            MySqlTransaction transaction = base.connection.BeginTransaction();
            try
            {
                MySqlCommand command = base.connection.CreateCommand();
                foreach (Puerta puerta in disponibles)
                {
                    string query = "UPDATE puerta SET GrupoPuerta_idGrupo = ?idGrupo, Ubicacion = ?Nombre WHERE idPuerta = ?idPt";
                    command.Parameters.Clear();
                    command.Parameters.Add("?idGrupo", MySqlDbType.Int32).Value = -1;
                    command.Parameters.Add("?idPt", MySqlDbType.Int32).Value = puerta.IdPuerta;
                    command.Parameters.Add("?Nombre", MySqlDbType.VarChar).Value = "Sin Zona";
                    command.CommandText = query;

                    int afected = command.ExecuteNonQuery();
                    if (afected > 0)
                    {
                        status = true;
                    }
                }
                transaction.Commit();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                //rollback todo wapo
                transaction.Rollback();
                return Error.Desconocido;
            }
            finally
            {
                base.connection.Close();
            }

            return Error.NoError;
        }

        //cuando salvamos un grupo, solo hay que actualizar el idGrupo en la puerta de la DB
        private Error SavePuertasAsociadas(List<Puerta> asociadas, int idGrupo, string nombreGrupo, out bool status)
        {
            status = true;
            base.connection.Open();
            MySqlTransaction transaction = base.connection.BeginTransaction();
            try
            {
                MySqlCommand command = base.connection.CreateCommand();
                foreach (Puerta puerta in asociadas)
                {
                    string query = "UPDATE puerta SET GrupoPuerta_idGrupo = ?idGrupo, Ubicacion = ?Nombre WHERE idPuerta = ?idPt";
                    command.Parameters.Clear();
                    command.Parameters.Add("?idGrupo", MySqlDbType.Int32).Value = idGrupo;
                    command.Parameters.Add("?idPt", MySqlDbType.Int32).Value = puerta.IdPuerta;
                    command.Parameters.Add("?Nombre", MySqlDbType.VarChar).Value = nombreGrupo;
                    command.CommandText = query;

                    int afected = command.ExecuteNonQuery();
                    if (afected > 0)
                    {
                        status = true;
                    }
                }
                transaction.Commit();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                //rollback todo wapo
                transaction.Rollback();
                return Error.Desconocido;
            }
            finally
            {
                base.connection.Close();
            }

            return Error.NoError;
        }

        public Error SaveGrupoPuertas(GrupoPuerta nuevoGrupo, out bool status)
        {

            status = false;
            base.connection.Open();
            MySqlTransaction transaction = base.connection.BeginTransaction();
            try
            {
                MySqlCommand command = base.connection.CreateCommand();
                string query = "INSERT INTO GrupoPuerta (idGrupoPuerta, Nombre, Descripcion) VALUES (?idGrupo, ?Nombre, ?Descripcion)";

                command.Parameters.Add("?idGrupo", MySqlDbType.Int32).Value = nuevoGrupo.IdGrupoPuerta;
                command.Parameters.Add("?Nombre", MySqlDbType.VarChar).Value = nuevoGrupo.Nombre;
                command.Parameters.Add("?Descripcion", MySqlDbType.VarChar).Value = nuevoGrupo.Descripcion;
                command.CommandText = query;

                int afected = command.ExecuteNonQuery();
                if (afected > 0)
                {
                    status = true;
                }

                transaction.Commit();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                //rollback todo wapo
                transaction.Rollback();
                return Error.Desconocido;
            }
            finally
            {
                base.connection.Close();
            }
            return SavePuertasAsociadas(nuevoGrupo.GetPuertasAsociadas(), nuevoGrupo.IdGrupoPuerta, nuevoGrupo.Nombre, out status);
        }
        public Error UpdateGrupoPuertas(GrupoPuerta nuevoGrupo, out bool status)
        {

            status = false;
            base.connection.Open();
            MySqlTransaction transaction = base.connection.BeginTransaction();
            try
            {
                MySqlCommand command = base.connection.CreateCommand();
                string query = "UPDATE GrupoPuerta SET Nombre = ?Nombre, Descripcion = ?Descripcion WHERE idGrupoPuerta = ?idGrupo";

                command.Parameters.Add("?idGrupo", MySqlDbType.Int32).Value = nuevoGrupo.IdGrupoPuerta;
                command.Parameters.Add("?Nombre", MySqlDbType.VarChar).Value = nuevoGrupo.Nombre;
                command.Parameters.Add("?Descripcion", MySqlDbType.VarChar).Value = nuevoGrupo.Descripcion;
                command.CommandText = query;

                int afected = command.ExecuteNonQuery();
                if (afected > 0)
                {
                    status = true;
                }

                transaction.Commit();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                //rollback todo wapo
                transaction.Rollback();
                return Error.Desconocido;
            }
            finally
            {
                base.connection.Close();
            }
            return SavePuertasAsociadas(nuevoGrupo.GetPuertasAsociadas(), nuevoGrupo.IdGrupoPuerta, nuevoGrupo.Nombre, out status);
        }

        public Error DeleteGrupoPuerta(int idGrupo, out bool status)
        {
            status = false;
            GetPuertasByGroup(idGrupo, out List<Puerta> asociadas, false);
            //liberamos todas las puertas de este grupo, así 
            //evitamos problemas con la llave foránea hija
            //y no borramos puertas
            UpdatePuertasDisponibles(asociadas, out status);
            //y luego borramos el grupo como tal
            base.connection.Open();
            MySqlTransaction transaction = base.connection.BeginTransaction();
            try
            {
                MySqlCommand command = base.connection.CreateCommand();
                string query = "DELETE FROM GrupoPuerta WHERE idGrupoPuerta = ?idGrupo";

                command.Parameters.Add("?idGrupo", MySqlDbType.Int32).Value = idGrupo;
                command.CommandText = query;

                int afected = command.ExecuteNonQuery();
                if (afected > 0)
                {
                    status = true;
                }

                transaction.Commit();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                //rollback todo wapo
                transaction.Rollback();
                return Error.Desconocido;
            }
            finally
            {
                base.connection.Close();
            }
            return Error.NoError;
        }

        public Error GetPuerta(int idPuerta, out Puerta puerta)
        {
            base.connection.Open();
            puerta = null;

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = base.connection;
                cmd.CommandText = "SELECT * FROM Puerta WHERE idPuerta=@puertaId";

                cmd.Parameters.AddWithValue("@puertaId", idPuerta);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    puerta = new Puerta(reader);
                }

                if (puerta == null)
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

    }
}
