using ConsoleApp3.StConeection;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Data.Usuarios
{
    public class ClassUsuario
    {
        //Se llama e instancia la clase conexion para acceder a la base de datos MySQL
        Connection db = new Connection();
        //Consulta a la tabla usuario para validar la existencia.
        private string consulta1 = "select nombre from usuario";
        //Funcion o metodo para obtener los usuarios
        public string GetUser()
        {

            string nombre_usuario = "";

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
                                    //int id_usuario = dr.GetInt32("id_usuario");
                                    string nombre = dr.GetString("nombre");
                                    //string apellido_paterno = dr.GetString("apellido_paterno");
                                    //string apellido_materno = dr.GetString("apellido_materno");
                                     nombre_usuario= $"{nombre}";   
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

            return nombre_usuario;
        }
    }
}
