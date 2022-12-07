using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.SqlConn;
using MySql.Data.MySqlClient;

namespace ConnectMySQL
{
    class Program
    {
        static void Main(string[] args)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();

            try
            {
                Console.Write("Ouverture de la connection ...\n \n");

                conn.Open();

                Console.Write("Base de donnée connectée\n");
            }
            catch (Exception e)
            {
                Console.Write("Error: " + e.Message);
            }

            

            Console.Read();
        }
    }

}