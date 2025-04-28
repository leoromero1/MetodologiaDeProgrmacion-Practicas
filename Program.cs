using Practicas;
using Practicas.FactoryMethod;
using Practicas.Models;

class Program
{
    public static void Main(string[] args)
    {
        Teacher teacher = new Teacher();
        FabricaDeAlumnos fabrica = new FabricaDeAlumnos();
        for (int i = 0; i < 10; i++)
        {
            Alumno alumno = (Alumno)fabrica.CrearAleatorio();
            AlumnoAdapter adaptado = new AlumnoAdapter(alumno);
            teacher.goToClass(adaptado);
        }
        
        for (int i = 0; i < 10; i++)
        {
            Alumno alumno = (Alumno)fabrica.CrearAleatorio();
            AlumnoMuyEstudioso alumnoEstudioso = new AlumnoMuyEstudioso(
                alumno.GetNombre(),
                alumno.GetDni(),
                alumno.GetLegajo(),
                alumno.GetPromedio(),
                alumno.GetCalificacion()
            );
            AlumnoAdapter adaptado = new AlumnoAdapter(alumnoEstudioso);
            teacher.goToClass(adaptado);
        }

        teacher.teachingAClass();
    }
}
