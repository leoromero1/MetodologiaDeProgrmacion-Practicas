namespace Practicas.Models;
public class LectorDeDatos
{
    public int NumeroPorteclado()
    {
        Console.WriteLine("Ingrese un numero: ");
        int numero = int.Parse(Console.ReadLine()!);
        return numero;
    }

    public string TextoPorteclado()
    {
        Console.WriteLine("Ingrese un texto: ");
        string texto = Console.ReadLine()!;
        return texto;
    }
}
