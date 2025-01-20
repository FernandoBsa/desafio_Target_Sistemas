using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_Target.Atividades
{
    public class Atividade4
    {
        public void ExibirPercentuais(Dictionary<string, decimal> faturamentoPorEstado)
        {
            decimal faturamentoTotal = faturamentoPorEstado.Values.Sum();

            Console.WriteLine("Percentual de representação por estado:\n");
            foreach (var (estado, faturamento) in faturamentoPorEstado)
            {
                decimal percentual = CalcularPercentual(faturamento, faturamentoTotal);
                Console.WriteLine($"{estado}: {percentual:F2}%");
            }
        }

        private decimal CalcularPercentual(decimal faturamento, decimal faturamentoTotal)
        {
            return (faturamento / faturamentoTotal) * 100;
        }
    }
}
