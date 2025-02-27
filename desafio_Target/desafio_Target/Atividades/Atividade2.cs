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
            public static bool VerificarSePertence(int numero)
            {
                if (numero == 0 || numero == 1)
                    return true;

                int a = 0, b = 1, soma = 0;

                while (soma < numero)
                {
                    soma = a + b;
                    a = b;      
                    b = soma;
                }

                return soma == numero;
            }
        }
    }
}
