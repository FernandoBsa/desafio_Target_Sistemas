using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_Target.Atividades
{
    public class Atividade2
    {
        public static class Fibonacci
        {
            // Método para verificar se um número pertence à sequência de Fibonacci
            public static bool VerificarSePertence(int numero)
            {
                // Caso o número seja 0 ou 1, pertence à sequência
                if (numero == 0 || numero == 1)
                    return true;

                int a = 0, b = 1, soma = 0;

                // Gera a sequência de Fibonacci até que soma >= numero
                while (soma < numero)
                {
                    soma = a + b; // Próximo número da sequência
                    a = b;        // Atualiza os valores
                    b = soma;
                }

                // Verifica se o número informado é igual à soma gerada
                return soma == numero;
            }
        }
    }
}
