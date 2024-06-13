// Aula 8 exercicio 3
using System;
class ex3
{
    static void Main()
    {
        while (true)
        {
            int[,] tabela = { { 0, 524, 521, 882 }, { 524, 0, 434, 586 }, { 521, 434, 0, 429 }, { 882, 586, 429, 0 } };
            Console.WriteLine("Digite o número referente a cidade:\n 1. Vitória \n 2. Belo Horizonte\n 3. Rio de Janeiro" +
             " \n 4.São Paulo ");
            int escolha = (int.Parse(Console.ReadLine())) - 1;
            Console.WriteLine("Digite outro: ");
            int escolha2 = (int.Parse(Console.ReadLine())) - 1;

            if (escolha != escolha2)
            {
                int distancia = tabela[escolha, escolha2];
                Console.WriteLine($"Distância é: {distancia}");
            }
            else return;
        }
    }
}