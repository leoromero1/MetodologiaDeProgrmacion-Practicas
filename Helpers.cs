using Practicas.Interfaces;
using Practicas.Models;

namespace Practicas;
public class Helpers
{
    public static void Llenar(Coleccionable c)
    {
        Random random = new Random();
        for (int i = 0; i < 20; i++)
        {
            c.Agregar(new Numero(random.Next(1, 50)));
        }
    }

    public static void Informar(Coleccionable c)
    {
        Console.Write("Cuantos: ");
        Console.WriteLine(c.Cuantos());
        Console.Write("Minimo: ");
        Console.WriteLine(c.Minimo());
        Console.Write("Maximo: ");
        Console.WriteLine(c.Maximo());
        Console.WriteLine("Ingrese un número a buscar");
        Numero num = new(int.Parse(Console.ReadLine()!));
        if (c.Contiene(num))
        {
            Console.WriteLine($"El elemento {num} está en la selección.");
            Console.WriteLine("----------------------------------------");
        }
        else
        {
            Console.WriteLine($"El elemento {num} no esta en la selección");
            Console.WriteLine("------------------------------------------");
        }
    }

    public static void LlenarPersonas(Coleccionable c)
    {
        Random random = new Random();
        for (int i = 0; i < 20; i++)
        {
            Persona persona = new Persona("Leo", random.Next(38611820, 38611850));
            c.Agregar(persona);
        }
    }
}
