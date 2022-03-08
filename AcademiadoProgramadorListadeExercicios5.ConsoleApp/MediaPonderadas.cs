namespace AcademiadoProgramadorListadeExercicios5.ConsoleApp
{
    partial class Program
    {
        public class MediaPonderadas
        {
            public double nota1;
            public double nota2;

            public double ObterMediaP()
            {
                double mediaharmonica = (nota1 * 10 + nota2 * 10) / (10 + 10);

                return mediaharmonica;
            }
        }
    }
}