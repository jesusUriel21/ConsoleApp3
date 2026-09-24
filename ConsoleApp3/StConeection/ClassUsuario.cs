using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.StConeection
{
    public class ClassUsuario
    {

        dbConnection db = new dbConnection();




        private string consulta1 = "select id_usuario, email, pass from usuario";
        private string consulta2 = "select email from usuario where email = @email";
        private string passw = "select pass from usuario";
        
        public void findUser(string email)
        {
            try
            {
                using (MySqlConnection cn = new MySqlConnection(db.GetMySqlConnection()))
                {
                    try
                    {
                        cn.Open();
                        using (MySqlCommand cmd = new MySqlCommand(consulta2, cn))
                        {
                            cmd.Parameters.AddWithValue("@email", email);

                            using (MySqlDataReader rd = cmd.ExecuteReader())
                            {
                                if (rd.HasRows)
                                {
                                    Console.WriteLine("Usuario encontrado");
                                }
                                else
                                {
                                    Console.WriteLine("No se encontro el usuario.");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al conectar con el servidor: error " + ex);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al conectar con el servidor: error {ex}");
            }

        }


 

        public void GetUsuario()
        {
            
            
            try
            {

                using (MySqlConnection cn  = new MySqlConnection(db.GetMySqlConnection()))
                {
                    try
                    {
                        cn.Open();
                        Console.WriteLine("Conexión exitosa");

                        using (MySqlCommand cm = new MySqlCommand(consulta1,cn))
                        {
                            using (MySqlDataReader dr = cm.ExecuteReader())
                            {
                                while (dr.Read())
                                {
                                    int id_usuario = dr.GetInt32("id_usuario");
                                    string email = dr.GetString("email");
                                    string pass = dr.GetString("pass");
                                    Console.WriteLine($"{id_usuario} |   {email}  |  {pass}");

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
