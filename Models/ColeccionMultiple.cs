using Practicas.Interfaces;

namespace Practicas.Models;
public class ColeccionMultiple : Coleccionable
{
    private Pila Pila;
    private Cola Cola;
    public ColeccionMultiple(Pila pila, Cola cola)
    {
        Pila = pila;
        Cola = cola;
    }
    public int Cuantos()
    {
        return Pila.Cuantos() + Cola.Cuantos();
    }

    public Comparable Minimo()
    {
        Comparable PMinimo = Pila.Minimo();
        Comparable CMinimo = Cola.Minimo();
        return PMinimo.SosMenor(CMinimo) ? PMinimo : CMinimo;
    }

    public Comparable Maximo()
    {
        Comparable PMaximo = Pila.Maximo();
        Comparable CMaximo = Cola.Maximo();
        return PMaximo.SosMayor(CMaximo) ? PMaximo : CMaximo;
    }

    public void Agregar(Comparable c)
    {
    }

    public bool Contiene(Comparable c)
    {
        if (Pila.Contiene(c) || Cola.Contiene(c))
        {
            return true;
        }
        return false;
    }
}
