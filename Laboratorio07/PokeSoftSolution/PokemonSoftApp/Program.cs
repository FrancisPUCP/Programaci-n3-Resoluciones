using PokeSoftBusinessLogic.BO;
using PokeSoftBusinessLogic.BOI;

namespace PokemonSoftApp;

public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Laboratorio 07 - PROG3");

        IMigratorBO migratorBO = new MigratorBOImpl();
        migratorBO.Run();

        Console.WriteLine("Migracion finalizada correctamente");
    }
}
