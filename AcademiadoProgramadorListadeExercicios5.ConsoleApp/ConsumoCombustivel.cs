namespace AcademiadoProgramadorListadeExercicios5.ConsoleApp
{
    partial class Program
    {
        public class ConsumoCombustivel
        {
            public int kminicial;
            public int kmfinal;
            public int distanciapercorrida;
            public int qtdconsumocombustivel; //Volume gasto de combustivel (l)
            public int consumocombustivel;

            public double ObterConsumoCombustivel()
            {
                double distanciapercorrida = kmfinal - kminicial;

                double consumocombustivel = distanciapercorrida / qtdconsumocombustivel; 

                return consumocombustivel;
            }
        }

    }
}