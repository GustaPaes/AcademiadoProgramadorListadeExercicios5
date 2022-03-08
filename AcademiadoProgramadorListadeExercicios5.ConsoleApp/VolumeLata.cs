namespace AcademiadoProgramadorListadeExercicios5.ConsoleApp
{
    partial class Program
    {
        public class VolumeLata
        {
            public double raio, altura, volume;

            public double ObrterVolumeLata()
            {

                volume = 3.14159 * raio * raio * altura;

                return volume;
            }
        }
    }
}