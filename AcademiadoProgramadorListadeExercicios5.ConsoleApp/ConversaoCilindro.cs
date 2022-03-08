namespace AcademiadoProgramadorListadeExercicios5.ConsoleApp
{
    public class ConversaoCilindro
    {
        public int raio;
        public int altura;
        public int valorcilindro;

        public double ObrterConversaoCili()
        {
            double valorcilindro = 3.14159 * raio * raio * altura;

            return valorcilindro;
        }
    }

}