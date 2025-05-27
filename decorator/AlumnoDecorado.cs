using Practicas.Interfaces;

namespace Practicas.decorator;

public abstract class AlumnoDecorado : IAlumno
{
    private IAlumno Alu;

    public AlumnoDecorado(IAlumno alu)
    {
        Alu = alu;
    }
    public string GetNombre()
    {
        return Alu.GetNombre();
    }
    public int GetDni()
    {
        return Alu.GetDni();
    }
    public int GetLegajo()
    {
        return Alu.GetLegajo();
    }
    public override string ToString()
    {
        return Alu.ToString();
    }
    public bool SosIgual(Comparable c)
    {
        return Alu.SosIgual(c);
    }
    public bool SosMenor(Comparable c)
    {
        return Alu.SosMenor(c);
    }
    public bool SosMayor(Comparable c)
    {
        return Alu.SosMayor(c);
    }
    public void PrestarAtencion()
    {
        Alu.PrestarAtencion();
    }
    public void Distraerse()
    {
        Alu.Distraerse();
    }
    public void Actualizar(Observado o)
    {
        Alu.Actualizar(o);
    }
    public int GetCalificacion()
    {
        return Alu.GetCalificacion();
    }
    public virtual void SetCalificacion(int calificacion)
    {
        Alu.SetCalificacion(calificacion);
    }
    public int ResponderPregunta(int pregunta)
    {
        return Alu.ResponderPregunta(pregunta);
    }
    public virtual string MostrarCalificacion()
    {
        return Alu.MostrarCalificacion();
    }
    public float GetPromedio()
    {
        return Alu.GetPromedio();
    }
}
