using Practicas;
using Practicas.Models;
using Practicas.Strategy;

class Program
{
    public static void Main(string[] args)
    {
        GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
        int numeroAleatorio = generador.NumeroAleatorio(10);
        Console.WriteLine($"numeroAleatorio: {numeroAleatorio}");
        string cadenaAleatoria = generador.stringAleatorio(numeroAleatorio);
        Console.WriteLine($"cadenaAleatoria: {cadenaAleatoria}");
    }
}
