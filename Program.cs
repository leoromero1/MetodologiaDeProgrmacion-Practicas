using Practicas;
using Practicas.Models;

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
    }
}
