using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace desafio_Target.Atividades
{
    public class Atividade3
    {
        public int Dia { get; set; }
        public decimal Faturamento { get; set; }
    }

    public class FaturamentoService
    {
        public static List<Atividade3> CarregarFaturamentoDeArquivo(string caminhoArquivo)
        {
            var jsonData = File.ReadAllText(caminhoArquivo);
            return JsonConvert.DeserializeObject<List<Atividade3>>(jsonData);
        }

        public static decimal CalcularMenorFaturamento(List<Atividade3> faturamentos)
        {
            return faturamentos.Where(f => f.Faturamento > 0)
                               .Min(f => f.Faturamento);
        }

        public static decimal CalcularMaiorFaturamento(List<Atividade3> faturamentos)
        {
            return faturamentos.Where(f => f.Faturamento > 0)
                               .Max(f => f.Faturamento);
        }

        public static decimal CalcularMediaFaturamento(List<Atividade3> faturamentos)
        {
            var faturamentosValidos = faturamentos.Where(f => f.Faturamento > 0).ToList();
            return faturamentosValidos.Average(f => f.Faturamento);
        }

        public static int CalcularDiasAcimaDaMedia(List<Atividade3> faturamentos, decimal media)
        {
            return faturamentos.Count(f => f.Faturamento > media);
        }
    }
}
