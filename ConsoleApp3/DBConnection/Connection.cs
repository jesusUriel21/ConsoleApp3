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
        //Cadenas de conexion a servidor MySQl
        private string MySqlConnectionOne = "server=localhost; database=usuarios; uid=root; pwd=nokia620*; port=3306";
        private string MySqlConnectionTwo = "server=192.168.100.107; database=usuarios; uid=remote; pwd=1234; port=3307";
        //Cadenas de conexión a SQLServer
        private string SQLServerConnectionOne = "Data Source=DESKTOP-9JCSRBN; Initial Catalog=Productos; User=sa; Password=nokia620*";
        private string SQLServerConnectionTwo = "Data Source=DESKTOP-3QE31CC; Initial Catalog=Store; User=sa; Password=nokia620*";


        //Conexión a la base de datos MySQL
        public string MySqlConnectionString => MySqlConnectionTwo;
        //Conexión a la base de datos SQL Server
        public string SQLServerConnectionString => SQLServerConnectionTwo;
    }
}
