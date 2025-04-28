using Practicas.Interfaces;
using Practicas.Models;

namespace Practicas.FactoryMethod;
public class FabricaDeAlumnos : FabricaDeComparables
{
    public override Comparable CrearAleatorio()
    {
        Random random = new Random();
        GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
        string nombre = generador.StringAleatorio(5);
        int dni = random.Next(18, 30);
        int legajo = random.Next(0, 25);
        float promedio = (float)(random.NextDouble() * 10);
        int calificacion = random.Next(1, 11);
        return new Alumno(nombre, dni, legajo, promedio, calificacion);
    }
}
