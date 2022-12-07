using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Test.SqlConn
{
    class DBMySQLUtils
    {

        public static MySqlConnection
                 GetDBConnection(string host, string database, string username, string password)
        {
            // Chaîne de connection
            String connString = "Server=" + host + ";Database=" + database
                + ";User Id=" + username + ";password=" + password;

            MySqlConnection conn = new MySqlConnection(connString);

            return conn;
        }

    }
}