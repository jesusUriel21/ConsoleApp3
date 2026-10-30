using ConsoleApp3.Data;
using ConsoleApp3.Data.Store;
using ConsoleApp3.Data.Usuarios;
using ConsoleApp3.Menus;
using ConsoleApp3.Seguridad;
using ConsoleApp3.StConeection;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp3.Acceso
{
    public class ClassAcceso
    {
      
        Connection connection = new Connection();

        private string consulta2 = "select correo, contrasena from cuenta where correo = @correo and contrasena = @contrasena";

        public void findUser(string correo, string contrasena)
        {
            try
            {
                using (MySqlConnection cn = new MySqlConnection(connection.MySqlConnectionString))
                {
                    try
                    {
                        cn.Open();
                        using (MySqlCommand cmd = new MySqlCommand(consulta2, cn))
                        {
                            cmd.Parameters.AddWithValue("@correo", correo);
                            cmd.Parameters.AddWithValue("@contrasena", contrasena);
                            using (MySqlDataReader rd = cmd.ExecuteReader())
                            {
                                if (rd.HasRows)
                                {
                                    Console.WriteLine("Usuario y contraseña correctos \niniciando sesión....");
                                    Task.Delay(5000).Wait();
                                    Console.Clear();
                                    ClassMenu menu = new ClassMenu();
                                    menu.ShowMenu();
                                    ClassStore store = new ClassStore();
                                    Console.WriteLine("id  ||  Marca ");
                                    store.GetBrands();
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("Error: Verifique que el usuario o contraseña esten bien escritos.");
                                    Console.WriteLine("Redireccionando");
                                    Task.Delay(5000).Wait();
                                    Console.Clear();
                                    ClassMenu menu = new ClassMenu();   
                                    menu.Loggin();
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

    }
}
