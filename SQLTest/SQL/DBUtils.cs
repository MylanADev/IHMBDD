using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Test.SqlConn
{
    class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "localhost";
            string database = "testdb";
            string username = "root";
            string password = "";

            return DBMySQLUtils.GetDBConnection(host, database, username, password);
        }

    }
}