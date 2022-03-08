namespace AcademiadoProgramadorListadeExercicios5.ConsoleApp
{
    partial class Program
    {
        public class VolumeEsfera
        {
            public int raio;
            public int volumeesfera;

            public double ObterVolumeEsfera()
            {
                double volumeesfera = 4 * 3.14 * raio * raio * raio / 3;

                return volumeesfera;
            }
        }

    }

}