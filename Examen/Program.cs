using Examen;

Asignatura asignatura = new Asignatura();

try
{
   
    Console.Write("Ingrese nombre del alumno: ");
    asignatura.NombreAlumno = Console.ReadLine();

    Console.Write("Ingrese número de cuenta: ");
    asignatura.NumeroCuenta = Console.ReadLine();

    Console.Write("Ingrese correo electrónico: ");
    asignatura.Email = Console.ReadLine();


    Console.Write("Ingrese nombre de la clase: ");
    asignatura.NombreAsignatura = Console.ReadLine();

    Console.Write("Ingrese horario de la clase: ");
    asignatura.Horario = Console.ReadLine();

    Console.Write("Ingrese nombre del docente: ");
    asignatura.NombreDocente = Console.ReadLine();

    
    asignatura.N1 = LeerNotaValida(30, "primer");
    asignatura.N2 = LeerNotaValida(30, "segundo");
    asignatura.N3 = LeerNotaValida(40, "tercer");

    
    asignatura.Imprimir();
}
catch (FormatException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ocurrió un error inesperado: {ex.Message}");
}

static int LeerNotaValida(int maxNota, string parcial)
{
    int nota;
    while (true)
    {
        try
        {
            Console.Write($"Ingrese la nota del {parcial} parcial: ");
            nota = int.Parse(Console.ReadLine());

            if (nota < 0 || nota > maxNota)
            {
                Console.WriteLine($"La nota del {parcial} parcial no puede superar el {maxNota}%");
            }
            else
            {
                break;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Una de las notas ingresadas no tiene el formato válido.");
        }
    }
    return nota;
}
