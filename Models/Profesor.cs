using Practicas.Interfaces;
using Practicas.Strategy;

namespace Practicas.Models;
public class Profesor : Persona, Observado
{
    private int Antiguedad;
    private EstrategiaProfesor estrategia;
    private List<Observador> Observadores = new List<Observador>();
    public string? Actual {get; private set;}
    public Profesor(string nombre, int dni, int antiguedad) : base(nombre, dni)
    {
        Antiguedad = antiguedad;
        estrategia = new EstrategiaPorAntiguedad();

    }
    public override string ToString()
    {
        return $"Profesor: {GetNombre()}, DNI: {GetDni()}, Antigüedad: {GetAntiguedad()} años";
    }

    public int GetAntiguedad()
    {
        return Antiguedad;
    }
    public void SetEstrategia(EstrategiaProfesor e)
    {
        estrategia = e;
    }

    public void HablarEnClase()
    {
        Actual = "hablar";
        Console.WriteLine("Hablando de algun tema");
        Notificar();
    }

    public void EscribirEnElPizarron()
    {
        Actual = "escribir";
        Console.WriteLine("Escribiendo en el pizarron");
        Notificar();
    }

    public void AgregarObservador(Observador o)
    {
        Observadores.Add(o);
    }

    public void QuitarObservador(Observador o)
    {
        Observadores.Remove(o);
    }
    public void Notificar()
    {
        foreach (var observador in Observadores)
        {
            observador.Actualizar(this);
        }
    }
}
