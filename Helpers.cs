using Practicas.Interfaces;
using Practicas.Models;

namespace Practicas;
public class Helpers
{
    public static void Llenar(Coleccionable c)
    {
        Random random = new Random();
        for (int i = 0; i < 20; i++)
        {
            c.Agregar(new Numero(random.Next(1, 50)));
        }
    }
}
