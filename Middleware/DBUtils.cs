using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

using System.Data;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

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

                MessageBox.Show("Actualizacion Terminada");

                conn.Close();
            }

            return Error.NoError;
        }
    }
}
