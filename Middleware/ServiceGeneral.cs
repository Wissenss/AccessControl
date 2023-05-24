using System;
using System.Collections.Generic;
using System.Text;

using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Middleware
{
    public class ServiceGeneral: Service, IService
    {
        public ServiceGeneral(MySqlConnection connection) : base(connection) { } 

        public Error Login(string nombre, string clave)
        {


            return Error.NoError;
        }
    }
}
