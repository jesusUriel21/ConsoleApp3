using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.StConeection
{
    public class dbConnection
    {
        private string strConnection = "server=localhost; database=login; uid=root; pwd=nokia620*";

       
        public void SetMySqlConnection()
        {

            MySqlConnection cn = new MySqlConnection(strConnection);

            try
            {
                cn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


        public string GetMySqlConnection()
        {
            return strConnection;
        }


    }
}
