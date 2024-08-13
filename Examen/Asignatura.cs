
namespace Examen
{
    public class Asignatura : Alumno, IAsignatura
    {
        public int N1;
        public int N2;
        public int N3;

        public string NombreAsignatura { get; set; }
        public string Horario { get; set; }
        public string NombreDocente { get; set; }

        public double CalcularNotaFinal()
        {
            return N1 + N2 + N3;
        }

        public double CalcularNotaFinal(int no1, int no2, int no3)
        {
            return no1 + no2 + no3;
        }

        public string MensajeNotaFinal(double notaFinal)
        {
            if (notaFinal <= 59)
                return "Reprobado";
            else if (notaFinal >= 60 && notaFinal <= 79)
                return "Bueno";
            else if (notaFinal >= 80 && notaFinal <= 89)
                return "Muy Bueno";
            else
                return "Sobresaliente";
        }

        public void Imprimir()
        {
            Console.WriteLine($"Nombre del alumno: {NombreAlumno}");
            Console.WriteLine($"Número de cuenta: {NumeroCuenta}");
            Console.WriteLine($"Correo electrónico: {Email}");
            Console.WriteLine($"Nombre de la Clase: {NombreAsignatura}");
            Console.WriteLine($"Horario: {Horario}");
            Console.WriteLine($"Nombre del docente: {NombreDocente}");

            double notaFinal1 = CalcularNotaFinal();
            double notaFinal2 = CalcularNotaFinal(N1, N2, N3);

            Console.WriteLine($"Nota final: {notaFinal1}% - {MensajeNotaFinal(notaFinal1)}");
        }
    }
}
