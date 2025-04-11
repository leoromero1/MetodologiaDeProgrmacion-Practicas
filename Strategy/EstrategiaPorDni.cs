using Practicas.Interfaces;
using Practicas.Models;
namespace Practicas.Strategy;
public class EstrategiaPorDni : EstrategiaDeComparacion
{
    public bool SosIgual(Alumno a, Alumno b)
    {
        return a.GetDni() == b.GetDni();
    }

    public bool SosMenor(Alumno a, Alumno b)
    {
        return a.GetDni() < b.GetDni();
    }

    public bool SosMayor(Alumno a, Alumno b)
    {
        return a.GetDni() > b.GetDni();
    }
}
