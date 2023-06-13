using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

using System.Data;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Middleware.Models;
using System.Collections;

namespace Middleware
{
    //estas funciones en escencia se encargan de reescribir el esquema de la base de datos
    public static class DBUtils
    {
        public static Error InizializarDB(ServiceProvider serviceProvider)
        {
            MySqlConnection conn = serviceProvider.connection;

            using(VScriptExecution DScriptExecution = new VScriptExecution())
            {
                conn.Open();

                MySqlScript script;
                string sqlScript;

                //esto para meterlo a otra thread y mostrar el progreso, aun no me sale...
                //script.StatementExecuted += DScriptExecution.On_StatementExecuted; 
                //DScriptExecution.ShowDialog();

                //elimina las tablas
                sqlScript = File.ReadAllText("sqlScripts/dropDatabase.sql");
                script = new MySqlScript(conn, sqlScript);
                script.Execute();

                //crea las tablas
                sqlScript = File.ReadAllText("sqlScripts/initDatabase.sql");
                script = new MySqlScript(conn, sqlScript);
                script.Execute();

                //llena los campos con la info del demo
                sqlScript = File.ReadAllText("sqlScripts/fillDatabase.sql");
                script = new MySqlScript(conn, sqlScript);
                script.Execute();

                string query = "UPDATE Persona SET Imagen = @imagenBlob WHERE idPersona = @personaId"; //insertar imagenes con puro sql es mucha lata
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.Add("@imagenBlob", MySqlDbType.Blob);
                cmd.Parameters.Add("@personaId", MySqlDbType.Int32);
                for (int id = 1; id <= 6; id++)
                {
                    byte[] imagen = File.ReadAllBytes($"sqlScripts/blobsDemo/blob_{id}.jpg");
                    cmd.Parameters["@imagenBlob"].Value = imagen;
                    cmd.Parameters["@personaId"].Value = id;
                    cmd.ExecuteNonQuery();
                }

                conn.Close();

                MessageBox.Show("Actualizacion Terminada");
            }

            return Error.NoError;
        }
    }
}
