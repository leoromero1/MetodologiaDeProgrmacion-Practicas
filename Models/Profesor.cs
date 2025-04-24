namespace Practicas.Models;
public class Profesor : Persona
{
    private int Antiguedad;
    public Profesor(string nombre, int dni, int antiguedad) : base(nombre, dni)
    {
        Antiguedad = antiguedad;
    }

    public static void HablarEnClase()
    {
        Console.WriteLine("Hablando de algun tema");
    }

    public static void EscribirEnElPizarron()
    {
        Console.WriteLine("Escribiendo en el pizarron");
    }
}
