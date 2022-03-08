namespace AcademiadoProgramadorListadeExercicios5.ConsoleApp
{
    public class CaixaRetangular
    {
        public int altura;
        public int largura;
        public int comprimento;

        public double ObterValorCaixa()
        {
            double volume = altura * largura * comprimento;

            return volume;
        }
    }
}