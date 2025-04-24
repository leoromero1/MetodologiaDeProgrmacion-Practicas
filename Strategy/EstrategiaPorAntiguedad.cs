using Practicas.Interfaces;
using Practicas.Models;

namespace Practicas.Strategy
{
    public class EstrategiaPorAntiguedad : EstrategiaProfesor
    {
        public bool SosIgual(Profesor a, Profesor b)
        {
            return a.GetAntiguedad() == b.GetAntiguedad();
        }
        public bool SosMenor(Profesor a, Profesor b)
        {
            return a.GetAntiguedad() == b.GetAntiguedad();
        }
        public bool SosMayor(Profesor a, Profesor b)
        {
            return a.GetAntiguedad() == b.GetAntiguedad();
        }
    }
}