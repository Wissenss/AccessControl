using System;
using System.Collections.Generic;
using System.Text;

using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Middleware
{
    public interface IService
    {
        MySqlConnection connection { get; set; }
    }
}
