using Practicas.Interfaces;
using Practicas.Models;

namespace Practicas.Strategy;
public class EstrategiaPorLegajo : EstrategiaDeComparacion
{
    public bool SosIgual(Alumno a, Alumno b)
    {
        return a.GetLegajo() == b.GetLegajo();
    }
    public bool SosMenor(Alumno a, Alumno b)
    {
        return a.GetLegajo() < b.GetLegajo();
    }
    public bool SosMayor(Alumno a, Alumno b)
    {
        return a.GetLegajo() > b.GetLegajo();
    }
}
