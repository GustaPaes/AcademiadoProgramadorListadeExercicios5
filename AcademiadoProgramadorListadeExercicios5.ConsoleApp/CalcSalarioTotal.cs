namespace AcademiadoProgramadorListadeExercicios5.ConsoleApp
{
    partial class Program
    {
        public class CalcSalarioTotal
        {
            public double salariobase;
            public double totaldevendas;
            public double porcentagemcomissao;
            public double salariotot;
            public double divisaoporcentagem;

            public double ObterSalarioBase()
            {

                return salariobase;
            }
            public double ObterSalarioVendedor()
            {
                double decimalporcentagem = porcentagemcomissao / divisaoporcentagem * totaldevendas;

                salariotot = salariobase * decimalporcentagem;

                salariotot = salariotot + salariobase;


                return salariotot;
            }
        }
    }
}