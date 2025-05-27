using Practicas.Interfaces;
using Practicas.Models;

namespace Practicas.decorator;

public class DecoradorPorLegajo : AlumnoDecorator
{
    public DecoradorPorLegajo(IAlumno alumno) : base(alumno)
    {
    }

    public override string MostrarCalificacion()
    {

        return $"{Alumno.GetNombre()} ({Alumno.GetLegajo()}/{Alumno.GetCalificacion()})";
    }
}
