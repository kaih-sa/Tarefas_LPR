
using System;
class exercicio03
{
    static void Main()
    {
        Console.WriteLine("Digite o número referente a sua opção de classe de personagem:\n 1- Guerreira;\n 2- Mago;\n 3- Arqueira");
        int opcao = int.Parse(Console.ReadLine());

         switch (opcao) 
        {
            case 1:
                Console.WriteLine("Suas habilidades são: Ataque Pesado e Defesa Total");
                break;

            case 2:
                Console.WriteLine("Suas habilidades são: Bola de Fogo e Escudo de Gelo");
                break;

             case 3:
                Console.WriteLine("Suas habilidades são: Flecha Precisa e Disparo Triplo");
                break;
        }

    }
}