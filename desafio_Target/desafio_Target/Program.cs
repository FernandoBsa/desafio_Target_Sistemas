using desafio_Target.Atividade_1;
using desafio_Target.Atividades;
using static desafio_Target.Atividades.Atividade2;

namespace desafio_Target
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Atividade - 1

            //Atividade1 atividade = new Atividade1();
            //Console.WriteLine("Resultado: " + atividade.SomaIndice());

            //Atividade - 2

            //Console.WriteLine("Digite um número para verificar se pertence à sequência de Fibonacci:");
            //if (int.TryParse(Console.ReadLine(), out int numero))
            //{
            //    bool pertence = Fibonacci.VerificarSePertence(numero);
            //    if (pertence)
            //    {
            //        Console.WriteLine($"O número {numero} pertence a sequência de Fibonacci.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"O número {numero} não pertence a sequência de Fibonacci.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Por favor, insira um número válido.");
            //}

            //Atividade - 3

            string caminhoArquivo = "faturamento.json";

            var faturamentos = FaturamentoService.CarregarFaturamentoDeArquivo(caminhoArquivo);

            decimal menorFaturamento = FaturamentoService.CalcularMenorFaturamento(faturamentos);
            decimal maiorFaturamento = FaturamentoService.CalcularMaiorFaturamento(faturamentos);
            decimal mediaFaturamento = FaturamentoService.CalcularMediaFaturamento(faturamentos);
            decimal mediaFaturamentoArredondada = Math.Round(mediaFaturamento, 1);
            int diasAcimaDaMedia = FaturamentoService.CalcularDiasAcimaDaMedia(faturamentos, mediaFaturamento);

            Console.WriteLine($"Menor faturamento: {menorFaturamento}");
            Console.WriteLine($"Maior faturamento: {maiorFaturamento}");
            Console.WriteLine($"Média de faturamento: {mediaFaturamentoArredondada}");
            Console.WriteLine($"Número de dias acima da média: {diasAcimaDaMedia}");

            //Atividade - 4 

            //Dictionary<string, decimal> faturamentoPorEstado = new Dictionary<string, decimal>
            //{
            //    { "SP", 67836.43m },
            //    { "RJ", 36678.66m },
            //    { "MG", 29229.88m },
            //    { "ES", 27165.48m },
            //    { "Outros", 19849.53m }
            //};

            //Atividade4 faturamentoService = new Atividade4();
            //faturamentoService.ExibirPercentuais(faturamentoPorEstado);
            //Console.ReadLine();

            //Atividade - 5 

            //string normal = "Exemplo de String";

            //string stringInvertida = "";

            
            //for (int i = normal.Length - 1; i >= 0; i--)
            //{
            //    stringInvertida += normal[i];
            //}
            //Console.WriteLine("String normal: " + normal);
            //Console.WriteLine("String invertida: " + stringInvertida);
        }

    }
}
