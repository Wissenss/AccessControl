using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Middleware
{
    public class ServiceCatalogs: Service, IService
    {
        public ServiceCatalogs(MySqlConnection connection) : base(connection) { }

        public Error GetPersonas()
        {
            //not implemented yet!

            return Error.NoError;
        }
    }
}
