using System;

namespace AcademiadoProgramadorListadeExercicios5.ConsoleApp
{
    partial class Program
    {
        static void Main(string[] args)
        {

            #region Caixa Retangular

            CaixaRetangular caixa = new CaixaRetangular();

            caixa.comprimento = 15;
            caixa.largura = 15;
            caixa.altura = 15;

            Console.WriteLine("O Volume da caixa é de: {0}", caixa.ObterValorCaixa());

            #endregion

            #region Conversão Fahrenheit
            ConversaoFahrenheit conversaof = new ConversaoFahrenheit();

            conversaof.fahrenheit = 150;
            conversaof.celsius = 0;

            Console.WriteLine("A conversão foi feita e o resultado em Graus Celsius é de: {0}", conversaof.ObrterConversaoF());
            #endregion

            #region Conversão Cilindro
            ConversaoCilindro conversaocili = new ConversaoCilindro();

            conversaocili.raio = 14;
            conversaocili.altura = 3;
            conversaocili.valorcilindro = 0;

            Console.WriteLine("O Volume do Cilindro é de: {0}", conversaocili.ObrterConversaoCili());
            #endregion

            #region Consumo de Combustível
            ConsumoCombustivel consumo = new ConsumoCombustivel();

            consumo.kminicial = 14;
            consumo.kmfinal = 99;
            consumo.distanciapercorrida = 0;
            consumo.qtdconsumocombustivel = 7; //Volume gasto de combustivel (l)
            consumo.consumocombustivel = 0;

            Console.WriteLine("O consumo de combustível por Km é de: {0}", consumo.ObterConsumoCombustivel());
            #endregion

            #region Calcular Volume da Esfera

            VolumeEsfera volumeesfera = new VolumeEsfera();

            volumeesfera.raio = 10;
            volumeesfera.volumeesfera = 0;

            Console.WriteLine("Volume da Esfera é de: {0}", volumeesfera.ObterVolumeEsfera());

            #endregion

            #region Conversão Graus
            ConversaoCelsius conversaoc = new ConversaoCelsius();

            conversaoc.celsius = 30;
            conversaoc.fahrenheit = 0;

            Console.WriteLine("A conversão foi feita e o resultado em Fahrenheit é de: {0}", conversaoc.ObrterConversaoC());
            #endregion

            #region Calcular Salário Total

            CalcSalarioTotal salariototal = new CalcSalarioTotal();

            salariototal.salariobase = 50000;
            salariototal.totaldevendas = 2;
            salariototal.porcentagemcomissao = 3;
            salariototal.salariotot = 0;
            salariototal.divisaoporcentagem = 100;

            Console.WriteLine("Salario base do Vendedor é de: {0}", salariototal.ObterSalarioBase());
            Console.WriteLine("Salario Total do Vendedor é de: {0}", salariototal.ObterSalarioVendedor());

            #endregion

            #region Calcular o Volume da Lata de Óleo

            VolumeLata lata = new VolumeLata();

            lata.raio = 10;
            lata.altura = 10;
            lata.volume = 0;

            Console.WriteLine("Volume da Lata de Óleo é de: {0}", lata.ObrterVolumeLata());
            #endregion

            #region Calcular Médias Harmônicas das notas de um aluno

            MediaHarmonicas harmonica = new MediaHarmonicas();

            harmonica.nota1 = 10;
            harmonica.nota2 = 40;
            harmonica.nota3 = 50;

            Console.WriteLine("Media Harmônica das notas é de: {0}", harmonica.ObterMediaH());

            #endregion

            #region Médias Ponderadas de 2 notas de um aluno

            MediaPonderadas ponderada = new MediaPonderadas();

            ponderada.nota1 = 10;
            ponderada.nota2 = 40;

            Console.WriteLine("Media Ponderada das notas é de: {0}", ponderada.ObterMediaP());

            #endregion

        }
    }
}
