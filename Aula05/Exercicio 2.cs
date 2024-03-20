using System;
class ex_2
{
    static void Main()
    {
        int a, b;

        Console.Write("Insira o valor de A: ");
         a = int.Parse(Console.ReadLine());
        Console.Write("Insira o valor de B: ");
        b = int.Parse(Console.ReadLine());

        if (a%b == 0 || b%a == 0)
        {
            Console.WriteLine("Eles são múltiplos");
        }
        else
        {
            Console.WriteLine("Eles não são múltiplos");
        }

    }
}