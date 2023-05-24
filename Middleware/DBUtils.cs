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
                string sqlScript = File.ReadAllText("sqlScripts/initDatabase.sql");
                MySqlScript script = new MySqlScript(conn, sqlScript);

                script.StatementExecuted += DScriptExecution.On_StatementExecuted;
                script.Execute();

                MessageBox.Show("Actualizacion Terminada");
                //DScriptExecution.ShowDialog();

                conn.Close();
            }

            return Error.NoError;
        }
    }
}
