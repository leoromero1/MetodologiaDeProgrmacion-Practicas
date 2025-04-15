using Practicas;
using Practicas.Models;
using Practicas.Strategy;

class Program
{
    public static void Main(string[] args)
    {
        Pila pila = new Pila();
        Cola cola = new Cola();
        Conjunto conjunto = new Conjunto();
        Helpers.LlenarAlumnos(pila);
        Helpers.LlenarAlumnos(cola);
        Helpers.LlenarAlumnos(conjunto);
        Console.WriteLine("Documentos de Pila:");
        Helpers.ImprimirDocumentos(pila);
        Console.WriteLine("Documentos de Cola:");
        Helpers.ImprimirDocumentos(cola);
        Console.WriteLine("Documentos de Conjunto:");
        Helpers.ImprimirDocumentos(conjunto);
        Console.WriteLine("Cambiando estrategia a EstrategiaPorDni...");
        Helpers.CambiarEstrategia(pila, new EstrategiaPorDni());
        Console.WriteLine("Con estrategia por DNI:");
        Helpers.Informar(pila);
        Console.WriteLine("Cambiando estrategia a EstrategiaPorPromedio...");
        Helpers.CambiarEstrategia(pila, new EstrategiaPorPromedio());
        Console.WriteLine("Con estrategia por Promedio:");
        Helpers.Informar(pila);
    }
}
