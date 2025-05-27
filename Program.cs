using Practicas;
using Practicas.decorator;
using Practicas.FactoryMethod;
using Practicas.Interfaces;
using Practicas.Models;

class Program
{
    public static void Main(string[] args)
    {
        Teacher teacher = new Teacher();
        FabricaDeAlumnos fabrica = new FabricaDeAlumnos();

        for (int i = 0; i < 10; i++)
        {
            IAlumno alumno = (IAlumno)fabrica.CrearAleatorio();
            IAlumno decorador = new DecoradorPorLegajo(alumno);
            IAlumno decorador2 = new DecoradorConLetras(decorador);
            IAlumno decorador3 = new DecoradoPorPromocion(decorador2);
            IAlumno decorador4 = new DecoradorConAstersicos(decorador3);
            Student student = new AlumnoAdapter(decorador4);

            teacher.goToClass(student);
        }

        teacher.teachingAClass();
    }
}
