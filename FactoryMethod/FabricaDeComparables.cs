using Practicas.Interfaces;

namespace Practicas.FactoryMethod;

public abstract class FabricaDeComparables
{
    public static Comparable CrearAleatorio(int opcion)
    {
        FabricaDeComparables? fabrica = null;
        switch (opcion)
        {
            case 1: fabrica = new FabricaDeNumeros(); break;
            case 2: fabrica = new FabricaDeAlumnos(); break;
            case 3: fabrica = new FabricaDeProfesores(); break;
        }

        return fabrica!.CrearAleatorio();
    }

    abstract public Comparable CrearAleatorio();
}

