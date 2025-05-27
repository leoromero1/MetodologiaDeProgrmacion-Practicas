using Practicas.Interfaces;
using Practicas.Models;

namespace Practicas.Strategy;
public class EstrategiaPorLegajo : EstrategiaDeComparacion
{
    public bool SosIgual(IAlumno a, IAlumno b)
    {
        return a.GetLegajo() == b.GetLegajo();
    }
    public bool SosMenor(IAlumno a, IAlumno b)
    {
        return a.GetLegajo() < b.GetLegajo();
    }
    public bool SosMayor(IAlumno a, IAlumno b)
    {
        return a.GetLegajo() > b.GetLegajo();
    }
}
