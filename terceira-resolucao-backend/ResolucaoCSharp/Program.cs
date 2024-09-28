using System;
using System.Collections.Generic;
using System.Linq;

namespace ResolucaoCSharp
{

    public class Program
    {
        static void Main(string[] args)

        {
            int[] faturamento = { 1000, 1500, 0, 2000, 1200, 0, 1800 };

            var resultado = AnalisarFaturamento(faturamento);

            Console.WriteLine($"Menor valor: {resultado.MenorValor}");
            Console.WriteLine($"Maior valor: {resultado.MaiorValor}");
            Console.WriteLine($"Média anual: {resultado.MediaAnual}");
            Console.WriteLine($"Dias acima da média: {resultado.DiasAcimaMedia}");
        }

        static (int MenorValor, int MaiorValor, double MediaAnual, int DiasAcimaMedia) AnalisarFaturamento(int[] faturamento)
        {
            int menorValor = int.MaxValue;
            int maiorValor = int.MinValue;
            int somaTotal = 0;
            int diasComFaturamento = 0;
            int diasAcimaMedia = 0;

            foreach (int valor in faturamento)
            {
                if (valor > 0)
                {
                    somaTotal += valor;
                    diasComFaturamento++;
                    menorValor = Math.Min(menorValor, valor);
                    maiorValor = Math.Max(maiorValor, valor);
                }
            }

            double mediaAnual = (double)somaTotal / diasComFaturamento;

            foreach (int valor in faturamento)
            {
                if (valor > mediaAnual)
                {
                    diasAcimaMedia++;
                }
            }

            return (menorValor, maiorValor, mediaAnual, diasAcimaMedia);
        }
    }
}