namespace Practicas.Models;
public class Alumno : Persona
{
    private int Legajo;
    private float Promedio;

    public Alumno(string nombre, int dni, int legajo, float promedio) : base(nombre, dni)
    {
        Legajo = legajo;
        Promedio = promedio;
    }
    public int GetLegajo()
    {
        return Legajo;
    }
    public float GetPromedio()
    {
        return Promedio;
    }
}
