namespace desafio_Target.Atividade_1
{
    public class Atividade1
    {
        public int SomaIndice()
        {
            int INDICE = 13, SOMA = 0, K = 0;

            while (K < INDICE)
            {
                K++;
                SOMA += K;
            }

            return SOMA;
        }
    }
}
