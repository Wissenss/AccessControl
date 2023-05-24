using System;
using System.Collections.Generic;
using System.Text;

using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Middleware
{
    public class Service: IService
    {
        public MySqlConnection connection { get; set; }
        public Service(MySqlConnection connection) 
        {
            this.connection = connection;
        }
    }
}
