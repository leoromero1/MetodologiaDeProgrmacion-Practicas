
using Practicas.Interfaces;

namespace Practicas.decorator;

public class DecoradorConLetras : AlumnoDecorator
{
    public DecoradorConLetras(IAlumno alumno) : base(alumno)
    {

    }
    public override string MostrarCalificacion()
    {
        string[] letras = { "CERO", "UNO", "DOS", "TRES", "CUATRO", "CINCO", "SEIS", "SIETE", "OCHO", "NUEVE", "DIEZ" };
        return $"{base.MostrarCalificacion()} ({letras[GetCalificacion()]})";
    }
}