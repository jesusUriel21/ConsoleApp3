using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp3.Seguridad
{
    internal class ClassValidation
    {
        public void emailFormat(string email)
        {
            Regex rgx = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");

            if (string.IsNullOrWhiteSpace(email) || email is null)
            {
                Console.WriteLine("formato no valido");
            }
            else
            {
                if (rgx.IsMatch(email))
                {
                    Console.WriteLine("Formato valido");
                }
                else
                {
                    Console.WriteLine("Formato invalido");
                }
            }
        }
    }
}
