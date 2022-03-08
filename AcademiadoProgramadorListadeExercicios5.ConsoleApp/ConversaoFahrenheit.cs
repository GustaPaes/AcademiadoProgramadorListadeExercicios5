namespace AcademiadoProgramadorListadeExercicios5.ConsoleApp
{
    partial class Program
    {
        public class ConversaoFahrenheit
        {
            public int fahrenheit;
            public int celsius;

            public double ObrterConversaoF()
            {
                double celsius = fahrenheit - 32;
                celsius = celsius / 1.8;

                return celsius;
            }
        }
    }
}

