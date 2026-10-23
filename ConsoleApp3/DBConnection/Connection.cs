using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.StConeection
{
    public class Connection
    {
        private string MySqlConnection = "server=localhost; database=usuarios; uid=root; pwd=nokia620*";
        private string SQLServerConnection = "Data Source=DESKTOP-9JCSRBN; Initial Catalog=Productos; User=sa; Password=nokia620*";

        //Conexión a la base de datos MySQL
        public string MySqlConnectionString => MySqlConnection;
        //Conexión a la base de datos SQL Server
        public string SQLServerConnectionString => SQLServerConnection;
    }
}
