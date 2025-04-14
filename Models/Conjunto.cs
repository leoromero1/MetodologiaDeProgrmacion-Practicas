using Practicas.Interfaces;

namespace Practicas.Models;

public class Conjunto
{
    private List<Comparable> elementos;

    public Conjunto()
    {
        elementos = new List<Comparable>();
    }

    public bool Pertenece(Comparable c)
    {
        foreach (Comparable item in elementos)
        {
            if (item.SosIgual(c)) return true;
        }
        return false;
    }

    public void Agregar(Comparable c)
    {
        if (!Pertenece(c))
        {
            elementos.Add(c);
        }
    }
}