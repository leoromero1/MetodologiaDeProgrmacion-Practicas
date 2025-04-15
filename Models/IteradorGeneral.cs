using Practicas.Interfaces;

namespace Practicas.Models;
public class IteradorGeneral : Iterador
{
    private List<Comparable> elementos;
    private int posicionActual;
    public IteradorGeneral(List<Comparable> elementos)
    {
        this.elementos = elementos;
        this.posicionActual = 0;
    }

    public void Primero()
    {
        posicionActual = 0;
    }

    public void Siguiente()
    {
        posicionActual++;
    }
    public bool Fin()
    {
        return posicionActual >= elementos.Count;
    }
    public Comparable Actual()
    {
        return elementos[posicionActual];
    }
}
