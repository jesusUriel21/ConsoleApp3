using ConsoleApp3.Acceso;
using ConsoleApp3.Menus;
using ConsoleApp3.StConeection;

namespace ConsoleApp3
{
    internal class Program
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0090:Usar \"new(...)\"", Justification = "<pendiente>")]
        static void Main(string[] args)
        {
            ClassMenu menu = new ClassMenu();
            menu.Loggin();
        }
    }
}
