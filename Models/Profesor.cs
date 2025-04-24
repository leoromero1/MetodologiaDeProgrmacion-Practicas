using Practicas.Interfaces;
using Practicas.Strategy;

namespace Practicas.Models;
public class Profesor : Persona
{
    private int Antiguedad;
    private EstrategiaProfesor estrategia;
    public Profesor(string nombre, int dni, int antiguedad) : base(nombre, dni)
    {
        Antiguedad = antiguedad;
        estrategia = new EstrategiaPorAntiguedad();
    }
    public override string ToString()
    {
        return $"Profesor: {GetNombre()}, DNI: {GetDni()}, Antigüedad: {GetAntiguedad()} años";
    }

    public int GetAntiguedad()
    {
        return Antiguedad;
    }
    public void SetEstrategia(EstrategiaProfesor e)
    {
        estrategia = e;
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
