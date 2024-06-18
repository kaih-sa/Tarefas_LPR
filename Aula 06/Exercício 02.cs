// Aula 06 andery ex2

using System;
class ex2
{
    static void Main()
    {
        int chute;
        Random num_aleatorio = new Random();
        int valor = num_aleatorio.Next(1,100);

         do
        {
            Console.Write("Chute um número de 1 a 100: ");
            chute = int.Parse(Console.ReadLine());

               if (chute >= (valor + 1))
               {
                  Console.WriteLine("Chutou alto!");
                }
               else if (chute <= (valor - 1))
               {
                   Console.WriteLine("Chutou baixo!");
               }

        }while (chute != valor);

        Console.WriteLine("Acertou!");
    }
       
}