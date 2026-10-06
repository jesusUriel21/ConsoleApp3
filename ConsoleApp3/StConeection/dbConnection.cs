using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.StConeection
{
    public class dbConnection
    {
        private string MySqlConnection = "server=localhost; database=login; uid=root; pwd=nokia620*";
        private string SQLServerConnection = "Data Source=DESKTOP-9JCSRBN; Initial Catalog=Productos; User=sa; Password=nokia620*";


        ///Comprobacion de conexion a la base de datos
        public void SetMySqlConnection()
        {
            MySqlConnection cn = new MySqlConnection(MySqlConnection);
            try
            {
                cn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void SetSqlServerConnection()
        {
            SqlConnection cn = new SqlConnection(SQLServerConnection);

            try
            {
                cn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        ///Obteniendo conexion a la DB
        public string GetMySqlConnection()
        {
            return MySqlConnection;
        }

        public string GetSQLServerConnection()
        {
            return SQLServerConnection;
        }

    }
}
