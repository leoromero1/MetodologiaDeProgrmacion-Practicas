using Practicas.Interfaces;
using Practicas.Strategy;

namespace Practicas.Models;
public class Alumno : Persona, Observador
{
    private int Legajo;
    private float Promedio;

    private EstrategiaDeComparacion estrategia;

    public Alumno(string nombre, int dni, int legajo, float promedio) : base(nombre, dni)
    {
        Legajo = legajo;
        Promedio = promedio;
        estrategia = new EstatategiaPorNombre();
    }
    public int GetLegajo()
    {
        return Legajo;
    }
    public float GetPromedio()
    {
        return Promedio;
    }
    public void SetEstrategia(EstrategiaDeComparacion e)
    {
        estrategia = e;
    }
    public override string ToString()
    {
        return $"Nombre: {GetNombre()}, DNI: {GetDni()}, Legajo: {GetLegajo()}, Promedio: {GetPromedio():0.00}";
    }


    public override bool SosIgual(Comparable c)
    {
        return estrategia.SosIgual(this, (Alumno)c);
    }
    public override bool SosMenor(Comparable c)
    {
        return estrategia.SosMenor(this, (Alumno)c);
    }
    public override bool SosMayor(Comparable c)
    {
        return estrategia.SosMayor(this, (Alumno)c);
    }

    public void PrestarAtencion()
    {
        Console.WriteLine("Prestando atención");
    }

    public void Distraerse()
    {
        Random random = new Random();
        string[] palabara = ["Mirando el celular", "Dibujando en el margen de la carpeta", "tirando aviones de papel"];
        int i = random.Next(0, palabara.Length);
        Console.WriteLine(palabara[i]);
    }

    public void Actualizar(Observado o)
    {

        if (o is Profesor profesor)
        {
            if (profesor.Actual == "hablar")
                PrestarAtencion();
            else if (profesor.Actual == "escribir")
                Distraerse();
        }
    }
}

