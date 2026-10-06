using ConsoleApp3.Acceso;
using ConsoleApp3.StConeection;

namespace ConsoleApp3
{
    internal class Program
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0090:Usar \"new(...)\"", Justification = "<pendiente>")]
        static void Main(string[] args)
        {
            ClassAcceso ca = new ClassAcceso();
            dbConnection dbc = new dbConnection();
            dbc.SetSqlServerConnection();
            ca.Loggin();
        }
    }
}
