using Practicas.Interfaces;
using Practicas.Models;
namespace Practicas.Strategy;
public class EstrategiaPorPromedio : EstrategiaDeComparacion
{
    public bool SosIgual(IAlumno a, IAlumno b)
    {
        return a.GetPromedio() == b.GetPromedio();
    }
    public bool SosMenor(IAlumno a, IAlumno b)
    {
        return a.GetPromedio() < b.GetPromedio();
    }
    public bool SosMayor(IAlumno a, IAlumno b)
    {
        return a.GetPromedio() > b.GetPromedio();
    }
}
