using Practicas.Interfaces;

namespace Practicas.decorator;

public abstract class AlumnoDecorator : IAlumno
{
    protected IAlumno Alumno;
    public AlumnoDecorator(IAlumno alumno)
    {
        Alumno = alumno;
    }

    public bool SosIgual(Comparable c)
    {
        return Alumno.SosIgual(c);
    }
    public bool SosMayor(Comparable c)
    {
        return Alumno.SosMayor(c);
    }
    public bool SosMenor(Comparable c)
    {
        return Alumno.SosMenor(c);
    }
    public int GetCalificacion()
    {
        return Alumno.GetCalificacion();
    }
    public void SetCalificacion(int nuevaCalificacion)
    {
        Alumno.SetCalificacion(nuevaCalificacion);
    }
    public int ResponderPregunta(int pregunta)
    {
        return Alumno.ResponderPregunta(pregunta);
    }
    public virtual string MostrarCalificacion()
    {
        return Alumno.MostrarCalificacion();
    }
    public int GetLegajo()
    {
        return Alumno.GetLegajo();
    }

    public void PrestarAtencion()
    {
        Alumno.PrestarAtencion();
    }
    public void Distraerse()
    {
        Alumno.Distraerse();
    }
    public void Actualizar(Observado o)
    {
        Alumno.Actualizar(o);
    }

    public string GetNombre()
    {
        return Alumno.GetNombre();
    }
    public int GetDni()
    {
        return Alumno.GetDni();
    }
    public float GetPromedio()
    {
        return Alumno.GetPromedio();
    }
    public override string ToString()
    {
        return Alumno.ToString();
    }
}
