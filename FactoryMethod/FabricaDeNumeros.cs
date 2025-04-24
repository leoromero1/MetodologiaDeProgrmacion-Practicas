using Practicas.Interfaces;
using Practicas.Models;

namespace Practicas.FactoryMethod;
public class FabricaDeNumeros : FabricaDeComparables
{
    public override Comparable CrearAleatorio()
    {
        Random random = new Random();
        int numeroAleatorio = random.Next(1, 100);
        return new Numero(numeroAleatorio);
    }
}
