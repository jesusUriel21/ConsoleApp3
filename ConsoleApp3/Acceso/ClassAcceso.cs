using ConsoleApp3.Data;
using ConsoleApp3.Seguridad;
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
        public void Loggin()
        {
            ClassUsuario us = new ClassUsuario();
            ClassValidation cs = new ClassValidation();
            Console.WriteLine("Sistema de gestion de usuarios" + "\n " + "\n Escriba su email");
            string email = Console.ReadLine();
            cs.emailFormat(email.Trim());
            Console.WriteLine("Escriba su contraseña");
            string pass = Console.ReadLine();
        }
    }
}
