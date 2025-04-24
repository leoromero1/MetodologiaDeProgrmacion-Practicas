using Practicas.Interfaces;
using Practicas.Models;

namespace Practicas.FactoryMethod;
public class FabricaDeProfesores : FabricaDeComparables
{
    public override Comparable CrearAleatorio()
    {
        GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
        Random random = new Random();
        int dni = random.Next(10000000, 99999999);
        int antiguedad = random.Next(1, 10);
        string nombre = generador.StringAleatorio(antiguedad);
        return new Profesor(nombre, dni, antiguedad);
    }
}
