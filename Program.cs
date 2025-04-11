using Practicas;
using Practicas.Models;

class Program
{
    public static void Main(string[] args)
    {
        Pila pila = new Pila();
        Cola cola = new Cola();
        Helpers.Llenar(pila);
        Helpers.Llenar(cola);
        Console.Write("PILA:");
        Helpers.Informar(pila);
        Console.Write("Cola:");
        Helpers.Informar(cola);
    }
}
