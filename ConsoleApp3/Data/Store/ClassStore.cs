using ConsoleApp3.StConeection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Data.Store
{
    public class ClassStore
    {

        Connection dbConnection = new Connection();

        private string queryBrnad = "select id_brand, brand_name from brands";

        public void GetBrands()
        {

            using (SqlConnection connectionSQL = new SqlConnection(dbConnection.SQLServerConnectionString))
            {
                try
                {
                    connectionSQL.Open();

                    using (SqlCommand command = new SqlCommand(queryBrnad, connectionSQL))
                    {
                        try
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    int id_brand = reader.GetInt32("id_brand");
                                    string brand_name = reader.GetString("brand_name");
                                    Console.WriteLine($"{id_brand}   ||  {brand_name}");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error al conectar con la base de datos: error " + ex.Message);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al conentar con la base de datos: error " + ex.Message);
                }
            }
        }

    }
}
