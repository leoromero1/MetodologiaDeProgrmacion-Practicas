namespace Practicas.Interfaces;
public interface Observado
{
    void AgregarObservador(Observador o);
    void QuitarObservador(Observador o);
    void Notificar();

}
