using Practicas.Interfaces;

namespace Practicas.Models;

public abstract class FabricaDeComparables
{
    public static Comparable CrearAleatorio(int opcion)
    {
        if (opcion == 1)
        {
            GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
            return new Numero(generador.NumeroAleatorio(100));
        }
        else
        {
            throw new ArgumentException("Opción no válida");
        }
    }

    public static Comparable CrearPorTeclado(int opcion)
    {
        if (opcion == 1)
        {
            return new Numero(LectorDeDatos.NumeroPorteclado());
        }
        else
        {
            throw new ArgumentException("Opción no válida");
        }
    }
}

