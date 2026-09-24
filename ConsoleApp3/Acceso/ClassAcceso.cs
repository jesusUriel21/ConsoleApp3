using ConsoleApp3.StConeection;
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

  

            Console.WriteLine("Sistema de gestion de usuarios" +
                "\n " +
                "\n Escriba su email");
            string email = Console.ReadLine();
            Console.WriteLine(email);
            us.findUser(email);
        }
    }
}
