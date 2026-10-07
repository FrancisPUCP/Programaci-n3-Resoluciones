using Microsoft.Extensions.Configuration;
using PokeSoftBusinessLogic.BO;
using PokeSoftBusinessLogic.BOI;
using PokeSoftDBManager;

namespace PokemonSoftApp;

public class Program
{
    public static void Main(String[] args)
    {
        IConfiguration configuracion =
            new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        string? cadenaConexion =
            configuracion.GetConnectionString("MySqlConnection");

        DBManager.Instance.Inicializar(cadenaConexion);

        Console.WriteLine("Laboratorio 07 - PROG3");

        IMigratorBO migratorBO = new MigratorBOImpl();
        migratorBO.Run();

        Console.WriteLine("Migracion finalizada correctamente");
    }
}
