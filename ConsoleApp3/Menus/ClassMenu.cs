using ConsoleApp3.Acceso;
using ConsoleApp3.Data;
using ConsoleApp3.Data.Usuarios;
using ConsoleApp3.Seguridad;
using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Menus
{
    public class ClassMenu
    {


        public void Loggin()
        {
            ClassAcceso us = new ClassAcceso();
            ClassValidation cs = new ClassValidation();
            Console.WriteLine("Sistema de gestion de usuarios" + "\n" + "Escriba su email");
            string correo = Console.ReadLine();
            Console.WriteLine("Escriba su contraseña");
            string contrasena = Console.ReadLine();
            us.findUser(correo, contrasena);
        }





        public void ShowMenu()
        {
            ClassUsuario usuario = new ClassUsuario();
            Console.WriteLine($"Bienvenido {usuario.GetUser()}");
            Console.WriteLine();
        }



    }
}
