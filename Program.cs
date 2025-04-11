using Practicas;
using Practicas.Models;

class Program
{
    public static void Main(string[] args)
    {
        Pila pila = new Pila();
        Cola cola = new Cola();
        ColeccionMultiple coleccion = new ColeccionMultiple(pila, cola);
        Helpers.LlenarPersonas(pila);
        Helpers.LlenarPersonas(cola);
        Console.Write("Coleccion:");
        Helpers.Informar(coleccion);
    }
}
