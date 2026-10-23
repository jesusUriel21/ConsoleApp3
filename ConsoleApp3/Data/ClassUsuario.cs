using ConsoleApp3.StConeection;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Data
{
    public class ClassUsuario
    {

        Connection db = new Connection();

        private string consulta1 = "select id_usuario, nombre, apellido_paterno, apellido_materno from usuario";
     
        public void GetAllUsers()
        {
            try
            {
                using (MySqlConnection cn  = new MySqlConnection(db.MySqlConnectionString))
                {
                    try
                    {
                        cn.Open();
                        using (MySqlCommand cm = new MySqlCommand(consulta1,cn))
                        {
                            using (MySqlDataReader dr = cm.ExecuteReader())
                            {
                                while (dr.Read())
                                {
                                    int id_usuario = dr.GetInt32("id_usuario");
                                    string nombre = dr.GetString("nombre");
                                    string apellido_paterno = dr.GetString("apellido_paterno");
                                    string apellido_materno = dr.GetString("apellido_materno");
                                    Console.WriteLine($"{id_usuario} |   {nombre}  |   {apellido_paterno}  |  {apellido_materno}");
                                }
                            }
                        }


                    }catch (Exception ex)
                    {
                        Console.WriteLine($"Error al conectar: código de error {ex}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar con la base de datos: error "+ex);
            }
        }
    }
}
