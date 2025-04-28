namespace Practicas.Models;
public class AlumnoAdapter : Student
{
    private Alumno Alumno;

    public AlumnoAdapter(Alumno alumno)
    {
        Alumno = alumno;
    }

    public string getName()
    {
        return Alumno.GetNombre();
    }
    public int yourAnswerIs(int question)
    {
        return Alumno.ResponderPregunta(question);
    }
    public void setScore(int score)
    {

    }
    public string showResult()
    {
        return Alumno.MostrarCalificacion();
    }
    public bool equals(Student student)
    {
        return Alumno.SosIgual(((AlumnoAdapter)student).Alumno);
    }
    public bool lessThan(Student student)
    {
        return Alumno.SosMenor(((AlumnoAdapter)student).Alumno);
    }
    public bool greaterThan(Student student)
    {
        return Alumno.SosMayor(((AlumnoAdapter)student).Alumno);
    }
}