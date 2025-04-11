using Practicas.Interfaces;
using Practicas.Strategy;

namespace Practicas.Models;
public class Alumno : Persona
{
    private int Legajo;
    private float Promedio;

    private EstrategiaDeComparacion estrategia;

    public Alumno(string nombre, int dni, int legajo, float promedio) : base(nombre, dni)
    {
        Legajo = legajo;
        Promedio = promedio;
        estrategia = new EstrategiaPorDni();
    }
    public int GetLegajo()
    {
        return Legajo;
    }
    public float GetPromedio()
    {
        return Promedio;
    }
    public void SetEstrategia(EstrategiaDeComparacion e)
    {
        estrategia = e;
    }

    public override bool SosIgual(Comparable c)
    {
        return estrategia.SosIgual(this, (Alumno)c);
    }
    public override bool SosMenor(Comparable c)
    {
        return estrategia.SosMenor(this, (Alumno)c);
    }
    public override bool SosMayor(Comparable c)
    {
        return estrategia.SosMayor(this, (Alumno)c);
    }
}
