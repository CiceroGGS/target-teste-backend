using System;

namespace ResolucaoCSharp
{
    class Program
    {
        static int DescobrirProximoElemento(List<int> sequencia, char nome)
        {
            int proximo = 0;

            switch (nome)
            {
                case 'a':
                    if (sequencia.Select((num, index) => index == 0 || num == sequencia[index - 1] + 2).All(x => x))
                        proximo = sequencia.Last() + 2;
                    break;
                case 'b':
                    proximo = sequencia.Last() * 2;
                    break;
                case 'c':
                    proximo = (int)Math.Pow(sequencia.Count, 2);
                    break;
                case 'd':
                    proximo = (int)Math.Pow((sequencia.Count + 1) * 2, 2);
                    break;
                case 'e':
                    proximo = sequencia.Last() + sequencia[sequencia.Count - 2];
                    break;
                case 'f':
                    proximo = sequencia.Last() + 1;
                    break;
                default:
                    return -1; // Sequência não reconhecida
            }

            return proximo;
        }

        static void Main()
        {
            Dictionary<char, List<int>> sequencias = new Dictionary<char, List<int>>()
        {
            { 'a', new List<int> { 1, 3, 5, 7 } },
            { 'b', new List<int> { 2, 4, 8, 16, 32, 64 } },
            { 'c', new List<int> { 0, 1, 4, 9, 16, 25, 36 } },
            { 'd', new List<int> { 4, 16, 36, 64 } },
            { 'e', new List<int> { 1, 1, 2, 3, 5, 8 } },
            { 'f', new List<int> { 2, 10, 12, 16, 17, 18, 19 } }
        };

            foreach (var sequencia in sequencias)
            {
                int proximo = DescobrirProximoElemento(sequencia.Value, sequencia.Key);
                Console.WriteLine($"{sequencia.Key}) {string.Join(", ", sequencia.Value)}, próximo: {proximo}");
            }
        }
    }
}