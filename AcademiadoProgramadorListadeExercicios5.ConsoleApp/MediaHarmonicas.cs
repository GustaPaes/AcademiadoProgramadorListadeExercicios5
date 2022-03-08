namespace AcademiadoProgramadorListadeExercicios5.ConsoleApp
{
    partial class Program
    {
        public class MediaHarmonicas
        {
            public double nota1;
            public double nota2;
            public double nota3;

            public double ObterMediaH()
            {
                double mediaharmonica = 3 / ((1 / nota1) + (1 / nota2) + (1 / nota3));

                return mediaharmonica;
            }
        }

    }
}