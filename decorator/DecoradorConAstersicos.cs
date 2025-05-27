using Practicas.Interfaces;
namespace Practicas.decorator;

public class DecoradorConAstersicos : AlumnoDecorator
{
    public DecoradorConAstersicos(IAlumno alumno) : base(alumno)
    {
    }
    public override string MostrarCalificacion()
    {
        return "********************************************" + "\n"
              + "* " + base.MostrarCalificacion() + " *" + "\n"
              + "********************************************";
    }
}
