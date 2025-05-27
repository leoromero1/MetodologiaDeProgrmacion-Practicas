using Practicas.Interfaces;
using Practicas.Models;
namespace Practicas.Strategy;
public class EstatategiaPorNombre : EstrategiaDeComparacion
{
    public bool SosIgual(IAlumno a, IAlumno b)
    {
        return a.GetNombre() == b.GetNombre();
    }
    public bool SosMenor(IAlumno a, IAlumno b)
    {
        return string.Compare(a.GetNombre(), b.GetNombre()) < 0;
    }
    public bool SosMayor(IAlumno a, IAlumno b)
    {
        return string.Compare(a.GetNombre(), b.GetNombre()) > 0;
    }

}
