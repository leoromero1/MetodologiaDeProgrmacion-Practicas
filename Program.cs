
using Practicas;
using Practicas.Models;
class Program
{
    public static void Main(string[] args)
    {
        Pila pila = new Pila();
        Console.WriteLine("Pila: ");
        Helpers.Llenar(pila, 2);
        Helpers.Informar(pila, 2);
    }
}
