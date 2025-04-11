using Practicas;
using Practicas.Models;

class Program
{
    public static void Main(string[] args)
    {
        Pila pila = new Pila();
        Cola cola = new Cola();
        ColeccionMultiple coleccion = new ColeccionMultiple(pila, cola);
        Helpers.Llenar(pila);
        Helpers.Llenar(cola);
        Console.Write("PILA:");
        Helpers.Informar(pila);
        Console.Write("Cola:");
        Helpers.Informar(cola);
        Console.Write("Coleccion:");
        Helpers.Informar(coleccion);

    }
}
