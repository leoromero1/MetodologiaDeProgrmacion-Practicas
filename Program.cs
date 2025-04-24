
using Practicas;
using Practicas.FactoryMethod;
using Practicas.Models;
class Program
{
    public static void Main(string[] args)
    {
        Profesor profesor = (Profesor)FabricaDeComparables.CrearAleatorio(3);

        for (int i = 0; i < 20; i++)
        {
            Alumno alumno = (Alumno)FabricaDeComparables.CrearAleatorio(2);
            profesor.AgregarObservador(alumno);
        }
        Console.WriteLine(profesor);
        Helpers.DictadoDeClases(profesor);

    }
}
