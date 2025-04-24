
using Practicas;
using Practicas.Models;
using Practicas.Strategy;
class Program
{
    public static void Main(string[] args)
    {
        Pila pila = new Pila();
        Helpers.Llenar(pila, 3);
        Console.WriteLine("Profesores:");
        Helpers.ImprimirDocumentos(pila);
        Console.WriteLine("Estrategia por antigüedad:");
        Helpers.CambiarEstrategiaProfesores(pila, new EstrategiaPorAntiguedad());
        Helpers.Informar(pila, 3);
    }
}
