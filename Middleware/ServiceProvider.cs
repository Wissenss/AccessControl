using System;
using System.Management.Instrumentation;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Middleware
{
    public class ServiceProvider
    {
        public MySqlConnection connection;
        
        public ServiceGeneral ServiceGeneral { get; private set; }

        public Settings settings;

        private static ServiceProvider _instance = null;

        private ServiceProvider()
        {
            //la string de conexion es creada utilizando las configuraciones del ini
            settings = new Settings();
            string connectionString = string.Format("server={0};uid={1};pwd={2};database={3}",
                settings.Server,
                settings.Uid,
                settings.Pwd,
                settings.Database);


            //establece la conexion
            this.connection = new MySqlConnection(connectionString);
            this.connection.Open();
            this.connection.Close();

            //inicia los diversos servicios
            ServiceGeneral = new ServiceGeneral(this.connection);
        }

        public static ServiceProvider Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ServiceProvider();
                }
                return _instance;
            }
        }

        /// <summary>
        /// This Method Invokes a certain service method.
        /// </summary>
        //static public void invoke(Func<> method, object[] parameters)
        public Error Invoke(Type serviceType, string methodName, object[] arguments)
        {
            if(connection.State == System.Data.ConnectionState.Closed)
                connection.Open();

            Error error = (Error)serviceType.GetMethod(methodName).Invoke(null, arguments);

            if(connection.State == System.Data.ConnectionState.Open)
                connection.Close();

            return error;
        }
    }
}
