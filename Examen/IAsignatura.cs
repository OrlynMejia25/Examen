

namespace Examen
{
    public interface IAsignatura
    {
        double CalcularNotaFinal();
        double CalcularNotaFinal(int no1, int no2, int no3);
        string MensajeNotaFinal(double notaFinal);
        void Imprimir();

    }
}
