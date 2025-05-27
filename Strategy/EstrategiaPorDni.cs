using Practicas.Interfaces;
using Practicas.Models;
namespace Practicas.Strategy;
public class EstrategiaPorDni : EstrategiaDeComparacion
{
    public bool SosIgual(IAlumno a, IAlumno b)
    {
        return a.GetDni() == b.GetDni();
    }

    public bool SosMenor(IAlumno a, IAlumno b)
    {
        return a.GetDni() < b.GetDni();
    }

    public bool SosMayor(IAlumno a, IAlumno b)
    {
        return a.GetDni() > b.GetDni();
    }
}
