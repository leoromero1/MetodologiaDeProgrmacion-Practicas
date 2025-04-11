using Practicas.Interfaces;
using Practicas.Models;
namespace Practicas.Strategy;
public class EstatategiaPorNombre : EstrategiaDeComparacion
{
    public bool SosIgual(Alumno a, Alumno b)
    {
        return int.Parse(a.GetNombre()) == int.Parse(b.GetNombre());
    }
    public bool SosMenor(Alumno a, Alumno b)
    {
        return int.Parse(a.GetNombre()) < int.Parse(b.GetNombre());
    }
    public bool SosMayor(Alumno a, Alumno b)
    {
        return int.Parse(a.GetNombre()) > int.Parse(b.GetNombre());
    }

}
