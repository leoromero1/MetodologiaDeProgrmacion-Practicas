using Practicas.Models;

namespace Practicas.Interfaces;

public interface EstrategiaDeComparacion
{
    bool SosIgual(Alumno a1, Alumno a2);
    bool SosMenor(Alumno a1, Alumno a2);
    bool SosMayor(Alumno a1, Alumno a2);
}