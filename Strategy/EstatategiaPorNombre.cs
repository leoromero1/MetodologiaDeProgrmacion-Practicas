using Practicas.Interfaces;
using Practicas.Models;
namespace Practicas.Strategy;
public class EstatategiaPorNombre : EstrategiaDeComparacion
{
    public bool SosIgual(Alumno a, Alumno b)
    {
        return a.GetNombre() == b.GetNombre();
    }
    public bool SosMenor(Alumno a, Alumno b)
    {
        return string.Compare(a.GetNombre(), b.GetNombre()) < 0;
    }
    public bool SosMayor(Alumno a, Alumno b)
    {
        return string.Compare(a.GetNombre(), b.GetNombre()) > 0;
    }

}
