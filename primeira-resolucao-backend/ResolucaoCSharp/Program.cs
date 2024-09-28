using System;

namespace ResolucaoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularSoma();
        }

        static void CalcularSoma()
        {
            int INDICE = 12;
            int SOMA = 0;
            int K = 1;

            while (K < INDICE)
            {
                K = K + 1;
                SOMA = SOMA + K;
            }

            Console.WriteLine($"O valor da variável SOMA é: {SOMA}");
        }
    }
}