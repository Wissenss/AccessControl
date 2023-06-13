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
        public static MySqlScript script = new MySqlScript();

        public static Error InizializarDB(ServiceProvider serviceProvider)
        {
            MySqlConnection conn = serviceProvider.connection;

            script.Connection = conn;
            string sqlScript;

            conn.Open();

            //elimina las tablas
            sqlScript = File.ReadAllText("sqlScripts/dropDatabase.sql");
            script.Query = sqlScript;
            script.Execute();

            //crea las tablas
            sqlScript = File.ReadAllText("sqlScripts/initDatabase.sql");
            script.Query = sqlScript;
            script.Execute();

            //llena los campos con la info del demo
            sqlScript = File.ReadAllText("sqlScripts/fillDatabase.sql");
            script.Query = sqlScript;
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

            return Error.NoError;
        }
    }
}
