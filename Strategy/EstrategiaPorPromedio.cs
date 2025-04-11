using Practicas.Interfaces;
using Practicas.Models;
namespace Practicas.Strategy;
public class EstrategiaPorPromedio : EstrategiaDeComparacion
{
    public bool SosIgual(Alumno a, Alumno b)
    {
        return a.GetPromedio() == b.GetPromedio();
    }
    public bool SosMenor(Alumno a, Alumno b)
    {
        return a.GetPromedio() < b.GetPromedio();
    }
    public bool SosMayor(Alumno a, Alumno b)
    {
        return a.GetPromedio() > b.GetPromedio();
    }
}
